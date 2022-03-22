using SSIP.Helper;
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
    public partial class QRCodeControl : UserControl
    {
        public string QrCodePic { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public QRCodeControl()
        {
            InitializeComponent();           
        }   
 
        public void GetDetails(string code, string firstname, string lastname, string Position)
        { 
            lbl_fname.Text = firstname;
            lbl_lname.Text = lastname;
            lbl_displayPosition.Text = Position;

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE
            };
            var bitmap = writer.Write(code);

            pic_qrcode.Image = bitmap;
            lbl_code.Text = code;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Download QR Code?", "Confirm",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
               == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("Cancelled Successfuly");
            }
        }

        private void printQRCode_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {     
            e.Graphics.DrawImage(pic_qrcode.Image, 280, 150, 300, 300);
            e.Graphics.DrawString("Firstname: " + lbl_fname.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(350, 430));
            e.Graphics.DrawString("Lastname: " + lbl_lname.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(350, 470));
            e.Graphics.DrawString("Position: " + lbl_displayPosition.Text, new Font("Microsoft Sans Serif", 21, FontStyle.Bold), Brushes.Black, new Point(350, 500));
        }

        private void QRCodeControl_Load(object sender, EventArgs e)
        {
            printQRCodeDialog1.Document = printQRCode;
            printQRCodeDialog1.ShowDialog();
        }
    }
}
