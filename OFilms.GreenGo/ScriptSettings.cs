using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OFilms.GreenGo.Project
{
    public class ScriptSettings
    {
        public ScriptSettings()
        {

        }

        public string Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
