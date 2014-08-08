using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPAddressControlLib;

namespace Cisco_Config_Wiz
{
    class Interface
    {
        #region Propriétés

        public enum TypeInterfaces
        {
            Serial,
            FastEthernet,
            GigabitEthernet,
            Loopback,
            VLan
        }
        public TypeInterfaces TypeInterface
        {
            get;
            set;
        }

        public int InterfaceNumber
        {
            get;
            set;
        }

        public int ClockSpeed
        {
            get;
            set;
        }

        //public string IpAddress
        //{
        //    get;
        //    set
        //    {

        //    }
        //}
        
        #endregion
        #region Méthodes


        #endregion
        #region Constructeur


        #endregion

    }
}
