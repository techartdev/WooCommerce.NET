using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce
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
        public ulong? Id { get; private set; }

        /// <summary>
        /// The date the order note was created, in the site’s timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// The date the order note was created, as GMT. 
        /// read-only
        /// </summary>

        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; private set; }

        /// <summary>
        /// Order note content. 
        /// mandatory
        /// </summary>

        [JsonProperty("note")]
        [JsonPropertyName("note")]
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        public string Note { get; set; }

        /// <summary>
        /// If true, the note will be shown to customers and they will be notified. If false, the note will be for admin reference only. Default is false.
        /// </summary>        
        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public bool CustomerNote { get; set; }

        /// <summary>
        /// Order note author.
        /// </summary>
        [JsonProperty("author")]
        [JsonPropertyName("author")]
        public string Author { get; private set; }

        /// <summary>
        /// If true, this note will be attributed to the current user. If false, the note will be attributed to the system. Default is false.
        /// </summary>        
        [JsonProperty("added_by_user")]
        [JsonPropertyName("added_by_user")]
        public bool AddedByUser { get; set; }
    }
}
