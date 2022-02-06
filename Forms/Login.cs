using SSIP.Controllers;
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
        private readonly Dashboard _dboard;
     
        public Login()
        {
            InitializeComponent();
        }

        public  Login(Dashboard dboard)
        {
            _dboard = dboard;
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var creds = new User
            {
                Username = tb_uname.Text,
                Password = tb_pwd.Text
            };

            var acc = new AccessController();

            var result = acc.Login(creds);

            if(result == true)
            {
                this.Close();
          
                dboard.Show();
            }

        }
    }
}
