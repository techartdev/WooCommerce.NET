using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

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
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Coupon code. 
        /// mandatory
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The date the coupon was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the coupon was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Coupon description.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Determines the type of discount that will be applied. Options: fixed_cart, percent, fixed_product and percent_product. Default: fixed_cart.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("discount_type")]
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// The amount of discount.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "amount")]
        protected object AmountValue { get; set; }

        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// UTC DateTime when the coupon expires.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("expiry_date")]
        [JsonPropertyName("expiry_date")]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Number of times the coupon has been used already. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("usage_count")]
        [JsonPropertyName("usage_count")]
        public int? UsageCount { get; set; }

        /// <summary>
        /// Whether coupon can only be used individually.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("individual_use")]
        [JsonPropertyName("individual_use")]
        public bool? IndividualUse { get; set; }

        /// <summary>
        /// List of product ID’s the coupon can be used on.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("product_ids")]
        [JsonPropertyName("product_ids")]
        public List<int> ProductIds { get; set; }

        /// <summary>
        /// List of product ID’s the coupon cannot be used on.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("exclude_product_ids")]
        [JsonPropertyName("exclude_product_ids")]
        public List<int> ExcludeProductIds { get; set; }

        /// <summary>
        /// How many times the coupon can be used.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("usage_limit")]
        [JsonPropertyName("usage_limit")]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// How many times the coupon can be used per customer.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("usage_limit_per_user")]
        [JsonPropertyName("usage_limit_per_user")]
        public int? UsageLimitPerUser { get; set; }

        /// <summary>
        /// Max number of items in the cart the coupon can be applied to.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("limit_usage_to_x_items")]
        [JsonPropertyName("limit_usage_to_x_items")]
        public int? LimitUsageToXItems { get; set; }

        /// <summary>
        /// Define if can be applied for free shipping.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("free_shipping")]
        [JsonPropertyName("free_shipping")]
        public bool? FreeShipping { get; set; }

        /// <summary>
        /// List of category ID’s the coupon applies to.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("product_categories")]
        [JsonPropertyName("product_categories")]
        public List<int> ProductCategories { get; set; }

        /// <summary>
        /// List of category ID’s the coupon does not apply to.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("excluded_product_categories")]
        [JsonPropertyName("excluded_product_categories")]
        public List<int> ExcludedProductCategories { get; set; }

        /// <summary>
        /// Define if should not apply when have sale items.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("exclude_sale_items")]
        [JsonPropertyName("exclude_sale_items")]
        public bool? ExcludeSaleItems { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "minimum_amount")]        
        protected object MinimumAmountValue { get; set; }

        /// <summary>
        /// Minimum order amount that needs to be in the cart before coupon applies.
        /// </summary>
        [JsonProperty("minimum_amount")]
        [JsonPropertyName("minimum_amount")]
        public decimal? MinimumAmount { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "maximum_amount")]        
        protected object MaximumAmountValue { get; set; }

        /// <summary>
        /// Maximum order amount allowed when using the coupon.
        /// </summary>
        [JsonProperty("maximum_amount")]
        [JsonPropertyName("maximum_amount")]
        public decimal? MaximumAmount { get; set; }

        /// <summary>
        /// List of email addresses that can use this coupon.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("email_restrictions")]
        [JsonPropertyName("email_restrictions")]
        public List<string> EmailRestrictions { get; set; }

        /// <summary>
        /// List of user IDs who have used the coupon. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("used_by")]
        [JsonPropertyName("used_by")]
        public List<string> UsedBy { get; set; }
    }
}
