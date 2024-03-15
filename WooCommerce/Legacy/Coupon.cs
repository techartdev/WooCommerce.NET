using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.Legacy
{
    [CollectionDataContract]
    public class CouponList : List<Coupon>
    {
        [JsonProperty("coupons")]
        [JsonPropertyName("coupons")]
        public List<Coupon> Coupons { get; set; }
    }

    
    public class Coupon : JsonObject
    {
        /// <summary>
        /// Coupon ID (post ID) 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Coupon code, always lowercase 
        /// mandatory when creating a new coupon.
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Coupon type, valid core types are: fixed_cart, percent, fixed_product and percent_product. Default is fixed_cart
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// UTC DateTime when the coupon was created 
        /// read-only
        /// </summary>
        
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the coupon was last updated 
        /// read-only
        /// </summary>
        
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The amount of discount
        /// </summary>
        
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Whether coupon can only be used individually
        /// </summary>
        
        [JsonProperty("individual_use")]
        [JsonPropertyName("individual_use")]
        public bool? IndividualUse { get; set; }

        /// <summary>
        /// Array of product ID’s the coupon can be used on
        /// </summary>
        
        [JsonProperty("product_ids")]
        [JsonPropertyName("product_ids")]
        public List<int> ProductIds { get; set; }

        /// <summary>
        /// Array of product ID’s the coupon cannot be used on
        /// </summary>
        
        [JsonProperty("exclude_product_ids")]
        [JsonPropertyName("exclude_product_ids")]
        public List<int> ExcludeProductIds { get; set; }

        /// <summary>
        /// How many times the coupon can be used
        /// </summary>
        
        [JsonProperty("usage_limit")]
        [JsonPropertyName("usage_limit")]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// How many times the coupon can be user per customer
        /// </summary>
        
        [JsonProperty("usage_limit_per_user")]
        [JsonPropertyName("usage_limit_per_user")]
        public int? UsageLimitPerUser { get; set; }

        /// <summary>
        /// Max number of items in the cart the coupon can be applied to
        /// </summary>
        
        [JsonProperty("limit_usage_to_x_items")]
        [JsonPropertyName("limit_usage_to_x_items")]
        public int? LimitUsageToXItems { get; set; }

        /// <summary>
        /// Number of times the coupon has been used already 
        /// read-only
        /// </summary>
        
        [JsonProperty("usage_count")]
        [JsonPropertyName("usage_count")]
        public int? UsageCount { get; set; }

        /// <summary>
        /// UTC DateTime`when the coupon expires
        /// </summary>
        
        [JsonProperty("expiry_date")]
        [JsonPropertyName("expiry_date")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Is the coupon for free shipping
        /// </summary>
        
        [JsonProperty("enable_free_shipping")]
        [JsonPropertyName("enable_free_shipping")]
        public bool? EnableFreeShipping { get; set; }

        /// <summary>
        /// Array of category ID’s the coupon applies to
        /// </summary>
        
        [JsonProperty("product_category_ids")]
        [JsonPropertyName("product_category_ids")]
        public List<int> ProductCategoryIds { get; set; }

        /// <summary>
        /// Array of category ID’s the coupon does not apply to
        /// </summary>
        
        [JsonProperty("exclude_product_category_ids")]
        [JsonPropertyName("exclude_product_category_ids")]
        public List<int> ExcludeProductCategoryIds { get; set; }

        /// <summary>
        /// Exclude sale items from the coupon
        /// </summary>
        
        [JsonProperty("exclude_sale_items")]
        [JsonPropertyName("exclude_sale_items")]
        public bool? ExcludeSaleItems { get; set; }

        /// <summary>
        /// Minimum order amount that needs to be in the cart before coupon applies
        /// </summary>
        
        [JsonProperty("minimum_amount")]
        [JsonPropertyName("minimum_amount")]
        public decimal? MinimumAmount { get; set; }

        /// <summary>
        /// Maximum order amount allowed when using the coupon
        /// </summary>
        
        [JsonProperty("maximum_amount")]
        [JsonPropertyName("maximum_amount")]
        public decimal? MaximumAmount { get; set; }

        /// <summary>
        /// Array of email addresses that can use this coupon
        /// </summary>
        
        [JsonProperty("customer_emails")]
        [JsonPropertyName("customer_emails")]
        public List<string> CustomerEmails { get; set; }

        /// <summary>
        /// Coupon description
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
