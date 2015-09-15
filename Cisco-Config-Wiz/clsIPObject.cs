using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cisco_Config_Wiz
{
    class clsIPObject
    {
        #region Constantes

        #endregion

        #region Variable
        //byte[] ipArray;
        byte[] ipArray = new byte[4];
        #endregion

        #region Propriétés

        private IPClass m_IPClasse = IPClass.ClasseB;
        public IPClass Class
        {
            get { CalcIPClass(); return m_IPClasse; }
            private set { m_IPClasse = value; }
        }

        public enum IPClass
        {
            ClasseA,
            ClasseB,
            ClasseC,
            ClasseD,
            ClasseE
        }
        public enum IPType
        {
            Local,
            APIPA
        }
        #endregion

        #region Méthodes

        private void CalcIPClass()
        {
            if (ipArray[0] < 128)
            {
                m_IPClasse = IPClass.ClasseA;
            }
            else if (ipArray[0] >= 128 && ipArray[0] < 192)
            {
                m_IPClasse = IPClass.ClasseB;
            }
            else if (ipArray[0] >= 192 && ipArray[0] < 224)
            {
                m_IPClasse = IPClass.ClasseC;
            }
            else if (ipArray[0] >= 224 && ipArray[0] < 240)
            {
                m_IPClasse = IPClass.ClasseD;
            }
            else
            {
                m_IPClasse = IPClass.ClasseE;
            }
        }

        public override string ToString()
        {
            return ipArray[0].ToString() + '.' + ipArray[1].ToString() + '.'
                + ipArray[2].ToString() + '.' + ipArray[3].ToString();
        }

        #endregion

        #region Constructeur

        public clsIPObject(string pString)
        {
            string[] strArrIP = pString.Split('.');
            for (int i = 0; i < strArrIP.Length; i++)
            {
                int tempByte = int.Parse(strArrIP[i]);
                ipArray[i] = (byte)tempByte;
            }
        }
        /// <summary>
        /// Generate Random IP, in APIPA range
        /// </summary>
        public clsIPObject()
        {
            Random rnd = new Random();
            ipArray[0] = 169;
            ipArray[1] = 254;
            for (int i = 2; i < ipArray.Length; i++)
            {
                ipArray[i] = (byte)rnd.Next(0, 256);
            }
        }
        #endregion
    }
}
