using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cisco_Config_Wiz
{
    class clsIOSConfig
    {
        #region Constantes, variable et propriétés
        #region General Configuration
        string m_Hostname;
        public string Hostname
        {
            get { return m_Hostname; }
            set { m_Hostname = value; }
        }

        string m_LoginBanner;
        public string LoginBanner
        {

        }

        string m_MOTD;
        public string MOTD
        {

        }
        bool m_noDomLookup;
        public bool NoDomainLookup
        {

        }
        #region Enable Security
        bool m_EnLogin;
        public bool EnableSecurity
        {

        }

        bool m_EnEncrypt;
        public bool EnableEncrypt
        {

        }

        string m_EnPassword;
        public string EnablePassword
        {

        }
        #endregion
        bool m_VTYLogSync;
        public bool VTYLoggingSynchronous
        {

        }
        bool m_VTYLogin;
        public bool VTYLogin
        {

        }
        string m_VTYPassword;
        public string VTYPassword
        {

        }
        #region VTY

        #endregion
        bool m_ConLogSync;
        public bool ConLoggingSynchronous
        {

        }
        bool m_ConLogin;
        public bool ConLogin
        {

        }
        string m_ConPassword;
        public string ConPassword
        {

        }
        #region Console

        #endregion

        #endregion
        #endregion
        #region Propriétés calculés

        #endregion

        #region Méthodes

        #endregion

        #region Constructeurs

        #endregion
    }
}
