using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cisco_Config_Wiz
{
    class clsInterface
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
        private int[] m_InterAddr;
        public string InterfaceAddress
        {
            get
            {
                string tStrAddr = "";

                tStrAddr += m_InterAddr[0];

                for (int i = 1; i < m_InterAddr.Length; i++)
                {
                    tStrAddr += "/" + m_InterAddr[i];
                    //if (i != m_InterAddr.Length - 1)
                    //{
                    //    tStrAddr
                    //}
                }

                return tStrAddr;
            }
            private set;
        }

        public int ClockSpeed
        {
            get;
            set
            {
                if (TypeInterface != TypeInterfaces.Serial)
                {
                    ClockSpeed = 0;
                }
                else ClockSpeed = value ;
            }
        }

        public clsIPObject IpAddress
        {
            get;
            set
            {

            }
        }

        #endregion
        #region Méthodes

        public void GenerateInterfaceAddress()
        {
            
        }

        #endregion
        #region Constructeur


        #endregion

    }
}
