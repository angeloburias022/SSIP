using SSIP.Controllers;
using SSIP.Helper;
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
            btn_updateAccount.Visible = true;
            btn_saveAcc.Enabled = false;
            btn_updateAccount.Enabled = false;

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
                btn_viewEmp.Enabled = true;
                btn_saveAcc.Enabled = true;
                btn_updateAccount.Enabled = true;
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
                btn_saveAcc.Enabled = true;
                btn_updateAccount.Enabled = true;

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
            }
            else
            {
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
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }
        #endregion

        #region main operation: add, update employee, get employees
        private void btn_saveAcc_Click(object sender, EventArgs e)
        {
            btn_saveAcc.Enabled = false;
            #region fields
            var user = new User
            {
                Firstname = tb_fname.Text,
                Lastname = tb_lname.Text,
                ContactNumber = tb_mobile.Text,
                TelephoneNo = tb_tel.Text,
                Username = tb_uname.Text,
                Password = tb_password.Text

            };

            var email = new Email
            {
                EmailAddress = tb_email.Text,
            };

            var address = new Address
            {
                HouseNo = tb_houseNo.Text,
                Street = tb_street.Text,
                Barangay = tb_barangay.Text,
                City = cmb_City.Text
            };

            var emp = new Employee
            {
                DateHired = Convert.ToDateTime(tb_datehired.Text),
                Position = tb_position.Text,
                TypeOfContract = "none",
                AccountTypeID = cmb_acctype.SelectedIndex,
                EmployeeStatus = cmb_empStatus.Text
            };
            #endregion

            var empController = new EmployeesController();

            var result = empController.AddEmployee(emp, user, address, email, tb_unameAccess.Text);

            if (result != true)
            {
                MessageBox.Show("Something went wrong");
            }
            else
            {
                MessageBox.Show("Added Successfully!");
                tb_unameAccess.ReadOnly = true;
                tb_pass.ReadOnly = true;
                btn_saveAcc.Enabled = true;
                ClearBoxes();
            }

        }

        private void btn_updateAccount_Click(object sender, EventArgs e)
        {
            tb_personID.Text = "0";

            var update = new EmployeesController();

            #region fields
            var personal = new User
            {
                UserID = Convert.ToInt32(tb_personID.Text),
                Firstname = tb_fname.Text,
                Lastname = tb_lname.Text,
                ContactNumber = tb_mobile.Text,
                TelephoneNo = tb_tel.Text
            };

            var adds = new Address
            {
                HouseNo = tb_houseNo.Text,
                Street = tb_street.Text,
                Barangay = tb_barangay.Text,
                City = cmb_City.Text
            };

            var empdetails = new Employee
            {
                EmployeeID = Convert.ToInt32(tb_empID.Text),
                DateHired = tb_datehired.Value,
                Position = tb_position.Text,
                AccountTypeID = cmb_acctype.SelectedIndex,
                EmployeeStatus = cmb_empStatus.Text
            };

            var email = new Email
            {
                EmailAddress = tb_email.Text
            };
            #endregion

            var result = update.UpdateEmployee(empdetails, personal, adds, email, tb_unameAccess.Text);

            if (result != true)
            {
                MessageBox.Show("Check your fields");
            }
            else
            {

                UpdateGrids();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            employeeGrid.DataSource = GetEmployees();
        }

        public DataTable GetEmployees()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string ConString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RFBDesktopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    using (SqlCommand com = new SqlCommand("[SpGetEmployees]", con))
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
                error.ToString();
            }
            return dt;
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
            employeeGrid.DataSource = GetEmployees();
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
        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            HideEmployeeGrid();
        }

        private void btn_viewEmp_Click(object sender, EventArgs e)
        {
            ShowEmployeeGrid();
            ClearBoxes();
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

        private void btn_viewUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
