using System;
using System.Reflection;
using Newtonsoft.Json;

namespace SteamCSharp.Utilities.JsonConverters
{
    internal class UnixTimeJsonConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var unixTime = ulong.Parse(reader.Value.ToString());
            return unixTime.ToDateTime();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(long).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
