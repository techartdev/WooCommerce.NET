using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce
{
    public class TaxClass
    {
        public static string Endpoint => "taxes/classes";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        /// <summary>
        /// Tax class name. 
        /// required
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; }
    }
}
