using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WooCommerce.NET.Analytics
{
    /// <summary>
    /// WooCommerce Analytics Performance Indicator
    /// Represents a single performance metric from the WooCommerce Analytics API
    /// </summary>
    [DataContract]
    public class PerformanceIndicator
    {
        /// <summary>
        /// The stat identifier (e.g., "revenue/total_sales", "orders/orders_count")
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("stat")]
        public string Stat { get; set; }

        /// <summary>
        /// The chart identifier (e.g., "total_sales", "net_revenue")
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("chart")]
        public string Chart { get; set; }

        /// <summary>
        /// The display label for this indicator
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// The format type (e.g., "currency", "number")
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// The numeric value of this indicator
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("value")]
        public decimal Value { get; set; }

        /// <summary>
        /// Related links for this indicator
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("_links")]
        public PerformanceIndicatorLinks Links { get; set; }
    }

    /// <summary>
    /// Links related to a performance indicator
    /// </summary>
    [DataContract]
    public class PerformanceIndicatorLinks
    {
        /// <summary>
        /// API endpoint links
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("api")]
        public List<PerformanceIndicatorLink> Api { get; set; }

        /// <summary>
        /// Report page links
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("report")]
        public List<PerformanceIndicatorLink> Report { get; set; }
    }

    /// <summary>
    /// A single link reference
    /// </summary>
    [DataContract]
    public class PerformanceIndicatorLink
    {
        /// <summary>
        /// The URL or path for this link
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}
