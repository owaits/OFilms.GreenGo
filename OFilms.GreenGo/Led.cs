using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public enum LedRate
    {
        NoBlink = 0,
        TwoSeconds = 1,
        OneSecond = 2,
        HalfSecond = 3,
        QuarterSecond = 4,
        HalfSecondPulse = 5,
        QuarterSecondPulse = 6
    }

    public class Led
    {
        public Led()
        {
            
        }

        public Led(Colour colour1, Colour colour2, LedRate rate)
        {
            Colour1 = colour1;
            Colour2 = colour2;
            Rate = rate;
        }

        [JsonPropertyName("C1")]
        public Colour Colour1 { get; set; }

        [JsonPropertyName("C2")]
        public Colour Colour2 { get; set; }

        public LedRate Rate { get; set; }
    }
}
