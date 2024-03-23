using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce
{
    public class ProductCategoryBatch : BatchObject<ProductCategory> { }

    public class ProductCategory
    {
        public static string Endpoint => "products/categories";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Category name. 
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
        /// The ID for the parent of the resource.
        /// </summary>        
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public ulong Parent { get; set; }

        /// <summary>
        /// HTML description of the resource.
        /// </summary>        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Category archive display type. Options: default, products, subcategories and both. Default is default.
        /// </summary>        
        [JsonProperty("display")]
        [JsonPropertyName("display")]
        public string Display { get; set; }

        /// <summary>
        /// Image data. See Product category - Image properties
        /// </summary>        
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public ProductCategoryImage Image { get; set; }

        /// <summary>
        /// Menu order, used to custom sort the resource.
        /// </summary>        
        [JsonProperty("menu_order")]
        [JsonPropertyName("menu_order")]
        public int MenuOrder { get; set; }

        /// <summary>
        /// Number of published products for the resource. 
        /// read-only
        /// </summary>        
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int Count { get; private set; }
    }

    public class ProductCategoryImage
    {
        /// <summary>
        /// Image ID.
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        /// <summary>
        /// The date the image was created, in the site’s timezone. 
        /// read-only
        /// </summary>        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// The date the image was created, as GMT 
        /// read-only
        /// </summary>        
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; private set; }

        /// <summary>
        /// The date the image was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; private set; }

        /// <summary>
        /// The date the image was last modified, as GMT. 
        /// read-only
        /// </summary>        
        [JsonProperty("date_modified_gmt")]
        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; private set; }

        /// <summary>
        /// Image URL.
        /// </summary>        
        [JsonProperty("src")]
        [JsonPropertyName("src")]
        public string Src { get; set; }

        /// <summary>
        /// Image name.
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Image alternative text.
        /// </summary>        
        [JsonProperty("alt")]
        [JsonPropertyName("alt")]
        public string Alt { get; set; }
    }
}
