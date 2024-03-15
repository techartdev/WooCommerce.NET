using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WooCommerce.v3
{
    
    public class Data
    {
        public static string Endpoint => "data";

        /// <summary>
        /// Data resource ID.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Data resource description.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    
    public class Continent
    {
        /// <summary>
        /// 2 character continent code.
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Full name of continent.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// List of countries on this continent. See Continents - Countries properties
        /// </summary>
        
        [JsonProperty("countries")]
        [JsonPropertyName("countries")]
        public List<Country> Countries { get; set; }
    }

    
    public class Country
    {
        /// <summary>
        /// ISO3166 alpha-2 country code.
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Default ISO4127 alpha-3 currency code for the country.
        /// </summary>
        
        [JsonProperty("currency_code")]
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Currency symbol position for this country.
        /// </summary>
        
        [JsonProperty("currency_pos")]
        [JsonPropertyName("currency_pos")]
        public string CurrencyPos { get; set; }

        /// <summary>
        /// Decimal separator for displayed prices for this country.
        /// </summary>
        
        [JsonProperty("decimal_sep")]
        [JsonPropertyName("decimal_sep")]
        public string DecimalSep { get; set; }

        /// <summary>
        /// The unit lengths are defined in for this country.
        /// </summary>
        
        [JsonProperty("dimension_unit")]
        [JsonPropertyName("dimension_unit")]
        public string DimensionUnit { get; set; }

        /// <summary>
        /// Full name of country.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of decimal points shown in displayed prices for this country.
        /// </summary>
        
        [JsonProperty("num_decimals")]
        [JsonPropertyName("num_decimals")]
        public uint NumDecimals { get; set; }

        /// <summary>
        /// List of states in this country. See Continents - Countries - States properties
        /// </summary>
        
        [JsonProperty("states")]
        [JsonPropertyName("states")]
        public List<State> States { get; set; }

        /// <summary>
        /// Thousands separator for displayed prices in this country.
        /// </summary>
        
        [JsonProperty("thousand_sep")]
        [JsonPropertyName("thousand_sep")]
        public string ThousandSep { get; set; }

        /// <summary>
        /// The unit weights are defined in for this country.
        /// </summary>
        
        [JsonProperty("weight_unit")]
        [JsonPropertyName("weight_unit")]
        public string WeightUnit { get; set; }
    }

    
    public class State
    {
        /// <summary>
        /// State code.
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Full name of state.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    
    public class Currency
    {
        /// <summary>
        /// ISO4217 currency code.
        /// </summary>
        
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Full name of currency.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Currency symbol.
        /// </summary>
        
        [JsonProperty("symbol")]
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }
    }
}
