using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Settings
    {
        public static string Endpoint => "settings";

        /// <summary>
        /// Site title.
        /// </summary>
        
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Site tagline.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A city in the same timezone as you.
        /// </summary>
        
        [JsonProperty("timezone")]
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// A date format for all date strings.
        /// </summary>
        
        [JsonProperty("date_format")]
        [JsonPropertyName("date_format")]
        public string DateFormat { get; set; }

        /// <summary>
        /// A time format for all time strings.
        /// </summary>
        
        [JsonProperty("time_format")]
        [JsonPropertyName("time_format")]
        public string TimeFormat { get; set; }

        /// <summary>
        /// A day number of the week that the week should start on.
        /// </summary>
        
        [JsonProperty("start_of_week")]
        [JsonPropertyName("start_of_week")]
        public int StartOfWeek { get; set; }

        /// <summary>
        /// WordPress locale code.
        /// </summary>
        
        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Convert emoticons like :-) and :-P to graphics on display.
        /// </summary>
        
        [JsonProperty("use_smilies")]
        [JsonPropertyName("use_smilies")]
        public bool UseSmilies { get; set; }

        /// <summary>
        /// Default post category.
        /// </summary>
        
        [JsonProperty("default_category")]
        [JsonPropertyName("default_category")]
        public int DefaultCategory { get; set; }

        /// <summary>
        /// Default post format.
        /// </summary>
        
        [JsonProperty("default_post_format")]
        [JsonPropertyName("default_post_format")]
        public string DefaultPostFormat { get; set; }

        /// <summary>
        /// Blog pages show at most.
        /// </summary>
        
        [JsonProperty("posts_per_page")]
        [JsonPropertyName("posts_per_page")]
        public int PostsPerPage { get; set; }

        /// <summary>
        /// Allow link notifications from other blogs (pingbacks and trackbacks) on new articles.
        /// </summary>
        
        [JsonProperty("default_ping_status")]
        [JsonPropertyName("default_ping_status")]
        public string DefaultPingStatus { get; set; }

        /// <summary>
        /// Allow people to post comments on new articles.
        /// </summary>
        
        [JsonProperty("default_comment_status")]
        [JsonPropertyName("default_comment_status")]
        public string DefaultCommentStatus { get; set; }
    }
}
