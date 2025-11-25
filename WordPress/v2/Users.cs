using Newtonsoft.Json;
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
        public bool SwitchThemes { get; set; }
        public bool EditThemes { get; set; }
        public bool ActivatePlugins { get; set; }
        public bool EditPlugins { get; set; }
        public bool EditUsers { get; set; }
        public bool EditFiles { get; set; }
        public bool ManageOptions { get; set; }
        public bool ModerateComments { get; set; }
        public bool ManageCategories { get; set; }
        public bool ManageLinks { get; set; }
        public bool UploadFiles { get; set; }
        public bool Import { get; set; }
        public bool UnfilteredHtml { get; set; }
        public bool EditPosts { get; set; }
        public bool EditOthersPosts { get; set; }
        public bool EditPublishedPosts { get; set; }
        public bool PublishPosts { get; set; }
        public bool EditPages { get; set; }
        public bool Read { get; set; }
        public bool Level10 { get; set; }
        public bool Level9 { get; set; }
        public bool Level8 { get; set; }
        public bool Level7 { get; set; }
        public bool Level6 { get; set; }
        public bool Level5 { get; set; }
        public bool Level4 { get; set; }
        public bool Level3 { get; set; }
        public bool Level2 { get; set; }
        public bool Level1 { get; set; }
        public bool Level0 { get; set; }
        public bool EditOthersPages { get; set; }
        public bool EditPublishedPages { get; set; }
        public bool PublishPages { get; set; }
        public bool DeletePages { get; set; }
        public bool DeleteOthersPages { get; set; }
        public bool DeletePublishedPages { get; set; }
        public bool DeletePosts { get; set; }
        public bool DeleteOthersPosts { get; set; }
        public bool DeletePublishedPosts { get; set; }
        public bool DeletePrivatePosts { get; set; }
        public bool EditPrivatePosts { get; set; }
        public bool ReadPrivatePosts { get; set; }
        public bool DeletePrivatePages { get; set; }
        public bool EditPrivatePages { get; set; }
        public bool ReadPrivatePages { get; set; }
        public bool DeleteUsers { get; set; }
        public bool CreateUsers { get; set; }
        public bool UnfilteredUpload { get; set; }
        public bool EditDashboard { get; set; }
        public bool UpdatePlugins { get; set; }
        public bool DeletePlugins { get; set; }
        public bool InstallPlugins { get; set; }
        public bool UpdateThemes { get; set; }
        public bool InstallThemes { get; set; }
        public bool UpdateCore { get; set; }
        public bool ListUsers { get; set; }
        public bool RemoveUsers { get; set; }
        public bool PromoteUsers { get; set; }
        public bool EditThemeOptions { get; set; }
        public bool DeleteThemes { get; set; }
        public bool Export { get; set; }
        public bool ManageWoocommerce { get; set; }
        public bool ViewWoocommerceReports { get; set; }
        public bool EditProduct { get; set; }
        public bool ReadProduct { get; set; }
        public bool DeleteProduct { get; set; }
        public bool EditProducts { get; set; }
        public bool EditOthersProducts { get; set; }
        public bool PublishProducts { get; set; }
        public bool ReadPrivateProducts { get; set; }
        public bool DeleteProducts { get; set; }
        public bool DeletePrivateProducts { get; set; }
        public bool DeletePublishedProducts { get; set; }
        public bool DeleteOthersProducts { get; set; }
        public bool EditPrivateProducts { get; set; }
        public bool EditPublishedProducts { get; set; }
        public bool ManageProductTerms { get; set; }
        public bool EditProductTerms { get; set; }
        public bool DeleteProductTerms { get; set; }
        public bool AssignProductTerms { get; set; }
        public bool EditShopOrder { get; set; }
        public bool ReadShopOrder { get; set; }
        public bool DeleteShopOrder { get; set; }
        public bool EditShopOrders { get; set; }
        public bool EditOthersShopOrders { get; set; }
        public bool PublishShopOrders { get; set; }
        public bool ReadPrivateShopOrders { get; set; }
        public bool DeleteShopOrders { get; set; }
        public bool DeletePrivateShopOrders { get; set; }
        public bool DeletePublishedShopOrders { get; set; }
        public bool DeleteOthersShopOrders { get; set; }
        public bool EditPrivateShopOrders { get; set; }
        public bool EditPublishedShopOrders { get; set; }
        public bool ManageShopOrderTerms { get; set; }
        public bool EditShopOrderTerms { get; set; }
        public bool DeleteShopOrderTerms { get; set; }
        public bool AssignShopOrderTerms { get; set; }
        public bool EditShopCoupon { get; set; }
        public bool ReadShopCoupon { get; set; }
        public bool DeleteShopCoupon { get; set; }
        public bool EditShopCoupons { get; set; }
        public bool EditOthersShopCoupons { get; set; }
        public bool PublishShopCoupons { get; set; }
        public bool ReadPrivateShopCoupons { get; set; }
        public bool DeleteShopCoupons { get; set; }
        public bool DeletePrivateShopCoupons { get; set; }
        public bool DeletePublishedShopCoupons { get; set; }
        public bool DeleteOthersShopCoupons { get; set; }
        public bool EditPrivateShopCoupons { get; set; }
        public bool EditPublishedShopCoupons { get; set; }
        public bool ManageShopCouponTerms { get; set; }
        public bool EditShopCouponTerms { get; set; }
        public bool DeleteShopCouponTerms { get; set; }
        public bool AssignShopCouponTerms { get; set; }
        public bool WpseoManageOptions { get; set; }
        public bool ManageBerocket { get; set; }
        public bool ManageBerocketAccount { get; set; }

        [JsonProperty("vc_access_rules_post_types/page")]
        [JsonPropertyName("vc_access_rules_post_types/page")]
        public bool VcAccessRulesPostTypesPage { get; set; }

        [JsonProperty("vc_access_rules_post_types/product")]
        [JsonPropertyName("vc_access_rules_post_types/product")]
        public bool VcAccessRulesPostTypesProduct { get; set; }
        public string VcAccessRulesPostTypes { get; set; }
        public bool VcAccessRulesBackendEditor { get; set; }
        public bool VcAccessRulesFrontendEditor { get; set; }
        public bool VcAccessRulesUnfilteredHtml { get; set; }
        public bool VcAccessRulesPostSettings { get; set; }
        public bool VcAccessRulesSettings { get; set; }
        public bool VcAccessRulesTemplates { get; set; }
        public bool VcAccessRulesShortcodes { get; set; }
        public bool VcAccessRulesGridBuilder { get; set; }
        public bool VcAccessRulesPresets { get; set; }
        public bool VcAccessRulesDragndrop { get; set; }
        public bool FrmViewForms { get; set; }
        public bool FrmEditForms { get; set; }
        public bool FrmDeleteForms { get; set; }
        public bool FrmChangeSettings { get; set; }
        public bool FrmViewEntries { get; set; }
        public bool FrmDeleteEntries { get; set; }
        public bool AtumEditPurchasePrice { get; set; }
        public bool AtumViewPurchasePrice { get; set; }
        public bool AtumEditPurchaseOrder { get; set; }
        public bool AtumReadPurchaseOrder { get; set; }
        public bool AtumDeletePurchaseOrder { get; set; }
        public bool AtumReadPrivatePurchaseOrders { get; set; }
        public bool AtumPublishPurchaseOrders { get; set; }
        public bool AtumEditPurchaseOrders { get; set; }
        public bool AtumEditOthersPurchaseOrders { get; set; }
        public bool AtumCreatePurchaseOrders { get; set; }
        public bool AtumDeletePurchaseOrders { get; set; }
        public bool AtumDeleteOtherPurchaseOrders { get; set; }
        public bool AtumEditInventoryLog { get; set; }
        public bool AtumReadInventoryLog { get; set; }
        public bool AtumDeleteInventoryLog { get; set; }
        public bool AtumReadPrivateInventoryLogs { get; set; }
        public bool AtumPublishInventoryLogs { get; set; }
        public bool AtumEditInventoryLogs { get; set; }
        public bool AtumEditOthersInventoryLogs { get; set; }
        public bool AtumCreateInventoryLogs { get; set; }
        public bool AtumDeleteInventoryLogs { get; set; }
        public bool AtumDeleteOtherInventoryLogs { get; set; }
        public bool AtumReadInboundStock { get; set; }
        public bool AtumEditOutStockThreshold { get; set; }
        public bool AtumEditSupplier { get; set; }
        public bool AtumReadSupplier { get; set; }
        public bool AtumDeleteSupplier { get; set; }
        public bool AtumEditSuppliers { get; set; }
        public bool AtumEditOthersSuppliers { get; set; }
        public bool AtumPublishSuppliers { get; set; }
        public bool AtumReadPrivateSuppliers { get; set; }
        public bool AtumCreateSuppliers { get; set; }
        public bool AtumDeleteSuppliers { get; set; }
        public bool AtumDeletePrivateSuppliers { get; set; }
        public bool AtumDeletePublishedSuppliers { get; set; }
        public bool AtumDeleteOtherSuppliers { get; set; }
        public bool AtumEditPrivateSuppliers { get; set; }
        public bool AtumEditPublishedSuppliers { get; set; }
        public bool AtumManageSettings { get; set; }
        public bool AtumEditVisualSettings { get; set; }
        public bool AtumViewAdminMenu { get; set; }
        public bool AtumViewAdminBarMenu { get; set; }
        public bool AtumReadOrderNotes { get; set; }
        public bool AtumCreateOrderNotes { get; set; }
        public bool AtumDeleteOrderNotes { get; set; }
        public bool AtumManageLocationTerms { get; set; }
        public bool AtumEditLocationTerms { get; set; }
        public bool AtumDeleteLocationTerms { get; set; }
        public bool AtumAssignLocationTerms { get; set; }
        public bool AtumExportData { get; set; }
        public bool AtumViewStatistics { get; set; }
        public bool EditOthersMultiplePostTypes { get; set; }
        public bool ReadPrivateMultiplePostTypes { get; set; }
        public bool RestrictContent { get; set; }
        public bool ListRoles { get; set; }
        public bool CreateRoles { get; set; }
        public bool DeleteRoles { get; set; }
        public bool EditRoles { get; set; }
        public bool EditSingleFilter { get; set; }
        public bool ReadSingleFilter { get; set; }
        public bool DeleteSingleFilter { get; set; }
        public bool EditSingleFilters { get; set; }
        public bool EditOthersSingleFilters { get; set; }
        public bool DeleteSingleFilters { get; set; }
        public bool PublishSingleFilters { get; set; }
        public bool ReadPrivateSingleFilters { get; set; }
        public bool DeletePrivateSingleFilters { get; set; }
        public bool DeletePublishedSingleFilters { get; set; }
        public bool DeleteOthersSingleFilters { get; set; }
        public bool EditPrivateSingleFilters { get; set; }
        public bool EditPublishedSingleFilters { get; set; }
        public bool EditGroupFilters { get; set; }
        public bool ReadGroupFilters { get; set; }
        public bool DeleteGroupFilters { get; set; }
        public bool EditGroupFilterss { get; set; }
        public bool EditOthersGroupFilterss { get; set; }
        public bool DeleteGroupFilterss { get; set; }
        public bool PublishGroupFilterss { get; set; }
        public bool ReadPrivateGroupFilterss { get; set; }
        public bool DeletePrivateGroupFilterss { get; set; }
        public bool DeletePublishedGroupFilterss { get; set; }
        public bool DeleteOthersGroupFilterss { get; set; }
        public bool EditPrivateGroupFilterss { get; set; }
        public bool EditPublishedGroupFilterss { get; set; }
        public bool ManageBerocketAapf { get; set; }
        public bool Administrator { get; set; }
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
