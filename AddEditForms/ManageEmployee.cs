using SSIP.Controllers;
using SSIP.Helper;
using SSIP.Models;
using SSIP.UserformControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.AddEditForms
{
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        QRCodeControl qr = new QRCodeControl();
        EmployeesController emp = new EmployeesController();
        AuditController aud = new AuditController();
        AccessController ac = new AccessController();

        #region fields
        public string EmployeeID
        {
            get
            {
                return tb_empID.Text;
            }
            set
            {
                this.tb_empID.Text = value;
            }
        }
  
        public string PersonID
        {
            get
            {
                return tb_personID.Text;
            }
            set
            {
                this.tb_personID.Text = value;
            }
        }
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
        public string lastname
        {
            get
            {
                return this.tb_lname.Text;
            }
            set
            {
                this.tb_lname.Text = value;
            }
        }
        public string MobleNo
        {
            get
            {
                return this.tb_mobile.Text;
            }
            set
            {
                this.tb_mobile.Text = value;
            }
        }
        public string TelephoneNo
        {
            get
            {
                return this.tb_tel.Text;
            }
            set
            {
                this.tb_tel.Text = value;
            }
        }
        public string HouseNo
        {
            get
            {
                return this.tb_houseNo.Text;
            }
            set
            {
                this.tb_houseNo.Text = value;
            }
        }
        public string Street
        {
            get
            {
                return this.tb_street.Text;
            }
            set
            {
                this.tb_street.Text = value;
            }
        }
        public string Barangay
        {
            get
            {
                return this.tb_barangay.Text;
            }
            set
            {
                this.tb_barangay.Text = value;
            }
        }
        public string City
        {
            get
            {
                return this.cmb_City.Text;
            }
            set
            {
                this.cmb_City.Text = value;
            }
        }
        public int AccountType
        {
            get
            {
                return this.cmb_acctype.SelectedIndex;
            }
            set
            {
                this.cmb_acctype.SelectedIndex = value;
            }
        }
        public string Status
        {
            get
            {
                return this.cmb_empStatus.Text;
            }
            set
            {
                this.cmb_empStatus.Text = value;
            }
        }
        public string Email
        {
            get
            {
                return this.tb_email.Text;
            }
            set
            {
                this.tb_email.Text = value;
            }
        }
        public string Position
        {
            get
            {
                return this.tb_position.Text;
            }
            set
            {
                this.tb_position.Text = value;
            }
        }

        public string DateHired
        {
            get
            {
                return this.tb_datehired.Text;
            }
            set
            {
                this.tb_datehired.Text = value;
            }
        }

        public string Username { get { return tb_unameAccess.Text; } set { tb_unameAccess.Text = value; } }
        public string Password { get { return tb_pass.Text; } set { tb_pass.Text = value; } }
        public string ManageLabel { get { return lbl_ManageEmp.Text; } set { this.lbl_ManageEmp.Text = value; } }

        #endregion

        private void btn_saveAcc_Click(object sender, EventArgs e)
        {
            if (tb_empID.Text == "0")
            {
                SaveAcc();
            }
        }

        private void btn_updateAccount_Click(object sender, EventArgs e)
        {
            if (tb_empID.Text != "0")
            {
                UpdateAcc();
            }
            else
            {
                btn_updateAccount.Enabled = false;
            }
        }

        void ClearBoxes()
        {
            tb_empID.Text = "0";
            tb_personID.Text = "0";

            tb_fname.Clear();
            tb_lname.Clear();
            tb_tel.Clear();
            tb_mobile.Clear();

            tb_houseNo.Clear();
            tb_street.Clear();
            tb_barangay.Clear();
            //    cmb_City.ResetText();
            cmb_City.SelectedItem = null;
            cmb_City.SelectedText = "--select--";


            cmb_empStatus.SelectedItem = null;
            cmb_empStatus.SelectedText = "--select--";

            cmb_acctype.SelectedItem = null;
            cmb_acctype.SelectedText = "--select--";

            tb_position.Clear();
            tb_uname.Clear();
            tb_password.Clear();
            tb_email.Clear();

        }

        void UpdateGrids()
        {
           
        }

        public void Reset()
        {
            tb_empID.Clear();
            tb_personID.Clear();

            tb_fname.Clear();
            tb_lname.Clear();
            tb_tel.Clear();
            tb_mobile.Clear();

            tb_houseNo.Clear();
            tb_street.Clear();
            tb_barangay.Clear();
            //    cmb_City.ResetText();
            cmb_City.SelectedItem = null;
            cmb_City.SelectedText = "--select--";


            cmb_empStatus.SelectedItem = null;
            cmb_empStatus.SelectedText = "--select--";

            cmb_acctype.SelectedItem = null;
            cmb_acctype.SelectedText = "--select--";

            tb_position.Clear();
            tb_uname.Clear();
            tb_password.Clear();
            tb_email.Clear();


            tb_unameAccess.Clear();
            tb_pass.Clear();


            //employeeMainPanel.Visible = false;
            //employeeGrid.DataSource = null;
            //employeeGrid.Update();
            //tb_searchEmployees.Clear();


            //employeeMainPanel.Visible = false;
        }

        private void checkUsernameUniqueness()
        {
            var result = ac.UsernameUnique(tb_uname.Text);
            if (result.Count > 0)
            {
                btn_saveAcc.Enabled = false;
                MessageBox.Show("Username already exist", "Think another one", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btn_saveAcc.Enabled = true;
            }
        }

        #region main operation
        private void SaveAcc()
        {
            if (HighAuthority())
            {
                #region fields

               
                var details = new Employee();

                var user_info = new User
                {
                    Username = tb_uname.Text,
                    Password = tb_password.Text,
                    Firstname = tb_fname.Text,
                    Lastname = tb_lname.Text,
                    ContactNumber = tb_mobile.Text,
                    TelephoneNo = tb_tel.Text
                };

                var addrss_info = new Address
                {
                    HouseNo = tb_houseNo.Text,
                    Street = tb_street.Text,
                    Barangay = tb_barangay.Text,
                    City = cmb_City.Text
                };

                var email_info = new Email
                {
                    EmailAddress = tb_email.Text
                };




                #endregion

                #region validations
                if (Valid.ValidateFields(user_info) && Valid.ValidateFields(addrss_info) && Valid.ValidateFields(email_info))
                {


                    details.user_info.Username = user_info.Username;
                    details.user_info.Password = user_info.Password;
                    details.user_info.Firstname = user_info.Firstname;
                    details.user_info.Lastname = user_info.Lastname;
                    details.user_info.ContactNumber = user_info.ContactNumber;
                    details.user_info.TelephoneNo = user_info.TelephoneNo;

                    details.email_info.EmailAddress = email_info.EmailAddress;

                    details.address_info.HouseNo = addrss_info.HouseNo;
                    details.address_info.Street = addrss_info.Street;
                    details.address_info.Barangay = addrss_info.Barangay;
                    details.address_info.City = addrss_info.City;

                    details.DateHired = Convert.ToDateTime(tb_datehired.Text);
                    details.Position = tb_position.Text;
                    details.TypeOfContract = "None";
                    details.AccountTypeID = cmb_acctype.SelectedIndex;
                    details.EmployeeStatus = cmb_empStatus.Text;


                    string randomCode = GenerateCode.Code(10);

                    this.qrCodeControl1.GetDetails(randomCode, tb_fname.Text, tb_lname.Text, tb_position.Text);

                    tb_qrcode.Text = randomCode;

                    details.code = tb_qrcode.Text;

                    var result = emp.AddEmployee(details);

                    if (result != true)
                    {
                        MessageBox.Show("Something went wrong");

                        var failed = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)3,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed to add new Employee"
                        };

                        aud.Logs(failed);
                    }
                    else
                    {
                        MessageBox.Show("Added Successfully!");

                        btn_saveAcc.Enabled = true;

                        var addEmployee = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)3,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Succeed",
                            Description = "Added new Employee"
                        };


                        this.qrCodeControl1.Visible = true;
                        this.qrCodeControl1.Dock = DockStyle.Fill;
                        this.qrCodeControl1.BringToFront();

                        aud.Logs(addEmployee);
                        UpdateGrids();
                        ClearBoxes();
                    }
                }
                #endregion

            }
        }
        private void UpdateAcc()
        {
            if (HighAuthority())
            {

                var details = new Employee();

                #region fields


                #region fields

                var user_info = new User
                {
                    UserID = Convert.ToInt32(tb_personID.Text),
                    Username = tb_unameAccess.Text,
                    Firstname = tb_fname.Text,
                    Lastname = tb_lname.Text,
                    ContactNumber = tb_mobile.Text,
                    TelephoneNo = tb_tel.Text
                };

                var addrss_info = new Address
                {
                    HouseNo = tb_houseNo.Text,
                    Street = tb_street.Text,
                    Barangay = tb_barangay.Text,
                    City = cmb_City.Text
                };

                var email_info = new Email
                {
                    EmailAddress = tb_email.Text
                };

                #endregion

                details.EmployeeID = Convert.ToInt32(tb_empID.Text);
                details.DateHired = Convert.ToDateTime(tb_datehired.Text);
                details.Position = tb_position.Text;
                details.AccountTypeID = cmb_acctype.SelectedIndex;
                details.EmployeeStatus = cmb_empStatus.Text;

                #endregion

                #region validations
                if (Valid.ValidateFields(user_info) && Valid.ValidateFields(addrss_info) && Valid.ValidateFields(email_info) && Valid.ValidateFields(details))
                {
                    details.user_info.UserID = user_info.UserID;
                    details.user_info.Firstname = user_info.Firstname;
                    details.user_info.Lastname = user_info.Lastname;
                    details.user_info.ContactNumber = user_info.ContactNumber;
                    details.user_info.TelephoneNo = user_info.TelephoneNo;

                    details.address_info.HouseNo = addrss_info.HouseNo;
                    details.address_info.Street = addrss_info.Street;
                    details.address_info.Barangay = addrss_info.Barangay;
                    details.address_info.City = addrss_info.City;
                    details.email_info.EmailAddress = email_info.EmailAddress;

                    var result = emp.UpdateEmployee(details, tb_unameAccess.Text);

                    if (result != true)
                    {
                        MessageBox.Show("Failed to update");

                        var addEmployee = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed to Update Employee ID: " + tb_empID.Text + " "
                        };

                        aud.Logs(addEmployee);
                    }
                    else
                    {
                        UpdateGrids();
                        MessageBox.Show("Updated Successfully");

                        var addEmployee = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Succeed",
                            Description = "Updated Employee ID:" + tb_empID.Text + " "
                        };

                        aud.Logs(addEmployee);
                    }
                }
                #endregion

            }
        }
        #endregion

        private bool HighAuthority()
        {

            var creds = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };

            var result = ac.ConfirmAuthority(creds);

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

        private void tb_uname_TextChanged(object sender, EventArgs e)
        {
            checkUsernameUniqueness();
        }
        public void HideUpdateButton()
        {
            btn_updateAccount.Visible = false;
        }
        public void HideSaveButton()
        {
            btn_updateAccount.Visible = false;
        }

        private void cmb_empStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_acctype.Text != "Employee")
            {
                employee_panel.Visible = true;
            }
            else
            {
                employee_panel.Visible = false;
            }
        }
    }
}
