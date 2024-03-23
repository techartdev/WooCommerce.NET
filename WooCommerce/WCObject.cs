using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce
{
    // ReSharper disable once UnusedTypeParameter
    public class WcObject<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        where T1 : Coupon where T2 : Customer where T3 : Product where T4 : ProductReview where T5 : Variation
        where T6 : Order where T7 : OrderNote where T8 : OrderRefund where T9 : ProductAttribute
        where T10 : ProductAttributeTerm where T11 : ProductCategory where T12 : ShippingClass
        where T13 : ProductTag where T14 : TaxRate where T15 : TaxClass where T16 : Data
    {

        protected RestApi Api { get; set; }

        public WcObject(RestApi api)
        {
            if (api.Version != ApiVersion.Version3 && api.Version != ApiVersion.ThirdPartyPlugins)
                throw new Exception("Please use WooCommerce Restful API Version 3 url for this WCObject. e.g.: http://www.yourstore.co.nz/wp-json/wc/v3/");

            Api = api;

            Coupon = new WcItem<T1>(api);
            Customer = new WcCustomerItem(api);
            Product = new WcProductItem(api);
            ProductReview = new WcItem<T4>(api);
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
            Data = new WcItem<Data>(api);
            Plugin = new WcItem<Plugins>(api);
        }

        public WcItem<T1> Coupon { get; protected set; }

        public WcCustomerItem Customer { get; protected set; }

        public WcProductItem Product { get; protected set; }

        public WcItem<T4> ProductReview { get; protected set; }

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

        public WcItem<Data> Data { get; protected set; }

        public WcItem<Plugins> Plugin { get; protected set; }

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

                //Reviews = new WCSubItem<T4>(api, APIEndpoint);
                Variations = new WcSubItem<T5>(api, ApiEndpoint);
            }

            //public WCSubItem<T4> Reviews { get; set; }

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

    public class WcObject : WcObject<Coupon, Customer, Product, ProductReview, Variation, Order, OrderNote, OrderRefund, ProductAttribute, ProductAttributeTerm,
                                    ProductCategory, ShippingClass, ProductTag, TaxRate, TaxClass, Data>
    {
        public WcObject(RestApi api) : base(api)
        {
        }
    }

    public class Plugins
    {
        public static string Endpoint => "plugins";
    }
}

namespace WooCommerce.NET.WooCommerce.Extension
{
    public static class WcExtension
    {
        public static async Task<T> WithCancellation<T>(this Task<T> task, CancellationToken cancellationToken)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => tcs.TrySetResult(true)))
                if (task != await Task.WhenAny(task, tcs.Task))
                    throw new OperationCanceledException(cancellationToken);
            return await task;
        }

        public static async Task WithCancellation(this Task task, CancellationToken cancellationToken)
        {
            var tcs = new TaskCompletionSource<bool>();
            using (cancellationToken.Register(() => tcs.TrySetResult(true)))
                if (task != await Task.WhenAny(task, tcs.Task))
                    throw new OperationCanceledException(cancellationToken);
            await task;
        }

        public static async Task<List<CustomerDownloads>> GetCustomerDownloads(this WcItem<Customer> item, int id, Dictionary<string, string> parms = null)
        {
            return item.Api.DeserializeJSon<List<CustomerDownloads>>(await item.Api.GetRestful(item.ApiEndpoint + "/" + id + "/downloads", parms).ConfigureAwait(false));
        }

        public static async Task<SystemStatus> Get(this WcItem<SystemStatus> item)
        {
            return item.Api.DeserializeJSon<SystemStatus>(await item.Api.GetRestful(item.ApiEndpoint).ConfigureAwait(false));
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

        public static async Task<List<Continent>> GetContinents(this WcItem<Data> item)
        {
            return item.Api.DeserializeJSon<List<Continent>>(await item.Api.GetRestful(item.ApiEndpoint + "/continents").ConfigureAwait(false));
        }

        public static async Task<List<Country>> GetCountries(this WcItem<Data> item)
        {
            return item.Api.DeserializeJSon<List<Country>>(await item.Api.GetRestful(item.ApiEndpoint + "/countries").ConfigureAwait(false));
        }

        public static async Task<List<Currency>> GetCurrencies(this WcItem<Data> item)
        {
            return item.Api.DeserializeJSon<List<Currency>>(await item.Api.GetRestful(item.ApiEndpoint + "/currencies").ConfigureAwait(false));
        }

        public static async Task<Currency> GetCurrency(this WcItem<Data> item, string currency = "current")
        {
            return item.Api.DeserializeJSon<Currency>(await item.Api.GetRestful(item.ApiEndpoint + "/currencies/" + currency).ConfigureAwait(false));
        }

        public static async Task<TaxClass> DeleteTaxClass(this WcItem<TaxClass> item, string slug, bool force = false, Dictionary<string, string> parms = null)
        {
            if (force)
            {
                if (parms == null)
                    parms = new Dictionary<string, string>();

                if (!parms.ContainsKey("force"))
                    parms.Add("force", "true");
            }

            return item.Api.DeserializeJSon<TaxClass>(await item.Api.DeleteRestful(item.ApiEndpoint + "/" + slug, parms).ConfigureAwait(false));
        }
    }

}