using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.Legacy
{
    
    public class Store
    {
        public List<WCRoute> GetRoutes(string json)
        {
            json = json.Replace(" ", string.Empty).Replace("\n", string.Empty);

            int startIndex = json.IndexOf("routes", StringComparison.Ordinal);
            int endIndex = json.LastIndexOf("meta", StringComparison.Ordinal);
            string result = json.Substring(startIndex + 8, endIndex - startIndex - 11);

            string[] res = result.Split(new[] { "\"\\" }, StringSplitOptions.RemoveEmptyEntries);
            
            List<WCRoute> routes = new List<WCRoute>();
            foreach (var r in res)
            {
                if (r.Contains(":{"))
                {
                    string temp = r.TrimEnd(',');

                    WCRoute sr = new WCRoute
                    {
                        Resource = temp.Substring(0, temp.IndexOf("\":{", StringComparison.Ordinal)),
                        AcceptData = temp.Contains("accepts_data"),
                        Method = temp.Substring(temp.IndexOf("supports", StringComparison.Ordinal) + 11, temp.IndexOf("]", StringComparison.Ordinal) - temp.IndexOf("supports", StringComparison.Ordinal) - 12 + 1).Replace("\"", string.Empty).Split(',')
                    };

                    if (!sr.Resource.Contains("<"))
                        sr.Self = temp.Substring(temp.IndexOf("self\":", StringComparison.Ordinal) + 7, temp.IndexOf("\"}", temp.IndexOf("self\":", StringComparison.Ordinal), StringComparison.Ordinal) - temp.IndexOf("self\":", StringComparison.Ordinal) - 7);
                    routes.Add(sr);
                }
            }

            return routes;
        }

        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        
        [JsonProperty("URL")]
        [JsonPropertyName("URL")]
        public string Url { get; set; }

        
        [JsonProperty("wc_version")]
        [JsonPropertyName("wc_version")]
        public string WcVersion { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public List<WCRoute> WcRoutes { get; set; }

        
        [JsonProperty("routes")]
        [JsonPropertyName("routes")]
        public StoreMeta Meta { get; set; }
    }

    public class WCRoute
    {
        public string Resource { get; set; }

        public string[] Method { get; set; }

        public bool AcceptData { get; set; }

        public string Self { get; set; }
    }

    public class StoreMeta
    {
        [JsonProperty("timezone")]
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("currency_format")]
        [JsonPropertyName("currency_format")]
        public string CurrencyFormat { get; set; }

        [JsonProperty("tax_included")]
        [JsonPropertyName("tax_included")]
        public bool TaxIncluded { get; set; }

        [JsonProperty("weight_unit")]
        [JsonPropertyName("weight_unit")]
        public string WeightUnit { get; set; }

        [JsonProperty("dimension_unit")]
        [JsonPropertyName("dimension_unit")]
        public string DimensionUnit { get; set; }

        [JsonProperty("ssl_enabled")]
        [JsonPropertyName("ssl_enabled")]
        public bool SslEnabled { get; set; }

        [JsonProperty("permalinks_enabled")]
        [JsonPropertyName("permalinks_enabled")]
        public bool PermalinksEnabled { get; set; }

        [JsonProperty("links")]
        [JsonPropertyName("links")]
        public object Links { get; set; }
    }
}
