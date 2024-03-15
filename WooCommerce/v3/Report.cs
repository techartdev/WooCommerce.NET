using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v3
{
    
    public class Report : v2.Report { }

    
    public class SalesReport : v2.SalesReport { }

    
    public class TopSellersReport : v2.TopSellersReport { }

    
    public class CouponsTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Coupon type name.
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Amount of coupons.
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public string Total { get; set; }
    }

    
    public class CustomersTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Customer type name.
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Amount of customers.
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public string Total { get; set; }
    }

    
    public class OrdersTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Orders type name.
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Amount of orders.
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public string Total { get; set; }
    }

    
    public class ProductsTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Product type name.
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Amount of products.
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public string Total { get; set; }
    }

    
    public class ReviewsTotals
    {
        /// <summary>
        /// An alphanumeric identifier for the resource.
        /// read-only
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Review type name.
        /// read-only
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Amount of reviews.
        /// read-only
        /// </summary>
        
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public string Total { get; set; }
    }
}
