using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v3
{
    public class OrderBatch : BatchObject<Order> { }

    
    public class Order : v2.Order { }
    
}
