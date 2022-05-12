
namespace SSIP.Forms
{
    partial class CustomerTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTransactions));
            this.historyGrid = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_mobile = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.btn_newtransaction = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_filter = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // historyGrid
            // 
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Location = new System.Drawing.Point(408, 89);
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.ReadOnly = true;
            this.historyGrid.Size = new System.Drawing.Size(516, 301);
            this.historyGrid.TabIndex = 0;
            this.historyGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyGrid_CellDoubleClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LimeGreen;
            this.label20.Location = new System.Drawing.Point(73, 128);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(216, 29);
            this.label20.TabIndex = 157;
            this.label20.Text = "Customer Profile:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(99, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 157;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(99, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 157;
            this.label2.Text = "Lastname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(95, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 157;
            this.label3.Text = "Mobile no:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(56, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 157;
            this.label4.Text = "Telephone no:";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tel.Location = new System.Drawing.Point(222, 297);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(148, 24);
            this.lbl_tel.TabIndex = 158;
            this.lbl_tel.Text = "Telephone no:";
            // 
            // lbl_mobile
            // 
            this.lbl_mobile.AutoSize = true;
            this.lbl_mobile.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mobile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_mobile.Location = new System.Drawing.Point(222, 261);
            this.lbl_mobile.Name = "lbl_mobile";
            this.lbl_mobile.Size = new System.Drawing.Size(109, 24);
            this.lbl_mobile.TabIndex = 159;
            this.lbl_mobile.Text = "Mobile no:";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_lname.Location = new System.Drawing.Point(222, 219);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(105, 24);
            this.lbl_lname.TabIndex = 160;
            this.lbl_lname.Text = "Lastname:";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_fname.Location = new System.Drawing.Point(222, 182);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(67, 24);
            this.lbl_fname.TabIndex = 161;
            this.lbl_fname.Text = "fname";
            // 
            // btn_newtransaction
            // 
            this.btn_newtransaction.BackColor = System.Drawing.Color.Transparent;
            this.btn_newtransaction.BorderRadius = 4;
            this.btn_newtransaction.CheckedState.Parent = this.btn_newtransaction;
            this.btn_newtransaction.CustomImages.Parent = this.btn_newtransaction;
            this.btn_newtransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newtransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_newtransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newtransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_newtransaction.DisabledState.Parent = this.btn_newtransaction;
            this.btn_newtransaction.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_newtransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_newtransaction.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_newtransaction.HoverState.Parent = this.btn_newtransaction;
            this.btn_newtransaction.Location = new System.Drawing.Point(804, 396);
            this.btn_newtransaction.Name = "btn_newtransaction";
            this.btn_newtransaction.ShadowDecoration.Parent = this.btn_newtransaction;
            this.btn_newtransaction.Size = new System.Drawing.Size(120, 45);
            this.btn_newtransaction.TabIndex = 162;
            this.btn_newtransaction.Text = "NEW TRANSACTION";
            this.btn_newtransaction.UseTransparentBackground = true;
            this.btn_newtransaction.Click += new System.EventHandler(this.btn_newtransaction_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(184, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(530, 55);
            this.label5.TabIndex = 163;
            this.label5.Text = "Customer\'s Transaction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(752, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 186;
            this.label6.Text = "Filter:";
            // 
            // cmb_filter
            // 
            this.cmb_filter.BackColor = System.Drawing.Color.Transparent;
            this.cmb_filter.BorderRadius = 4;
            this.cmb_filter.DisabledState.Parent = this.cmb_filter;
            this.cmb_filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_filter.FocusedState.Parent = this.cmb_filter;
            this.cmb_filter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_filter.ForeColor = System.Drawing.Color.Black;
            this.cmb_filter.HoverState.Parent = this.cmb_filter;
            this.cmb_filter.ItemHeight = 30;
            this.cmb_filter.Items.AddRange(new object[] {
            "Dispatch",
            "Done / Not-paid",
            "Done / Paid",
            "Schedule"});
            this.cmb_filter.ItemsAppearance.Parent = this.cmb_filter;
            this.cmb_filter.Location = new System.Drawing.Point(756, 47);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.ShadowDecoration.Parent = this.cmb_filter;
            this.cmb_filter.Size = new System.Drawing.Size(168, 36);
            this.cmb_filter.StartIndex = 0;
            this.cmb_filter.TabIndex = 185;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // CustomerTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_newtransaction);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_mobile);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.historyGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Transactions";
            this.Load += new System.EventHandler(this.CustomerTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historyGrid;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_mobile;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_fname;
        private Guna.UI2.WinForms.Guna2Button btn_newtransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_filter;
    }
}