using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v1
{
    [KnownType(typeof(TaxRateBatch))]
    public class TaxRateBatch : BatchObject<TaxRate> { }

    
    public class TaxRate
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

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
        /// Postcode/ZIP.
        /// </summary>
        
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// City name.
        /// </summary>
        
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

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
        public int? Priority { get; set; }

        /// <summary>
        /// Whether or not this is a compound rate. Compound tax rates are applied on top of other tax rates. Default is false.
        /// </summary>
        
        [JsonProperty("compound")]
        [JsonPropertyName("compound")]
        public bool? Compound { get; set; }

        /// <summary>
        /// Whether or not this tax rate also gets applied to shipping. Default is true.
        /// </summary>
        
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public bool? Shipping { get; set; }

        /// <summary>
        /// Indicates the order that will appear in queries.
        /// </summary>
        
        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Tax class. Default is standard.
        /// </summary>
        [JsonProperty("class")]
        [JsonPropertyName("class")]
        public string Class{ get; set; }
}

    
    public class TaxClass
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Tax class name. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
