﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.WordPress.v2
{
    
    public class Users
    {
        public static string Endpoint => "users";

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Login name for the user.
        /// </summary>
        
        [JsonProperty("username")]
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// Display name for the user.
        /// </summary>
        
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// First name for the user.
        /// </summary>
        
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name for the user.
        /// </summary>
        
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The email address for the user.
        /// </summary>
        
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// URL of the user.
        /// </summary>
        
        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Description of the user.
        /// </summary>
        
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Author URL of the user.
        /// </summary>
        
        [JsonProperty("link")]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Locale for the user.
        /// </summary>
        
        [JsonProperty("locale")]
        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// The nickname for the user.
        /// </summary>
        
        [JsonProperty("nickname")]
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// An alphanumeric identifier for the user.
        /// </summary>
        
        [JsonProperty("slug")]
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Registration date for the user.
        /// </summary>
        
        [JsonProperty("registered_date")]
        [JsonPropertyName("registered_date")]
        public string RegisteredDate { get; set; }

        /// <summary>
        /// Roles assigned to the user.
        /// </summary>
        
        [JsonProperty("roles")]
        [JsonPropertyName("roles")]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Password for the user (never included).
        /// </summary>
        
        [JsonProperty("password")]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// All capabilities assigned to the user.
        /// </summary>
        
        [JsonProperty("capabilities")]
        [JsonPropertyName("capabilities")]
        public Capabilities Capabilities { get; set; }

        /// <summary>
        /// Any extra capabilities assigned to the user.
        /// </summary>
        
        [JsonProperty("extra_capabilities")]
        [JsonPropertyName("extra_capabilities")]
        public ExtraCapabilities ExtraCapabilities { get; set; }

        /// <summary>
        /// Avatar URLs for the user.
        /// </summary>
        
        [JsonProperty("avatar_urls")]
        [JsonPropertyName("avatar_urls")]
        public object AvatarUrls { get; set; }

        /// <summary>
        /// Meta fields.
        /// </summary>
        
        [JsonProperty("meta")]
        [JsonPropertyName("meta")]
        public object Meta { get; set; }
    }

    public class Capabilities
    {
        public bool switch_themes { get; set; }
        public bool edit_themes { get; set; }
        public bool activate_plugins { get; set; }
        public bool edit_plugins { get; set; }
        public bool edit_users { get; set; }
        public bool edit_files { get; set; }
        public bool manage_options { get; set; }
        public bool moderate_comments { get; set; }
        public bool manage_categories { get; set; }
        public bool manage_links { get; set; }
        public bool upload_files { get; set; }
        public bool import { get; set; }
        public bool unfiltered_html { get; set; }
        public bool edit_posts { get; set; }
        public bool edit_others_posts { get; set; }
        public bool edit_published_posts { get; set; }
        public bool publish_posts { get; set; }
        public bool edit_pages { get; set; }
        public bool read { get; set; }
        public bool level_10 { get; set; }
        public bool level_9 { get; set; }
        public bool level_8 { get; set; }
        public bool level_7 { get; set; }
        public bool level_6 { get; set; }
        public bool level_5 { get; set; }
        public bool level_4 { get; set; }
        public bool level_3 { get; set; }
        public bool level_2 { get; set; }
        public bool level_1 { get; set; }
        public bool level_0 { get; set; }
        public bool edit_others_pages { get; set; }
        public bool edit_published_pages { get; set; }
        public bool publish_pages { get; set; }
        public bool delete_pages { get; set; }
        public bool delete_others_pages { get; set; }
        public bool delete_published_pages { get; set; }
        public bool delete_posts { get; set; }
        public bool delete_others_posts { get; set; }
        public bool delete_published_posts { get; set; }
        public bool delete_private_posts { get; set; }
        public bool edit_private_posts { get; set; }
        public bool read_private_posts { get; set; }
        public bool delete_private_pages { get; set; }
        public bool edit_private_pages { get; set; }
        public bool read_private_pages { get; set; }
        public bool delete_users { get; set; }
        public bool create_users { get; set; }
        public bool unfiltered_upload { get; set; }
        public bool edit_dashboard { get; set; }
        public bool update_plugins { get; set; }
        public bool delete_plugins { get; set; }
        public bool install_plugins { get; set; }
        public bool update_themes { get; set; }
        public bool install_themes { get; set; }
        public bool update_core { get; set; }
        public bool list_users { get; set; }
        public bool remove_users { get; set; }
        public bool promote_users { get; set; }
        public bool edit_theme_options { get; set; }
        public bool delete_themes { get; set; }
        public bool export { get; set; }
        public bool manage_woocommerce { get; set; }
        public bool view_woocommerce_reports { get; set; }
        public bool edit_product { get; set; }
        public bool read_product { get; set; }
        public bool delete_product { get; set; }
        public bool edit_products { get; set; }
        public bool edit_others_products { get; set; }
        public bool publish_products { get; set; }
        public bool read_private_products { get; set; }
        public bool delete_products { get; set; }
        public bool delete_private_products { get; set; }
        public bool delete_published_products { get; set; }
        public bool delete_others_products { get; set; }
        public bool edit_private_products { get; set; }
        public bool edit_published_products { get; set; }
        public bool manage_product_terms { get; set; }
        public bool edit_product_terms { get; set; }
        public bool delete_product_terms { get; set; }
        public bool assign_product_terms { get; set; }
        public bool edit_shop_order { get; set; }
        public bool read_shop_order { get; set; }
        public bool delete_shop_order { get; set; }
        public bool edit_shop_orders { get; set; }
        public bool edit_others_shop_orders { get; set; }
        public bool publish_shop_orders { get; set; }
        public bool read_private_shop_orders { get; set; }
        public bool delete_shop_orders { get; set; }
        public bool delete_private_shop_orders { get; set; }
        public bool delete_published_shop_orders { get; set; }
        public bool delete_others_shop_orders { get; set; }
        public bool edit_private_shop_orders { get; set; }
        public bool edit_published_shop_orders { get; set; }
        public bool manage_shop_order_terms { get; set; }
        public bool edit_shop_order_terms { get; set; }
        public bool delete_shop_order_terms { get; set; }
        public bool assign_shop_order_terms { get; set; }
        public bool edit_shop_coupon { get; set; }
        public bool read_shop_coupon { get; set; }
        public bool delete_shop_coupon { get; set; }
        public bool edit_shop_coupons { get; set; }
        public bool edit_others_shop_coupons { get; set; }
        public bool publish_shop_coupons { get; set; }
        public bool read_private_shop_coupons { get; set; }
        public bool delete_shop_coupons { get; set; }
        public bool delete_private_shop_coupons { get; set; }
        public bool delete_published_shop_coupons { get; set; }
        public bool delete_others_shop_coupons { get; set; }
        public bool edit_private_shop_coupons { get; set; }
        public bool edit_published_shop_coupons { get; set; }
        public bool manage_shop_coupon_terms { get; set; }
        public bool edit_shop_coupon_terms { get; set; }
        public bool delete_shop_coupon_terms { get; set; }
        public bool assign_shop_coupon_terms { get; set; }
        public bool wpseo_manage_options { get; set; }
        public bool manage_berocket { get; set; }
        public bool manage_berocket_account { get; set; }

        [JsonProperty("vc_access_rules_post_types/page")]
        [JsonPropertyName("vc_access_rules_post_types/page")]
        public bool VcAccessRulesPostTypesPage { get; set; }

        [JsonProperty("vc_access_rules_post_types/product")]
        [JsonPropertyName("vc_access_rules_post_types/product")]
        public bool VcAccessRulesPostTypesProduct { get; set; }
        public string vc_access_rules_post_types { get; set; }
        public bool vc_access_rules_backend_editor { get; set; }
        public bool vc_access_rules_frontend_editor { get; set; }
        public bool vc_access_rules_unfiltered_html { get; set; }
        public bool vc_access_rules_post_settings { get; set; }
        public bool vc_access_rules_settings { get; set; }
        public bool vc_access_rules_templates { get; set; }
        public bool vc_access_rules_shortcodes { get; set; }
        public bool vc_access_rules_grid_builder { get; set; }
        public bool vc_access_rules_presets { get; set; }
        public bool vc_access_rules_dragndrop { get; set; }
        public bool frm_view_forms { get; set; }
        public bool frm_edit_forms { get; set; }
        public bool frm_delete_forms { get; set; }
        public bool frm_change_settings { get; set; }
        public bool frm_view_entries { get; set; }
        public bool frm_delete_entries { get; set; }
        public bool atum_edit_purchase_price { get; set; }
        public bool atum_view_purchase_price { get; set; }
        public bool atum_edit_purchase_order { get; set; }
        public bool atum_read_purchase_order { get; set; }
        public bool atum_delete_purchase_order { get; set; }
        public bool atum_read_private_purchase_orders { get; set; }
        public bool atum_publish_purchase_orders { get; set; }
        public bool atum_edit_purchase_orders { get; set; }
        public bool atum_edit_others_purchase_orders { get; set; }
        public bool atum_create_purchase_orders { get; set; }
        public bool atum_delete_purchase_orders { get; set; }
        public bool atum_delete_other_purchase_orders { get; set; }
        public bool atum_edit_inventory_log { get; set; }
        public bool atum_read_inventory_log { get; set; }
        public bool atum_delete_inventory_log { get; set; }
        public bool atum_read_private_inventory_logs { get; set; }
        public bool atum_publish_inventory_logs { get; set; }
        public bool atum_edit_inventory_logs { get; set; }
        public bool atum_edit_others_inventory_logs { get; set; }
        public bool atum_create_inventory_logs { get; set; }
        public bool atum_delete_inventory_logs { get; set; }
        public bool atum_delete_other_inventory_logs { get; set; }
        public bool atum_read_inbound_stock { get; set; }
        public bool atum_edit_out_stock_threshold { get; set; }
        public bool atum_edit_supplier { get; set; }
        public bool atum_read_supplier { get; set; }
        public bool atum_delete_supplier { get; set; }
        public bool atum_edit_suppliers { get; set; }
        public bool atum_edit_others_suppliers { get; set; }
        public bool atum_publish_suppliers { get; set; }
        public bool atum_read_private_suppliers { get; set; }
        public bool atum_create_suppliers { get; set; }
        public bool atum_delete_suppliers { get; set; }
        public bool atum_delete_private_suppliers { get; set; }
        public bool atum_delete_published_suppliers { get; set; }
        public bool atum_delete_other_suppliers { get; set; }
        public bool atum_edit_private_suppliers { get; set; }
        public bool atum_edit_published_suppliers { get; set; }
        public bool atum_manage_settings { get; set; }
        public bool atum_edit_visual_settings { get; set; }
        public bool atum_view_admin_menu { get; set; }
        public bool atum_view_admin_bar_menu { get; set; }
        public bool atum_read_order_notes { get; set; }
        public bool atum_create_order_notes { get; set; }
        public bool atum_delete_order_notes { get; set; }
        public bool atum_manage_location_terms { get; set; }
        public bool atum_edit_location_terms { get; set; }
        public bool atum_delete_location_terms { get; set; }
        public bool atum_assign_location_terms { get; set; }
        public bool atum_export_data { get; set; }
        public bool atum_view_statistics { get; set; }
        public bool edit_others_multiple_post_types { get; set; }
        public bool read_private_multiple_post_types { get; set; }
        public bool restrict_content { get; set; }
        public bool list_roles { get; set; }
        public bool create_roles { get; set; }
        public bool delete_roles { get; set; }
        public bool edit_roles { get; set; }
        public bool edit_single_filter { get; set; }
        public bool read_single_filter { get; set; }
        public bool delete_single_filter { get; set; }
        public bool edit_single_filters { get; set; }
        public bool edit_others_single_filters { get; set; }
        public bool delete_single_filters { get; set; }
        public bool publish_single_filters { get; set; }
        public bool read_private_single_filters { get; set; }
        public bool delete_private_single_filters { get; set; }
        public bool delete_published_single_filters { get; set; }
        public bool delete_others_single_filters { get; set; }
        public bool edit_private_single_filters { get; set; }
        public bool edit_published_single_filters { get; set; }
        public bool edit_group_filters { get; set; }
        public bool read_group_filters { get; set; }
        public bool delete_group_filters { get; set; }
        public bool edit_group_filterss { get; set; }
        public bool edit_others_group_filterss { get; set; }
        public bool delete_group_filterss { get; set; }
        public bool publish_group_filterss { get; set; }
        public bool read_private_group_filterss { get; set; }
        public bool delete_private_group_filterss { get; set; }
        public bool delete_published_group_filterss { get; set; }
        public bool delete_others_group_filterss { get; set; }
        public bool edit_private_group_filterss { get; set; }
        public bool edit_published_group_filterss { get; set; }
        public bool manage_berocket_aapf { get; set; }
        public bool administrator { get; set; }
    }

    public class ExtraCapabilities
    {
        [JsonProperty("administrator")]
        [JsonPropertyName("administrator")]
        public bool Administrator { get; set; }

        [JsonProperty("frm_view_forms")]
        [JsonPropertyName("frm_view_forms")]
        public bool FrmViewForms { get; set; }

        [JsonProperty("frm_edit_forms")]
        [JsonPropertyName("frm_edit_forms")]
        public bool FrmEditForms { get; set; }

        [JsonProperty("frm_delete_forms")]
        [JsonPropertyName("frm_delete_forms")]
        public bool FrmDeleteForms { get; set; }

        [JsonProperty("frm_change_settings")]
        [JsonPropertyName("frm_change_settings")]
        public bool FrmChangeSettings { get; set; }

        [JsonProperty("frm_view_entries")]
        [JsonPropertyName("frm_view_entries")]
        public bool FrmViewEntries { get; set; }

        [JsonProperty("frm_edit_entries")]
        [JsonPropertyName("frm_edit_entries")]
        public bool FrmDeleteEntries { get; set; }
    }
}
