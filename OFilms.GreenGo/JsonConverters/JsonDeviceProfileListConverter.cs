using OFilms.GreenGo.Project.DeviceProfiles;
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
    internal class JsonDeviceProfileListConverter : JsonConverter<List<DeviceProfile>>
    {
        public override List<DeviceProfile>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var keyList = new List<DeviceProfile>();

            while(reader.Read())
            {
                switch(reader.TokenType)
                {
                    case JsonTokenType.PropertyName:
                        {
                            switch(reader.GetString())
                            {
                                case "RDX":
                                    keyList.Add(JsonSerializer.Deserialize<RDXProfile>(ref reader, options)!);
                                    break;
                                case "2WR":
                                    keyList.Add(JsonSerializer.Deserialize<TwoWireProfile>(ref reader, options)!);
                                    break;
                                case "4WR":
                                    keyList.Add(JsonSerializer.Deserialize<FourWireProfile>(ref reader, options)!);
                                    break;
                                case "LineInOut":
                                    keyList.Add(JsonSerializer.Deserialize<LineInOutProfile>(ref reader, options)!);
                                    break;
                                case "Wireless":
                                    keyList.Add(JsonSerializer.Deserialize<WirelessProfile>(ref reader, options)!);
                                    break;
                                default:
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

        public override void Write(Utf8JsonWriter writer, List<DeviceProfile> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach(var item in value)
            {
                if (item.Name == null)
                    throw new NullReferenceException($"You must set the Name for {item}");

                writer.WritePropertyName(item.Name);
                JsonSerializer.Serialize<DeviceProfile>(writer, item, options);
            }

            writer.WriteEndObject();
        }
    }
}
