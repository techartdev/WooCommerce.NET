using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce
{
    public class PaymentGateway
    {
        public static string Endpoint => "payment_gateways";

        /// <summary>
        /// Payment gateway ID. 
        /// read-only
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Payment gateway title on checkout.
        /// </summary>        
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Payment gateway description on checkout.
        /// </summary>        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Payment gateway sort order.
        /// </summary>        
        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Payment gateway enabled status.
        /// </summary>        
        [JsonProperty("enabled")]
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Payment gateway method title. 
        /// read-only
        /// </summary>        
        [JsonProperty("method_title")]
        [JsonPropertyName("method_title")]
        public string MethodTitle { get; private set; }

        /// <summary>
        /// Payment gateway method description. 
        /// read-only
        /// </summary>        
        [JsonProperty("method_description")]
        [JsonPropertyName("method_description")]
        public string MethodDescription { get; private set; }

        /// <summary>
        /// Supported features for this payment gateway.
        /// read-only
        /// </summary>        
        [JsonProperty("method_supports")]
        [JsonPropertyName("method_supports")]
        public List<string> MethodSupports { get; private set; }

        /// <summary>
        /// Payment gateway settings. See Payment gateway - Settings properties
        /// </summary>        
        [JsonProperty("settings")]
        [JsonPropertyName("settings")]
        public Dictionary<string, PaymentGatewaySetting> Settings { get; set; }
    }


    public class PaymentGatewaySetting
    {
        /// <summary>
        /// A unique identifier for the setting. 
        /// read-only
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// A human readable label for the setting used in interfaces. 
        /// read-only
        /// </summary>        
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; private set; }

        /// <summary>
        /// A human readable description for the setting used in interfaces. 
        /// read-only
        /// </summary>        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Type of setting. Options: text, email, number, color, password, textarea, select, multiselect, radio, image_width and checkbox. 
        /// read-only
        /// </summary>        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Setting value.
        /// </summary>        
        [JsonProperty("value")]
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Default value for the setting. 
        /// read-only
        /// </summary>
        [JsonProperty("default")]
        [JsonPropertyName("default")]
        public string Default { get; private set; }

        /// <summary>
        /// Additional help text shown to the user about the setting. 
        /// read-only
        /// </summary>        
        [JsonProperty("tip")]
        [JsonPropertyName("tip")]
        public string Tip { get; private set; }

        /// <summary>
        /// Placeholder text to be displayed in text inputs. 
        /// read-only
        /// </summary>        
        [JsonProperty("placeholder")]
        [JsonPropertyName("placeholder")]
        public string Placeholder { get; private set; }

    }
}
