using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using OFilms.GreenGo.Project;
using OFilms.GreenGo.Project.JsonConverters;
using System.Security.Principal;

namespace OFilms.GreenGo.Project
{
    public enum UserMode
    {
        LineInOut = -1,
        Normal = 0,
        Extensions1 = 1,
        Extensions2 = 2,
        Extensions3 = 3,
        Extensions4 = 4,
        Extensions5 = 5,
        Extensions6 = 6,
        Extensions7 = 7,
        Extensions8 = 8,
        Extensions9 = 9
    }

    public enum AlertTone
    {
        Fast = 0,
        Slow = 1,
        Pulse = 3
    }

    public enum ReplyMode
    {
        Disabled = 0,
        Active = 1,
        Last = 2
    }

    public enum PopupMode
    {
        SystemOnly = 0,
        Cue = 1,
        CueAndDirect = 2,
        CueDirectAndHidden = 3
    }

    public enum CueTimeout
    {
        HalfSecond = 0,
        Seconds1 = 1,
        Seconds2 = 2,
        Seconds5 = 3,
        Seconds30 = 4,
        Seconds60 = 5,
        Seconds120 = 6
    }

    public class User : GreenGoElement
    {
        public string Name { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Colour Color { get; set; } = Colour.Off;

        public UserMode Mode { get; set; } = UserMode.Normal;


        [JsonConverter(typeof(JsonKeyedListConverter<Channel>))]
        public List<Channel> Channels { get; set; } = new List<Channel>();

        public SpecialChannels SpecialChannels { get; set; } = new SpecialChannels();

        public UserSettings Settings { get; set; } = new UserSettings();

        public override string ToString()
        {
            return Name;
        }

        public bool IsInGroup(Group group)
        {
            return Channels.Any(ch => ch.Assign.Type == LinkType.Group && ch.Assign.Id == group.Id);
        }

        public void RemoveFromGroup(Group group)
        {
            foreach(var channel in Channels.Where(ch => ch.Assign.Type == LinkType.Group && ch.Assign.Id == group.Id).ToList())
            {
                Channels.Remove(channel);
            }
        }

        public void AddToGroup(Group group)
        {
            int userId = Channels.Any() ? Channels.Max(item => item.Id) + 1 : 1;

            var newChannel = new Channel(userId);
            newChannel.Assign.CreateLink(group);

            Channels.Add(newChannel);
        }

    }

    public class UserSettings
    {
        public int ActiveTime { get; set; } = 3;

        public int ToneLevel { get; set; } = -24;

        public AlertTone AlertTone { get; set; } = AlertTone.Fast;

        public ReplyMode ReplyMode { get; set; } = ReplyMode.Last;

        public int PriorityDim { get; set; } = -6;

        public PopupMode PopupMode { get; set; } = PopupMode.CueDirectAndHidden;

        public int CueTimeout { get; set; } = 3;

        public GreenGoStatus Isolate { get; set; } = GreenGoStatus.Disabled;

        public Link RoomId { get; set; } = new Link();

        public int RoomDim { get; set; }

        public Pan RoomPan { get; set; }
    }
}
