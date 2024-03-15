using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce.v2
{
    public class CustomerBatch : BatchObject<Customer> { }

    
    public class Customer : JsonObject
    {
        public static string Endpoint => "customers";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The date the customer was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the order was created, as GMT. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        /// <summary>
        /// The date the customer was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// The date the customer was last modified, as GMT. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified_gmt")]
        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        /// <summary>
        /// The email address for the customer. 
        /// mandatory
        /// </summary>
        
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Customer first name.
        /// </summary>
        
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Customer last name.
        /// </summary>
        
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Customer role. 
        /// read-only
        /// </summary>
        
        [JsonProperty("role")]
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        /// Customer login name.
        /// </summary>
        
        [JsonProperty("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Customer password. 
        /// write-only
        /// </summary>
        
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// List of billing address data. See Customer - Billing properties
        /// </summary>
        
        [JsonProperty("billing")]
        [JsonPropertyName("billing")]
        public CustomerBilling Billing { get; set; }

        /// <summary>
        /// List of shipping address data. See Customer - Shipping properties
        /// </summary>
        
        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public CustomerShipping Shipping { get; set; }

        /// <summary>
        /// Is the customer a paying customer? 
        /// read-only
        /// </summary>
        
        [JsonProperty("is_paying_customer")]
        [JsonPropertyName("is_paying_customer")]
        public bool? IsPayingCustomer { get; set; }

        /// <summary>
        /// Quantity of orders made by the customer. 
        /// read-only
        /// </summary>
        
        [JsonProperty("orders_count")]
        [JsonPropertyName("orders_count")]
        public int? OrdersCount { get; set; }

        /// <summary>
        /// Total amount spent. 
        /// read-only
        /// </summary>
        [JsonProperty("total_spent")]
        [JsonPropertyName("total_spent")]
        [Newtonsoft.Json.JsonConverter(typeof(NumericToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(NumericToStringConverterNet))]
        public decimal? TotalSpent { get; set; }

        /// <summary>
        /// Avatar URL. 
        /// read-only
        /// </summary>
        
        [JsonProperty("avatar_url")]
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Meta data. See Customer - Meta data properties
        /// </summary>
        
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<CustomerMeta> MetaData { get; set; }
    }

    
    public class CustomerBilling
    {
        /// <summary>
        /// First name.
        /// </summary>
        
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name.
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
        /// City name.
        /// </summary>
        
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district.
        /// </summary>
        
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country.
        /// </summary>
        
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        
        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

    }

    
    public class CustomerShipping
    {
        /// <summary>
        /// First name.
        /// </summary>
        
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name.
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
        /// City name.
        /// </summary>
        
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district.
        /// </summary>
        
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>
        
        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// ISO code of the country.
        /// </summary>
        
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

    }

    
    public class CustomerMeta : WcObject.MetaData
    {

    }

    
    public class CustomerDownloads
    {
        /// <summary>
        /// Download ID (MD5). 
        /// read-only
        /// </summary>
        
        [JsonProperty("download_id")]
        [JsonPropertyName("download_id")]
        public string DownloadId { get; set; }

        /// <summary>
        /// Download file URL. 
        /// read-only
        /// </summary>
        
        [JsonProperty("download_url")]
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// Downloadable product ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong? ProductId { get; set; }

        /// <summary>
        /// Product name. 
        /// read-only
        /// </summary>
        
        [JsonProperty("product_name")]
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// Downloadable file name. 
        /// read-only
        /// </summary>
        
        [JsonProperty("download_name")]
        [JsonPropertyName("download_name")]
        public string DownloadName { get; set; }

        /// <summary>
        /// Order ID. 
        /// read-only
        /// </summary>
        
        [JsonProperty("order_id")]
        [JsonPropertyName("order_id")]
        public ulong? OrderId { get; set; }

        /// <summary>
        /// Order key. 
        /// read-only
        /// </summary>
        
        [JsonProperty("order_key")]
        [JsonPropertyName("order_key")]
        public string OrderKey { get; set; }

        /// <summary>
        /// Number of downloads remaining. 
        /// read-only
        /// </summary>
        
        [JsonProperty("downloads_remaining")]
        [JsonPropertyName("downloads_remaining")]
        public string DownloadsRemaining { get; set; }

        /// <summary>
        /// The date when download access expires, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("access_expires")]
        [JsonPropertyName("access_expires")]
        public string AccessExpires { get; set; }

        /// <summary>
        /// The date when download access expires, as GMT. 
        /// read-only
        /// </summary>
        
        [JsonProperty("access_expires_gmt")]
        [JsonPropertyName("access_expires_gmt")]
        public string AccessExpiresGmt { get; set; }

        /// <summary>
        /// File details. 
        /// read-only
        /// </summary>
        
        [JsonProperty("file")]
        [JsonPropertyName("file")]
        public CustomerDownloadFile File { get; set; }

    }

    
    public class CustomerDownloadFile
    {
        /// <summary>
        /// File name
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// File URL
        /// </summary>
        
        [JsonProperty("file")]
        [JsonPropertyName("file")]
        public string File { get; set; }
    }
}
