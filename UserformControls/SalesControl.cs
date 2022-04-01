using AForge.Video;
using AForge.Video.DirectShow;
using LiveCharts;
using LiveCharts.Wpf;
using OfficeOpenXml;
using SSIP.Controllers;
using SSIP.Forms;
using SSIP.Helper;
using SSIP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        public string CurrentUser { get; set; }
        // Dashboard db = new Dashboard();
        //SendEmail em = new SendEmail();

        public string user
        {
            get
            {
                return CurrentUser;
            }
            set
            {
                CurrentUser = value;
            }
        }

        #endregion

        #region declarations
        AuditController aud = new AuditController();
        public SalesControl()
        {
            InitializeComponent();

           
            //var logs = new AuditTrails
            //{
            //    Username = CurrentUser,
            //    AuditActionTypeENUM = (Enums.ActionTypes)1,
            //    DateTimeStamp = DateTime.Now.ToString(),
            //    Result = "Succeed",
            //    Description = "" + CurrentUser + " Successfully delivered e-receipt and copy of order"
            //};

            //aud.Logs(logs);
            //tryPrintname();
            //MyMethod();
        }
        #endregion

        #region access 
        private void Access()
        {

            throw new NotImplementedException();
        }
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
            try
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
            catch (Exception error)
            {
                error.ToString();
            }
        }
        private void SearchProducts()
        {
            var tools = new SalesController();
            var result = tools.GetProduct(tb_searchProd.Text);

            try
            {
                if (result[6].Length > 0)
                {
                    tb_id.Text = result[0].ToString();
                    tb_productName.Text = result[1].ToString();
                    tb_prodPrice.Text = result[2].ToString();
                    tb_code.Text = result[3].ToString();
                    tb_prodDescr.Text = result[4].ToString();
                    cmb_prodCategory.SelectedIndex = Convert.ToInt32(result[5]);
                    tb_quantity.Text = result[6].ToString();
                }
                else
                {
                    MessageBox.Show("No stock available", "OUT OF STOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }         
            }
            catch (Exception error)
            {
                error.ToString();
            }

            //prodGrid.DataSource = result;

            if (result.Count == 0)
            {
                ClearFields();
            }
        }
        private void UpdateGrid()
        {
         //   prodGrid.DataSource = sp.
        }

        public void tryPrintname()
        {
            printSlipDialog.Document = printSlipDocument;
            printSlipDialog.Document.PrinterSettings.PrintToFile = true;
       
            Random random = new Random();
            int random_filename = random.Next();

            DialogResult userResp = printSlipDialog.ShowDialog();

            if (userResp == DialogResult.Cancel)
            {
                if (printSlipDocument.PrinterSettings.PrinterName == "Microsoft Print to PDF")
                {   // force a reasonable filename
                    string basename = Path.GetFileNameWithoutExtension(random_filename.ToString());
                    string directory = Path.GetDirectoryName(random_filename.ToString());
                    printSlipDocument.PrinterSettings.PrintToFile = true;
                    // confirm the user wants to use that name
                    SaveFileDialog pdfSaveDialog = new SaveFileDialog();
                    pdfSaveDialog.InitialDirectory = directory;
                    pdfSaveDialog.FileName = basename + ".pdf";
                    pdfSaveDialog.Filter = "PDF File|*.pdf";
                    userResp = pdfSaveDialog.ShowDialog();
                    if (userResp != DialogResult.Cancel)
                        printSlipDocument.PrinterSettings.PrintFileName = pdfSaveDialog.FileName;
                }

                if (userResp != DialogResult.Cancel)  // in case they canceled the save as dialog
                {
                    printSlipDocument.Print();
                }
            }
        }
        private bool PrintReceipt()
        {
            printSlipDialog.Document = printSlipDocument;
            printSlipDialog.Document.PrinterSettings.PrintToFile = true;

            Random random = new Random();
            int random_filename = random.Next();
            SaveFileDialog pdfSaveDialog = new SaveFileDialog();
            DialogResult userResp = printSlipDialog.ShowDialog();
            string final_name = tb_cusname.Text +"_" + random_filename.ToString();
            if (userResp == DialogResult.Cancel)
            {
                if (printSlipDocument.PrinterSettings.PrinterName == "Microsoft Print to PDF")
                {   // force a reasonable filename
                    string basename = Path.GetFileNameWithoutExtension(final_name);
                    string directory = Path.GetDirectoryName(final_name);
                    printSlipDocument.PrinterSettings.PrintToFile = true;
                    // confirm the user wants to use that name
                   
                    pdfSaveDialog.InitialDirectory = directory;
                    pdfSaveDialog.FileName = basename + ".pdf";
                    pdfSaveDialog.Filter = "PDF File|*.pdf";
                    userResp = pdfSaveDialog.ShowDialog();
                    if (userResp != DialogResult.Cancel)
                        printSlipDocument.PrinterSettings.PrintFileName = pdfSaveDialog.FileName;
                }

                if (userResp != DialogResult.Cancel)  // in case they canceled the save as dialog
                {
                    printSlipDocument.Print();
                }
                receiptattach.Text = pdfSaveDialog.FileName;
                return true;
            }
            return false;
        }
        private void Finalized()
        {
            if (Authorized())
            {
                
                if (Validation())
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
                    details.email_info.EmailAddress = tb_email.Text;

                    if (Valid.ValidateFields(details))
                    {
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

                            if (GenerateExcel())
                            {
                                var body = new Emailer
                                {
                                    Body = "Good day sir/ma'am " + tb_cusname.Text + "<br/>" +
                                               "You have successfully ordered " + itemsTotal.Text + " A/C unit/units. <br/>" +
                                               "Thank you for choosing our service. <br/>" +
                                               "<br/>" +
                                               "Regards, <br/>" +
                                               "RFB Airconditioning Services",
                                    Subject = "Ordered " + itemsTotal.Text + " Aircon",
                                    Receiver = tb_email.Text,
                                    Attachments = attachment.Text
                                };

                                var resultEmail = SendEmail.Send(body);
                                if (resultEmail)
                                {
                                    if (PrintReceipt())
                                    {

                                        //var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                                        //string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;
                                        //string attach = Path.Combine(projectDirectory, @"V2_SSIP\receipts\" + receiptattach.Text);

                                        var receipt = new Emailer
                                        {
                                            Body = "Good day sir/ma'am " + tb_cusname.Text + "<br/>" +
                                             "This is your e-receipt for the " + itemsTotal.Text + " A/C unit/units. <br/>" +
                                             "<br/>" +
                                             "Thank you for choosing our service. <br/>" +
                                             "<br/>" +
                                             "Regards, <br/>" +
                                             "RFB Airconditioning Services",
                                            Subject = "Receipt",
                                            Receiver = tb_email.Text,
                                            Attachments = receiptattach.Text
                                        };

                                        var emailresult = SendEmail.Send(receipt);

                                        if (emailresult == true)
                                        {
                                            var logs = new AuditTrails
                                            {
                                                Username = tb_unameAccess.Text,
                                                AuditActionTypeENUM = (Enums.ActionTypes)9,
                                                DateTimeStamp = DateTime.Now.ToString(),
                                                Result = "Succeed",
                                                Description = "" + tb_unameAccess.Text + " Successfully emailed e-receipt and copy of order"
                                            };

                                            aud.Logs(logs);
                                            ClearAccessTB();

                                            MessageBox.Show("Transaction Succeed", "RECORDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                    }
                                }

                            }

                        }
                    }
                }  
            }            
        }
        private void GetProductDetails(string code)
        {
            var tools = new SalesController();

            var result = tools.GetProduct(code);

            if (result.Count > 0)
            {
                if (result[6].Length > 0)
                {
                    GetCam();
                    tb_id.Text = result[0].ToString();
                    tb_productName.Text = result[1].ToString();
                    tb_prodPrice.Text = result[2].ToString();
                    tb_code.Text = result[3].ToString();
                    tb_prodDescr.Text = result[4].ToString();
                    cmb_prodCategory.SelectedIndex = Convert.ToInt32(result[5].ToString());
                    tb_quantity.Text = result[6].ToString();
                }
                else
                {                 
                    if (MessageBox.Show("No stock available, Request new one?", "OUT OF STOCK", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        GetCam();
                        tb_id.Text = result[0].ToString();
                        tb_productName.Text = result[1].ToString();
                        tb_prodPrice.Text = result[2].ToString();
                        tb_code.Text = result[3].ToString();
                        tb_prodDescr.Text = result[4].ToString();
                        cmb_prodCategory.SelectedIndex = Convert.ToInt32(result[5].ToString());
                        tb_quantity.Text = result[6].ToString();
                    }
                    else
                    {
                        ClearFields();
                    }
                }
            }
            else
            {
                MessageBox.Show("No products found");
                GetCam();
            }
        }
        private bool GetCam()
        {           
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();            
            return true;
        }
        #endregion

        #region event handlers
        private void btn_scan_Click(object sender, EventArgs e)
        {
            if (Authorized())
            {
                if (GetCam())
                {
                    btn_scan.Text = "SCANNING";
                    btn_scan.FillColor = Color.Red;
                } 
            }
        }      
        private void CaptureDevice_NewFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            productPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
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
            catch (Exception error)
            {
                error.ToString();
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (HighAuthority())
            {
                foreach (DataGridViewRow item in this.prodGrid.SelectedRows)
                {
                    prodGrid.Rows.RemoveAt(item.Index);
                }
            }
        }
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "0")
            {
                if (Authorized())
                {
                    addProduct(); 
                }
            }
            else if (tb_quantity.Text == "0")
            {
                MessageBox.Show("Quantity of product should not be below 1", "ADD QUANTITY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Scan a product first", "SCAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // MessageBoxOptions.ServiceNotification = true;
            }
            
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
            if (compute())
            {             
               Finalized();                            
            }      
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
            decimal am_paid = Convert.ToDecimal(tb_amountPaid.Text);
            decimal gra_total = Convert.ToDecimal(grandTotal.Text);
            if (gra_total > am_paid)
            {
                MessageBox.Show("Invalid Amount");
            }
            else
            {
                compute();
            }
  
        }
        private bool Validation()
        {
            if (tb_cusname.Text != "" | tb_email.Text != "" || tb_address.Text !="")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Customer Details fields is required");
                return false;
            }
        }
        private bool compute()
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
                return false;
            }
            else
            {
                total = amountPaid - itemsPriceTotal;
                change = total;
                display_change.Text = change.ToString();

                return true;
            }
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            if (tb_email.Text== "")
            {
                MessageBox.Show("Check email field");
                btn_finalized.Enabled = false;
            }
            else
            {
                btn_finalized.Enabled = true;
            }
        }

        private void btn_generateExcell_Click(object sender, EventArgs e)
        {
          
        }

        private bool GenerateExcel()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook| .xlsx" })
            {

                Random random = new Random();
                int random_filename = random.Next();
                saveFileDialog.Title = "Save as Excel";
                saveFileDialog.FileName = tb_cusname.Text+"_"+random_filename.ToString();
                saveFileDialog.Filter = "Excel files(2007)|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage pck = new ExcelPackage())
                        {                 
                            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                            string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;

                            string template_path = Path.Combine(projectDirectory, @"V2_SSIP\templates\POS_template.xlsx");
                  
                            FileInfo temp_File = new FileInfo(template_path.ToString());

                            ExcelPackage temp_pck = new ExcelPackage(temp_File);
                            var temp_ws = temp_pck.Workbook.Worksheets["Sheet1"];
                           
                            ExcelPackage new_temp_ep = new ExcelPackage();
              
                            var sav = new_temp_ep.Workbook.Worksheets.Add("Sheet1", temp_ws);
                           
                            ExcelWorksheet res = sav.Workbook.Worksheets["Sheet1"];
                            res.Cells["B17"].LoadFromDataTable((this.prodGrid.DataSource as DataTable).DefaultView.ToTable(), true);
                            res.Workbook.Worksheets.Add(DateTime.Today.ToString("MMMM-yyyy"));
                            res.Cells["A8"].Value = DateTime.Today.ToString("MMMM-yyyy-dddd");
                            res.Cells["A10"].Value = tb_address.Text;
                            res.Cells["A12"].Value = "Attention: " + tb_cusname.Text;
                            res.Cells["A14"].Value = "Subject: Ordered: " + itemsTotal.Text + " Units";
                            res.Cells["A8:A14"].Style.Indent = 3;
                            res.Cells["H28"].Value = lbl_grandTotal.Text;
                            res.Cells["H28"].Style.Indent = 5;
                            res.Cells["I28"].Value = grandTotal.Text;

                            ExcelPackage ep = new ExcelPackage();

                            ep.Workbook.Worksheets.Add("Orders: " + DateTime.Today.ToString("MMMM-yyyy-dddd"), res);

                            string final_name = saveFileDialog.FileName;
                            attachment.Text = saveFileDialog.FileName;

                            ep.SaveAs(saveFileDialog.FileName);

                            return true;
                        }
                    }
                    catch (Exception error)
                    {

                        error.ToString();
                    }
                }
            }
            return false;
        }

        public void excelfirstway()
        {
            //prodGrid.SelectAll();
            //DataObject copydata = prodGrid.GetClipboardContent();
            //if (copydata != null) Clipboard.SetDataObject(copydata);


            //Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            //xlapp.Visible = true;
            //Microsoft.Office.Interop.Excel.Workbook xlWbook;
            //Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            //object miseddata = System.Reflection.Missing.Value;
            //xlWbook = xlapp.Workbooks.Add(miseddata);

            //xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);



            //Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[10, 1];




            //xlr.Select();

            //xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


            //xlsheet.SaveAs(file_info.ToString());
            //MessageBox.Show("Save excel successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool MyMethod()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook| .xlsx" })
            {

                Random random = new Random();
                int random_filename = random.Next();
                saveFileDialog.Title = "Save as Excel";
                saveFileDialog.FileName = random_filename.ToString();
                saveFileDialog.Filter = "Excel files(2007)|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage pck = new ExcelPackage())
                        {
                            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                            string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;

                            string template_path = Path.Combine(projectDirectory, @"V2_SSIP\templates\POS_template.xlsx");
                            //  string new_excel_path = Path.Combine(projectDirectory, @"V2_SSIP\templates\" + random_filename.ToString() + ".xlsx");

                            FileInfo temp_File = new FileInfo(template_path.ToString());

                            ExcelPackage temp_pck = new ExcelPackage(temp_File);
                            var temp_ws = temp_pck.Workbook.Worksheets["Sheet1"];

                            //   FileInfo new_temp_nfi = new FileInfo(new_excel_path.ToString());
                            ExcelPackage new_temp_ep = new ExcelPackage();

                            //  new_temp_ep.Columns.AutoFit();
                            var sav = new_temp_ep.Workbook.Worksheets.Add("Sheet1", temp_ws);

                            //   EmployeesController emp = new EmployeesController();
                            ExcelWorksheet res = sav.Workbook.Worksheets["Sheet1"];
                           // res.Cells["B17"].LoadFromDataTable((this.prodGrid.DataSource as DataTable).DefaultView.ToTable(), true);
                            res.Workbook.Worksheets.Add(DateTime.Today.ToString("MMMM-yyyy"));
                            res.Cells["A8"].Value = DateTime.Today.ToString("MMMM-yyyy-dddd");
                            res.Cells["A10"].Value = tb_address.Text;
                            res.Cells["A12"].Value = "Attention: " + tb_cusname.Text;
                            res.Cells["A14"].Value = "Subject: Ordered: " + itemsTotal.Text + " Units";
                            res.Cells["A8:A14"].Style.Indent = 3;
                            //   res.Cells["B17:I17"].Style.Indent = 3;

                            string attach = Path.Combine(projectDirectory, @"V2_SSIP\templates\" + saveFileDialog.FileName);

                            attachment.Text = attach;
                            ExcelPackage ep = new ExcelPackage();

                            ep.Workbook.Worksheets.Add("Orders: " + DateTime.Today.ToString("MMMM-yyyy-dddd"), res);

                            ep.SaveAs(saveFileDialog.FileName);

                            return true;
                        }
                    }
                    catch (Exception error)
                    {

                        error.ToString();
                    }
                }


            }
            return false;

        }

        private void btn_scan_DoubleClick(object sender, EventArgs e)
        {
            captureDevice.Stop();

            if (!captureDevice.IsRunning)
            {
                btn_scan.Text = "SCAN PRODUCT";
                btn_scan.FillColor = Color.AliceBlue;
                timer1.Stop();
            }
        }

        private void printSlipDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (Authorized())
            {
                e.Graphics.DrawString("*******************************", new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(50, 30));
                e.Graphics.DrawString("Receipt", new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(180, 60));

                e.Graphics.DrawString("RFB Airconditioning Services", new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.LimeGreen, new Point(180, 90));
                e.Graphics.DrawString("38 C. Jose st. Malibay Pasay City", new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(140, 120));
                e.Graphics.DrawString("0928-976-9872", new Font("Microsoft Sans Serif", 25, FontStyle.Bold), Brushes.Black, new Point(160, 150));

                e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 220));
                e.Graphics.DrawString("Customer Name: " + tb_cusname.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 250));
                e.Graphics.DrawString("Quantity: " + itemsTotal.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 280));
                e.Graphics.DrawString("Amount Paid: " + tb_amountPaid.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 310));
                e.Graphics.DrawString("Change: " + display_change.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 340));
                e.Graphics.DrawString("Grand Total: " + grandTotal.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 370));
                if (CurrentUser == null)
                {
                    e.Graphics.DrawString("Cashier: " + tb_unameAccess.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 430));
                }
                else
                {
                    e.Graphics.DrawString("Cashier: " + CurrentUser, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 430));
                }

                //e.Graphics.DrawString("SSS: " + lbl_sss_print.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 340));
                //e.Graphics.DrawString("Pag-ibig " + lbl_pagibig_print.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 370));
                //e.Graphics.DrawString("Philhealth " + lbl_ph_print.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 400));
                //e.Graphics.DrawString("Recorded by: " + lbl_signature.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 460));
                //e.Graphics.DrawString("_____________________", new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 565));
                //e.Graphics.DrawString(" Authorized Signature:  ", new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(120, 600));
            }
            else
            {
                NotAuthorized();
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
                    Description = "'" + user.Username + "' access POS feature"
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
                    Description = "'" + user.Username + "'Failed to POS feature"
                };
                aud.Logs(accesslog);
                return false;
            }
        }
        private void NotHighAuthorized()
        {
            MessageBox.Show("Higher Authoritization Required");
        }
        private void NotAuthorized()
        {
            MessageBox.Show("Authentication Required");
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
                NotHighAuthorized();
                return false;
            }
            else
            {
                return true;
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
                    NotAuthorized();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Re-enter your credentials to activate this feature", "ENTER CREDENTIALS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_unameAccess.FillColor = Color.Red;
                return false;
            }
           
        }
        private void tb_unameAccess_TextChanged(object sender, EventArgs e)
        {
            if (tb_unameAccess.Text.Length < 0)
            {
                tb_pass.Enabled = false;
            }
            else
            {
                tb_unameAccess.FillColor = Color.White;
                tb_pass.Enabled = true;
            }
        }
        private void tb_pass_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("validated");

            var creds = new User
            {
                Username = tb_unameAccess.Text,
                Password = tb_pass.Text
            };

            var result = AccessLogin(creds);

            if (result == true)
            {
                btn_finalized.Enabled = true;
            }
            else
            {
                NotAuthorized();
                btn_finalized.Enabled = false;
            }
        }
        private void ClearAccessTB()
        {
            tb_unameAccess.Clear();
            tb_pass.Clear();
        }

        private void tb_quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_quantity.Text.Length < 0 || tb_quantity.Text =="")
            {
                tb_quantity.Text = "0";
            }
        }

       
        private void btn_viewOrders_Click(object sender, EventArgs e)
        {
            if (Authorized())
            {
                this.Controls.Clear();
                InitializeComponent();
               
                TypeAcPieChart.BackColor = Color.Transparent;
                TypeAcPieChart.ForeColor = Color.White;
                if (LoadDatas())
                {
                    chartTablePanel.Dock = DockStyle.Fill;
                    chartTablePanel.Visible = true;
                } 
            }
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {           
            chartTablePanel.Visible = false;
            salesGridView.DataSource = null;
            salesGridView.Update();
        }
        private bool LoadDatas()
        {
           
            try
            {
                var tools = new SalesController();
                #region POS data

                salesGridView.DataSource = tools.GetOrders();
                salesGridView.Update();
                #endregion
                try
                {

                    #region monthly sales chart
                    // Monthly sales chart
                    using (DashboardEntities db = new DashboardEntities())
                    {
                        var data = db.SpMontlySales(); // get the stored proc inside the entity
                        ColumnSeries col = new ColumnSeries() // access the cartesian chart
                        {
                            DataLabels = true,
                            Values = new ChartValues<int>(),
                            LabelPoint = point => point.Y.ToString()
                        };

                        Axis ax = new Axis()
                        {
                            Separator = new Separator() { Step = 1, IsEnabled = false }
                        };

                        ax.Labels = new List<string>();

                        // loop through the database
                        foreach (var sales in data)
                        {

                            col.Values.Add(Convert.ToInt32(sales.January.Value));
                            ax.Labels.Add("January");

                            col.Values.Add(Convert.ToInt32(sales.February.Value));
                            ax.Labels.Add("February");

                            col.Values.Add(Convert.ToInt32(sales.March.Value));
                            ax.Labels.Add("March");

                            col.Values.Add(Convert.ToInt32(sales.April.Value));
                            ax.Labels.Add("April");

                            col.Values.Add(Convert.ToInt32(sales.May.Value));
                            ax.Labels.Add("May");

                            col.Values.Add(Convert.ToInt32(sales.June.Value));
                            ax.Labels.Add("June");

                            col.Values.Add(Convert.ToInt32(sales.July.Value));
                            ax.Labels.Add("July");

                            col.Values.Add(Convert.ToInt32(sales.August.Value));
                            ax.Labels.Add("August");

                            col.Values.Add(Convert.ToInt32(sales.September.Value));
                            ax.Labels.Add("September");

                            col.Values.Add(Convert.ToInt32(sales.October.Value));
                            ax.Labels.Add("October");

                            col.Values.Add(Convert.ToInt32(sales.November.Value));
                            ax.Labels.Add("November");

                            col.Values.Add(Convert.ToInt32(sales.December.Value));
                            ax.Labels.Add("December");



                        }

                        cartesianMonthChart1.Series.Add(col);
                        cartesianMonthChart1.AxisX.Add(ax);
                        cartesianMonthChart1.AxisY.Add(
                            new Axis
                            {
                                LabelFormatter = value => value.ToString(),
                                Separator = new Separator()
                            });

                    }

                    #endregion

                    #region aircontype stocks
                    SeriesCollection series = new SeriesCollection();
                    using (DashboardEntities db = new DashboardEntities())
                    {
                        var data = db.SpGetActypeStocks(); // get the stored proc inside the entity

                        Func<ChartPoint, string> labelPoint = chartPoint =>
                          string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                        try
                        {
                            foreach (var actypes in data)
                            {
                                PieSeries WindowType = new PieSeries
                                {
                                    DataLabels = true,
                                    LabelPoint = labelPoint,
                                    Title = "WindowType",
                                    Values = new ChartValues<int> { actypes.WindowType.Value }
                                };

                                PieSeries SplitType = new PieSeries
                                {
                                    DataLabels = true,
                                    LabelPoint = labelPoint,
                                    Title = "SplitType",
                                    Values = new ChartValues<int> { actypes.SplitType.Value }
                                };

                                PieSeries Floor_mounted_type = new PieSeries
                                {
                                    DataLabels = true,
                                    LabelPoint = labelPoint,
                                    Title = "Floor mounted type",
                                    Values = new ChartValues<int> { actypes.Floor_mounted_type.Value }
                                };

                                PieSeries Ceiling_Wallmounted_type = new PieSeries
                                {
                                    DataLabels = true,
                                    LabelPoint = labelPoint,
                                    Title = "Ceiling Wallmounted type",
                                    Values = new ChartValues<int> { actypes.Ceiling_Wallmounted_type.Value }
                                };


                                series.Add(WindowType);
                                series.Add(SplitType);
                                series.Add(Floor_mounted_type);
                                series.Add(Ceiling_Wallmounted_type);
                                TypeAcPieChart.Series = series;
                            }

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show("something went wrong" + error);
                        }

                        TypeAcPieChart.LegendLocation = LegendLocation.Bottom;

                        //SeriesCollection series = new SeriesCollection();

                        //foreach (var obj in db.SpServicesChart())
                        //    series.Add(new PieSeries() { Title = obj.che.ToString(), Values = new ChartValues<int> { obj.clea.ToString(), ChartValues = new ChartValues<string>, } DataLabels = true, LabelPoint = LabelPoint);
                        //pieChart1.Series = series;
                    }
                    #endregion
                }
                catch (Exception error)
                {

                    error.ToString();
                }
                return true;
            }
            catch (Exception error)
            {
                error.ToString();
            }
            return false;
        }

        private void tb_searchOrders_TextChanged(object sender, EventArgs e)
        {
            if (tb_searchOrders.Text.Length > 0)
            {
                var tools = new SalesController();
                salesGridView.DataSource = tools.FindOrders(tb_searchOrders.Text);
                salesGridView.Update();
            }
        }
    }
}
