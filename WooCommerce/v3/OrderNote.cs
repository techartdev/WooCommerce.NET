using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v3
{
    
    public class OrderNote : v2.OrderNote 
    {
        /// <summary>
        /// Order note author.
        /// </summary>
        
        [JsonProperty("author")]
        [JsonPropertyName("author")]
        public string Author { get; set; }

        /// <summary>
        /// If true, this note will be attributed to the current user. If false, the note will be attributed to the system. Default is false.
        /// </summary>
        
        [JsonProperty("added_by_user")]
        [JsonPropertyName("added_by_user")]
        public bool AddedByUser { get; set; }
    }
}
