using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cisco_Config_Wiz
{
    class ClsInterfaces
    {
        #region Constantes, variables et propriétés

        const int MAX_CIDR_MASK = 32;

        public string Name
        {
            get;
            set;
        }

        public enum InterfaceType
        {
            FastEthernet,
            Serial,
            Loopback,
        }

        public InterfaceType Type
        {
            get;
            set;
        }

        public string Numéro
        {
            get;
            set;
        }

        public string IPAddress
        {
            get;
            set;
        }

        public string Mask
        {
            get;
            set;
        }
        private int m_CIDR;
        public int CIDRMask
        {
            get;
            set
            {
                if (value < 0)
                    m_CIDR = 0;
                else if (value > MAX_CIDR_MASK)
                    m_CIDR = MAX_CIDR_MASK;
                else
                    m_CIDR = value;
            }
        }

        public int ClockRate
        {
            get;
            set;
        }

        #endregion

        #region Propriétés calculées
        
        #endregion

        #region Constructeurs

        public ClsInterfaces(string pName, InterfaceType pType, string pNumInterface)
        {

        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return Name + " (" + 
            return base.ToString();
        }
        public string ReturnType(InterfaceType pType)
        {

        }

        #endregion
    }
}
