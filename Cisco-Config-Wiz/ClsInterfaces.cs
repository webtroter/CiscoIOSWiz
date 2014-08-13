using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cisco_Config_Wiz
{
    class clsInterfaces
    {
        #region Constantes, variables et propriétés

        const int MAX_CIDR_MASK = 32;

        public string Name
        {
            get;
            set;
        }

        public enum InterfaceTypes
        {
            Loopback = 0,
            Serial = 1,
            FastEthernet = 2,
        }

        public InterfaceTypes Type
        {
            get;
            set;
        }

        public string Number
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
            get
            {
                return m_CIDR;
            }
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

        /// <summary>
        /// Set if the Serial Interface is DCE (Master) or DTE
        /// If True, is DCE
        /// </summary>
        public bool DceDte
        {
            get { return DceDte; }
            set
            {
                if (Type == InterfaceTypes.Serial)
                {
                    DceDte = value;
                }
            }
        }
        public int ClockRate
        {
            get { return ClockRate; }
            set
            {
                if (Type == InterfaceTypes.Serial)
                {
                    ClockRate = value;
                }
            }
        }

        #endregion

        #region Propriétés calculées
        
        #endregion

        #region Constructeurs

        public clsInterfaces(string pName, InterfaceTypes pType, string pNumInterface)
        {
            Name = pName;
            Type = pType;
            Number = pNumInterface;
        }

        #endregion

        #region Méthodes

        public override string ToString()
        {
            return ReturnType(Type) + " " + Number.ToString() + "(" + Name + ")";
        }
        public string ReturnType(InterfaceTypes pType)
        {
            switch (pType)
            {
                case InterfaceTypes.FastEthernet:
                    return "FastEthernet";
                case InterfaceTypes.Serial:
                    return "Serial";
                case InterfaceTypes.Loopback:
                    return "Loopback";
                default:
                    return "";
            }
        }

        public List<string> GetInterfaceTypes()
        {
            List<string> interTypes = new List<string>();
            foreach (var interfType in Enum.GetNames(typeof(InterfaceTypes)))
            {
                interTypes.Add(interfType.ToString());
            }
            return interTypes;
        }

        #endregion
    }
}
