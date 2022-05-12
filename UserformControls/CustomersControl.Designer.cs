
namespace SSIP.UserformControls
{
    partial class CustomersControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customersMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tb_searchCustomers = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_viewCus = new Guna.UI2.WinForms.Guna2Button();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.tb_unameAccess = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_addNew = new Guna.UI2.WinForms.Guna2Button();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_both = new System.Windows.Forms.RadioButton();
            this.rd_InActive = new System.Windows.Forms.RadioButton();
            this.rb_active = new System.Windows.Forms.RadioButton();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.confirmAccessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersMainPanel
            // 
            this.customersMainPanel.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.customersMainPanel.ColumnCount = 3;
            this.customersMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.333333F));
            this.customersMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.customersMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.customersMainPanel.Location = new System.Drawing.Point(1131, 97);
            this.customersMainPanel.Name = "customersMainPanel";
            this.customersMainPanel.RowCount = 3;
            this.customersMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24365F));
            this.customersMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.67513F));
            this.customersMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.33503F));
            this.customersMainPanel.Size = new System.Drawing.Size(94, 101);
            this.customersMainPanel.TabIndex = 165;
            this.customersMainPanel.Visible = false;
            // 
            // tb_searchCustomers
            // 
            this.tb_searchCustomers.BackColor = System.Drawing.Color.Transparent;
            this.tb_searchCustomers.BorderRadius = 4;
            this.tb_searchCustomers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchCustomers.DefaultText = "";
            this.tb_searchCustomers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchCustomers.DisabledState.Parent = this.tb_searchCustomers;
            this.tb_searchCustomers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchCustomers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchCustomers.FocusedState.Parent = this.tb_searchCustomers;
            this.tb_searchCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_searchCustomers.ForeColor = System.Drawing.Color.Black;
            this.tb_searchCustomers.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchCustomers.HoverState.Parent = this.tb_searchCustomers;
            this.tb_searchCustomers.Location = new System.Drawing.Point(30, 84);
            this.tb_searchCustomers.Name = "tb_searchCustomers";
            this.tb_searchCustomers.PasswordChar = '\0';
            this.tb_searchCustomers.PlaceholderText = "Search:";
            this.tb_searchCustomers.SelectedText = "";
            this.tb_searchCustomers.ShadowDecoration.Parent = this.tb_searchCustomers;
            this.tb_searchCustomers.Size = new System.Drawing.Size(165, 36);
            this.tb_searchCustomers.TabIndex = 170;
            this.tb_searchCustomers.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            this.tb_searchCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_searchCustomers_KeyPress);
            // 
            // btn_viewCus
            // 
            this.btn_viewCus.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewCus.BorderRadius = 4;
            this.btn_viewCus.CheckedState.Parent = this.btn_viewCus;
            this.btn_viewCus.CustomImages.Parent = this.btn_viewCus;
            this.btn_viewCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewCus.DisabledState.Parent = this.btn_viewCus;
            this.btn_viewCus.FillColor = System.Drawing.Color.Black;
            this.btn_viewCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewCus.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_viewCus.HoverState.Parent = this.btn_viewCus;
            this.btn_viewCus.Location = new System.Drawing.Point(468, 48);
            this.btn_viewCus.Name = "btn_viewCus";
            this.btn_viewCus.ShadowDecoration.Parent = this.btn_viewCus;
            this.btn_viewCus.Size = new System.Drawing.Size(120, 45);
            this.btn_viewCus.TabIndex = 157;
            this.btn_viewCus.Text = "VIEW CUSTOMERS";
            this.btn_viewCus.UseTransparentBackground = true;
            this.btn_viewCus.Visible = false;
            this.btn_viewCus.Click += new System.EventHandler(this.btn_viewCus_Click);
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.lbl_confirmAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_unameAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_pass);
            this.confirmAccessPanel.Location = new System.Drawing.Point(801, 315);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(207, 126);
            this.confirmAccessPanel.TabIndex = 195;
            // 
            // lbl_confirmAccess
            // 
            this.lbl_confirmAccess.AutoSize = true;
            this.lbl_confirmAccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmAccess.ForeColor = System.Drawing.Color.Black;
            this.lbl_confirmAccess.Location = new System.Drawing.Point(40, 9);
            this.lbl_confirmAccess.Name = "lbl_confirmAccess";
            this.lbl_confirmAccess.Size = new System.Drawing.Size(134, 20);
            this.lbl_confirmAccess.TabIndex = 122;
            this.lbl_confirmAccess.Text = "Confirm Access";
            // 
            // tb_unameAccess
            // 
            this.tb_unameAccess.BackColor = System.Drawing.Color.White;
            this.tb_unameAccess.BorderRadius = 4;
            this.tb_unameAccess.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_unameAccess.DefaultText = "";
            this.tb_unameAccess.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_unameAccess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_unameAccess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_unameAccess.DisabledState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_unameAccess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_unameAccess.FocusedState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_unameAccess.ForeColor = System.Drawing.Color.Black;
            this.tb_unameAccess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_unameAccess.HoverState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Location = new System.Drawing.Point(24, 32);
            this.tb_unameAccess.Name = "tb_unameAccess";
            this.tb_unameAccess.PasswordChar = '*';
            this.tb_unameAccess.PlaceholderText = "Username";
            this.tb_unameAccess.SelectedText = "";
            this.tb_unameAccess.ShadowDecoration.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Size = new System.Drawing.Size(165, 36);
            this.tb_unameAccess.TabIndex = 124;
            this.tb_unameAccess.TextChanged += new System.EventHandler(this.tb_unameAccess_TextChanged);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.White;
            this.tb_pass.BorderRadius = 4;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.DefaultText = "";
            this.tb_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.DisabledState.Parent = this.tb_pass;
            this.tb_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.Enabled = false;
            this.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.FocusedState.Parent = this.tb_pass;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_pass.ForeColor = System.Drawing.Color.Black;
            this.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.HoverState.Parent = this.tb_pass;
            this.tb_pass.Location = new System.Drawing.Point(24, 74);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.PlaceholderText = "Password";
            this.tb_pass.SelectedText = "";
            this.tb_pass.ShadowDecoration.Parent = this.tb_pass;
            this.tb_pass.Size = new System.Drawing.Size(165, 36);
            this.tb_pass.TabIndex = 123;
            // 
            // btn_addNew
            // 
            this.btn_addNew.BackColor = System.Drawing.Color.Transparent;
            this.btn_addNew.BorderRadius = 4;
            this.btn_addNew.CheckedState.Parent = this.btn_addNew;
            this.btn_addNew.CustomImages.Parent = this.btn_addNew;
            this.btn_addNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addNew.DisabledState.Parent = this.btn_addNew;
            this.btn_addNew.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addNew.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_addNew.HoverState.Parent = this.btn_addNew;
            this.btn_addNew.Location = new System.Drawing.Point(604, 484);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.ShadowDecoration.Parent = this.btn_addNew;
            this.btn_addNew.Size = new System.Drawing.Size(120, 45);
            this.btn_addNew.TabIndex = 157;
            this.btn_addNew.Text = "ADD CUSTOMER";
            this.btn_addNew.UseTransparentBackground = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // customersGrid
            // 
            this.customersGrid.AllowUserToAddRows = false;
            this.customersGrid.AllowUserToDeleteRows = false;
            this.customersGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.customersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.customersGrid.BackgroundColor = System.Drawing.Color.White;
            this.customersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customersGrid.ColumnHeadersHeight = 40;
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action});
            this.customersGrid.Location = new System.Drawing.Point(30, 138);
            this.customersGrid.Name = "customersGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customersGrid.RowHeadersWidth = 58;
            this.customersGrid.ShowCellErrors = false;
            this.customersGrid.ShowCellToolTips = false;
            this.customersGrid.Size = new System.Drawing.Size(755, 303);
            this.customersGrid.TabIndex = 196;
            this.customersGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.customersGrid_EditingControlShowing);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rb_both);
            this.panel2.Controls.Add(this.rd_InActive);
            this.panel2.Controls.Add(this.rb_active);
            this.panel2.Location = new System.Drawing.Point(801, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 138);
            this.panel2.TabIndex = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status Filter:";
            // 
            // rb_both
            // 
            this.rb_both.AutoSize = true;
            this.rb_both.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_both.Location = new System.Drawing.Point(3, 104);
            this.rb_both.Name = "rb_both";
            this.rb_both.Size = new System.Drawing.Size(142, 24);
            this.rb_both.TabIndex = 0;
            this.rb_both.TabStop = true;
            this.rb_both.Text = "View Customers";
            this.rb_both.UseVisualStyleBackColor = true;
            this.rb_both.CheckedChanged += new System.EventHandler(this.rb_both_CheckedChanged);
            // 
            // rd_InActive
            // 
            this.rd_InActive.AutoSize = true;
            this.rd_InActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_InActive.Location = new System.Drawing.Point(3, 74);
            this.rd_InActive.Name = "rd_InActive";
            this.rd_InActive.Size = new System.Drawing.Size(170, 24);
            this.rd_InActive.TabIndex = 0;
            this.rd_InActive.TabStop = true;
            this.rd_InActive.Text = "In-Active Customers";
            this.rd_InActive.UseVisualStyleBackColor = true;
            this.rd_InActive.CheckedChanged += new System.EventHandler(this.rd_InActive_CheckedChanged);
            // 
            // rb_active
            // 
            this.rb_active.AutoSize = true;
            this.rb_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_active.Location = new System.Drawing.Point(3, 47);
            this.rb_active.Name = "rb_active";
            this.rb_active.Size = new System.Drawing.Size(151, 24);
            this.rb_active.TabIndex = 0;
            this.rb_active.TabStop = true;
            this.rb_active.Text = "Active Customers";
            this.rb_active.UseVisualStyleBackColor = true;
            this.rb_active.CheckedChanged += new System.EventHandler(this.rb_active_CheckedChanged);
            // 
            // Action
            // 
            this.Action.DividerWidth = 10;
            this.Action.DropDownWidth = 3;
            this.Action.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "Update"});
            this.Action.Name = "Action";
            this.Action.ToolTipText = "Action";
            this.Action.Width = 76;
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customersGrid);
            this.Controls.Add(this.confirmAccessPanel);
            this.Controls.Add(this.tb_searchCustomers);
            this.Controls.Add(this.customersMainPanel);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.btn_viewCus);
            this.DoubleBuffered = true;
            this.Name = "CustomersControl";
            this.Size = new System.Drawing.Size(1021, 631);
            this.Load += new System.EventHandler(this.CustomersControl_Load);
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customersMainPanel;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchCustomers;
        private Guna.UI2.WinForms.Guna2Button btn_viewCus;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_unameAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private Guna.UI2.WinForms.Guna2Button btn_addNew;
        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_both;
        private System.Windows.Forms.RadioButton rd_InActive;
        private System.Windows.Forms.RadioButton rb_active;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
    }
}
