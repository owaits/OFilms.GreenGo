using OFilms.GreenGo.Project.JsonConverters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public class LedColours
    {
        [JsonPropertyName("0")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led Free { get; protected set; } = new Led(Colour.Blue, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("1")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led NoMember { get; protected set; } = new Led(Colour.Blue, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("2")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led IdleMuted { get; protected set; } = new Led(Colour.Blue, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("3")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led Idle { get; protected set; } = new Led(Colour.Blue, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("4")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led Active { get; protected set; } = new Led(Colour.Blue, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("5")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led ActiveVox { get; protected set; } = new Led(Colour.Purple, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("6")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led ActiveMuted { get; protected set; } = new Led(Colour.Yellow, Colour.Blue, LedRate.HalfSecondPulse);

        [JsonPropertyName("7")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led AutoTalk { get; protected set; } = new Led(Colour.Green, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("8")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led Talk { get; protected set; } = new Led(Colour.Green, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("9")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led CueAttention { get; protected set; } = new Led(Colour.Yellow, Colour.Off, LedRate.HalfSecond);

        [JsonPropertyName("10")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led CueReady { get; protected set; } = new Led(Colour.Orange, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("11")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led CueGo { get; protected set; } = new Led(Colour.Green, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("13")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led Call { get; protected set; } = new Led(Colour.Red, Colour.Off, LedRate.NoBlink);

        [JsonPropertyName("14")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led AlertCall { get; protected set; } = new Led(Colour.Red, Colour.White, LedRate.HalfSecond);

        [JsonPropertyName("15")]
        [JsonConverter(typeof(JsonSkipConverter<Led>))]
        public Led GPIOControl { get; protected set; } = new Led(Colour.Purple, Colour.Off, LedRate.NoBlink);
    }
}
