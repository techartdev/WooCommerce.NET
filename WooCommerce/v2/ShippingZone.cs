using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v2
{
    
    public class ShippingZone
    {
        public static string Endpoint => "shipping/zones";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Shipping zone name. 
        /// mandatory
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipping zone order.
        /// </summary>
        
        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int? Order { get; set; }

    }

    
    public class ShippingZoneLocation
    {
        public static string Endpoint => "locations";

        /// <summary>
        /// Shipping zone location code.
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Shipping zone location type. Options: postcode, state, country and continent. Default is country.
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

    }
    
    
    public class ShippingZoneMethod
    {
        public static string Endpoint => "methods";

        /// <summary>
        /// Shipping method instance ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("instance_id")]
        [JsonPropertyName("instance_id")]
        public int? InstanceId { get; set; }

        /// <summary>
        /// Shipping method customer facing title. 
        /// read-only
        /// </summary>
        
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Shipping method sort order.
        /// </summary>
        
        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Shipping method enabled status.
        /// </summary>
        
        [JsonProperty("enabled")]
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Shipping method ID. read-only 
        /// read-only</i> <i class="label label-info">mandatory
        /// </summary>
        
        [JsonProperty("method_id")]
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// Shipping method title. 
        /// read-only
        /// </summary>
        
        [JsonProperty("method_title")]
        [JsonPropertyName("method_title")]
        public string MethodTitle { get; set; }

        /// <summary>
        /// Shipping method description. 
        /// read-only
        /// </summary>
        
        [JsonProperty("method_description")]
        [JsonPropertyName("method_description")]
        public string MethodDescription { get; set; }

        /// <summary>
        /// Shipping method settings. See Shipping method - Settings properties
        /// </summary>
        
        [JsonProperty("settings")]
        [JsonPropertyName("settings")]
        public Dictionary<string, ShippingZoneMethodSetting> Settings { get; set; }

        /// <summary>
        /// Method ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Shipping method title. 
        /// read-only
        /// </summary>
        
        [JsonProperty("title2")]
        [JsonPropertyName("title2")]
        public string Title2 { get; set; }

        /// <summary>
        /// Shipping method description. 
        /// read-only
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

    }
    
    
    public class ShippingZoneMethodSetting
    {
        /// <summary>
        /// A unique identifier for the setting. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// A human readable label for the setting used in interfaces. 
        /// read-only
        /// </summary>
        
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// A human readable description for the setting used in interfaces. 
        /// read-only
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Type of setting. Options: text, email, number, color, password, textarea, select, multiselect, radio, image_width and checkbox. 
        /// read-only
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

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
        public string Default { get; set; }

        /// <summary>
        /// Additional help text shown to the user about the setting. 
        /// read-only
        /// </summary>
        
        [JsonProperty("tip")]
        [JsonPropertyName("tip")]
        public string Tip { get; set; }

        /// <summary>
        /// Placeholder text to be displayed in text inputs. 
        /// read-only
        /// </summary>
        
        [JsonProperty("placeholder")]
        [JsonPropertyName("placeholder")]
        public string Placeholder { get; set; }

    }
}
