using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IPAddressControlLib;

namespace Cisco_Config_Wiz
{
    public partial class Form1 : Form
    {
        clsText obj_EnPass;
        clsText obj_VTYPass;
        clsText obj_CONPass;
        clsText obj_Hostname;
        clsText obj_Banner;
        clsText obj_MOTD;
        
        public Form1()
        {
            InitializeComponent();
            obj_EnPass = new clsText("Password", txtEnPass);
            obj_VTYPass = new clsText("Password", txtVTYPass);
            obj_CONPass = new clsText("Password", txtConPass);
            obj_Hostname = new clsText("Hostname", txtHostname);
            obj_Banner = new clsText("Login Banner", txtLogBanner);
            obj_MOTD = new clsText("MOTD", txtMotdBanner);

            Console.WriteLine(ipAddressControl1.Text);

        }
        #region Constants
        #endregion
        #region Name and Banners

        #region Hostname
        private void txtHostname_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtHostname_Enter(object sender, EventArgs e)
        {
            if (obj_Hostname.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_Hostname.SetBoxMode(clsText.BoxMode.Default);
            }
        }

        private void txtHostname_Leave(object sender, EventArgs e)
        {
            if (obj_Hostname.txtBox.TextLength == 0)
            {
                obj_Hostname.SetBoxMode(clsText.BoxMode.Title);
            }
        }
        #endregion
        #region Login Banner
        private void txtLogBanner_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtLogBanner_Enter(object sender, EventArgs e)
        {
            if (obj_Banner.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_Banner.SetBoxMode(clsText.BoxMode.Default);
            }
        }

        private void txtLogBanner_Leave(object sender, EventArgs e)
        {
            if (obj_Banner.txtBox.TextLength == 0)
            {
                obj_Banner.SetBoxMode(clsText.BoxMode.Title);
            }
        }
        #endregion
        #region MOTD
        private void txtMotdBanner_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMotdBanner_Enter(object sender, EventArgs e)
        {
            if (obj_MOTD.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_MOTD.SetBoxMode(clsText.BoxMode.Default);
            }
        }

        private void txtMotdBanner_Leave(object sender, EventArgs e)
        {
            if (obj_MOTD.txtBox.TextLength == 0)
            {
                obj_MOTD.SetBoxMode(clsText.BoxMode.Title);
            }
        }
        #endregion

        #endregion

        #region Enable
        private void chkEnLogin_CheckedChanged(object sender, EventArgs e)
        {
            txtEnPass.Enabled = chkEncrypt.Enabled = chkEnLogin.Checked;
        }

        private void txtEnPass_Enter(object sender, EventArgs e)
        {
            if (obj_EnPass.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_EnPass.SetBoxMode(clsText.BoxMode.Password);
            }
        }

        private void txtEnPass_Leave(object sender, EventArgs e)
        {
            if (obj_EnPass.txtBox.TextLength == 0)
            {
                obj_EnPass.SetBoxMode(clsText.BoxMode.Title);
            }
        }

        #endregion
        #region VTY
        private void chkVTYLogin_CheckedChanged(object sender, EventArgs e)
        {
            obj_VTYPass.txtBox.Enabled = chkVTYLogin.Checked;
        }
        private void txtVTYPass_Enter(object sender, EventArgs e)
        {
            if (obj_VTYPass.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_VTYPass.SetBoxMode(clsText.BoxMode.Password);
            }
        }

        private void txtVTYPass_Leave(object sender, EventArgs e)
        {
            if (obj_VTYPass.txtBox.TextLength == 0)
            {
                obj_VTYPass.SetBoxMode(clsText.BoxMode.Title);
            }
        }
        #endregion
        #region Console
        private void chkConLogin_CheckedChanged(object sender, EventArgs e)
        {
            obj_CONPass.txtBox.Enabled = chkConLogin.Checked;
        }

        private void txtConPass_Enter(object sender, EventArgs e)
        {
            if (obj_CONPass.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_CONPass.SetBoxMode(clsText.BoxMode.Default);
            }
        }

        private void txtConPass_Leave(object sender, EventArgs e)
        {
            if (obj_CONPass.txtBox.TextLength == 0)
            {
                obj_CONPass.SetBoxMode(clsText.BoxMode.Title);
            }

        }
        #endregion


    }
}
