using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public enum LinkType
    {
        Disabled = 0,
        User = 1,
        Group = 2
    }

    public class Link
    {
        public LinkType Type { get; set; }

        public int Id { get; set; }

        public void CreateLink<TLink>(TLink target)
        {
            switch(target)
            {
                case Group group:
                    Type = LinkType.Group;
                    Id = group.Id;
                    break;
                case User user:
                    Type = LinkType.User;
                    Id = user.Id;
                    break;

                default:
                    throw new NotSupportedException();
            }
        }

    }
}
