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

        #region General Things like Methods

        private List<clsText> m_ListTextBox = new List<clsText>();
        public List<clsText> obj_Ltxt
        {
            get { return m_ListTextBox; }
            private set { m_ListTextBox = value; }
        }

        public static void setTitle(TextBox pTextBox)
        {
            //if (obj_Hostname.BoxModeObj == clsText.BoxMode.Title)
            //{
            //    obj_Hostname.SetBoxMode(clsText.BoxMode.Default);
            //}
        }
        public static void removeTitle(TextBox pTextBox)
        {
        }

        #endregion

        #region Constructeur

        public clsConfWiz(Form formCiscoIOSWiz)
        {

            foreach (Control pControl1 in formCiscoIOSWiz.Controls)
            {
                if (pControl1 is TabControl)
                {
                    TabControl pTabControl = pControl1 as TabControl;
                    foreach (TabPage pTabPage in pTabControl.TabPages)
                    {
                        foreach (Control pControl2 in pTabPage.Controls)
                        {
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
