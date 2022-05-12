
namespace SSIP.UserformControls
{
    partial class EmployeeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeControl));
            this.btn_viewEmp = new Guna.UI2.WinForms.Guna2Button();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_unameAccess = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.tb_searchEmployees = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_newEmp = new Guna.UI2.WinForms.Guna2Button();
            this.tb_qrcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.qrCodeControl1 = new SSIP.UserformControls.QRCodeControl();
            this.btn_addNew = new Guna.UI2.WinForms.Guna2Button();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.confirmAccessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_viewEmp
            // 
            this.btn_viewEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewEmp.BorderRadius = 4;
            this.btn_viewEmp.CheckedState.Parent = this.btn_viewEmp;
            this.btn_viewEmp.CustomImages.Parent = this.btn_viewEmp;
            this.btn_viewEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewEmp.DisabledState.Parent = this.btn_viewEmp;
            this.btn_viewEmp.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_viewEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewEmp.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_viewEmp.HoverState.Parent = this.btn_viewEmp;
            this.btn_viewEmp.Location = new System.Drawing.Point(834, 194);
            this.btn_viewEmp.Name = "btn_viewEmp";
            this.btn_viewEmp.ShadowDecoration.Parent = this.btn_viewEmp;
            this.btn_viewEmp.Size = new System.Drawing.Size(120, 45);
            this.btn_viewEmp.TabIndex = 126;
            this.btn_viewEmp.Text = "VIEW EMPLOYEES";
            this.btn_viewEmp.UseTransparentBackground = true;
            this.btn_viewEmp.Click += new System.EventHandler(this.btn_viewEmp_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.Transparent;
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
            this.tb_pass.Location = new System.Drawing.Point(9, 73);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.PlaceholderText = "Password";
            this.tb_pass.SelectedText = "";
            this.tb_pass.ShadowDecoration.Parent = this.tb_pass;
            this.tb_pass.Size = new System.Drawing.Size(165, 36);
            this.tb_pass.TabIndex = 123;
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // tb_unameAccess
            // 
            this.tb_unameAccess.BackColor = System.Drawing.Color.Transparent;
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
            this.tb_unameAccess.Location = new System.Drawing.Point(9, 28);
            this.tb_unameAccess.Name = "tb_unameAccess";
            this.tb_unameAccess.PasswordChar = '*';
            this.tb_unameAccess.PlaceholderText = "Username";
            this.tb_unameAccess.SelectedText = "";
            this.tb_unameAccess.ShadowDecoration.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Size = new System.Drawing.Size(165, 36);
            this.tb_unameAccess.TabIndex = 124;
            this.tb_unameAccess.TextChanged += new System.EventHandler(this.tb_unameAccess_TextChanged);
            // 
            // lbl_confirmAccess
            // 
            this.lbl_confirmAccess.AutoSize = true;
            this.lbl_confirmAccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmAccess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_confirmAccess.Location = new System.Drawing.Point(24, 5);
            this.lbl_confirmAccess.Name = "lbl_confirmAccess";
            this.lbl_confirmAccess.Size = new System.Drawing.Size(134, 20);
            this.lbl_confirmAccess.TabIndex = 122;
            this.lbl_confirmAccess.Text = "Confirm Access";
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.lbl_confirmAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_unameAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_pass);
            this.confirmAccessPanel.Location = new System.Drawing.Point(797, 326);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(183, 120);
            this.confirmAccessPanel.TabIndex = 134;
            // 
            // tb_searchEmployees
            // 
            this.tb_searchEmployees.BackColor = System.Drawing.Color.Transparent;
            this.tb_searchEmployees.BorderRadius = 4;
            this.tb_searchEmployees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchEmployees.DefaultText = "";
            this.tb_searchEmployees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchEmployees.DisabledState.Parent = this.tb_searchEmployees;
            this.tb_searchEmployees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchEmployees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchEmployees.FocusedState.Parent = this.tb_searchEmployees;
            this.tb_searchEmployees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_searchEmployees.ForeColor = System.Drawing.Color.Black;
            this.tb_searchEmployees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchEmployees.HoverState.Parent = this.tb_searchEmployees;
            this.tb_searchEmployees.Location = new System.Drawing.Point(48, 76);
            this.tb_searchEmployees.Name = "tb_searchEmployees";
            this.tb_searchEmployees.PasswordChar = '\0';
            this.tb_searchEmployees.PlaceholderText = "Search";
            this.tb_searchEmployees.SelectedText = "";
            this.tb_searchEmployees.ShadowDecoration.Parent = this.tb_searchEmployees;
            this.tb_searchEmployees.Size = new System.Drawing.Size(165, 36);
            this.tb_searchEmployees.TabIndex = 140;
            this.tb_searchEmployees.TextChanged += new System.EventHandler(this.tb_searchEmployees_TextChanged);
            this.tb_searchEmployees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_searchEmployees_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(307, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 73);
            this.label2.TabIndex = 121;
            this.label2.Text = "Employee";
            // 
            // btn_newEmp
            // 
            this.btn_newEmp.BackColor = System.Drawing.Color.Transparent;
            this.btn_newEmp.BorderRadius = 4;
            this.btn_newEmp.CheckedState.Parent = this.btn_newEmp;
            this.btn_newEmp.CustomImages.Parent = this.btn_newEmp;
            this.btn_newEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_newEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_newEmp.DisabledState.Parent = this.btn_newEmp;
            this.btn_newEmp.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_newEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_newEmp.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_newEmp.HoverState.Parent = this.btn_newEmp;
            this.btn_newEmp.Location = new System.Drawing.Point(833, 245);
            this.btn_newEmp.Name = "btn_newEmp";
            this.btn_newEmp.ShadowDecoration.Parent = this.btn_newEmp;
            this.btn_newEmp.Size = new System.Drawing.Size(120, 45);
            this.btn_newEmp.TabIndex = 105;
            this.btn_newEmp.Text = "CLEAR FIELDS";
            this.btn_newEmp.UseTransparentBackground = true;
            this.btn_newEmp.Click += new System.EventHandler(this.btn_newEmp_Click);
            // 
            // tb_qrcode
            // 
            this.tb_qrcode.BackColor = System.Drawing.Color.Transparent;
            this.tb_qrcode.BorderRadius = 4;
            this.tb_qrcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_qrcode.DefaultText = "";
            this.tb_qrcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_qrcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_qrcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_qrcode.DisabledState.Parent = this.tb_qrcode;
            this.tb_qrcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_qrcode.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_qrcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_qrcode.FocusedState.Parent = this.tb_qrcode;
            this.tb_qrcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_qrcode.ForeColor = System.Drawing.Color.Black;
            this.tb_qrcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_qrcode.HoverState.Parent = this.tb_qrcode;
            this.tb_qrcode.Location = new System.Drawing.Point(783, 45);
            this.tb_qrcode.Name = "tb_qrcode";
            this.tb_qrcode.PasswordChar = '\0';
            this.tb_qrcode.PlaceholderText = "Code";
            this.tb_qrcode.SelectedText = "";
            this.tb_qrcode.ShadowDecoration.Parent = this.tb_qrcode;
            this.tb_qrcode.Size = new System.Drawing.Size(112, 36);
            this.tb_qrcode.TabIndex = 134;
            this.tb_qrcode.Visible = false;
            // 
            // employeeGrid
            // 
            this.employeeGrid.AllowUserToAddRows = false;
            this.employeeGrid.AllowUserToDeleteRows = false;
            this.employeeGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.employeeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.employeeGrid.BackgroundColor = System.Drawing.Color.White;
            this.employeeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.employeeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeGrid.ColumnHeadersHeight = 40;
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.employeeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action});
            this.employeeGrid.Location = new System.Drawing.Point(48, 143);
            this.employeeGrid.Name = "employeeGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.employeeGrid.RowHeadersWidth = 58;
            this.employeeGrid.ShowCellErrors = false;
            this.employeeGrid.ShowCellToolTips = false;
            this.employeeGrid.Size = new System.Drawing.Size(732, 303);
            this.employeeGrid.TabIndex = 197;
            this.employeeGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.employeesGrid_EditingControlShowing);
            // 
            // qrCodeControl1
            // 
            this.qrCodeControl1.BackColor = System.Drawing.Color.Black;
            this.qrCodeControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("qrCodeControl1.BackgroundImage")));
            this.qrCodeControl1.Firstname = null;
            this.qrCodeControl1.Lastname = null;
            this.qrCodeControl1.Location = new System.Drawing.Point(976, 76);
            this.qrCodeControl1.Name = "qrCodeControl1";
            this.qrCodeControl1.QrCodePic = null;
            this.qrCodeControl1.Size = new System.Drawing.Size(78, 49);
            this.qrCodeControl1.TabIndex = 140;
            this.qrCodeControl1.Visible = false;
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
            this.btn_addNew.Location = new System.Drawing.Point(642, 471);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.ShadowDecoration.Parent = this.btn_addNew;
            this.btn_addNew.Size = new System.Drawing.Size(120, 45);
            this.btn_addNew.TabIndex = 198;
            this.btn_addNew.Text = "ADD EMPLOYEE";
            this.btn_addNew.UseTransparentBackground = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "Update"});
            this.Action.Name = "Action";
            this.Action.Width = 66;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.employeeGrid);
            this.Controls.Add(this.tb_searchEmployees);
            this.Controls.Add(this.qrCodeControl1);
            this.Controls.Add(this.btn_newEmp);
            this.Controls.Add(this.tb_qrcode);
            this.Controls.Add(this.confirmAccessPanel);
            this.Controls.Add(this.btn_viewEmp);
            this.Controls.Add(this.label2);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1134, 660);
            this.Load += new System.EventHandler(this.EmployeeControl_Load);
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_viewEmp;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private Guna.UI2.WinForms.Guna2TextBox tb_unameAccess;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_newEmp;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchEmployees;
        private QRCodeControl qrCodeControl1;
        private Guna.UI2.WinForms.Guna2TextBox tb_qrcode;
        private System.Windows.Forms.DataGridView employeeGrid;
        private Guna.UI2.WinForms.Guna2Button btn_addNew;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
    }
}
