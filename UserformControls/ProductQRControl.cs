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

namespace SSIP.UserformControls
{
    public partial class ProductQRControl : UserControl
    {
        public ProductQRControl()
        {
            InitializeComponent();
        }

        private void printDocuQR_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pic_qrcode.Image, 280, 150, 300, 300);
            e.Graphics.DrawString("Product Name: " + productName.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(310, 430));
            e.Graphics.DrawString("Product Code/QR Code: " + displaycode.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(310, 470));
       
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
        private void ProductQRControl_Load(object sender, EventArgs e)
        {
            printQRDialog1.Document = printDocuQR;
            printQRDialog1.ShowDialog();
        }
    }
}
