using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class PostStatuses
    {
        public static string Endpoint => "statuses";

        /// <summary>
        /// The title for the status.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether posts with this status should be private.
        /// </summary>
        [JsonProperty("private")]
        [JsonPropertyName("private")]
        public bool Private  { get; set; }

        /// <summary>
        /// Whether posts with this status should be protected.
        /// </summary>
        [JsonProperty("protected")]
        [JsonPropertyName("protected")]
        public bool Protected  { get; set; }

        /// <summary>
        /// Whether posts of this status should be shown in the front end of the site.
        /// </summary>
        [JsonProperty("public")]
        [JsonPropertyName("public")]
        public bool Public  { get; set; }

        /// <summary>
        /// Whether posts with this status should be publicly-queryable.
        /// </summary>
        
        [JsonProperty("queryable")]
        [JsonPropertyName("queryable")]
        public bool Queryable { get; set; }

        /// <summary>
        /// Whether to include posts in the edit listing for their post type.
        /// </summary>
        
        [JsonProperty("show_in_list")]
        [JsonPropertyName("show_in_list")]
        public bool ShowInList { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the status.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Format json string on Deserialize
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string FormatJsonD(string json)
        {
            StringBuilder newJson = new StringBuilder();
            newJson.Append('[');

            int headIndex = json.IndexOf("\":{\"name\":\"", StringComparison.Ordinal);

            while (headIndex > 0)
            {
                int nextIndex = json.IndexOf("\":{\"name\":\"", headIndex + 10, StringComparison.Ordinal);

                if (nextIndex > 0)
                {
                    int quoteIndex = json.LastIndexOf("\"", nextIndex - 2, StringComparison.Ordinal);
                    newJson.Append(json.Substring(headIndex + 2, nextIndex - headIndex - (nextIndex - quoteIndex) - 3));
                    newJson.Append(',');

                    headIndex = json.IndexOf("\":{\"name\":\"", nextIndex, StringComparison.Ordinal);
                }
                else
                {
                    string temp = json.Substring(headIndex + 2);
                    newJson.Append(temp.Substring(0, temp.Length - 1));
                    newJson.Append(']');

                    break;
                }
            }

            return newJson.ToString();
        }
    }
}
