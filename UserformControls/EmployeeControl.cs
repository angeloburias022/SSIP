﻿using SSIP.Controllers;
using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        #endregion

        public EmployeeControl()
        {
            InitializeComponent();

            btn_saveAcc.Visible = true;
            btn_updateAccount.Visible = true;
            btn_saveAcc.Enabled = false;
            btn_updateAccount.Enabled = false;
           
        }

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

            }else
            {
                tb_unameAccess.ReadOnly = true;
                tb_pass.ReadOnly = true;
            }
        }
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

            var result = empController.AddEmployee(emp,user,address,email);

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
        public bool AccessLogin(User users)
        {
            var user = new User
            {
                Username = users.Username,
                Password = users.Password
            };

            var accesslog = new AuditTrails
            {
                Username = user.Username,
                AuditActionTypeENUM = (Enums.ActionTypes)1,
                DateTimeStamp = DateTime.Now.ToString(),
                Result = "Succeed",
                Description = "'" + user.Username + "' accessed manager customer feature"
            };


            var cfirm = new AccessController();

            var result = cfirm.ConfirmAccess(user, accesslog);

            if (result == true)
            {
                btn_saveAcc.Enabled = true;
                btn_updateAccount.Enabled = true;

                return true;
            }

            return false;
        }


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
            //schedgrid.DataSource = GetSchedules();
            //schedgrid.Update();

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
    }
}
