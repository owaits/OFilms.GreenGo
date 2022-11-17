using OFilms.GreenGo.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{

    public class SpecialChannel : GreenGoElement
    {
        public Link Assign { get; set; } = new Link();

        public Level Level { get; protected set; } = new Level(-40, 12);

        public Pan Pan { get; set; }

        public int Dim { get; set; }
    }


    public class SpecialChannels
    {
        public SpecialChannel Program { get; set; } = new SpecialChannel();

        public SpecialChannel Announce { get; set; } = new SpecialChannel();

        public SpecialChannel Emergency { get; set; } = new SpecialChannel();

        public SpecialChannel Direct { get; set; } = new SpecialChannel();
    }
}
