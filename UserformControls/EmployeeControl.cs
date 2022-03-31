using SSIP.Controllers;
using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class EmployeeControl : UserControl
    {
       
        public bool emp_setter { get; set; }

        #region Declaration 

        EmployeesController emp = new EmployeesController();
        AuditController aud = new AuditController();
        public EmployeeControl()
        {
            InitializeComponent();

            btn_saveAcc.Visible = true;          
        }

        #endregion

        #region Operator / user access
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
                btn_saveAcc.Enabled = false;
                btn_updateAccount.Enabled = false;
                btn_viewEmp.Enabled = false;

            }
            else
            {
                btn_newEmp.Enabled = true;
                btn_viewEmp.Enabled = true;
                btn_saveAcc.Enabled = true;
           
                
            }
        }
        private bool AccessLogin(User users)
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
                btn_saveAcc.Enabled = true;
                btn_updateAccount.Enabled = true;

                var accesslog = new AuditTrails
                {
                    Username = user.Username,
                    AuditActionTypeENUM = (Enums.ActionTypes)1,
                    DateTimeStamp = DateTime.Now.ToString(),
                    Result = "Succeed",
                    Description = "" + user.Username + " access manage employee feature"
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
                    Description = "" + user.Username + "Failed to access manage employee feature"
                };
                aud.Logs(accesslog);
                return false;
            }           
        }
        private bool Authorized()
        {
            var user = new User
            {
                Username = tb_uname.Text,
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
                Username = tb_unameAccess.Text,
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
        #endregion

        #region others
        private void cmb_acctype_SelectedIndexChanged(object sender, EventArgs e)
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
        private void employeeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_datehired.Format = DateTimePickerFormat.Custom;
                // Display the date as "Mon 27 Feb 2012". 
                tb_datehired.CustomFormat = "ddd dd MMM yyyy";
                tb_fname.Text = this.employeeGrid.CurrentRow.Cells[0].Value.ToString();
                tb_lname.Text = this.employeeGrid.CurrentRow.Cells[1].Value.ToString();
                tb_mobile.Text = this.employeeGrid.CurrentRow.Cells[2].Value.ToString();
                tb_tel.Text = this.employeeGrid.CurrentRow.Cells[3].Value.ToString();

                tb_houseNo.Text = this.employeeGrid.CurrentRow.Cells[4].Value.ToString();
                tb_street.Text = this.employeeGrid.CurrentRow.Cells[5].Value.ToString();
                tb_barangay.Text = this.employeeGrid.CurrentRow.Cells[6].Value.ToString();
                cmb_City.Text = this.employeeGrid.CurrentRow.Cells[7].Value.ToString();

                cmb_empStatus.Text = this.employeeGrid.CurrentRow.Cells[8].Value.ToString();
                tb_position.Text = this.employeeGrid.CurrentRow.Cells[9].Value.ToString();
                tb_datehired.Value = Convert.ToDateTime(this.employeeGrid.CurrentRow.Cells[10].Value.ToString());
                tb_email.Text = this.employeeGrid.CurrentRow.Cells[11].Value.ToString();
                cmb_acctype.SelectedIndex = Convert.ToInt32(this.employeeGrid.CurrentRow.Cells[12].Value.ToString());

                tb_empID.Text = this.employeeGrid.CurrentRow.Cells[13].Value.ToString();
                tb_personID.Text = this.employeeGrid.CurrentRow.Cells[14].Value.ToString();

                HideEmployeeGrid();
                btn_updateAccount.Enabled = true;
                btn_saveAcc.Enabled = false;
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }
        #endregion

        #region main operation: add, update employee, get employees
      
        private void SaveAcc()
        {
            if (HighAuthority())
            {
                #region fields

                var qr = new QRCodeControl();          
                var details = new Employee();

                details.user_info.Username = tb_uname.Text;
                details.user_info.Password = tb_password.Text;
                details.user_info.Firstname = tb_fname.Text;
                details.user_info.Lastname = tb_lname.Text;
                details.user_info.ContactNumber = tb_mobile.Text;
                details.user_info.TelephoneNo = tb_tel.Text;
             
                details.email_info.EmailAddress = tb_email.Text;

                details.address_info.HouseNo = tb_houseNo.Text;
                details.address_info.Street = tb_street.Text;
                details.address_info.Barangay = tb_barangay.Text;
                details.address_info.City = cmb_City.Text;

                string randomCode = GenerateCode.Code(10);

                this.qrCodeControl1.GetDetails(randomCode, tb_fname.Text, tb_lname.Text, tb_position.Text);

                tb_qrcode.Text = randomCode;

                details.DateHired = Convert.ToDateTime(tb_datehired.Text);
                details.Position = tb_position.Text;
                details.TypeOfContract = "None";
                details.AccountTypeID = cmb_acctype.SelectedIndex;
                details.EmployeeStatus = cmb_empStatus.Text;
                details.code = tb_qrcode.Text;

                #endregion

                #region validations
                if (Valid.ValidateFields(details))
                {
                    var empController = new EmployeesController();

                    var result = empController.AddEmployee(details);

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
                        tb_unameAccess.ReadOnly = true;
                        tb_pass.ReadOnly = true;
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
               // tb_personID.Text = "0";

                var update = new EmployeesController();
                var details = new Employee();

                #region fields
                details.user_info.UserID = Convert.ToInt32(tb_personID.Text);
                details.user_info.Firstname = tb_fname.Text;
                details.user_info.Lastname = tb_lname.Text;
                details.user_info.ContactNumber = tb_mobile.Text;
                details.user_info.TelephoneNo = tb_tel.Text;
              
                details.address_info.HouseNo = tb_houseNo.Text;
                details.address_info.Street = tb_street.Text;
                details.address_info.Barangay = tb_barangay.Text;
                details.address_info.City = cmb_City.Text;

                details.EmployeeID = Convert.ToInt32(tb_empID.Text);
                details.DateHired = Convert.ToDateTime(tb_datehired.Text);
                details.Position = tb_position.Text;                
                details.AccountTypeID = cmb_acctype.SelectedIndex;
                details.EmployeeStatus = cmb_empStatus.Text;
               
                details.email_info.EmailAddress = tb_email.Text;
                #endregion

                #region validations
                if (Valid.ValidateFields(details))
                {
                    var result = update.UpdateEmployee(details, tb_unameAccess.Text);

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
        private void EmployeeControl_Load(object sender, EventArgs e)
        {       
            employeeGrid.DataSource = emp.GetEmployees();   
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
        void UpdateGrids()
        {
            employeeGrid.DataSource = emp.GetEmployees();
            employeeGrid.Update();

            //dispatchListgrid.DataSource = GetDispatches();
            //dispatchListgrid.Update();
        }
        void ClearBoxes()
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


        }

        #endregion

        #region add new employee show, view employee button, hide emp grid, show emp grid
        private void AddEmployee()
        {
            HideEmployeeGrid();
            btn_updateAccount.Enabled = false;
            btn_saveAcc.Enabled = true;
        }
        void ShowEmployeeGrid()
        {
            employeeMainPanel.Visible = true;
            employeeMainPanel.Dock = DockStyle.Fill;
        }
        void HideEmployeeGrid()
        {
            employeeMainPanel.Visible = false;
            employeeMainPanel.Dock = DockStyle.None;
        }
        #endregion

        #region event handlers
        private void btn_saveAcc_Click(object sender, EventArgs e)
        {
            SaveAcc();
        }
        private void btn_updateAccount_Click(object sender, EventArgs e)
        {
            UpdateAcc();
        }
        private void btn_newEmp_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                ClearBoxes();
                btn_updateAccount.Enabled = false;
                btn_saveAcc.Enabled = true;
            }
        }
        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }
        private void btn_viewEmp_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                ShowEmployeeGrid();
                ClearBoxes();
            }
        }
        private void tb_searchEmployees_TextChanged(object sender, EventArgs e)
        {
            var tool = new EmployeesController();

            var result = tool.FindEmployees(tb_searchEmployees.Text);

            employeeGrid.DataSource = result;

            if (tb_searchEmployees.Text == "")
            {
                UpdateGrids();
            }
        }
        private void tb_searchEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text == "")
            {
                tb_pass.Enabled = false;
            }
            else
            {
                tb_pass.Enabled = true;
            }
        }
        #endregion

        private void tb_uname_TextChanged(object sender, EventArgs e)
        {         
            checkUsernameUniqueness();
           // EnableDoubleBuffering();
        }

        private void checkUsernameUniqueness()
        {
            var tool = new AccessController();
            var result = tool.UsernameUnique(tb_uname.Text);
            if (result.Count > 0)
            {
                btn_saveAcc.Enabled = false;
                MessageBox.Show("Username already exist");              
            }
            else
            {
                btn_saveAcc.Enabled = true;               
            }
        }
    }
}
