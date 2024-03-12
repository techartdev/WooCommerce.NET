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

            Coupon = new WCItem<T1>(api);
            Customer = new WcCustomerItem(api);
            Product = new WcProductItem(api);
            Order = new WcOrderItem(api);
            Attribute = new WcAttributeItem(api);
            Category = new WCItem<T11>(api);
            ShippingClass = new WCItem<T12>(api);
            Tag = new WCItem<T13>(api);
            Report = new WCItem<Report>(api);
            TaxRate = new WCItem<T14>(api);
            TaxClass = new WCItem<T15>(api);
            Webhook = new WCItem<Webhook>(api);
            PaymentGateway = new WCItem<PaymentGateway>(api);
            ShippingZone = new WcShippingZoneItem(api);
            ShippingMethod = new WCItem<ShippingMethod>(api);
            SystemStatus = new WCItem<SystemStatus>(api);
            SystemStatusTool = new WCItem<SystemStatusTool>(api);
            Setting = new WCItem<Setting>(api);
        }

        public WCItem<T1> Coupon { get; protected set; }

        public WcCustomerItem Customer { get; protected set; }

        public WcProductItem Product { get; protected set; }

        public WcOrderItem Order { get; protected set; }

        public WcAttributeItem Attribute { get; protected set; }

        public WCItem<T11> Category { get; protected set; }

        public WCItem<T12> ShippingClass { get; protected set; }

        public WCItem<T13> Tag { get; protected set; }

        public WCItem<Report> Report { get; protected set; }

        public WCItem<T14> TaxRate { get; protected set; }

        public WCItem<T15> TaxClass { get; protected set; }

        public WCItem<Webhook> Webhook { get; protected set; }

        public WCItem<PaymentGateway> PaymentGateway { get; protected set; }

        public WcShippingZoneItem ShippingZone { get; protected set; }

        public WCItem<ShippingMethod> ShippingMethod { get; protected set; }

        public WCItem<SystemStatus> SystemStatus { get; protected set; }

        public WCItem<SystemStatusTool> SystemStatusTool { get; protected set; }

        public WCItem<Setting> Setting { get; protected set; }

        [DataContract]
        public class MetaData
        {
            /// <summary>
            /// Meta ID. 
            /// read-only
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            [JsonProperty("id")]
            public ulong? Id { get; set; }

            /// <summary>
            /// Meta key.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            [JsonProperty("key")]
            public string Key { get; set; }

            /// <summary>
            /// Meta value.
            /// </summary>            
            private object _preValue;

            [DataMember(EmitDefaultValue = false)]
            [JsonProperty("value")]
            public object Value
            {
                get => _preValue;
                set => _preValue = MetaValueProcessor != null ? MetaValueProcessor.Invoke(GetType().Name, value) : value;
            }

            /// <summary>
            /// Display key.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            [JsonProperty("display_key")]
            public string DisplayKey { get; set; }

            /// <summary>
            /// Display value.
            /// </summary>
            private object _preDisplayValue;
            [DataMember(EmitDefaultValue = false)]
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


        [DataContract]
        public class SimpleMetaData
        {
            /// <summary>
            /// Meta ID. 
            /// read-only
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            [JsonProperty("id")]
            public ulong? Id { get; set; }

            /// <summary>
            /// Meta key.
            /// </summary>
            [DataMember(EmitDefaultValue = false)]
            [JsonProperty("key")]
            public string Key { get; set; }

            /// <summary>
            /// Meta value.
            /// </summary>
            private object _preValue;
            [DataMember(EmitDefaultValue = false)]
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

        public class WcCustomerItem : WCItem<T2>
        {
            public WcCustomerItem(RestApi api) : base(api)
            {
                API = api;
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

        public class WcProductItem : WCItem<T3>
        {
            public WcProductItem(RestApi api) : base(api)
            {
                API = api;

                Reviews = new WCSubItem<T4>(api, APIEndpoint);
                Variations = new WCSubItem<T5>(api, APIEndpoint);
            }

            public WCSubItem<T4> Reviews { get; set; }

            public WCSubItem<T5> Variations { get; set; }
        }

        public class WcOrderItem : WCItem<T6>
        {
            public WcOrderItem(RestApi api) : base(api)
            {
                API = api;

                Notes = new WCSubItem<T7>(api, APIEndpoint);
                Refunds = new WCSubItem<T8>(api, APIEndpoint);
            }

            public WCSubItem<T7> Notes { get; set; }

            public WCSubItem<T8> Refunds { get; set; }
        }

        public class WcAttributeItem : WCItem<T9>
        {
            public WcAttributeItem(RestApi api) : base(api)
            {
                API = api;

                Terms = new WCSubItem<T10>(api, APIEndpoint);
            }

            public WCSubItem<T10> Terms { get; set; }
        }

        public class WcShippingZoneItem : WCItem<ShippingZone>
        {
            public WcShippingZoneItem(RestApi api) : base(api)
            {
                API = api;

                Locations = new WCSubItem<ShippingZoneLocation>(api, APIEndpoint);
                Methods = new WCSubItem<ShippingZoneMethod>(api, APIEndpoint);
            }

            public WCSubItem<ShippingZoneLocation> Locations { get; protected set; }
            public WCSubItem<ShippingZoneMethod> Methods { get; protected set; }
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
        public static async Task<List<CustomerDownloads>> GetCustomerDownloads(this WCItem<Customer> item, int id, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<List<CustomerDownloads>>(await item.API.GetRestful(item.APIEndpoint + "/" + id.ToString() + "/downloads", parms).ConfigureAwait(false));
        }

        public static async Task<SystemStatusTool> Run(this WCItem<SystemStatusTool> item, string id, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<SystemStatusTool>(await item.API.PutRestful(item.APIEndpoint + "/" + id, parms).ConfigureAwait(false));
        }

        public static async Task<List<SalesReport>> GetSalesReport(this WCItem<Report> item, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<List<SalesReport>>(await item.API.GetRestful(item.APIEndpoint + "/sales", parms).ConfigureAwait(false));
        }

        public static async Task<List<TopSellersReport>> GetTopSellerReport(this WCItem<Report> item, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<List<TopSellersReport>>(await item.API.GetRestful(item.APIEndpoint + "/top_sellers", parms).ConfigureAwait(false));
        }

        public static async Task<List<SettingOption>> GetSettingOptions(this WCItem<Setting> item, string settingId, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<List<SettingOption>>(await item.API.GetRestful(item.APIEndpoint + "/" + settingId, parms).ConfigureAwait(false));
        }

        public static async Task<SettingOption> GetSettingOption(this WCItem<Setting> item, string settingId, string optionId, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<SettingOption>(await item.API.GetRestful(item.APIEndpoint + "/" + settingId + "/" + optionId, parms).ConfigureAwait(false));
        }

        public static async Task<SettingOption> UpdateSettingOption(this WCItem<Setting> item, string settingId, string optionId, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<SettingOption>(await item.API.PostRestful(item.APIEndpoint + "/" + settingId + "/" + optionId, parms).ConfigureAwait(false));
        }

        public static async Task<List<SettingOption>> UpdateSettingOptions(this WCItem<Setting> item, string settingId, SettingOptionBatch batch, Dictionary<string, string> parms = null)
        {
            return item.API.DeserializeJSon<List<SettingOption>>(await item.API.PostRestful(item.APIEndpoint + "/" + settingId + "/batch", parms).ConfigureAwait(false));
        }
    }
}