using System;
using System.Runtime.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v3
{
    public class ProductCategoryBatch : BatchObject<ProductCategory> { }

    [DataContract]
    public class ProductCategory : v2.ProductCategory { }

    [DataContract]
    public class ProductCategoryImage : v2.ProductCategoryImage { }
}
