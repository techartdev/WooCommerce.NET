using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v3
{
    public class CouponBatch : BatchObject<Coupon> { }

    public class Coupon : v2.Coupon { }
}
