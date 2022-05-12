using SSIP.AddEditForms;
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
        ComboBox combo;
        public CustomersControl()
        {
            InitializeComponent();
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
           
                btn_viewCus.Enabled = true;
        
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
            
                btn_viewCus.Enabled = false;
                   
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
            
        }

        private void customersGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }

        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selected = (sender as ComboBox).SelectedItem.ToString();

                //  var action = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (selected == "Update")
                {

                    ManageCustomer mc = new ManageCustomer();
                    mc.firstname = this.customersGrid.CurrentRow.Cells[1].Value.ToString();
                    mc.lastname = this.customersGrid.CurrentRow.Cells[2].Value.ToString();
                    mc.MobleNo = this.customersGrid.CurrentRow.Cells[3].Value.ToString();
                    mc.TelephoneNo = this.customersGrid.CurrentRow.Cells[4].Value.ToString();

                    mc.HouseNo = this.customersGrid.CurrentRow.Cells[5].Value.ToString();
                    mc.Street = this.customersGrid.CurrentRow.Cells[6].Value.ToString();
                    mc.Barangay = this.customersGrid.CurrentRow.Cells[7].Value.ToString();
                    mc.City = this.customersGrid.CurrentRow.Cells[8].Value.ToString();

                    mc.Status = this.customersGrid.CurrentRow.Cells[9].Value.ToString();
                    mc.Email = this.customersGrid.CurrentRow.Cells[10].Value.ToString();
                    mc.PersonID = this.customersGrid.CurrentRow.Cells[11].Value.ToString();

                    mc.ManageLabel = "Update Customer";
                    mc.HideAddButton();
                    mc.ShowDialog();
                }
                else
                {
                    if (MessageBox.Show("Delete now", "This can't be undo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                       //cusControl.del
                    }
                }
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }
        private void customersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // HideCustomersGrid();
            // Display the date as "Mon 27 Feb 2012". 

            //tb_fname.Text = this.customersGrid.CurrentRow.Cells[0].Value.ToString();
            //tb_lname.Text = this.customersGrid.CurrentRow.Cells[1].Value.ToString();
            //tb_mobile.Text = this.customersGrid.CurrentRow.Cells[2].Value.ToString();
            //tb_tel.Text = this.customersGrid.CurrentRow.Cells[3].Value.ToString();

            //tb_houseNo.Text = this.customersGrid.CurrentRow.Cells[4].Value.ToString();
            //tb_street.Text = this.customersGrid.CurrentRow.Cells[5].Value.ToString();
            //tb_barangay.Text = this.customersGrid.CurrentRow.Cells[6].Value.ToString();
            //cmb_City.Text = this.customersGrid.CurrentRow.Cells[7].Value.ToString();

            //cmb_status.Text = this.customersGrid.CurrentRow.Cells[8].Value.ToString();
            //tb_email.Text = this.customersGrid.CurrentRow.Cells[9].Value.ToString();

            //tb_personID.Text = this.customersGrid.CurrentRow.Cells[10].Value.ToString();
         
            //btn_updateCus.Visible = true;        
            //btn_saveCus.Visible = false;
            //tb_personID.Visible = true;
            //lbl_personID.Visible = true;
        }

        #endregion

        #region disable fields, clear txtboxes and update grid
      

        public void Reset()
        {
            customersGrid.DataSource = false;
            tb_unameAccess.Clear();
            tb_pass.Clear();
            tb_pass.Enabled = false;
        }

        #endregion

        #region add new employee show, view employee button, hide emp grid, show emp grid
     
        private void btn_viewEmp_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                ShowEmployeeGrid();

            }
        }

        void ShowEmployeeGrid()
        {
            customersMainPanel.Visible = true;
            customersMainPanel.Dock = DockStyle.Fill;
        }
  


        #endregion

        #region event handlers
        private void btn_viewCus_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                customersGrid.DataSource = cusControl.GetCustomers();
                customersGrid.Update();
            }
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

  
        #region unused

  
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_personID_Click(object sender, EventArgs e)
        {

        }

        private void tb_personID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void confirmAccessPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void cmb_City_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_barangay_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_street_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_houseNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                ManageCustomer mc = new ManageCustomer();
                mc.ManageLabel = "Add new Customer";
                mc.Username = tb_unameAccess.Text;
                mc.Password = tb_pass.Text;
                mc.HideUpdateBtn();
                customersGrid.DataSource = null;
                customersGrid.Update();
                mc.ShowDialog(); 
            }                  
        }

     

        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text.Length > 0)
            {
                tb_pass.Enabled = true;
            }
            else
            {
                tb_pass.Enabled = false;
            }
        }

        private void rb_both_CheckedChanged(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                if (rb_both.Checked)
                {
                    customersGrid.DataSource = cusControl.GetCustomers();
                    customersGrid.Update();
                } 
            }                  
        }

        private void rb_active_CheckedChanged(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                if (rb_active.Checked)
                {
                    customersGrid.DataSource = cusControl.GetActiveCustomers();
                    customersGrid.Update();
                } 
            }
        }

        private void rd_InActive_CheckedChanged(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                if (rd_InActive.Checked)
                {
                    customersGrid.DataSource = cusControl.GetInActiveCustomers();
                    customersGrid.Update();
                }
            }
        }


        //tb_personID.Text = this.customersGrid.CurrentRow.Cells[10].Value.ToString();
    }
}
