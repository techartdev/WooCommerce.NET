using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v1
{
    [DataContract]
    public class BillingAddress
    {
        /// <summary>
        /// First name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }

    [DataContract]
    public class ShippingAddress
    {
        /// <summary>
        /// First name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
