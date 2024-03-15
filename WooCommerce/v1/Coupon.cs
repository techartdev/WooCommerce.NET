using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce.v1
{
    [KnownType(typeof(CouponBatch))]
    public class CouponBatch : BatchObject<Coupon> { }
    
    public class Coupon : JsonObject
    {
        /// <summary>
        /// Unique identifier for the object. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Coupon code. 
        /// mandatory
        /// </summary>
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The date the coupon was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the coupon was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Coupon description.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Determines the type of discount that will be applied. Options: fixed_cart, percent, fixed_product and percent_product. Default: fixed_cart.
        /// </summary>
        
        [JsonProperty("discount_type")]
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// The amount of discount.
        /// </summary>

        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// UTC DateTime when the coupon expires.
        /// </summary>
        
        [JsonProperty("expiry_date")]
        [JsonPropertyName("expiry_date")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Number of times the coupon has been used already. 
        /// read-only
        /// </summary>
        
        [JsonProperty("usage_count")]
        [JsonPropertyName("usage_count")]
        public int? UsageCount { get; set; }

        /// <summary>
        /// Whether coupon can only be used individually.
        /// </summary>
        
        [JsonProperty("individual_use")]
        [JsonPropertyName("individual_use")]
        public bool? IndividualUse { get; set; }

        /// <summary>
        /// List of product ID’s the coupon can be used on.
        /// </summary>
        
        [JsonProperty("product_ids")]
        [JsonPropertyName("product_ids")]
        public List<int> ProductIds { get; set; }

        /// <summary>
        /// List of product ID’s the coupon cannot be used on.
        /// </summary>
        
        [JsonProperty("exclude_product_ids")]
        [JsonPropertyName("exclude_product_ids")]
        public List<int> ExcludeProductIds { get; set; }

        /// <summary>
        /// How many times the coupon can be used.
        /// </summary>
        
        [JsonProperty("usage_limit")]
        [JsonPropertyName("usage_limit")]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// How many times the coupon can be used per customer.
        /// </summary>
        
        [JsonProperty("usage_limit_per_user")]
        [JsonPropertyName("usage_limit_per_user")]
        public int? UsageLimitPerUser { get; set; }

        /// <summary>
        /// Max number of items in the cart the coupon can be applied to.
        /// </summary>
        
        [JsonProperty("limit_usage_to_x_items")]
        [JsonPropertyName("limit_usage_to_x_items")]
        public int? LimitUsageToXItems { get; set; }

        /// <summary>
        /// Define if can be applied for free shipping.
        /// </summary>
        
        [JsonProperty("free_shipping")]
        [JsonPropertyName("free_shipping")]
        public bool? FreeShipping { get; set; }

        /// <summary>
        /// List of category ID’s the coupon applies to.
        /// </summary>
        
        [JsonProperty("product_categories")]
        [JsonPropertyName("product_categories")]
        public List<int> ProductCategories { get; set; }

        /// <summary>
        /// List of category ID’s the coupon does not apply to.
        /// </summary>
        
        [JsonProperty("excluded_product_categories")]
        [JsonPropertyName("excluded_product_categories")]
        public List<int> ExcludedProductCategories { get; set; }

        /// <summary>
        /// Define if should not apply when have sale items.
        /// </summary>
        
        [JsonProperty("exclude_sale_items")]
        [JsonPropertyName("exclude_sale_items")]
        public bool? ExcludeSaleItems { get; set; }


        /// <summary>
        /// Minimum order amount that needs to be in the cart before coupon applies.
        /// </summary>
        [JsonProperty("minimum_amount")]
        [JsonPropertyName("minimum_amount")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? MinimumAmount { get; set; }


        /// <summary>
        /// Maximum order amount allowed when using the coupon.
        /// </summary>
        [JsonProperty("maximum_amount")]
        [JsonPropertyName("maximum_amount")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? MaximumAmount { get; set; }

        /// <summary>
        /// List of email addresses that can use this coupon.
        /// </summary>
        
        [JsonProperty("email_restrictions")]
        [JsonPropertyName("email_restrictions")]
        public List<string> EmailRestrictions { get; set; }

        /// <summary>
        /// List of user IDs who have used the coupon. 
        /// read-only
        /// </summary>
        
        [JsonProperty("used_by")]
        [JsonPropertyName("used_by")]
        public List<string> UsedBy { get; set; }
    }
}
