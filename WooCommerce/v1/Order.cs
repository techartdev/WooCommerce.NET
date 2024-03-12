using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v1
{
    [KnownType(typeof(OrderBatch))]
    public class OrderBatch : BatchObject<Order> { }

    [DataContract]
    public class Order : JsonObject
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Parent order ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("parent_id")]
        [JsonPropertyName("parent_id")]
        public ulong? ParentId { get; set; }

        /// <summary>
        /// Order status. Default is pending. Options (plugins may include new status): pending, processing, on-hold, completed, cancelled, refunded and failed.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Order key. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("order_key")]
        [JsonPropertyName("order_key")]
        public string OrderKey { get; set; }

        /// <summary>
        /// Currency the order was created with, in ISO format, e.g USD. Default is the current store currency.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Version of WooCommerce when the order was made. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// Shows if the prices included tax during checkout. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("prices_include_tax")]
        [JsonPropertyName("prices_include_tax")]
        public bool? PricesIncludeTax { get; set; }

        /// <summary>
        /// The date the order was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the order was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// User ID who owns the order. Use 0 for guests. Default is 0.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("customer_id")]
        [JsonPropertyName("customer_id")]
        public ulong? CustomerId { get; set; }

        /// <summary>
        /// Total discount amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("discount_total")]
        [JsonPropertyName("discount_total")]
        public decimal? DiscountTotal { get; set; }

        /// <summary>
        /// Total discount tax amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("discount_tax")]
        [JsonPropertyName("discount_tax")]
        public decimal? DiscountTax { get; set; }

        /// <summary>
        /// Total shipping amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_total")]
        [JsonPropertyName("shipping_total")]
        public decimal? ShippingTotal { get; set; }

        /// <summary>
        /// Total shipping tax amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_tax")]
        [JsonPropertyName("shipping_tax")]
        public decimal? ShippingTax { get; set; }

        /// <summary>
        /// Sum of line item taxes only. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("cart_tax")]
        [JsonPropertyName("cart_tax")]
        public decimal? CartTax { get; set; }

        /// <summary>
        /// Grand total. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Sum of all taxes. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Billing address. See Customer Billing Address properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("billing")]
        [JsonPropertyName("billing")]
        public BillingAddress Billing { get; set; }

        /// <summary>
        /// Shipping address. See Customer Shipping Address properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public ShippingAddress Shipping { get; set; }

        /// <summary>
        /// Payment method ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("payment_method")]
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Payment method title.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("payment_method_title")]
        [JsonPropertyName("payment_method_title")]
        public string PaymentMethodTitle { get; set; }

        /// <summary>
        /// Define if the order is paid. It will set the status to processing and reduce stock items. Default is false. 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("set_paid")]
        [JsonPropertyName("set_paid")]
        public bool? SetPaid { get; set; }

        /// <summary>
        /// Unique transaction ID. In write-mode only is available if set_paid is true.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("transaction_id")]
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Customer’s IP address. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("customer_ip_address")]
        [JsonPropertyName("customer_ip_address")]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// User agent of the customer. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("customer_user_agent")]
        [JsonPropertyName("customer_user_agent")]
        public string CustomerUserAgent { get; set; }

        /// <summary>
        /// Shows where the order was created. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_via")]
        [JsonPropertyName("created_via")]
        public string CreatedVia { get; set; }

        /// <summary>
        /// Note left by customer during checkout.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public string CustomerNote { get; set; }

        /// <summary>
        /// The date the order was completed, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_completed")]
        [JsonPropertyName("date_completed")]
        public DateTime? DateCompleted { get; set; }

        /// <summary>
        /// The date the order has been paid, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "date_paid")]        
        protected object DatePaidValue { get; set; }

        [JsonProperty("date_paid")]
        [JsonPropertyName("date_paid")]
        public DateTime? DatePaid { get; set; }

        /// <summary>
        /// MD5 hash of cart items to ensure orders are not modified. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("cart_hash")]
        [JsonPropertyName("cart_hash")]
        public string CartHash { get; set; }

        /// <summary>
        /// Line items data. See Line Items properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Tax lines data. See Tax Lines properties. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public List<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// Shipping lines data. See Shipping Lines properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_lines")]
        [JsonPropertyName("shipping_lines")]
        public List<ShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// Fee lines data. See Fee Lines Properites.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("fee_lines")]
        [JsonPropertyName("fee_lines")]
        public List<FeeLine> FeeLines { get; set; }

        /// <summary>
        /// Coupons line data. See Coupon Lines properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("coupon_lines")]
        [JsonPropertyName("coupon_lines")]
        public List<CouponLine> CouponLines { get; set; }
    }

    [DataContract]
    public class LineItem
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Product name. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("variation_id")]
        [JsonPropertyName("variation_id")]
        public ulong? VariationId { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Tax class of product. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("subtotal_tax")]
        [JsonPropertyName("subtotal_tax")]
        public decimal? SubtotalTax { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line taxes with id, total and subtotal. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }

        /// <summary>
        /// Line item meta data with key, label and value. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public List<MetaItem> Meta { get; set; }
    }

    [DataContract]
    public class MetaItem
    {
        /// <summary>
        /// Meta item key
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("key")]
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Meta item label
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// Meta item value
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("value")]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    [DataContract]
    public class TaxItem : JsonObject
    {
        /// <summary>
        /// tax item id
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// tax item total
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "total")]
        protected object TotalValue { get; set; }

        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// tax item subtotal
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "subtotal")]
        protected object SubtotalValue { get; set; }

        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }
    }

    [DataContract]
    public class ShippingLine : JsonObject
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Shipping method name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("method_title")]
        [JsonPropertyName("method_title")]
        public string MethodTitle { get; set; }

        /// <summary>
        /// Shipping method ID. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("method_id")]
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "total")]
        protected object TotalValue { get; set; }

        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts). 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "total_tax")]
        protected object TotalTaxValue { get; set; }

        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line taxes with id and total. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
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
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Tax rate code. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("rate_code")]
        [JsonPropertyName("rate_code")]
        public string RateCode { get; set; }

        /// <summary>
        /// Tax rate ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("rate_id")]
        [JsonPropertyName("rate_id")]
        public string RateId { get; set; }

        /// <summary>
        /// Tax rate label. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// Show if is a compound tax rate. Compound tax rates are applied on top of other tax rates. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("compound")]
        [JsonPropertyName("compound")]
        public bool? Compound { get; set; }

        /// <summary>
        /// Tax total (not including shipping taxes). 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "tax_total")]
        protected object TaxTotalValue { get; set; }

        [JsonProperty("tax_total")]
        [JsonPropertyName("tax_total")]
        public decimal? TaxTotal { get; set; }

        /// <summary>
        /// Shipping tax total. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "shipping_tax_total")]
        protected object ShippingTaxTotalValue { get; set; }

        [JsonProperty("shipping_tax_total")]
        [JsonPropertyName("shipping_tax_total")]
        public decimal? ShippingTaxTotal { get; set; }
    }

    [DataContract]
    public class FeeLine : JsonObject
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Fee name. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tax class. 
        /// required if the fee is taxable
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Tax status of fee. Set to taxable if need apply taxes.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_status")]
        [JsonPropertyName("tax_status")]
        public string TaxStatus { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "total")]
        protected object TotalValue { get; set; }

        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "total_tax")]
        protected object TotalTaxValue { get; set; }

        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line taxes with id, total and subtotal. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }
    }

    [DataContract]
    public class CouponLine : JsonObject
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Coupon code. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Discount total. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "discount")]
        protected object DiscountValue { get; set; }

        [JsonProperty("discount")]
        [JsonPropertyName("discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// Discount total tax. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "discount_tax")]
        protected object DiscountTaxValue { get; set; }

        [JsonProperty("discount_tax")]
        [JsonPropertyName("discount_tax")]
        public decimal? DiscountTax { get; set; }
    }

    [DataContract]
    public class OrderNote
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the order note was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Order note. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("note")]
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// Shows/define if the note is only for reference or for the customer (the user will be notified). Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public bool? CustomerNote { get; set; }
    }

    [DataContract]
    public class OrderRefund : JsonObject
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the order refund was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Refund amount. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "amount")]
        protected object AmountValue { get; set; }

        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Reason for refund.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("reason")]
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Line items data. See Refunds Line Items properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<OrderRefundLine> LineItems { get; set; }
    }

    [DataContract]
    public class OrderRefundLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Product name. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("variation_id")]
        [JsonPropertyName("variation_id")]
        public ulong? VariationId { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Tax class of product. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("subtotal_tax")]
        [JsonPropertyName("subtotal_tax")]
        public decimal? SubtotalTax { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line total tax with id, total and subtotal. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }

        /// <summary>
        /// Line item meta data with key, label and value. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public List<MetaItem> Meta { get; set; }
    }
}
