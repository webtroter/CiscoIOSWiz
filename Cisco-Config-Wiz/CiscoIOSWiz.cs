using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cisco_Config_Wiz
{
    public partial class CiscoIOSWiz : Form
    {
        clsText obj_EnPass;
        clsText obj_VTYPass;
        clsText obj_CONPass;
        clsText obj_Hostname;
        clsText obj_Banner;
        clsText obj_MOTD;
        clsText obj_NewInterfaceName;
        clsText obj_NewInterfacenumber;
        List<clsInterfaces> obj_ListInterfaces = new List<clsInterfaces>();
        clsInterfaces obj_CurrentInterface = null;
        public CiscoIOSWiz()
        {
            InitializeComponent();

            obj_EnPass = new clsText("Password", txtEnPass);
            obj_VTYPass = new clsText("Password", txtVTYPass);
            obj_CONPass = new clsText("Password", txtConPass);
            obj_Hostname = new clsText("Hostname", txtHostname);
            obj_Banner = new clsText("Login Banner", txtLogBanner);
            obj_MOTD = new clsText("MOTD", txtMotdBanner);
            obj_NewInterfaceName = new clsText("Interface Name", txtNewInterfaceName);
            obj_NewInterfacenumber = new clsText("Interface Number", txtNewInterfaceNumber);
            foreach (var interfType in Enum.GetNames(typeof(clsInterfaces.InterfaceTypes)))
            {
                cboNewInterfaceType.Items.Add(interfType.ToString());
            }
            cboNewInterfaceType.SelectedItem = cboNewInterfaceType.Items[0];
        }
        #region General Conf
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

        #endregion
        #region Interfaces
        #region New Interface
        #region New Interface Name
        private void txtNewInterfaceName_Enter(object sender, EventArgs e)
        {
            if (obj_NewInterfaceName.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_NewInterfaceName.SetBoxMode(clsText.BoxMode.Default);
            }
        }

        private void txtNewInterfaceName_Leave(object sender, EventArgs e)
        {
            if (obj_NewInterfaceName.txtBox.TextLength == 0)
            {
                obj_NewInterfaceName.SetBoxMode(clsText.BoxMode.Title);
            }
        }
        #endregion
        #region New Interface Number
        private void txtNewInterfaceNumber_Enter(object sender, EventArgs e)
        {
            if (obj_NewInterfacenumber.BoxModeObj == clsText.BoxMode.Title)
            {
                obj_NewInterfacenumber.SetBoxMode(clsText.BoxMode.Default);
            }
        }

        private void txtNewInterfaceNumber_Leave(object sender, EventArgs e)
        {
            if (obj_NewInterfacenumber.txtBox.TextLength == 0)
            {
                obj_NewInterfacenumber.SetBoxMode(clsText.BoxMode.Title);
            }
        }
        #endregion
        private void btnnewInterfaceAdd_Click(object sender, EventArgs e)
        {
            obj_ListInterfaces.Add(new clsInterfaces(txtNewInterfaceName.Text,
                (clsInterfaces.InterfaceTypes)cboNewInterfaceType.SelectedIndex,
                txtNewInterfaceNumber.Text));
            cboInterfaces.Items.Add(obj_ListInterfaces[obj_ListInterfaces.Count - 1]);
            boxInterface.Enabled = true;
            cboInterfaces.SelectedIndex = cboInterfaces.Items.Count - 1;
            txtNoInterfaceWarning.Visible = false;

        }
        #endregion

        private void cboInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_CurrentInterface = obj_ListInterfaces[cboInterfaces.SelectedIndex];
            txtInterfaceName.Text = obj_CurrentInterface.Name;
            txtInterfaceTypeNum.Text = obj_CurrentInterface.ReturnType(obj_CurrentInterface.Type);
            numInterfaceClock.Enabled = obj_CurrentInterface.Type == clsInterfaces.InterfaceTypes.Serial;
            cboInterfaceUseClock.Enabled = obj_CurrentInterface.Type == clsInterfaces.InterfaceTypes.Serial;
        }



        #endregion

        #region UI
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void ipInterfaceMask_TextChanged(object sender, EventArgs e)
        {
            string[] ipMask = ipInterfaceMask.Text.Split('.');
            int compt = 0;
            foreach (string ipPart in ipMask)
            {
                if (ipPart != "")
                {
                    
                    compt++;
                    //Console.Write('-');
                }
                //Console.WriteLine(ipPart);
                if (compt == 4)
                {
                    Console.WriteLine("Full MASK");
                    obj_CurrentInterface.Mask = ipInterfaceMask.Text;
                    Console.WriteLine("CIDR:" + obj_CurrentInterface.CIDRMask.ToString());
                    Console.WriteLine("Mask:" + obj_CurrentInterface.Mask.ToString());
                }
                //Console.WriteLine("=" + compt);
            }
        }

        private void numInterfaceCIDR_ValueChanged(object sender, EventArgs e)
        {
            //obj_CurrentInterface.CalculateMaskAndCIDR(true);
            obj_CurrentInterface.CIDRMask = (int)numInterfaceCIDR.Value;
            Console.WriteLine("CIDR:" + obj_CurrentInterface.CIDRMask.ToString());
            Console.WriteLine("Mask:" + obj_CurrentInterface.Mask.ToString());
        }
    }
}
