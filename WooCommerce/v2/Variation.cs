using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce.v2
{
    
    public class Variation : JsonObject
    {
        public static string Endpoint => "variations";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the variation was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the variation was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Variation description.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Variation URL. 
        /// read-only
        /// </summary>
        
        [JsonProperty("permalink")]
        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Current variation price. 
        /// read-only
        /// </summary>
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Price { get; set; }

        /// <summary>
        /// Variation regular price.
        /// </summary>
        [JsonProperty("regular_price")]
        [JsonPropertyName("regular_price")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? RegularPrice { get; set; }

        /// <summary>
        /// Variation sale price.
        /// </summary>
        [JsonProperty("sale_price")]
        [JsonPropertyName("sale_price")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? SalePrice { get; set; }

        /// <summary>
        /// Start date of sale price, in the site’s timezone.
        /// </summary>
        
        [JsonProperty("date_on_sale_from")]
        [JsonPropertyName("date_on_sale_from")]
        public DateTime? DateOnSaleFrom { get; set; }

        /// <summary>
        /// Start date of sale price, as GMT.
        /// </summary>
        
        [JsonProperty("date_on_sale_from_gmt")]
        [JsonPropertyName("date_on_sale_from_gmt")]
        public DateTime? DateOnSaleFromGmt { get; set; }

        /// <summary>
        /// End date of sale price, in the site’s timezone.
        /// </summary>
        
        [JsonProperty("date_on_sale_to")]
        [JsonPropertyName("date_on_sale_to")]
        public DateTime? DateOnSaleTo { get; set; }

        /// <summary>
        /// End date of sale price, in the site’s timezone.
        /// </summary>
        
        [JsonProperty("date_on_sale_to_gmt")]
        [JsonPropertyName("date_on_sale_to_gmt")]
        public DateTime? DateOnSaleToGmt { get; set; }

        /// <summary>
        /// Shows if the variation is on sale. 
        /// read-only
        /// </summary>
        
        [JsonProperty("on_sale")]
        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; set; }

        /// <summary>
        /// Define if the attribute is visible on the “Additional information” tab in the product’s page. Default is true.
        /// </summary>
        
        [JsonProperty("visible")]
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// Shows if the variation can be bought. 
        /// read-only
        /// </summary>
        
        [JsonProperty("purchasable")]
        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }

        /// <summary>
        /// If the variation is virtual. Default is false.
        /// </summary>
        [JsonProperty("virtual")]
        [JsonPropertyName("virtual")]
        public bool? Virtual { get; set; }

        /// <summary>
        /// If the variation is downloadable. Default is false.
        /// </summary>
        
        [JsonProperty("downloadable")]
        [JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// List of downloadable files. See Product variation - Downloads properties
        /// </summary>
        
        [JsonProperty("downloads")]
        [JsonPropertyName("downloads")]
        public List<VariationDownload> Downloads { get; set; }

        /// <summary>
        /// Number of times downloadable files can be downloaded after purchase. Default is -1.
        /// </summary>
        
        [JsonProperty("download_limit")]
        [JsonPropertyName("download_limit")]
        public int? DownloadLimit { get; set; }

        /// <summary>
        /// Number of days until access to downloadable files expires. Default is -1.
        /// </summary>
        
        [JsonProperty("download_expiry")]
        [JsonPropertyName("download_expiry")]
        public int? DownloadExpiry { get; set; }

        /// <summary>
        /// Tax status. Options: taxable, shipping and none. Default is taxable.
        /// </summary>
        
        [JsonProperty("tax_status")]
        [JsonPropertyName("tax_status")]
        public string TaxStatus { get; set; }

        /// <summary>
        /// Tax class.
        /// </summary>
        
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Stock management at variation level. Default is false.
        /// When Manage stock is checked, string value "parent" will be given, otherwise, it will be bool value false.
        /// </summary>
        
        [JsonProperty("manage_stock")]
        [JsonPropertyName("manage_stock")]
        public object ManageStock { get; set; }

        /// <summary>
        /// Stock quantity.
        /// </summary>
        [JsonProperty("stock_quantity")]
        [JsonPropertyName("stock_quantity")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Controls whether or not the variation is listed as “in stock” or “out of stock” on the frontend. Default is true.
        /// </summary>
        
        [JsonProperty("in_stock")]
        [JsonPropertyName("in_stock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// If managing stock, this controls if backorders are allowed. Options: no, notify and yes. Default is no.
        /// </summary>
        
        [JsonProperty("backorders")]
        [JsonPropertyName("backorders")]
        public string Backorders { get; set; }

        /// <summary>
        /// Shows if backorders are allowed. 
        /// read-only
        /// </summary>
        
        [JsonProperty("backorders_allowed")]
        [JsonPropertyName("backorders_allowed")]
        public bool? BackordersAllowed { get; set; }

        /// <summary>
        /// Shows if the variation is on backordered. 
        /// read-only
        /// </summary>
        
        [JsonProperty("backordered")]
        [JsonPropertyName("backordered")]
        public bool? Backordered { get; set; }

        /// <summary>
        /// Variation weight (kg).
        /// </summary>
        [JsonProperty("weight")]
        [JsonPropertyName("weight")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Variation dimensions. See Product variation - Dimensions properties
        /// </summary>
        
        [JsonProperty("dimensions")]
        [JsonPropertyName("dimensions")]
        public VariationDimension Dimensions { get; set; }

        /// <summary>
        /// Shipping class slug.
        /// </summary>
        
        [JsonProperty("shipping_class")]
        [JsonPropertyName("shipping_class")]
        public string ShippingClass { get; set; }

        /// <summary>
        /// Shipping class ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("shipping_class_id")]
        [JsonPropertyName("shipping_class_id")]
        public string ShippingClassId { get; set; }

        /// <summary>
        /// Variation image data. See Product variation - Image properties
        /// </summary>
        
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public VariationImage Image { get; set; }

        /// <summary>
        /// List of attributes. See Product variation - Attributes properties
        /// </summary>
        
        [JsonProperty("attributes")]
        [JsonPropertyName("attributes")]
        public List<VariationAttribute> Attributes { get; set; }

        /// <summary>
        /// Menu order, used to custom sort products.
        /// </summary>
        
        [JsonProperty("menu_order")]
        [JsonPropertyName("menu_order")]
        public uint MenuOrder { get; set; }

        /// <summary>
        /// Meta data. See Product variation - Meta data properties
        /// </summary>
        
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<VariationMeta> MetaData { get; set; }

        /// <summary>
        /// Container for error information, if any
        /// </summary>
        
        [JsonProperty("error")]
        [JsonPropertyName("error")]
        public VariationError Error { get; set; }
    }
    
    
    public class VariationDownload
    {
        /// <summary>
        /// File MD5 hash. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// File URL.
        /// </summary>
        
        [JsonProperty("file")]
        [JsonPropertyName("file")]
        public string File { get; set; }

    }
    
    
    public class VariationDimension
    {
        /// <summary>
        /// Variation length (cm).
        /// </summary>
        
        [JsonProperty("length")]
        [JsonPropertyName("length")]
        public string Length { get; set; }

        /// <summary>
        /// Variation width (cm).
        /// </summary>
        
        [JsonProperty("width")]
        [JsonPropertyName("width")]
        public string Width { get; set; }

        /// <summary>
        /// Variation height (cm).
        /// </summary>
        
        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public string Height { get; set; }

    }
    
    
    public class VariationImage
    {
        /// <summary>
        /// Image ID.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the image was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the image was created, as GMT. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        /// <summary>
        /// The date the image was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// The date the image was last modified, as GMT. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified_gmt")]
        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

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

        /// <summary>
        /// Image position. 0 means that the image is featured.
        /// </summary>
        
        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int? Position { get; set; }
    }
    
    
    public class VariationAttribute
    {
        /// <summary>
        /// Attribute ID.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Attribute name.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Selected attribute term name.
        /// </summary>
        
        [JsonProperty("option")]
        [JsonPropertyName("option")]
        public string Option { get; set; }

    }
    
    
    public class VariationMeta : WcObject.MetaData
    {
        
    }

    
    public class VariationError : JsonObject
    {
        [JsonProperty( "code" )]
        [JsonPropertyName( "code" )]
        public string Code { get; set; }

        [JsonProperty( "message" )]
        [JsonPropertyName( "message" )]
        public string Message { get; set; }

        [JsonProperty( "data" )]
        [JsonPropertyName( "data" )]
        public object Data { get; set; }
    }
}
