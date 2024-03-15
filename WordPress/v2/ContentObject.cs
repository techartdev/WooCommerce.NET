using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class ContentObject
    {
        
        [JsonProperty("rendered")]
        [JsonPropertyName("rendered")]
        public string Rendered { get; set; }

        [JsonProperty("protected")]
        [JsonPropertyName("protected")]
        public bool Protected { get; set; }
    }
}
