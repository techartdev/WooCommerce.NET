using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WooCommerce.NET.WooCommerce;

namespace WooCommerce.NET.Extensions
{
    public static class MetaDataExtensions
    {
        public static T GetMetaValue<T>(this List<MetaData> metaData, string key, T defaultValue = default)
        {
            var item = metaData?.FirstOrDefault(m => m.Key == key);
            if (item != null && item.Value != null)
            {
                try
                {
                    Type targetType = typeof(T);
                    // If T is nullable, get the underlying type
                    if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        targetType = Nullable.GetUnderlyingType(targetType);
                    }
                    return (T)Convert.ChangeType(item.Value, targetType);
                }
                catch
                {
                    // Handle conversion issues as needed (log, etc.)
                }
            }
            return defaultValue;
        }
    }
}
