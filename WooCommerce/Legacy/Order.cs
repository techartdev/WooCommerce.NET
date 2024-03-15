using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.Legacy
{
    [CollectionDataContract]
    public class OrderList : List<Order>
    {
        
        [JsonProperty("orders")]
        [JsonPropertyName("orders")]
        public List<Order> Orders { get; set; }
    }

    
    public class Order
    {
        /// <summary>
        /// Order ID (post ID) 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Order number 
        /// read-only
        /// </summary>
        
        [JsonProperty("order_number")]
        [JsonPropertyName("order_number")]
        public int? OrderNumber { get; set; }

        /// <summary>
        /// UTC DateTime when the order was created 
        /// read-only
        /// </summary>
        
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the order was last updated 
        /// read-only
        /// </summary>
        
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the order was last completed 
        /// read-only
        /// </summary>
        
        [JsonProperty("completed_at")]
        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Order status. By default are available the status: pending, processing, on-hold, completed, cancelled, refunded and failed. See View List of Order Statuses
        /// </summary>
        
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Currency in ISO format, e.g USD
        /// </summary>
        
        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Order total 
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Order subtotal 
        /// read-only
        /// </summary>
        
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Total of order items 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_line_items_quantity")]
        [JsonPropertyName("total_line_items_quantity")]
        public int? TotalLineItemsQuantity { get; set; }

        /// <summary>
        /// Order tax total 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Order shipping total 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_shipping")]
        [JsonPropertyName("total_shipping")]
        public decimal? TotalShipping { get; set; }

        /// <summary>
        /// Order cart tax 
        /// read-only
        /// </summary>
        
        [JsonProperty("cart_tax")]
        [JsonPropertyName("cart_tax")]
        public decimal? CartTax { get; set; }

        /// <summary>
        /// Order shipping tax 
        /// read-only
        /// </summary>
        
        [JsonProperty("shipping_tax")]
        [JsonPropertyName("shipping_tax")]
        public decimal? ShippingTax { get; set; }

        /// <summary>
        /// Order total discount 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_discount")]
        [JsonPropertyName("total_discount")]
        public decimal? TotalDiscount { get; set; }

        /// <summary>
        /// Text list of the shipping methods used in the order 
        /// read-only
        /// </summary>
        
        [JsonProperty("shipping_methods")]
        [JsonPropertyName("shipping_methods")]
        public string ShippingMethods { get; set; }

        /// <summary>
        /// List of payment details. See Payment Details Properties
        /// </summary>
        
        [JsonProperty("payment_details")]
        [JsonPropertyName("payment_details")]
        public PaymentDetail PaymentDetails { get; set; }

        /// <summary>
        /// List of customer billing address. See Customer Billing Address Properties
        /// </summary>
        
        [JsonProperty("billing_address")]
        [JsonPropertyName("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// List of customer shipping address. See Customer Shipping Address Properties
        /// </summary>
        
        [JsonProperty("shipping_address")]
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Customer order notes
        /// </summary>
        
        [JsonProperty("note")]
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// Customer IP address 
        /// read-only
        /// </summary>
        
        [JsonProperty("customer_ip")]
        [JsonPropertyName("customer_ip")]
        public string CustomerIp { get; set; }

        /// <summary>
        /// Customer User-Agent 
        /// read-only
        /// </summary>
        
        [JsonProperty("customer_user_agent")]
        [JsonPropertyName("customer_user_agent")]
        public string CustomerUserAgent { get; set; }

        /// <summary>
        /// Customer ID (user ID) 
        /// required when creating a new order
        /// </summary>
        
        [JsonProperty("customer_id")]
        [JsonPropertyName("customer_id")]
        public ulong? CustomerId { get; set; }

        /// <summary>
        /// URL to view the order in frontend 
        /// read-only
        /// </summary>
        
        [JsonProperty("view_order_url")]
        [JsonPropertyName("view_order_url")]
        public string ViewOrderUrl { get; set; }

        /// <summary>
        /// List of order line items. See Line Items Properties
        /// </summary>
        
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public LineItemList LineItems { get; set; }

        /// <summary>
        /// List of shipping line items. See Shipping Lines Properties
        /// </summary>
        
        [JsonProperty("shipping_lines")]
        [JsonPropertyName("shipping_lines")]
        public ShippingLineList ShippingLines { get; set; }

        /// <summary>
        /// List of tax line items. See Tax Lines Properties 
        /// read-only
        /// </summary>
        
        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public TaxLineList TaxLines { get; set; }

        /// <summary>
        /// List of fee line items. See Fee Lines Properties
        /// </summary>
        
        [JsonProperty("fee_lines")]
        [JsonPropertyName("fee_lines")]
        public FeeLineList FeeLines { get; set; }

        /// <summary>
        /// List of coupon line items. See Coupon Lines Properties
        /// </summary>
        
        [JsonProperty("coupon_lines")]
        [JsonPropertyName("coupon_lines")]
        public CouponLineList CouponLines { get; set; }

        /// <summary>
        /// Customer data. See Customer Properties
        /// </summary>
        
        [JsonProperty("customer")]
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        /// <summary>
        /// Dictionary of order metadata/custom fields. Undocumented; set parameter filter[meta] to true on GetOrders to include in response.
        /// </summary>
        
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public IDictionary<string, string> OrderMeta { get; set; }
    }

    [CollectionDataContract]
    public class PaymentDetailList : List<PaymentDetail>
    {
        
        [JsonProperty("payment_details")]
        [JsonPropertyName("payment_details")]
        public List<PaymentDetail> PaymentDetails { get; set; }
    }

    
    public class PaymentDetail
    {
        /// <summary>
        /// Payment method ID 
        /// required
        /// </summary>
        [JsonProperty("method_id")]
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// Payment method title 
        /// required
        /// </summary>
        [JsonProperty("method_title")]
        [JsonPropertyName("method_title")]
        public string MethodTitle { get; set; }

        /// <summary>
        /// Shows/define if the order is paid using this payment method. Use true to complete the payment.
        /// </summary>
        
        [JsonProperty("paid")]
        [JsonPropertyName("paid")]
        public bool? Paid { get; set; }

        /// <summary>
        /// Transaction ID, an optional field to set the transaction ID when complete one payment (to set this you need set the paid as true too)
        /// </summary>
        
        [JsonProperty("transaction_id")]
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }
    }


    [CollectionDataContract]
    public class LineItemList : List<LineItem>
    {
        
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; set; }
    }

    
    public class LineItem
    {
        /// <summary>
        /// Line item ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Line item subtotal
        /// </summary>
        
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line item tax subtotal
        /// </summary>
        
        [JsonProperty("subtotal_tax")]
        [JsonPropertyName("subtotal_tax")]
        public decimal? SubtotalTax { get; set; }

        /// <summary>
        /// Line item total
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line item tax total
        /// </summary>
        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Product price 
        /// read-only
        /// </summary>
        
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Product tax class 
        /// read-only
        /// </summary>
        
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Product name 
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Product ID 
        /// required when creating new order
        /// </summary>
        
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public int? ProductId { get; set; }

        /// <summary>
        /// Product SKU 
        /// read-only
        /// </summary>
        
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// List of product meta items. See Products Meta Items Properties
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public MetaItemList Meta { get; set; }

        /// <summary>
        /// List of product variation attributes. e.g: "variation": {"pa_color": "Black", "pa_size": "XGG"} (Use pa_ prefix when is a product attribute) 
        /// write-only
        /// </summary>
        
        [JsonProperty("variations")]
        [JsonPropertyName("variations")]
        public VariationList Variations { get; set; }
    }


    [CollectionDataContract]
    public class MetaItemList : List<MetaItem>
    {
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public List<MetaItem> Metas { get; set; }
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


    [CollectionDataContract]
    public class ShippingLineList : List<ShippingLine>
    {
        
        [JsonProperty("shipping_lines")]
        [JsonPropertyName("shipping_lines")]
        public List<ShippingLine> ShippingLines { get; set; }
    }

    
    public class ShippingLine
    {
        /// <summary>
        /// Shipping line ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Shipping method ID 
        /// required when creating a new shipping line in orders
        /// </summary>
        
        [JsonProperty("method_id")]
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// Shipping method title 
        /// required when creating a new shipping line in orders
        /// </summary>
        
        [JsonProperty("method_title")]
        [JsonPropertyName("method_title")]
        public string MethodTitle { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }
    }


    [CollectionDataContract]
    public class TaxLineList : List<TaxLine>
    {
        
        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public List<TaxLine> TaxLines { get; set; }
    }

    public class TaxLine
    {
        /// <summary>
        /// Tax rate line ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Tax rate ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("rate_id")]
        [JsonPropertyName("rate_id")]
        public ulong? RateId { get; set; }

        /// <summary>
        /// Tax rate code 
        /// read-only
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Tax rate title/name 
        /// read-only
        /// </summary>
        
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Tax rate total 
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Shows if is or not a compound rate. Compound tax rates are applied on top of other tax rates. 
        /// read-only
        /// </summary>
        
        [JsonProperty("compound")]
        [JsonPropertyName("compound")]
        public bool? Compound { get; set; }
    }


    [CollectionDataContract]
    public class FeeLineList : List<FeeLine>
    {
        
        [JsonProperty("fee_lines")]
        [JsonPropertyName("fee_lines")]
        public List<FeeLine> FeeLines { get; set; }
    }

    
    public class FeeLine
    {
        /// <summary>
        /// Fee line ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Shipping method title 
        /// required when creating a new fee.
        /// </summary>
        
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Shows/define if the fee is taxable 
        /// write-only
        /// </summary>
        
        [JsonProperty("taxable")]
        [JsonPropertyName("taxable")]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Tax class, required in write-mode if the fee is taxable
        /// </summary>
        
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Tax total
        /// </summary>
        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }
    }


    [CollectionDataContract]
    public class CouponLineList : List<CouponLine>
    {
        
        [JsonProperty("coupon_lines")]
        public List<CouponLine> CouponLines { get; set; }
    }

    
    public class CouponLine
    {
        /// <summary>
        /// Coupon line ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Coupon code 
        /// required when creating a new order.
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Total amount 
        /// required when creating a new order.
        /// </summary>
        
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }
    }


    [CollectionDataContract]
    public class OrderNoteList : List<OrderNote>
    {
        
        [JsonProperty("order_notes")]
        [JsonPropertyName("order_notes")]
        public List<OrderNote> OrderNotes { get; set; }
    }

    
    public class OrderNote
    {
        /// <summary>
        /// Order note ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime when the order note was created 
        /// read-only
        /// </summary>
        
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Order note 
        /// required when creating a new note
        /// </summary>
        
        [JsonProperty("note")]
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// Shows/define if the note is only for reference or for the customer (the user will be notified). Default is false
        /// </summary>
        
        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public bool? CustomerNote { get; set; }
    }


    [CollectionDataContract]
    public class OrderRefundList : List<OrderRefund>
    {
        
        [JsonProperty("order_refunds")]
        [JsonPropertyName("order_refunds")]
        public List<OrderRefund> OrderRefunds { get; set; }
    }

    
    public class OrderRefund
    {
        /// <summary>
        /// Order note ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime when the order refund was created 
        /// read-only
        /// </summary>
        
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Refund amount 
        /// required when creating a new refund.
        /// </summary>
        
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Reason for refund
        /// </summary>
        
        [JsonProperty("reason")]
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// List of order items to refund. See Line Items Properties
        /// </summary>
        
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public LineItemList LineItems { get; set; }
    }
}
