using OFilms.GreenGo.Project;
using OFilms.GreenGo.Project.JsonConverters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OFilms.GreenGo.Project
{
    public class Settings
    {
        [JsonConverter(typeof(ConfigIdConverter))]
        [JsonPropertyName("configId")]
        public ConfigId ConfigId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public int SampleRate { get; set; } = 32000;

        public string MulticastAddress { get; set; } = "239.1.42.180";

        public LedColours Colors { get; set; } = new LedColours();

        #region Timestamps

        [JsonIgnore]
        [JsonPropertyName("createdAtTimestamp")]
        public DateTime CreatedAtTimestamp { get; set; }

        [JsonIgnore]
        [JsonPropertyName("cavedAtTimestamp")]
        public DateTime SavedAtTimestamp { get; set; }

        [JsonIgnore]
        [JsonPropertyName("binaryTimestamp")]
        public DateTime BinaryTimestamp { get; set; }

        #endregion

        #region Security

        public Guid ConfigPassword { get; set; }

        public GreenGoStatus ConfigPasswordSet { get; set; } = GreenGoStatus.Disabled;

        public Guid AdminPassword { get; set; }

        public GreenGoStatus AdminPasswordSet { get; set; } = GreenGoStatus.Disabled;

        public string TechPincode { get; set; } = "0";

        #endregion



        [JsonExtensionData]
        public Dictionary<string, JsonElement>? ExtensionData { get; set; }
    }
}