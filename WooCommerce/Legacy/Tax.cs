using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.Legacy
{
    [DataContract]
    public class Tax
    {
        /// <summary>
        /// Tax rate ID 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Country code. See ISO 3166 Codes (Countries) for more details
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// State code
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postcode/ZIP
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Tax rate
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("rate")]
        [JsonPropertyName("rate")]
        public decimal? Rate { get; set; }

        /// <summary>
        /// Tax rate name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tax priority. Only 1 matching rate per priority will be used. To define multiple tax rates for a single area you need to specify a different priority per rate. Default is 1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("priority")]
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Choose whether or not this is a compound rate. Compound tax rates are applied on top of other tax rates. Default is false
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("compound")]
        [JsonPropertyName("compound")]
        public bool? Compound { get; set; }

        /// <summary>
        /// Choose whether or not this tax rate also gets applied to shipping. Default is true
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public bool? Shipping { get; set; }

        /// <summary>
        /// Indicates the order that will appear in queries
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Tax class. Default is standard
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "class")]
        [JsonProperty("class")]
        [JsonPropertyName("class")]
        public string TaxClass { get; set; }
    }

    [DataContract]
    public class TaxClass
    {
        /// <summary>
        /// Tax class slug 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Tax class name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
