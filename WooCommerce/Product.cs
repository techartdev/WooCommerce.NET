using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce
{
    public class ProductBatch : BatchObject<Product> { }

    public class Product
    {
        public static string Endpoint => "products";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

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
        public string Permalink { get; private set; }

        /// <summary>
        /// The date the product was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// The date the product was created, as GMT. 
        /// read-only
        /// </summary>
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; private set; }

        /// <summary>
        /// The date the product was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; private set; }

        /// <summary>
        /// The date the product was last modified, as GMT. 
        /// read-only
        /// </summary>
        [JsonProperty("date_modified_gmt")]
        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; private set; }

        /// <summary>
        /// Product type. Options: simple, grouped, external and variable. Default is simple.
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Product status (post status). Options: draft, pending, private and publish. Default is publish.
        /// </summary>
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Featured product. Default is false.
        /// </summary>
        [JsonProperty("featured")]
        [JsonPropertyName("featured")]
        public bool Featured { get; set; }

        /// <summary>
        /// Catalog visibility. Options: visible, catalog, search and hidden. Default is visible.
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
        /// Current product price. 
        /// read-only
        /// </summary>
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Price { get; private set; }

        /// <summary>
        /// Product regular price.
        /// </summary>
        [JsonProperty("regular_price")]
        [JsonPropertyName("regular_price")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? RegularPrice { get; set; }

        /// <summary>
        /// Product sale price.
        /// </summary>
        [JsonProperty("sale_price")]
        [JsonPropertyName("sale_price")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
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
        /// Price formatted in HTML. 
        /// read-only
        /// </summary>
        [JsonProperty("price_html")]
        [JsonPropertyName("price_html")]
        public string PriceHtml { get; private set; }

        /// <summary>
        /// Shows if the product is on sale. 
        /// read-only
        /// </summary>
        [JsonProperty("on_sale")]
        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; private set; }

        /// <summary>
        /// Shows if the product can be bought. 
        /// read-only
        /// </summary>
        [JsonProperty("purchasable")]
        [JsonPropertyName("purchasable")]
        public bool? Purchasable { get; private set; }

        /// <summary>
        /// Amount of sales. 
        /// read-only
        /// </summary>
        [JsonProperty("total_sales")]
        [JsonPropertyName("total_sales")]
        public long? TotalSales { get; private set; }

        /// <summary>
        /// If the product is virtual. Default is false.
        /// </summary>
        [JsonProperty("virtual")]
        [JsonPropertyName("virtual")]
        public bool Virtual { get; set; }

        /// <summary>
        /// If the product is downloadable. Default is false.
        /// </summary>
        [JsonProperty("downloadable")]
        [JsonPropertyName("downloadable")]
        public bool Downloadable { get; set; }

        /// <summary>
        /// List of downloadable files. See Product - Downloads properties
        /// </summary>
        [JsonProperty("downloads")]
        [JsonPropertyName("downloads")]
        public List<ProductDownloadLine> Downloads { get; set; }

        /// <summary>
        /// Number of times downloadable files can be downloaded after purchase. Default is -1.
        /// </summary>
        [JsonProperty("download_limit")]
        [JsonPropertyName("download_limit")]
        public int DownloadLimit { get; set; } = -1;

        /// <summary>
        /// Number of days until access to downloadable files expires. Default is -1.
        /// </summary>
        [JsonProperty("download_expiry")]
        [JsonPropertyName("download_expiry")]
        public int DownloadExpiry { get; set; } = -1;

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
        /// Stock management at product level. Default is false.
        /// </summary>
        [JsonProperty("manage_stock")]
        [JsonPropertyName("manage_stock")]
        public bool ManageStock { get; set; }

        /// <summary>
        /// Stock quantity.
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
        /// Controls the stock status of the product. Options: instock, outofstock, onbackorder. Default is instock.
        /// </summary>
        [JsonProperty("stock_status")]
        [JsonPropertyName("stock_status")]
        public string StockStatus { get; set; }

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
        public bool? BackordersAllowed { get; private set; }

        /// <summary>
        /// Shows if the product is on backordered. 
        /// read-only
        /// </summary>
        [JsonProperty("backordered")]
        [JsonPropertyName("backordered")]
        public bool? Backordered { get; private set; }

        /// <summary>
        /// Allow one item to be bought in a single order. Default is false.
        /// </summary>

        [JsonProperty("sold_individually")]
        [JsonPropertyName("sold_individually")]
        public bool SoldIndividually { get; set; }

        /// <summary>
        /// Product weight (kg).
        /// </summary>
        [JsonProperty("weight")]
        [JsonPropertyName("weight")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Product dimensions. See Product - Dimensions properties
        /// </summary>
        [JsonProperty("dimensions")]
        [JsonPropertyName("dimensions")]
        public ProductDimension Dimensions { get; set; }

        /// <summary>
        /// Shows if the product need to be shipped. 
        /// read-only
        /// </summary>
        [JsonProperty("shipping_required")]
        [JsonPropertyName("shipping_required")]
        public bool? ShippingRequired { get; private set; }

        /// <summary>
        /// Shows whether or not the product shipping is taxable. 
        /// read-only
        /// </summary>
        [JsonProperty("shipping_taxable")]
        [JsonPropertyName("shipping_taxable")]
        public bool? ShippingTaxable { get; private set; }

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
        public ulong? ShippingClassId { get; private set; }

        /// <summary>
        /// Allow reviews. Default is true.
        /// </summary>
        [JsonProperty("reviews_allowed")]
        [JsonPropertyName("reviews_allowed")]
        public bool ReviewsAllowed { get; set; }

        /// <summary>
        /// Reviews average rating. 
        /// read-only
        /// </summary>
        [JsonProperty("average_rating")]
        [JsonPropertyName("average_rating")]
        public string AverageRating { get; private set; }

        /// <summary>
        /// Amount of reviews that the product have. 
        /// read-only
        /// </summary>
        [JsonProperty("rating_count")]
        [JsonPropertyName("rating_count")]
        public int? RatingCount { get; private set; }

        /// <summary>
        /// List of related products IDs. 
        /// read-only
        /// </summary>
        [JsonProperty("related_ids")]
        [JsonPropertyName("related_ids")]
        public List<ulong> RelatedIds { get; private set; }

        /// <summary>
        /// List of up-sell products IDs.
        /// </summary>
        [JsonProperty("upsell_ids")]
        [JsonPropertyName("upsell_ids")]
        public List<ulong> UpsellIds { get; set; }

        /// <summary>
        /// List of cross-sell products IDs.
        /// </summary>
        [JsonProperty("cross_sell_ids")]
        [JsonPropertyName("cross_sell_ids")]
        public List<ulong> CrossSellIds { get; set; }

        /// <summary>
        /// Product parent ID.
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
        /// List of categories. See Product - Categories properties
        /// </summary>
        [JsonProperty("categories")]
        [JsonPropertyName("categories")]
        public List<ProductCategoryLine> Categories { get; set; }

        /// <summary>
        /// List of tags. See Product - Tags properties
        /// </summary>
        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public List<ProductTagLine> Tags { get; set; }

        /// <summary>
        /// List of images. See Product - Images properties
        /// </summary>
        [JsonProperty("images")]
        [JsonPropertyName("images")]
        public List<ProductImage> Images { get; set; }

        /// <summary>
        /// List of attributes. See Product - Attributes properties
        /// </summary>
        [JsonProperty("attributes")]
        [JsonPropertyName("attributes")]
        public List<ProductAttributeLine> Attributes { get; set; }

        /// <summary>
        /// Defaults variation attributes. See Product - Default attributes properties
        /// </summary>
        [JsonProperty("default_attributes")]
        [JsonPropertyName("default_attributes")]
        public List<ProductDefaultAttribute> DefaultAttributes { get; set; }

        /// <summary>
        /// List of variations IDs. 
        /// read-only
        /// </summary>
        [JsonProperty("variations")]
        [JsonPropertyName("variations")]
        public List<int> Variations { get; private set; }

        /// <summary>
        /// List of grouped products ID. 
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

        /// <summary>
        /// Meta data. See Product - Meta data properties
        /// </summary>
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }
    }

    public class ProductDownloadLine
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

    public class ProductDimension
    {
        /// <summary>
        /// Product length (cm).
        /// </summary>        
        [JsonProperty("length")]
        [JsonPropertyName("length")]
        public string Length { get; set; }

        /// <summary>
        /// Product width (cm).
        /// </summary>        
        [JsonProperty("width")]
        [JsonPropertyName("width")]
        public string Width { get; set; }

        /// <summary>
        /// Product height (cm).
        /// </summary>        
        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public string Height { get; set; }
    }

    public class ProductCategoryLine
    {
        /// <summary>
        /// Category ID.
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        /// <summary>
        /// Category name. 
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Category slug. 
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }
    }

    public class ProductTagLine
    {
        /// <summary>
        /// Tag ID.
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        /// <summary>
        /// Tag name. 
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Tag slug. 
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }
    }

    public class ProductImage
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
        /// The date the image was created, as GMT. 
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

    public class ProductAttributeLine
    {
        /// <summary>
        /// Attribute ID.
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        /// <summary>
        /// Attribute name.
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Attribute position.
        /// </summary>        
        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// Define if the attribute is visible on the “Additional information” tab in the product’s page. Default is false.
        /// </summary>        
        [JsonProperty("visible")]
        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// Define if the attribute can be used as variation. Default is false.
        /// </summary>        
        [JsonProperty("variation")]
        [JsonPropertyName("variation")]
        public bool Variation { get; set; }

        /// <summary>
        /// List of available term names of the attribute.
        /// </summary>        
        [JsonProperty("options")]
        [JsonPropertyName("options")]
        public List<string> Options { get; set; }

    }

    public class ProductDefaultAttribute
    {
        /// <summary>
        /// Attribute ID.
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

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

    public class ProductReview
    {
        public static string Endpoint => "reviews";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }
                

        /// <summary>
        /// The date the review was created, in the site’s timezone.
        /// </summary>
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// The date the review was created, as GMT.
        /// </summary>
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; private set; }


        /// <summary>
        /// Unique identifier for the product that the review belongs to.
        /// </summary>
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; set; }

        /// <summary>
        /// Status of the review. Options: approved, hold, spam, unspam, trash and untrash. Defaults to approved.
        /// </summary>
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Reviewer name. 
        /// mandatory
        /// </summary>
        [JsonProperty("reviewer")]
        [JsonPropertyName("reviewer")]
        public string Reviewer { get; set; }

        /// <summary>
        /// Reviewer email. 
        /// mandatory
        /// </summary>
        [JsonProperty("reviewer_email")]
        [JsonPropertyName("reviewer_email")]
        public string ReviewerEmail { get; set; }

        /// <summary>
        /// The content of the review. 
        /// mandatory
        /// </summary>
        [JsonProperty("review")]
        [JsonPropertyName("review")]
        public string Review { get; set; }

        /// <summary>
        /// Review rating (0 to 5).
        /// </summary>
        [JsonProperty("rating")]
        [JsonPropertyName("rating")]
        public int? Rating { get; set; }

        /// <summary>
        /// Shows if the reviewer bought the product or not. 
        /// read-only
        /// </summary>
        [JsonProperty("verified")]
        [JsonPropertyName("verified")]
        public bool? Verified { get; set; }

    }
}
