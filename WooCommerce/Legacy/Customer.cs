using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.Legacy
{
    [CollectionDataContract]
    public class CustomerList : List<Customer>
    {
        [DataMember]
        [JsonProperty("customers")]
        [JsonPropertyName("customers")]
        public List<Customer> Customers { get; set; }
    }

    [DataContract]
    public class Customer
    {
        /// <summary>
        /// Customer ID (user ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime when the customer was created 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Customer email address 
        /// mandatory when creating a new customer.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Customer first name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Customer username, can be generated automatically from the customer’s email address if the option woocommerce_registration_generate_username is equal to yes 
        /// cannot be changed
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Customer password, can be generated automatically with wp_generate_password() if the “Automatically generate customer password” option is enabled, check the index meta for generate_password 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Last order ID 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_order_id")]
        [JsonPropertyName("last_order_id")]
        public int? LastOrderId { get; set; }

        /// <summary>
        /// UTC DateTime of the customer last order 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_order_date")]
        [JsonPropertyName("last_order_date")]
        public DateTime? LastOrderDate { get; set; }

        /// <summary>
        /// Quantity of orders that the customer have 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("orders_count")]
        [JsonPropertyName("orders_count")]
        public int? OrdersCount { get; set; }

        /// <summary>
        /// Total amount spent 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("total_spent")]
        [JsonPropertyName("total_spent")]
        public decimal? TotalSpent { get; set; }

        /// <summary>
        /// Gravatar URL
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("avatar_url")]
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// List of Billing Address fields. See Billing Address Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("billing_address")]
        [JsonPropertyName("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// List of Shipping Address fields. See Shipping Address Properties
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("shipping_address")]
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }
    }

    [CollectionDataContract]
    public class BillingAddressList : List<BillingAddress>
    {
        [DataMember]
        [JsonProperty("billing_address")]
        [JsonPropertyName("billing_address")]
        public List<BillingAddress> BillingAddress { get; set; }
    }

    [DataContract]
    public class BillingAddress
    {
        /// <summary>
        /// First name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }


    [CollectionDataContract]
    public class ShippingAddressList : List<ShippingAddress>
    {
        [DataMember]
        [JsonProperty("shipping_address")]
        [JsonPropertyName("shipping_address")]
        public List<ShippingAddress> ShippingAddress { get; set; }
    }

    [DataContract]
    public class ShippingAddress
    {
        /// <summary>
        /// First name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
