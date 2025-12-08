using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFilms.GreenGo.Project.DeviceProfiles
{
    /// <summary>
    /// The base class for all device specific profiles. The device profile allows specific settings for a device type to be defined.
    /// </summary>
    public abstract class DeviceProfile
    {
        protected DeviceProfile(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the profile.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the script used by this device.
        /// </summary>
        public ScriptSettings ScriptSettings { get; set; }
    }
}
