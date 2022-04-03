using SSIP.Controllers;
using SSIP.Forms;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.UserformControls
{
    public partial class DispatchesControl : UserControl
    {
        public DispatchesControl()
        {
            InitializeComponent();
        }

        AuditController aud = new AuditController();
        ServicesController sv = new ServicesController();
        private void schedgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_updateChanges_Click(object sender, EventArgs e)
        {
            UpdateChanges();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void UpdateChanges()
        {
            if (MessageBox.Show("CONFIRM?",
                      "UPDATE CHANGES", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                var dispatch = new Dispatch();
                var sched = new Schedule();
                var cus = new User();
                var per = new Customer();
                var address = new Address();


                dispatch = new Dispatch
                {
                    DispatchID = Convert.ToInt32(tb_dispatchID.Text),
                    dispatchdate = Convert.ToDateTime(dispatchDate.Text),
                    TimeIn = tb_timein.Text,
                    TimeOut = tb_timeout.Text,
                    AssignTeam = tb_assign1.Text
                };


                cus = new User
                {
                    Username = tb_recorded.Text,
                    UserID = Convert.ToInt32(tb_customerID.Text),
                    Firstname = tb_fname.Text,
                    Lastname = tb_lname.Text,
                    ContactNumber = tb_mobile.Text,
                    TelephoneNo = tb_tel.Text,

                };

                per = new Customer
                {
                    CustomerID = Convert.ToInt32(tb_customerID.Text)
                };

                sched = new Schedule
                {
                    Quantity = Convert.ToInt32(tb_quan.Text),
                    Brand = tb_brand.Text,
                    AirconType = tb_actype.Text,
                    ServiceType = cmb_svtype.Text,
                    ServiceTime = tb_svtime.Text,
                    RecordedBy = tb_recorded.Text,
                    ScheduleDate = tb_svdate.Text,
                    ScheduleID = Convert.ToInt32(tb_schedID.Text),
                    Status = cmb_Status.Text
                };

                address = new Address
                {
                    Street = tb_street.Text,
                    HouseNo = tb_houseNo.Text,
                    Barangay = tb_barangay.Text,
                    City = cmb_City.Text
                };

                ServicesController svcon = new ServicesController();


                var customerValidCon = new ValidationContext(cus, null, null);
                var addsValidCon = new ValidationContext(address, null, null);
                var schedValidCon = new ValidationContext(sched, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(cus, customerValidCon, errors, true) ||
                    !Validator.TryValidateObject(address, addsValidCon, errors, true) ||
                    !Validator.TryValidateObject(sched, schedValidCon, errors, true)
                    )
                {
                    foreach (ValidationResult val in errors)
                    {
                        MessageBox.Show(val.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    var result = svcon.UpdateService(cus, per, address, sched, dispatch);

                    if (result != true)
                    {
                        MessageBox.Show("something went wrong");


                        var failedupdate = new AuditTrails
                        {
                            Username = tb_recorded.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed update of Schedule ID: " + sched.ScheduleID + " "
                        };

                        aud.Logs(failedupdate);
                        UpdateGrids();
                    }
                    else
                    {
                        MessageBox.Show("Updated successfully");
                        UpdateGrids();
                    }
                }


            }
            else
            {
                MessageBox.Show("Cancelled Successfuly");
            }
        }
        private void Save()
        {
            if (Authorized())
            {
                if (MessageBox.Show("CONFIRM?",
                                "ADD NEW", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    int cusID = 0;
                    int schedID = 0;


                    tb_customerID.Text = "0";
                    tb_schedID.Text = "0";

                    var sched = new Schedule();

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

                    try
                    {
                        sched = new Schedule
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
                    }
                    catch (Exception error)
                    {
                        error.ToString();
                    }

                    var address = new Address
                    {
                        Street = tb_street.Text,
                        HouseNo = tb_houseNo.Text,
                        Barangay = tb_barangay.Text,
                        City = cmb_City.Text
                    };

                    var svcon = new ServicesController();

                    var customerValidCon = new ValidationContext(cus, null, null);
                    var addsValidCon = new ValidationContext(address, null, null);
                    var schedValidCon = new ValidationContext(sched, null, null);
                    IList<ValidationResult> errors = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(cus, customerValidCon, errors, true) ||
                        !Validator.TryValidateObject(address, addsValidCon, errors, true) ||
                        !Validator.TryValidateObject(sched, schedValidCon, errors, true)
                        )
                    {
                        foreach (ValidationResult val in errors)
                        {
                            MessageBox.Show(val.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        var result = svcon.AddService(cus, address, sched, dispatch);

                        if (result != true)
                        {
                            MessageBox.Show("something went wrong");

                            UpdateGrids();
                        }
                        else
                        {
                            MessageBox.Show("Added successfully");

                            UpdateGrids();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled Successfuly");
                }
            }
        }
        void UpdateGrids()
        {
            dispatchListgrid.DataSource = sv.GetSchedules();
            dispatchListgrid.Update();       
        }

        #region access
        private void PasswordField()
        {
            var user = new User
            {
                Username = tb_recorded.Text,
                Password = tb_pass.Text
            };

            AccessLogin(user);
        }
        private bool Authorized()
        {
            var user = new User
            {
                Username = tb_recorded.Text,
                Password = tb_pass.Text
            };


            var cfirm = new AccessController();

            if (user.Username != "" && user.Lastname != "")
            {
                var result = cfirm.ConfirmAccess(user);

                if (result != true)
                {
                    NotAuthorizedMssg();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Authorization Access Required");
                return false;
            }
        }
        private bool HighAuthority()
        {
            var access = new AccessController();

            var creds = new User
            {
                Username = tb_recorded.Text,
                Password = tb_pass.Text
            };

            var result = access.ConfirmAuthority(creds);

            if (result != true)
            {
                NotHighAuthorityMssg();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void NotAuthorizedMssg()
        {
            MessageBox.Show("Authorization Required");
        }
        private void NotHighAuthorityMssg()
        {
            MessageBox.Show("Higher Authoritization Required");
        }
        private bool AccessLogin(User users)
        {

            var cfirm = new AccessController();

            var result = cfirm.ConfirmAccess(users);

            if (result == true)
            {
                if (tb_dispatchID.Text != "0" || tb_schedID.Text != "0")
                {
                    this.btn_save.Visible = false;
                    this.btn_updateChanges.Visible = true;
                    this.btn_updateChanges.Enabled = true;
                    this.btn_viewDispatches.Enabled = true;
              
                }
                else
                {
                    this.btn_save.Enabled = true;
                    this.btn_viewDispatches.Enabled = true;
                

                }
                var accesslog = new AuditTrails
                {
                    Username = users.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Succeed",
                    Description = "'" + users.Username + "' accessed main services feature"
                };

                aud.Logs(accesslog);
                return true;
            }
            else
            {
                if (tb_dispatchID.Text != "0" || tb_schedID.Text != "0")
                {
                    this.btn_updateChanges.Visible = false;
                    this.btn_updateChanges.Enabled = true;
                    this.btn_viewDispatches.Enabled = false;
              
                }
                else
                {
                    this.btn_save.Enabled = false;
                    this.btn_updateChanges.Enabled = false;
                    this.btn_viewDispatches.Enabled = false;
                   
                }
                var failedaudit = new AuditTrails
                {
                    Username = tb_recorded.Text,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Failed",
                    Description = "'" + users.Username + "'failed to accessed main services feature"
                };

                aud.Logs(failedaudit);

                MessageBox.Show("Wrong password");
                return false;
            }
        }

        #endregion

        private void btn_viewDispatches_Click(object sender, EventArgs e)
        {
            ViewDispatches();
        }
        void ViewDispatches()
        { 
            this.dispatchListgrid.DataSource = sv.GetDispatches();
            dispatchList_panel.Visible = true;
            dispatchListgrid.Visible = true;
            DispatchListPanel.Visible = true;
            dispatchList_panel.Dock = DockStyle.Fill;
        }
        private void tb_recorded_TextChanged(object sender, EventArgs e)
        {
            if (tb_recorded.Text != "")
            {
                tb_pass.Enabled = true;
            }
            else
            {
                tb_pass.Enabled = false;
            }
        }
        private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Status.Text == "Dispatch")
            {
                ShowAssign();
            }
            else if (cmb_Status.Text == "Done / Paid")
            {
                ShowAssign();
                lbl_amount.Visible = true;
                tb_amount.Visible = true;
            }
            else
            {
                HideAssign();
            }
        }
        void HideAssign()
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
        void ShowAssign()
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

        private void ShowDispatch()
        {
         
            if (HighAuthority())
            {
                this.dispatchListgrid.DataSource = sv.GetDispatches();
                this.dispatchListgrid.Columns["SchedID"].Visible = false;
                this.dispatchListgrid.Columns["FirstName"].Visible = false;
                this.dispatchListgrid.Columns["LastName"].Visible = false;
                this.dispatchListgrid.Columns["Dispatch_ID"].Visible = false;
                this.dispatchListgrid.Columns["PersonID"].Visible = false;

                ClearBoxes();
                ViewDispatches();
            }
        }

        void ClearBoxes()
        {
            tb_fname.Clear();
            tb_lname.Clear();
            tb_tel.Clear();
            tb_mobile.Clear();

            tb_houseNo.Clear();
            tb_street.Clear();
            tb_barangay.Clear();
            cmb_City.ResetText();

            cmb_Status.SelectedItem = null;
            cmb_Status.SelectedText = "--select--";


            cmb_City.SelectedItem = null;
            cmb_City.SelectedText = "--select--";

            cmb_svtype.SelectedItem = null;
            cmb_svtype.SelectedText = "--select--";


            tb_actype.ResetText();
            tb_quan.Clear();
            tb_svdate.ResetText();
            tb_brand.Clear();
            tb_timein.Clear();
            tb_timeout.Clear();
            tb_assign1.Clear();
            dispatchDate.ResetText();
            tb_svtime.Clear();

            tb_customerID.Text = "0";
            tb_dispatchID.Text = "0";
            tb_schedID.Clear();


        }

        private void btn_addDispatch_Click(object sender, EventArgs e)
        {

            tb_fname.Enabled = true;
            tb_lname.Enabled = true;
            tb_mobile.Enabled = true;
            tb_tel.Enabled = true;

            cmb_Status.SelectedValue = "Dispatch";
            btn_updateChanges.Enabled = false;
            btn_save.Enabled = true;
            ShowAssign();
            ClearBoxes();
            HideDispatch();
        }

        void HideDispatch()
        {
            dispatchList_panel.Visible = false;
            DispatchListPanel.Visible = false;
            dispatchList_panel.Visible = false;
            DispatchListPanel.Dock = DockStyle.None;
        }

        private void dispatchListgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HideDispatch();



            tb_svdate.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012". 
            tb_svdate.CustomFormat = "ddd dd MMM yyyy";
            tb_schedID.Text = this.dispatchListgrid.CurrentRow.Cells[0].Value.ToString();
            tb_svdate.Value = Convert.ToDateTime(this.dispatchListgrid.CurrentRow.Cells[1].Value.ToString());
            cmb_svtype.Text = this.dispatchListgrid.CurrentRow.Cells[2].Value.ToString();
            tb_fname.Text = this.dispatchListgrid.CurrentRow.Cells[3].Value.ToString();
            tb_lname.Text = this.dispatchListgrid.CurrentRow.Cells[4].Value.ToString();

            tb_quan.Text = this.dispatchListgrid.CurrentRow.Cells[5].Value.ToString();
            tb_brand.Text = this.dispatchListgrid.CurrentRow.Cells[6].Value.ToString();
            tb_actype.Text = this.dispatchListgrid.CurrentRow.Cells[7].Value.ToString();
            tb_mobile.Text = this.dispatchListgrid.CurrentRow.Cells[8].Value.ToString();
            tb_tel.Text = this.dispatchListgrid.CurrentRow.Cells[9].Value.ToString();
            tb_houseNo.Text = this.dispatchListgrid.CurrentRow.Cells[10].Value.ToString();
            tb_street.Text = this.dispatchListgrid.CurrentRow.Cells[11].Value.ToString();
            tb_barangay.Text = this.dispatchListgrid.CurrentRow.Cells[12].Value.ToString();
            cmb_City.Text = this.dispatchListgrid.CurrentRow.Cells[13].Value.ToString();
            cmb_Status.Text = this.dispatchListgrid.CurrentRow.Cells[14].Value.ToString();
            tb_svtime.Text = this.dispatchListgrid.CurrentRow.Cells[15].Value.ToString();

            tb_customerID.Text = this.dispatchListgrid.CurrentRow.Cells[16].Value.ToString();
            tb_dispatchID.Text = this.dispatchListgrid.CurrentRow.Cells[17].Value.ToString();
            tb_timein.Text = this.dispatchListgrid.CurrentRow.Cells[18].Value.ToString();
            tb_timeout.Text = this.dispatchListgrid.CurrentRow.Cells[19].Value.ToString();
            tb_assign1.Text = this.dispatchListgrid.CurrentRow.Cells[20].Value.ToString();
            dispatchDate.Format = DateTimePickerFormat.Custom;
            dispatchDate.CustomFormat = "ddd dd MMM yyyy";
            var dispatchdateNull = this.dispatchListgrid.CurrentRow.Cells[21].Value.ToString();
            tb_amount.Text = this.dispatchListgrid.CurrentRow.Cells[22].Value.ToString();


            if (dispatchdateNull == "")
            {
                dispatchDate.Value = Convert.ToDateTime("12/23/23");
            }
            else
            {
                dispatchDate.Value = Convert.ToDateTime(this.dispatchListgrid.CurrentRow.Cells[21].Value.ToString());

            }


            if (tb_dispatchID.Text != "0")
            {
                btn_updateChanges.Enabled = true;
                btn_save.Enabled = false;

                DisabledPersonInfoFields();
                ShowAssign();

                if (tb_amount.Text != "")
                {

                    lbl_amount.Visible = true;
                    tb_amount.Visible = true;
                }
                else
                {
                    lbl_amount.Visible = false;
                    tb_amount.Visible = false;
                }
            }

        }

        void DisabledPersonInfoFields()
        {
            tb_fname.Enabled = false;
            tb_lname.Enabled = false;
            tb_tel.Enabled = false;
            tb_mobile.Enabled = false;
        }

        private void tb_quan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
