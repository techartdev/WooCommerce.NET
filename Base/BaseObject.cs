using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WooCommerce.NET.Base
{
    public class BatchObject<T>
    {
        
        [JsonProperty("create")]
        [JsonPropertyName("create")]
        public List<T> Create { get; set; }

        
        [JsonProperty("update")]
        [JsonPropertyName("update")]
        public List<T> Update { get; set; }

        
        [JsonProperty("delete")]
        [JsonPropertyName("delete")]
        public List<ulong> Delete { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<T> DeletedItems { get; set; }
    }

    public class WcItem<T>
    {
        public string ApiEndpoint { get; protected set; }
        public RestApi Api { get; protected set; }

        public WcItem(RestApi api)
        {
            Api = api;
            if(typeof(T).BaseType.GetRuntimeProperty("Endpoint") == null)
                ApiEndpoint = typeof(T).GetRuntimeProperty("Endpoint").GetValue(null).ToString();
            else
                ApiEndpoint = typeof(T).BaseType.GetRuntimeProperty("Endpoint").GetValue(null).ToString();
        }

        public virtual async Task<T> Get(ulong id, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<T>(await Api.GetRestful(ApiEndpoint + "/" + id, pars).ConfigureAwait(false));
        }

        public virtual async Task<T> Get(string email, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<T>(await Api.GetRestful(ApiEndpoint + "/" + email, pars).ConfigureAwait(false));
        }

        public virtual async Task<List<T>> GetAll(Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<List<T>>(await Api.GetRestful(ApiEndpoint, pars).ConfigureAwait(false));
        }

        public virtual async Task<T> Add(T item, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<T>(await Api.PostRestful(ApiEndpoint, item, pars).ConfigureAwait(false));
        }

        [Obsolete("AddRange method is obsolete, please use UpdateRange for batch Add, Update, Delete.")]
        public async Task<BatchObject<T>> AddRange(BatchObject<T> items, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<BatchObject<T>>(await Api.PostRestful(ApiEndpoint + "/batch", items, pars).ConfigureAwait(false));
        }

        public virtual async Task<T> Update(ulong id, T item, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<T>(await Api.PostRestful(ApiEndpoint + "/" + id, item, pars).ConfigureAwait(false));
        }

        public virtual async Task<T> UpdateWithNull(ulong id, object item, Dictionary<string, string> pars = null)
        {
            if (Api.GetType().Name == "RestAPI")
            {
                StringBuilder json = new StringBuilder();
                json.Append("{");
                foreach (var prop in item.GetType().GetRuntimeProperties())
                {
                    if (prop.GetValue(item).ToString() == "")
                        json.Append($"\"{prop.Name}\": \"\", ");
                    else
                        json.Append($"\"{prop.Name}\": \"{prop.GetValue(item)}\", ");
                }

                if (json.Length > 1)
                    json.Remove(json.Length - 2, 1);

                json.Append("}");

                return Api.DeserializeJSon<T>(await Api.PostRestful(ApiEndpoint + "/" + id, json.ToString(), pars).ConfigureAwait(false));
            }
            else
                return Api.DeserializeJSon<T>(await Api.PostRestful(ApiEndpoint + "/" + id, item, pars).ConfigureAwait(false));
        }

        public virtual async Task<BatchObject<T>> UpdateRange(BatchObject<T> items, Dictionary<string, string> pars = null)
        {
            string json = await UpdateRangeRaw(items, pars);

            if (items.Delete == null || items.Delete.Count == 0)
                return Api.DeserializeJSon<BatchObject<T>>(json);
            else
            {
                BatchObject<T> batchResult = new BatchObject<T>();

                if ((items.Create == null || items.Create.Count == 0) && (items.Update == null || items.Update.Count == 0))
                {
                    batchResult.DeletedItems = Api.DeserializeJSon<List<T>>(json.Substring(json.IndexOf("[", StringComparison.Ordinal)).TrimEnd('}'));
                }
                else
                {
                    var pos = json.LastIndexOf("\"delete\":[", StringComparison.Ordinal);
                    if (pos != -1)
                    {
                        batchResult = Api.DeserializeJSon<BatchObject<T>>(json.Substring(0, pos - 1) + "}");
                        batchResult.DeletedItems = Api.DeserializeJSon<List<T>>(json.Substring(pos + 9).TrimEnd('}'));
                    }
                    else
                        batchResult = Api.DeserializeJSon<BatchObject<T>>(json);
                }

                return batchResult;
            }
        }

        public virtual async Task<string> UpdateRangeRaw(BatchObject<T> items, Dictionary<string, string> pars = null)
        {
            return await Api.PostRestful(ApiEndpoint + "/batch", items, pars).ConfigureAwait(false);
        }

        public virtual async Task<T> Delete(ulong id, bool force = false, Dictionary<string, string> pars = null)
        {
            if (force)
            {
                if (pars == null)
                    pars = new Dictionary<string, string>();

                if (!pars.ContainsKey("force"))
                    pars.Add("force", "true");
            }

            return Api.DeserializeJSon<T>(await Api.DeleteRestful(ApiEndpoint + "/" + id, pars).ConfigureAwait(false));
        }

        [Obsolete("DeleteRange method is obsolete, please use UpdateRange for batch Add, Update, Delete.")]
        public async Task<string> DeleteRange(BatchObject<T> items, Dictionary<string, string> pars = null)
        {
            return await Api.PostRestful(ApiEndpoint + "/batch", items, pars).ConfigureAwait(false);
        }
    }

    public class WcSubItem<T>
    {
        public string ApiEndpoint { get; protected set; }
        public string ApiParentEndpoint { get; protected set; }
        public RestApi Api { get; protected set; }

        public WcSubItem(RestApi api, string parentEndpoint)
        {
            Api = api;
            var memberInfo = typeof(T).BaseType;
            if (memberInfo != null && memberInfo.FullName != null && memberInfo.FullName.Contains("v2"))
                ApiEndpoint = typeof(T).BaseType.GetRuntimeProperty("Endpoint").GetValue(null).ToString();
            else
                ApiEndpoint = typeof(T).GetRuntimeProperty("Endpoint").GetValue(null).ToString();

            ApiParentEndpoint = parentEndpoint;
        }

        public virtual async Task<T> Get(ulong id, ulong parentId, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<T>(await Api.GetRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint + "/" + id, pars).ConfigureAwait(false));
        }

        public virtual async Task<List<T>> GetAll(object parentId, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<List<T>>(await Api.GetRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint, pars).ConfigureAwait(false));
        }

        public virtual async Task<T> Add(T item, ulong parentId, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<T>(await Api.PostRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint, item, pars).ConfigureAwait(false));
        }

        public virtual async Task<T> Update(ulong id, T item, ulong parentId, Dictionary<string, string> pars = null)
        {
            return Api.DeserializeJSon<T>(await Api.PostRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint + "/" + id, item, pars).ConfigureAwait(false));
        }

        public virtual async Task<T> UpdateWithNull(ulong id, ulong parentId, object item, Dictionary<string, string> pars = null)
        {
            if (Api.GetType().Name == "RestAPI")
            {
                StringBuilder json = new StringBuilder();
                json.Append("{");
                foreach (var prop in item.GetType().GetProperties())
                {
                    if (prop.GetValue(item).ToString() == "")
                        json.Append($"\"{prop.Name}\": \"\", ");
                    else
                        json.Append($"\"{prop.Name}\": \"{prop.GetValue(item)}\", ");
                }

                if (json.Length > 1)
                    json.Remove(json.Length - 2, 1);

                json.Append("}");

                return Api.DeserializeJSon<T>(await Api.PostRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint + "/" + id, json.ToString(), pars).ConfigureAwait(false));
            }
            else
                return Api.DeserializeJSon<T>(await Api.PostRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint + "/" + id, item, pars).ConfigureAwait(false));
        }

        public virtual async Task<BatchObject<T>> UpdateRange(ulong parentId, BatchObject<T> items, Dictionary<string, string> pars = null)
        {
            string json = await UpdateRangeRaw(parentId, items, pars);

            if (items.Delete == null || items.Delete.Count == 0)
                return Api.DeserializeJSon<BatchObject<T>>(json);
            else
            {
                BatchObject<T> batchResult = new BatchObject<T>();

                if ((items.Create == null || items.Create.Count == 0) && (items.Update == null || items.Update.Count == 0))
                {
                    batchResult.DeletedItems = Api.DeserializeJSon<List<T>>(json.Substring(json.IndexOf("[", StringComparison.Ordinal)).TrimEnd('}'));
                }
                else
                {
                    var pos = json.LastIndexOf("\"delete\":[", StringComparison.Ordinal);
                    if (pos != -1)
                    {
                        batchResult = Api.DeserializeJSon<BatchObject<T>>(json.Substring(0, pos - 1) + "}");
                        batchResult.DeletedItems = Api.DeserializeJSon<List<T>>(json.Substring(pos + 9).TrimEnd('}'));
                    }
                    else
                        batchResult = Api.DeserializeJSon<BatchObject<T>>(json);
                }

                return batchResult;
            }
        }

        public virtual async Task<string> UpdateRangeRaw(ulong parentId, BatchObject<T> items, Dictionary<string, string> pars = null)
        {
            return await Api.PostRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint + "/batch", items, pars).ConfigureAwait(false);
        }

        public virtual async Task<string> Delete(ulong id, ulong parentId, bool force = false, Dictionary<string, string> pars = null)
        {
            if (force)
            {
                if (pars == null)
                    pars = new Dictionary<string, string>();

                if (!pars.ContainsKey("force"))
                    pars.Add("force", "true");
            }

            return await Api.DeleteRestful(ApiParentEndpoint + "/" + parentId + "/" + ApiEndpoint + "/" + id, pars).ConfigureAwait(false);
        }
    }
}
