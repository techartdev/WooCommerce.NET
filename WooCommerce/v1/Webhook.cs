using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v1
{
    public class WebhookBatch : BatchObject<Webhook> { }

    
    public class Webhook
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// A friendly name for the webhook. Defaults is Webhook created on lt;dategt;.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Webhook status. Default is active. Options active (delivers payload), paused (does not deliver), or disabled (does not deliver due delivery failures).
        /// </summary>
        
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Webhook topic, e.g. coupon.updated. See the complete list. 
        /// required
        /// </summary>
        
        [JsonProperty("topic")]
        [JsonPropertyName("topic")]
        public string Topic { get; set; }

        /// <summary>
        /// Webhook resource, e.g. coupon 
        /// read-only
        /// </summary>
        
        [JsonProperty("resource")]
        [JsonPropertyName("resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Webhook event, e.g. updated 
        /// read-only
        /// </summary>
        [JsonProperty("event")]
        [JsonPropertyName("event")]
        public string Event{ get; set; }

        /// <summary>
        /// WooCommerce action names associated with the webhook. 
        /// read-only
        /// </summary>
        
        [JsonProperty("hooks")]
        [JsonPropertyName("hooks")]
        public List<string> Hooks { get; set; }

        /// <summary>
        /// The URL where the webhook payload is delivered. 
        /// required
        /// </summary>
        
        [JsonProperty("delivery_url")]
        [JsonPropertyName("delivery_url")]
        public string DeliveryUrl { get; set; }

        /// <summary>
        /// Secret key used to generate a hash of the delivered webhook and provided in the request headers. This will default is a MD5 hash from the current user’s Id's username if not provided. 
        /// write-only
        /// </summary>
        
        [JsonProperty("secret")]
        [JsonPropertyName("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// UTC DateTime when the webhook was created 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// UTC DateTime when the webhook was last updated 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }
    }

    
    public class WebhookDelivery
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The delivery duration, in seconds. 
        /// read-only
        /// </summary>
        
        [JsonProperty("duration")]
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// A friendly summary of the response including the HTTP response code, message, and body. 
        /// read-only
        /// </summary>
        
        [JsonProperty("summary")]
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// The URL where the webhook was delivered. 
        /// read-only
        /// </summary>
        
        [JsonProperty("request_url")]
        [JsonPropertyName("request_url")]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Request headers. See Request Headers Attributes for more details. 
        /// read-only
        /// </summary>
        
        [JsonProperty("request_headers")]
        [JsonPropertyName("request_headers")]
        public List<RequestHeader> RequestHeaders { get; set; }

        /// <summary>
        /// Request body. 
        /// read-only
        /// </summary>
        
        [JsonProperty("request_body")]
        [JsonPropertyName("request_body")]
        public string RequestBody { get; set; }

        /// <summary>
        /// The HTTP response code from the receiving server. 
        /// read-only
        /// </summary>
        
        [JsonProperty("response_code")]
        [JsonPropertyName("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The HTTP response message from the receiving server. 
        /// read-only
        /// </summary>
        
        [JsonProperty("response_message")]
        [JsonPropertyName("response_message")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Array of the response headers from the receiving server. 
        /// read-only
        /// </summary>
        
        [JsonProperty("response_headers")]
        [JsonPropertyName("response_headers")]
        public List<ResponseHeader> ResponseHeaders { get; set; }

        /// <summary>
        /// The response body from the receiving server. 
        /// read-only
        /// </summary>
        
        [JsonProperty("response_body")]
        [JsonPropertyName("response_body")]
        public string ResponseBody { get; set; }

        /// <summary>
        /// The date the webhook delivery was logged, in the site’s timezone. 
        /// read-only
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }
    }

    
    public class RequestHeader
    {
        /// <summary>
        /// The request user agent, defaults to “WooCommerce/{version} Hookshot (WordPress/{version})”
        /// </summary>
        [JsonProperty("User-Agent")]
        [JsonPropertyName("User-Agent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// The request content-type, defaults to “application/json”
        /// </summary>
        [JsonProperty("Content-Type")]
        [JsonPropertyName("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The webhook topic
        /// </summary>
        [JsonProperty("X-WC-Webhook-Topic")]
        [JsonPropertyName("X-WC-Webhook-Topic")]
        public string XwcWebhookTopic { get; set; }

        /// <summary>
        /// The webhook resource
        /// </summary>
        [JsonProperty("X-WC-Webhook-Resource")]
        [JsonPropertyName("X-WC-Webhook-Resource")]
        public string XwcWebhookResource { get; set; }

        /// <summary>
        /// The webhook event
        /// </summary>
        [JsonProperty("X-WC-Webhook-Event")]
        [JsonPropertyName("X-WC-Webhook-Event")]
        public string XwcWebhookEvent { get; set; }

        /// <summary>
        /// A base64 encoded HMAC-SHA256 hash of the payload
        /// </summary>
        [JsonProperty("X-WC-Webhook-Signature")]
        [JsonPropertyName("X-WC-Webhook-Signature")]
        public string XwcWebhookSignature { get; set; }

        /// <summary>
        /// The webhook’s ID
        /// </summary>
        [JsonProperty("X-WC-Webhook-ID")]
        [JsonPropertyName("X-WC-Webhook-ID")]
        public uint XwcWebhookId { get; set; }

        /// <summary>
        /// The delivery ID
        /// </summary>
        [JsonProperty("X-WC-Webhook-Delivery-ID")]
        [JsonPropertyName("X-WC-Webhook-Delivery-ID")]
        public uint XwcWebhookDeliveryId { get; set; }

    }

    
    public class ResponseHeader
    {
        /// <summary>
        /// cache response directives values: private | public | no-cache
        /// </summary>
        [JsonProperty("cache-control")]
        [JsonPropertyName("cache-control")]
        public string CacheControl { get; set; }

        /// <summary>
        ///  The response content-type, defaults to “application/json”
        /// </summary>
        [JsonProperty("content-type")]
        [JsonPropertyName("content-type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Webserver where webhook delivery page is hosted.
        /// </summary>
        
        [JsonProperty("server")]
        [JsonPropertyName("server")]
        public string Server { get; set; }

        /// <summary>
        /// Host engine where webhook delivery page is hosted, e.g. PHP / ASP.Net
        /// </summary>
        [JsonProperty("x-powered-by")]
        [JsonPropertyName("x-powered-by")]
        public string XPoweredBy { get; set; }

        /// <summary>
        /// Date of webhook delivery posted
        /// </summary>
        
        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// Connection state
        /// </summary>
        
        [JsonProperty("connection")]
        [JsonPropertyName("connection")]
        public string Connection { get; set; }

        /// <summary>
        /// The request data length
        /// </summary>
        [JsonProperty("content-length")]
        [JsonPropertyName("content-length")]
        public string ContentLength { get; set; }
    }
}
