using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    /// <summary>
    /// How the PTT of the radio is controlled.
    /// </summary>
    public enum TXMode
    {
        /// <summary>
        /// TX is disabled and no traffic will be sent to the radio.
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// The PTT of the Radio is activated when there is voice on the GreenGo network.
        /// </summary>
        VOX = 1,
        /// <summary>
        /// The PTT of the Radio is activated when someone pushes the talk button in the Group.
        /// </summary>
        Talk = 2
    }

    /// <summary>
    /// Settings to control how the RDX interface interacts with the Radio.
    /// </summary>
    public class RadioPort
    {          
        /// <summary>
        /// Gets or sets how quickly the gate responds to activity.
        /// </summary>
        public CompressorAttack Compressor { get; set; }

        /// <summary>
        /// Gets or sets the gate threshold in dB.
        /// </summary>
        public int GateThreshold { get; set; }

        /// <summary>
        /// Gets or sets the how long it takes before the input is gated.
        /// </summary>
        public GateHold GateHold { get; set; }

        /// <summary>
        /// Gets or sets the output level to the radio.
        /// </summary>
        public Level OutputAdjust { get; set; } = new Level(-100, 12);

        /// <summary>
        /// Gets or sets the output limiter level in dB.
        /// </summary>
        public int OutputLimiter { get; set; }

        /// <summary>
        /// Gets or sets how the TX on the Radio is controlled from the GreenGo network.
        /// </summary>
        /// <remarks>
        /// If you want to activate the radio PTT when there is voice on the network rather than activity set to VOX.
        /// </remarks>
        public TXMode TxMode { get; set; }
    }
}
