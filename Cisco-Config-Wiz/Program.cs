using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cisco_Config_Wiz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //CHECK: Enlever Application.EnableVisualStyles(); pour plus de swag Win95
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
