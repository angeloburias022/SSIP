
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
            this.label20 = new System.Windows.Forms.Label();
            this.btn_viewEmp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updateAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btn_saveAcc = new Guna.UI2.WinForms.Guna2Button();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_unameAccess = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.cmb_acctype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_acctype = new System.Windows.Forms.Label();
            this.tb_datehired = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_datehired = new System.Windows.Forms.Label();
            this.employee_panel = new System.Windows.Forms.Panel();
            this.tb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_empStatus = new System.Windows.Forms.Label();
            this.tb_uname = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_empStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.tb_position = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.tb_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_personID = new System.Windows.Forms.TextBox();
            this.tb_empID = new System.Windows.Forms.TextBox();
            this.lbl_empID = new System.Windows.Forms.Label();
            this.employeeMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.btn_addEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.employee_panel.SuspendLayout();
            this.confirmAccessPanel.SuspendLayout();
            this.employeeMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.SuspendLayout();
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
            this.cmb_City.Location = new System.Drawing.Point(214, 356);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.ShadowDecoration.Parent = this.cmb_City;
            this.cmb_City.Size = new System.Drawing.Size(165, 36);
            this.cmb_City.TabIndex = 120;
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
            this.tb_tel.Location = new System.Drawing.Point(213, 237);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.PasswordChar = '\0';
            this.tb_tel.PlaceholderText = "Tel #";
            this.tb_tel.SelectedText = "";
            this.tb_tel.ShadowDecoration.Parent = this.tb_tel;
            this.tb_tel.Size = new System.Drawing.Size(165, 36);
            this.tb_tel.TabIndex = 118;
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
            this.tb_barangay.Location = new System.Drawing.Point(29, 356);
            this.tb_barangay.Name = "tb_barangay";
            this.tb_barangay.PasswordChar = '\0';
            this.tb_barangay.PlaceholderText = "Barangay";
            this.tb_barangay.SelectedText = "";
            this.tb_barangay.ShadowDecoration.Parent = this.tb_barangay;
            this.tb_barangay.Size = new System.Drawing.Size(165, 36);
            this.tb_barangay.TabIndex = 117;
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
            this.tb_mobile.Location = new System.Drawing.Point(29, 237);
            this.tb_mobile.Name = "tb_mobile";
            this.tb_mobile.PasswordChar = '\0';
            this.tb_mobile.PlaceholderText = "Mobile #";
            this.tb_mobile.SelectedText = "";
            this.tb_mobile.ShadowDecoration.Parent = this.tb_mobile;
            this.tb_mobile.Size = new System.Drawing.Size(165, 36);
            this.tb_mobile.TabIndex = 116;
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
            this.tb_street.Location = new System.Drawing.Point(214, 295);
            this.tb_street.Name = "tb_street";
            this.tb_street.PasswordChar = '\0';
            this.tb_street.PlaceholderText = "Street";
            this.tb_street.SelectedText = "";
            this.tb_street.ShadowDecoration.Parent = this.tb_street;
            this.tb_street.Size = new System.Drawing.Size(165, 36);
            this.tb_street.TabIndex = 115;
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
            this.tb_lname.Location = new System.Drawing.Point(211, 177);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.PasswordChar = '\0';
            this.tb_lname.PlaceholderText = "Lastname";
            this.tb_lname.SelectedText = "";
            this.tb_lname.ShadowDecoration.Parent = this.tb_lname;
            this.tb_lname.Size = new System.Drawing.Size(165, 36);
            this.tb_lname.TabIndex = 114;
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
            this.tb_houseNo.Location = new System.Drawing.Point(29, 295);
            this.tb_houseNo.Name = "tb_houseNo";
            this.tb_houseNo.PasswordChar = '\0';
            this.tb_houseNo.PlaceholderText = "House #";
            this.tb_houseNo.SelectedText = "";
            this.tb_houseNo.ShadowDecoration.Parent = this.tb_houseNo;
            this.tb_houseNo.Size = new System.Drawing.Size(165, 36);
            this.tb_houseNo.TabIndex = 119;
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
            this.tb_fname.Location = new System.Drawing.Point(32, 177);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.PasswordChar = '\0';
            this.tb_fname.PlaceholderText = "Firstname";
            this.tb_fname.SelectedText = "";
            this.tb_fname.ShadowDecoration.Parent = this.tb_fname;
            this.tb_fname.Size = new System.Drawing.Size(165, 36);
            this.tb_fname.TabIndex = 113;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Honeydew;
            this.label15.Location = new System.Drawing.Point(210, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 105;
            this.label15.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Honeydew;
            this.label10.Location = new System.Drawing.Point(28, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 106;
            this.label10.Text = "Barangay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(209, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 104;
            this.label6.Text = "Street:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(207, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 108;
            this.label9.Text = "Tel No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(209, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "LastName:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(25, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 109;
            this.label8.Text = "Mobile No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(25, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 111;
            this.label12.Text = "House No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "FirstName:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LimeGreen;
            this.label20.Location = new System.Drawing.Point(17, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(237, 31);
            this.label20.TabIndex = 121;
            this.label20.Text = "Personal Details:";
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
            this.btn_viewEmp.Enabled = false;
            this.btn_viewEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewEmp.ForeColor = System.Drawing.Color.White;
            this.btn_viewEmp.HoverState.Parent = this.btn_viewEmp;
            this.btn_viewEmp.Location = new System.Drawing.Point(634, 177);
            this.btn_viewEmp.Name = "btn_viewEmp";
            this.btn_viewEmp.ShadowDecoration.Parent = this.btn_viewEmp;
            this.btn_viewEmp.Size = new System.Drawing.Size(120, 45);
            this.btn_viewEmp.TabIndex = 126;
            this.btn_viewEmp.Text = "VIEW EMPLOYEES";
            this.btn_viewEmp.UseTransparentBackground = true;
            this.btn_viewEmp.Click += new System.EventHandler(this.btn_viewEmp_Click);
            // 
            // btn_updateAccount
            // 
            this.btn_updateAccount.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateAccount.BorderRadius = 4;
            this.btn_updateAccount.CheckedState.Parent = this.btn_updateAccount;
            this.btn_updateAccount.CustomImages.Parent = this.btn_updateAccount;
            this.btn_updateAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateAccount.DisabledState.Parent = this.btn_updateAccount;
            this.btn_updateAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_updateAccount.ForeColor = System.Drawing.Color.White;
            this.btn_updateAccount.HoverState.Parent = this.btn_updateAccount;
            this.btn_updateAccount.Location = new System.Drawing.Point(636, 356);
            this.btn_updateAccount.Name = "btn_updateAccount";
            this.btn_updateAccount.ShadowDecoration.Parent = this.btn_updateAccount;
            this.btn_updateAccount.Size = new System.Drawing.Size(120, 45);
            this.btn_updateAccount.TabIndex = 127;
            this.btn_updateAccount.Text = "UPDATE";
            this.btn_updateAccount.UseTransparentBackground = true;
            this.btn_updateAccount.Click += new System.EventHandler(this.btn_updateAccount_Click);
            // 
            // btn_saveAcc
            // 
            this.btn_saveAcc.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveAcc.BorderRadius = 4;
            this.btn_saveAcc.CheckedState.Parent = this.btn_saveAcc;
            this.btn_saveAcc.CustomImages.Parent = this.btn_saveAcc;
            this.btn_saveAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_saveAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_saveAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_saveAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_saveAcc.DisabledState.Parent = this.btn_saveAcc;
            this.btn_saveAcc.Enabled = false;
            this.btn_saveAcc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_saveAcc.ForeColor = System.Drawing.Color.White;
            this.btn_saveAcc.HoverState.Parent = this.btn_saveAcc;
            this.btn_saveAcc.Location = new System.Drawing.Point(636, 407);
            this.btn_saveAcc.Name = "btn_saveAcc";
            this.btn_saveAcc.ShadowDecoration.Parent = this.btn_saveAcc;
            this.btn_saveAcc.Size = new System.Drawing.Size(120, 45);
            this.btn_saveAcc.TabIndex = 128;
            this.btn_saveAcc.Text = "SAVE";
            this.btn_saveAcc.UseTransparentBackground = true;
            this.btn_saveAcc.Click += new System.EventHandler(this.btn_saveAcc_Click);
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
            // cmb_acctype
            // 
            this.cmb_acctype.BackColor = System.Drawing.Color.Transparent;
            this.cmb_acctype.BorderRadius = 4;
            this.cmb_acctype.DisabledState.Parent = this.cmb_acctype;
            this.cmb_acctype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_acctype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_acctype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_acctype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_acctype.FocusedState.Parent = this.cmb_acctype;
            this.cmb_acctype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_acctype.ForeColor = System.Drawing.Color.Black;
            this.cmb_acctype.HoverState.Parent = this.cmb_acctype;
            this.cmb_acctype.ItemHeight = 30;
            this.cmb_acctype.Items.AddRange(new object[] {
            "Employee",
            "User",
            "Admin"});
            this.cmb_acctype.ItemsAppearance.Parent = this.cmb_acctype;
            this.cmb_acctype.Location = new System.Drawing.Point(30, 421);
            this.cmb_acctype.Name = "cmb_acctype";
            this.cmb_acctype.ShadowDecoration.Parent = this.cmb_acctype;
            this.cmb_acctype.Size = new System.Drawing.Size(168, 36);
            this.cmb_acctype.TabIndex = 130;
            this.cmb_acctype.SelectedIndexChanged += new System.EventHandler(this.cmb_acctype_SelectedIndexChanged);
            // 
            // lbl_acctype
            // 
            this.lbl_acctype.AutoSize = true;
            this.lbl_acctype.BackColor = System.Drawing.Color.Transparent;
            this.lbl_acctype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acctype.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_acctype.Location = new System.Drawing.Point(28, 398);
            this.lbl_acctype.Name = "lbl_acctype";
            this.lbl_acctype.Size = new System.Drawing.Size(123, 20);
            this.lbl_acctype.TabIndex = 129;
            this.lbl_acctype.Text = "Account Type:";
            // 
            // tb_datehired
            // 
            this.tb_datehired.Checked = true;
            this.tb_datehired.CheckedState.Parent = this.tb_datehired;
            this.tb_datehired.FillColor = System.Drawing.Color.LimeGreen;
            this.tb_datehired.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_datehired.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tb_datehired.HoverState.Parent = this.tb_datehired;
            this.tb_datehired.Location = new System.Drawing.Point(10, 23);
            this.tb_datehired.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tb_datehired.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tb_datehired.Name = "tb_datehired";
            this.tb_datehired.ShadowDecoration.Parent = this.tb_datehired;
            this.tb_datehired.Size = new System.Drawing.Size(169, 36);
            this.tb_datehired.TabIndex = 132;
            this.tb_datehired.Value = new System.DateTime(2022, 2, 12, 0, 31, 11, 428);
            // 
            // lbl_datehired
            // 
            this.lbl_datehired.AutoSize = true;
            this.lbl_datehired.BackColor = System.Drawing.Color.Transparent;
            this.lbl_datehired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datehired.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_datehired.Location = new System.Drawing.Point(6, 0);
            this.lbl_datehired.Name = "lbl_datehired";
            this.lbl_datehired.Size = new System.Drawing.Size(98, 20);
            this.lbl_datehired.TabIndex = 131;
            this.lbl_datehired.Text = "Date hired:";
            // 
            // employee_panel
            // 
            this.employee_panel.BackColor = System.Drawing.Color.Transparent;
            this.employee_panel.Controls.Add(this.tb_password);
            this.employee_panel.Controls.Add(this.lbl_datehired);
            this.employee_panel.Controls.Add(this.lbl_empStatus);
            this.employee_panel.Controls.Add(this.tb_uname);
            this.employee_panel.Controls.Add(this.cmb_empStatus);
            this.employee_panel.Controls.Add(this.tb_datehired);
            this.employee_panel.Controls.Add(this.lbl_password);
            this.employee_panel.Controls.Add(this.lbl_position);
            this.employee_panel.Controls.Add(this.tb_position);
            this.employee_panel.Controls.Add(this.lbl_username);
            this.employee_panel.Location = new System.Drawing.Point(385, 154);
            this.employee_panel.Name = "employee_panel";
            this.employee_panel.Size = new System.Drawing.Size(194, 303);
            this.employee_panel.TabIndex = 133;
            this.employee_panel.Visible = false;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.Transparent;
            this.tb_password.BorderRadius = 4;
            this.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_password.DefaultText = "";
            this.tb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_password.DisabledState.Parent = this.tb_password;
            this.tb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_password.FocusedState.Parent = this.tb_password;
            this.tb_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_password.HoverState.Parent = this.tb_password;
            this.tb_password.Location = new System.Drawing.Point(12, 264);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.PlaceholderText = "Password";
            this.tb_password.SelectedText = "";
            this.tb_password.ShadowDecoration.Parent = this.tb_password;
            this.tb_password.Size = new System.Drawing.Size(165, 36);
            this.tb_password.TabIndex = 136;
            // 
            // lbl_empStatus
            // 
            this.lbl_empStatus.AutoSize = true;
            this.lbl_empStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empStatus.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_empStatus.Location = new System.Drawing.Point(9, 116);
            this.lbl_empStatus.Name = "lbl_empStatus";
            this.lbl_empStatus.Size = new System.Drawing.Size(67, 20);
            this.lbl_empStatus.TabIndex = 105;
            this.lbl_empStatus.Text = "Status:";
            // 
            // tb_uname
            // 
            this.tb_uname.BackColor = System.Drawing.Color.Transparent;
            this.tb_uname.BorderRadius = 4;
            this.tb_uname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_uname.DefaultText = "";
            this.tb_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_uname.DisabledState.Parent = this.tb_uname;
            this.tb_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_uname.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_uname.FocusedState.Parent = this.tb_uname;
            this.tb_uname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_uname.ForeColor = System.Drawing.Color.Black;
            this.tb_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_uname.HoverState.Parent = this.tb_uname;
            this.tb_uname.Location = new System.Drawing.Point(13, 202);
            this.tb_uname.Name = "tb_uname";
            this.tb_uname.PasswordChar = '\0';
            this.tb_uname.PlaceholderText = "Username";
            this.tb_uname.SelectedText = "";
            this.tb_uname.ShadowDecoration.Parent = this.tb_uname;
            this.tb_uname.Size = new System.Drawing.Size(165, 36);
            this.tb_uname.TabIndex = 137;
            // 
            // cmb_empStatus
            // 
            this.cmb_empStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmb_empStatus.BorderRadius = 4;
            this.cmb_empStatus.DisabledState.Parent = this.cmb_empStatus;
            this.cmb_empStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_empStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_empStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_empStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_empStatus.FocusedState.Parent = this.cmb_empStatus;
            this.cmb_empStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_empStatus.ForeColor = System.Drawing.Color.Black;
            this.cmb_empStatus.HoverState.Parent = this.cmb_empStatus;
            this.cmb_empStatus.ItemHeight = 30;
            this.cmb_empStatus.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.cmb_empStatus.ItemsAppearance.Parent = this.cmb_empStatus;
            this.cmb_empStatus.Location = new System.Drawing.Point(13, 139);
            this.cmb_empStatus.Name = "cmb_empStatus";
            this.cmb_empStatus.ShadowDecoration.Parent = this.cmb_empStatus;
            this.cmb_empStatus.Size = new System.Drawing.Size(165, 36);
            this.cmb_empStatus.TabIndex = 120;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_password.Location = new System.Drawing.Point(8, 241);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(86, 20);
            this.lbl_password.TabIndex = 135;
            this.lbl_password.Text = "Password";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.BackColor = System.Drawing.Color.Transparent;
            this.lbl_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_position.Location = new System.Drawing.Point(8, 60);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(78, 20);
            this.lbl_position.TabIndex = 133;
            this.lbl_position.Text = "Position:";
            // 
            // tb_position
            // 
            this.tb_position.BackColor = System.Drawing.Color.Transparent;
            this.tb_position.BorderRadius = 4;
            this.tb_position.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_position.DefaultText = "";
            this.tb_position.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_position.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_position.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_position.DisabledState.Parent = this.tb_position;
            this.tb_position.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_position.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_position.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_position.FocusedState.Parent = this.tb_position;
            this.tb_position.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_position.ForeColor = System.Drawing.Color.Black;
            this.tb_position.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_position.HoverState.Parent = this.tb_position;
            this.tb_position.Location = new System.Drawing.Point(13, 83);
            this.tb_position.Name = "tb_position";
            this.tb_position.PasswordChar = '\0';
            this.tb_position.PlaceholderText = "Position";
            this.tb_position.SelectedText = "";
            this.tb_position.ShadowDecoration.Parent = this.tb_position;
            this.tb_position.Size = new System.Drawing.Size(165, 36);
            this.tb_position.TabIndex = 134;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_username.Location = new System.Drawing.Point(9, 179);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(96, 20);
            this.lbl_username.TabIndex = 135;
            this.lbl_username.Text = "Username:";
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.lbl_confirmAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_unameAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_pass);
            this.confirmAccessPanel.Location = new System.Drawing.Point(590, 234);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(214, 116);
            this.confirmAccessPanel.TabIndex = 134;
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
            this.tb_email.Location = new System.Drawing.Point(211, 418);
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.PlaceholderText = "Email Address";
            this.tb_email.SelectedText = "";
            this.tb_email.ShadowDecoration.Parent = this.tb_email;
            this.tb_email.Size = new System.Drawing.Size(165, 36);
            this.tb_email.TabIndex = 136;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_email.Location = new System.Drawing.Point(210, 395);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(53, 20);
            this.lbl_email.TabIndex = 135;
            this.lbl_email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(271, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 138;
            this.label1.Text = "Person ID";
            this.label1.Visible = false;
            // 
            // tb_personID
            // 
            this.tb_personID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_personID.Location = new System.Drawing.Point(276, 108);
            this.tb_personID.Multiline = true;
            this.tb_personID.Name = "tb_personID";
            this.tb_personID.ReadOnly = true;
            this.tb_personID.Size = new System.Drawing.Size(100, 33);
            this.tb_personID.TabIndex = 137;
            this.tb_personID.Text = "0";
            this.tb_personID.Visible = false;
            // 
            // tb_empID
            // 
            this.tb_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_empID.Location = new System.Drawing.Point(399, 108);
            this.tb_empID.Multiline = true;
            this.tb_empID.Name = "tb_empID";
            this.tb_empID.ReadOnly = true;
            this.tb_empID.Size = new System.Drawing.Size(100, 33);
            this.tb_empID.TabIndex = 137;
            this.tb_empID.Text = "0";
            this.tb_empID.Visible = false;
            // 
            // lbl_empID
            // 
            this.lbl_empID.AutoSize = true;
            this.lbl_empID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empID.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_empID.Location = new System.Drawing.Point(394, 86);
            this.lbl_empID.Name = "lbl_empID";
            this.lbl_empID.Size = new System.Drawing.Size(116, 20);
            this.lbl_empID.TabIndex = 138;
            this.lbl_empID.Text = "Employee  ID";
            this.lbl_empID.Visible = false;
            // 
            // employeeMainPanel
            // 
            this.employeeMainPanel.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.employeeMainPanel.ColumnCount = 3;
            this.employeeMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.333333F));
            this.employeeMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.employeeMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.employeeMainPanel.Controls.Add(this.employeeGrid, 1, 1);
            this.employeeMainPanel.Controls.Add(this.btn_addEmployee, 1, 2);
            this.employeeMainPanel.Location = new System.Drawing.Point(813, 74);
            this.employeeMainPanel.Name = "employeeMainPanel";
            this.employeeMainPanel.RowCount = 3;
            this.employeeMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24365F));
            this.employeeMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.67513F));
            this.employeeMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.33503F));
            this.employeeMainPanel.Size = new System.Drawing.Size(450, 328);
            this.employeeMainPanel.TabIndex = 139;
            this.employeeMainPanel.Visible = false;
            // 
            // employeeGrid
            // 
            this.employeeGrid.AllowUserToAddRows = false;
            this.employeeGrid.AllowUserToDeleteRows = false;
            this.employeeGrid.AllowUserToOrderColumns = true;
            this.employeeGrid.AllowUserToResizeColumns = false;
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeGrid.Location = new System.Drawing.Point(26, 56);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.ReadOnly = true;
            this.employeeGrid.Size = new System.Drawing.Size(399, 195);
            this.employeeGrid.TabIndex = 0;
            this.employeeGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGrid_CellDoubleClick);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_addEmployee.BorderRadius = 4;
            this.btn_addEmployee.CheckedState.Parent = this.btn_addEmployee;
            this.btn_addEmployee.CustomImages.Parent = this.btn_addEmployee;
            this.btn_addEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addEmployee.DisabledState.Parent = this.btn_addEmployee;
            this.btn_addEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_addEmployee.HoverState.Parent = this.btn_addEmployee;
            this.btn_addEmployee.Location = new System.Drawing.Point(26, 257);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.ShadowDecoration.Parent = this.btn_addEmployee;
            this.btn_addEmployee.Size = new System.Drawing.Size(112, 43);
            this.btn_addEmployee.TabIndex = 105;
            this.btn_addEmployee.Text = "ADD EMPLOYEE";
            this.btn_addEmployee.UseTransparentBackground = true;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 42);
            this.label2.TabIndex = 121;
            this.label2.Text = "Employee";
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.employeeMainPanel);
            this.Controls.Add(this.lbl_empID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_empID);
            this.Controls.Add(this.tb_personID);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.confirmAccessPanel);
            this.Controls.Add(this.employee_panel);
            this.Controls.Add(this.cmb_acctype);
            this.Controls.Add(this.lbl_acctype);
            this.Controls.Add(this.btn_viewEmp);
            this.Controls.Add(this.btn_updateAccount);
            this.Controls.Add(this.btn_saveAcc);
            this.Controls.Add(this.label2);
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
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(886, 490);
            this.Load += new System.EventHandler(this.EmployeeControl_Load);
            this.employee_panel.ResumeLayout(false);
            this.employee_panel.PerformLayout();
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            this.employeeMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2Button btn_viewEmp;
        private Guna.UI2.WinForms.Guna2Button btn_updateAccount;
        private Guna.UI2.WinForms.Guna2Button btn_saveAcc;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private Guna.UI2.WinForms.Guna2TextBox tb_unameAccess;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_acctype;
        private System.Windows.Forms.Label lbl_acctype;
        private Guna.UI2.WinForms.Guna2DateTimePicker tb_datehired;
        private System.Windows.Forms.Label lbl_datehired;
        private System.Windows.Forms.Panel employee_panel;
        private Guna.UI2.WinForms.Guna2TextBox tb_password;
        private Guna.UI2.WinForms.Guna2TextBox tb_uname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private Guna.UI2.WinForms.Guna2TextBox tb_position;
        private System.Windows.Forms.Label lbl_position;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_empStatus;
        private System.Windows.Forms.Label lbl_empStatus;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private Guna.UI2.WinForms.Guna2TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_personID;
        private System.Windows.Forms.TextBox tb_empID;
        private System.Windows.Forms.Label lbl_empID;
        private System.Windows.Forms.TableLayoutPanel employeeMainPanel;
        private System.Windows.Forms.DataGridView employeeGrid;
        private Guna.UI2.WinForms.Guna2Button btn_addEmployee;
        private System.Windows.Forms.Label label2;
    }
}
