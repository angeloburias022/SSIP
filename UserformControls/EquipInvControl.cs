using SSIP.Controllers;
using SSIP.Helper;
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
using static SSIP.Models.Inventories;

namespace SSIP.UserformControls
{
    public partial class EquipInvControl : UserControl
    {

        #region declarations
        InventoryController ic = new InventoryController();
        AuditController aud = new AuditController();
       
        public EquipInvControl()
        {
            InitializeComponent();
        }
        #endregion

        #region methods operations
        private void AddItem()
        {
            if (Authorized())
            {
                var productCode = GenerateCode.Code(10);
                var details = new EquipmentInventory();
                try
                {
                    details = new EquipmentInventory
                    {
                        Name = tb_productName.Text,
                        Description = tb_prodDescr.Text,
                        UnitPrice = Convert.ToDecimal(tb_price.Text),
                        ProductCode = productCode,
                        Category = "categ",
                        DatePurchased = datepurchased.Value,
                        RecordedBy = tb_unameAccess.Text,
                        Status = cmb_equipStatus.SelectedIndex.ToString(),
                        quantity = Convert.ToInt32(tb_quan.Text)
                    };
                }
                catch (Exception error)
                {
                    error.ToString();
                }

                if (Valid.ValidateFields(details))
                {
                    var result = ic.AddItem(details);

                    if (result != false)
                    {
                        var success = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)3,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Succeed",
                            Description = "Added a new Product"
                        };

                        aud.Logs(success);
                        MessageBox.Show("Product Added");
                        UpdateGrid();
                    }
                    else
                    {
                        var failed = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)3,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed to add new product"
                        };

                        aud.Logs(failed);
                        MessageBox.Show("Something went wrong");
                    }
                }

            }
        }
        private void UpdateItem()
        {
            if (HighAuthority())
            {
                var details = new EquipmentInventory
                {
                    EquipmentID = Convert.ToInt32(tb_id.Text),
                    Name = tb_productName.Text,
                    Description = tb_prodDescr.Text,
                    Category = "category",
                    UnitPrice = Convert.ToDecimal(tb_price.Text),
                    DatePurchased = datepurchased.Value,
                    RecordedBy = tb_unameAccess.Text,
                    Status = cmb_equipStatus.SelectedIndex.ToString(),
                    quantity = Convert.ToInt32(tb_quan.Text)
                };
                if (Valid.ValidateFields(details))
                {
                    var result = ic.UpdateItem(details);
                    if (result != false)
                    {
                        var success = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Succeed",
                            Description = "Updated Item ID: " + tb_id.Text + ""
                        };

                        aud.Logs(success);
                        MessageBox.Show("Item Updated");
                        UpdateGrid();
                    }
                    else
                    {
                        var failed = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed to Update Item ID: " + tb_id.Text + ""
                        };

                        aud.Logs(failed);
                        MessageBox.Show("Something went wrong");
                    }
                }    
            }        
        }      
        private void UpdateGrid()
        {
            if (Authorized())
            {
                itemGrid.DataSource = ic.GetItems();
                itemGrid.Update();
            }           
        }
        private void GetEquipValues()
        {
            tb_productName.Text = this.itemGrid.CurrentRow.Cells[0].Value.ToString();                    
            tb_prodDescr.Text = this.itemGrid.CurrentRow.Cells[1].Value.ToString();
            tb_code.Text = this.itemGrid.CurrentRow.Cells[2].Value.ToString();
            tb_price.Text = this.itemGrid.CurrentRow.Cells[3].Value.ToString();
            datepurchased.Value =Convert.ToDateTime(this.itemGrid.CurrentRow.Cells[4].Value.ToString());
            tb_id.Text = this.itemGrid.CurrentRow.Cells[5].Value.ToString();
            cmb_equipStatus.SelectedIndex = Convert.ToInt32(this.itemGrid.CurrentRow.Cells[6].Value);
            tb_quan.Text = this.itemGrid.CurrentRow.Cells[6].Value.ToString();
        }
        private void DeactivateProduct(string id)
        {
            if (HighAuthority())
            {
                var results = ic.DeactivateProduct(id);

                if (results != false)
                {
                    MessageBox.Show("Product Removed");
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }
        #endregion

        #region access
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
                    Description = "'" + user.Username + "' access equipment feature"
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
                    Description = "'" + user.Username + "'Failed to access equipment feature"
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
        }
        private void NotHighAuthorityMssg()
        {
            MessageBox.Show("Higher Authoritization Required");
        }
        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text != "")
            {
                tb_pass.Enabled = true;
            }
            else
            {
                tb_pass.Enabled = false;
            }
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

                tb_unameAccess.ReadOnly = false;
                tb_pass.ReadOnly = false;
            }
            else
            {


            }
        }
        #endregion

        #region event handlers
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddItem();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }       
        private void btn_remove_Click(object sender, EventArgs e)
        {
            DeactivateProduct(tb_id.Text);
        }
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var result = ic.FindItem(tb_search.Text);

            itemGrid.DataSource = result;

            if (tb_search.Text == "")
            {
                UpdateGrid();
            }
        }
        private void tb_prodPrice_TextChanged(object sender, EventArgs e)
        {
            if (tb_price.Text == "")
            {
                tb_price.Text = "0";
                MessageBox.Show("Dont leave Unit price blank");
                tb_price.FillColor = Color.Red;
            }
        }
        private void btn_viewEquip_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void itemGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetEquipValues();
        }
        #endregion

        private void btn_viewForm_Click(object sender, EventArgs e)
        {
            Equipstats_panel.Visible = false;
            ShowStats();
        }

        private void ShowStats()
        {
            var tools = new InventoryController();
            dis_brandnewEquipment.Text = tools.GetBrandNewEquipments();
            dis_usedEquipments.Text = tools.GetUsedEquipments();
            dis_newEquip.Text = tools.GetNewEquipments();
            dis_currentEquipment.Text = tools.GetCurrentEquipments();            
            dis_runningLow.Text = tools.GetRunningLowEquipments();
            dis_slightlyUsed.Text = tools.GetSlightlyUsedEquipments();
        }

        private void EquipInvControl_Load(object sender, EventArgs e)
        {
            Equipstats_panel.Visible = true;
            Equipstats_panel.Dock = DockStyle.Fill;
            ShowStats();
        }

        private void btn_showStats_Click(object sender, EventArgs e)
        {
            Equipstats_panel.Visible = true;
            Equipstats_panel.Dock = DockStyle.Fill;
            ShowStats();
        }
        private void tb_quan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
