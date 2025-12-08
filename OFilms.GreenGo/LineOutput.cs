using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project
{
    /// <summary>
    /// The user settings for a line output.
    /// </summary>
    public class LineOutput
    {
        /// <summary>
        /// The group or user from which this line output takes its audio.
        /// </summary>
        public Link Assign { get; set; } = new Link();

        /// <summary>
        /// Gets or sets the audio  level of the output.
        /// </summary>
        public Level Level { get; set; } = new Level(-40, 12);

        /// <summary>
        /// Gets or sets a limitter to apply to the output.
        /// </summary>
        public int Limiter { get; set; }

        /// <summary>
        /// Gets or sets the level of audio that is fed to this output from the input.
        /// </summary>
        public Level Loopback { get; set; } = new Level(-40, 0);

    }
}
