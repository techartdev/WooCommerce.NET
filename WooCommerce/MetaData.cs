using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce
{
    public class MetaData
    {
        /// <summary>
        /// Meta ID. 
        /// read-only
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Meta key.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Meta value.
        /// </summary>
        [JsonProperty("value")]
        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}
