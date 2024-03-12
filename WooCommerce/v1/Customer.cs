using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v1
{
    [KnownType(typeof(CustomerBatch))]
    public class CustomerBatch : BatchObject<Customer> { }

    [DataContract]
    public class Customer
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the customer was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the customer was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// The email address for the customer. 
        /// mandatory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Customer first name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Customer login name. Can be generated automatically from the customer’s email address if the option woocommerce_registration_generate_username is equal to yes cannot be changed 
        /// cannot be changed, maybe mandatory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Customer password. Can be generated automatically with wp_generate_password() if the “Automatically generate customer password” option is enabled, check the index meta for generate_password write-only 
        /// write-only, maybe mandatory
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Last order data. See Customer Last Order properties. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_order")]
        [JsonPropertyName("last_order")]
        public LastOrder LastOrder { get; set; }

        /// <summary>
        /// Quantity of orders made by the customer. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("orders_count")]
        [JsonPropertyName("orders_count")]
        public int? OrdersCount { get; set; }

        /// <summary>
        /// Total amount spent. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total_spent")]
        [JsonPropertyName("total_spent")]
        public decimal? TotalSpent { get; set; }

        /// <summary>
        /// Avatar URL.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("avatar_url")]
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// List of billing address data. See Billing Address properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("billing")]
        [JsonPropertyName("billing")]
        public BillingAddress Billing { get; set; }

        /// <summary>
        /// List of shipping address data. See Shipping Address properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public ShippingAddress Shipping { get; set; }
    }

    [DataContract]
    public class LastOrder
    {
        /// <summary>
        /// Last order ID.  
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime of the customer last order.
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }
    }
}
