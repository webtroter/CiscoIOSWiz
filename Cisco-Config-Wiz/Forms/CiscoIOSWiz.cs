using System;
using System.Collections.Generic;
using System.Windows.Forms;

//TODO: FormDNS
//TODO: FormPing
//Le pire c'est que j'ai déjà ces deux formes là de faites (de NetNet, un de mes programmes), mais les importer n'est pas très facile. J'ai essayé.

namespace Cisco_Config_Wiz
{
    public partial class CiscoIOSWiz : Form
    {
        protected internal readonly string nl = System.Environment.NewLine;

        clsText obj_EnPass;
        clsText obj_VTYPass;
        clsText obj_CONPass;
        clsText obj_Hostname;
        clsText obj_Banner;
        clsText obj_MOTD;
        clsText obj_NewInterfaceName;
        clsText obj_NewInterfacenumber;
        //List<clsInterfaces> obj_ListInterfaces = new List<clsInterfaces>();
        clsInterfaces obj_CurrentInterface = null;
        clsConfWiz ConfWiz;

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
            clsConfWiz ConfWiz = new clsConfWiz();


            //DEBUG
            txtOutput.AppendText("c68034f9fb64a322c66a8e07b40526622c470b2ba14f1a6edf2a56a278cc354b" + nl);
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
            else
            {
                Console.WriteLine("Calculated CIDR :" + clsInterfaces.ReturnMaskAndCIDR(int.Parse(txtHostname.Text)));
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

        private void txtNewInterfaceName_TextChanged(object sender, EventArgs e)
        {
            errAddInterface.Clear();
            txtNewInterfaceName.Size = new System.Drawing.Size(140, 23);
            txtNewInterfaceNumber.Size = new System.Drawing.Size(140, 23);
        }

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
        private void txtNewInterfaceNumber_TextChanged(object sender, EventArgs e)
        {
            errAddInterface.Clear();
            txtNewInterfaceName.Size = new System.Drawing.Size(140, 23);
            txtNewInterfaceNumber.Size = new System.Drawing.Size(140, 23);
        }
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
            bool newInterOK = true;
            if (obj_NewInterfaceName.BoxModeObj == clsText.BoxMode.Title)
            {
                errAddInterface.SetError(txtNewInterfaceName, "Name is empty");
                txtNewInterfaceName.Size = new System.Drawing.Size(130, 23);
                newInterOK = false;
            }
            if (obj_NewInterfacenumber.BoxModeObj == clsText.BoxMode.Title)
            {
                errAddInterface.SetError(txtNewInterfaceNumber, "Number is Empty");
                txtNewInterfaceNumber.Size = new System.Drawing.Size(130, 23);
                newInterOK = false;
            }
            if (newInterOK)
            {
                errAddInterface.Clear();
                ConfWiz.InterfacesList.Add(new clsInterfaces(txtNewInterfaceName.Text,
                    (clsInterfaces.InterfaceTypes)cboNewInterfaceType.SelectedIndex,
                    txtNewInterfaceNumber.Text));
                obj_NewInterfaceName.SetBoxMode(clsText.BoxMode.Title);
                obj_NewInterfacenumber.SetBoxMode(clsText.BoxMode.Title);
                cboInterfaces.Items.Add(ConfWiz.InterfacesList[ConfWiz.InterfacesList.Count - 1]);
                boxInterface.Enabled = true;
                cboInterfaces.SelectedIndex = cboInterfaces.Items.Count - 1;
                txtNoInterfaceWarning.Visible = false;
            }

        }
        private void txtNewInterfaceNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnnewInterfaceAdd.PerformClick();
            }
        }

        #endregion

        #region Update fields to current interface
        private void cboInterfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj_CurrentInterface = ConfWiz.InterfacesList[cboInterfaces.SelectedIndex];
            txtInterfaceName.Text = obj_CurrentInterface.Name;
            txtInterfaceTypeNum.Text = obj_CurrentInterface.ReturnType(obj_CurrentInterface.Type);
            numInterfaceClock.Enabled = obj_CurrentInterface.Type == clsInterfaces.InterfaceTypes.Serial;
            cboInterfaceUseClock.Enabled = obj_CurrentInterface.Type == clsInterfaces.InterfaceTypes.Serial;
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
                    //IsValidMask(ipInterfaceMask.Text);
                    if (!clsInterfaces.IsValidMask(ipInterfaceMask.Text))
                    {
                        errMask.SetError(ipInterfaceMask, "Mask is not valid");
                    }
                    else errMask.Clear();
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
        #endregion

        #region UI
        //ABOUT
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }

        //EXIT
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //HELP
        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Si la forme demandé est présente et non null..
            if (System.Windows.Forms.Application.OpenForms["FormHelp"] as FormHelp == null)
            {
                //Affiche la
                new FormHelp().Show(); //Show() masterrace
            }
            else
                //Aussi non active la et donne lui le focus.
                Application.OpenForms["FormHelp"].Activate();
        }

        //SELECT ALL
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabOutput;
            txtOutput.SelectAll();
        }
        #endregion
        
        #region MaskValidationInForm - No more useful Thanks static
        //public bool IsValidMask(byte[] pByteArray)
        //{
        //    if (pByteArray.Length != 4)
        //    {
        //        return false;
        //    }

        //    for (int pos = 0; pos < 4; pos++)
        //    {
        //        if (pos != 0 && pByteArray[pos - 1] != 255 && pByteArray[pos] != 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        //public bool IsValidMask(string pString)
        //{
        //    byte[] pByteArray = new byte[4];
        //    string[] tabMask = pString.Split('.');
        //    int compt = 0;
        //    foreach (string pPart in tabMask)
        //    {
        //        pByteArray[compt] = (byte)int.Parse(pPart);
        //        compt++;
        //    }
        //    if (pByteArray.Length != 4)
        //    {
        //        return false;
        //    }
        //    for (int pos = 0; pos < 4; pos++)
        //    {
        //        if (pos != 0 && pByteArray[pos - 1] != 255 && pByteArray[pos] != 0)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
        #endregion
    }
}
