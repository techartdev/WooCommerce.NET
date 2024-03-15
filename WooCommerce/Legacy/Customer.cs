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
        [JsonProperty("customers")]
        [JsonPropertyName("customers")]
        public List<Customer> Customers { get; set; }
    }

    
    public class Customer
    {
        /// <summary>
        /// Customer ID (user ID) 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// UTC DateTime when the customer was created 
        /// read-only
        /// </summary>
        
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Customer email address 
        /// mandatory when creating a new customer.
        /// </summary>
        
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Customer first name
        /// </summary>
        
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name
        /// </summary>
        
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Customer username, can be generated automatically from the customer’s email address if the option woocommerce_registration_generate_username is equal to yes 
        /// cannot be changed
        /// </summary>
        
        [JsonProperty("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Customer password, can be generated automatically with wp_generate_password() if the “Automatically generate customer password” option is enabled, check the index meta for generate_password 
        /// write-only
        /// </summary>
        
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Last order ID 
        /// read-only
        /// </summary>
        
        [JsonProperty("last_order_id")]
        [JsonPropertyName("last_order_id")]
        public int? LastOrderId { get; set; }

        /// <summary>
        /// UTC DateTime of the customer last order 
        /// read-only
        /// </summary>
        
        [JsonProperty("last_order_date")]
        [JsonPropertyName("last_order_date")]
        public DateTime? LastOrderDate { get; set; }

        /// <summary>
        /// Quantity of orders that the customer have 
        /// read-only
        /// </summary>
        
        [JsonProperty("orders_count")]
        [JsonPropertyName("orders_count")]
        public int? OrdersCount { get; set; }

        /// <summary>
        /// Total amount spent 
        /// read-only
        /// </summary>
        
        [JsonProperty("total_spent")]
        [JsonPropertyName("total_spent")]
        public decimal? TotalSpent { get; set; }

        /// <summary>
        /// Gravatar URL
        /// </summary>
        
        [JsonProperty("avatar_url")]
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// List of Billing Address fields. See Billing Address Properties
        /// </summary>
        
        [JsonProperty("billing_address")]
        [JsonPropertyName("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// List of Shipping Address fields. See Shipping Address Properties
        /// </summary>
        
        [JsonProperty("shipping_address")]
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }
    }

    [CollectionDataContract]
    public class BillingAddressList : List<BillingAddress>
    {
        [JsonProperty("billing_address")]
        [JsonPropertyName("billing_address")]
        public List<BillingAddress> BillingAddress { get; set; }
    }

    
    public class BillingAddress
    {
        /// <summary>
        /// First name
        /// </summary>
        
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        
        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        
        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        
        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district
        /// </summary>
        
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country
        /// </summary>
        
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        
        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }


    [CollectionDataContract]
    public class ShippingAddressList : List<ShippingAddress>
    {
        
        [JsonProperty("shipping_address")]
        [JsonPropertyName("shipping_address")]
        public List<ShippingAddress> ShippingAddress { get; set; }
    }

    
    public class ShippingAddress
    {
        /// <summary>
        /// First name
        /// </summary>
        
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        
        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>
        
        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>
        
        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district
        /// </summary>
        
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country
        /// </summary>
        
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
