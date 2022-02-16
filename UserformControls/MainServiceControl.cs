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
      
        public MainServiceControl()
        {
            InitializeComponent();
            this.securityForm1.Visible = false;
            this.btn_save.Enabled = false;
        }

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

                if(result != true)
                {
                    MessageBox.Show("something went wrong");
                }else
                {
                    MessageBox.Show("Added successfully");
                }

            }
            else
            {
                MessageBox.Show("Cancelled Successfuly");
            }
        }
        private void btn_updateSched_Click(object sender, EventArgs e)
        {
            //btn_save_Click(sender, e);
        }

        private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Status.Text == "Dispatch")
            {
                tb_assign1.Visible = true;
                lbl_assign.Visible = true;
                lbl_timein.Visible = true;
                lbl_timeout.Visible = true;
                tb_timein.Visible = true;
                tb_timeout.Visible = true;
                dispatchDate.Visible = true;
                lbl_dispatchDate.Visible = true;
            }else
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


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainServiceControl_Load(object sender, EventArgs e)
        {

        }

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

            if(result == true)
            {
                this.tb_pass.Show();
          
            }else
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

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btn_viewDispatches_Click(object sender, EventArgs e)
        {
            dispatchList_panel.Visible = true;
            dispatchList_panel.Dock = DockStyle.Fill;
        }
    }
}
