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
            txtEnPass.Enabled = chkEnLogin.Checked;
            chkEncrypt.Enabled = chkEnLogin.Checked;
        }

        private void txtEnPass_Enter(object sender, EventArgs e)
        {
            if (obj_EnPass.BoxMode)
            {
                obj_EnPass.SetBoxMode(false);
            }
        }

        private void txtEnPass_Leave(object sender, EventArgs e)
        {
            if (obj_EnPass.txtBox.TextLength == 0)
            {
                obj_EnPass.SetBoxMode(true);
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
            if (obj_VTYPass.BoxMode)
            {
                obj_VTYPass.SetBoxMode(false);
            }
        }

        private void txtVTYPass_Leave(object sender, EventArgs e)
        {
            if (obj_VTYPass.txtBox.TextLength == 0)
            {
                obj_VTYPass.SetBoxMode(true);
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
            if (obj_CONPass.BoxMode)
            {
                obj_CONPass.SetBoxMode(false);
            }
        }

        private void txtConPass_Leave(object sender, EventArgs e)
        {
            if (obj_CONPass.txtBox.TextLength == 0)
            {
                obj_CONPass.SetBoxMode(true);
            }
            
        }
        #endregion
    }
}
