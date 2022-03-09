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
    public partial class ProductInvControl : UserControl
    {
        #region declarations
        InventoryController ic = new InventoryController();
        AuditController aud = new AuditController();
        public ProductInvControl()
        {
            InitializeComponent();
        }
        #endregion

        #region methods
        private bool AddProduct()
        {
            if (Authorized())
            {
                var productCode = GenerateCode.Code(10);
                var details = new ProductInventory();
                try
                {
                    details = new ProductInventory
                    {
                        Name = tb_productName.Text,
                        Description = tb_prodDescr.Text,
                        UnitPrice = Convert.ToDecimal(tb_prodPrice.Text),
                        ProductCode = productCode,
                        Category = Convert.ToString(cmb_prodCategory.SelectedIndex),
                        RecordedBy = tb_unameAccess.Text
                    };
                }
                catch (Exception error)
                {
                    error.ToString();
                }
               
                var detailsValidCon = new ValidationContext(details, null, null);
                
                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(details, detailsValidCon, errors, true))
                {
                    foreach (ValidationResult val in errors)
                    {
                        MessageBox.Show(val.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    var result = ic.AddProduct(details);

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
        return true;
        }
        private bool UpdateProduct()
        {
            if (Authorized())
            {      
                var details = new ProductInventory
                {
                    productID = Convert.ToInt32(tb_id.Text),
                    Name = tb_productName.Text,
                    Description = tb_prodDescr.Text,
                    UnitPrice = Convert.ToDecimal(tb_prodPrice.Text),                   
                    Category = Convert.ToString(cmb_prodCategory.SelectedIndex),
                    RecordedBy = tb_unameAccess.Text
                };
               
                var detailsValidCon = new ValidationContext(details, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();

                if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(details, detailsValidCon, errors, true))
                {
                    foreach (ValidationResult val in errors)
                    {
                        MessageBox.Show(val.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else {
                    var result = ic.UpdateProduct(details);

                    if (result != false)
                    {
                        var success = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Succeed",
                            Description = "Updated Product ID: " + tb_id.Text + ""
                        };

                        aud.Logs(success);
                        MessageBox.Show("Product Updated");
                        UpdateGrid();
                        return true;
                    }
                    else
                    {
                        var failed = new AuditTrails
                        {
                            Username = tb_unameAccess.Text,
                            AuditActionTypeENUM = (Enums.ActionTypes)4,
                            DateTimeStamp = DateTime.Now.ToString(),
                            Result = "Failed",
                            Description = "Failed to Update Product ID: " + tb_id.Text + ""
                        };

                        aud.Logs(failed);
                        MessageBox.Show("Something went wrong");
                        return false;
                    }
                }            
            }
            else
            {              
                return false;
            }
            return true;
        }
        private void UpdateGrid()
        {
            ProductGrid.DataSource = ic.GetProducts();
            ProductGrid.Update();

            this.ProductGrid.Columns["CategoryID"].Visible = false;
            this.ProductGrid.Columns["ProductID"].Visible = false;
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
                }else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }     
        #endregion

        #region event handler
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
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
                //btn_filter.Enabled = false;
                //btn_generateLayout.Enabled = false;
                //btn_printLayout.Enabled = false;
                //btn_viewPayrolls.Enabled = false;
                //btn_compute.Enabled = false;

                tb_unameAccess.ReadOnly = false;
                tb_pass.ReadOnly = false;
            }
            else
            {
                //btn_filter.Enabled = true;
                //btn_generateLayout.Enabled = true;
                //btn_printLayout.Enabled = true;
                //btn_viewPayrolls.Enabled = true;
                //btn_compute.Enabled = true;

                //    tb_unameAccess.ReadOnly = true;
                //    tb_pass.ReadOnly = true;


            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
        private void tb_searchProd_TextChanged(object sender, EventArgs e)
        {
            var tools = new InventoryController();

            var results = tools.FindProduct(tb_searchProd.Text);

            ProductGrid.DataSource = results;

            if (tb_searchProd.Text == "")
            {
                UpdateGrid();
            }
        }
        private void ProductInvControl_Load(object sender, EventArgs e)
        {
        }
        private void ProductGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            tb_productName.Text = this.ProductGrid.CurrentRow.Cells[0].Value.ToString();
            tb_prodDescr.Text = this.ProductGrid.CurrentRow.Cells[1].Value.ToString();
            tb_code.Text = this.ProductGrid.CurrentRow.Cells[2].Value.ToString();
            tb_prodPrice.Text = this.ProductGrid.CurrentRow.Cells[3].Value.ToString();
            cmb_prodCategory.SelectedIndex = Convert.ToInt32(this.ProductGrid.CurrentRow.Cells[4].Value.ToString());
            tb_id.Text = this.ProductGrid.CurrentRow.Cells[6].Value.ToString();
        }
        private void btn_viewProducts_Click(object sender, EventArgs e)
        {
            if (Authorized())
            {
                UpdateGrid();
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            var id =  this.ProductGrid.CurrentRow.Cells[6].Value.ToString();
         
            Int32 rowToDelete = ProductGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            ProductGrid.Rows.RemoveAt(rowToDelete);
            ProductGrid.ClearSelection();
            DeactivateProduct(id);
        }
        #endregion

        #region access
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
                    Description = "'" + user.Username + "' access product inventory feature"
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
                    Description = "'" + user.Username + "'Failed to access product inventory feature"
                };
                aud.Logs(accesslog);
                return false;
            }
        }

        #endregion

        private void ProductGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = ProductGrid.HitTest(e.X, e.Y);
                ProductGrid.ClearSelection();
                ProductGrid.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void tb_prodPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_prodPrice_TextChanged(object sender, EventArgs e)
        {
            if(tb_prodPrice.Text == "")
            {
                tb_prodPrice.Text = "0";
                MessageBox.Show("Dont leave Unit price blank");
                tb_prodPrice.FillColor = Color.Red;
            }
        }
    }
}
