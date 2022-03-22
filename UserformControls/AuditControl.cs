using SSIP.Controllers;
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
    }
}
