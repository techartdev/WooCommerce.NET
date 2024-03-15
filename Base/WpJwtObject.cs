using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WooCommerce.NET.Base
{
    public class WpJwtObject
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("user_nicename")]
        public string UserNicename { get; set; }

        [JsonProperty("user_display_name")]
        public string UserDisplayName { get; set; }
    }
}
