
namespace SSIP.UserformControls
{
    partial class ProductQRControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductQRControl));
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.displaycode = new System.Windows.Forms.Label();
            this.printDocuQR = new System.Drawing.Printing.PrintDocument();
            this.printQRDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.BackColor = System.Drawing.Color.White;
            this.pic_qrcode.Location = new System.Drawing.Point(27, 26);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(280, 245);
            this.pic_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_qrcode.TabIndex = 2;
            this.pic_qrcode.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderRadius = 4;
            this.btn_close.CheckedState.Parent = this.btn_close;
            this.btn_close.CustomImages.Parent = this.btn_close;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.DisabledState.Parent = this.btn_close;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.HoverState.Parent = this.btn_close;
            this.btn_close.Location = new System.Drawing.Point(23, 226);
            this.btn_close.Name = "btn_close";
            this.btn_close.ShadowDecoration.Parent = this.btn_close;
            this.btn_close.Size = new System.Drawing.Size(120, 45);
            this.btn_close.TabIndex = 129;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseTransparentBackground = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(325, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 393);
            this.panel2.TabIndex = 131;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_productName.Location = new System.Drawing.Point(21, 343);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(127, 20);
            this.lbl_productName.TabIndex = 132;
            this.lbl_productName.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(61, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "QR Code:";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.BackColor = System.Drawing.Color.Transparent;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.Honeydew;
            this.productName.Location = new System.Drawing.Point(163, 343);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(122, 20);
            this.productName.TabIndex = 134;
            this.productName.Text = "Product Name";
            // 
            // displaycode
            // 
            this.displaycode.AutoSize = true;
            this.displaycode.BackColor = System.Drawing.Color.Transparent;
            this.displaycode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaycode.ForeColor = System.Drawing.Color.Honeydew;
            this.displaycode.Location = new System.Drawing.Point(166, 309);
            this.displaycode.Name = "displaycode";
            this.displaycode.Size = new System.Drawing.Size(82, 20);
            this.displaycode.TabIndex = 135;
            this.displaycode.Text = "QR Code";
            // 
            // printDocuQR
            // 
            this.printDocuQR.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocuQR_PrintPage);
            // 
            // printQRDialog1
            // 
            this.printQRDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printQRDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printQRDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printQRDialog1.Enabled = true;
            this.printQRDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printQRDialog1.Icon")));
            this.printQRDialog1.Name = "printQRDialog1";
            this.printQRDialog1.Visible = false;
            // 
            // ProductQRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.displaycode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pic_qrcode);
            this.Name = "ProductQRControl";
            this.Size = new System.Drawing.Size(493, 393);
            this.Load += new System.EventHandler(this.ProductQRControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_qrcode;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label displaycode;
        private System.Drawing.Printing.PrintDocument printDocuQR;
        private System.Windows.Forms.PrintPreviewDialog printQRDialog1;
    }
}
