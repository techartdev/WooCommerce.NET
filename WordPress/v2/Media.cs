using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Media
    {
        public static string Endpoint => "media";

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
        public ulong? Id  { get; set; }

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
        /// The ID for the author of the object.
        /// </summary>
        
        [JsonProperty("author")]
        [JsonPropertyName("author")]
        public ulong? Author  { get; set; }

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
        public string PingStatus { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public List<object> Meta  { get; set; }

        /// <summary>
        /// The theme file to use to display the object.
        /// </summary>
        
        [JsonProperty("template")]
        [JsonPropertyName("template")]
        public string Template { get; set; }

        /// <summary>
        /// Alternative text to display when attachment is not displayed.
        /// </summary>
        
        [JsonProperty("alt_text")]
        [JsonPropertyName("alt_text")]
        public string AltText { get; set; }

        /// <summary>
        /// The attachment caption.
        /// </summary>
        [JsonProperty("caption")]
        [JsonPropertyName("caption")]
        protected ContentObject CaptionValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Caption
        {
            get => CaptionValue.Rendered;
            set
            {
                if (CaptionValue == null)
                    CaptionValue = new ContentObject();

                CaptionValue.Rendered = value;
            }
        }

        /// <summary>
        /// The attachment description.
        /// </summary>
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        protected ContentObject DescriptionValue { get; set; }

        
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Description
        {
            get => DescriptionValue.Rendered;
            set
            {
                if (DescriptionValue == null)
                    DescriptionValue = new ContentObject();

                DescriptionValue.Rendered = value;
            }
        }

        /// <summary>
        /// Attachment type.
        /// </summary>
        
        [JsonProperty("media_type")]
        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// The attachment MIME type.
        /// </summary>
        
        [JsonProperty("mime_type")]
        [JsonPropertyName("mime_type")]
        public string MimeType { get; set; }

        /// <summary>
        /// Details about the media file, specific to its type.
        /// </summary>
        
        [JsonProperty("media_details")]
        [JsonPropertyName("media_details")]
        public object MediaDetails { get; set; }

        /// <summary>
        /// The ID for the associated post of the attachment.
        /// </summary>
        
        [JsonProperty("post")]
        [JsonPropertyName("post")]
        public ulong? Post  { get; set; }

        /// <summary>
        /// URL to the original attachment file.
        /// </summary>
        
        [JsonProperty("source_url")]
        [JsonPropertyName("source_url")]
        public string SourceUrl { get; set; }

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
