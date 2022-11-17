using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project.JsonConverters
{
    internal class JsonSkipConverter<TValue> : JsonConverter<TValue>
    {
        public override TValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Skip();
            return JsonSerializer.Deserialize<TValue>(ref reader, options)!;
        }

        public override void Write(Utf8JsonWriter writer, TValue value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName(typeof(TValue).Name);
            JsonSerializer.Serialize<TValue>(writer, value, options);
            writer.WriteEndObject();
        }
    }
}
