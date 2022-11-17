using OFilms.GreenGo.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    public enum TalkMode
    {
        Disabled = 0,
        Momentary = 1,
        Latch = 2,
        LatchMomentary = 3
    }

    public enum ChannelMode
    {
        Normal = 0,
        NoReply = 1,
        ReplyDirect = 2,
        AutoReply = 3,
        AutoTalk = 4,
        SoloTalk = 5,
        GPIO = 6,
        Flex = 7
    }

    public enum CallMode
    {
        Disabled = 0,
        Receive = 1,
        Send = 2,
        SendAndReceive = 3
    }

    public enum CueMode
    {
        Normal = 0,
        Ignore = 1,
        AutoAnswer = 2
    }

    public enum ListenMode
    {
        ListenOnTalk = 0,
        ListenOnTalkIgnore = 1,
        IsolateIgnore = 2,
        Fixed = 3
    }

    public enum Priority
    {
        Low = -1,
        Normal = 0,                
        High = 1
    }

    public enum Pan
    {
        Both = 0,
        Channel1 = 1,
        Channel2 = 2
    }

    public class Channel : GreenGoElement
    {
        public Channel() { }

        public Channel(int id) 
        {
            Id = id;
        }

        public Link Assign { get; set; } = new Link();

        public Link Override { get; set; } = new Link();

        public GreenGoStatus Talk { get; set; } = GreenGoStatus.Disabled;
        public GreenGoStatus Listen { get; set; } = GreenGoStatus.Enabled;

        public TalkMode TalkMode { get; set; } = TalkMode.LatchMomentary;

        public ChannelMode ChannelMode { get; set; } = ChannelMode.Normal;

        public CallMode CallMode { get; set; } = CallMode.SendAndReceive;

        public CueMode CueMode { get; set; } = CueMode.Normal;

        public ListenMode ListenMode { get; set; } = ListenMode.ListenOnTalk;

        public Priority Priority { get; set; } = Priority.Normal;

        public Pan Pan { get; set; }

        public Level Level { get; protected set; } = new Level(-40, 12);
    }
}
