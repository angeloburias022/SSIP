﻿using SSIP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Dashboard());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login frmMain = new Login();
            frmMain.Show();

            Application.Run();
        }
    }
}
