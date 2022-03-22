using AForge.Video;
using AForge.Video.DirectShow;
using SSIP.Controllers;
using SSIP.Forms;
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
using ZXing;
using ZXing.Aztec.Internal;

namespace SSIP.UserformControls
{
    public partial class SalesControl : UserControl
    {
        #region private fields
        //  private readonly FilterInfoCollection filterinfocollection;
        // public Detector Detector;
        

        private VideoCaptureDevice captureDevice;
        DataTable dt = new DataTable();
        DataRow dr;
        SalesController sp = new SalesController();
        #endregion

        #region declarations
        AuditController aud = new AuditController();
        public SalesControl()
        {
            InitializeComponent();
        }
        #endregion

        #region access 

        #endregion

        #region private methods
        private void addProduct()
        {
            int i, items = 0, items_total = 0, itemprice = 0, grand_total = 0;
            ShowRows();
            if (prodGrid.DataSource != null)
            {
                for (i = 0; i < prodGrid.Rows.Count; ++i)
                {
                    items += Convert.ToInt32(prodGrid.Rows[i].Cells[5].Value);
                    itemprice += Convert.ToInt32(prodGrid.Rows[i].Cells[7].Value);
                }
                items_total = +items;
                grand_total = +itemprice;

                grandTotal.Text = grand_total.ToString();
                itemsTotal.Text = items_total.ToString();
                ClearFields();
            }
        }
        private void ShowRows()
        {
            int prod_quan = 0, prod_price = 0, totalPrice = 0;
            // price * quan
            prod_price = Convert.ToInt32(tb_prodPrice.Text);
            prod_quan = Convert.ToInt32(tb_quantity.Text);
            totalPrice = prod_price * prod_quan;
            tb_totalprice.Text = totalPrice.ToString();

            dr = dt.NewRow();

            dr["ProductID"] = tb_id.Text;
            dr["Name"] = tb_productName.Text;
            dr["Code"] = tb_code.Text;
            dr["Category"] = cmb_prodCategory.SelectedItem;
            dr["Description"] = tb_prodDescr.Text;
            dr["Quantity"] = tb_quantity.Text;
            dr["Unit Price"] = tb_prodPrice.Text;
            dr["Total Price"] = tb_totalprice.Text;
            dt.Rows.Add(dr);
            prodGrid.DataSource = dt;

            this.prodGrid.Columns["ProductID"].Visible = false;
            this.prodGrid.Columns["Category"].Visible = false;
            this.prodGrid.Columns["Description"].Visible = false;
        }
        private void SearchProducts()
        {
            var tools = new SalesController();
            var result = tools.GetProduct(tb_searchProd.Text);
            prodGrid.DataSource = result;

            if (tb_searchProd.Text == "")
            {
                UpdateGrid();
            }
        }
        private void UpdateGrid()
        {
         //   prodGrid.DataSource = sp.
        }
        private void Finalized()
        {
            btn_finalized.Enabled = false;
            var details = new Sales();
            var tools = new SalesController();
            details.customerName = tb_cusname.Text;
            details.Address = tb_address.Text;
            details.AmountPaid = Convert.ToDecimal(tb_amountPaid.Text);
            details.GrandTotal = Convert.ToDecimal(grandTotal.Text);
            details.Quantity = Convert.ToInt32(itemsTotal.Text);
            details.code = GenerateCode.Code(10);
            details.ContactNo = tb_contact.Text;
            var result = tools.AddTransClientInfo(details);

            if (result != false)
            {
                foreach (DataGridViewRow item in prodGrid.Rows)
                {
                    if (item.IsNewRow) continue;
                    {
                        tools.AddTransaction(item, details);
                    }                  
                }
                MessageBox.Show("Recorded");
                btn_finalized.Enabled = true;
            }
        }
        private void GetProductDetails(string code)
        {
            var tools = new SalesController();

            var result = tools.GetProduct(code);

            if (result.Count > 0)
            {
                GetCam();
                tb_id.Text = result[0].ToString();
                tb_productName.Text = result[1].ToString();
                tb_prodPrice.Text = result[2].ToString();
                tb_code.Text = result[3].ToString();
                tb_prodDescr.Text = result[4].ToString();
                cmb_prodCategory.SelectedIndex = Convert.ToInt32(result[5].ToString());
            }
            else
            {
                MessageBox.Show("No products found");
                GetCam();
            }
        }
        private void GetCam()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        #endregion

        #region event handlers
        private void btn_scan_Click(object sender, EventArgs e)
        {
            GetCam();
        }      
        private void CaptureDevice_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            productPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (productPictureBox.Image != null)
            {
                var barcodeReader = new BarcodeReader();

                Result result = barcodeReader.Decode((Bitmap)productPictureBox.Image);
                timer1.Stop();

                if (result != null)
                {
                    tb_code.Text = result.ToString();
                    GetProductDetails(tb_code.Text);
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
                else
                {
                    timer1.Start();
                }
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {

        }
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            addProduct();
        }
        private void SalesControl_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ProductID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Code");
            dt.Columns.Add("Category");
            dt.Columns.Add("Description");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Unit Price");
            dt.Columns.Add("Total Price");
        }
        private void tb_searchProd_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void prodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tb_id.Text = this.prodGrid.CurrentRow.Cells[0].Value.ToString();
            //tb_productName.Text = this.prodGrid.CurrentRow.Cells[1].Value.ToString();
            //tb_prodPrice.Text = this.prodGrid.CurrentRow.Cells[2].Value.ToString();
            //tb_code.Text = this.prodGrid.CurrentRow.Cells[3].Value.ToString();
            //tb_prodDescr.Text = this.prodGrid.CurrentRow.Cells[4].Value.ToString();
            //cmb_prodCategory.SelectedIndex = Convert.ToInt32(this.prodGrid.CurrentRow.Cells[5].Value.ToString());
        }
        private void btn_finalized_Click(object sender, EventArgs e)
        {
            Finalized();
        }
        private void tb_prodPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        #endregion

        #region others
        private void ClearFields()
        {
            tb_productName.Clear();
            tb_id.Clear();
            tb_prodDescr.Clear();
            tb_prodPrice.Clear();
            tb_code.Clear();
            cmb_prodCategory.SelectedIndex = -1;
            tb_quantity.Clear();
        }
        #endregion

        private void tb_code_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {
            ClearFields();
            prodGrid.DataSource = null;
            prodGrid.Update();
        }
        private void tb_compute_Click(object sender, EventArgs e)
        {
            compute();
        }
        private void compute()
        {
            decimal amountPaid = 0, change = 0, total = 0, itemsPriceTotal = 0;
            amountPaid = Convert.ToDecimal(tb_amountPaid.Text);
            itemsPriceTotal = Convert.ToDecimal(grandTotal.Text);

            Dashboard frm;     //frm_main is your main form which user control is on it
            frm = (Dashboard)this.FindForm();     //It finds the parent form and sets it to the frm
            //frm.
           // frm.Hide();
            if (amountPaid < itemsPriceTotal)
            {
                MessageBox.Show("Invalid amount");
            }
            else
            {
                total = amountPaid - itemsPriceTotal;
                change = total;
                display_change.Text = change.ToString();
            }
        }
    }
}
