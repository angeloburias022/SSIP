
namespace SSIP.Forms
{
    partial class FlickerTrace
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customersControl1 = new SSIP.UserformControls.CustomersControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersControl1
            // 
            this.customersControl1.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.customersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersControl1.Location = new System.Drawing.Point(0, 0);
            this.customersControl1.Name = "customersControl1";
            this.customersControl1.Size = new System.Drawing.Size(1112, 602);
            this.customersControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customersControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 602);
            this.panel1.TabIndex = 1;
            // 
            // FlickerTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 602);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FlickerTrace";
            this.Text = "FlickerTrace";
            this.Load += new System.EventHandler(this.FlickerTrace_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserformControls.CustomersControl customersControl1;
        private System.Windows.Forms.Panel panel1;
    }
}