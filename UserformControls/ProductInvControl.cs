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
using ZXing;
using static SSIP.Models.Inventories;

namespace SSIP.UserformControls
{
    public partial class ProductInvControl : UserControl
    {
        #region declarations
        InventoryController ic = new InventoryController();
        AuditController aud = new AuditController();
        AccessController ac = new AccessController();
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

                tb_code.Text = productCode;
                try
                {
                    details.Name = tb_productName.Text;
                    details.Description = tb_prodDescr.Text;
                    details.UnitPrice = Convert.ToDecimal(tb_prodPrice.Text);
                    details.ProductCode = productCode;
                    details.Category = Convert.ToString(cmb_prodCategory.SelectedIndex);
                    details.RecordedBy = tb_unameAccess.Text;

                    details.aircondetails.Aircontype = cmb_actype.SelectedIndex.ToString();
                    details.quantity = Convert.ToInt32(tb_quan.Text);
                    details.aircondetails.width = Convert.ToDecimal(tb_width.Text);
                    details.aircondetails.height = Convert.ToDecimal(tb_height.Text);
                    details.aircondetails.length = Convert.ToDecimal(tb_length.Text);
                    details.aircondetails.horsepower = Convert.ToString(cmb_Hp.SelectedIndex);
                }
                catch (Exception error)
                {
                    error.ToString();
                }

                if (Valid.ValidateFields(details))
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

                        return true;
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

                        return false;
                    }
                }
                else
                {
                    return false;
                }               
            }
        return false;
        }
        private bool UpdateProduct()
        {
            var details = new ProductInventory();
            if (Authorized())
            {
                details.productID = Convert.ToInt32(tb_id.Text);
                details.Name = tb_productName.Text;
                details.Description = tb_prodDescr.Text;
                details.UnitPrice = Convert.ToDecimal(tb_prodPrice.Text);
                details.ProductCode = tb_code.Text;
                details.Category = Convert.ToString(cmb_prodCategory.SelectedIndex);
                details.RecordedBy = tb_unameAccess.Text;

                details.aircondetails.Aircontype = Convert.ToString(cmb_actype.SelectedIndex);
                details.quantity = Convert.ToInt32(tb_quan.Text);
                details.aircondetails.width = Convert.ToDecimal(tb_width.Text);
                details.aircondetails.height = Convert.ToDecimal(tb_height.Text);
                details.aircondetails.length = Convert.ToDecimal(tb_length.Text);
                details.aircondetails.horsepower = Convert.ToString(cmb_Hp.SelectedIndex);

                if (Valid.ValidateFields(details))
                {
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
            this.ProductGrid.Columns["AirconType"].Visible = false;
            this.ProductGrid.Columns["Horsepower"].Visible = false;
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
        private void ShowAirconDetailFields()
        {
            if (cmb_prodCategory.Text != "Parts")
            {
                lbl_actype.Visible = true;
                cmb_actype.Visible = true;

                lbl_hp.Visible = true;
                cmb_Hp.Visible = true;

                lbl_meterlbl.Visible = true;
                //lbl_width.Visible = true;
                //tb_width.Visible = true;

                //lbl_length.Visible = true;
                //tb_length.Visible = true;
            }
            else
            {
                lbl_actype.Visible = false;
                cmb_actype.Visible = false;

                lbl_hp.Visible = false;
                cmb_Hp.Visible = false;
                lbl_meterlbl.Visible = false;
                //lbl_width.Visible = false;
                //tb_width.Visible = false;

                //lbl_length.Visible = false;
                //tb_length.Visible = false;
            }
        }
        private void UnitPriceField()
        {
            if (tb_prodPrice.Text == "")
            {
                tb_prodPrice.Text = "0";
                MessageBox.Show("Dont leave Unit price blank");
                tb_prodPrice.FillColor = Color.Red;
            }
            else
            {
                tb_prodPrice.FillColor = Color.WhiteSmoke;
            }
           
        }
        private void DoubleClickGrid()
        {
            try
            {
                tb_productName.Text = this.ProductGrid.CurrentRow.Cells[0].Value.ToString();
                tb_prodDescr.Text = this.ProductGrid.CurrentRow.Cells[1].Value.ToString();
                tb_code.Text = this.ProductGrid.CurrentRow.Cells[2].Value.ToString();
                tb_prodPrice.Text = this.ProductGrid.CurrentRow.Cells[3].Value.ToString();

                tb_quan.Text = this.ProductGrid.CurrentRow.Cells[4].Value.ToString();
                cmb_actype.SelectedIndex = Convert.ToInt32(this.ProductGrid.CurrentRow.Cells[5].Value.ToString());
                cmb_Hp.SelectedIndex = Convert.ToInt32(this.ProductGrid.CurrentRow.Cells[6].Value.ToString());
                tb_height.Text = this.ProductGrid.CurrentRow.Cells[7].Value.ToString();
                tb_length.Text = this.ProductGrid.CurrentRow.Cells[8].Value.ToString();
                tb_width.Text = this.ProductGrid.CurrentRow.Cells[9].Value.ToString();
                cmb_prodCategory.SelectedIndex = Convert.ToInt32(this.ProductGrid.CurrentRow.Cells[10].Value.ToString());


                tb_id.Text = this.ProductGrid.CurrentRow.Cells[12].Value.ToString();
            }
            catch (Exception error)
            {
                error.ToString();
            }
        }

        public void GetProductDetails(string code, string name)
        {
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE
            };
            var bitmap = writer.Write(code);

            pic_qrcode.Image = bitmap;
            productName.Text = name;
            displaycode.Text = code;
        }
        #endregion

        #region event handler
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "0")
            {
                if (AddProduct())
                {                 
                    productMainPanel.Visible = false;
                    GetProductDetails(tb_code.Text, tb_productName.Text);
                    QRcontrolpanel.Dock = DockStyle.Fill;
                    QRcontrolpanel.Visible = true;
                    ClearFields();
                } 
            }else
            {
                MessageBox.Show("There is an existing product", tb_code.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
        }

        private void ClearFields()
        {
            tb_id.Text = "0";
            tb_productName.Clear();
            tb_code.Clear();
            tb_prodDescr.Clear();
            tb_prodPrice.Text ="0";
            tb_quan.Text ="0";
            tb_length.Text = "0";
            tb_height.Text = "0";
            tb_width.Text = "0";
            cmb_actype.SelectedIndex = -1;
            cmb_Hp.SelectedIndex = -1;
            cmb_prodCategory.SelectedIndex = -1;
        }
        public void Reset()
        {
            tb_id.Text="0";
            tb_productName.Clear();
            tb_code.Clear();
            tb_prodDescr.Clear();
            tb_prodPrice.Text = "0";
            tb_quan.Text = "0";
            tb_length.Text = "0";
            tb_height.Text = "0";
            tb_width.Text = "0";
            cmb_actype.SelectedIndex = -1;
            cmb_Hp.SelectedIndex = -1;
            cmb_prodCategory.SelectedIndex = -1;

            stats_panel.Visible = true;
            stats_panel.Dock = DockStyle.Fill;
            ProductGrid.DataSource = null;

            tb_unameAccess.Clear();
            tb_pass.Clear();
        }

        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text != "")
            {
                tb_unameAccess.FillColor = Color.White;
                tb_pass.Enabled = true;
            }
            else
            {
                tb_unameAccess.FillColor = Color.Red;
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
            if (tb_id.Text != "0")
            {
                UpdateProduct();                     
            }
        }
        private void tb_searchProd_TextChanged(object sender, EventArgs e)
        {
            if (Authorized())
            {
                var tools = new InventoryController();

                var results = tools.FindProduct(tb_searchProd.Text);

                ProductGrid.DataSource = results;

                if (tb_searchProd.Text == "")
                {
                    UpdateGrid();
                } 
            }
        }
        private void ProductInvControl_Load(object sender, EventArgs e)
        {
            stats_panel.Visible = true;
            stats_panel.Dock = DockStyle.Fill;
            ShowStats();
        }
        private void ProductGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DoubleClickGrid();
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
            var id =  this.ProductGrid.CurrentRow.Cells[12].Value.ToString();
         
            Int32 rowToDelete = ProductGrid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            ProductGrid.Rows.RemoveAt(rowToDelete);
            ProductGrid.ClearSelection();
            DeactivateProduct(id);
        }
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
            UnitPriceField();
        }
        private void cmb_prodCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ShowAirconDetailFields();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            btn_download.Enabled = false;
            if (downloaded())
            {
                QRcontrolpanel.Dock = DockStyle.None;
                QRcontrolpanel.Visible = false;              
            }
            productMainPanel.Visible = true;
        }
        private bool downloaded()
        {
            printQRDialog1.Document = printDocuQR;
            DialogResult res = printQRDialog1.ShowDialog();


            if (res == DialogResult.Cancel)
            {
                printDocuQR.Print();
            }

            return true;
        }

        private void printDocuQR_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pic_qrcode.Image, 280, 150, 300, 300);
            e.Graphics.DrawString("Product Name: " + productName.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(280, 430));
            e.Graphics.DrawString("Product Code/QR Code: " + displaycode.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(280, 470));

        }
        private void btn_download_Click(object sender, EventArgs e)
        {
            downloaded();
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
            tb_unameAccess.FillColor = Color.Red;
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

            var result = ac.ConfirmAccess(user);

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

        private void btn_viewForm_Click(object sender, EventArgs e)
        {
            stats_panel.Visible = false;
            ShowStats();
        }

        private void btn_showStats_Click(object sender, EventArgs e)
        {
            stats_panel.Visible = true;
            stats_panel.Dock = DockStyle.Fill;
            ShowStats();
        }

        private void ShowStats()
        {
            var tools = new InventoryController();
            dis_currentStocks.Text = tools.GetCurrentStocks();
            dis_newstocks.Text = tools.GetNewStocks();
            dis_runningLow.Text = tools.GetRunningLowStocks();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                tb_id.Text = "0";
            }else if (tb_id.Text.Length < 0)
            {
                tb_id.Text = "0";
            }
        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Authorized())
            {
                var tools = new InventoryController();
                var result = tools.ProductFilter(cmb_filter.SelectedIndex);
                ProductGrid.DataSource = result;
                ProductGrid.Update();
            }
        }
    }
}
