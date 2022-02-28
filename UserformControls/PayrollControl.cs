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
    public partial class PayrollControl : UserControl
    {
        public PayrollControl()
        {
            InitializeComponent();
        }

        private void tb_workhrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            var tool = new PayRollController();

            var result = tool.Filter(tb_empName.Text, date_from.Value, date_to.Value);

            empGrid.DataSource = result;

        }
    }
}
