using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WooCommerce.NET.Converters
{
    public class TypeToStringConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(decimal) || objectType == typeof(int) || objectType == typeof(long) || objectType == typeof(bool)
                || objectType == typeof(decimal?) || objectType == typeof(int?) || objectType == typeof(long?) || objectType == typeof(bool?)
                || objectType == typeof(DateTime?);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = reader.Value?.ToString();

            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            if (objectType == typeof(decimal))
            {
                return decimal.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(int))
            {
                return int.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(long))
            {
                return long.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(bool))
            {
                return bool.Parse(value);
            }
            else if (objectType == typeof(decimal?))
            {
                return decimal.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(int?))
            {
                return int.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(long?))
            {
                return long.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (objectType == typeof(bool?))
            {
                return bool.Parse(value);
            }
            else if (objectType == typeof(DateTime?) || objectType == typeof(DateTime))
            {
                return DateTime.Parse(value, CultureInfo.InvariantCulture);
            }

            throw new JsonSerializationException("Unexpected object type.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is decimal || value is int || value is long || value is bool || value is DateTime)
            {
                writer.WriteValue(value.ToString());
            }
            else
            {
                throw new JsonSerializationException("Unexpected value type.");
            }
        }
    }
}
