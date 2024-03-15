using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Taxonomies : JsonObject
    {
        public static string Endpoint => "taxonomies";

        /// <summary>
        ///  All capabilities used by the taxonomy.
        /// </summary>
        [JsonProperty("capabilities")]
        [JsonPropertyName("capabilities")]
        protected ContentObject CapabilitiesValue { get; set; }


        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Capabilities
        {
            get => CapabilitiesValue.Rendered;
            set
            {
                if (CapabilitiesValue == null)
                    CapabilitiesValue = new ContentObject();

                CapabilitiesValue.Rendered = value;
            }
        }

        /// <summary>
        ///  A human-readable description of the taxonomy.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        ///  Whether or not the taxonomy should have children.
        /// </summary>
        
        [JsonProperty("hierarchical")]
        [JsonPropertyName("hierarchical")]
        public bool Hierarchical { get; set; }

        /// <summary>
        ///  Human-readable labels for the taxonomy for various contexts.
        /// </summary>
        [JsonProperty("labels")]
        [JsonPropertyName("labels")]
        protected ContentObject LabelsValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Labels
        {
            get => LabelsValue.Rendered;
            set
            {
                if (LabelsValue == null)
                    LabelsValue = new ContentObject();

                LabelsValue.Rendered = value;
            }
        }

        /// <summary>
        ///  The title for the taxonomy.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///  An alphanumeric identifier for the taxonomy.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        ///  Whether or not the term cloud should be displayed.
        /// </summary>
        
        [JsonProperty("show_cloud")]
        [JsonPropertyName("show_cloud")]
        public bool ShowCloud { get; set; }

        /// <summary>
        ///  Types associated with the taxonomy.
        /// </summary>
        
        [JsonProperty("types")]
        [JsonPropertyName("types")]
        public List<object> Types { get; set; }

        /// <summary>
        ///  REST base route for the taxonomy.
        /// </summary>
        
        [JsonProperty("rest_base")]
        [JsonPropertyName("rest_base")]
        public string RestBase { get; set; }

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

                if(nextIndex > 0)
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
