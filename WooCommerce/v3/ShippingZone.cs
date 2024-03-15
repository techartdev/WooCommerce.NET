using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v3
{
    
    public class ShippingZone : v2.ShippingZone { }

    
    public class ShippingZoneLocation : v2.ShippingZoneLocation { }
    
    
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
    }

    
    public class ShippingZoneMethodSetting : v2.ShippingZoneMethodSetting { }
}
