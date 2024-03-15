using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce.v1
{
    [KnownType(typeof(ProductBatch))]
    public class ProductBatch : BatchObject<Product> { }

    
    public class Product : JsonObject
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Product slug.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Product URL. 
        /// read-only
        /// </summary>
        
        [JsonProperty("permalink")]
        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// The date the product was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the product was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Product type. Default is simple. Options (plugins may add new options): simple, grouped, external, variable.
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Product status (post status). Default is publish. Options (plugins may add new options): draft, pending, private and publish.
        /// </summary>
        
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Featured product. Default is false.
        /// </summary>
        
        [JsonProperty("featured")]
        [JsonPropertyName("featured")]
        public bool? Featured { get; set; }

        /// <summary>
        /// Catalog visibility. Default is visible. Options: visible (Catalog and search), catalog (Only in catalog), search (Only in search) and hidden (Hidden from all).
        /// </summary>
        
        [JsonProperty("catalog_visibility")]
        [JsonPropertyName("catalog_visibility")]
        public string CatalogVisibility { get; set; }

        /// <summary>
        /// Product description.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Enable HTML for product description 
        /// write-only
        /// </summary>
        
        [JsonProperty("enable_html_description")]
        [JsonPropertyName("enable_html_description")]
        public bool? EnableHtmlDescription { get; set; }

        /// <summary>
        /// Product short description.
        /// </summary>
        
        [JsonProperty("short_description")]
        [JsonPropertyName("short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Enable HTML for product short description 
        /// write-only
        /// </summary>
        
        [JsonProperty("enable_html_short_description")]
        [JsonPropertyName("enable_html_short_description")]
        public string EnableHtmlShortDescription { get; set; }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Current product price. This is setted from regular_price and sale_price. 
        /// read-only
        /// </summary>
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Price { get; set; }

        /// <summary>
        /// Product regular price.
        /// </summary>
        [JsonProperty("regular_price")]
        [JsonPropertyName("regular_price")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? RegularPrice { get; set; }

        /// <summary>
        /// Product sale price.
        /// </summary>
        [JsonProperty("sale_price")]
        [JsonPropertyName("sale_price")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? SalePrice { get; set; }

        /// <summary>
        /// Start date of sale price. Date in the YYYY-MM-DD format.
        /// </summary>
        
        [JsonProperty("date_on_sale_from")]
        [JsonPropertyName("date_on_sale_from")]
        public string DateOnSaleFrom { get; set; }

        /// <summary>
        /// Sets the sale end date. Date in the YYYY-MM-DD format.
        /// </summary>
        
        [JsonProperty("date_on_sale_to")]
        [JsonPropertyName("date_on_sale_to")]
        public string DateOnSaleTo { get; set; }

        /// <summary>
        /// Price formatted in HTML, e.g. delspan class=\"woocommerce-Price-amount amount\"span class=\"woocommerce-Price-currencySymbol\"#36;nbsp;3.00/span/span/del insspan class=\"woocommerce-Price-amount amount\"span class=\"woocommerce-Price-currencySymbol\"#36;nbsp;2.00/span/span/ins 
        /// read-only
        /// </summary>
        
        [JsonProperty("price_html")]
        [JsonPropertyName("price_html")]
        public string PriceHtml { get; set; }

        /// <summary>
        /// Shows if the product is on sale. 
        /// read-only
        /// </summary>
        
        [JsonProperty("on_sale")]
        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; set; }

        /// <summary>
        /// Shows if the product can be bought. 
        /// read-only
        /// </summary>
        
        [JsonProperty("purchasable")]
        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }

        /// <summary>
        /// Amount of sales. 
        /// read-only
        /// </summary>
        [JsonProperty("total_sales")]
        [JsonPropertyName("total_sales")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? TotalSales { get; set; }

        /// <summary>
        /// If the product is virtual. Virtual products are intangible and aren’t shipped. Default is false.
        /// </summary>
        [JsonProperty("virtual")]
        [JsonPropertyName("virtual")]
        public bool? Virtual { get; set; }

        /// <summary>
        /// If the product is downloadable. Downloadable products give access to a file upon purchase. Default is false.
        /// </summary>
        
        [JsonProperty("downloadable")]
        [JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// List of downloadable files. See Downloads properties.
        /// </summary>
        
        [JsonProperty("downloads")]
        [JsonPropertyName("downloads")]
        public List<Download> Downloads { get; set; }

        /// <summary>
        /// Amount of times the product can be downloaded, the -1 values means unlimited re-downloads. Default is -1.
        /// </summary>
        
        [JsonProperty("download_limit")]
        [JsonPropertyName("download_limit")]
        public int? DownloadLimit { get; set; }

        /// <summary>
        /// Number of days that the customer has up to be able to download the product, the -1 means that downloads never expires. Default is -1.
        /// </summary>
        
        [JsonProperty("download_expiry")]
        [JsonPropertyName("download_expiry")]
        public int? DownloadExpiry { get; set; }

        /// <summary>
        /// Download type, this controls the schema on the front-end. Default is standard. Options: 'standard' (Standard Product), application (Application/Software) and music (Music).
        /// </summary>
        
        [JsonProperty("download_type")]
        [JsonPropertyName("download_type")]
        public string DownloadType { get; set; }

        /// <summary>
        /// Product external URL. Only for external products.
        /// </summary>
        
        [JsonProperty("external_url")]
        [JsonPropertyName("external_url")]
        public string ExternalUrl { get; set; }

        /// <summary>
        /// Product external button text. Only for external products.
        /// </summary>
        
        [JsonProperty("button_text")]
        [JsonPropertyName("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// Tax status. Default is taxable. Options: taxable, shipping (Shipping only) and none.
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
        /// Stock management at product level. Default is false.
        /// When Manage stock is checked, string value "parent" will be given, otherwise, it will be bool value false.
        /// </summary>
        
        [JsonProperty("manage_stock")]
        [JsonPropertyName("manage_stock")]
        public object ManageStock { get; set; }

        /// <summary>
        /// Stock quantity. If is a variable product this value will be used to control stock for all variations, unless you define stock at variation level.
        /// </summary>
        
        [JsonProperty("stock_quantity")]
        [JsonPropertyName("stock_quantity")]
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Controls whether or not the product is listed as “in stock” or “out of stock” on the frontend. Default is true.
        /// </summary>
        
        [JsonProperty("in_stock")]
        [JsonPropertyName("in_stock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// If managing stock, this controls if backorders are allowed. If enabled, stock quantity can go below 0. Default is no. Options are: no (Do not allow), notify (Allow, but notify customer), and yes (Allow).
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
        /// Shows if a product is on backorder (if the product have the stock_quantity negative). 
        /// read-only
        /// </summary>
        
        [JsonProperty("backordered")]
        [JsonPropertyName("backordered")]
        public bool? Backordered { get; set; }

        /// <summary>
        /// Allow one item to be bought in a single order. Default is false.
        /// </summary>
        
        [JsonProperty("sold_individually")]
        [JsonPropertyName("sold_individually")]
        public bool? SoldIndividually { get; set; }

        /// <summary>
        /// Product weight in decimal format.
        /// </summary>
        [JsonProperty("weight")]
        [JsonPropertyName("weight")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Product dimensions. See Dimensions properties.
        /// </summary>
        
        [JsonProperty("dimensions")]
        [JsonPropertyName("dimensions")]
        public Dimension Dimensions { get; set; }

        /// <summary>
        /// Shows if the product need to be shipped. 
        /// read-only
        /// </summary>
        
        [JsonProperty("shipping_required")]
        [JsonPropertyName("shipping_required")]
        public bool? ShippingRequired { get; set; }

        /// <summary>
        /// Shows whether or not the product shipping is taxable. 
        /// read-only
        /// </summary>
        
        [JsonProperty("shipping_taxable")]
        [JsonPropertyName("shipping_taxable")]
        public bool? ShippingTaxable { get; set; }

        /// <summary>
        /// Shipping class slug. Shipping classes are used by certain shipping methods to group similar products.
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
        public int? ShippingClassId { get; set; }

        /// <summary>
        /// Allow reviews. Default is true.
        /// </summary>
        
        [JsonProperty("reviews_allowed")]
        [JsonPropertyName("reviews_allowed")]
        public bool? ReviewsAllowed { get; set; }

        /// <summary>
        /// Reviews average rating. 
        /// read-only
        /// </summary>
        
        [JsonProperty("average_rating")]
        [JsonPropertyName("average_rating")]
        public string AverageRating { get; set; }

        /// <summary>
        /// Amount of reviews that the product have. 
        /// read-only
        /// </summary>
        
        [JsonProperty("rating_count")]
        [JsonPropertyName("rating_count")]
        public int? RatingCount { get; set; }

        /// <summary>
        /// List of related products IDs (integer). 
        /// read-only
        /// </summary>
        
        [JsonProperty("related_ids")]
        [JsonPropertyName("related_ids")]
        public List<ulong> RelatedIds { get; set; }

        /// <summary>
        /// List of up-sell products IDs (integer). Up-sells are products which you recommend instead of the currently viewed product, for example, products that are more profitable or better quality or more expensive.
        /// </summary>
        
        [JsonProperty("upsell_ids")]
        [JsonPropertyName("upsell_ids")]
        public List<ulong> UpsellIds { get; set; }

        /// <summary>
        /// List of cross-sell products IDs. Cross-sells are products which you promote in the cart, based on the current product.
        /// </summary>
        
        [JsonProperty("cross_sell_ids")]
        [JsonPropertyName("cross_sell_ids")]
        public List<ulong> CrossSellIds { get; set; }

        /// <summary>
        /// Product parent ID (post_parent).
        /// </summary>
        
        [JsonProperty("parent_id")]
        [JsonPropertyName("parent_id")]
        public ulong? ParentId { get; set; }

        /// <summary>
        /// Optional note to send the customer after purchase.
        /// </summary>
        
        [JsonProperty("purchase_note")]
        [JsonPropertyName("purchase_note")]
        public string PurchaseNote { get; set; }

        /// <summary>
        /// List of categories. See Categories properties.
        /// </summary>
        
        [JsonProperty("categories")]
        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// List of tags. See Tags properties.
        /// </summary>
        
        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// List of images. See Images properties
        /// </summary>
        
        [JsonProperty("images")]
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// List of attributes. See Attributes properties.
        /// </summary>
        
        [JsonProperty("attributes")]
        [JsonPropertyName("attributes")]
        public List<Attribute> Attributes { get; set; }

        /// <summary>
        /// Defaults variation attributes, used only for variations and pre-selecte attributes on the frontend. See Default Attributes properties.
        /// </summary>
        
        [JsonProperty("default_attributes")]
        [JsonPropertyName("default_attributes")]
        public List<DefaultAttribute> DefaultAttributes { get; set; }

        /// <summary>
        /// List of variations. See Variations properties
        /// </summary>
        
        [JsonProperty("variations")]
        [JsonPropertyName("variations")]
        public List<Variation> Variations { get; set; }

        /// <summary>
        /// List of grouped products ID, only for group type products. 
        /// read-only
        /// </summary>
        
        [JsonProperty("grouped_products")]
        [JsonPropertyName("grouped_products")]
        public List<int> GroupedProducts { get; set; }

        /// <summary>
        /// Menu order, used to custom sort products.
        /// </summary>
        
        [JsonProperty("menu_order")]
        [JsonPropertyName("menu_order")]
        public int? MenuOrder { get; set; }
    }

    
    public class Dimension
    {
        /// <summary>
        /// Product length in decimal format.
        /// </summary>
        
        [JsonProperty("length")]
        [JsonPropertyName("length")]
        public string Length { get; set; }

        /// <summary>
        /// Product width in decimal format.
        /// </summary>
        
        [JsonProperty("width")]
        [JsonPropertyName("width")]
        public string Width { get; set; }

        /// <summary>
        /// Product height in decimal format.
        /// </summary>
        
        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public string Height { get; set; }
    }

    [KnownType(typeof(CategoryBatch))]
    public class CategoryBatch : BatchObject<Category> { }

    
    public class Category
    {
        /// <summary>
        /// Category ID.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Category name. 
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Category slug. 
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }

    
    public class Tag
    {
        /// <summary>
        /// Tag ID.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Tag name. 
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tag slug. 
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
    }

    
    public class Image
    {
        /// <summary>
        /// Image ID (attachment ID). In write-mode used to attach pre-existing images.
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
        /// The date the image was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Image URL. In write-mode used to upload new images.
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

    [KnownType(typeof(AttributeBatch))]
    public class AttributeBatch : BatchObject<Attribute> { }

    
    public class Attribute
    {
        /// <summary>
        /// Attribute ID (required if is a global attribute).
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Attribute name (required if is a non-global attribute).
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Attribute position.
        /// </summary>
        
        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Define if the attribute is visible on the “Additional Information” tab in the product’s page. Default is false.
        /// </summary>
        
        [JsonProperty("visible")]
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// Define if the attribute can be used as variation. Default is false.
        /// </summary>
        
        [JsonProperty("variation")]
        [JsonPropertyName("variation")]
        public bool? Variation { get; set; }

        /// <summary>
        /// List of available term names of the attribute.
        /// </summary>
        
        [JsonProperty("options")]
        [JsonPropertyName("options")]
        public List<string> Options { get; set; }
    }

    
    public class DefaultAttribute
    {
        /// <summary>
        /// Attribute ID (required if is a global attribute).
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Attribute name (required if is a non-global attribute).
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

    
    public class Download
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
        /// File URL. In write-mode you can use this property to send new files.
        /// </summary>
        
        [JsonProperty("file")]
        [JsonPropertyName("file")]
        public string File { get; set; }
    }

    
    public class Variation : JsonObject
    {
        /// <summary>
        /// Variation ID. 
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
        /// Current variation price. This is setted from regular_price and sale_price. 
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
        /// Start date of sale price. Date in the YYYY-MM-DD format.
        /// </summary>
        
        [JsonProperty("date_on_sale_from")]
        [JsonPropertyName("date_on_sale_from")]
        public string DateOnSaleFrom { get; set; }

        /// <summary>
        /// Start date of sale price. Date in the YYYY-MM-DD format.
        /// </summary>
        
        [JsonProperty("date_on_sale_to")]
        [JsonPropertyName("date_on_sale_to")]
        public string DateOnSaleTo { get; set; }

        /// <summary>
        /// Shows if the variation is on sale. 
        /// read-only
        /// </summary>
        
        [JsonProperty("on_sale")]
        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; set; }

        /// <summary>
        /// Shows if the variation can be bought. 
        /// read-only
        /// </summary>
        
        [JsonProperty("purchasable")]
        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; set; }

        /// <summary>
        /// If the variation is virtual. Virtual variations are intangible and aren’t shipped. Default is false.
        /// </summary>
        [JsonProperty("virtual")]
        [JsonPropertyName("virtual")]
        public bool? Virtual { get; set; }

        /// <summary>
        /// If the variation is downloadable. Downloadable variations give access to a file upon purchase. Default is false.
        /// </summary>
        
        [JsonProperty("downloadable")]
        [JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// List of downloadable files. See Downloads properties.
        /// </summary>
        
        [JsonProperty("downloads")]
        [JsonPropertyName("downloads")]
        public List<Download> Downloads { get; set; }

        /// <summary>
        /// Amount of times the variation can be downloaded, the -1 values means unlimited re-downloads. Default is -1.
        /// </summary>
        
        [JsonProperty("download_limit")]
        [JsonPropertyName("download_limit")]
        public int? DownloadLimit { get; set; }

        /// <summary>
        /// Number of days that the customer has up to be able to download the variation, the -1 means that downloads never expires. Default is -1.
        /// </summary>
        
        [JsonProperty("download_expiry")]
        [JsonPropertyName("download_expiry")]
        public int? DownloadExpiry { get; set; }

        /// <summary>
        /// Tax status. Default is taxable. Options: taxable, shipping (Shipping only) and none.
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
        /// Stock quantity. If is a variable variation this value will be used to control stock for all variations, unless you define stock at variation level.
        /// </summary>
        
        [JsonProperty("stock_quantity")]
        [JsonPropertyName("stock_quantity")]
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Controls whether or not the variation is listed as “in stock” or “out of stock” on the frontend. Default is true.
        /// </summary>
        
        [JsonProperty("in_stock")]
        [JsonPropertyName("in_stock")]
        public bool InStock { get; set; }

        /// <summary>
        /// If managing stock, this controls if backorders are allowed. If enabled, stock quantity can go below 0. Default is no. Options are: no (Do not allow), notify (Allow, but notify customer), and yes (Allow).
        /// </summary>
        
        [JsonProperty("backorders")]
        [JsonPropertyName("backorders")]
        public string Backorders { get; set; }

        /// <summary>
        /// Shows if backorders are allowed.“ 
        /// read-only
        /// </summary>
        
        [JsonProperty("backorders_allowed")]
        [JsonPropertyName("backorders_allowed")]
        public bool? BackordersAllowed { get; set; }

        /// <summary>
        /// Shows if a variation is on backorder (if the variation have the stock_quantity negative). 
        /// read-only
        /// </summary>
        
        [JsonProperty("backordered")]
        [JsonPropertyName("backordered")]
        public bool? Backordered { get; set; }

        /// <summary>
        /// Shows if the variation can be bought 
        /// read-only
        /// </summary>
        
        [JsonProperty("purchaseable")]
        [JsonPropertyName("purchaseable")]
        public bool? Purchaseable { get; set; }

        /// <summary>
        /// Variation weight in decimal format.
        /// </summary>
        [JsonProperty("weight")]
        [JsonPropertyName("weight")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Variation dimensions. See Dimensions properties.
        /// </summary>
        
        [JsonProperty("dimensions")]
        [JsonPropertyName("dimensions")]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// Shipping class slug. Shipping classes are used by certain shipping methods to group similar products.
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
        public int? ShippingClassId { get; set; }

        /// <summary>
        /// Variation featured image. Only position 0 will be used. See Images properties.
        /// </summary>
        
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public List<Image> Image { get; set; }

        /// <summary>
        /// List of variation attributes. See Variation Attributes properties
        /// </summary>
        
        [JsonProperty("attributes")]
        [JsonPropertyName("attributes")]
        public List<VariationAttribute> Attributes { get; set; }
    }

    
    public class VariationAttribute
    {
        /// <summary>
        /// Attribute ID (required if is a global attribute).
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Attribute name (required if is a non-global attribute).
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

    
    public class ProductAttribute
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Attribute name. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
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
        /// Type of attribute. Default is select. Options: select and text (some plugins can include new types)
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Default sort order. Default is menu_order. Options: menu_order, name, name_num and id.
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
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Term name. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
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

    
    public class ProductCategory : Category
    {
        /// <summary>
        /// The id for the parent of the resource.
        /// </summary>
        
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public ulong? Parent { get; set; }

        /// <summary>
        /// HTML description of the resource.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Category archive display type. Default is default. Options: default, products, subcategories and both
        /// </summary>
        
        [JsonProperty("display")]
        [JsonPropertyName("display")]
        public string Display { get; set; }

        /// <summary>
        /// Image data. See Category Image properties
        /// </summary>
        
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public ProductCategoryImage Image { get; set; }

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

    
    public class ProductCategoryImage
    {
        /// <summary>
        /// Image ID (attachment ID). In write-mode used to attach pre-existing images.
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
        /// The date the image was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Image URL. In write-mode used to upload new images.
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

    [KnownType(typeof(ShippingClassBatch))]
    public class ShippingClassBatch : BatchObject<ShippingClass> { }

    
    public class ShippingClass
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Shipping class name. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
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
        /// Number of published products for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }

    [KnownType(typeof(ProductTagBatch))]
    public class ProductTagBatch : BatchObject<ProductTag> { }

    
    public class ProductTag
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Tag name. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
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
        /// Number of published products for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }

    
    public class ProductReview
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the review was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Review rating (0 to 5). 
        /// read-only
        /// </summary>
        
        [JsonProperty("rating")]
        [JsonPropertyName("rating")]
        public int? Rating { get; set; }

        /// <summary>
        /// Reviewer name. 
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Reviewer email. 
        /// read-only
        /// </summary>
        
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Shows if the reviewer bought the product or not. 
        /// read-only
        /// </summary>
        
        [JsonProperty("verified")]
        [JsonPropertyName("verified")]
        public bool? Verified { get; set; }
    }
}
