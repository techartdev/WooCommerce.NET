using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Pages
    {
        public static string Endpoint => "pages";

        /// <summary>
        /// The date the object was published, in the site's timezone.
        /// </summary>
        
        [JsonProperty("date")]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// The date the object was published, as GMT.
        /// </summary>
        
        [JsonProperty("date_gmt")]
        [JsonPropertyName("date_gmt")]
        public string DateGmt { get; set; }

        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        [JsonProperty("guid")]
        [JsonPropertyName("guid")]
        protected ContentObject GuidValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Guid
        {
            get => GuidValue.Rendered;
            set
            {
                if (GuidValue == null)
                    GuidValue = new ContentObject();

                GuidValue.Rendered = value;
            }
        }

        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// URL to the object.
        /// </summary>
        
        [JsonProperty("link")]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// The date the object was last modified, in the site's timezone.
        /// </summary>
        
        [JsonProperty("modified")]
        [JsonPropertyName("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// The date the object was last modified, as GMT.
        /// </summary>
        
        [JsonProperty("modified_gmt")]
        [JsonPropertyName("modified_gmt")]
        public string ModifiedGmt { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the object unique to its type.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// A named status for the object.
        /// </summary>
        
        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of Post for the object.
        /// </summary>
        
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// A password to protect access to the content and excerpt.
        /// </summary>
        
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// The ID for the parent of the object.
        /// </summary>
        
        [JsonProperty("parent")]
        [JsonPropertyName("parent")]
        public ulong? Parent  { get; set; }

        /// <summary>
        /// The title for the object.
        /// </summary>
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        protected ContentObject TitleValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Title
        {
            get => TitleValue.Rendered;
            set
            {
                if (TitleValue == null)
                    TitleValue = new ContentObject();

                TitleValue.Rendered = value;
            }
        }

        /// <summary>
        /// The content for the object.
        /// </summary>
        [JsonProperty("content")]
        [JsonPropertyName("content")]
        protected ContentObject ContentValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Content
        {
            get => ContentValue.Rendered;
            set
            {
                if (ContentValue == null)
                    ContentValue = new ContentObject();

                ContentValue.Rendered = value;
            }
        }


        /// <summary>
        /// The ID for the author of the object.
        /// </summary>
        
        [JsonProperty("author")]
        [JsonPropertyName("author")]
        public ulong? Author  { get; set; }

        /// <summary>
        /// The excerpt for the object.
        /// </summary>
        [JsonProperty("excerpt")]
        [JsonPropertyName("excerpt")]
        protected ContentObject ExcerptValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Excerpt
        {
            get => ExcerptValue.Rendered;
            set
            {
                if (ExcerptValue == null)
                    ExcerptValue = new ContentObject();

                ExcerptValue.Rendered = value;
            }
        }

        /// <summary>
        /// The ID of the featured media for the object.
        /// </summary>
        
        [JsonProperty("featured_media")]
        [JsonPropertyName("featured_media")]
        public ulong? FeaturedMedia  { get; set; }

        /// <summary>
        /// Whether or not comments are open on the object.
        /// </summary>
        
        [JsonProperty("comment_status")]
        [JsonPropertyName("comment_status")]
        public string CommentStatus { get; set; }

        /// <summary>
        /// Whether or not the object can be pinged.
        /// </summary>
        
        [JsonProperty("ping_status")]
        [JsonPropertyName("ping_status")]
        public string PingStatus  { get; set; }

        /// <summary>
        /// The order of the object in relation to other object of its type.
        /// </summary>
        
        [JsonProperty("menu_order")]
        [JsonPropertyName("menu_order")]
        public int? MenuOrder  { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public object Meta  { get; set; }

        /// <summary>
        /// The theme file to use to display the object.
        /// </summary>
        
        [JsonProperty("template")]
        [JsonPropertyName("template")]
        public string Template { get; set; }

        /// <summary>
        /// Format json string on Serialize
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static string FormatJsonS(string json)
        {
            int startIndex = json.IndexOf("{\"rendered\":", StringComparison.Ordinal);

            while (startIndex > 0)
            {
                int endIndex = json.IndexOf("\"}", startIndex, StringComparison.Ordinal);

                string oldPart = json.Substring(startIndex, endIndex - startIndex + 2);
                string newPart = oldPart.Substring(12).TrimEnd('}');

                json = json.Replace(oldPart, newPart);

                startIndex = json.IndexOf("{\"rendered\":", StringComparison.Ordinal);
            }

            return json;
        }
    }
}
