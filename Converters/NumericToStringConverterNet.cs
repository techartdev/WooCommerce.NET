using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WooCommerce.NET.Converters
{
    public class NumericToStringConverterNet : JsonConverter<object>
    {
        public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();

            if (value == null)
            {
                return null;
            }

            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            if (typeToConvert == typeof(decimal))
            {
                return decimal.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (typeToConvert == typeof(int))
            {
                return int.Parse(value);
            }
            else if (typeToConvert == typeof(long))
            {
                return long.Parse(value);
            }
            else if (typeToConvert == typeof(bool))
            {
                return bool.Parse(value);
            }
            else if (typeToConvert == typeof(decimal?))
            {
                return decimal.Parse(value, CultureInfo.InvariantCulture);
            }
            else if (typeToConvert == typeof(int?))
            {
                return int.Parse(value);
            }
            else if (typeToConvert == typeof(long?))
            {
                return long.Parse(value);
            }
            else if (typeToConvert == typeof(bool?))
            {
                return bool.Parse(value);
            }
            else if (typeToConvert == typeof(DateTime?))
            {
                return DateTime.Parse(value, CultureInfo.InvariantCulture);
            }
            else
            {
                throw new JsonException($"Unexpected type {typeToConvert}.");
            }
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(decimal) || typeToConvert == typeof(int) || typeToConvert == typeof(long) || typeToConvert == typeof(bool)
                || typeToConvert == typeof(decimal?) || typeToConvert == typeof(int?) || typeToConvert == typeof(long?) || typeToConvert == typeof(bool?)
                || typeToConvert == typeof(DateTime?);
        }
    }
}
