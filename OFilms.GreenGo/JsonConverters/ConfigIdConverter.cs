using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project.JsonConverters
{
    internal class ConfigIdConverter : JsonConverter<ConfigId>
    {
        public override ConfigId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {            
            return ConfigId.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, ConfigId value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
