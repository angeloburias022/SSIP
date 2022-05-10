using SSIP.Controllers;
using SSIP.DbAccess;
using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        AccessController acc = new AccessController();
        public Login()
        {
            InitializeComponent();
        }
       
        public bool Log(string user)
        {

            return true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var creds = new User
            {
                Username = tb_uname.Text,
                Password = tb_pwd.Text
            };

            var result = acc.Login(creds);


            if (!Valid())
            {
                MessageBox.Show("Check your fields");
            }
            else
            {
                if (result != false)
                {
                    var uname = acc.GetCurrentUserDetails(tb_uname.Text);
                    dboard.Show();
                    dboard.LabelText = "Welcome \n \t \t" + uname;
                    dboard.Username = uname;
                    dboard.UserName = tb_uname.Text;

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

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_pwd.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            if (tb_uname.Text != "")
            {           
                var result = acc.GetEmail(tb_uname.Text);

                if (result.Length > 5)
                {
                    var code = GenerateCode.Code(10);
                    this.forgotPassword1.code = code;
                    this.forgotPassword1.username = tb_uname.Text;

                    var email = new Emailer
                    {
                        Subject = "Recovery Code",
                        Body = "This is your recovery code: " + "<strong><u>" + code + "</u></strong>",
                        Receiver = result
                    };

                    if (SendEmail.Send(email))
                    {
                        forgotpass_panel.Visible = true;
                        forgotpass_panel.Dock = DockStyle.Fill;
                    }
                }
                else
                {
                    MessageBox.Show("Email does not exist", "EMAIL NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                }
            }
            else
            {
                MessageBox.Show("Enter your username first", "FORGOT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
