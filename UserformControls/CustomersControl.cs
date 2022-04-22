using SSIP.Controllers;
using SSIP.Forms;
using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        AccessController ac = new AccessController();
        public CustomersControl()
        {
            InitializeComponent();
        }

        #endregion

        #region view, add, update, new buttons     
        private void SaveCustomer()
        {
            var details = new CustomerModel();
            
            #region fields

            var user_info = new User
            {
                Username = tb_unameAccess.Text,
                Firstname = tb_fname.Text,
                Lastname= tb_lname.Text,
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

                    tb_unameAccess.ReadOnly = true;
                    tb_pass.ReadOnly = true;
                    UpdateGrid();
                }
            }

        }    
        private void UpdateCustomer()
        {
            if (HighAuthority())
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
            }
        }
        private void AddCustomer()
        {
            HideCustomersGrid();
            ClearBoxes();
            btn_saveCus.Visible = true;
            btn_updateCus.Visible = false;
          
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

            var result = Access.AuthorizeAccess(creds);

            if (result != true)
            {
                MessageBox.Show("Make sure your credentials is correct");
            }          
        }
        public bool AccessLogin(User users)
        {
            var user = new User
            {
                Username = users.Username,
                Password = users.Password
            };

            var result = ac.ConfirmAccess(user);

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
            tb_unameAccess.FillColor = Color.Red;
            tb_pass.FillColor = Color.Red;
        }
        private void NotHighAuthorityMssg()
        {
            MessageBox.Show("Higher Authoritization Required");
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
       //     this.DoubleBuffered = true;
            if (tb_personID.Text != "0")
            {
                btn_saveCus.Visible = true;
            }

           
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

            customersMainPanel.Visible = false;
            customersGrid.DataSource = null;
            btn_updateCus.Visible = false;
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

        #region event handlers
        private void btn_viewCus_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                customersGrid.DataSource = cusControl.GetCustomers();
                //customersMainPanel.Visible = true;
                //customersMainPanel.Dock = DockStyle.Fill;
                //customersMainPanel.BringToFront();
                //ClearBoxes();
            }
        }
        private void btn_saveCus_Click(object sender, EventArgs e)
        {
            if (Authorized())
            {
                SaveCustomer(); 
            }
        }
        private void btn_addCus_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }     
        private void btn_updateCus_Click(object sender, EventArgs e)
        {
            UpdateCustomer();
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                var result = cusControl.FindCustomers(tb_searchCustomers.Text);
                customersGrid.DataSource = result;
                customersGrid.Update();
                if (tb_searchCustomers.Text == "")
                {
                    UpdateGrid();
                } 
            }
        }
        private void tb_searchCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text == "")
            {
                tb_pass.Enabled = false;
            }
            else
            {
                tb_pass.Enabled = true;
                tb_unameAccess.FillColor = Color.WhiteSmoke;
            }
        }

        private void customersGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {          
            CustomerTransactions his = new CustomerTransactions();
            his.Firstname = this.customersGrid.CurrentRow.Cells[0].Value.ToString();
            his.Lastname = this.customersGrid.CurrentRow.Cells[1].Value.ToString();
            his.MobileNo = this.customersGrid.CurrentRow.Cells[2].Value.ToString();
            his.TelephoneNo = this.customersGrid.CurrentRow.Cells[3].Value.ToString();
            his.HouseNo = this.customersGrid.CurrentRow.Cells[4].Value.ToString();
            his.Street = this.customersGrid.CurrentRow.Cells[5].Value.ToString();
            his.Barangay = this.customersGrid.CurrentRow.Cells[6].Value.ToString();
            his.City = this.customersGrid.CurrentRow.Cells[7].Value.ToString();
            his.PersonID = Convert.ToInt32(this.customersGrid.CurrentRow.Cells[10].Value.ToString());
            his.AddressID = Convert.ToInt32(this.customersGrid.CurrentRow.Cells[11].Value.ToString());
            his.ShowDialog();
        }

        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            if (tb_pass.Text !="")
            {
                tb_pass.FillColor = Color.WhiteSmoke;
            }
           
        }
    }
}
