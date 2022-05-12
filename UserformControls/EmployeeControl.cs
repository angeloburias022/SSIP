using SSIP.AddEditForms;
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
        ComboBox combo;

        #region Declaration 

        EmployeesController emp = new EmployeesController();
        AuditController aud = new AuditController();
        AccessController ac = new AccessController();
        public EmployeeControl()
        {
            InitializeComponent();

               
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
                
                btn_viewEmp.Enabled = false;

            }
            else
            {
                btn_newEmp.Enabled = true;
                btn_viewEmp.Enabled = true;
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
                Username = tb_unameAccess.Text,
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
        #endregion

        #region others
        private void cmb_acctype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_acctype.Text != "Employee")
            //{
            //    employee_panel.Visible = true;
            //}
            //else
            //{
            //    employee_panel.Visible = false;
            //}
        }
        private void employeeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //tb_uname.Visible = false;
                //tb_password.Visible = false;
                //lbl_username.Visible = false;
                //lbl_password.Visible = false;

                //tb_datehired.Format = DateTimePickerFormat.Custom;
                //// Display the date as "Mon 27 Feb 2012". 
                //tb_datehired.CustomFormat = "ddd dd MMM yyyy";
                //tb_fname.Text = this.employeeGrid.CurrentRow.Cells[0].Value.ToString();
                //tb_lname.Text = this.employeeGrid.CurrentRow.Cells[1].Value.ToString();
                //tb_mobile.Text = this.employeeGrid.CurrentRow.Cells[2].Value.ToString();
                //tb_tel.Text = this.employeeGrid.CurrentRow.Cells[3].Value.ToString();

                //tb_houseNo.Text = this.employeeGrid.CurrentRow.Cells[4].Value.ToString();
                //tb_street.Text = this.employeeGrid.CurrentRow.Cells[5].Value.ToString();
                //tb_barangay.Text = this.employeeGrid.CurrentRow.Cells[6].Value.ToString();
                //cmb_City.Text = this.employeeGrid.CurrentRow.Cells[7].Value.ToString();

                //cmb_empStatus.Text = this.employeeGrid.CurrentRow.Cells[8].Value.ToString();
                //tb_position.Text = this.employeeGrid.CurrentRow.Cells[9].Value.ToString();
                //tb_datehired.Value = Convert.ToDateTime(this.employeeGrid.CurrentRow.Cells[10].Value.ToString());
                //tb_email.Text = this.employeeGrid.CurrentRow.Cells[11].Value.ToString();
                //cmb_acctype.SelectedIndex = Convert.ToInt32(this.employeeGrid.CurrentRow.Cells[12].Value.ToString());

                //tb_empID.Text = this.employeeGrid.CurrentRow.Cells[13].Value.ToString();
                //tb_personID.Text = this.employeeGrid.CurrentRow.Cells[14].Value.ToString();

                //HideEmployeeGrid();
                //btn_updateAccount.Visible = true;
                //btn_updateAccount.Enabled = true;
                //btn_saveAcc.Visible = false;
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }
        #endregion

        #region main operation: add, update employee, get employees
      
      
        private void EmployeeControl_Load(object sender, EventArgs e)
        {       
         
        }  
        #endregion

        #region disable fields, clear txtboxes and update grid
        void DisabledPersonInfoFields()
        {
            //tb_fname.Enabled = false;
            //tb_lname.Enabled = false;
            //tb_tel.Enabled = false;
            //tb_mobile.Enabled = false;
        }
   
  

        #endregion

        #region add new employee show, view employee button, hide emp grid, show emp grid
        private void AddEmployee()
        {
            HideEmployeeGrid();
         
        }
        void ShowEmployeeGrid()
        {
            employeeGrid.DataSource = emp.GetEmployees();        
            employeeGrid.Update();
        }
        void HideEmployeeGrid()
        {
            //employeeMainPanel.Visible = false;
            //employeeMainPanel.Dock = DockStyle.None;
        }
        #endregion

        #region event handlers
       
  
        private void btn_newEmp_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
               
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
                
            }
        }
        private void tb_searchEmployees_TextChanged(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                var result = emp.FindEmployees(tb_searchEmployees.Text);

                employeeGrid.DataSource = result;

                if (tb_searchEmployees.Text == "")
                {
                    UpdateGrids();
                } 
            }
        }

        void UpdateGrids()
        {
            employeeGrid.DataSource = emp.GetEmployees();
            employeeGrid.Update();
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


        private void employeesGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(comboEmployee_SelectedIndexChanged);
                combo.SelectedIndexChanged += comboEmployee_SelectedIndexChanged;
            }

        }
        public void ClearGrid()
        {
            employeeGrid.DataSource = null;
            employeeGrid.Update();
        }
        private void comboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = (sender as ComboBox).SelectedItem.ToString();

                //  var action = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (selected == "Update")
                {
                  
                    ManageEmployee mc = new ManageEmployee();
                    mc.firstname = this.employeeGrid.CurrentRow.Cells[1].Value.ToString();
                    mc.lastname = this.employeeGrid.CurrentRow.Cells[2].Value.ToString();
                    mc.MobleNo = this.employeeGrid.CurrentRow.Cells[3].Value.ToString();
                    mc.TelephoneNo = this.employeeGrid.CurrentRow.Cells[4].Value.ToString();

                    mc.HouseNo = this.employeeGrid.CurrentRow.Cells[5].Value.ToString();
                    mc.Street = this.employeeGrid.CurrentRow.Cells[6].Value.ToString();
                    mc.Barangay = this.employeeGrid.CurrentRow.Cells[7].Value.ToString();
                    mc.City = this.employeeGrid.CurrentRow.Cells[8].Value.ToString();

                    mc.Status = this.employeeGrid.CurrentRow.Cells[9].Value.ToString();
                    mc.Position = this.employeeGrid.CurrentRow.Cells[10].Value.ToString();
                    mc.DateHired = this.employeeGrid.CurrentRow.Cells[11].Value.ToString();

                    mc.Email = this.employeeGrid.CurrentRow.Cells[12].Value.ToString();
                    mc.AccountType = Convert.ToInt32(this.employeeGrid.CurrentRow.Cells[13].Value.ToString());

                    mc.EmployeeID = this.employeeGrid.CurrentRow.Cells[14].Value.ToString();

                  
                    mc.PersonID = this.employeeGrid.CurrentRow.Cells[15].Value.ToString();

                    mc.ManageLabel = "Update Customer";
                    mc.Username = tb_unameAccess.Text;
                    mc.Password = tb_pass.Text;
                    mc.HideSaveButton();
                    mc.ShowDialog();
                    ClearGrid();

                }
                else
                {
                    if (MessageBox.Show("Delete now", "This can't be undo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        //
                    }
                }
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                ManageEmployee me = new ManageEmployee();
                me.ManageLabel = "Add new Employee";
                me.Username = tb_unameAccess.Text;
                me.Password = tb_pass.Text;
                me.HideUpdateButton();
                employeeGrid.DataSource = null;
                employeeGrid.Update();
                me.ShowDialog(); 
            }
        }

        public void Reset()
        {
            tb_pass.Clear();
            tb_unameAccess.Clear();
            ClearGrid();
        }
    }
}
