using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cisco_Config_Wiz
{
    interface IConfWiz
    {
        #region General
        #region More General
        /// <summary>
        /// Hostname of the device
        /// </summary>
        string Hostname { get; set; }
        /// <summary>
        /// Banner at login
        /// </summary>
        string LoginBanner { get; set; }
        /// <summary>
        /// Message of the Day banner
        /// </summary>
        string MOTDBanner { get; set; }
        /// <summary>
        /// Deactivate Domain-Lookup. You should activate this
        /// </summary>
        bool NoIPDomainLookup { get; set; }
        #endregion
        #region Enable Security
        /// <summary>
        /// Enable the login to go in Enabled Mode
        /// </summary>
        bool EnableLogin { get; set; }
        /// <summary>
        /// Encrypt the password for the "enable" command
        /// </summary>
        bool EncryptEnablePassword { get; set; }
        /// <summary>
        /// The "enable" password
        /// </summary>
        string EnablePassword { get; set; }
        
        #endregion
        #region VTY (SSH & TelNet)
        /// <summary>
        /// Activate the synchronous logging when connected via a VTY
        /// </summary>
        bool VTYLoggingSynchronous { get; set; }
        /// <summary>
        /// Activate the login for the VTYs. Needs to be activated to activate the VTYs itselves
        /// </summary>
        bool VTYLogin { get; set; }
        /// <summary>
        /// The password for the VTYs
        /// </summary>
        string VTYPassword { get; set; }

        #endregion
        #region Console
        /// <summary>
        /// Activate the synchronous logging when connected via the CONSOLE port
        /// </summary>
        bool ConsoleLoggingSynchronous { get; set; }
        /// <summary>
        /// Activate the login on the CONSOLE port
        /// </summary>
        bool ConsoleLogin { get; set; }
        /// <summary>
        /// The password to login on the CONSOLE port
        /// </summary>
        string ConsolePassword { get; set; }

        #endregion
        #endregion

        #region Interfaces
        /// <summary>
        /// The list of all created interfaces
        /// </summary>
        List<clsInterfaces> InterfacesList { get; set; }

        #region New Interface
        /// <summary>
        /// The name of the new Interface
        /// </summary>
        string NewInterfaceName { get; set; }
        /// <summary>
        /// The type of the new interface
        /// </summary>
        clsInterfaces.InterfaceTypes InterfaceType { get; set; }
        /// <summary>
        /// The number of the new interface
        /// </summary>
        string NewInterfaceNumber { get; set; }

        #endregion

        #endregion
    }
}
