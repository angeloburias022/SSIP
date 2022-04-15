using SSIP.Controllers;
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

namespace SSIP.Forms
{
    public partial class MainserviceForm : Form
    {
        #region property fields

        public string firstname
        {
            get
            {
                return this.tb_fname.Text;
            }
            set
            {
                this.tb_fname.Text = value;

            }
        }

        public string lastname {

            get {
                return this.tb_lname.Text;
            }
            set
            {
                this.tb_lname.Text = value;
            }
        }

        public string MobleNo { 
            get {
                return this.tb_mobile.Text;
            } set {
                this.tb_mobile.Text = value;
            } 
        }

        public string TelephoneNo {
            get {
                return this.tb_tel.Text;
            } set {
                this.tb_tel.Text = value;
            }       
        }

        public string HouseNo { 
            get {
                return this.tb_houseNo.Text;
            }
            set
            {
                this.tb_houseNo.Text = value;
            }         
        }

        public string Street { 
            get {
                return this.tb_street.Text;
            } set
            {
                this.tb_street.Text = value;
            }
        }

        public string Barangay {
            get
            {
                return this.tb_barangay.Text;
            }
            set {
                this.tb_barangay.Text = value;
            } 
        }

        public string City { 
            get {
                return this.cmb_City.Text;
            } set
            {
                this.cmb_City.Text = value;
            }
        }
        public string Status { 
            get { return this.cmb_Status.Text; }
            set { this.cmb_Status.Text = value; } 
        }

        public string CustomerID
        {
            get { return this.tb_customerID.Text; }
            set { this.tb_customerID.Text = value; }
        }


        #endregion

        ServicesController sv = new ServicesController();
        AuditController aud = new AuditController();
        public MainserviceForm()
        {
            InitializeComponent();


            if (tb_schedID.Text != "0" && tb_customerID.Text != "0")
            {
                this.btn_save.Enabled = false;
                this.btn_updateChanges.Enabled = true;
            }
            else
            {
                this.btn_save.Enabled = true;              
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
                        AssignTeam = tb_assign1.Text,
                        PaidAmount = tb_amount.Text
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
                        }
                        else
                        {
                            MessageBox.Show("Added successfully");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled Successfuly");
                }
            }
        }

        private void PasswordField()
        {
            var user = new User
            {
                Username = tb_recorded.Text,
                Password = tb_pass.Text
            };

            AccessLogin(user);
        }

        void UpdateGrids()
        {
          
        }

        #region Access security
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
                    this.btn_viewScheds.Enabled = true;
                }
                else
                {
                    this.btn_save.Enabled = true;
                    this.btn_viewDispatches.Enabled = true;
                    this.btn_viewScheds.Enabled = true;

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
                    this.btn_viewScheds.Enabled = false;
                }
                else
                {
                    this.btn_save.Enabled = false;
                    this.btn_updateChanges.Enabled = false;
                    this.btn_viewDispatches.Enabled = false;
                    this.btn_viewScheds.Enabled = false;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tb_pass_Leave(object sender, EventArgs e)
        {
            PasswordField();
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

        private void btn_updateChanges_Click(object sender, EventArgs e)
        {
            UpdateChanges();
        }

        private void UpdateChanges()
        {
            if (HighAuthority())
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
                        AssignTeam = tb_assign1.Text,
                        PaidAmount = tb_amount.Text
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

        private void tb_amount_TextChanged(object sender, EventArgs e)
        {
            if (tb_amount.Text == "")
            {

            }
        }
    }
}
