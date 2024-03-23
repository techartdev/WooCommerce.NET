using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce
{
    public class ShippingClass
    {
        public static string Endpoint => "products/shipping_classes";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Shipping class name. 
        /// mandatory
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the resource unique to its type.
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// HTML description of the resource.
        /// </summary>        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Number of published products for the resource. 
        /// read-only
        /// </summary>        
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int Count { get; private set; }
    }
}
