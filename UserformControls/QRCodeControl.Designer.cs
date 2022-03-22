
namespace SSIP.UserformControls
{
    partial class QRCodeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeControl));
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_download = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.printQRCode = new System.Drawing.Printing.PrintDocument();
            this.printQRCodeDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_displayPosition = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.BackColor = System.Drawing.Color.White;
            this.pic_qrcode.Location = new System.Drawing.Point(187, 26);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(280, 245);
            this.pic_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_qrcode.TabIndex = 1;
            this.pic_qrcode.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 431);
            this.panel1.TabIndex = 2;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.BackColor = System.Drawing.Color.Transparent;
            this.lbl_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_code.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_code.Location = new System.Drawing.Point(328, 277);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(82, 20);
            this.lbl_code.TabIndex = 111;
            this.lbl_code.Text = "QR Code";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_fname.Location = new System.Drawing.Point(325, 311);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(96, 20);
            this.lbl_fname.TabIndex = 111;
            this.lbl_fname.Text = "FirstName:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_lname.Location = new System.Drawing.Point(328, 349);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(93, 20);
            this.lbl_lname.TabIndex = 111;
            this.lbl_lname.Text = "Lastname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(223, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "QR Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(223, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(224, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Lastname:";
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.Color.Transparent;
            this.btn_download.BorderRadius = 4;
            this.btn_download.CheckedState.Parent = this.btn_download;
            this.btn_download.CustomImages.Parent = this.btn_download;
            this.btn_download.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_download.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_download.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_download.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_download.DisabledState.Parent = this.btn_download;
            this.btn_download.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.HoverState.Parent = this.btn_download;
            this.btn_download.Location = new System.Drawing.Point(23, 175);
            this.btn_download.Name = "btn_download";
            this.btn_download.ShadowDecoration.Parent = this.btn_download;
            this.btn_download.Size = new System.Drawing.Size(120, 45);
            this.btn_download.TabIndex = 129;
            this.btn_download.Text = "DOWNLOAD";
            this.btn_download.UseTransparentBackground = true;
            this.btn_download.Visible = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.btn_download);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(499, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 431);
            this.panel2.TabIndex = 130;
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
            // printQRCode
            // 
            this.printQRCode.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printQRCode_PrintPage);
            // 
            // printQRCodeDialog1
            // 
            this.printQRCodeDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printQRCodeDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printQRCodeDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printQRCodeDialog1.Enabled = true;
            this.printQRCodeDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printQRCodeDialog1.Icon")));
            this.printQRCodeDialog1.Name = "printQRCodeDialog1";
            this.printQRCodeDialog1.Visible = false;
            // 
            // lbl_displayPosition
            // 
            this.lbl_displayPosition.AutoSize = true;
            this.lbl_displayPosition.BackColor = System.Drawing.Color.Transparent;
            this.lbl_displayPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_displayPosition.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_displayPosition.Location = new System.Drawing.Point(328, 381);
            this.lbl_displayPosition.Name = "lbl_displayPosition";
            this.lbl_displayPosition.Size = new System.Drawing.Size(73, 20);
            this.lbl_displayPosition.TabIndex = 111;
            this.lbl_displayPosition.Text = "Position";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.BackColor = System.Drawing.Color.Transparent;
            this.lbl_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_position.Location = new System.Drawing.Point(224, 381);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(78, 20);
            this.lbl_position.TabIndex = 111;
            this.lbl_position.Text = "Position:";
            // 
            // QRCodeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_displayPosition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.pic_qrcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_code);
            this.Name = "QRCodeControl";
            this.Size = new System.Drawing.Size(667, 431);
            this.Load += new System.EventHandler(this.QRCodeControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_qrcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_download;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Drawing.Printing.PrintDocument printQRCode;
        private System.Windows.Forms.PrintPreviewDialog printQRCodeDialog1;
        private System.Windows.Forms.Label lbl_displayPosition;
        private System.Windows.Forms.Label lbl_position;
    }
}
