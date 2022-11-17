using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public enum GreenGoStatus
    {
        Disabled = 0,
        Enabled = 1
    }

    public enum GreenGoBadge
    {
        None = 0
    }

    public abstract class GreenGoElement
    {
        [JsonIgnore]
        public int Id
        {
            get
            {
                if (int.TryParse(MyId, out int id))
                    return id;
                return 0;
            }
            set { MyId = value.ToString(); }
        }


        [JsonPropertyName("myId")]
        public string? MyId { get; set; } = null;

        [JsonPropertyName("badge")]
        public GreenGoBadge Badge { get; set; }

        [JsonPropertyName("status")]
        public GreenGoStatus Status { get; set; }


        [JsonExtensionData]
        public Dictionary<string, JsonElement>? ExtensionData { get; set; }
    }
}
