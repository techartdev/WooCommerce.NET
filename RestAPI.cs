using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;
using WooCommerce.NET.Resolvers;

namespace WooCommerce.NET
{
    public class RestApi
    {
        protected string WcUrl { get; set; }

        public string WcKey { get; set; }

        public string WcSecret { get; set; }

        protected bool AuthorizedHeader { get; set; }

        protected Func<string, string> JsonSerializeFilter { get; set; }

        protected Func<string, string> JsonDeserializeFilter { get; set; }

        protected Action<HttpWebRequest> WebRequestFilter { get; set; }

        protected Action<HttpWebResponse> WebResponseFilter { get; set; }

        /// <summary>
        /// For WordPress REST API with OAuth 1.0 ONLY
        /// </summary>
        public string OauthToken { get; set; }

        /// <summary>
        /// For WordPress REST API with OAuth 1.0 ONLY
        /// </summary>
        public string OauthTokenSecret { get; set; }

        public WpJwtObject JwtObject { get; set; }

        /// <summary>
        /// Authenticate WooCommerce API with JWT when set to True
        /// </summary>
        public bool WcAuthWithJwt { get; set; }

        /// <summary>
        /// Provide a function to modify the json string before deserializing, this is for JWT Token ONLY!
        /// </summary>
        public Func<string, string> JwtDeserializeFilter { get; set; }

        /// <summary>
        /// Provide a function to modify the HttpWebRequest object, this is for JWT Token ONLY!
        /// </summary>
        public Action<HttpWebRequest> JwtRequestFilter { get; set; }

        /// <summary>
        /// If running in Debug mode, default is False.
        /// NOTE: Beware when setting Debug to True, as exceptions might contain sensitive information.
        /// </summary>
        public bool Debug { get; set; }

        /// <summary>
        /// Initialize the RestAPI object
        /// </summary>
        /// <param name="url">
        /// WooCommerce REST API URL, e.g.: http://yourstore/wp-json/wc/v1/ 
        /// WordPress REST API URL, e.g.: http://yourstore/wp-json/
        /// </param>
        /// <param name="key">WooCommerce REST API Key Or WordPress consumerKey</param>
        /// <param name="secret">WooCommerce REST API Secret Or WordPress consumerSecret</param>
        /// <param name="authorizedHeader">WHEN using HTTPS, do you prefer to send the Credentials in HTTP HEADER?</param>
        /// <param name="jsonSerializeFilter">Provide a function to modify the json string after serializing.</param>
        /// <param name="jsonDeserializeFilter">Provide a function to modify the json string before deserializing.</param>
        /// <param name="requestFilter">Provide a function to modify the HttpWebRequest object.</param>
        /// <param name="responseFilter">Provide a function to grab information from the HttpWebResponse object.</param>
        public RestApi(string url, string key, string secret, bool authorizedHeader = true,
                            Func<string, string> jsonSerializeFilter = null,
                            Func<string, string> jsonDeserializeFilter = null,
                            Action<HttpWebRequest> requestFilter = null,
                            Action<HttpWebResponse> responseFilter = null)//, bool useProxy = false)
        {
            if (string.IsNullOrEmpty(url))
                throw new Exception("Please use a valid WooCommerce Restful API url.");

            string urlLower = url.Trim().ToLower().TrimEnd('/');

            if (urlLower.EndsWith("wp-json/wc/v3"))
                Version = ApiVersion.Version3;
            else if (urlLower.Contains("wp-json/wc-"))
                Version = ApiVersion.ThirdPartyPlugins;
            else if (urlLower.EndsWith("wp-json/wp/v2") || urlLower.EndsWith("wp-json"))
                Version = ApiVersion.WordPressAPI;
            else if (urlLower.EndsWith("jwt-auth/v1/token"))
            {
                Version = ApiVersion.WordPressAPIJWT;
                url = urlLower.Replace("jwt-auth/v1/token", "wp/v2");
            }
            else
            {
                Version = ApiVersion.Unknown;
                throw new Exception("Unknown WooCommerce Restful API version.");
            }

            WcUrl = url + (url.EndsWith("/") ? "" : "/");
            WcKey = key;
            AuthorizedHeader = authorizedHeader;

            //Why extra '&'? look here: https://wordpress.org/support/topic/woocommerce-rest-api-v3-problem-woocommerce_api_authentication_error/
            if (url.ToLower().Contains("wc-api/v3") && !WcUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase) && !(Version == ApiVersion.WordPressAPI || Version == ApiVersion.WordPressAPIJWT))
                WcSecret = secret + "&";
            else
                WcSecret = secret;

            JsonSerializeFilter = jsonSerializeFilter;
            JsonDeserializeFilter = jsonDeserializeFilter;
            WebRequestFilter = requestFilter;
            WebResponseFilter = responseFilter;
        }

        public ApiVersion Version { get; }

        public string Url => WcUrl;

        /// <summary>
        /// Make Restful calls
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <param name="method">HEAD, GET, POST, PUT, PATCH, DELETE</param>
        /// <param name="requestBody">If your call doesn't have a body, please pass string.Empty, not null.</param>
        /// <param name="pars"></param>
        /// <returns>json string</returns>
        public virtual async Task<string> SendHttpClientRequest<T>(string endpoint, RequestMethod method, T requestBody, Dictionary<string, string> pars = null)
        {
            System.Diagnostics.Debug.WriteLine(WcUrl + GetOAuthEndPoint(method.ToString(), endpoint, pars));
            HttpWebRequest httpWebRequest = null;
            try
            {
                if ((Version == ApiVersion.WordPressAPIJWT || WcAuthWithJwt) && JwtObject == null)
                {
                    JwtObject = await JwtAuthenticate().ConfigureAwait(false);
                }

                httpWebRequest = InitializeWebRequest(endpoint, method, ref pars);

                return await DoHttpRequest(requestBody, pars, httpWebRequest).ConfigureAwait(false);
            }
            catch (WebException we)
            {
                if (httpWebRequest == null || !httpWebRequest.HaveResponse)
                    throw;

                if (we.Response != null)
                    throw new WebException(await GetStreamContent(we.Response.GetResponseStream(), we.Response.ContentType.Contains("=") ? we.Response.ContentType.Split('=')[1] : "UTF-8").ConfigureAwait(false), we.InnerException, we.Status, we.Response);

                throw;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private async Task<string> DoHttpRequest<T>(T requestBody, Dictionary<string, string> pars, HttpWebRequest httpWebRequest)
        {
            if (requestBody != null && requestBody.GetType() != typeof(string))
            {
                httpWebRequest.ContentType = "application/json";
                var buffer = Encoding.UTF8.GetBytes(SerializeJSon(requestBody));
                using (Stream dataStream = await httpWebRequest.GetRequestStreamAsync().ConfigureAwait(false))
                {
                    await dataStream.WriteAsync(buffer, 0, buffer.Length);
                }
            }
            else
            {
                if (requestBody != null && requestBody.ToString() != string.Empty)
                {
                    // ReSharper disable once StringLiteralTypo
                    if (requestBody.ToString() == "fileupload")
                    {
                        await WriteUploadFile(pars, httpWebRequest);
                    }
                    else
                    {
                        httpWebRequest.ContentType = "application/json";
                        var buffer = Encoding.UTF8.GetBytes(requestBody.ToString());
                        using (Stream dataStream = await httpWebRequest.GetRequestStreamAsync().ConfigureAwait(false))
                        {
                            await dataStream.WriteAsync(buffer, 0, buffer.Length);
                        }
                    }
                }
            }

            // asynchronously get a response
            WebResponse wr = await httpWebRequest.GetResponseAsync().ConfigureAwait(false);

            WebResponseFilter?.Invoke((HttpWebResponse)wr);

            string contentType = wr.ContentType.Contains("=") ? wr.ContentType.Split('=')[1] : "UTF-8";

            return await GetStreamContent(wr.GetResponseStream(), contentType).ConfigureAwait(false);
        }

        private static async Task WriteUploadFile(Dictionary<string, string> pars, HttpWebRequest httpWebRequest)
        {
            if (pars != null)
            {
                httpWebRequest.Headers["Content-Disposition"] = $"attachment; filename=\"{pars["name"]}\"";
                httpWebRequest.ContentType = "image/jpeg";

                using (Stream dataStream = await httpWebRequest.GetRequestStreamAsync().ConfigureAwait(false))
                {
                    //FileStream fileStream = new FileStream(pars["path"], FileMode.Open, FileAccess.Read);
                    //byte[] buffer = new byte[4096];
                    //int bytesRead = 0;

                    //while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    //{
                    //    dataStream.Write(buffer, 0, bytesRead);
                    //}
                    //fileStream.Close();

                    byte[] fileBytes = File.ReadAllBytes(pars["path"]);
                    await dataStream.WriteAsync(fileBytes, 0, fileBytes.Length);
                }
            }
        }

        private HttpWebRequest InitializeWebRequest(string endpoint, RequestMethod method, ref Dictionary<string, string> pars)
        {
            HttpWebRequest httpWebRequest;
            if (WcUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase) && Version != ApiVersion.WordPressAPI &&
                Version != ApiVersion.WordPressAPIJWT)
            {
                if (AuthorizedHeader)
                {
                    httpWebRequest = (HttpWebRequest)WebRequest.Create(WcUrl + GetOAuthEndPoint(method.ToString(), endpoint, pars));

                    if (WcAuthWithJwt && JwtObject != null)
                        httpWebRequest.Headers["Authorization"] = "Bearer " + JwtObject.Token;
                    else
                        httpWebRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(WcKey + ":" + WcSecret));
                }
                else
                {
                    if (pars == null)
                        pars = new Dictionary<string, string>();

                    if (!pars.ContainsKey("consumer_key"))
                        pars.Add("consumer_key", WcKey);
                    if (!pars.ContainsKey("consumer_secret"))
                        pars.Add("consumer_secret", WcSecret);

                    httpWebRequest = (HttpWebRequest)WebRequest.Create(WcUrl + GetOAuthEndPoint(method.ToString(), endpoint, pars));
                }
            }
            else
            {
                httpWebRequest = (HttpWebRequest)WebRequest.Create(WcUrl + GetOAuthEndPoint(method.ToString(), endpoint, pars));
                if (Version == ApiVersion.WordPressAPIJWT || (Version == ApiVersion.WordPressAPI && JwtObject != null))
                    httpWebRequest.Headers["Authorization"] = "Bearer " + JwtObject.Token;
            }

            // start the stream immediately
            httpWebRequest.Method = method.ToString();
            httpWebRequest.AllowReadStreamBuffering = false;

            WebRequestFilter?.Invoke(httpWebRequest);
            return httpWebRequest;
        }

        private async Task<WpJwtObject> JwtAuthenticate()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(WcUrl.Replace("wp/v2", "jwt-auth/v1/token")
                .Replace("wc/v1", "jwt-auth/v1/token")
                .Replace("wc/v2", "jwt-auth/v1/token")
                .Replace("wc/v3", "jwt-auth/v1/token"));
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            if (JwtRequestFilter != null)
                JwtRequestFilter.Invoke(request);

            var buffer = Encoding.UTF8.GetBytes($"username={WcKey}&password={WebUtility.UrlEncode(WcSecret)}");
            using (Stream dataStream = await request.GetRequestStreamAsync().ConfigureAwait(false))
            {
                await dataStream.WriteAsync(buffer, 0, buffer.Length);
            }

            WebResponse response = await request.GetResponseAsync().ConfigureAwait(false);
            Stream resStream = response.GetResponseStream();
            string result = await GetStreamContent(resStream, "UTF-8").ConfigureAwait(false);

            if (JwtDeserializeFilter != null)
                result = JwtDeserializeFilter.Invoke(result);

            return DeserializeJSon<WpJwtObject>(result);
        }

        public async Task<string> GetRestful(string endpoint, Dictionary<string, string> pars = null)
        {
            return await SendHttpClientRequest(endpoint, RequestMethod.GET, string.Empty, pars).ConfigureAwait(false);
        }

        public async Task<string> PostRestful(string endpoint, object jsonObject, Dictionary<string, string> pars = null)
        {
            return await SendHttpClientRequest(endpoint, RequestMethod.POST, jsonObject, pars).ConfigureAwait(false);
        }

        public async Task<string> PutRestful(string endpoint, object jsonObject, Dictionary<string, string> pars = null)
        {
            return await SendHttpClientRequest(endpoint, RequestMethod.PUT, jsonObject, pars).ConfigureAwait(false);
        }

        public async Task<string> DeleteRestful(string endpoint, Dictionary<string, string> pars = null)
        {
            return await SendHttpClientRequest(endpoint, RequestMethod.DELETE, string.Empty, pars).ConfigureAwait(false);
        }

        public async Task<string> DeleteRestful(string endpoint, object jsonObject, Dictionary<string, string> pars = null)
        {
            return await SendHttpClientRequest(endpoint, RequestMethod.DELETE, jsonObject, pars).ConfigureAwait(false);
        }

        protected string GetOAuthEndPoint(string method, string endpoint, Dictionary<string, string> pars = null)
        {
            if (Version == ApiVersion.WordPressAPIJWT || (WcUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase)))
            {
                if (pars == null)
                    return endpoint;
                else
                {
                    string requestPars = string.Empty;
                    foreach (var par in pars)
                        requestPars += par.Key + "=" + par.Value + "&";

                    return endpoint + "?" + requestPars.TrimEnd('&');
                }
            }

            Dictionary<string, string> dic = new Dictionary<string, string> { { "oauth_consumer_key", WcKey } };

            if (Version == ApiVersion.WordPressAPI)
                dic.Add("oauth_token", OauthToken);

            dic.Add("oauth_nonce", Guid.NewGuid().ToString("N"));
            dic.Add("oauth_signature_method", "HMAC-SHA256");
            dic.Add("oauth_timestamp", Common.GetUnixTime(false));
            dic.Add("oauth_version", "1.0");

            if (pars != null)
                foreach (var p in pars)
                    dic.Add(p.Key, p.Value);

            string baseRequestUri = method.ToUpper() + "&" + Uri.EscapeDataString(WcUrl + endpoint) + "&";
            string stringToSign = string.Empty;

            foreach (var par in dic.OrderBy(x => x.Key))
                stringToSign += Uri.EscapeDataString(par.Key) + "=" + Uri.EscapeDataString(par.Value) + "&";

            baseRequestUri += Uri.EscapeDataString(stringToSign.TrimEnd('&'));

            dic.Add("oauth_signature",
                Version == ApiVersion.WordPressAPI
                    ? Common.GetSha256(WcSecret + "&" + OauthTokenSecret, baseRequestUri)
                    : Common.GetSha256(WcSecret, baseRequestUri));

            string parStr = string.Empty;
            foreach (var par in dic)
                parStr += par.Key + "=" + Uri.EscapeDataString(par.Value) + "&";

            return endpoint + "?" + parStr.TrimEnd('&');
        }

        protected async Task<string> GetStreamContent(Stream s, string charset)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buffer = new byte[512];
            int count = await s.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false);

            while (count > 0)
            {
                sb.Append(Encoding.GetEncoding(charset).GetString(buffer, 0, count));
                count = await s.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
            }

            return sb.ToString();
        }

        public virtual string SerializeJSon<T>(T t)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                DateFormatString = DateTimeFormat, // Assuming DateTimeFormat is defined elsewhere
                // Note: Json.NET automatically handles dictionaries in a simple format
                ContractResolver = new NullToEmptyStringResolver(),
                Converters = new List<JsonConverter> { new TypeToStringConverter() },
                NullValueHandling = NullValueHandling.Ignore
            };

            string jsonString = JsonConvert.SerializeObject(t, settings);

            // Special formatting, similar to your original method
            MethodInfo formatJsonSMethod = t.GetType().GetMethod("FormatJsonS");
            if (formatJsonSMethod != null)
            {
                jsonString = (string)formatJsonSMethod.Invoke(null, new object[] { jsonString });
            }

            // Filter, assuming JsonSerializeFilter is a Func<string, string> defined elsewhere
            if (JsonSerializeFilter != null)
            {
                jsonString = JsonSerializeFilter(jsonString);
            }

            return jsonString;
        }

        public virtual T DeserializeJSon<T>(string jsonString)
        {
            // Filter, assuming JsonDeserializeFilter is a Func<string, string> defined elsewhere
            if (JsonDeserializeFilter != null)
            {
                jsonString = JsonDeserializeFilter(jsonString);
            }

            Type dT = typeof(T);

            // Handle special cases similar to your original method
            if (dT.Name.EndsWith("List"))
            {
                dT = dT.GetTypeInfo().DeclaredProperties.First().PropertyType.GenericTypeArguments[0];
            }

            if (dT.FullName != null && dT.FullName.StartsWith("System.Collections.Generic.List"))
            {
                dT = dT.GetProperty("Item")?.PropertyType;
            }

            MethodInfo formatJsonDMethod = dT.GetMethod("FormatJsonD");
            if (formatJsonDMethod != null)
            {
                jsonString = (string)formatJsonDMethod.Invoke(null, new object[] { jsonString });
            }

            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    DateFormatString = DateTimeFormat, // Assuming DateTimeFormat is defined elsewhere
                    // Note: Json.NET handles simple dictionary format automatically
                };

                T obj = JsonConvert.DeserializeObject<T>(jsonString, settings);
                return obj;
            }
            catch (Exception ex)
            {
                if (Debug) // Assuming Debug is a bool defined elsewhere
                    throw new Exception(ex.Message + Environment.NewLine + Environment.NewLine + jsonString);
                throw;
            }
        }

        public string DateTimeFormat => "yyyy-MM-ddTHH:mm:ssK";
    }



}
