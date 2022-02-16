using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.UserformControls
{
    public partial class DispatchListControl : UserControl
    {

        private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        private DataTable dt = new DataTable();

        private DataSet ds = new DataSet();
        public DispatchListControl()
        {
            InitializeComponent();
        }

        private void btn_viewDispatches_Click(object sender, EventArgs e)
        {
            //this.dispatch_panel

            //this.dispatchControl1.Visible = false;
            //this.mainServiceControl.BringToFront();
            //this.disc.Visible = false;

            //DispatchListControl.

        }


        public DataTable GetDispatch()
        {

            using (SqlConnection con = new SqlConnection(ConString))
            {
                using (SqlCommand com = new SqlCommand("[SpGetDispatched]", con))
                {
                    com.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        ds.Clear();
                        adapter.Fill(ds);

                        dt = ds.Tables[0];
                        con.Close();

                    }
                }
            }
            return dt;
        }

        private void DispatchListControl_Load(object sender, EventArgs e)
        {
            dispatchGrid.DataSource = GetDispatch();
        }
    }
}
