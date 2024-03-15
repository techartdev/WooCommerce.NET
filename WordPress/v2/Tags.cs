using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Tags
    {
        public static string Endpoint => "tags";

        /// <summary>
        /// Unique identifier for the term.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? id  { get; set; }

        /// <summary>
        /// Number of published posts for the term.
        /// </summary>
        
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public uint count { get; set; }

        /// <summary>
        /// HTML description of the term.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string description { get; set; }

        /// <summary>
        /// URL of the term.
        /// </summary>
        
        [JsonProperty("link")]
        [JsonPropertyName("link")]
        public string link { get; set; }

        /// <summary>
        /// HTML title for the term.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the term unique to its type.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string slug{ get; set; }

        /// <summary>
        /// Type attribution for the term.
        /// </summary>
        
        [JsonProperty("taxonomy")]
        [JsonPropertyName("taxonomy")]
        public string taxonomy { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public object meta { get; set; }
    }
}
