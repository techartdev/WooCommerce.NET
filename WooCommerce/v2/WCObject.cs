using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v2
{
    public class WcObject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        where T1 : Coupon where T2 : Customer where T3 : Product where T4 : ProductReview where T5 : Variation
        where T6 : Order where T7 : OrderNote where T8 : OrderRefund where T9 : ProductAttribute
        where T10 : ProductAttributeTerm where T11 : ProductCategory where T12 : ShippingClass 
        where T13 : ProductTag where T14 : TaxRate where T15 : TaxClass
    {
       
        protected RestApi Api { get; set; }

        // ReSharper disable once StaticMemberInGenericType
        public static Func<string, object, object> MetaValueProcessor { get; set; }

        // ReSharper disable once StaticMemberInGenericType
        public static Func<string, object, object> MetaDisplayValueProcessor { get; set; }

        public WcObject(RestApi api)
        {
            if (api.Version != ApiVersion.Version2)
                throw new Exception("Please use WooCommerce Restful API Version 2 url for this WCObject. e.g.: http://www.yourstore.co.nz/wp-json/wc/v2/");

            Api = api;

            Coupon = new WcItem<T1>(api);
            Customer = new WcCustomerItem(api);
            Product = new WcProductItem(api);
            Order = new WcOrderItem(api);
            Attribute = new WcAttributeItem(api);
            Category = new WcItem<T11>(api);
            ShippingClass = new WcItem<T12>(api);
            Tag = new WcItem<T13>(api);
            Report = new WcItem<Report>(api);
            TaxRate = new WcItem<T14>(api);
            TaxClass = new WcItem<T15>(api);
            Webhook = new WcItem<Webhook>(api);
            PaymentGateway = new WcItem<PaymentGateway>(api);
            ShippingZone = new WcShippingZoneItem(api);
            ShippingMethod = new WcItem<ShippingMethod>(api);
            SystemStatus = new WcItem<SystemStatus>(api);
            SystemStatusTool = new WcItem<SystemStatusTool>(api);
            Setting = new WcItem<Setting>(api);
        }

        public WcItem<T1> Coupon { get; protected set; }

        public WcCustomerItem Customer { get; protected set; }

        public WcProductItem Product { get; protected set; }

        public WcOrderItem Order { get; protected set; }

        public WcAttributeItem Attribute { get; protected set; }

        public WcItem<T11> Category { get; protected set; }

        public WcItem<T12> ShippingClass { get; protected set; }

        public WcItem<T13> Tag { get; protected set; }

        public WcItem<Report> Report { get; protected set; }

        public WcItem<T14> TaxRate { get; protected set; }

        public WcItem<T15> TaxClass { get; protected set; }

        public WcItem<Webhook> Webhook { get; protected set; }

        public WcItem<PaymentGateway> PaymentGateway { get; protected set; }

        public WcShippingZoneItem ShippingZone { get; protected set; }

        public WcItem<ShippingMethod> ShippingMethod { get; protected set; }

        public WcItem<SystemStatus> SystemStatus { get; protected set; }

        public WcItem<SystemStatusTool> SystemStatusTool { get; protected set; }

        public WcItem<Setting> Setting { get; protected set; }

        
        public class MetaData
        {
            /// <summary>
            /// Meta ID. 
            /// read-only
            /// </summary>
            
            [JsonProperty("id")]
            public ulong? Id { get; set; }

            /// <summary>
            /// Meta key.
            /// </summary>
            
            [JsonProperty("key")]
            public string Key { get; set; }

            /// <summary>
            /// Meta value.
            /// </summary>            
            private object _preValue;

            
            [JsonProperty("value")]
            public object Value
            {
                get => _preValue;
                set => _preValue = MetaValueProcessor != null ? MetaValueProcessor.Invoke(GetType().Name, value) : value;
            }

            /// <summary>
            /// Display key.
            /// </summary>
            
            [JsonProperty("display_key")]
            public string DisplayKey { get; set; }

            /// <summary>
            /// Display value.
            /// </summary>
            private object _preDisplayValue;
            
            [JsonProperty("display_value")]
            public object DisplayValue 
            {
                get => _preDisplayValue;
                set
                {
                    if (MetaDisplayValueProcessor != null)
                        _preDisplayValue = MetaDisplayValueProcessor.Invoke(GetType().Name, value);
                    else
                        _preDisplayValue = value;
                }
            }
        }


        
        public class SimpleMetaData
        {
            /// <summary>
            /// Meta ID. 
            /// read-only
            /// </summary>
            
            [JsonProperty("id")]
            public ulong? Id { get; set; }

            /// <summary>
            /// Meta key.
            /// </summary>
            
            [JsonProperty("key")]
            public string Key { get; set; }

            /// <summary>
            /// Meta value.
            /// </summary>
            private object _preValue;
            
            [JsonProperty("value")]
            public object Value
            {
                get
                {
                    return _preValue;
                }
                set
                {
                    if (MetaValueProcessor != null)
                        _preValue = MetaValueProcessor.Invoke(GetType().Name, value);
                    else
                        _preValue = value;
                }
            }
        }

        public class WcCustomerItem : WcItem<T2>
        {
            public WcCustomerItem(RestApi api) : base(api)
            {
                Api = api;
            }

            public override async Task<T2> Get(string email, Dictionary<string, string> pars = null)
            {
                if (pars == null)
                    pars = new Dictionary<string, string>();

                pars.Add("email", email);

                var customers = await GetAll(pars);

                if (customers == null || customers.Count == 0)
                    return null;
                else
                    return customers[0];
            }
        }

        public class WcProductItem : WcItem<T3>
        {
            public WcProductItem(RestApi api) : base(api)
            {
                Api = api;

                Reviews = new WcSubItem<T4>(api, ApiEndpoint);
                Variations = new WcSubItem<T5>(api, ApiEndpoint);
            }

            public WcSubItem<T4> Reviews { get; set; }

            public WcSubItem<T5> Variations { get; set; }
        }

        public class WcOrderItem : WcItem<T6>
        {
            public WcOrderItem(RestApi api) : base(api)
            {
                Api = api;

                Notes = new WcSubItem<T7>(api, ApiEndpoint);
                Refunds = new WcSubItem<T8>(api, ApiEndpoint);
            }

            public WcSubItem<T7> Notes { get; set; }

            public WcSubItem<T8> Refunds { get; set; }
        }

        public class WcAttributeItem : WcItem<T9>
        {
            public WcAttributeItem(RestApi api) : base(api)
            {
                Api = api;

                Terms = new WcSubItem<T10>(api, ApiEndpoint);
            }

            public WcSubItem<T10> Terms { get; set; }
        }

        public class WcShippingZoneItem : WcItem<ShippingZone>
        {
            public WcShippingZoneItem(RestApi api) : base(api)
            {
                Api = api;

                Locations = new WcSubItem<ShippingZoneLocation>(api, ApiEndpoint);
                Methods = new WcSubItem<ShippingZoneMethod>(api, ApiEndpoint);
            }

            public WcSubItem<ShippingZoneLocation> Locations { get; protected set; }
            public WcSubItem<ShippingZoneMethod> Methods { get; protected set; }
        }
    }

    public class WcObject: WcObject<Coupon, Customer, Product, ProductReview, Variation, Order, OrderNote, OrderRefund, ProductAttribute, ProductAttributeTerm, 
                                    ProductCategory, ShippingClass, ProductTag, TaxRate, TaxClass>
    {
        public WcObject(RestApi api) : base(api)
        {
        }
    }
}

namespace WooCommerce.NET.WooCommerce.v2.Extension
{
    public static class WcExtension
    {
        public static async Task<List<CustomerDownloads>> GetCustomerDownloads(this WcItem<Customer> item, int id, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<List<CustomerDownloads>>(await item.Api.GetRestful(item.ApiEndpoint + "/" + id.ToString() + "/downloads", parms).ConfigureAwait(false));
        }

        public static async Task<SystemStatusTool> Run(this WcItem<SystemStatusTool> item, string id, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<SystemStatusTool>(await item.Api.PutRestful(item.ApiEndpoint + "/" + id, parms).ConfigureAwait(false));
        }

        public static async Task<List<SalesReport>> GetSalesReport(this WcItem<Report> item, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<List<SalesReport>>(await item.Api.GetRestful(item.ApiEndpoint + "/sales", parms).ConfigureAwait(false));
        }

        public static async Task<List<TopSellersReport>> GetTopSellerReport(this WcItem<Report> item, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<List<TopSellersReport>>(await item.Api.GetRestful(item.ApiEndpoint + "/top_sellers", parms).ConfigureAwait(false));
        }

        public static async Task<List<SettingOption>> GetSettingOptions(this WcItem<Setting> item, string settingId, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<List<SettingOption>>(await item.Api.GetRestful(item.ApiEndpoint + "/" + settingId, parms).ConfigureAwait(false));
        }

        public static async Task<SettingOption> GetSettingOption(this WcItem<Setting> item, string settingId, string optionId, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<SettingOption>(await item.Api.GetRestful(item.ApiEndpoint + "/" + settingId + "/" + optionId, parms).ConfigureAwait(false));
        }

        public static async Task<SettingOption> UpdateSettingOption(this WcItem<Setting> item, string settingId, string optionId, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<SettingOption>(await item.Api.PostRestful(item.ApiEndpoint + "/" + settingId + "/" + optionId, parms).ConfigureAwait(false));
        }

        public static async Task<List<SettingOption>> UpdateSettingOptions(this WcItem<Setting> item, string settingId, SettingOptionBatch batch, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<List<SettingOption>>(await item.Api.PostRestful(item.ApiEndpoint + "/" + settingId + "/batch", parms).ConfigureAwait(false));
        }
    }
}