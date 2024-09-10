using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
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

        [JsonIgnore]
        public DateTime? ExpireDate
        {
            get
            {
                var handler = new JwtSecurityTokenHandler();

                // Read token without validating
                var jwtToken = handler.ReadToken(Token) as JwtSecurityToken;

                if (jwtToken != null && jwtToken.ValidTo != DateTime.MinValue)
                {
                    return jwtToken.ValidTo; // UTC Time
                }

                return null; // Token doesn't have a valid expiry date }
            }
        }
    }
}