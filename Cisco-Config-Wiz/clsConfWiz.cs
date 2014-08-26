using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cisco_Config_Wiz
{
    class clsConfWiz : IConfWiz
    {
        #region General Configuration
        #region Hostname, etc.
        string m_Hostname;
        public string Hostname
        {
            get
            {
                return m_Hostname;
            }
            set
            {
                m_Hostname = value;
            }
        }
        string m_LoginBanner;
        public string LoginBanner
        {
            get
            {
                return m_LoginBanner;
            }
            set
            {
                m_LoginBanner = value;
            }
        }
        string m_MOTDBanner;
        public string MOTDBanner
        {
            get
            {
                return m_MOTDBanner;
            }
            set
            {
                m_MOTDBanner = value;
            }
        }
        bool m_NoIPdomlook;
        public bool NoIPDomainLookup
        {
            get
            {
                return m_NoIPdomlook;
            }
            set
            {
                m_NoIPdomlook = value;
            }
        }
        //public clsText Hostname
        //{
        //    get;
        //    set;
        //}
        ////clsText obj_Hostname = new clsText("Hostname", CiscoIOSWiz.txtHostname);

        #endregion
        #region Enable Security
        bool m_ENLogin;
        public bool EnableLogin
        {
            get
            {
                return m_ENLogin;
            }
            set
            {
                m_ENLogin = value;
            }
        }
        bool m_ENcrypt;
        public bool EncryptEnablePassword
        {
            get
            {
                return m_ENcrypt;
            }
            set
            {
                m_ENcrypt = value;
            }
        }
        string m_ENPassword;
        public string EnablePassword
        {
            get
            {
                return m_ENPassword;
            }
            set
            {
                m_ENPassword = value;
            }
        }
        #endregion
        #region VTY SSH/Telnet
        public bool VTYLoggingSynchronous
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool VTYLogin
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string VTYPassword
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        #region Console
        public bool ConsoleLoggingSynchronous
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ConsoleLogin
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string ConsolePassword
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        
        #endregion

        #region Interfaces
        List<clsInterfaces> m_ListInterfaces;
        public List<clsInterfaces> InterfacesList
        {
            get
            {
                return m_ListInterfaces;
            }
            private set
            {
                m_ListInterfaces = value;
            }
        }
        clsInterfaces m_currentInterface = null;
        public clsInterfaces CurrentInterface
        {
            get
            {
                return m_currentInterface;
            }
            set
            {
                m_currentInterface = value;
            }
        }
        #region New Interface
        public string NewInterfaceName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public clsInterfaces.InterfaceTypes InterfaceType
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string NewInterfaceNumber
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        #endregion

        #region Essais

        //private List<clsText> m_ListTextBox = new List<clsText>();
        //public List<clsText> ListTextBox
        //{
        //    get { return m_ListTextBox; }
        //    private set { m_ListTextBox = value; }
        //}
        //#region ReturnTextBox
        ///// <summary>
        ///// Return the clsTextBox associatied with the name given
        ///// </summary>
        ///// <param name="pTBfound">Name of the TextBox</param>
        ///// <returns></returns>
        //public clsText ReturnTextBox(string pTBfound)
        //{
        //    foreach (clsText pTextBox in m_ListTextBox)
        //    {
        //        if (pTextBox.Name == pTBfound)
        //        {
        //            return pTextBox;
        //        }
        //    }
        //    return null;
        //}
        ///// <summary>
        ///// Return the clsTextBox associatied with the textbox given
        ///// </summary>
        ///// <param name="pTBfound">TextBox itself</param>
        ///// <returns></returns>
        //public clsText ReturnTextBox(TextBox pTBfound)
        //{
        //    foreach (clsText pTextBox in m_ListTextBox)
        //    {
        //        if (pTextBox.txtBox == pTBfound)
        //        {
        //            return pTextBox;
        //        }
        //    }
        //    return null;
        //}
        //#endregion

        #region Doesn't work yet == set and remove title
        //public void setTitle(clsText pTextBox)
        //{
        //    if (pTextBox.BoxModeObj == clsText.BoxMode.Title)
        //    {
        //        pTextBox.SetBoxMode(clsText.BoxMode.Default);
        //    }
        //}
        //public void setTitle(TextBox pTextBox)
        //{
        //    foreach (clsText pText in m_ListTextBox)
        //    {
        //        if (pText.txtBox == pTextBox && pText.BoxModeObj == clsText.BoxMode.Title)
        //        {
        //            pText.SetBoxMode(clsText.BoxMode.Default);
        //        }
        //    }
        //}
        //public void removeTitle(object pTextBox)
        //{
        //    foreach (clsText pText in m_ListTextBox)
        //    {
        //        if (pText.txtBox == pTextBox && pText.txtBox.TextLength == 0)
        //        {
        //            pText.SetBoxMode(clsText.BoxMode.Title);
        //        }
        //    }
        //}

        //public void removeTitle(clsText pTextBox)
        //{
        //    if (pTextBox.txtBox.TextLength == 0)
        //    {
        //        pTextBox.SetBoxMode(clsText.BoxMode.Title);
        //    }
        //}
        #endregion

        #endregion

        #region Méthodes
        /// <summary>
        /// 
        /// </summary>
        public void AddInterfaceToList()
        {

        }

        #endregion

        #region Constructeur

        public clsConfWiz()
        {
            #region ForEach pour les textbox
            //foreach (Control pControl1 in formCiscoIOSWiz.Controls)
            //{
            //    if (pControl1 is TextBox)
            //    {
            //        TextBox pTextBox = pControl1 as TextBox;
            //        m_ListTextBox.Add(new clsText(pTextBox.Text, pTextBox));
            //    }
            //    if (pControl1 is TabControl)
            //    {
            //        TabControl pTabControl = pControl1 as TabControl;
            //        foreach (TabPage pTabPage in pTabControl.TabPages)
            //        {
            //            foreach (Control pControl2 in pTabPage.Controls)
            //            {
            //                if (pControl2 is TextBox)
            //                {
            //                    TextBox pTextBox = pControl2 as TextBox;
            //                    m_ListTextBox.Add(new clsText(pTextBox.Text, pTextBox));
            //                }
            //                foreach (Control pControl in pControl2.Controls)
            //                {
            //                    if (pControl is TextBox)
            //                    {
            //                        TextBox pTextBox = pControl as TextBox;
            //                        m_ListTextBox.Add(new clsText(pTextBox.Text, pTextBox));
            //                    }
            //                }
                            
            //            }
            //        }
            //    }
            //}
            #endregion

            m_ListInterfaces = new List<clsInterfaces>();

            //Console.WriteLine(m_ListTextBox.Count.ToString());

            //foreach (Control pControl in formCiscoIOSWiz.Controls)
            //{
                
            //    if (pControl is TextBox)
            //    {
            //        TextBox pTextBox = pControl as TextBox;
            //        obj_Ltxt.Add(new clsText(pTextBox.Text, pTextBox));
            //    }
            //}
        }
        #endregion

    }
}
