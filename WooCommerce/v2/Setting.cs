using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v2
{
    
    public class Setting
    {
        public static string Endpoint => "settings";

        /// <summary>
        /// A unique identifier that can be used to link settings together. 
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
        /// ID of parent grouping. 
        /// read-only
        /// </summary>
        
        [JsonProperty("parent_id")]
        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// IDs for settings sub groups. 
        /// read-only
        /// </summary>
        
        [JsonProperty("sub_groups")]
        [JsonPropertyName("sub_groups")]
        public List<string> SubGroups { get; set; }

    }

    public class SettingOptionBatch : BatchObject<SettingOption> { }

    
    public class SettingOption
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
        /// Setting value.
        /// </summary>
        
        [JsonProperty("value")]
        [JsonPropertyName("value")]
        public object Value { get; set; }

        /// <summary>
        /// Default value for the setting. 
        /// read-only
        /// </summary>
        [JsonProperty("default")]
        [JsonPropertyName("default")]
        public object Default { get; set; }

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

        /// <summary>
        /// Type of setting. Options: text, email, number, color, password, textarea, select, multiselect, radio, image_width and checkbox. 
        /// read-only
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Array of options (key value pairs) for inputs such as select, multiselect, and radio buttons. 
        /// read-only
        /// </summary>
        
        [JsonProperty("options")]
        [JsonPropertyName("options")]
        public Dictionary<string, string> Options { get; set; }

    }
}
