
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
            this.customersMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.btn_addCus = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.tb_unameAccess = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_personID = new System.Windows.Forms.Label();
            this.tb_personID = new System.Windows.Forms.TextBox();
            this.tb_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.btn_viewCus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateCus = new Guna.UI2.WinForms.Guna2Button();
            this.btn_saveCus = new Guna.UI2.WinForms.Guna2Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cmb_City = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_tel = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_barangay = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_mobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_street = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_houseNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.customersMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.confirmAccessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersMainPanel
            // 
            this.customersMainPanel.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.customersMainPanel.ColumnCount = 3;
            this.customersMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.333333F));
            this.customersMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.customersMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.customersMainPanel.Controls.Add(this.tb_search, 1, 0);
            this.customersMainPanel.Controls.Add(this.customersGrid, 1, 1);
            this.customersMainPanel.Controls.Add(this.btn_addCus, 1, 2);
            this.customersMainPanel.Location = new System.Drawing.Point(972, 100);
            this.customersMainPanel.Name = "customersMainPanel";
            this.customersMainPanel.RowCount = 3;
            this.customersMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24365F));
            this.customersMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.67513F));
            this.customersMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.33503F));
            this.customersMainPanel.Size = new System.Drawing.Size(450, 328);
            this.customersMainPanel.TabIndex = 165;
            this.customersMainPanel.Visible = false;
            // 
            // customersGrid
            // 
            this.customersGrid.AllowUserToAddRows = false;
            this.customersGrid.AllowUserToDeleteRows = false;
            this.customersGrid.AllowUserToOrderColumns = true;
            this.customersGrid.AllowUserToResizeColumns = false;
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersGrid.Location = new System.Drawing.Point(26, 56);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.ReadOnly = true;
            this.customersGrid.Size = new System.Drawing.Size(399, 195);
            this.customersGrid.TabIndex = 0;
            this.customersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGrid_CellDoubleClick);
            // 
            // btn_addCus
            // 
            this.btn_addCus.BackColor = System.Drawing.Color.Transparent;
            this.btn_addCus.BorderRadius = 4;
            this.btn_addCus.CheckedState.Parent = this.btn_addCus;
            this.btn_addCus.CustomImages.Parent = this.btn_addCus;
            this.btn_addCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addCus.DisabledState.Parent = this.btn_addCus;
            this.btn_addCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addCus.ForeColor = System.Drawing.Color.White;
            this.btn_addCus.HoverState.Parent = this.btn_addCus;
            this.btn_addCus.Location = new System.Drawing.Point(26, 257);
            this.btn_addCus.Name = "btn_addCus";
            this.btn_addCus.ShadowDecoration.Parent = this.btn_addCus;
            this.btn_addCus.Size = new System.Drawing.Size(112, 43);
            this.btn_addCus.TabIndex = 105;
            this.btn_addCus.Text = "ADD CUSTOMER";
            this.btn_addCus.UseTransparentBackground = true;
            this.btn_addCus.Click += new System.EventHandler(this.btn_addCus_Click);
            // 
            // lbl_confirmAccess
            // 
            this.lbl_confirmAccess.AutoSize = true;
            this.lbl_confirmAccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmAccess.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_confirmAccess.Location = new System.Drawing.Point(40, 9);
            this.lbl_confirmAccess.Name = "lbl_confirmAccess";
            this.lbl_confirmAccess.Size = new System.Drawing.Size(134, 20);
            this.lbl_confirmAccess.TabIndex = 122;
            this.lbl_confirmAccess.Text = "Confirm Access";
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
            this.tb_unameAccess.Location = new System.Drawing.Point(24, 32);
            this.tb_unameAccess.Name = "tb_unameAccess";
            this.tb_unameAccess.PasswordChar = '\0';
            this.tb_unameAccess.PlaceholderText = "Username";
            this.tb_unameAccess.SelectedText = "";
            this.tb_unameAccess.ShadowDecoration.Parent = this.tb_unameAccess;
            this.tb_unameAccess.Size = new System.Drawing.Size(165, 36);
            this.tb_unameAccess.TabIndex = 124;
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
            this.tb_pass.FillColor = System.Drawing.Color.WhiteSmoke;
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
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // lbl_personID
            // 
            this.lbl_personID.AutoSize = true;
            this.lbl_personID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personID.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_personID.Location = new System.Drawing.Point(268, 64);
            this.lbl_personID.Name = "lbl_personID";
            this.lbl_personID.Size = new System.Drawing.Size(89, 20);
            this.lbl_personID.TabIndex = 164;
            this.lbl_personID.Text = "Person ID";
            this.lbl_personID.Visible = false;
            // 
            // tb_personID
            // 
            this.tb_personID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_personID.Location = new System.Drawing.Point(273, 86);
            this.tb_personID.Multiline = true;
            this.tb_personID.Name = "tb_personID";
            this.tb_personID.ReadOnly = true;
            this.tb_personID.Size = new System.Drawing.Size(100, 33);
            this.tb_personID.TabIndex = 163;
            this.tb_personID.Text = "0";
            this.tb_personID.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Transparent;
            this.tb_email.BorderRadius = 4;
            this.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_email.DefaultText = "";
            this.tb_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_email.DisabledState.Parent = this.tb_email;
            this.tb_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_email.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_email.FocusedState.Parent = this.tb_email;
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_email.ForeColor = System.Drawing.Color.Black;
            this.tb_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_email.HoverState.Parent = this.tb_email;
            this.tb_email.Location = new System.Drawing.Point(205, 306);
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.PlaceholderText = "Email Address";
            this.tb_email.SelectedText = "";
            this.tb_email.ShadowDecoration.Parent = this.tb_email;
            this.tb_email.Size = new System.Drawing.Size(165, 36);
            this.tb_email.TabIndex = 162;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_email.Location = new System.Drawing.Point(204, 283);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(53, 20);
            this.lbl_email.TabIndex = 161;
            this.lbl_email.Text = "Email";
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.lbl_confirmAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_unameAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_pass);
            this.confirmAccessPanel.Location = new System.Drawing.Point(759, 181);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(207, 126);
            this.confirmAccessPanel.TabIndex = 160;
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
            this.btn_viewCus.Enabled = false;
            this.btn_viewCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewCus.ForeColor = System.Drawing.Color.White;
            this.btn_viewCus.HoverState.Parent = this.btn_viewCus;
            this.btn_viewCus.Location = new System.Drawing.Point(803, 125);
            this.btn_viewCus.Name = "btn_viewCus";
            this.btn_viewCus.ShadowDecoration.Parent = this.btn_viewCus;
            this.btn_viewCus.Size = new System.Drawing.Size(120, 45);
            this.btn_viewCus.TabIndex = 157;
            this.btn_viewCus.Text = "VIEW CUSTOMERS";
            this.btn_viewCus.UseTransparentBackground = true;
            this.btn_viewCus.Click += new System.EventHandler(this.btn_viewCus_Click);
            // 
            // btn_updateCus
            // 
            this.btn_updateCus.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateCus.BorderRadius = 4;
            this.btn_updateCus.CheckedState.Parent = this.btn_updateCus;
            this.btn_updateCus.CustomImages.Parent = this.btn_updateCus;
            this.btn_updateCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateCus.DisabledState.Parent = this.btn_updateCus;
            this.btn_updateCus.Enabled = false;
            this.btn_updateCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_updateCus.ForeColor = System.Drawing.Color.White;
            this.btn_updateCus.HoverState.Parent = this.btn_updateCus;
            this.btn_updateCus.Location = new System.Drawing.Point(803, 313);
            this.btn_updateCus.Name = "btn_updateCus";
            this.btn_updateCus.ShadowDecoration.Parent = this.btn_updateCus;
            this.btn_updateCus.Size = new System.Drawing.Size(120, 45);
            this.btn_updateCus.TabIndex = 158;
            this.btn_updateCus.Text = "UPDATE";
            this.btn_updateCus.UseTransparentBackground = true;
            this.btn_updateCus.Visible = false;
            this.btn_updateCus.Click += new System.EventHandler(this.btn_updateCus_Click);
            // 
            // btn_saveCus
            // 
            this.btn_saveCus.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveCus.BorderRadius = 4;
            this.btn_saveCus.CheckedState.Parent = this.btn_saveCus;
            this.btn_saveCus.CustomImages.Parent = this.btn_saveCus;
            this.btn_saveCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_saveCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_saveCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_saveCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_saveCus.DisabledState.Parent = this.btn_saveCus;
            this.btn_saveCus.Enabled = false;
            this.btn_saveCus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_saveCus.ForeColor = System.Drawing.Color.White;
            this.btn_saveCus.HoverState.Parent = this.btn_saveCus;
            this.btn_saveCus.Location = new System.Drawing.Point(803, 364);
            this.btn_saveCus.Name = "btn_saveCus";
            this.btn_saveCus.ShadowDecoration.Parent = this.btn_saveCus;
            this.btn_saveCus.Size = new System.Drawing.Size(120, 45);
            this.btn_saveCus.TabIndex = 159;
            this.btn_saveCus.Text = "SAVE";
            this.btn_saveCus.UseTransparentBackground = true;
            this.btn_saveCus.Click += new System.EventHandler(this.btn_saveCus_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LimeGreen;
            this.label20.Location = new System.Drawing.Point(14, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(237, 31);
            this.label20.TabIndex = 156;
            this.label20.Text = "Personal Details:";
            // 
            // cmb_City
            // 
            this.cmb_City.BackColor = System.Drawing.Color.Transparent;
            this.cmb_City.BorderRadius = 4;
            this.cmb_City.DisabledState.Parent = this.cmb_City;
            this.cmb_City.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_City.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_City.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_City.FocusedState.Parent = this.cmb_City;
            this.cmb_City.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_City.ForeColor = System.Drawing.Color.Black;
            this.cmb_City.HoverState.Parent = this.cmb_City;
            this.cmb_City.ItemHeight = 30;
            this.cmb_City.Items.AddRange(new object[] {
            "Pasay",
            "Pasig",
            "Paranaque",
            "Makati",
            "Mandaluyong",
            "Muntinlupa"});
            this.cmb_City.ItemsAppearance.Parent = this.cmb_City;
            this.cmb_City.Location = new System.Drawing.Point(578, 232);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.ShadowDecoration.Parent = this.cmb_City;
            this.cmb_City.Size = new System.Drawing.Size(165, 36);
            this.cmb_City.TabIndex = 155;
            // 
            // tb_tel
            // 
            this.tb_tel.BackColor = System.Drawing.Color.Transparent;
            this.tb_tel.BorderRadius = 4;
            this.tb_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tel.DefaultText = "";
            this.tb_tel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_tel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_tel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_tel.DisabledState.Parent = this.tb_tel;
            this.tb_tel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_tel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_tel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_tel.FocusedState.Parent = this.tb_tel;
            this.tb_tel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tel.ForeColor = System.Drawing.Color.Black;
            this.tb_tel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_tel.HoverState.Parent = this.tb_tel;
            this.tb_tel.Location = new System.Drawing.Point(577, 157);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.PasswordChar = '\0';
            this.tb_tel.PlaceholderText = "Tel #";
            this.tb_tel.SelectedText = "";
            this.tb_tel.ShadowDecoration.Parent = this.tb_tel;
            this.tb_tel.Size = new System.Drawing.Size(165, 36);
            this.tb_tel.TabIndex = 153;
            // 
            // tb_barangay
            // 
            this.tb_barangay.BackColor = System.Drawing.Color.Transparent;
            this.tb_barangay.BorderRadius = 4;
            this.tb_barangay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_barangay.DefaultText = "";
            this.tb_barangay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_barangay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_barangay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_barangay.DisabledState.Parent = this.tb_barangay;
            this.tb_barangay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_barangay.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_barangay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_barangay.FocusedState.Parent = this.tb_barangay;
            this.tb_barangay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_barangay.ForeColor = System.Drawing.Color.Black;
            this.tb_barangay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_barangay.HoverState.Parent = this.tb_barangay;
            this.tb_barangay.Location = new System.Drawing.Point(393, 232);
            this.tb_barangay.Name = "tb_barangay";
            this.tb_barangay.PasswordChar = '\0';
            this.tb_barangay.PlaceholderText = "Barangay";
            this.tb_barangay.SelectedText = "";
            this.tb_barangay.ShadowDecoration.Parent = this.tb_barangay;
            this.tb_barangay.Size = new System.Drawing.Size(165, 36);
            this.tb_barangay.TabIndex = 152;
            // 
            // tb_mobile
            // 
            this.tb_mobile.BackColor = System.Drawing.Color.Transparent;
            this.tb_mobile.BorderRadius = 4;
            this.tb_mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_mobile.DefaultText = "";
            this.tb_mobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_mobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_mobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_mobile.DisabledState.Parent = this.tb_mobile;
            this.tb_mobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_mobile.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_mobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_mobile.FocusedState.Parent = this.tb_mobile;
            this.tb_mobile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_mobile.ForeColor = System.Drawing.Color.Black;
            this.tb_mobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_mobile.HoverState.Parent = this.tb_mobile;
            this.tb_mobile.Location = new System.Drawing.Point(393, 157);
            this.tb_mobile.Name = "tb_mobile";
            this.tb_mobile.PasswordChar = '\0';
            this.tb_mobile.PlaceholderText = "Mobile #";
            this.tb_mobile.SelectedText = "";
            this.tb_mobile.ShadowDecoration.Parent = this.tb_mobile;
            this.tb_mobile.Size = new System.Drawing.Size(165, 36);
            this.tb_mobile.TabIndex = 151;
            // 
            // tb_street
            // 
            this.tb_street.BackColor = System.Drawing.Color.Transparent;
            this.tb_street.BorderRadius = 4;
            this.tb_street.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_street.DefaultText = "";
            this.tb_street.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_street.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_street.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_street.DisabledState.Parent = this.tb_street;
            this.tb_street.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_street.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_street.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_street.FocusedState.Parent = this.tb_street;
            this.tb_street.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_street.ForeColor = System.Drawing.Color.Black;
            this.tb_street.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_street.HoverState.Parent = this.tb_street;
            this.tb_street.Location = new System.Drawing.Point(208, 232);
            this.tb_street.Name = "tb_street";
            this.tb_street.PasswordChar = '\0';
            this.tb_street.PlaceholderText = "Street";
            this.tb_street.SelectedText = "";
            this.tb_street.ShadowDecoration.Parent = this.tb_street;
            this.tb_street.Size = new System.Drawing.Size(165, 36);
            this.tb_street.TabIndex = 150;
            // 
            // tb_lname
            // 
            this.tb_lname.BackColor = System.Drawing.Color.Transparent;
            this.tb_lname.BorderRadius = 4;
            this.tb_lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_lname.DefaultText = "";
            this.tb_lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_lname.DisabledState.Parent = this.tb_lname;
            this.tb_lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_lname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_lname.FocusedState.Parent = this.tb_lname;
            this.tb_lname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_lname.ForeColor = System.Drawing.Color.Black;
            this.tb_lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_lname.HoverState.Parent = this.tb_lname;
            this.tb_lname.Location = new System.Drawing.Point(206, 157);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.PasswordChar = '\0';
            this.tb_lname.PlaceholderText = "Lastname";
            this.tb_lname.SelectedText = "";
            this.tb_lname.ShadowDecoration.Parent = this.tb_lname;
            this.tb_lname.Size = new System.Drawing.Size(165, 36);
            this.tb_lname.TabIndex = 149;
            // 
            // tb_houseNo
            // 
            this.tb_houseNo.BackColor = System.Drawing.Color.Transparent;
            this.tb_houseNo.BorderRadius = 4;
            this.tb_houseNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_houseNo.DefaultText = "";
            this.tb_houseNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_houseNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_houseNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_houseNo.DisabledState.Parent = this.tb_houseNo;
            this.tb_houseNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_houseNo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_houseNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_houseNo.FocusedState.Parent = this.tb_houseNo;
            this.tb_houseNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_houseNo.ForeColor = System.Drawing.Color.Black;
            this.tb_houseNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_houseNo.HoverState.Parent = this.tb_houseNo;
            this.tb_houseNo.Location = new System.Drawing.Point(23, 232);
            this.tb_houseNo.Name = "tb_houseNo";
            this.tb_houseNo.PasswordChar = '\0';
            this.tb_houseNo.PlaceholderText = "House #";
            this.tb_houseNo.SelectedText = "";
            this.tb_houseNo.ShadowDecoration.Parent = this.tb_houseNo;
            this.tb_houseNo.Size = new System.Drawing.Size(165, 36);
            this.tb_houseNo.TabIndex = 154;
            // 
            // tb_fname
            // 
            this.tb_fname.BackColor = System.Drawing.Color.Transparent;
            this.tb_fname.BorderRadius = 4;
            this.tb_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_fname.DefaultText = "";
            this.tb_fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_fname.DisabledState.Parent = this.tb_fname;
            this.tb_fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_fname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_fname.FocusedState.Parent = this.tb_fname;
            this.tb_fname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_fname.ForeColor = System.Drawing.Color.Black;
            this.tb_fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_fname.HoverState.Parent = this.tb_fname;
            this.tb_fname.Location = new System.Drawing.Point(20, 157);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.PasswordChar = '\0';
            this.tb_fname.PlaceholderText = "Firstname";
            this.tb_fname.SelectedText = "";
            this.tb_fname.ShadowDecoration.Parent = this.tb_fname;
            this.tb_fname.Size = new System.Drawing.Size(165, 36);
            this.tb_fname.TabIndex = 148;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Honeydew;
            this.label15.Location = new System.Drawing.Point(574, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 141;
            this.label15.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Honeydew;
            this.label10.Location = new System.Drawing.Point(392, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 142;
            this.label10.Text = "Barangay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(203, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 140;
            this.label6.Text = "Street:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(571, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 144;
            this.label9.Text = "Tel No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(204, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 143;
            this.label5.Text = "LastName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(389, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 145;
            this.label8.Text = "Mobile No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(19, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 147;
            this.label12.Text = "House No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 146;
            this.label4.Text = "FirstName:";
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.Transparent;
            this.cmb_status.BorderRadius = 4;
            this.cmb_status.DisabledState.Parent = this.cmb_status;
            this.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_status.FocusedState.Parent = this.cmb_status;
            this.cmb_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_status.ForeColor = System.Drawing.Color.Black;
            this.cmb_status.HoverState.Parent = this.cmb_status;
            this.cmb_status.ItemHeight = 30;
            this.cmb_status.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.cmb_status.ItemsAppearance.Parent = this.cmb_status;
            this.cmb_status.Location = new System.Drawing.Point(23, 306);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.ShadowDecoration.Parent = this.cmb_status;
            this.cmb_status.Size = new System.Drawing.Size(165, 36);
            this.cmb_status.TabIndex = 167;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(19, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 166;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(437, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 42);
            this.label1.TabIndex = 168;
            this.label1.Text = "Customer";
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.Transparent;
            this.tb_search.BorderRadius = 4;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.DefaultText = "";
            this.tb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.DisabledState.Parent = this.tb_search;
            this.tb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_search.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.FocusedState.Parent = this.tb_search;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_search.ForeColor = System.Drawing.Color.Black;
            this.tb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_search.HoverState.Parent = this.tb_search;
            this.tb_search.Location = new System.Drawing.Point(26, 3);
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PlaceholderText = "Search:";
            this.tb_search.SelectedText = "";
            this.tb_search.ShadowDecoration.Parent = this.tb_search;
            this.tb_search.Size = new System.Drawing.Size(165, 36);
            this.tb_search.TabIndex = 170;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customersMainPanel);
            this.Controls.Add(this.lbl_personID);
            this.Controls.Add(this.tb_personID);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.confirmAccessPanel);
            this.Controls.Add(this.btn_viewCus);
            this.Controls.Add(this.btn_updateCus);
            this.Controls.Add(this.btn_saveCus);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_barangay);
            this.Controls.Add(this.tb_mobile);
            this.Controls.Add(this.tb_street);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_houseNo);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Name = "CustomersControl";
            this.Size = new System.Drawing.Size(1287, 529);
            this.Load += new System.EventHandler(this.CustomersControl_Load);
            this.customersMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customersMainPanel;
        private System.Windows.Forms.DataGridView customersGrid;
        private Guna.UI2.WinForms.Guna2Button btn_addCus;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_unameAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private System.Windows.Forms.Label lbl_personID;
        private System.Windows.Forms.TextBox tb_personID;
        private Guna.UI2.WinForms.Guna2TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private Guna.UI2.WinForms.Guna2Button btn_viewCus;
        private Guna.UI2.WinForms.Guna2Button btn_updateCus;
        private Guna.UI2.WinForms.Guna2Button btn_saveCus;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_City;
        private Guna.UI2.WinForms.Guna2TextBox tb_tel;
        private Guna.UI2.WinForms.Guna2TextBox tb_barangay;
        private Guna.UI2.WinForms.Guna2TextBox tb_mobile;
        private Guna.UI2.WinForms.Guna2TextBox tb_street;
        private Guna.UI2.WinForms.Guna2TextBox tb_lname;
        private Guna.UI2.WinForms.Guna2TextBox tb_houseNo;
        private Guna.UI2.WinForms.Guna2TextBox tb_fname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tb_search;
    }
}
