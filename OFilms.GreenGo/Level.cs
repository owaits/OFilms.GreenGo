using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public class Level
    {
        public Level(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int Value { get; set; }

        public int Min { get; protected set; }

        public int Max { get; protected set; }
    }
}
