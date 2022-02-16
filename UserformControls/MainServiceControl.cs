using SSIP.AccessControls;
using SSIP.Controllers;
using SSIP.Forms;
using SSIP.Models;
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

namespace SSIP.UserForms
{
    public partial class MainServiceControl : UserControl
    {

        #region initiliazer
        public MainServiceControl()
        {
            InitializeComponent();

            this.securityForm1.Visible = false;
            this.btn_save.Enabled = false;
        }

        private void MainServiceControl_Load(object sender, EventArgs e)
        {
            dispatchListgrid.DataSource = GetDispatches();
            schedgrid.DataSource = GetSchedules();
        }

        #endregion

        #region private fields

        //protected static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //protected DataTable dt = new DataTable();

        //protected DataSet ds = new DataSet();

        #endregion

        #region save service (dispatch/schedule)
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("CONFIRM?",
               "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                int cusID = 0;
                int schedID = 0;

                cusID = Convert.ToInt32(tb_customerID.Text);
                schedID = Convert.ToInt32(tb_schedID.Text);

                var cus = new User
                {
                    Username = tb_recorded.Text,
                    UserID = cusID,
                    Firstname = tb_fname.Text,
                    Lastname = tb_lname.Text,
                    ContactNumber = tb_mobile.Text,
                    TelephoneNo = tb_tel.Text,
                };

                var dispatch = new Dispatch
                {
                    dispatchdate = Convert.ToDateTime(dispatchDate.Text),
                    TimeIn = tb_timein.Text,
                    TimeOut = tb_timeout.Text,
                    AssignTeam = tb_assign1.Text
                };

                var sched = new Schedule
                {
                    Quantity = Convert.ToInt32(tb_quan.Text),
                    Brand = tb_brand.Text,
                    AirconType = tb_actype.Text,
                    ServiceType = cmb_svtype.Text,
                    ServiceTime = tb_svtime.Text,
                    RecordedBy = tb_recorded.Text,
                    ScheduleDate = tb_svdate.Text,
                    ScheduleID = schedID,
                    Status = cmb_Status.Text
                };

                var address = new Address
                {
                    Street = tb_street.Text,
                    HouseNo = tb_houseNo.Text,
                    Barangay = tb_barangay.Text,
                    City = cmb_City.Text
                };

                ServicesController svcon = new ServicesController();

                var result = svcon.AddService(cus, address, sched, dispatch);

                if (result != true)
                {
                    MessageBox.Show("something went wrong");
                }
                else
                {
                    MessageBox.Show("Added successfully");
                }

            }
            else
            {
                MessageBox.Show("Cancelled Successfuly");
            }
        }
        #endregion

        #region credentials confirmation
        private void tb_recorded_Leave(object sender, EventArgs e)
        {
            //  this.dispatchControl1.Visible = false;
            //this.securityForm1.BringToFront();
            //this.securityForm1.Visible = true;
            //this.securityForm1.Dock = DockStyle.Fill;
            var user = new User
            {
                Username = tb_recorded.Text
            };

            var acc = new AccessController();

            var result = acc.CheckUsername(user);

            if (result == true)
            {
                this.tb_pass.Show();

            }
            else
            {

                this.tb_pass.Hide();

                MessageBox.Show("Make sure you inputted your corrent Username");
            }

        }

        private void tb_pass_Leave(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = tb_recorded.Text,
                Password = tb_pass.Text
            };

            var acc = new AccessController();

            var result = acc.Login(user);

            if (result == true)
            {
                this.btn_save.Enabled = true;
            }
            else
            {
                this.btn_save.Enabled = false;

                MessageBox.Show("Wrong password");
            }
        }
        #endregion

        #region show and hide based on service status
        private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Status.Text == "Dispatch")
            {
                tb_assign1.Visible = true;
                lbl_assign.Visible = true;
                lbl_timein.Visible = true;
                lbl_timeout.Visible = true;
                tb_timein.Visible = true;
                tb_timeout.Visible = true;
                dispatchDate.Visible = true;
                lbl_dispatchDate.Visible = true;
            }
            else
            {
                tb_assign1.Visible = false;
                lbl_assign.Visible = false;
                lbl_timein.Visible = false;
                lbl_timeout.Visible = false;
                tb_timein.Visible = false;
                tb_timeout.Visible = false;
                dispatchDate.Visible = false;
                lbl_dispatchDate.Visible = false;
            }
        }

        #endregion

        #region Get sched and dispatch 
        public DataTable GetDispatches()
        {

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            try
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
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return dt;
        }

        public DataTable GetSchedules()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            try
            {


                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetSchedules]", con))
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
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

            return dt;
        }
        #endregion

        #region cell double click
        private void schedgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HideSched();
            try
            {

                tb_svdate.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012". 
                tb_svdate.CustomFormat = "ddd dd MMM yyyy";
                tb_schedID.Text = this.schedgrid.CurrentRow.Cells[0].Value.ToString();
                tb_svdate.Value = Convert.ToDateTime(this.schedgrid.CurrentRow.Cells[1].Value.ToString());
                cmb_svtype.Text = this.schedgrid.CurrentRow.Cells[2].Value.ToString();
                tb_fname.Text = this.schedgrid.CurrentRow.Cells[3].Value.ToString();
                tb_lname.Text = this.schedgrid.CurrentRow.Cells[4].Value.ToString();
                tb_quan.Text = this.schedgrid.CurrentRow.Cells[5].Value.ToString();
                tb_brand.Text = this.schedgrid.CurrentRow.Cells[6].Value.ToString();
                tb_actype.Text = this.schedgrid.CurrentRow.Cells[7].Value.ToString();
                tb_mobile.Text = this.schedgrid.CurrentRow.Cells[8].Value.ToString();
                tb_tel.Text = this.schedgrid.CurrentRow.Cells[9].Value.ToString();
                tb_houseNo.Text = this.schedgrid.CurrentRow.Cells[10].Value.ToString();
                tb_street.Text = this.schedgrid.CurrentRow.Cells[11].Value.ToString();
                tb_barangay.Text = this.schedgrid.CurrentRow.Cells[12].Value.ToString();
                cmb_City.Text = this.schedgrid.CurrentRow.Cells[13].Value.ToString();
                cmb_Status.Text = this.schedgrid.CurrentRow.Cells[14].Value.ToString();
                tb_svtime.Text = this.schedgrid.CurrentRow.Cells[15].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("something went wrong " + error);
            }
        }
        private void dispatchListgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HideDispatch();
            try
            {
                MessageBox.Show("clicked");
                tb_schedID.Text = this.dispatchListgrid.CurrentRow.Cells[0].Value.ToString();
                //tb_svdate.Value = Convert.ToDateTime(this.schedgrid.CurrentRow.Cells[1].Value.ToString());
                //cmb_svtype.Text = this.schedgrid.CurrentRow.Cells[2].Value.ToString();
                //tb_fname.Text = this.schedgrid.CurrentRow.Cells[3].Value.ToString();
                //tb_lname.Text = this.schedgrid.CurrentRow.Cells[4].Value.ToString();
                //tb_quan.Text = this.schedgrid.CurrentRow.Cells[5].Value.ToString();
                //tb_brand.Text = this.schedgrid.CurrentRow.Cells[6].Value.ToString();
                //tb_actype.Text = this.schedgrid.CurrentRow.Cells[7].Value.ToString();
                //tb_mobile.Text = this.schedgrid.CurrentRow.Cells[8].Value.ToString();
                //tb_tel.Text = this.schedgrid.CurrentRow.Cells[9].Value.ToString();
                //tb_houseNo.Text = this.schedgrid.CurrentRow.Cells[10].Value.ToString();
                //tb_street.Text = this.schedgrid.CurrentRow.Cells[11].Value.ToString();
                //tb_barangay.Text = this.schedgrid.CurrentRow.Cells[12].Value.ToString();
                //cmb_City.Text = this.schedgrid.CurrentRow.Cells[13].Value.ToString();
                //cmb_Status.Text = this.schedgrid.CurrentRow.Cells[14].Value.ToString();
                //tb_svtime.Text = this.schedgrid.CurrentRow.Cells[15].Value.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("something went wrong " + error);
            }
        }

        #endregion

        #region Add new sched and dispatch
        private void btn_addDispatch_Click(object sender, EventArgs e)
        {
            HideDispatch();
        }
        private void btn_addsched_Click(object sender, EventArgs e)
        {
            HideSched();
        }
        #endregion

        #region hide and view services panels
        private void btn_viewDispatches_Click(object sender, EventArgs e)
        {
            ViewDispatches();
        }

        private void btn_viewScheds_Click(object sender, EventArgs e)
        {
            ViewSchedules();
        }
        void ViewSchedules()
        {
            schedListTablePanel.Visible = true;
            schedgrid.Visible = true;
            schedMainPanel.Visible = true;
            schedMainPanel.Dock = DockStyle.Fill;
        }
        void ViewDispatches()
        {
            dispatchList_panel.Visible = true;
            dispatchListgrid.Visible = true;
            DispatchListPanel.Visible = true;
            dispatchList_panel.Dock = DockStyle.Fill;         
        }
        void HideDispatch()
        {
            dispatchList_panel.Visible = false;
            DispatchListPanel.Visible = false;
            dispatchList_panel.Visible = false;
            DispatchListPanel.Dock = DockStyle.None;
        }
        void HideSched()
        {
            schedListTablePanel.Visible = false;
            schedMainPanel.Visible = false;
            schedgrid.Visible = false;
            schedMainPanel.Dock = DockStyle.None;

        }
        #endregion

    }
}
