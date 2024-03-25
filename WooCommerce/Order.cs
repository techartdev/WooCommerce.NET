using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WooCommerce.NET.Base;
using WooCommerce.NET.Converters;

namespace WooCommerce.NET.WooCommerce
{
    public class OrderBatch : BatchObject<Order> { }


    public class Order
    {
        public static string Endpoint => "orders";

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Parent order ID.
        /// </summary>

        [JsonProperty("parent_id")]
        [JsonPropertyName("parent_id")]
        public ulong ParentId { get; set; }

        /// <summary>
        /// Order number. 
        /// read-only
        /// </summary>

        [JsonProperty("number")]
        [JsonPropertyName("number")]
        public string Number { get; private set; }

        /// <summary>
        /// Order key. 
        /// read-only
        /// </summary>

        [JsonProperty("order_key")]
        [JsonPropertyName("order_key")]
        public string OrderKey { get; private set; }

        /// <summary>
        /// Shows where the order was created. 
        /// read-only
        /// </summary>

        [JsonProperty("created_via")]
        [JsonPropertyName("created_via")]
        public string CreatedVia { get; private set; }

        /// <summary>
        /// Version of WooCommerce which last updated the order. 
        /// read-only
        /// </summary>

        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public string Version { get; private set; }

        /// <summary>
        /// Order status. Options: pending, processing, on-hold, completed, cancelled, refunded and failed. Default is pending.
        /// </summary>

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public string Status { get; set; } = "pending";

        /// <summary>
        /// Currency the order was created with, in ISO format. Options: AED, AFN, ALL, AMD, ANG, AOA, ARS, AUD, AWG, AZN, BAM, BBD, BDT, BGN, BHD, BIF, BMD, BND, BOB, BRL, BSD, BTC, BTN, BWP, BYR, BZD, CAD, CDF, CHF, CLP, CNY, COP, CRC, CUC, CUP, CVE, CZK, DJF, DKK, DOP, DZD, EGP, ERN, ETB, EUR, FJD, FKP, GBP, GEL, GGP, GHS, GIP, GMD, GNF, GTQ, GYD, HKD, HNL, HRK, HTG, HUF, IDR, ILS, IMP, INR, IQD, IRR, IRT, ISK, JEP, JMD, JOD, JPY, KES, KGS, KHR, KMF, KPW, KRW, KWD, KYD, KZT, LAK, LBP, LKR, LRD, LSL, LYD, MAD, MDL, MGA, MKD, MMK, MNT, MOP, MRO, MUR, MVR, MWK, MXN, MYR, MZN, NAD, NGN, NIO, NOK, NPR, NZD, OMR, PAB, PEN, PGK, PHP, PKR, PLN, PRB, PYG, QAR, RON, RSD, RUB, RWF, SAR, SBD, SCR, SDG, SEK, SGD, SHP, SLL, SOS, SRD, SSP, STD, SYP, SZL, THB, TJS, TMT, TND, TOP, TRY, TTD, TWD, TZS, UAH, UGX, USD, UYU, UZS, VEF, VND, VUV, WST, XAF, XCD, XOF, XPF, YER, ZAR and ZMW. Default is USD.
        /// </summary>

        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency { get; set; } = "USD";

        /// <summary>
        /// The date the order was created, in the site’s timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("date_created")]
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; private set; }

        /// <summary>
        /// The date the order was created, as GMT. 
        /// read-only
        /// </summary>

        [JsonProperty("date_created_gmt")]
        [JsonPropertyName("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; private set; }

        /// <summary>
        /// The date the order was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("date_modified")]
        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; private set; }

        /// <summary>
        /// The date the order was last modified, as GMT. 
        /// read-only
        /// </summary>

        [JsonProperty("date_modified_gmt")]
        [JsonPropertyName("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; private set; }

        /// <summary>
        /// Total discount amount for the order. 
        /// read-only
        /// </summary>

        [JsonProperty("discount_total")]
        [JsonPropertyName("discount_total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? DiscountTotal { get; private set; }

        /// <summary>
        /// Total discount tax amount for the order. 
        /// read-only
        /// </summary>

        [JsonProperty("discount_tax")]
        [JsonPropertyName("discount_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? DiscountTax { get; private set; }

        /// <summary>
        /// Total shipping amount for the order. 
        /// read-only
        /// </summary>

        [JsonProperty("shipping_total")]
        [JsonPropertyName("shipping_total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? ShippingTotal { get; private set; }

        /// <summary>
        /// Total shipping tax amount for the order. 
        /// read-only
        /// </summary>

        [JsonProperty("shipping_tax")]
        [JsonPropertyName("shipping_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? ShippingTax { get; private set; }

        /// <summary>
        /// Sum of line item taxes only. 
        /// read-only
        /// </summary>

        [JsonProperty("cart_tax")]
        [JsonPropertyName("cart_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? CartTax { get; private set; }

        /// <summary>
        /// Grand total. 
        /// read-only
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; private set; }

        /// <summary>
        /// Sum of all taxes. 
        /// read-only
        /// </summary>
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TotalTax { get; private set; }

        /// <summary>
        /// True the prices included tax during checkout. 
        /// read-only
        /// </summary>

        [JsonProperty("prices_include_tax")]
        [JsonPropertyName("prices_include_tax")]
        public bool PricesIncludeTax { get; private set; }

        /// <summary>
        /// User ID who owns the order. 0 for guests. Default is 0.
        /// </summary>

        [JsonProperty("customer_id")]
        [JsonPropertyName("customer_id")]
        public ulong CustomerId { get; set; }

        /// <summary>
        /// Customer’s IP address. 
        /// read-only
        /// </summary>

        [JsonProperty("customer_ip_address")]
        [JsonPropertyName("customer_ip_address")]
        public string CustomerIpAddress { get; private set; }

        /// <summary>
        /// User agent of the customer. 
        /// read-only
        /// </summary>

        [JsonProperty("customer_user_agent")]
        [JsonPropertyName("customer_user_agent")]
        public string CustomerUserAgent { get; private set; }

        /// <summary>
        /// Note left by customer during checkout.
        /// </summary>

        [JsonProperty("customer_note")]
        [JsonPropertyName("customer_note")]
        public string CustomerNote { get; set; }

        /// <summary>
        /// Billing address. See Order - Billing properties
        /// </summary>

        [JsonProperty("billing")]
        [JsonPropertyName("billing")]
        public OrderBilling Billing { get; set; }

        /// <summary>
        /// Shipping address. See Order - Shipping properties
        /// </summary>

        [JsonProperty("shipping")]
        [JsonPropertyName("shipping")]
        public OrderShipping Shipping { get; set; }

        /// <summary>
        /// Payment method ID.
        /// </summary>

        [JsonProperty("payment_method")]
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Payment method title.
        /// </summary>

        [JsonProperty("payment_method_title")]
        [JsonPropertyName("payment_method_title")]
        public string PaymentMethodTitle { get; set; }

        /// <summary>
        /// Unique transaction ID.
        /// </summary>

        [JsonProperty("transaction_id")]
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// The date the order was paid, in the site’s timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("date_paid")]
        [JsonPropertyName("date_paid")]
        public DateTime? DatePaid { get; private set; }

        /// <summary>
        /// The date the order was paid, as GMT. 
        /// read-only
        /// </summary>

        [JsonProperty("date_paid_gmt")]
        [JsonPropertyName("date_paid_gmt")]
        public DateTime? DatePaidGmt { get; private set; }

        /// <summary>
        /// The date the order was completed, in the site’s timezone. 
        /// read-only
        /// </summary>

        [JsonProperty("date_completed")]
        [JsonPropertyName("date_completed")]
        public DateTime? DateCompleted { get; private set; }

        /// <summary>
        /// The date the order was completed, as GMT. 
        /// read-only
        /// </summary>

        [JsonProperty("date_completed_gmt")]
        [JsonPropertyName("date_completed_gmt")]
        public DateTime? DateCompletedGmt { get; private set; }

        /// <summary>
        /// MD5 hash of cart items to ensure orders are not modified. 
        /// read-only
        /// </summary>

        [JsonProperty("cart_hash")]
        [JsonPropertyName("cart_hash")]
        public string CartHash { get; private set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>

        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }

        /// <summary>
        /// Line items data. See Order - Line items properties
        /// </summary>

        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<OrderLineItem> LineItems { get; set; }

        /// <summary>
        /// Tax lines data. See Order - Tax lines properties 
        /// read-only
        /// </summary>

        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public List<OrderTaxLine> TaxLines { get; set; }

        /// <summary>
        /// Shipping lines data. See Order - Shipping lines properties
        /// </summary>

        [JsonProperty("shipping_lines")]
        [JsonPropertyName("shipping_lines")]
        public List<OrderShippingLine> ShippingLines { get; set; }

        /// <summary>
        /// Fee lines data. See Order - Fee lines properties
        /// </summary>

        [JsonProperty("fee_lines")]
        [JsonPropertyName("fee_lines")]
        public List<OrderFeeLine> FeeLines { get; set; }

        /// <summary>
        /// Coupons line data. See Order - Coupon lines properties
        /// </summary>

        [JsonProperty("coupon_lines")]
        [JsonPropertyName("coupon_lines")]
        public List<OrderCouponLine> CouponLines { get; set; }

        /// <summary>
        /// List of refunds. See Order - Refunds properties 
        /// read-only
        /// </summary>

        [JsonProperty("refunds")]
        [JsonPropertyName("refunds")]
        public List<OrderRefundLine> Refunds { get; set; }

        /// <summary>
        /// Define if the order is paid. It will set the status to processing and reduce stock items. Default is false. 
        /// write-only
        /// </summary>

        [JsonProperty("set_paid")]
        [JsonPropertyName("set_paid")]
        public bool SetPaid { private get; set; }
    }


    public class OrderBilling
    {
        /// <summary>
        /// First name.
        /// </summary>

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>

        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>

        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>

        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name.
        /// </summary>

        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district.
        /// </summary>

        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>

        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// Country code in ISO 3166-1 alpha-2 format.
        /// </summary>

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }


    public class OrderShipping
    {
        /// <summary>
        /// First name.
        /// </summary>

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Company name.
        /// </summary>

        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Address line 1
        /// </summary>

        [JsonProperty("address_1")]
        [JsonPropertyName("address_1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2
        /// </summary>

        [JsonProperty("address_2")]
        [JsonPropertyName("address_2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City name.
        /// </summary>

        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO code or name of the state, province or district.
        /// </summary>

        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Postal code.
        /// </summary>

        [JsonProperty("postcode")]
        [JsonPropertyName("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// Country code in ISO 3166-1 alpha-2 format.
        /// </summary>

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

    }

    public class OrderLineItem
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Product name.
        /// </summary>

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>

        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public ulong ProductId { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>

        [JsonProperty("variation_id")]
        [JsonPropertyName("variation_id")]
        public ulong? VariationId { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>

        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Tax class of product.
        /// </summary>

        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts). 
        /// read-only
        /// </summary>
        [JsonProperty("subtotal_tax")]
        [JsonPropertyName("subtotal_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? SubtotalTax { get; private set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts). 
        /// read-only
        /// </summary>
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TotalTax { get; private set; }

        /// <summary>
        /// Line taxes. See Order - Taxes properties 
        /// read-only
        /// </summary>

        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; private set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>

        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>

        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku { get; private set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Price { get; private set; }

    }


    public class OrderTaxLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Tax rate code. 
        /// read-only
        /// </summary>

        [JsonProperty("rate_code")]
        [JsonPropertyName("rate_code")]
        public string RateCode { get; private set; }

        /// <summary>
        /// Tax rate ID. 
        /// read-only
        /// </summary>

        [JsonProperty("rate_id")]
        [JsonPropertyName("rate_id")]
        public string RateId { get; private set; }

        /// <summary>
        /// Tax rate label. 
        /// read-only
        /// </summary>

        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; private set; }

        /// <summary>
        /// Show if is a compound tax rate. 
        /// read-only
        /// </summary>

        [JsonProperty("compound")]
        [JsonPropertyName("compound")]
        public bool? Compound { get; private set; }

        /// <summary>
        /// Tax total (not including shipping taxes). 
        /// read-only
        /// </summary>

        [JsonProperty("tax_total")]
        [JsonPropertyName("tax_total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TaxTotal { get; private set; }

        /// <summary>
        /// Shipping tax total. 
        /// read-only
        /// </summary>

        [JsonProperty("shipping_tax_total")]
        [JsonPropertyName("shipping_tax_total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? ShippingTaxTotal { get; private set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>

        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }
    }


    public class TaxItem
    {
        /// <summary>
        /// tax item id
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong? Id { get; set; }

        /// <summary>
        /// Tax rate code
        /// </summary>
        [JsonProperty("rate_code")]
        [JsonPropertyName("rate_code")]
        public string RateCode { get; private set; }

        /// <summary>
        /// Tax rate ID
        /// </summary>
        [JsonProperty("rate_id")]
        [JsonPropertyName("rate_id")]
        public string RateId { get; set; }

        /// <summary>
        /// Tax rate label
        /// </summary>
        [JsonProperty("label")]
        [JsonPropertyName("label")]
        public string Label { get; private set; }

        /// <summary>
        /// tax item total
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; private set; }

        /// <summary>
        /// tax item subtotal
        /// </summary>
        [JsonProperty("subtotal")]
        [JsonPropertyName("subtotal")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Subtotal { get; private set; }

        /// <summary>
        /// Meta data
        /// </summary>
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }
    }


    public class OrderShippingLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Shipping method name.
        /// </summary>

        [JsonProperty("method_title")]
        [JsonPropertyName("method_title")]
        public string MethodTitle { get; set; }

        /// <summary>
        /// Shipping method ID.
        /// </summary>

        [JsonProperty("method_id")]
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; set; }

        /// <summary>
        /// Line total tax (after discounts). 
        /// read-only
        /// </summary>
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TotalTax { get; private set; }

        /// <summary>
        /// Line taxes. See Order - Taxes properties 
        /// read-only
        /// </summary>

        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>

        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }

    }


    public class OrderFeeLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Fee name.
        /// </summary>

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tax class of fee.
        /// </summary>

        [JsonProperty("tax_class")]
        [JsonPropertyName("tax_class")]
        public string TaxClass { get; set; }

        /// <summary>
        /// Tax status of fee. Options: taxable and none.
        /// </summary>

        [JsonProperty("tax_status")]

        public string TaxStatus { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; set; }


        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? TotalTax { get; private set; }

        /// <summary>
        /// Line taxes. See Order - Taxes properties 
        /// read-only
        /// </summary>
        [JsonProperty("taxes")]
        [JsonPropertyName("taxes")]
        public List<TaxItem> Taxes { get; set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>
        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }
    }


    public class OrderCouponLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Coupon code.
        /// </summary>
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Discount total.
        /// </summary>
        [JsonProperty("discount")]
        [JsonPropertyName("discount")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Discount { get; private set; }

        /// <summary>
        /// Line discount_tax (after discounts).
        /// </summary>
        [JsonProperty("discount_tax")]
        [JsonPropertyName("discount_tax")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? DiscountTax { get; private set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>

        [JsonProperty("meta_data")]
        [JsonPropertyName("meta_data")]
        public List<MetaData> MetaData { get; set; }

    }


    public class OrderRefundLine
    {
        /// <summary>
        /// Refund ID. 
        /// read-only
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// Refund reason. 
        /// read-only
        /// </summary>
        [JsonProperty("reason")]
        [JsonPropertyName("reason")]
        public string Reason { get; private set; }

        /// <summary>
        /// Refund total. 
        /// read-only
        /// </summary>
        [JsonProperty("total")]
        [JsonPropertyName("total")]
        [Newtonsoft.Json.JsonConverter(typeof(TypeToStringConverter))]
        [System.Text.Json.Serialization.JsonConverter(typeof(TypeToStringConverterNet))]
        public decimal? Total { get; private set; }

    }

}
