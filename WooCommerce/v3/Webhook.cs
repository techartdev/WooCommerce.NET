using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v3
{
    
    public class Webhook : v2.Webhook { }

    
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
        /// </summary>
        
        [JsonProperty("duration")]
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// A friendly summary of the response including the HTTP response code, message, and body        
        /// </summary>
        
        [JsonProperty("summary")]
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// The URL where the webhook was delivered
        /// read-only
        /// </summary>
        
        [JsonProperty("request_url")]
        [JsonPropertyName("request_url")]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Array of request headers (see Request Headers Attributes)
        /// read-only
        /// </summary>
        
        [JsonProperty("request_headers")]
        [JsonPropertyName("request_headers")]
        public RequestHeaders RequestHeaders { get; set; }

        /// <summary>
        /// The request body, this matches the API response for the given resource        
        /// </summary>
        
        [JsonProperty("request_body")]
        [JsonPropertyName("request_body")]
        public string RequestBody { get; set; }

        /// <summary>
        /// The HTTP response code from the receiving server        
        /// </summary>
        
        [JsonProperty("response_code")]
        [JsonPropertyName("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The HTTP response message from the receiving server        
        /// </summary>
        
        [JsonProperty("response_message")]
        [JsonPropertyName("response_message")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Array of the response headers from the receiving server        
        /// </summary>
        
        [JsonProperty("response_headers")]
        [JsonPropertyName("response_headers")]
        public RequestHeaders ResponseHeaders { get; set; }

        /// <summary>
        /// The response body from the receiving server        
        /// </summary>
        
        [JsonProperty("response_body")]
        [JsonPropertyName("response_body")]
        public string ResponseBody { get; set; }

        /// <summary>
        /// The date the webhook delivery was logged, in the site’s timezone.     
        /// </summary>
        
        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date the webhook delivery was logged, GMT.   
        /// </summary>
        
        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }
    }
    
    
    public class RequestHeaders
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

}
