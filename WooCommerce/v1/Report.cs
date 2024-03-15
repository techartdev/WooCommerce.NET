using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WooCommerce.NET.WooCommerce.v1
{
    
    public class Report
    {
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
        public decimal? TotalSales { get; set; }

        /// <summary>
        /// Net sales in the period. 
        /// read-only
        /// </summary>
        
        [JsonProperty("net_sales")]
        [JsonPropertyName("net_sales")]
        public decimal? NetSales { get; set; }

        /// <summary>
        /// Average net daily sales. 
        /// read-only
        /// </summary>
        
        [JsonProperty("average_sales")]
        [JsonPropertyName("average_sales")]
        public decimal? AverageSales { get; set; }

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
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Total charged for shipping. 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_shipping")]
        [JsonPropertyName("total_shipping")]
        public decimal? TotalShipping { get; set; }

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
        public decimal? TotalDiscount { get; set; }

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
        public List<string> Totals { get; set; }
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
        public uint Quantity { get; set; }

    }

}
