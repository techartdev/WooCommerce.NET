using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce.v1
{
    [KnownType(typeof(OrderBatch))]
    public class OrderBatch : BatchObject<Order> { }

    
    public class Order : JsonObject
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Parent order ID.
        /// </summary>
        
        [JsonProperty("parent_id")]
        [JsonPropertyName("parent_id")]
        public ulong? ParentId { get; set; }

        /// <summary>
        /// Order status. Default is pending. Options (plugins may include new status): pending, processing, on-hold, completed, cancelled, refunded and failed.
        /// </summary>
        
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Order key. 
        /// read-only
        /// </summary>
        
        [JsonProperty("order_key")]
        [JsonPropertyName("order_key")]
        public string OrderKey { get; set; }

        /// <summary>
        /// Currency the order was created with, in ISO format, e.g USD. Default is the current store currency.
        /// </summary>
        
        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Version of WooCommerce when the order was made. 
        /// read-only
        /// </summary>
        
        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// Shows if the prices included tax during checkout. 
        /// read-only
        /// </summary>
        
        [JsonProperty("prices_include_tax")]
        [JsonPropertyName("prices_include_tax")]
        public bool? PricesIncludeTax { get; set; }

        /// <summary>
        /// The date the order was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the order was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// User ID who owns the order. Use 0 for guests. Default is 0.
        /// </summary>
        
        [JsonProperty("customer_id")]
        [JsonPropertyName("customer_id")]
        public ulong? CustomerId { get; set; }

        /// <summary>
        /// Total discount amount for the order. 
        /// read-only
        /// </summary>
        
        [JsonProperty("discount_total")]
        [JsonPropertyName("discount_total")]
        public decimal? DiscountTotal { get; set; }

        /// <summary>
        /// Total discount tax amount for the order. 
        /// read-only
        /// </summary>
        
        [JsonProperty("discount_tax")]
        [JsonPropertyName("discount_tax")]
        public decimal? DiscountTax { get; set; }

        /// <summary>
        /// Total shipping amount for the order. 
        /// read-only
        /// </summary>
        
        [JsonProperty("shipping_total")]
        [JsonPropertyName("shipping_total")]
        public decimal? ShippingTotal { get; set; }

        /// <summary>
        /// Total shipping tax amount for the order. 
        /// read-only
        /// </summary>
        
        [JsonProperty("shipping_tax")]
        [JsonPropertyName("shipping_tax")]
        public decimal? ShippingTax { get; set; }

        /// <summary>
        /// Sum of line item taxes only. 
        /// read-only
        /// </summary>
        
        [JsonProperty("cart_tax")]
        [JsonPropertyName("cart_tax")]
        public decimal? CartTax { get; set; }

        /// <summary>
        /// Grand total. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Sum of all taxes. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Billing address. See Customer Billing Address properties.
        /// </summary>
        
        [JsonProperty("billing")]
        [JsonPropertyName("billing")]
        public BillingAddress Billing { get; set; }

        /// <summary>
        /// Shipping address. See Customer Shipping Address properties.
        /// </summary>
        
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public ShippingAddress Shipping { get; set; }

        /// <summary>
        /// Payment method ID.
        /// </summary>
        
        [JsonProperty("payment_method")]
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Payment method title.
        /// </summary>
        
        [JsonProperty("payment_method_title")]
        [JsonPropertyName("payment_method_title")]
        public string PaymentMethodTitle { get; set; }

        /// <summary>
        /// Define if the order is paid. It will set the status to processing and reduce stock items. Default is false. 
        /// write-only
        /// </summary>
        
        [JsonProperty("set_paid")]
        [JsonPropertyName("set_paid")]
        public bool? SetPaid { get; set; }

        /// <summary>
        /// Unique transaction ID. In write-mode only is available if set_paid is true.
        /// </summary>
        
        [JsonProperty("transaction_id")]
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Customer’s IP address. 
        /// read-only
        /// </summary>
        
        [JsonProperty("customer_ip_address")]
        [JsonPropertyName("customer_ip_address")]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// User agent of the customer. 
        /// read-only
        /// </summary>
        
        [JsonProperty("customer_user_agent")]
        [JsonPropertyName("customer_user_agent")]
        public string CustomerUserAgent { get; set; }

        /// <summary>
        /// Shows where the order was created. 
        /// read-only
        /// </summary>
        
        [JsonProperty("created_via")]
        [JsonPropertyName("created_via")]
        public string CreatedVia { get; set; }

        /// <summary>
        /// Note left by customer during checkout.
        /// </summary>
        
        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public string CustomerNote { get; set; }

        /// <summary>
        /// The date the order was completed, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_completed")]
        [JsonPropertyName("date_completed")]
        public DateTime? DateCompleted { get; set; }

        /// <summary>
        /// The date the order has been paid, in the site’s timezone. 
        /// read-only
        /// </summary>
        [JsonProperty("date_paid")]
        [JsonPropertyName("date_paid")]
        public DateTime? DatePaid { get; set; }

        /// <summary>
        /// MD5 hash of cart items to ensure orders are not modified. 
        /// read-only
        /// </summary>
        
        [JsonProperty("cart_hash")]
        [JsonPropertyName("cart_hash")]
        public string CartHash { get; set; }

        /// <summary>
        /// Line items data. See Line Items properties.
        /// </summary>
        
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Tax lines data. See Tax Lines properties. 
        /// read-only
        /// </summary>
        
        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public List<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// Shipping lines data. See Shipping Lines properties.
        /// </summary>
        
        [JsonProperty("shipping_lines")]
        [JsonPropertyName("shipping_lines")]
        public List<ShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// Fee lines data. See Fee Lines Properites.
        /// </summary>
        
        [JsonProperty("fee_lines")]
        [JsonPropertyName("fee_lines")]
        public List<FeeLine> FeeLines { get; set; }

        /// <summary>
        /// Coupons line data. See Coupon Lines properties.
        /// </summary>
        
        [JsonProperty("coupon_lines")]
        [JsonPropertyName("coupon_lines")]
        public List<CouponLine> CouponLines { get; set; }
    }

    
    public class LineItem
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Product name. 
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>
        
        [JsonProperty("variation_id")]
        [JsonPropertyName("variation_id")]
        public ulong? VariationId { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>
        
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Tax class of product. 
        /// read-only
        /// </summary>
        
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts).
        /// </summary>
        
        [JsonProperty("subtotal_tax")]
        [JsonPropertyName("subtotal_tax")]
        public decimal? SubtotalTax { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line taxes with id, total and subtotal. 
        /// read-only
        /// </summary>
        
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }

        /// <summary>
        /// Line item meta data with key, label and value. 
        /// read-only
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public List<MetaItem> Meta { get; set; }
    }

    
    public class MetaItem
    {
        /// <summary>
        /// Meta item key
        /// </summary>
        
        [JsonProperty("key")]
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Meta item label
        /// </summary>
        
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// Meta item value
        /// </summary>
        
        [JsonProperty("value")]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    
    public class TaxItem : JsonObject
    {
        /// <summary>
        /// tax item id
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// tax item total
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Total { get; set; }

        /// <summary>
        /// tax item subtotal
        /// </summary>
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Subtotal { get; set; }
    }

    
    public class ShippingLine : JsonObject
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Shipping method name.
        /// </summary>
        
        [JsonProperty("method_title")]
        [JsonPropertyName("method_title")]
        public string MethodTitle { get; set; }

        /// <summary>
        /// Shipping method ID. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        [JsonProperty("method_id")]
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts). 
        /// read-only
        /// </summary>
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line taxes with id and total. 
        /// read-only
        /// </summary>
        
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }
    }

    public class TaxLine : JsonObject
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Tax rate code. 
        /// read-only
        /// </summary>
        
        [JsonProperty("rate_code")]
        [JsonPropertyName("rate_code")]
        public string RateCode { get; set; }

        /// <summary>
        /// Tax rate ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("rate_id")]
        [JsonPropertyName("rate_id")]
        public string RateId { get; set; }

        /// <summary>
        /// Tax rate label. 
        /// read-only
        /// </summary>
        
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// Show if is a compound tax rate. Compound tax rates are applied on top of other tax rates. 
        /// read-only
        /// </summary>
        
        [JsonProperty("compound")]
        [JsonPropertyName("compound")]
        public bool? Compound { get; set; }

        /// <summary>
        /// Tax total (not including shipping taxes). 
        /// read-only
        /// </summary>
        [JsonProperty("tax_total")]
        [JsonPropertyName("tax_total")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? TaxTotal { get; set; }

        /// <summary>
        /// Shipping tax total. 
        /// read-only
        /// </summary>
        [JsonProperty("shipping_tax_total")]
        [JsonPropertyName("shipping_tax_total")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? ShippingTaxTotal { get; set; }
    }

    
    public class FeeLine : JsonObject
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Fee name. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tax class. 
        /// required if the fee is taxable
        /// </summary>
        
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Tax status of fee. Set to taxable if need apply taxes.
        /// </summary>
        
        [JsonProperty("tax_status")]
        [JsonPropertyName("tax_status")]
        public string TaxStatus { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line taxes with id, total and subtotal. 
        /// read-only
        /// </summary>
        
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }
    }

    
    public class CouponLine : JsonObject
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Coupon code. 
        /// required
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Discount total. 
        /// required
        /// </summary>
        [JsonProperty("discount")]
        [JsonPropertyName("discount")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Discount { get; set; }

        /// <summary>
        /// Discount total tax. 
        /// read-only
        /// </summary>
        [JsonProperty("discount_tax")]
        [JsonPropertyName("discount_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? DiscountTax { get; set; }
    }

    
    public class OrderNote
    {
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
        /// Order note. 
        /// required
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        [JsonProperty("note")]
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// Shows/define if the note is only for reference or for the customer (the user will be notified). Default is false.
        /// </summary>
        
        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public bool? CustomerNote { get; set; }
    }

    
    public class OrderRefund : JsonObject
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the order refund was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Refund amount. 
        /// required
        /// </summary>
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Reason for refund.
        /// </summary>
        
        [JsonProperty("reason")]
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Line items data. See Refunds Line Items properties.
        /// </summary>
        
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<OrderRefundLine> LineItems { get; set; }
    }

    
    public class OrderRefundLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Product name. 
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>
        
        [JsonProperty("variation_id")]
        [JsonPropertyName("variation_id")]
        public ulong? VariationId { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>
        
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Tax class of product. 
        /// read-only
        /// </summary>
        
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts).
        /// </summary>
        
        [JsonProperty("subtotal_tax")]
        [JsonPropertyName("subtotal_tax")]
        public decimal? SubtotalTax { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line total tax with id, total and subtotal. 
        /// read-only
        /// </summary>
        
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }

        /// <summary>
        /// Line item meta data with key, label and value. 
        /// read-only
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public List<MetaItem> Meta { get; set; }
    }
}
