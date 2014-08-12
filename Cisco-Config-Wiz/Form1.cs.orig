using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cisco_Config_Wiz
{
    public partial class Form1 : Form
    {
        clsText obj_EnPass;
        clsText obj_VTYPass;
        clsText obj_CONPass;
        public Form1()
        {
            InitializeComponent();
            obj_EnPass = new clsText("Password", txtEnPass);
            obj_VTYPass = new clsText("Password", txtVTYPass);
            obj_CONPass = new clsText("Password", txtConPass);
        }
        #region Constants
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
                obj_EnPass.SetBoxMode(clsText.BoxMode.Default);
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
                obj_VTYPass.SetBoxMode(clsText.BoxMode.Default);
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
