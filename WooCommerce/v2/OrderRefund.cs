using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v2
{
    [DataContract]
    public class OrderRefund : JsonObject
    {
        public static string Endpoint { get { return "refunds"; } }

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
        /// The date the order refund was created, as GMT. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "amount")]
        protected object AmountValue { get; set; }

        /// <summary>
        /// Refund amount.
        /// </summary>
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
        /// User ID of user who created the refund.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("refunded_by")]
        [JsonPropertyName("refunded_by")]
        public ulong? RefundedBy { get; set; }

        /// <summary>
        /// Meta data. See Order refund - Meta data properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<OrderRefundMeta> MetaData { get; set; }

        /// <summary>
        /// Line items data. See Order refund - Line items properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<OrderRefundItem> LineItems { get; set; }

        /// <summary>
        /// When true, the payment gateway API is used to generate the refund. Default is true. 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("api_refund")]
        [JsonPropertyName("api_refund")]
        public bool? ApiRefund { get; set; }

    }

    [DataContract]
    public class OrderRefundMeta : WcObject.MetaData
    {

    }

    [DataContract]
    public class OrderRefundItem
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
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

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
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts). 
        /// read-only
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
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Line taxes. See Order refund - Taxes properties 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<object> Taxes { get; set; }

        /// <summary>
        /// Meta data. See Order refund - Meta data properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<OrderRefundMeta> MetaData { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

    }
}
