using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v2
{
    
    public class OrderNote
    {
        public static string Endpoint => "notes";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the order note was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the order note was created, as GMT. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        /// <summary>
        /// Order note content. 
        /// mandatory
        /// </summary>
        
        [JsonProperty("note")]
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// If true, the note will be shown to customers and they will be notified. If false, the note will be for admin reference only. Default is false.
        /// </summary>
        
        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public bool? CustomerNote { get; set; }
    }
}
