
namespace SSIP.UserformControls
{
    partial class AuditControl
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
            this.auditGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.access_panel = new System.Windows.Forms.Panel();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.btn_access = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.tb_unameAccess = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.auditGrid)).BeginInit();
            this.access_panel.SuspendLayout();
            this.confirmAccessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // auditGrid
            // 
            this.auditGrid.AllowUserToAddRows = false;
            this.auditGrid.AllowUserToDeleteRows = false;
            this.auditGrid.AllowUserToOrderColumns = true;
            this.auditGrid.AllowUserToResizeColumns = false;
            this.auditGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.auditGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.auditGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.auditGrid.BackgroundColor = System.Drawing.Color.White;
            this.auditGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.auditGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.auditGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.auditGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.auditGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.auditGrid.EnableHeadersVisualStyles = false;
            this.auditGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.auditGrid.Location = new System.Drawing.Point(39, 95);
            this.auditGrid.Name = "auditGrid";
            this.auditGrid.ReadOnly = true;
            this.auditGrid.RowHeadersVisible = false;
            this.auditGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.auditGrid.Size = new System.Drawing.Size(888, 286);
            this.auditGrid.TabIndex = 0;
            this.auditGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.auditGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.auditGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.auditGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.auditGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.auditGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.auditGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.auditGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.auditGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.auditGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.auditGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.auditGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.auditGrid.ThemeStyle.HeaderStyle.Height = 23;
            this.auditGrid.ThemeStyle.ReadOnly = true;
            this.auditGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.auditGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.auditGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.auditGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.auditGrid.ThemeStyle.RowsStyle.Height = 22;
            this.auditGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.auditGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // access_panel
            // 
            this.access_panel.BackColor = System.Drawing.Color.Transparent;
            this.access_panel.Controls.Add(this.confirmAccessPanel);
            this.access_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.access_panel.Location = new System.Drawing.Point(0, 0);
            this.access_panel.Name = "access_panel";
            this.access_panel.Size = new System.Drawing.Size(1055, 518);
            this.access_panel.TabIndex = 1;
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.btn_access);
            this.confirmAccessPanel.Controls.Add(this.lbl_confirmAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_unameAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_pass);
            this.confirmAccessPanel.Location = new System.Drawing.Point(295, 140);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(448, 241);
            this.confirmAccessPanel.TabIndex = 174;
            // 
            // btn_access
            // 
            this.btn_access.BackColor = System.Drawing.Color.Transparent;
            this.btn_access.BorderRadius = 4;
            this.btn_access.CheckedState.Parent = this.btn_access;
            this.btn_access.CustomImages.Parent = this.btn_access;
            this.btn_access.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_access.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_access.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_access.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_access.DisabledState.Parent = this.btn_access;
            this.btn_access.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_access.ForeColor = System.Drawing.Color.White;
            this.btn_access.HoverState.Parent = this.btn_access;
            this.btn_access.Location = new System.Drawing.Point(183, 186);
            this.btn_access.Name = "btn_access";
            this.btn_access.ShadowDecoration.Parent = this.btn_access;
            this.btn_access.Size = new System.Drawing.Size(111, 40);
            this.btn_access.TabIndex = 171;
            this.btn_access.Text = "ACCESS";
            this.btn_access.Click += new System.EventHandler(this.btn_access_Click);
            // 
            // lbl_confirmAccess
            // 
            this.lbl_confirmAccess.AutoSize = true;
            this.lbl_confirmAccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmAccess.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_confirmAccess.Location = new System.Drawing.Point(65, 40);
            this.lbl_confirmAccess.Name = "lbl_confirmAccess";
            this.lbl_confirmAccess.Size = new System.Drawing.Size(331, 20);
            this.lbl_confirmAccess.TabIndex = 122;
            this.lbl_confirmAccess.Text = "HIGHER AUTHORIZED PERSON ONLY";
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
            this.tb_unameAccess.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_unameAccess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_unameAccess.FocusedState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_unameAccess.ForeColor = System.Drawing.Color.Black;
            this.tb_unameAccess.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_unameAccess.HoverState.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Location = new System.Drawing.Point(154, 89);
            this.tb_unameAccess.Name = "tb_unameAccess";
            this.tb_unameAccess.PasswordChar = '\0';
            this.tb_unameAccess.PlaceholderText = "Username";
            this.tb_unameAccess.SelectedText = "";
            this.tb_unameAccess.ShadowDecoration.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Size = new System.Drawing.Size(165, 36);
            this.tb_unameAccess.TabIndex = 124;
            this.tb_unameAccess.TextChanged += new System.EventHandler(this.tb_unameAccess_TextChanged);
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
            this.tb_pass.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.FocusedState.Parent = this.tb_pass;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_pass.ForeColor = System.Drawing.Color.Black;
            this.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.HoverState.Parent = this.tb_pass;
            this.tb_pass.Location = new System.Drawing.Point(154, 134);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.PlaceholderText = "Password";
            this.tb_pass.SelectedText = "";
            this.tb_pass.ShadowDecoration.Parent = this.tb_pass;
            this.tb_pass.Size = new System.Drawing.Size(165, 36);
            this.tb_pass.TabIndex = 123;
            // 
            // AuditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.access_panel);
            this.Controls.Add(this.auditGrid);
            this.Name = "AuditControl";
            this.Size = new System.Drawing.Size(1055, 518);
            this.Load += new System.EventHandler(this.AuditControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auditGrid)).EndInit();
            this.access_panel.ResumeLayout(false);
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView auditGrid;
        private System.Windows.Forms.Panel access_panel;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_unameAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private Guna.UI2.WinForms.Guna2Button btn_access;
    }
}
