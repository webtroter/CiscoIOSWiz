using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cisco_Config_Wiz
{
    class clsConfWiz
    {
        #region General Configuration
        #region Hostname, etc.
        public clsText Hostname
        {
            get;
            set;
        }
        //clsText obj_Hostname = new clsText("Hostname", CiscoIOSWiz.txtHostname);

        #endregion
        #region VTY SSH/Telnet

        #endregion
        #region Console

        #endregion
        #region Enable Security

        #endregion
        #endregion

        #region General Things

        private List<clsText> m_ListTextBox = new List<clsText>();
        public List<clsText> ListTextBox
        {
            get { return m_ListTextBox; }
            private set { m_ListTextBox = value; }
        }
        #region ReturnTextBox
        /// <summary>
        /// Return the clsTextBox associatied with the name given
        /// </summary>
        /// <param name="pTBfound">Name of the TextBox</param>
        /// <returns></returns>
        public clsText ReturnTextBox(string pTBfound)
        {
            foreach (clsText pTextBox in m_ListTextBox)
            {
                if (pTextBox.Name == pTBfound)
                {
                    return pTextBox;
                }
            }
            return null;
        }
        /// <summary>
        /// Return the clsTextBox associatied with the textbox given
        /// </summary>
        /// <param name="pTBfound">TextBox itself</param>
        /// <returns></returns>
        public clsText ReturnTextBox(TextBox pTBfound)
        {
            foreach (clsText pTextBox in m_ListTextBox)
            {
                if (pTextBox.txtBox == pTBfound)
                {
                    return pTextBox;
                }
            }
            return null;
        }
        #endregion

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

        #region Constructeur

        public clsConfWiz(Form formCiscoIOSWiz)
        {
            #region ForEach pour les textbox
            foreach (Control pControl1 in formCiscoIOSWiz.Controls)
            {
                if (pControl1 is TextBox)
                {
                    TextBox pTextBox = pControl1 as TextBox;
                    m_ListTextBox.Add(new clsText(pTextBox.Text, pTextBox));
                }
                if (pControl1 is TabControl)
                {
                    TabControl pTabControl = pControl1 as TabControl;
                    foreach (TabPage pTabPage in pTabControl.TabPages)
                    {
                        foreach (Control pControl2 in pTabPage.Controls)
                        {
                            if (pControl2 is TextBox)
                            {
                                TextBox pTextBox = pControl2 as TextBox;
                                m_ListTextBox.Add(new clsText(pTextBox.Text, pTextBox));
                            }
                            foreach (Control pControl in pControl2.Controls)
                            {
                                if (pControl is TextBox)
                                {
                                    TextBox pTextBox = pControl as TextBox;
                                    m_ListTextBox.Add(new clsText(pTextBox.Text, pTextBox));
                                }
                            }
                            
                        }
                    }
                }
            }
            #endregion

            Console.WriteLine(m_ListTextBox.Count.ToString());

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
