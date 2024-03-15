using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v2
{
    
    public class ProductAttribute
    {
        public static string Endpoint => "products/attributes";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Attribute name. 
        /// mandatory
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the resource unique to its type.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Type of attribute. Options: select and text. Default is select.
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Default sort order. Options: menu_order, name, name_num and id. Default is menu_order.
        /// </summary>
        
        [JsonProperty("order_by")]
        [JsonPropertyName("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Enable/Disable attribute archives. Default is false.
        /// </summary>
        
        [JsonProperty("has_archives")]
        [JsonPropertyName("has_archives")]
        public bool? HasArchives { get; set; }

    }

    
    public class ProductAttributeTerm
    {
        public static string Endpoint => "terms";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Term name. 
        /// mandatory
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the resource unique to its type.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// HTML description of the resource.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Menu order, used to custom sort the resource.
        /// </summary>
        
        [JsonProperty("menu_order")]
        [JsonPropertyName("menu_order")]
        public int? MenuOrder { get; set; }

        /// <summary>
        /// Number of published products for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }
}
