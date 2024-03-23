using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce
{
    public class TaxRate
    {
        public static string Endpoint => "taxes";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("name")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Country ISO 3166 code. See ISO 3166 Codes (Countries) for more details
        /// </summary>        
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// State code.
        /// </summary>        
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postcode/ZIP, it doesn't support multiple values. Deprecated as of WooCommerce 5.3, postcodes should be used instead.
        /// </summary>        
        [Obsolete("Deprecated as of WooCommerce 5.3, postcodes should be used instead.")]
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// City name, it doesn't support multiple values. Deprecated as of WooCommerce 5.3, cities should be used instead.
        /// </summary>      
        [Obsolete("Deprecated as of WooCommerce 5.3, cities should be used instead.")]
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Postcodes/ZIPs. Introduced in WooCommerce 5.3.
        /// </summary>
        [JsonProperty("postcodes")]
        [JsonPropertyName("postcodes")]
        public string[] Postcodes { get; set; }

        /// <summary>
        /// City names. Introduced in WooCommerce 5.3.
        /// </summary>
        [JsonProperty("cities")]
        [JsonPropertyName("cities")]
        public string[] Cities { get; set; }

        /// <summary>
        /// Tax rate.
        /// </summary>        
        [JsonProperty("rate")]
        [JsonPropertyName("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Tax rate name.
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tax priority. Only 1 matching rate per priority will be used. To define multiple tax rates for a single area you need to specify a different priority per rate. Default is 1.
        /// </summary>        
        [JsonProperty("priority")]
        [JsonPropertyName("priority")]
        public int Priority { get; set; } = 1;

        /// <summary>
        /// Whether or not this is a compound rate. Compound tax rates are applied on top of other tax rates. Default is false.
        /// </summary>        
        [JsonProperty("compound")]
        [JsonPropertyName("compound")]
        public bool Compound { get; set; }

        /// <summary>
        /// Whether or not this tax rate also gets applied to shipping. Default is true.
        /// </summary>        
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public bool Shipping { get; set; } = true;

        /// <summary>
        /// Indicates the order that will appear in queries.
        /// </summary>        
        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int Order { get; set; }

        /// <summary>
        /// Tax class. Default is standard.
        /// </summary>
        [JsonProperty("class")]
        [JsonPropertyName("class")]
        public string Class { get; set; } = "standard";
    }
}
