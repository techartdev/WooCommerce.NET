using System;
using System.Runtime.Serialization;
using WooCommerce.NET.Base;

namespace WooCommerce.NET.WooCommerce.v3
{
    public class ProductCategoryBatch : BatchObject<ProductCategory> { }

    
    public class ProductCategory : v2.ProductCategory { }

    
    public class ProductCategoryImage : v2.ProductCategoryImage { }
}
