using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class PostTypes
    {
        public static string Endpoint => "types";

        /// <summary>
        /// All capabilities used by the post type.
        /// </summary>
        
        [JsonProperty("capabilities")]
        [JsonPropertyName("capabilities")]
        public object Capabilities { get; set; }

        /// <summary>
        /// A human-readable description of the post type.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether or not the post type should have children.
        /// </summary>
        
        [JsonProperty("hierarchical")]
        [JsonPropertyName("hierarchical")]
        public bool Hierarchical { get; set; }

        /// <summary>
        /// Human-readable labels for the post type for various contexts.
        /// </summary>
        
        [JsonProperty("labels")]
        [JsonPropertyName("labels")]
        public object Labels { get; set; }

        /// <summary>
        /// The title for the post type.
        /// </summary>
        
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the post type.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Slug { get; set; }

        /// <summary>
        /// All features, supported by the post type.
        /// </summary>
        
        [JsonProperty("supports")]
        [JsonPropertyName("supports")]
        public object Supports { get; set; }

        /// <summary>
        /// Taxonomies associated with post type.
        /// </summary>
        
        [JsonProperty("taxonomies")]
        [JsonPropertyName("taxonomies")]
        public List<object> Taxonomies { get; set; }

        /// <summary>
        /// REST base route for the post type.
        /// </summary>
        
        [JsonProperty("rest_base")]
        [JsonPropertyName("rest_base")]
        public string RestBase { get; set; }

        /// <summary>
        /// Format json string on Deserialize
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string FormatJsonD(string json)
        {
            StringBuilder newJson = new StringBuilder();
            newJson.Append('[');

            int headIndex = json.IndexOf("\":{\"description\":\"", StringComparison.Ordinal);

            while (headIndex > 0)
            {
                int nextIndex = json.IndexOf("\":{\"description\":\"", headIndex + 10, StringComparison.Ordinal);

                if (nextIndex > 0)
                {
                    int quoteIndex = json.LastIndexOf("\"", nextIndex - 2, StringComparison.Ordinal);
                    newJson.Append(json.Substring(headIndex + 2, nextIndex - headIndex - (nextIndex - quoteIndex) - 3));
                    newJson.Append(',');

                    headIndex = json.IndexOf("\":{\"description\":\"", nextIndex, StringComparison.Ordinal);
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
