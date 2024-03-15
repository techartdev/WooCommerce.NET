using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v3
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
        public List<v2.CustomerMeta> MetaData { get; set; }
    }

    
    public class CustomerBilling : v2.CustomerBilling { }

    
    public class CustomerShipping : v2.CustomerShipping { }
    
    
    public class CustomerDownloads : v2.CustomerDownloads { }

    
    public class CustomerDownloadFile : v2.CustomerDownloadFile { }
}
