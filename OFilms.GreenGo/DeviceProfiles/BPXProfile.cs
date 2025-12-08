using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project.DeviceProfiles
{
    /// <summary>
    /// The device profile for a wired beltpack.
    /// </summary>
    /// <seealso cref="OFilms.GreenGo.Project.DeviceProfiles.DeviceProfile" />
    public class BPXProfile:DeviceProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BPXProfile"/> class.
        /// </summary>
        public BPXProfile() : base("BPX")
        {
        }

        /// <summary>
        /// Gets or sets the device settings for the wired beltpack.
        /// </summary>
        public BPXSettings DeviceSettings { get; set; }

        /// <summary>
        /// The BPX device settings as part of the device profile.
        /// </summary>
        public class BPXSettings
        {
            /// <summary>
            /// Gets or sets the UI mode.
            /// </summary>
            public string? UiMode { get; set; }

            /// <summary>
            /// Gets or sets the encoder left functionality.
            /// </summary>
            public string? EncoderLeft { get; set; }

            /// <summary>
            /// Gets or sets the encoder right functionality.
            /// </summary>
            public string? EncoderRight { get; set; }

            /// <summary>
            /// Gets or sets if the beltpack is in extended mode.
            /// </summary>
            public string? Extended { get; set; }

            /// <summary>
            /// Gets or sets whether the beltpack screen is flipped.
            /// </summary>
            public string? Flip { get; set; }

            /// <summary>
            /// Gets or sets whether the buzzer is enabled.
            /// </summary>
            public string? Buzzer { get; set; }

            /// <summary>
            /// Gets or sets whether the vibrate funtionality is turned on.
            /// </summary>
            public string? Vibrate { get; set; }

            /// <summary>
            /// Gets or sets the screen intensity.
            /// </summary>
            public string? ScreenIntensity { get; set; }

            /// <summary>
            /// Gets or sets the time before the screen goes to sleep.
            /// </summary>
            public string? ScreenTime { get; set; }

            /// <summary>
            /// Gets or sets the led intensity for the LEDs on the beltpack.
            /// </summary>
            public string? LedIntensity { get; set; }

            /// <summary>
            /// Gets or sets the led time.
            /// </summary>
            public string? LedTime { get; set; }
        }

    }
}
