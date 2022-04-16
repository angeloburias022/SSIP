using SSIP.Controllers;
using SSIP.Forms;
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

namespace SSIP.UserformControls
{
    public partial class ForgotPassword : UserControl
    {
        AuditController aud = new AuditController();
        public string code { 
            get {
                return lbl_code.Text;
            } set {
                lbl_code.Text = value;
            } 
        }

        public string username
        {
            get
            {
                return lbl_username.Text;
            }
            set
            {
                lbl_username.Text = value;
            }
        }

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (code != tb_Code.Text)
            {
                MessageBox.Show("Invalid code", "INVALID CODE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                changePassPanel.Visible = true;
                changePassPanel.Dock = DockStyle.Fill;
            }
        }

        private void tb_confirm_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            if (tb_confirm.Text != tb_newPass.Text)
            {
                MessageBox.Show("New password and Confirm password is not the same", "CHECK YOUR FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                var tools = new AccessController();
                var creds = new User { Username = username, Password = tb_confirm.Text };

                if (tools.UpdatePassword(creds))
                {
                    MessageBox.Show("Password Successfuly changed!", "NEW PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var logs = new AuditTrails
                    {
                        Username = username,
                        AuditActionTypeENUM = (Enums.ActionTypes)10,
                        DateTimeStamp = DateTime.Now.ToString(),
                        Result = "Succeed",
                        Description = " " + username + " changed password"
                    };

                    aud.Logs(logs);

                    this.ParentForm.Close();

                    Login log = new Login();
                    log.Show();
                }
            }       
        }

        private void tb_newPass_TextChanged(object sender, EventArgs e)
        {
            if (tb_newPass.Text.Length > 1)
            {
                tb_confirm.Enabled = true;
            }
        }
    }
}
