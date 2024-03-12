using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.Legacy
{
    [CollectionDataContract]
    public class ProductList : List<Product>
    {
        [DataMember]
        [JsonProperty("products")]
        [JsonPropertyName("products")]
        public List<Product> Products { get; set; }
    }


    [DataContract]
    public class Product : JsonObject
    {
        /// <summary>
        /// Product name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Product ID (post ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Product slug 
        /// edit-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// UTC DateTime when the product was created 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the product was last updated 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Product type. By default in WooCommerce the following types are available: simple, grouped, external, variable. Default is simple
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Product status (post status). Default is publish
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// If the product is downloadable or not. Downloadable products give access to a file upon purchase
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("downloadable")]
        [JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// If the product is virtual or not. Virtual products are intangible and are not shipped
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "virtual")]
        [JsonProperty("virtual")]
        [JsonPropertyName("virtual")]
        public bool? Isvirtual { get; set; }

        /// <summary>
        /// Product URL (post permalink) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("permalink")]
        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// SKU refers to a Stock-keeping unit, a unique identifier for each distinct product and service that can be purchased
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Current product price. This is set from regular_price and sale_price 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "price")]        
        private object PriceValue { get; set; }

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Product regular price
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "regular_price")]
        private object RegularPriceValue { get; set; }

        [JsonProperty("regular_price")]
        [JsonPropertyName("regular_price")]
        public decimal? RegularPrice { get; set; }

        /// <summary>
        /// Product sale price
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "sale_price")]
        private object SalePriceValue { get; set; }

        [JsonProperty("sale_price")]
        [JsonPropertyName("sale_price")]
        public decimal? SalePrice { get; set; }

        /// <summary>
        /// Sets the sale start date. Date in the YYYY-MM-DD format 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sale_price_dates_from")]
        [JsonPropertyName("sale_price_dates_from")]
        public decimal? SalePriceDatesFrom { get; set; }

        /// <summary>
        /// Sets the sale end date. Date in the YYYY-MM-DD format 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sale_price_dates_to")]
        [JsonPropertyName("sale_price_dates_to")]
        public decimal? SalePriceDatesTo { get; set; }

        /// <summary>
        /// Price formatted in HTML, e.g. delspan class=\"amount\"#36;nbsp;3.00/span/del insspan class=\"amount\"#36;nbsp;2.00/span/ins 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("price_html")]
        [JsonPropertyName("price_html")]
        public string PriceHtml { get; set; }

        /// <summary>
        /// Show if the product is taxable or not 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("taxable")]
        [JsonPropertyName("taxable")]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Tax status. The options are: taxable, shipping (Shipping only) and none
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_status")]
        [JsonPropertyName("tax_status")]
        public string TaxStatus { get; set; }

        /// <summary>
        /// Tax class
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Enable stock management at product level
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("managing_stock")]
        [JsonPropertyName("managing_stock")]
        public bool? ManagingStock { get; set; }

        /// <summary>
        /// Stock quantity. If is a variable product this value will be used to control stock for all variations, unless you define stock at variation level.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("stock_quantity")]
        [JsonPropertyName("stock_quantity")]
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Controls whether or not the product is listed as “in stock” or “out of stock” on the frontend.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("in_stock")]
        [JsonPropertyName("in_stock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// Shows if backorders are allowed 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("backorders_allowed")]
        [JsonPropertyName("backorders_allowed")]
        public bool? BackordersAllowed { get; set; }

        /// <summary>
        /// Shows if a product is on backorder (if the product have the stock_quantity negative) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("backordered")]
        [JsonPropertyName("backordered")]
        public bool? Backordered { get; set; }

        /// <summary>
        /// If managing stock, this controls whether or not backorders are allowed. If enabled, stock quantity can go below 0. The options are: false (Do not allow), notify (Allow, but notify customer), and true (Allow) 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("backorders")]
        [JsonPropertyName("backorders")]
        public object Backorders { get; set; }

        /// <summary>
        /// When true this only allow one item to be bought in a single order
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sold_individually")]
        [JsonPropertyName("sold_individually")] 
        public bool? SoldIndividually { get; set; }

        /// <summary>
        /// Shows if the product can be bought 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("purchaseable")]
        [JsonPropertyName("purchaseable")]
        public bool? Purchaseable { get; set; }

        /// <summary>
        /// Featured Product
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("featured")]
        [JsonPropertyName("featured")]
        public bool? Featured { get; set; }

        /// <summary>
        /// Shows whether or not the product is visible in the catalog 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("visible")]
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// Catalog visibility. The following options are available: visible (Catalog and search), catalog (Only in catalog), search (Only in search) and hidden (Hidden from all). Default is visible
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("catalog_visibility")]
        [JsonPropertyName("catalog_visibility")]
        public string CatalogVisibility { get; set; }

        /// <summary>
        /// Shows if the product is on sale or not 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("on_sale")]
        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; set; }

        /// <summary>
        /// Product weight in decimal format
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("weight")]
        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// List of the product dimensions. See Dimensions Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("dimensions")]
        [JsonPropertyName("dimensions")]
        public DimensionList Dimensions { get; set; }

        /// <summary>
        /// Shows if the product need to be shipped or not 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_required")]
        [JsonPropertyName("shipping_required")]
        public bool? ShippingRequired { get; set; }

        /// <summary>
        /// Shows whether or not the product shipping is taxable 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_taxable")]
        [JsonPropertyName("shipping_taxable")]
        public bool? ShippingTaxable { get; set; }

        /// <summary>
        /// Shipping class slug. Shipping classes are used by certain shipping methods to group similar products
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_class")]
        [JsonPropertyName("shipping_class")]
        public string ShippingClass { get; set; }

        /// <summary>
        /// Shipping class ID 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_class_id")]
        [JsonPropertyName("shipping_class_id")]
        public int? ShippingClassId { get; set; }

        /// <summary>
        /// Product description
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Enable HTML for product description 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("enable_html_description")]
        [JsonPropertyName("enable_html_description")]
        public bool? EnableHtmlDescription { get; set; }

        /// <summary>
        /// Product short description
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("short_description")]
        [JsonPropertyName("short_description")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Enable HTML for product short description 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("enable_html_short_description")]
        [JsonPropertyName("enable_html_short_description")]
        public string EnableHtmlShortDescription { get; set; }

        /// <summary>
        /// Shows/define if reviews are allowed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("reviews_allowed")]
        [JsonPropertyName("reviews_allowed")]
        public bool? ReviewsAllowed { get; set; }

        /// <summary>
        /// Reviews average rating 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("average_rating")]
        [JsonPropertyName("average_rating")]
        public string AverageRating { get; set; }

        /// <summary>
        /// Amount of reviews that the product have 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("rating_count")]
        [JsonPropertyName("rating_count")]
        public int? RatingCount { get; set; }

        /// <summary>
        /// List of related products IDs (integer) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("related_ids")]
        [JsonPropertyName("related_ids")]
        public List<ulong> RelatedIds { get; set; }

        /// <summary>
        /// List of up-sell products IDs (integer). Up-sells are products which you recommend instead of the currently viewed product, for example, products that are more profitable or better quality or more expensive
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("upsell_ids")]
        [JsonPropertyName("upsell_ids")]
        public List<ulong> UpsellIds { get; set; }

        /// <summary>
        /// List of cross-sell products IDs. Cross-sells are products which you promote in the cart, based on the current product
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("cross_sell_ids")]
        [JsonPropertyName("cross_sell_ids")]
        public List<ulong> CrossSellIds { get; set; }

        /// <summary>
        /// Product parent ID (post_parent)
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("parent_id")]
        [JsonPropertyName("parent_id")]
        public ulong? ParentId { get; set; }

        /// <summary>
        /// List of product categories names (string). In write-mode need to pass a array of categories IDs (integer) (uses wp_set_object_terms())
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("categories")]
        [JsonPropertyName("categories")]
        public List<object> Categories { get; set; }

        /// <summary>
        /// List of product tags names (string). In write-mode need to pass a array of tags IDs (integer) (uses wp_set_object_terms())
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        /// <summary>
        /// List of products images. See Images Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("images")]
        [JsonPropertyName("images")]
        public ImageList Images { get; set; }

        /// <summary>
        /// Featured image URL 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("featured_src")]
        [JsonPropertyName("featured_src")]
        public string FeaturedSrc { get; set; }

        /// <summary>
        /// List of product attributes. See Attributes Properties. Note: the attribute must be registered in WooCommerce before.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("attributes")]
        [JsonPropertyName("attributes")]
        public AttributeList Attributes { get; set; }

        /// <summary>
        /// Defaults variation attributes. These are the attributes that will be pre-selected on the frontend. See Default Attributes Properties 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("default_attributes")]
        [JsonPropertyName("default_attributes")]
        public DefaultAttributeList DefaultAttributes { get; set; }

        /// <summary>
        /// List of downloadable files. See Downloads Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("downloads")]
        [JsonPropertyName("downloads")]
        public DownloadList Downloads { get; set; }

        /// <summary>
        /// Amount of times the product can be downloaded. In write-mode you can sent a blank string for unlimited re-downloads. e.g ''
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("download_limit")]
        [JsonPropertyName("download_limit")]
        public int? DownloadLimit { get; set; }

        /// <summary>
        /// Number of days that the customer has up to be able to download the product. In write-mode you can sent a blank string for never expiry. e.g ''
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("download_expiry")]
        [JsonPropertyName("download_expiry")]
        public int? DownloadExpiry { get; set; }

        /// <summary>
        /// Download type, this controls the schema. The available options are: '' (Standard Product), application (Application/Software) and music (Music)
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("download_type")]
        [JsonPropertyName("download_type")]
        public string DownloadType { get; set; }

        /// <summary>
        /// Optional note to send the customer after purchase.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("purchase_note")]
        [JsonPropertyName("purchase_note")]
        public string PurchaseNote { get; set; }

        /// <summary>
        /// Amount of sales 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total_sales")]
        [JsonPropertyName("total_sales")]
        public long? TotalSales { get; set; }

        /// <summary>
        /// List of products variations. See Variations Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("variations")]
        [JsonPropertyName("variations")]
        public VariationList Variations { get; set; }

        /// <summary>
        /// List the product parent data when query for a variation 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public List<object> Parent { get; set; }

        /// <summary>
        /// Product external URL. Only for external products 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("product_url")]
        [JsonPropertyName("product_url")]
        public string ProductUrl { get; set; }

        /// <summary>
        /// Product external button text. Only for external products 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("button_text")]
        [JsonPropertyName("button_text")]
        public string ButtonText { get; set; }

        /// <summary>
        /// Menu order, used to custom sort products
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("menu_order")]
        [JsonPropertyName("menu_order")]
        public int? MenuOrder { get; set; }
    }


    [CollectionDataContract]
    public class DimensionList : List<Dimension>
    {
        [DataMember]
        [JsonProperty("dimensions")]
        [JsonPropertyName("dimensions")]
        public List<Dimension> Dimensions { get; set; }
    }

    [DataContract]
    public class Dimension
    {
        /// <summary>
        /// Product length in decimal format
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("length")]
        [JsonPropertyName("length")]
        public string Length { get; set; }

        /// <summary>
        /// Product width in decimal format
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("width")]
        [JsonPropertyName("width")]
        public string Width { get; set; }

        /// <summary>
        /// Product height in decimal format
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("height")]
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// Product name 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("unit")]
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

    }


    [CollectionDataContract]
    public class ImageList : List<Image>
    {
        [DataMember]
        [JsonProperty("images")]
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }
    }

    [DataContract]
    public class Image
    {
        /// <summary>
        /// Image ID (attachment ID)
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime when the image was created 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the image was last updated 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Image URL. In write-mode you can use to send new images
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("src")]
        [JsonPropertyName("src")]
        public string Src { get; set; }

        /// <summary>
        /// Image title (attachment title)
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Image alt text (attachment image alt text)
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("alt")]
        [JsonPropertyName("alt")]
        public string Alt { get; set; }

        /// <summary>
        /// Image position. 0 means that the image is featured
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int? Position { get; set; }
    }


    [CollectionDataContract]
    public class AttributeList : List<Attribute>
    {
        [DataMember]
        [JsonProperty("attributes")]
        [JsonPropertyName("attributes")]
        public List<Attribute> Attributes { get; set; }
    }

    [DataContract]
    public class Attribute
    {
        /// <summary>
        /// Attribute name 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Attribute slug
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Attribute position
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("position")]
        [JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Shows/define if the attribute is visible on the “Additional Information” tab in the product’s page
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("visible")]
        [JsonPropertyName("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// Shows/define if the attribute can be used as variation
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("variation")]
        [JsonPropertyName("variation")]
        public bool Variation { get; set; }

        /// <summary>
        /// List of available term names of the attribute
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("options")]
        [JsonPropertyName("options")]
        public List<string> Options { get; set; }
    }


    [CollectionDataContract]
    public class DefaultAttributeList : List<DefaultAttribute>
    {
        [DataMember]
        [JsonProperty("default_attributes")]
        [JsonPropertyName("default_attributes")]
        public List<DefaultAttribute> DefaultAttributes { get; set; }
    }

    [DataContract]
    public class DefaultAttribute
    {
        /// <summary>
        /// Attribute name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Attribute slug
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Selected term name of the attribute
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("option")]
        [JsonPropertyName("option")]
        public string Option { get; set; }

    }


    [CollectionDataContract]
    public class DownloadList : List<Download>
    {
        [DataMember]
        [JsonProperty("downloads")]
        [JsonPropertyName("downloads")]
        public List<Download> Downloads { get; set; }
    }

    [DataContract]
    public class Download
    {
        /// <summary>
        /// File ID (file md5 hash) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// File URL. In write-mode you can use this property to send new files
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("file")]
        [JsonPropertyName("file")]
        public string File { get; set; }
    }


    [CollectionDataContract]
    public class VariationList : List<Variation>
    {
        [DataMember]
        [JsonProperty("variations")]
        [JsonPropertyName("variations")]
        public List<Variation> Variations { get; set; }
    }

    [DataContract]
    public class Variation
    {
        /// <summary>
        /// Variation ID (post ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime when the variation was created 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the variation was last updated 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// If the variation is downloadable or not. Downloadable variations give access to a file upon purchase
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("downloadable")]
        [JsonPropertyName("downloadable")]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// If the variation is virtual or not. Virtual variations are intangible and aren’t shipped
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "virtual")]
        [JsonProperty("virtual")]
        [JsonPropertyName("virtual")]
        public bool? Isvirtual { get; set; }

        /// <summary>
        /// Variation URL (post permalink) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("permalink")]
        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        /// <summary>
        /// SKU refers to a Stock-keeping unit, a unique identifier for each distinct product and service that can be purchased
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Current variation price. This is set from regular_price and sale_price 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "price")]
        private object PriceValue { get; set; }

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Variation regular price
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "regular_price")]
        private object RegularPriceValue { get; set; }

        [JsonProperty("regular_price")]
        [JsonPropertyName("regular_price")]
        public decimal? RegularPrice { get; set; }

        /// <summary>
        /// Variation sale price
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "sale_price")]
        private object SalePriceValue { get; set; }

        [JsonProperty("sale_price")]
        [JsonPropertyName("sale_price")]
        public decimal? SalePrice { get; set; }

        /// <summary>
        /// Sets the sale start date. Date in the YYYY-MM-DD format 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sale_price_dates_from")]
        [JsonPropertyName("sale_price_dates_from")]
        public string SalePriceDatesFrom { get; set; }

        /// <summary>
        /// Sets the sale end date. Date in the YYYY-MM-DD format 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sale_price_dates_to")]
        [JsonPropertyName("sale_price_dates_to")]
        public string SalePriceDatesTo { get; set; }

        /// <summary>
        /// Show if the variation is taxable or not 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("taxable")]
        [JsonPropertyName("taxable")]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Tax status. The options are: taxable, shipping (Shipping only) and none
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_status")]
        [JsonPropertyName("tax_status")]
        public string TaxStatus { get; set; }

        /// <summary>
        /// Tax class
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Enable stock management at variation level
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("managing_stock")]
        [JsonPropertyName("managing_stock")]
        public bool? ManagingStock { get; set; }

        /// <summary>
        /// Stock quantity. If is a variable variation this value will be used to control stock for all variations, unless you define stock at variation level.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("stock_quantity")]
        [JsonPropertyName("stock_quantity")]
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Controls whether or not the variation is listed as “in stock” or “out of stock” on the frontend.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("in_stock")]
        [JsonPropertyName("in_stock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// Shows if a variation is on backorder (if the variation have the stock_quantity negative) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("backordered")]
        [JsonPropertyName("backordered")]
        public bool? Backordered { get; set; }

        /// <summary>
        /// Shows if the variation can be bought 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("purchaseable")]
        [JsonPropertyName("purchaseable")]
        public bool? Purchaseable { get; set; }

        /// <summary>
        /// Shows whether or not the product parent is visible in the catalog 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("visible")]
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// Shows if the variation is on sale or not 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("on_sale")]
        [JsonPropertyName("on_sale")]
        public bool? OnSale { get; set; }

        /// <summary>
        /// Variation weight in decimal format
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("weight")]
        [JsonPropertyName("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// List of the variation dimensions. See Dimensions Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("dimensions")]
        [JsonPropertyName("dimensions")]
        public DimensionList Dimensions { get; set; }

        /// <summary>
        /// Shipping class slug. Shipping classes are used by certain shipping methods to group similar products
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_class")]
        [JsonPropertyName("shipping_class")]
        public string ShippingClass { get; set; }

        /// <summary>
        /// Shipping class ID 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_class_id")]
        [JsonPropertyName("shipping_class_id")]
        public int? ShippingClassId { get; set; }

        /// <summary>
        /// Variation featured image. Only position 0 will be used. See Images Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public ImageList Image { get; set; }

        /// <summary>
        /// List of variation attributes. Similar to a simple or variable product, but for variation indicate the attributes used to form the variation. See Attributes Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("attributes")]
        [JsonPropertyName("attributes")]
        public AttributeList Attributes { get; set; }

        /// <summary>
        /// List of downloadable files. See Downloads Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("downloads")]
        [JsonPropertyName("downloads")]
        public DownloadList Downloads { get; set; }

        /// <summary>
        /// Amount of times the variation can be downloaded. In write-mode you can sent a blank string for unlimited re-downloads. e.g ''
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("download_limit")]
        [JsonPropertyName("download_limit")]
        public int? DownloadLimit { get; set; }

        /// <summary>
        /// Number of days that the customer has up to be able to download the variation. In write-mode you can sent a blank string for never expiry. e.g ''
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("download_expiry")]
        [JsonPropertyName("download_expiry")]
        public int? DownloadExpiry { get; set; }
    }

    [DataContract]
    public class ProductAttribute
    {
        /// <summary>
        /// Attribute ID 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Attribute name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Attribute slug
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Attribute type, the types available include by default are: select and text (some plugins can include new types)
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Default sort order. Available: menu_order, name, name_num and id
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("order_by")]
        [JsonPropertyName("order_by")]
        public string OrderBy { get; set; }

        /// <summary>
        /// Enable/Disable attribute archives
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("has_archives")]
        [JsonPropertyName("has_archives")]
        public bool? HasArchives { get; set; }


    }

    [DataContract]
    public class ProductAttributeTerm
    {
        /// <summary>
        /// Term ID (term ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Term name 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Term slug
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Shows the quantity of products in this term 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }


    [CollectionDataContract]
    public class ProductCategoryList : List<ProductCategory>
    {
        [DataMember]
        [JsonProperty("product_categories")]
        [JsonPropertyName("product_categories")]
        public List<ProductCategory> ProductCategories { get; set; }
    }

    [DataContract]
    public class ProductCategory
    {
        /// <summary>
        /// Category ID (term ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Category name 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Category slug
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Category parent
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public ulong? Parent { get; set; }

        /// <summary>
        /// Category description
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Category archive display type, the types available include: default, products, subcategories and both
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("display")]
        [JsonPropertyName("display")]
        public string Display { get; set; }

        /// <summary>
        /// Category image URL
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// Shows the quantity of products in this category 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }

    [DataContract]
    public class ShippingClass
    {
        /// <summary>
        /// Shipping Class ID (term ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Shipping Class name 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipping Class slug
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Shipping Class parent
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public ulong? Parent { get; set; }

        /// <summary>
        /// Shipping Class description
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Shows the quantity of products in this shipping class 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }

    [DataContract]
    public class ProductTag
    {
        /// <summary>
        /// Tag ID (term ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Tag name 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tag slug
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Tag description
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Shows the quantity of products in this tag 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int? Count { get; set; }
    }


    [CollectionDataContract]
    public class ProductReviewList : List<ProductReview>
    {
        [DataMember]
        [JsonProperty("product_reviews")]
        [JsonPropertyName("product_reviews")]
        public List<ProductReview> ProductReviews { get; set; }
    }

    [DataContract]
    public class ProductReview
    {
        /// <summary>
        /// Review ID (comment ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime when the review was created 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Review rating (0 to 5) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("rating")]
        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// Reviewer name 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("reviewer_name")]
        [JsonPropertyName("reviewer_name")]
        public string ReviewerName { get; set; }

        /// <summary>
        /// Reviewer email 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("reviewer_email")]
        [JsonPropertyName("reviewer_email")]
        public string ReviewerEmail { get; set; }

        /// <summary>
        /// Shows if the reviewer bought the product or not 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("verified")]
        [JsonPropertyName("verified")]
        public bool? Verified { get; set; }
    }
}
