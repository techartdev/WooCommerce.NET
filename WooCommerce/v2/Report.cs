using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v2
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
        public string TotalSales { get; set; }

        /// <summary>
        /// Net sales in the period. 
        /// read-only
        /// </summary>
        
        [JsonProperty("net_sales")]
        [JsonPropertyName("net_sales")]
        public string NetSales { get; set; }

        /// <summary>
        /// Average net daily sales. 
        /// read-only
        /// </summary>
        
        [JsonProperty("average_sales")]
        [JsonPropertyName("average_sales")]
        public string AverageSales { get; set; }

        /// <summary>
        /// Total of orders placed. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_orders")]
        [JsonPropertyName("total_orders")]
        public int? TotalOrders { get; set; }

        /// <summary>
        /// Total of items purchased. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_items")]
        [JsonPropertyName("total_items")]
        public int? TotalItems { get; set; }

        /// <summary>
        /// Total charged for taxes. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public string TotalTax { get; set; }

        /// <summary>
        /// Total charged for shipping. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_shipping")]
        [JsonPropertyName("total_shipping")]
        public string TotalShipping { get; set; }

        /// <summary>
        /// Total of refunded orders. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_refunds")]
        [JsonPropertyName("total_refunds")]
        public int? TotalRefunds { get; set; }

        /// <summary>
        /// Total of coupons used. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_discount")]
        [JsonPropertyName("total_discount")]
        public string TotalDiscount { get; set; }

        /// <summary>
        /// Group type. 
        /// read-only
        /// </summary>
        
        [JsonProperty("totals_grouped_by")]
        [JsonPropertyName("totals_grouped_by")]
        public string TotalsGroupedBy { get; set; }

        /// <summary>
        /// Totals. 
        /// read-only
        /// </summary>
        
        [JsonProperty("totals")]
        [JsonPropertyName("totals")]
        public Dictionary<string, SalesReportTotal> Totals { get; set; }
    }

    
    public class SalesReportTotal
    {
        /// <summary>
        /// Total Sales
        /// </summary>
        
        [JsonProperty("sales")]
        [JsonPropertyName("sales")]
        public string Sales { get; set; }

        /// <summary>
        /// Total number of orders
        /// </summary>
        
        [JsonProperty("orders")]
        [JsonPropertyName("orders")]
        public int? Orders { get; set; }

        /// <summary>
        /// Total numbers of items
        /// </summary>
        
        [JsonProperty("items")]
        [JsonPropertyName("items")]
        public int? Items { get; set; }
        
        /// <summary>
        /// Total tax
        /// </summary>
        
        [JsonProperty("tax")]
        [JsonPropertyName("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// Total shipping
        /// </summary>
        
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public string Shipping { get; set; }

        /// <summary>
        /// Total discount
        /// </summary>
        
        [JsonProperty("discount")]
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// Total number of customers
        /// </summary>
        
        [JsonProperty("customers")]
        [JsonPropertyName("customers")]
        public int? Customers { get; set; }
    }

    
    public class TopSellersReport
    {
        /// <summary>
        /// Product title. 
        /// read-only
        /// </summary>
        
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Product ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; set; }

        /// <summary>
        /// Total number of purchases. 
        /// read-only
        /// </summary>
        
        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

    }

}
