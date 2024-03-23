using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce
{
    public class Report
    {
        public static string Endpoint => "reports";

        /// <summary>
        /// Report slug
        /// </summary>
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Report description
        /// </summary>
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }


    public class SalesReport
    {
        /// <summary>
        /// Gross sales in the period. 
        /// read-only
        /// </summary>        
        [JsonProperty("total_sales")]
        [JsonPropertyName("total_sales")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TotalSales { get; private set; }

        /// <summary>
        /// Net sales in the period. 
        /// read-only
        /// </summary>        
        [JsonProperty("net_sales")]
        [JsonPropertyName("net_sales")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? NetSales { get; private set; }

        /// <summary>
        /// Average net daily sales. 
        /// read-only
        /// </summary>        
        [JsonProperty("average_sales")]
        [JsonPropertyName("average_sales")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? AverageSales { get; private set; }

        /// <summary>
        /// Total of orders placed. 
        /// read-only
        /// </summary>        
        [JsonProperty("total_orders")]
        [JsonPropertyName("total_orders")]
        public int? TotalOrders { get; private set; }

        /// <summary>
        /// Total of items purchased. 
        /// read-only
        /// </summary>        
        [JsonProperty("total_items")]
        [JsonPropertyName("total_items")]
        public int? TotalItems { get; private set; }

        /// <summary>
        /// Total charged for taxes. 
        /// read-only
        /// </summary>
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public string TotalTax { get; private set; }

        /// <summary>
        /// Total charged for shipping. 
        /// read-only
        /// </summary>        
        [JsonProperty("total_shipping")]
        [JsonPropertyName("total_shipping")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TotalShipping { get; private set; }

        /// <summary>
        /// Total of refunded orders. 
        /// read-only
        /// </summary>        
        [JsonProperty("total_refunds")]
        [JsonPropertyName("total_refunds")]
        public int? TotalRefunds { get; private set; }

        /// <summary>
        /// Total of coupons used. 
        /// read-only
        /// </summary>        
        [JsonProperty("total_discount")]
        [JsonPropertyName("total_discount")]
        public decimal? TotalDiscount { get; private set; }

        /// <summary>
        /// Group type. 
        /// read-only
        /// </summary>        
        [JsonProperty("totals_grouped_by")]
        [JsonPropertyName("totals_grouped_by")]
        public decimal? TotalsGroupedBy { get; private set; }

        /// <summary>
        /// Totals. 
        /// read-only
        /// </summary>        
        [JsonProperty("totals")]
        [JsonPropertyName("totals")]
        public Dictionary<DateTime, SalesReportTotal> Totals { get; set; }
    }


    public class SalesReportTotal
    {
        /// <summary>
        /// Total Sales
        /// </summary>
        [JsonProperty("sales")]
        [JsonPropertyName("sales")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Sales { get; private set; }

        /// <summary>
        /// Total number of orders
        /// </summary>
        [JsonProperty("orders")]
        [JsonPropertyName("orders")]
        public int? Orders { get; private set; }

        /// <summary>
        /// Total numbers of items
        /// </summary>
        [JsonProperty("items")]
        [JsonPropertyName("items")]
        public int? Items { get; private set; }

        /// <summary>
        /// Total tax
        /// </summary>
        [JsonProperty("tax")]
        [JsonPropertyName("tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Tax { get; private set; }

        /// <summary>
        /// Total shipping
        /// </summary>
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Shipping { get; private set; }

        /// <summary>
        /// Total discount
        /// </summary>
        [JsonProperty("discount")]
        [JsonPropertyName("discount")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Discount { get; private set; }

        /// <summary>
        /// Total number of customers
        /// </summary>
        [JsonProperty("customers")]
        [JsonPropertyName("customers")]
        public int? Customers { get; private set; }
    }


    public class TopSellersReport
    {
        /// <summary>
        /// Product title. 
        /// read-only
        /// </summary>
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; private set; }

        /// <summary>
        /// Product ID. 
        /// read-only
        /// </summary>
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; private set; }

        /// <summary>
        /// Total number of purchases. 
        /// read-only
        /// </summary>
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int? Quantity { get; private set; }

    }

    public class CouponsTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        /// <summary>
        /// Coupon type name.
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Amount of coupons.
        /// read-only
        /// </summary>        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public int? Total { get; private set; }
    }

    public class CustomersTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        /// <summary>
        /// Customer type name.
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Amount of customers.
        /// read-only
        /// </summary>        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public int? Total { get; private set; }
    }

    public class OrdersTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        /// <summary>
        /// Orders type name.
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Amount of orders.
        /// read-only
        /// </summary>        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public int? Total { get; private set; }
    }

    public class ProductsTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        /// <summary>
        /// Product type name.
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Amount of products.
        /// read-only
        /// </summary>        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public int? Total { get; private set; }
    }

    public class ReviewsTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; private set; }

        /// <summary>
        /// Review type name.
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Amount of reviews.
        /// read-only
        /// </summary>        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public int? Total { get; private set; }
    }
}
