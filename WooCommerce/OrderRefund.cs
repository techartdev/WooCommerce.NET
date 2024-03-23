using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce
{

    public class OrderRefund
    {
        public static string Endpoint => "refunds";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// The date the order refund was created, in the site’s timezone. 
        /// read-only
        /// </summary>        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// The date the order refund was created, as GMT. 
        /// read-only
        /// </summary>        
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; private set; }

        /// <summary>
        /// Total refund amount. Optional. If this parameter is provided, it will take precedence over line item totals, even when total of line items does not matches with this amount.
        /// </summary>
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Reason for refund.
        /// </summary>

        [JsonProperty("reason")]
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// User ID of user who created the refund.
        /// </summary>        
        [JsonProperty("refunded_by")]
        [JsonPropertyName("refunded_by")]
        public ulong? RefundedBy { get; set; }

        /// <summary>
        /// If the payment was refunded via the API. See api_refund.
        /// </summary>
        [JsonProperty("refunded_payment")]
        [JsonPropertyName("refunded_payment")]
        public bool RefundedPayment { get; private set; }

        /// <summary>
        /// Meta data. See Order refund - Meta data properties
        /// </summary>        
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }

        /// <summary>
        /// Line items data. See Order refund - Line items properties
        /// </summary>

        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<OrderRefundItem> LineItems { get; set; }

        /// <summary>
        /// When true, the payment gateway API is used to generate the refund. Default is true. 
        /// write-only
        /// </summary>

        [JsonProperty("api_refund")]
        [JsonPropertyName("api_refund")]
        public bool ApiRefund { private get; set; } = true;

        /// <summary>
        /// When true, the selected line items are restocked Default is true.
        /// </summary>
        [JsonProperty("api_restock")]
        [JsonPropertyName("api_restock")]
        public bool ApiRestock { get; set; } = true;

    }

    public class OrderRefundItem
    {
        /// <summary>
        /// Item ID. 
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
        /// Product ID.
        /// </summary>        
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong ProductId { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>        
        [JsonProperty("variation_id")]
        [JsonPropertyName("variation_id")]
        public ulong VariationId { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>        
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Tax class of product.
        /// </summary>        
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public int TaxClass { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>        
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts). 
        /// read-only
        /// </summary>        
        [JsonProperty("subtotal_tax")]
        [JsonPropertyName("subtotal_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? SubtotalTax { get; private set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts). 
        /// read-only
        /// </summary>        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TotalTax { get; private set; }

        /// <summary>
        /// Line taxes. See Order refund - Taxes properties 
        /// read-only
        /// </summary>        
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<OrderRefundTaxItem> Taxes { get; set; }

        /// <summary>
        /// Meta data. See Order refund - Meta data properties
        /// </summary>        
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>        
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; private set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>        
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Price { get; private set; }

        /// <summary>
        ///  The amount to refund for this line item, excluding taxes.
        /// </summary>
        [JsonProperty("refund_total")]
        [JsonPropertyName("refund_total")]
        public decimal RefundTotal { private get; set; }
    }

    public class OrderRefundTaxItem
    {
        /// <summary>
        /// Tax rate ID
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Tax total
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; private set; }

        /// <summary>
        /// Tax subtotal
        /// </summary>
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Subtotal { get; private set; }

        /// <summary>
        ///  The amount to refund for this tax.
        /// </summary>
        [JsonProperty("refund_total")]
        [JsonPropertyName("refund_total")]
        public decimal RefundTotal { private get; set; }
    }

}
