using SSIP.Controllers;
using SSIP.Models;
using SSIP.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.AccessControls
{
    public partial class SecurityForm : UserControl
    {
        public int ActionType { get; set; }
        public SecurityForm()
        {
            InitializeComponent();
        }

        private void btn_access_Click(object sender, EventArgs e)
        {

            var user = new User
            {
                Username = tb_uname.Text,
                Password = tb_password.Text
            };

            var _access = new AccessController();

            bool logs = _access.Login(user);
            
            if(logs == true)
            {
                this.Hide();
                Clear();
                EnableTxtBox();
            }else
            {
                DisableTxtBox();
            }

        }

        public void DisableTxtBox()
        {

          //  ms.tb_fname.Enabled = false;
        }

        public void EnableTxtBox()
        {

         //   ms.tb_fname.Enabled = true;
        }




        private void login_panel_Paint(object sender, PaintEventArgs e)
        {
            login_panel.Left = (this.ClientSize.Width - login_panel.Width) / 2;
            login_panel.Top = (this.ClientSize.Height - login_panel.Height) / 2;
        }

        #region Clear fields
        void Clear()
        {
            tb_uname.Clear();
            tb_password.Clear();
        }
        #endregion

    }
}
