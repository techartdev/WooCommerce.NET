using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace WooCommerce.NET.Resolvers
{
    public class NullToEmptyStringResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            if (property.PropertyType == typeof(string))
            {
                // Check for null and set the value provider to return an empty string if the original value is null.
                property.ValueProvider = new NullToEmptyStringValueProvider(property.ValueProvider);
            }

            return property;
        }

        class NullToEmptyStringValueProvider : IValueProvider
        {
            private readonly IValueProvider _underlyingValueProvider;

            public NullToEmptyStringValueProvider(IValueProvider underlyingValueProvider)
            {
                _underlyingValueProvider = underlyingValueProvider;
            }

            public object GetValue(object target)
            {
                var result = _underlyingValueProvider.GetValue(target);
                if (result == null) return string.Empty; // Convert null to empty string.
                return result;
            }

            public void SetValue(object target, object value)
            {
                _underlyingValueProvider.SetValue(target, value);
            }
        }
    }
}
