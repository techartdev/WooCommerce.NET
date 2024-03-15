using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Comments
    {
        public static string Endpoint => "comments";

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id  { get; set; }

        /// <summary>
        /// The ID of the user object, if author was a user.
        /// </summary>
        
        [JsonProperty("author")]
        [JsonPropertyName("author")]
        public ulong? Author { get; set; }

        /// <summary>
        /// Email address for the object author.
        /// </summary>
        
        [JsonProperty("author_email")]
        [JsonPropertyName("author_email")]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// IP address for the object author.
        /// </summary>
        
        [JsonProperty("author_ip")]
        [JsonPropertyName("author_ip")]
        public string AuthorIp { get; set; }

        /// <summary>
        /// Display name for the object author.
        /// </summary>
        
        [JsonProperty("author_name")]
        [JsonPropertyName("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// URL for the object author.
        /// </summary>
        
        [JsonProperty("author_url")]
        [JsonPropertyName("author_url")]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// User agent for the object author.
        /// </summary>
        
        [JsonProperty("author_user_agent")]
        [JsonPropertyName("author_user_agent")]
        public string AuthorUserAgent { get; set; }

        /// <summary>
        /// The content for the object.
        /// </summary>
        [JsonProperty("content")]
        [JsonPropertyName("content")]
        protected ContentObject ContentValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Content
        {
            get => ContentValue.Rendered;
            set
            {
                if (ContentValue == null)
                    ContentValue = new ContentObject();

                ContentValue.Rendered = value;
            }
        }

        /// <summary>
        /// The date the object was published, in the site's timezone.
        /// </summary>
        
        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// The date the object was published, as GMT.
        /// </summary>
        
        [JsonProperty("date_gmt")]
        [JsonPropertyName("date_gmt")]
        public string DateGmt { get; set; }

        /// <summary>
        /// URL to the object.
        /// </summary>
        
        [JsonProperty("link")]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// The ID for the parent of the object.
        /// </summary>
        
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public ulong? Parent { get; set; }

        /// <summary>
        /// The ID of the associated post object.
        /// </summary>
        
        [JsonProperty("post")]
        [JsonPropertyName("post")]
        public ulong? Post { get; set; }

        /// <summary>
        /// State of the object.
        /// </summary>
        
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of Comment for the object.
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Avatar URLs for the object author.
        /// </summary>
        
        [JsonProperty("author_avatar_urls")]
        [JsonPropertyName("author_avatar_urls")]
        public object AuthorAvatarUrls { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public object Meta { get; set; }

        /// <summary>
        /// Format json string on Serialize
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string FormatJsonS(string json)
        {
            int startIndex = json.IndexOf("{\"rendered\":", StringComparison.Ordinal);

            while (startIndex > 0)
            {
                int endIndex = json.IndexOf("\"}", startIndex, StringComparison.Ordinal);

                string oldPart = json.Substring(startIndex, endIndex - startIndex + 2);
                string newPart = oldPart.Substring(12).TrimEnd('}');

                json = json.Replace(oldPart, newPart);

                startIndex = json.IndexOf("{\"rendered\":", StringComparison.Ordinal);
            }

            return json;
        }
    }
}
