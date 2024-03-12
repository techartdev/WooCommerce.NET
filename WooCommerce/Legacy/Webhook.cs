using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.Legacy
{
    [CollectionDataContract]
    public class WebhookList : List<Webhook>
    {
        [DataMember]
        [JsonProperty("webhooks")]
        [JsonPropertyName("webhooks")]
        public List<Webhook> Webhooks { get; set; }
    }

    [DataContract]
    public class Webhook
    {
        /// <summary>
        /// Webhook ID (post ID) 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }


        /// <summary>
        /// A friendly name for the webhook, defaults to “Webhook created on <date>”
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Webhook status, options are active (delivers payload), paused (does not deliver), or disabled (does not deliver due delivery failures). Default is active
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Webhook topic, e.g. coupon.updated. See the complete list (http://woothemes.github.io/woocommerce-rest-api-docs/#webhooks)
        /// The topic is a combination resource (e.g. order) and event (e.g. created) and maps to one or more hook names (e.g. woocommerce_checkout_order_processed). Webhooks can be created using the topic name and the appropriate hooks are automatically added.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("topic")]
        [JsonPropertyName("topic")]
        public string Topic { get; set; }

        /// <summary>
        /// Webhook resource, e.g. coupon
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("resource")]
        [JsonPropertyName("resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Webhook event, e.g. updated
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("event")]
        [JsonPropertyName("event")]
        public string Event { get; set; }


        /// <summary>
        /// WooCommerce action names associated with the webhook
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("hooks")]
        [JsonPropertyName("hooks")]
        public List<string> Hooks { get; set; }

        /// <summary>
        /// The URL where the webhook payload is delivered       
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("delivery_url")]
        [JsonPropertyName("delivery_url")]
        public string DeliveryUrl { get; set; }

        /// <summary>
        /// Secret key used to generate a hash of the delivered webhook and provided in the request headers. This will default to the current API user’s consumer secret if not provided
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("secret")]
        [JsonPropertyName("secret")]
        public string Secret { get; set; }


        /// <summary>
        /// UTC DateTime when the webhook was created
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// UTC DateTime when the webhook was last updated
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }
    }


    [CollectionDataContract]
    public class WebhookDeliveryList : List<WebhookDelivery>
    {
        [DataMember]
        [JsonProperty("webhookdeliveries")]
        [JsonPropertyName("webhookdeliveries")]
        public List<Webhook> WebhookDeliveries { get; set; }
    }

    [DataContract]
    public class WebhookDelivery
    {
        /// <summary>
        /// The delivery ID (comment ID)
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// The delivery duration, in seconds        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("duration")]
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// A friendly summary of the response including the HTTP response code, message, and body        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("summary")]
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// The URL where the webhook was delivered
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("request_url")]
        [JsonPropertyName("request_url")]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Array of request headers (see Request Headers Attributes)
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("request_headers")]
        [JsonPropertyName("request_headers")]
        public RequestHeaders RequestHeaders { get; set; }

        /// <summary>
        /// The request body, this matches the API response for the given resource        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("request_body")]
        [JsonPropertyName("request_body")]
        public string RequestBody { get; set; }

        /// <summary>
        /// The HTTP response code from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("response_code")]
        [JsonPropertyName("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The HTTP response message from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("response_message")]
        [JsonPropertyName("response_message")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Array of the response headers from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("response_headers")]
        [JsonPropertyName("response_headers")]
        public ResponseHeaders ResponseHeaders { get; set; }

        /// <summary>
        /// The response body from the receiving server        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("response_body")]
        [JsonPropertyName("response_body")]
        public string ResponseBody { get; set; }

        /// <summary>
        /// A DateTime of when the delivery was logged        
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

    }


    [DataContract]
    public class RequestHeaders
    {
        /// <summary>
        /// The request user agent, defaults to “WooCommerce/{version} Hookshot (WordPress/{version})”
        /// </summary>
        [DataMember(Name = "User-Agent", EmitDefaultValue = false)]
        [JsonProperty("User-Agent")]
        [JsonPropertyName("User-Agent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// The request content-type, defaults to “application/json”
        /// </summary>
        [DataMember(Name = "Content-Type", EmitDefaultValue = false)]
        [JsonProperty("Content-Type")]
        [JsonPropertyName("Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The webhook topic
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Topic", EmitDefaultValue = false)]
        [JsonProperty("X-WC-Webhook-Topic")]
        [JsonPropertyName("X-WC-Webhook-Topic")]
        public string XwcWebhookTopic { get; set; }

        /// <summary>
        /// The webhook resource
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Resource", EmitDefaultValue = false)]
        [JsonProperty("X-WC-Webhook-Resource")]
        [JsonPropertyName("X-WC-Webhook-Resource")]
        public string XwcWebhookResource { get; set; }

        /// <summary>
        /// The webhook event
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Event", EmitDefaultValue = false)]
        [JsonProperty("X-WC-Webhook-Event")]
        [JsonPropertyName("X-WC-Webhook-Event")]
        public string XwcWebhookEvent { get; set; }

        /// <summary>
        /// A base64 encoded HMAC-SHA256 hash of the payload
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Signature", EmitDefaultValue = false)]
        [JsonProperty("X-WC-Webhook-Signature")]
        [JsonPropertyName("X-WC-Webhook-Signature")]
        public string XwcWebhookSignature { get; set; }

        /// <summary>
        /// The webhook’s ID
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-ID", EmitDefaultValue = false)]
        [JsonProperty("X-WC-Webhook-ID")]
        [JsonPropertyName("X-WC-Webhook-ID")]
        public uint XwcWebhookId { get; set; }

        /// <summary>
        /// The delivery ID
        /// </summary>
        [DataMember(Name = "X-WC-Webhook-Delivery-ID", EmitDefaultValue = false)]
        [JsonProperty("X-WC-Webhook-Delivery-ID")]
        [JsonPropertyName("X-WC-Webhook-Delivery-ID")]
        public uint XwcWebhookDeliveryId { get; set; }

    }

    [DataContract]
    public class ResponseHeaders
    {
        /// <summary>
        /// cache response directives values: private | public | no-cache
        /// </summary>
        [DataMember(Name = "cache-control", EmitDefaultValue = false)]
        [JsonProperty("cache-control")]
        [JsonPropertyName("cache-control")]
        public string CacheControl { get; set; }

        /// <summary>
        ///  The response content-type, defaults to “application/json”
        /// </summary>
        [DataMember(Name = "content-type", EmitDefaultValue = false)]
        [JsonProperty("content-type")]
        [JsonPropertyName("content-type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Webserver where webhook delivery page is hosted.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("server")]
        [JsonPropertyName("server")]
        public string Server { get; set; }

        /// <summary>
        /// Host engine where webhook delivery page is hosted, e.g. PHP / ASP.Net
        /// </summary>
        [DataMember(Name = "x-powered-by", EmitDefaultValue = false)]
        [JsonProperty("x-powered-by")]
        [JsonPropertyName("x-powered-by")]
        public string XPoweredBy { get; set; }

        /// <summary>
        /// Date of webhook delivery posted
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// Connection state
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("connection")]
        [JsonPropertyName("connection")]
        public string Connection { get; set; }

        /// <summary>
        /// The request data length
        /// </summary>
        [DataMember(Name = "content-length", EmitDefaultValue = false)]
        [JsonProperty("content-length")]
        [JsonPropertyName("content-length")]
        public string Contentlength { get; set; }
    }
}
