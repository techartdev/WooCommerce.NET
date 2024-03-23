using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce
{
    public class ShippingMethod
    {
        public static string Endpoint => "shipping_methods";

        /// <summary>
        /// Method ID. 
        /// read-only
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Shipping method title. 
        /// read-only
        /// </summary>        
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; private set; }

        /// <summary>
        /// Shipping method description.
        /// read-only
        /// </summary>        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; private set; }
    }
}
