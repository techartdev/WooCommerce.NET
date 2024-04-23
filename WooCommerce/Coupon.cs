using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce
{
    public class CouponBatch : BatchObject<Coupon> { }

    public class Coupon
    {
        public static string Endpoint => "coupons";

        /// <summary>
        /// Unique identifier for the object. 
        /// read-only
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Coupon code. 
        /// mandatory
        /// </summary>

        [JsonProperty("code")]
        [JsonPropertyName("code")]
        [Newtonsoft.Json.JsonRequired]
        [System.Text.Json.Serialization.JsonRequired]
        public string Code { get; set; }

        /// <summary>
        /// The amount of discount. Should always be numeric, even if setting a percentage.
        /// </summary>
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The date the coupon was created, in the site’s timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// The date the coupon was created, as GMT. 
        /// read-only
        /// </summary>

        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; private set; }

        /// <summary>
        /// The date the coupon was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; private set; }

        /// <summary>
        /// The date the coupon was last modified, as GMT. 
        /// read-only
        /// </summary>

        [JsonProperty("date_modified_gmt")]
        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; private set; }

        /// <summary>
        /// Determines the type of discount that will be applied. Options: percent, fixed_cart and fixed_product. Default is fixed_cart.
        /// </summary>

        [JsonProperty("discount_type")]
        [JsonPropertyName("discount_type")]
        public string DiscountType { get; set; } = "fixed_cart";

        /// <summary>
        /// Coupon description.
        /// </summary>

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The date the coupon expires, in the site’s timezone.
        /// </summary>

        [JsonProperty("date_expires")]
        [JsonPropertyName("date_expires")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public DateTime? DateExpires { get; set; }

        /// <summary>
        /// The date the coupon expires, as GMT.
        /// </summary>

        [JsonProperty("date_expires_gmt")]
        [JsonPropertyName("date_expires_gmt")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public DateTime? DateExpiresGmt { get; set; }

        /// <summary>
        /// Number of times the coupon has been used already. 
        /// read-only
        /// </summary>

        [JsonProperty("usage_count")]
        [JsonPropertyName("usage_count")]
        public int UsageCount { get; private set; }

        /// <summary>
        /// If true, the coupon can only be used individually. Other applied coupons will be removed from the cart. Default is false.
        /// </summary>

        [JsonProperty("individual_use")]
        [JsonPropertyName("individual_use")]
        public bool IndividualUse { get; set; }

        /// <summary>
        /// List of product IDs the coupon can be used on.
        /// </summary>

        [JsonProperty("product_ids")]
        [JsonPropertyName("product_ids")]
        public List<int> ProductIds { get; set; }

        /// <summary>
        /// List of product IDs the coupon cannot be used on.
        /// </summary>

        [JsonProperty("excluded_product_ids")]
        [JsonPropertyName("excluded_product_ids")]
        public List<int> ExcludedProductIds { get; set; }

        /// <summary>
        /// How many times the coupon can be used in total.
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
        /// If true and if the free shipping method requires a coupon, this coupon will enable free shipping. Default is false.
        /// </summary>

        [JsonProperty("free_shipping")]
        [JsonPropertyName("free_shipping")]
        public bool FreeShipping { get; set; }

        /// <summary>
        /// List of category IDs the coupon applies to.
        /// </summary>

        [JsonProperty("product_categories")]
        [JsonPropertyName("product_categories")]
        public List<int> ProductCategories { get; set; }

        /// <summary>
        /// List of category IDs the coupon does not apply to.
        /// </summary>

        [JsonProperty("excluded_product_categories")]
        [JsonPropertyName("excluded_product_categories")]
        public List<int> ExcludedProductCategories { get; set; }

        /// <summary>
        /// If true, this coupon will not be applied to items that have sale prices. Default is false.
        /// </summary>

        [JsonProperty("exclude_sale_items")]
        [JsonPropertyName("exclude_sale_items")]
        public bool ExcludeSaleItems { get; set; }

        /// <summary>
        /// Minimum order amount that needs to be in the cart before coupon applies.
        /// </summary>

        [JsonProperty("minimum_amount")]
        [JsonPropertyName("minimum_amount")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? MinimumAmount { get; set; }

        /// <summary>
        /// Maximum order amount allowed when using the coupon.
        /// </summary>

        [JsonProperty("maximum_amount")]
        [JsonPropertyName("maximum_amount")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? MaximumAmount { get; set; }

        /// <summary>
        /// List of email addresses that can use this coupon.
        /// </summary>

        [JsonProperty("email_restrictions")]
        [JsonPropertyName("email_restrictions")]
        public List<string> EmailRestrictions { get; set; }

        /// <summary>
        /// List of user IDs (or guest email addresses) that have used the coupon. 
        /// read-only
        /// </summary>

        [JsonProperty("used_by")]
        [JsonPropertyName("used_by")]
        public List<object> UsedBy { get; private set; }

        /// <summary>
        /// Meta data. See Coupon - Meta data properties
        /// </summary>

        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }
    }
}
