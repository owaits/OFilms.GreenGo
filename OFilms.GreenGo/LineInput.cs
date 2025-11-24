using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    /// <summary>
    /// The line input source options.
    /// </summary>
    public enum LineInputSource
    {
        [Description("Line In")]
        LineIn =0,
        [Description("Signal Generator 2.5KHz")]
        SignalGenerator2_5KHz,
        [Description("Signal Generator 1.5KHz")]
        SignalGenerator1_2KHz,
        [Description("Signal Generator 1KHz")]
        SignalGenerator1KHz,
        [Description("Signal Generator 375Hz")]
        SignalGenerator375Hz
    }

    /// <summary>
    /// The user settings for a line input.
    /// </summary>
    public class LineInput
    {
        /// <summary>
        /// The group or user to send this input to.
        /// </summary>
        public Link Assign { get; set; } = new Link();

        /// <summary>
        /// The source to use for this input whether the line input or a signal generator.
        /// </summary>
        public LineInputSource Source { get; set; }

        /// <summary>
        /// The gain to apply to this input before sending to the group or user.
        /// </summary>
        public Level Gain { get; set; } = new Level(-6,24);

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
    }
}
