using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using SSIP.Controllers;
using SSIP.Models;
using ZXing;

namespace SSIP.UserformControls
{
    public partial class AttendanceControl : UserControl
    {

        #region declaration
        FilterInfoCollection filterinfocollection;
        VideoCaptureDevice captureDevice;
        AuditController aud = new AuditController();
        EmployeesController emp = new EmployeesController();
        public AttendanceControl()
        {
            InitializeComponent();

            attendanceGrid.Visible = false;
            btn_addAttendance.Visible = false;
            //   TimePicker();
        }
        #endregion

        #region main ops     
        public void GetEmployee(string code)
        {
            var tools = new EmployeesController();

            var result = tools.GetEmployeeName(code);

            tb_fname.Text = result[0].ToString();
            tb_lname.Text = result[1].ToString();
            tb_employeeID.Text = result[2].ToString();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            var tools = new EmployeesController();

            var result = tools.AddAttendance(tb_employeeID.Text, tb_timein.Text, tb_timeout.Text, workdate.Value, tb_totalHrs.Text);

            if (result != true)
            {
                MessageBox.Show("Something went wrong");
            }
            else
            {
                ClearFields();
                MessageBox.Show("Attendance Recorded");

                // audit 
            }

        }
        private void btn_scan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterinfocollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }
        private void btn_updateChanges_Click(object sender, EventArgs e)
        {
            var tools = new EmployeesController();

            if (HighAuthority())
            {
                btn_updateChanges.Enabled = true;
                var result = tools.UpdateAttendance(tb_employeeID.Text, tb_timein.Text, tb_timeout.Text, tb_totalHrs.Text, workdate.Value);

                if (result != false)
                {
                    MessageBox.Show("Attendance Updated");
                }
                else
                {
                    MessageBox.Show("Something wennt wrong");
                }
            }
            else
            {
                MessageBox.Show("Higher authorization access required");
                btn_updateChanges.Enabled = false;
                HideGRID();
            }

        }

        #endregion

        #region access
        private void tb_pass_Leave(object sender, EventArgs e)
        {
            var creds = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };

            var result = AccessLogin(creds);

            if (result != true)
            {
                MessageBox.Show("Make sure your credentials is correct");
                btn_save.Enabled = false;
                btn_scan.Enabled = false;
                btn_viewAttendances.Enabled = false;

            }
            else
            {
                btn_save.Enabled = true;
                btn_scan.Enabled = true;
                btn_viewAttendances.Enabled = true;
            }
        }

        public bool AccessLogin(User users)
        {
            var user = new User
            {
                Username = users.Username,
                Password = users.Password
            };


            var cfirm = new AccessController();

            var result = cfirm.ConfirmAccess(user);

            if (result == true)
            {
                if (HighAuthority())
                {
                    btn_updateChanges.Enabled = true;
                }

                btn_save.Enabled = true;
                btn_scan.Enabled = true;
                btn_viewAttendances.Enabled = true;
                var accesslog = new AuditTrails
                {
                    Username = user.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Succeed",
                    Description = "'" + user.Username + "' accessed Attendance feature"
                };
                aud.Logs(accesslog);
                return true;
            }
            else
            {
                var accesslog = new AuditTrails
                {
                    Username = user.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Failed",
                    Description = "'" + user.Username + "'Failed to access Attendance feature"
                };
                aud.Logs(accesslog);
                return false;
            }
        }

        private bool HighAuthority()
        {
            var access = new AccessController();

            var user = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };

            var result = access.ConfirmAuthority(user);

            if (result != false)
            {
                return true;
            }
            else
                return false;

        }
        #endregion

        #region others
        private void CaptureDevice_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pb_qrcode.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_qrcode.Image != null)
            {

                BarcodeReader barcodeReader = new BarcodeReader();


                Result result = barcodeReader.Decode((Bitmap)pb_qrcode.Image);
                timer1.Stop();

                if (result != null)
                {
                    tb_DisplayQR.Text = result.ToString();
                    GetEmployee(tb_DisplayQR.Text);
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
                else
                {
                    timer1.Start();
                }
            }
        }
        private void AttendanceControl_Load(object sender, EventArgs e)
        {
          
            //  attendanceMainpanel.Update();
            tb_DisplayQR.ReadOnly = true;
            tb_fname.ReadOnly = true;
            tb_lname.ReadOnly = true;
            tb_employeeID.ReadOnly = true;
            filterinfocollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterinfocollection)
                cboDevice.Items.Add(filter);

            cboDevice.SelectedIndex = 0;
                
        }
        private void AttendanceControl_Leave(object sender, EventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning)
                    captureDevice.Stop();
            }
            catch (Exception error)
            {

                error.ToString();
            }
            
        }
        private void tb_timeout_Leave(object sender, EventArgs e)
        {
            if (tb_timeout.Text != "")
            {
                tb_totalHrs.Visible = true;
                lbl_totalworkhrs.Visible = true;
            }
        }
        private void btn_viewAttendances_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                DisplayGRID();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Higher authorization access required");
            }   
        }
        private void btn_addAttendance_Click(object sender, EventArgs e)
        {
            ClearFields();
            HideGRID();
        }
        private void tb_searchAttendances_TextChanged(object sender, EventArgs e)
        {
            var tool = new EmployeesController();

            var result = tool.FindAttendance(tb_searchAttendances.Text);

            attendanceGrid.DataSource = result;


            if (tb_searchAttendances.Text == "")
            {
                UpdateGrid();
            }

        }
        private void tb_searchAttendances_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

        }
        public void DisplayGRID()
        {
            attendanceGrid.DataSource = emp.GetAttendance();
            attendanceGrid.Visible = true;
            btn_addAttendance.Visible = true;
            attendanceMainpanel.Visible = true;
            attendanceMainpanel.Dock = DockStyle.Fill;
            attendanceMainpanel.BringToFront();
            
           
        }
        public void UpdateGrid()
        {
            attendanceGrid.DataSource = emp.GetAttendance();
            attendanceGrid.Update();
        }
        public void HideGRID()
        {
         
            attendanceMainpanel.Visible = false;
            attendanceMainpanel.Dock = DockStyle.None;
          
          
        }
        public void ClearFields()
        {
            tb_employeeID.Clear();
            tb_fname.Clear();
            tb_lname.Clear();
            tb_totalHrs.Clear();
            tb_DisplayQR.Clear();
            tb_timein.Clear();
            tb_timeout.Clear();
            workdate.Value = DateTime.Now;
        }
        public void TimePicker()
        {
            //time_in = new Guna.UI2.WinForms.Guna2DateTimePicker
            //{
            //    Format = DateTimePickerFormat.Time,
            //    ShowUpDown = true,
            //    Location = new Point(12, 25)
            //};
            //Controls.Add(time_in);


            //time_out = new Guna.UI2.WinForms.Guna2DateTimePicker
            //{
            //    Format = DateTimePickerFormat.Time,
            //    ShowUpDown = true,
            //    Location = new Point(240, 25)
            //};
            //Controls.Add(time_out);
            //lbl_timein = new Label
            //{
            //    Location = new Point(12, 10)
            //};

            //Controls.Add(lbl_timein);

            //lbl_timeout = new Label
            //{
            //    Location = new Point(12, 10)
            //};

            //Controls.Add(lbl_timeout);
        }
        private void attendanceGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HideGRID();
            tb_fname.Text = this.attendanceGrid.CurrentRow.Cells[1].Value.ToString();
            tb_lname.Text = this.attendanceGrid.CurrentRow.Cells[2].Value.ToString();
            tb_timein.Text = this.attendanceGrid.CurrentRow.Cells[3].Value.ToString();
            tb_timeout.Text = this.attendanceGrid.CurrentRow.Cells[4].Value.ToString();

            if (tb_timeout.Text != "")
            {
                lbl_totalworkhrs.Visible = true;
                tb_totalHrs.Visible = true;
            }
            else
            {
                lbl_totalworkhrs.Visible = false;
                tb_totalHrs.Visible = false;
            }


            tb_totalHrs.Text = this.attendanceGrid.CurrentRow.Cells[5].Value.ToString();
            workdate.Value = Convert.ToDateTime(this.attendanceGrid.CurrentRow.Cells[6].Value.ToString());
            tb_employeeID.Text = this.attendanceGrid.CurrentRow.Cells[8].Value.ToString();
        }

        #endregion

    }
}
