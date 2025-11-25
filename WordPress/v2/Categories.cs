using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Categories
    {
        public static string Endpoint => "categories";

        /// <summary>
        /// Unique identifier for the term.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id  { get; set; }

        /// <summary>
        /// Number of published posts for the term.
        /// </summary>
        
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public uint Count  { get; set; }

        /// <summary>
        /// HTML description of the term.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// URL of the term.
        /// </summary>
        
        [JsonProperty("link")]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// HTML title for the term.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the term unique to its type.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Type attribution for the term.
        /// </summary>
        
        [JsonProperty("taxonomy")]
        [JsonPropertyName("taxonomy")]
        public string Taxonomy { get; set; }

        /// <summary>
        /// The parent term ID.
        /// </summary>
        
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public ulong? Parent  { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public object Meta { get; set; }
    }
}
