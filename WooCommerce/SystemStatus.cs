using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WooCommerce.NET.WooCommerce
{
    public class SystemStatus
    {
        public static string Endpoint => "system_status";

        /// <summary>
        /// Environment. See System status - Environment properties 
        /// read-only
        /// </summary>        
        [JsonProperty("environment")]
        [JsonPropertyName("environment")]
        public SystemStatusEnvironment Environment { get; set; }

        /// <summary>
        /// Database. See System status - Database properties 
        /// read-only
        /// </summary>        
        [JsonProperty("database")]
        [JsonPropertyName("database")]
        public SystemStatusDatabase Database { get; set; }

        /// <summary>
        /// Active plugins. 
        /// read-only
        /// </summary>        
        [JsonProperty("active_plugins")]
        [JsonPropertyName("active_plugins")]
        public List<SystemStatusPlugins> ActivePlugins { get; set; }

        /// <summary>
        /// Theme. See System status - Theme properties 
        /// read-only
        /// </summary>        
        [JsonProperty("theme")]
        [JsonPropertyName("theme")]
        public SystemStatusTheme Theme { get; set; }

        /// <summary>
        /// Settings. See System status - Settings properties 
        /// read-only
        /// </summary>        
        [JsonProperty("settings")]
        [JsonPropertyName("settings")]
        public SystemStatusSetting Settings { get; set; }

        /// <summary>
        /// Security. See System status - Security properties 
        /// read-only
        /// </summary>        
        [JsonProperty("security")]
        [JsonPropertyName("security")]
        public SystemStatusSecurity Security { get; set; }

        /// <summary>
        /// WooCommerce pages. 
        /// read-only
        /// </summary>        
        [JsonProperty("pages")]
        [JsonPropertyName("pages")]
        public List<SystemStatusPage> Pages { get; set; }

    }


    public class SystemStatusEnvironment
    {
        /// <summary>
        /// Home URL. 
        /// read-only
        /// </summary>

        [JsonProperty("home_url")]
        [JsonPropertyName("home_url")]
        public string HomeUrl { get; private set; }

        /// <summary>
        /// Site URL. 
        /// read-only
        /// </summary>

        [JsonProperty("site_url")]
        [JsonPropertyName("site_url")]
        public string SiteUrl { get; private set; }

        /// <summary>
        /// WooCommerce version. 
        /// read-only
        /// </summary>

        [JsonProperty("wc_version")]
        [JsonPropertyName("wc_version")]
        public string WcVersion { get; private set; }

        /// <summary>
        /// Log directory. 
        /// read-only
        /// </summary>

        [JsonProperty("log_directory")]
        [JsonPropertyName("log_directory")]
        public string LogDirectory { get; private set; }

        /// <summary>
        /// Is log directory writable? 
        /// read-only
        /// </summary>

        [JsonProperty("log_directory_writable")]
        [JsonPropertyName("log_directory_writable")]
        public bool? LogDirectoryWritable { get; private set; }

        /// <summary>
        /// WordPress version. 
        /// read-only
        /// </summary>

        [JsonProperty("wp_version")]
        [JsonPropertyName("wp_version")]
        public string WpVersion { get; private set; }

        /// <summary>
        /// Is WordPress multisite? 
        /// read-only
        /// </summary>

        [JsonProperty("wp_multisite")]
        [JsonPropertyName("wp_multisite")]
        public bool? WpMultisite { get; private set; }

        /// <summary>
        /// WordPress memory limit. 
        /// read-only
        /// </summary>

        [JsonProperty("wp_memory_limit")]
        [JsonPropertyName("wp_memory_limit")]
        public int? WpMemoryLimit { get; private set; }

        /// <summary>
        /// Is WordPress debug mode active? 
        /// read-only
        /// </summary>

        [JsonProperty("wp_debug_mode")]
        [JsonPropertyName("wp_debug_mode")]
        public bool? WpDebugMode { get; private set; }

        /// <summary>
        /// Are WordPress cron jobs enabled? 
        /// read-only
        /// </summary>

        [JsonProperty("wp_cron")]
        [JsonPropertyName("wp_cron")]
        public bool? WpCron { get; private set; }

        /// <summary>
        /// WordPress language. 
        /// read-only
        /// </summary>

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public string Language { get; private set; }

        /// <summary>
        /// Server info. 
        /// read-only
        /// </summary>

        [JsonProperty("server_info")]
        [JsonPropertyName("server_info")]
        public string ServerInfo { get; private set; }

        /// <summary>
        /// PHP version. 
        /// read-only
        /// </summary>

        [JsonProperty("php_version")]
        [JsonPropertyName("php_version")]
        public string PhpVersion { get; private set; }

        /// <summary>
        /// PHP post max size. 
        /// read-only
        /// </summary>

        [JsonProperty("php_post_max_size")]
        [JsonPropertyName("php_post_max_size")]
        public int? PhpPostMaxSize { get; private set; }

        /// <summary>
        /// PHP max execution time. 
        /// read-only
        /// </summary>

        [JsonProperty("php_max_execution_time")]
        [JsonPropertyName("php_max_execution_time")]
        public int? PhpMaxExecutionTime { get; private set; }

        /// <summary>
        /// PHP max input vars. 
        /// read-only
        /// </summary>

        [JsonProperty("php_max_input_vars")]
        [JsonPropertyName("php_max_input_vars")]
        public int? PhpMaxInputVars { get; private set; }

        /// <summary>
        /// cURL version. 
        /// read-only
        /// </summary>

        [JsonProperty("curl_version")]
        [JsonPropertyName("curl_version")]
        public string CurlVersion { get; private set; }

        /// <summary>
        /// Is SUHOSIN installed? 
        /// read-only
        /// </summary>

        [JsonProperty("suhosin_installed")]
        [JsonPropertyName("suhosin_installed")]
        public bool? SuhosinInstalled { get; private set; }

        /// <summary>
        /// Max upload size. 
        /// read-only
        /// </summary>

        [JsonProperty("max_upload_size")]
        [JsonPropertyName("max_upload_size")]
        public int? MaxUploadSize { get; private set; }

        /// <summary>
        /// MySQL version. 
        /// read-only
        /// </summary>

        [JsonProperty("mysql_version")]
        [JsonPropertyName("mysql_version")]
        public string MysqlVersion { get; private set; }

        /// <summary>
        /// Default timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("default_timezone")]
        [JsonPropertyName("default_timezone")]
        public string DefaultTimezone { get; private set; }

        /// <summary>
        /// Is fsockopen/cURL enabled? 
        /// read-only
        /// </summary>

        [JsonProperty("fsockopen_or_curl_enabled")]
        [JsonPropertyName("fsockopen_or_curl_enabled")]
        public bool? FsockopenOrCurlEnabled { get; private set; }

        /// <summary>
        /// Is SoapClient class enabled? 
        /// read-only
        /// </summary>

        [JsonProperty("soapclient_enabled")]
        [JsonPropertyName("soapclient_enabled")]
        public bool? SoapclientEnabled { get; private set; }

        /// <summary>
        /// Is DomDocument class enabled? 
        /// read-only
        /// </summary>

        [JsonProperty("domdocument_enabled")]
        [JsonPropertyName("domdocument_enabled")]
        public bool? DomdocumentEnabled { get; private set; }

        /// <summary>
        /// Is GZip enabled? 
        /// read-only
        /// </summary>

        [JsonProperty("gzip_enabled")]
        [JsonPropertyName("gzip_enabled")]
        public bool? GzipEnabled { get; private set; }

        /// <summary>
        /// Is mbstring enabled? 
        /// read-only
        /// </summary>

        [JsonProperty("mbstring_enabled")]
        [JsonPropertyName("mbstring_enabled")]
        public bool? MbstringEnabled { get; private set; }

        /// <summary>
        /// Remote POST successful? 
        /// read-only
        /// </summary>

        [JsonProperty("remote_post_successful")]
        [JsonPropertyName("remote_post_successful")]
        public bool? RemotePostSuccessful { get; private set; }

        /// <summary>
        /// Remote POST response. 
        /// read-only
        /// </summary>

        [JsonProperty("remote_post_response")]
        [JsonPropertyName("remote_post_response")]
        public string RemotePostResponse { get; private set; }

        /// <summary>
        /// Remote GET successful? 
        /// read-only
        /// </summary>

        [JsonProperty("remote_get_successful")]
        [JsonPropertyName("remote_get_successful")]
        public bool? RemoteGetSuccessful { get; private set; }

        /// <summary>
        /// Remote GET response. 
        /// read-only
        /// </summary>

        [JsonProperty("remote_get_response")]
        [JsonPropertyName("remote_get_response")]
        public string RemoteGetResponse { get; private set; }

    }


    public class SystemStatusPlugins
    {

        [JsonProperty("plugin")]
        [JsonPropertyName("plugin")]
        public string Plugin { get; set; }


        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }


        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public string Version { get; set; }


        [JsonProperty("version_latest")]
        [JsonPropertyName("version_latest")]
        public string VersionLatest { get; set; }


        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }


        [JsonProperty("author_name")]
        [JsonPropertyName("author_name")]
        public string AuthorName { get; set; }


        [JsonProperty("author_url")]
        [JsonPropertyName("author_url")]
        public string AuthorUrl { get; set; }


        [JsonProperty("network_activated")]
        [JsonPropertyName("network_activated")]
        public bool? NetworkActivated { get; set; }
    }


    public class SystemStatusDatabase
    {
        /// <summary>
        /// WC database version. 
        /// read-only
        /// </summary>        
        [JsonProperty("wc_database_version")]
        [JsonPropertyName("wc_database_version")]
        public string WcDatabaseVersion { get; set; }

        /// <summary>
        /// Database prefix. 
        /// read-only
        /// </summary>        
        [JsonProperty("database_prefix")]
        [JsonPropertyName("database_prefix")]
        public string DatabasePrefix { get; set; }

        /// <summary>
        /// MaxMind GeoIP database. 
        /// read-only
        /// </summary>        
        [JsonProperty("maxmind_geoip_database")]
        [JsonPropertyName("maxmind_geoip_database")]
        public string MaxmindGeoipDatabase { get; set; }

        /// <summary>
        /// Database tables. 
        /// read-only
        /// </summary>        
        [JsonProperty("database_tables")]
        [JsonPropertyName("database_tables")]
        public object DatabaseTables { get; set; }

    }


    public class SystemStatusTheme
    {
        /// <summary>
        /// Theme name. 
        /// read-only
        /// </summary>        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Theme version. 
        /// read-only
        /// </summary>        
        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public string Version { get; private set; }

        /// <summary>
        /// Latest version of theme. 
        /// read-only
        /// </summary>        
        [JsonProperty("version_latest")]
        [JsonPropertyName("version_latest")]
        public string VersionLatest { get; private set; }

        /// <summary>
        /// Theme author URL. 
        /// read-only
        /// </summary>        
        [JsonProperty("author_url")]
        [JsonPropertyName("author_url")]
        public string AuthorUrl { get; private set; }

        /// <summary>
        /// Is this theme a child theme? 
        /// read-only
        /// </summary>        
        [JsonProperty("is_child_theme")]
        [JsonPropertyName("is_child_theme")]
        public bool? IsChildTheme { get; private set; }

        /// <summary>
        /// Does the theme declare WooCommerce support? 
        /// read-only
        /// </summary>        
        [JsonProperty("has_woocommerce_support")]
        [JsonPropertyName("has_woocommerce_support")]
        public bool? HasWoocommerceSupport { get; private set; }

        /// <summary>
        /// Does the theme have a woocommerce.php file? 
        /// read-only
        /// </summary>        
        [JsonProperty("has_woocommerce_file")]
        [JsonPropertyName("has_woocommerce_file")]
        public bool? HasWoocommerceFile { get; private set; }

        /// <summary>
        /// Does this theme have outdated templates? 
        /// read-only
        /// </summary>        
        [JsonProperty("has_outdated_templates")]
        [JsonPropertyName("has_outdated_templates")]
        public bool? HasOutdatedTemplates { get; private set; }

        /// <summary>
        /// Template overrides. 
        /// read-only
        /// </summary>        
        [JsonProperty("overrides")]
        [JsonPropertyName("overrides")]
        public List<string> Overrides { get; private set; }

        /// <summary>
        /// Parent theme name. 
        /// read-only
        /// </summary>        
        [JsonProperty("parent_name")]
        [JsonPropertyName("parent_name")]
        public string ParentName { get; private set; }

        /// <summary>
        /// Parent theme version. 
        /// read-only
        /// </summary>        
        [JsonProperty("parent_version")]
        [JsonPropertyName("parent_version")]
        public string ParentVersion { get; private set; }

        /// <summary>
        /// Parent theme author URL. 
        /// read-only
        /// </summary>        
        [JsonProperty("parent_author_url")]
        [JsonPropertyName("parent_author_url")]
        public string ParentAuthorUrl { get; private set; }

    }


    public class SystemStatusSetting
    {
        /// <summary>
        /// REST API enabled? 
        /// read-only
        /// </summary>        
        [JsonProperty("api_enabled")]
        [JsonPropertyName("api_enabled")]
        public bool? ApiEnabled { get; private set; }

        /// <summary>
        /// SSL forced? 
        /// read-only
        /// </summary>        
        [JsonProperty("force_ssl")]
        [JsonPropertyName("force_ssl")]
        public bool? ForceSsl { get; private set; }

        /// <summary>
        /// Currency. 
        /// read-only
        /// </summary>        
        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency { get; private set; }

        /// <summary>
        /// Currency symbol. 
        /// read-only
        /// </summary>        
        [JsonProperty("currency_symbol")]
        [JsonPropertyName("currency_symbol")]
        public string CurrencySymbol { get; private set; }

        /// <summary>
        /// Currency position. 
        /// read-only
        /// </summary>        
        [JsonProperty("currency_position")]
        [JsonPropertyName("currency_position")]
        public string CurrencyPosition { get; private set; }

        /// <summary>
        /// Thousand separator. 
        /// read-only
        /// </summary>        
        [JsonProperty("thousand_separator")]
        [JsonPropertyName("thousand_separator")]
        public string ThousandSeparator { get; private set; }

        /// <summary>
        /// Decimal separator. 
        /// read-only
        /// </summary>        
        [JsonProperty("decimal_separator")]
        [JsonPropertyName("decimal_separator")]
        public string DecimalSeparator { get; private set; }

        /// <summary>
        /// Number of decimals. 
        /// read-only
        /// </summary>        
        [JsonProperty("number_of_decimals")]
        [JsonPropertyName("number_of_decimals")]
        public int? NumberOfDecimals { get; private set; }

        /// <summary>
        /// Geolocation enabled? 
        /// read-only
        /// </summary>        
        [JsonProperty("geolocation_enabled")]
        [JsonPropertyName("geolocation_enabled")]
        public bool? GeolocationEnabled { get; private set; }

        /// <summary>
        /// Taxonomy terms for product/order statuses. 
        /// read-only
        /// </summary>        
        [JsonProperty("taxonomies")]
        [JsonPropertyName("taxonomies")]
        public List<object> Taxonomies { get; private set; }
    }


    public class SystemStatusSecurity
    {
        /// <summary>
        /// Is the connection to your store secure? 
        /// read-only
        /// </summary>        
        [JsonProperty("secure_connection")]
        [JsonPropertyName("secure_connection")]
        public bool? SecureConnection { get; private set; }

        /// <summary>
        /// Hide errors from visitors? 
        /// read-only
        /// </summary>        
        [JsonProperty("hide_errors")]
        [JsonPropertyName("hide_errors")]
        public bool? HideErrors { get; private set; }

    }


    public class SystemStatusPage
    {

        [JsonProperty("page_name")]
        [JsonPropertyName("page_name")]
        public string PageName { get; private set; }


        [JsonProperty("page_id")]
        [JsonPropertyName("page_id")]
        public string PageId { get; private set; }


        [JsonProperty("page_set")]
        [JsonPropertyName("page_set")]
        public bool PageSet { get; private set; }


        [JsonProperty("page_exists")]
        [JsonPropertyName("page_exists")]
        public bool PageExists { get; private set; }


        [JsonProperty("page_visible")]
        [JsonPropertyName("page_visible")]
        public bool PageVisible { get; private set; }


        [JsonProperty("shortcode")]
        [JsonPropertyName("shortcode")]
        public string Shortcode { get; private set; }


        [JsonProperty("shortcode_required")]
        [JsonPropertyName("shortcode_required")]
        public bool ShortcodeRequired { get; private set; }


        [JsonProperty("shortcode_present")]
        [JsonPropertyName("shortcode_present")]
        public bool ShortcodePresent { get; private set; }
    }


    public class SystemStatusTool
    {
        public static string Endpoint => "system_status/tools";

        /// <summary>
        /// A unique identifier for the tool. 
        /// read-only
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Tool name. 
        /// read-only
        /// </summary>

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// What running the tool will do. 
        /// read-only
        /// </summary>

        [JsonProperty("action")]
        [JsonPropertyName("action")]
        public string Action { get; private set; }

        /// <summary>
        /// Tool description. 
        /// read-only
        /// </summary>

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Did the tool run successfully? read-only 
        /// read-only write-only
        /// </summary>

        [JsonProperty("success")]
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Tool return message. read-only 
        /// read-only write-only
        /// </summary>        
        [JsonProperty("message")]
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Confirm execution of the tool. Default is false. 
        /// write-only
        /// </summary>        
        [JsonProperty("confirm")]
        [JsonPropertyName("confirm")]
        public bool Confirm { get; set; }

    }
}
