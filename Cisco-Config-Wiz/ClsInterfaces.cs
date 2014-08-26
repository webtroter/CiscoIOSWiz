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
        static byte[] GOOD_MASK_VALUES = { 0, 128, 192, 224, 240, 248, 242, 254, 255 };

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
        //string[] m_tabMask = new string[4];
        byte[] m_tabMaskByte = new byte[4];
        public string Mask
        {
            get
            {
                string breturn = "";
                int compt = 0;
                foreach (byte pPart in m_tabMaskByte)
                {
                    breturn += pPart.ToString();
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
                byte[] byteArray = new byte[4];
                string[] tabMask = value.Split('.');
                int compt = 0;
                foreach (string pPart in tabMask)
                {
                    byteArray[compt] = (byte)int.Parse(pPart);
                    compt++;
                }
                if (IsValidMask(byteArray))
                {
                    m_tabMaskByte = byteArray;
                }
                else
                {
                    for (int pos = 0; pos < m_tabMaskByte.Length; pos++)
                    {
                        m_tabMaskByte[pos] = 0;
                    }
                }
                //int compt = 0;
                //foreach (string pPart in tabMask)
                //{
                //    bool byteIsValid = false;
                //    foreach (byte pGoodByte in GOOD_MASK_VALUES)
                //    {
                //        if ((byte)int.Parse(pPart) == pGoodByte || byteIsValid)
                //        {
                //            byteIsValid = true;
                //        }
                //    }
                //    if (byteIsValid)
                //    {
                //        m_tabMaskByte[compt] = (byte)int.Parse(pPart);
                //    }
                //    compt++;
                    
                //}
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
        public static List<string> GetInterfaceTypes()
        {
            List<string> interTypes = new List<string>();
            foreach (var interfType in Enum.GetNames(typeof(InterfaceTypes)))
            {
                interTypes.Add(interfType.ToString());
            }
            return interTypes;
        }
        #region IsValidMask( byteArray or String )
        /// <summary>
        /// Will confirm that the mask entered is valid. (Only UP bits followed by only down bits)
        /// </summary>
        /// <param name="pByteArray">Bytes Array - An IP!</param>
        /// <returns></returns>
        public static bool IsValidMask(byte[] pByteArray)
        {
            if (pByteArray.Length != 4)
            {
                return false;
            }

            for (int pos = 0; pos < 4; pos++)
            {
                if (pos != 0 && pByteArray[pos - 1] != 255 && pByteArray[pos] != 0)
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Will confirm that the mask entered is valid. (Only UP bits followed by only down bits)
        /// Will convert a string of the format WWW.XXX.YYY.ZZZ to a byte array first
        /// </summary>
        /// <param name="pString">String of the format WWW.XXX.YYY.ZZZ that will be converted to a byte array</param>
        /// <returns></returns>
        public static bool IsValidMask(string pString)
        {
            byte[] pByteArray = new byte[4];
            string[] tabMask = pString.Split('.');
            int compt = 0;
            foreach (string pPart in tabMask)
            {
                pByteArray[compt] = (byte)int.Parse(pPart);
                compt++;
            }
            if (pByteArray.Length != 4)
            {
                return false;
            }

            for (int pos = 0; pos < 4; pos++)
            {
                if (pos != 0 && pByteArray[pos - 1] != 255 && pByteArray[pos] != 0)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        // <summary>
        // Will calculate the Mask from the CIDR, or the CIDR from the Mask.
        // </summary>
        // <param name="pFromCIDR">Set to true if Mask is calculated from CIDR. False if you want to find the CIDR</param>
        /// <summary>
        /// Will calculate the CIDR from the Mask, in byteArray
        /// </summary>
        /// <param name="pByteArray">Mask in byteArray</param>
        /// <returns></returns>
        public static int CalculateMaskAndCIDR(byte[] pByteArray)
        {
            //Console.WriteLine("Calculating...");
            //if (pFromCIDR)
            //{

            //}
            //else
            //{
            //    string[] ipMask = Mask.Split('.');
            //    foreach (string ipPart in ipMask)
            //    {
            //        Console.WriteLine(ipPart);
            //    }
            //}
            return 0;
        }
        /// <summary>
        /// Will calculate the Mask from the CIDR
        /// </summary>
        /// <param name="pCIDR"></param>
        /// <returns></returns>
        public byte[] CalculateMaskAndCIDR(int pCIDR)
        {
            int fullByte = pCIDR / 8;
            int restByte = pCIDR % 8;
            byte[] MaskByteArray = new byte[4];
            //for (int i = 0; i < fullByte - 1; i++)
            //{
            //    MaskByteArray[i] = GOOD_MASK_VALUES[8];
            //}
            if (fullByte == 1)
            {
                MaskByteArray[0] = GOOD_MASK_VALUES[8];
            }
            else if (fullByte == 2)
            {
                MaskByteArray[0] = MaskByteArray[1] = GOOD_MASK_VALUES[8];
            }
            else if (fullByte == 3)
            {
                MaskByteArray[0] = MaskByteArray[1] = MaskByteArray[2] = GOOD_MASK_VALUES[8];
            }
            MaskByteArray[fullByte] = GOOD_MASK_VALUES[restByte];
            return MaskByteArray;
        }
        public void CalculateMaskAndCIDR(bool pFrom)
        {

        }
        public static string ReturnMaskAndCIDR(int pCIDR)
        {
            int fullByte = pCIDR / 8;
            int restByte = pCIDR % 8;
            byte[] MaskByteArray = new byte[4];
            if (fullByte == 1)
            {
                MaskByteArray[0] = GOOD_MASK_VALUES[8];
            }
            else if (fullByte == 2)
            {
                MaskByteArray[0] = MaskByteArray[1] = GOOD_MASK_VALUES[8];
            }
            else if (fullByte == 3)
            {
                MaskByteArray[0] = MaskByteArray[1] = MaskByteArray[2] = GOOD_MASK_VALUES[8];
            }
            MaskByteArray[fullByte] = GOOD_MASK_VALUES[restByte];
            string breturn = "";
            int compt = 0;
            foreach (byte pPart in MaskByteArray)
            {
                breturn += pPart.ToString();
                if (compt != 3)
                {
                    compt++;
                    breturn += '.';
                }
            }
            return breturn;
        }
        #endregion
    }
}