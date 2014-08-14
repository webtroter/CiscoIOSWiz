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
        string[] m_tabMask = new string[4];
        byte[] m_tabMaskByte = new byte[4];
        public string Mask
        {
            get
            {
                string breturn = "";
                int compt = 0;
                foreach (string pPart in m_tabMask)
                {
                    breturn += pPart;
                    if (compt != 3)
                    {
                        compt++;
                        breturn += '.';
                    }
                }
                return breturn;
            }
            set
            {
                m_tabMask = value.Split('.');
                int compt = 0;
                foreach (string pPart in m_tabMask)
                {
                    m_tabMaskByte[compt] = (byte)int.Parse(pPart);
                    compt++;
                }
            }
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
        /// <summary>
        /// Will calculate the Mask from the CIDR, or the CIDR from the Mask.
        /// </summary>
        /// <param name="pFromCIDR">Set to true if Mask is calculated from CIDR. False if you want to find the CIDR</param>
        public void CalculateMaskAndCIDR(bool pFromCIDR)
        {
            Console.WriteLine("Calculating...");
            if (pFromCIDR)
            {

            }
            else
            {
                string[] ipMask = Mask.Split('.');
                foreach (string ipPart in ipMask)
                {
                    Console.WriteLine(ipPart);
                }
            }
        }

        #endregion
    }
}
