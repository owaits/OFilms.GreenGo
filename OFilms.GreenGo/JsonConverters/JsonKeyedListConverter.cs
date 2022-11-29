using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project.JsonConverters
{
    internal class JsonKeyedListConverter<TValue> : JsonConverter<List<TValue>> where TValue : GreenGoElement
    {
        public override List<TValue>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var keyList = new List<TValue>();

            while(reader.Read())
            {
                switch(reader.TokenType)
                {
                    case JsonTokenType.PropertyName:
                        {
                            switch(reader.GetString())
                            {
                                case "keys":
                                case "badge":
                                    reader.TrySkip();
                                    break;
                                default:
                                    keyList.Add(JsonSerializer.Deserialize<TValue>(ref reader, options)!);
                                    break;
                            }
                        }
                        break;
                    case JsonTokenType.EndArray:
                    case JsonTokenType.EndObject:
                        return keyList;
                }
            }

            return keyList;
        }

        public override void Write(Utf8JsonWriter writer, List<TValue> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            //Write the Keys
            writer.WritePropertyName("keys");
            writer.WriteStartArray();
            foreach(var item in value)
            {
                writer.WriteStringValue(item.MyId);
            }
            writer.WriteEndArray();

            //Write the badge
            writer.WritePropertyName("badge");
            writer.WriteNumberValue(0);

            foreach(var item in value)
            {
                if (item.MyId == null)
                    throw new NullReferenceException($"You must set the MyID for {item}");

                writer.WritePropertyName(item.MyId);
                JsonSerializer.Serialize<TValue>(writer, item, options);
            }

            writer.WriteEndObject();
        }
    }
}
