using OFilms.GreenGo.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public class Room : GreenGoElement
    {
        public string Name { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public override string ToString()
        {
            return Name;
        }
    }
}
