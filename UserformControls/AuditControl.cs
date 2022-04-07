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

namespace SSIP.UserformControls
{
    public partial class AuditControl : UserControl
    {
        AuditController aud = new AuditController();
        public AuditControl()
        {
            InitializeComponent();
            GetAudits();
        }
        private void GetAudits()
        {
            auditGrid.DataSource = aud.GetAudits();
            this.auditGrid.Columns["AuditActionTypeENUM"].Visible = false;
        }
        private void UpdateGrid()
        {
            auditGrid.DataSource = aud.GetAudits();
            auditGrid.Update();
        }

        private void AuditControl_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text.Length != 0)
            {
                tb_pass.Enabled = true;
            }
            else
            {
                tb_pass.Enabled = false;
            }
        }

        private void btn_access_Click(object sender, EventArgs e)
        {
            var creds = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };
            

            if (Access.HighAuthorityAccess(creds))
            {
                access_panel.Visible = false;
            }
            else
            {
                access_panel.Visible = false;
            }
        }
    }
}
