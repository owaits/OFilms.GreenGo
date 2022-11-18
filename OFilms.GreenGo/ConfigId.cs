using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public struct ConfigId
    {
        public ConfigId(long id1, long id2)
        {
            Id1 = id1;
            Id2 = id2;
        }

        public long Id1 { get; set; }

        public long Id2 { get; set; }

        public static ConfigId Parse(string? value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return new ConfigId(long.Parse(value.Substring(0,8), System.Globalization.NumberStyles.HexNumber), long.Parse(value.Substring(9, 8), System.Globalization.NumberStyles.HexNumber));
        }

        public override string ToString()
        {
            return $"{Id1:X8}-{Id1:X8}";
        }
    }
}
