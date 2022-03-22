﻿using SSIP.Controllers;
using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.Forms
{
    public partial class Login : Form
    {
        Dashboard dboard = new Dashboard();
       

        public Login()
        {
            InitializeComponent();
        }

        

        private void btn_login_Click(object sender, EventArgs e)
        {
            var creds = new User
            {
                Username = tb_uname.Text,
                Password = tb_pwd.Text
            };
            
            if (!Valid())
            {
                MessageBox.Show("Check your fields");
                
            } else
            {
                var acc = new AccessController();
                var result = acc.Login(creds);

                if (result != false)
                {
                                    
                    dboard.Show();
                    dboard.LabelText ="Welcome "+acc.GetCurrentUserDetails(tb_uname.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your password or Username might incorrect.");
                }
            }


        }


        #region login field validation
        public bool Valid()
        {

            if (tb_pwd.Text != "" && tb_uname.Text != "")
            {
                return true;
            }
            else
                return false;

        }
        #endregion

    }
}
