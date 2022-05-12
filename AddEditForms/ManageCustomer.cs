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
    public partial class ManageCustomer : Form
    {
        CustomersController cusControl = new CustomersController();

        AuditController aud = new AuditController();
        AccessController ac = new AccessController();

        #region fields
    
        public string PersonID { 
            get { 
                return tb_personID.Text; 
            }
            set { 
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
        public string Status
        {
            get { 
                return this.cmb_status.Text;
            }
            set { 
                this.cmb_status.Text = value; 
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

        public string Username { get { return tb_unameAccess.Text; } set { tb_unameAccess.Text = value; } }
        public string Password { get { return tb_pass.Text; } set { tb_pass.Text = value; } }

        public string ManageLabel { get { return lbl_ManageCus.Text; } set { this.lbl_ManageCus.Text = value; } }

        #endregion
        public ManageCustomer()
        {
            InitializeComponent();
        }

        public void HideUpdateBtn()
        {
            btn_updateCus.Visible = false;
            btn_saveCus.Visible = true;
        }

        public void HideAddButton()
        {
            btn_updateCus.Visible = true;
            btn_saveCus.Visible = false;
        }

        #region view, add, update, new buttons     
        private void SaveCustomer()
        {
            var details = new CustomerModel();

            #region fields

            var user_info = new User
            {
                Username = "",
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

            if (Valid.ValidateFields(user_info) && Valid.ValidateFields(addrss_info) && Valid.ValidateFields(email_info))
            {
                details.user_info.Username = user_info.Username;
                details.user_info.Firstname = user_info.Firstname;
                details.user_info.Lastname = user_info.Lastname;
                details.user_info.ContactNumber = user_info.ContactNumber;
                details.user_info.TelephoneNo = user_info.TelephoneNo;

                details.address_info.HouseNo = addrss_info.HouseNo;
                details.address_info.Street = addrss_info.Street;
                details.address_info.Barangay = addrss_info.Barangay;
                details.address_info.City = addrss_info.City;

                details.employee_info.EmployeeStatus = cmb_status.Text;
                details.email_info.EmailAddress = email_info.EmailAddress;

                var result = cusControl.AddCustomer(details);

                if (result != true)
                {
                    MessageBox.Show("Add failed");

                    // audit here
                    var failed = new AuditTrails
                    {
                        Username = tb_unameAccess.Text,
                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                        DateTimeStamp = DateTime.Now.ToString(),
                        Result = "Failed",
                        Description = "Failed to add new Customer"
                    };

                    aud.Logs(failed);
                }
                else
                {
                    MessageBox.Show("Successfully Added");

                    // audit here
                    var addEmployee = new AuditTrails
                    {
                        Username = tb_unameAccess.Text,
                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                        DateTimeStamp = DateTime.Now.ToString(),
                        Result = "Succeed",
                        Description = "Added new Customer"
                    };

                    aud.Logs(addEmployee);
                    
                }
            }

        }
        private void UpdateCustomer()
        {
         
            #region fields        

            var details = new CustomerModel();


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

            if (Valid.ValidateFields(user_info) && Valid.ValidateFields(addrss_info) && Valid.ValidateFields(email_info))
            {

                details.user_info.UserID = user_info.UserID;
                details.user_info.Username = user_info.Username;
                details.user_info.Firstname = user_info.Firstname;
                details.user_info.Lastname = user_info.Lastname;
                details.user_info.ContactNumber = user_info.ContactNumber;
                details.user_info.TelephoneNo = user_info.TelephoneNo;

                details.address_info.HouseNo = addrss_info.HouseNo;
                details.address_info.Street = addrss_info.Street;
                details.address_info.Barangay = addrss_info.Barangay;
                details.address_info.City = addrss_info.City;

                details.employee_info.EmployeeStatus = cmb_status.Text;
                details.email_info.EmailAddress = email_info.EmailAddress;

                var result = cusControl.UpdateCustomer(details);

                if (result != true)
                {
                    MessageBox.Show("Update failed");

                    // audit here
                    var failed = new AuditTrails
                    {
                        Username = "",
                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                        DateTimeStamp = DateTime.Now.ToString(),
                        Result = "Failed",
                        Description = "Failed to Update Customer"
                    };

                    aud.Logs(failed);

                }
                else
                {
                    MessageBox.Show("Successfully Updated");

                    // audit here
                    var addEmployee = new AuditTrails
                    {
                        Username ="",
                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                        DateTimeStamp = DateTime.Now.ToString(),
                        Result = "Succeed",
                        Description = "Updated Customer ID: " + tb_personID.Text + " "
                    };

                    aud.Logs(addEmployee);                   
                }
            }
            
        }
        private void AddCustomer()
        {
            ClearBoxes();
            btn_saveCus.Visible = true;
            btn_updateCus.Visible = false;

        }

        void DisabledPersonInfoFields()
        {
            tb_fname.Enabled = false;
            tb_lname.Enabled = false;
            tb_tel.Enabled = false;
            tb_mobile.Enabled = false;
        }

        

        void ClearBoxes()
        {

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
            cmb_status.SelectedItem = null;
            cmb_status.SelectedText = "--select--";

            tb_email.Clear();


        }

        public void Reset()
        {
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
            cmb_status.SelectedItem = null;
            cmb_status.SelectedText = "--select--";

            tb_email.Clear();

            tb_unameAccess.Clear();
            tb_pass.Clear();

            btn_updateCus.Visible = false;
        }
        #endregion

       
        private void btn_saveCus_Click(object sender, EventArgs e)
        {          
            SaveCustomer();
        }
        private void btn_addCus_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void btn_updateCus_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }

        private void AECustomer_Load(object sender, EventArgs e)
        {
       
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
    }
}
