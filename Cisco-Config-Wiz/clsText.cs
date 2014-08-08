﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cisco_Config_Wiz
{
    class clsText
    {
        #region Propriétés

        TextBox m_txtBox;
        public TextBox txtBox
        {
            get { return m_txtBox; }
            private set { m_txtBox = value; }
        }
        /// <summary>
        /// Title of the textbox
        /// </summary>
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        /// Will tell if the BoxMode is in Title, Password or default. v1
        /// </summary>
        private BoxMode m_BoxMode = BoxMode.Default;
        public BoxMode BoxModeObj
        {
            get { return m_BoxMode; }
            private set { m_BoxMode = value; }
        }
        public static enum BoxMode
        {
            Default,
            Title,
            Password
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Will set the TextBox the way you want.
        /// </summary>
        /// <param name="pMode">TextBoxMode : True=>Title, False=>Text,</param>
        public void SetBoxMode(bool pMode)
        {
            if (pMode == true)
            {
                m_txtBox.Text = Title;
                m_txtBox.ForeColor = Color.Gray;
                m_BoxMode = BoxMode.Title;

            }
            else
            {
                m_txtBox.Text = "";
                m_txtBox.ForeColor = Color.Black;
                m_BoxMode = BoxMode.Default;

            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// TextBox with Title and password option
        /// </summary>
        /// <param name="pTitle">Title of the TextBox</param>
        /// <param name="pTxtBox">TextBox that you want to use</param>
        public clsText(string pTitle, TextBox pTxtBox)
        {
            m_txtBox = pTxtBox;
            Title = pTitle;
        }
        /// <summary>
        /// TextBox with Title and password option
        /// </summary>
        /// <param name="pTitle">Title of the TextBox</param>
        /// <param name="pTxtBox">TextBox that you want to use</param>
        /// <param name="pBoxMode">Mode of the text box when you start. Title(true) by default.</param>
        public clsText(string pTitle, TextBox pTxtBox, BoxMode pBoxMode)
        {
            m_txtBox = pTxtBox;
            Title = pTitle;
            m_BoxMode = pBoxMode;
        }
        #endregion
    }
}
