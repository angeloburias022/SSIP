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

namespace SSIP.UserformControls
{
    public partial class CustomersControl : UserControl
    {
        #region declarations
        CustomersController cusControl = new CustomersController();

        AuditController aud = new AuditController();

        public CustomersControl()
        {
            InitializeComponent();
        }
        #endregion

        #region view, add, update, new buttons

        private void btn_viewCus_Click(object sender, EventArgs e)
        {
            customersMainPanel.Visible = true;
            customersMainPanel.Dock = DockStyle.Fill;
            customersMainPanel.BringToFront();
            ClearBoxes();
        }

        private void btn_saveCus_Click(object sender, EventArgs e)
        {         
            #region fields
            var cus = new User
            {
                Username = tb_unameAccess.Text,
                Firstname = tb_fname.Text,
                Lastname = tb_lname.Text,
                ContactNumber = tb_mobile.Text,
                TelephoneNo = tb_tel.Text
            };

            var adds = new Address
            {
                HouseNo = tb_houseNo.Text,
                Street = tb_street.Text,
                Barangay = cmb_City.Text,
                City = cmb_City.Text
            };

            var emp = new Employee
            {
                EmployeeStatus = cmb_status.Text
            };

            var em = new Email
            {
                EmailAddress = tb_email.Text
            };

            #endregion

            #region validations
            var customerValidCon = new ValidationContext(cus, null, null);
            var addsValidCon = new ValidationContext(adds, null, null);
            var empValidCon = new ValidationContext(emp, null, null);
            var emailValidCon = new ValidationContext(em, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(cus, customerValidCon, errors, true) ||
                !Validator.TryValidateObject(adds, addsValidCon, errors, true) ||
                !Validator.TryValidateObject(emp, empValidCon, errors, true) ||
                !Validator.TryValidateObject(em, emailValidCon, errors, true))
            {
                foreach (ValidationResult val in errors)
                {
                    MessageBox.Show(val.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {

                var result = cusControl.AddCustomer(emp, cus, adds, em);

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

                    tb_unameAccess.ReadOnly = true;
                    tb_pass.ReadOnly = true;
                    UpdateGrid();
                }

            }
            #endregion
        }

        private void btn_updateCus_Click(object sender, EventArgs e)
        {
            #region fields        
            var cus = new User
            {
                UserID = Convert.ToInt32(tb_personID.Text),
                Username = tb_unameAccess.Text,
                Firstname = tb_fname.Text,
                Lastname = tb_lname.Text,
                ContactNumber = tb_mobile.Text,
                TelephoneNo = tb_tel.Text
            };

            var adds = new Address
            {
                HouseNo = tb_houseNo.Text,
                Street = tb_street.Text,
                Barangay = cmb_City.Text,
                City = cmb_City.Text
            };

            var emp = new Employee
            {
                EmployeeStatus = cmb_status.Text
            };

            var em = new Email
            {
                EmailAddress = tb_email.Text
            };
            #endregion

            #region validations

            var customerValidCon = new ValidationContext(cus, null, null);
            var addsValidCon = new ValidationContext(adds, null, null);
            var empValidCon = new ValidationContext(emp, null, null);
            var emailValidCon = new ValidationContext(em, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(cus, customerValidCon, errors, true) ||
                !Validator.TryValidateObject(adds, addsValidCon, errors, true) ||
                !Validator.TryValidateObject(emp, empValidCon, errors, true) ||
                !Validator.TryValidateObject(em, emailValidCon, errors, true))
            {
                foreach (ValidationResult val in errors)
                {
                    MessageBox.Show(val.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                var result = cusControl.UpdateCustomer(emp, cus, adds, em);

                if (result != true)
                {
                    MessageBox.Show("Update failed");

                    // audit here
                    var failed = new AuditTrails
                    {
                        Username = tb_unameAccess.Text,
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
                        Username = tb_unameAccess.Text,
                        AuditActionTypeENUM = (Enums.ActionTypes)3,
                        DateTimeStamp = DateTime.Now.ToString(),
                        Result = "Succeed",
                        Description = "Updated Customer ID: " + tb_personID.Text + " "
                    };

                    aud.Logs(addEmployee);

                    tb_unameAccess.ReadOnly = true;
                    tb_pass.ReadOnly = true;
                    UpdateGrid();
                }
            }
            #endregion
        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {
            HideCustomersGrid();
            ClearBoxes();
            btn_saveCus.Visible = true;
            btn_updateCus.Enabled = false;
        }
        #endregion

        #region operator / security access
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

            }
            else
            {
                tb_unameAccess.ReadOnly = true;
                tb_pass.ReadOnly = true;
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
                btn_saveCus.Enabled = true;
                btn_updateCus.Enabled = true;
                btn_viewCus.Enabled = true;
                btn_saveCus.Enabled = true;

                var accesslog = new AuditTrails
                {
                    Username = user.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Succeed",
                    Description = "'" + user.Username + "' accessed manager customer feature"
                };
                aud.Logs(accesslog);

                return true;
            }else
            {
                btn_saveCus.Enabled = false;
                btn_updateCus.Enabled = false;
                btn_viewCus.Enabled = false;
                btn_saveCus.Enabled = false;
                   
                var accesslog = new AuditTrails
                {
                    Username = user.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Failed",
                    Description = "'" + user.Username + "'Failed to access manager customer feature"
                };

                aud.Logs(accesslog);

                return false;
            }

            
        }
        #endregion

        #region others
        public void UpdateGrid()
        {
            customersGrid.DataSource = cusControl.GetCustomers();
            customersGrid.Update();
        }
        private void CustomersControl_Load(object sender, EventArgs e)
        {
            if (tb_personID.Text != "0")
            {
                btn_saveCus.Visible = true;
            }

            customersGrid.DataSource = cusControl.GetCustomers();
        }
        private void customersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HideCustomersGrid();
            // Display the date as "Mon 27 Feb 2012". 

            tb_fname.Text = this.customersGrid.CurrentRow.Cells[0].Value.ToString();
            tb_lname.Text = this.customersGrid.CurrentRow.Cells[1].Value.ToString();
            tb_mobile.Text = this.customersGrid.CurrentRow.Cells[2].Value.ToString();
            tb_tel.Text = this.customersGrid.CurrentRow.Cells[3].Value.ToString();

            tb_houseNo.Text = this.customersGrid.CurrentRow.Cells[4].Value.ToString();
            tb_street.Text = this.customersGrid.CurrentRow.Cells[5].Value.ToString();
            tb_barangay.Text = this.customersGrid.CurrentRow.Cells[6].Value.ToString();
            cmb_City.Text = this.customersGrid.CurrentRow.Cells[7].Value.ToString();

            cmb_status.Text = this.customersGrid.CurrentRow.Cells[8].Value.ToString();
            tb_email.Text = this.customersGrid.CurrentRow.Cells[9].Value.ToString();

            tb_personID.Text = this.customersGrid.CurrentRow.Cells[10].Value.ToString();

          

            btn_updateCus.Visible = true;
        
            btn_saveCus.Visible = false;
            tb_personID.Visible = true;
            lbl_personID.Visible = true;
        }

        #endregion

        #region disable fields, clear txtboxes and update grid
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

        #endregion

        #region add new employee show, view employee button, hide emp grid, show emp grid
     
        private void btn_viewEmp_Click(object sender, EventArgs e)
        {
            ShowEmployeeGrid();
            ClearBoxes();
        }

        void ShowEmployeeGrid()
        {
            customersMainPanel.Visible = true;
            customersMainPanel.Dock = DockStyle.Fill;
        }
        void HideCustomersGrid()
        {
            customersMainPanel.Visible = false;
            customersMainPanel.Dock = DockStyle.None;
        }


        #endregion

        private void tb_search_TextChanged(object sender, EventArgs e)
        {



        }

        public void Validation()
        {

           
        }
    }
}
