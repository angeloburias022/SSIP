
namespace SSIP.UserformControls
{
    partial class AttendanceControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_qrcode = new System.Windows.Forms.PictureBox();
            this.tb_lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.workdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewAttendances = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_scan = new Guna.UI2.WinForms.Guna2Button();
            this.cboDevice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tb_DisplayQR = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_employeeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_totalHrs = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_totalworkhrs = new System.Windows.Forms.Label();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.tb_unameAccess = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.attendanceMainpanel = new System.Windows.Forms.TableLayoutPanel();
            this.tb_searchAttendances = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_addAttendance = new Guna.UI2.WinForms.Guna2Button();
            this.attendanceGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_updateChanges = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.timeout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.timein = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).BeginInit();
            this.confirmAccessPanel.SuspendLayout();
            this.attendanceMainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_qrcode
            // 
            this.pb_qrcode.Location = new System.Drawing.Point(331, 20);
            this.pb_qrcode.Name = "pb_qrcode";
            this.pb_qrcode.Size = new System.Drawing.Size(140, 120);
            this.pb_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_qrcode.TabIndex = 0;
            this.pb_qrcode.TabStop = false;
            this.pb_qrcode.Visible = false;
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
            this.tb_lname.Location = new System.Drawing.Point(254, 172);
            this.tb_lname.Name = "tb_lname";
            this.tb_lname.PasswordChar = '\0';
            this.tb_lname.PlaceholderText = "Lastname";
            this.tb_lname.SelectedText = "";
            this.tb_lname.ShadowDecoration.Parent = this.tb_lname;
            this.tb_lname.Size = new System.Drawing.Size(165, 36);
            this.tb_lname.TabIndex = 160;
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
            this.tb_fname.Location = new System.Drawing.Point(68, 172);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.PasswordChar = '\0';
            this.tb_fname.PlaceholderText = "Firstname";
            this.tb_fname.SelectedText = "";
            this.tb_fname.ShadowDecoration.Parent = this.tb_fname;
            this.tb_fname.Size = new System.Drawing.Size(165, 36);
            this.tb_fname.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(222, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 155;
            this.label6.Text = "TIME OUT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(252, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 156;
            this.label5.Text = "LastName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(67, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 158;
            this.label12.Text = "TIME IN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(64, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 157;
            this.label4.Text = "FirstName:";
            // 
            // workdate
            // 
            this.workdate.Checked = true;
            this.workdate.CheckedState.Parent = this.workdate;
            this.workdate.FillColor = System.Drawing.Color.LimeGreen;
            this.workdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.workdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.workdate.HoverState.Parent = this.workdate;
            this.workdate.Location = new System.Drawing.Point(71, 325);
            this.workdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.workdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.workdate.Name = "workdate";
            this.workdate.ShadowDecoration.Parent = this.workdate;
            this.workdate.Size = new System.Drawing.Size(125, 36);
            this.workdate.TabIndex = 163;
            this.workdate.Value = new System.DateTime(2022, 2, 12, 0, 0, 0, 0);
            this.workdate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(67, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 158;
            this.label1.Text = "Date:";
            this.label1.Visible = false;
            // 
            // btn_viewAttendances
            // 
            this.btn_viewAttendances.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewAttendances.BorderRadius = 4;
            this.btn_viewAttendances.CheckedState.Parent = this.btn_viewAttendances;
            this.btn_viewAttendances.CustomImages.Parent = this.btn_viewAttendances;
            this.btn_viewAttendances.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewAttendances.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_viewAttendances.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_viewAttendances.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_viewAttendances.DisabledState.Parent = this.btn_viewAttendances;
            this.btn_viewAttendances.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_viewAttendances.ForeColor = System.Drawing.Color.White;
            this.btn_viewAttendances.HoverState.Parent = this.btn_viewAttendances;
            this.btn_viewAttendances.Location = new System.Drawing.Point(451, 270);
            this.btn_viewAttendances.Name = "btn_viewAttendances";
            this.btn_viewAttendances.ShadowDecoration.Parent = this.btn_viewAttendances;
            this.btn_viewAttendances.Size = new System.Drawing.Size(120, 36);
            this.btn_viewAttendances.TabIndex = 164;
            this.btn_viewAttendances.Text = "VIEW ATTENDANCES";
            this.btn_viewAttendances.UseTransparentBackground = true;
            this.btn_viewAttendances.Click += new System.EventHandler(this.btn_viewAttendances_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 4;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.DisabledState.Parent = this.btn_save;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(607, 117);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(120, 36);
            this.btn_save.TabIndex = 164;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseTransparentBackground = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.BackColor = System.Drawing.Color.Transparent;
            this.btn_scan.BorderRadius = 4;
            this.btn_scan.CheckedState.Parent = this.btn_scan;
            this.btn_scan.CustomImages.Parent = this.btn_scan;
            this.btn_scan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_scan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_scan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_scan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_scan.DisabledState.Parent = this.btn_scan;
            this.btn_scan.Enabled = false;
            this.btn_scan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_scan.ForeColor = System.Drawing.Color.White;
            this.btn_scan.HoverState.Parent = this.btn_scan;
            this.btn_scan.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btn_scan.Location = new System.Drawing.Point(451, 232);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.ShadowDecoration.Parent = this.btn_scan;
            this.btn_scan.Size = new System.Drawing.Size(120, 32);
            this.btn_scan.TabIndex = 164;
            this.btn_scan.Text = "SCAN QR CODE";
            this.btn_scan.UseTransparentBackground = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // cboDevice
            // 
            this.cboDevice.BackColor = System.Drawing.Color.Transparent;
            this.cboDevice.DisabledState.Parent = this.cboDevice;
            this.cboDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDevice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDevice.FocusedState.Parent = this.cboDevice;
            this.cboDevice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDevice.HoverState.Parent = this.cboDevice;
            this.cboDevice.ItemHeight = 30;
            this.cboDevice.ItemsAppearance.Parent = this.cboDevice;
            this.cboDevice.Location = new System.Drawing.Point(644, 45);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.ShadowDecoration.Parent = this.cboDevice;
            this.cboDevice.Size = new System.Drawing.Size(165, 36);
            this.cboDevice.TabIndex = 165;
            this.cboDevice.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tb_DisplayQR
            // 
            this.tb_DisplayQR.BackColor = System.Drawing.Color.Transparent;
            this.tb_DisplayQR.BorderRadius = 4;
            this.tb_DisplayQR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_DisplayQR.DefaultText = "";
            this.tb_DisplayQR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_DisplayQR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_DisplayQR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_DisplayQR.DisabledState.Parent = this.tb_DisplayQR;
            this.tb_DisplayQR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_DisplayQR.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_DisplayQR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_DisplayQR.FocusedState.Parent = this.tb_DisplayQR;
            this.tb_DisplayQR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_DisplayQR.ForeColor = System.Drawing.Color.Black;
            this.tb_DisplayQR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_DisplayQR.HoverState.Parent = this.tb_DisplayQR;
            this.tb_DisplayQR.Location = new System.Drawing.Point(71, 33);
            this.tb_DisplayQR.Name = "tb_DisplayQR";
            this.tb_DisplayQR.PasswordChar = '\0';
            this.tb_DisplayQR.PlaceholderText = "";
            this.tb_DisplayQR.SelectedText = "";
            this.tb_DisplayQR.ShadowDecoration.Parent = this.tb_DisplayQR;
            this.tb_DisplayQR.Size = new System.Drawing.Size(101, 36);
            this.tb_DisplayQR.TabIndex = 160;
            this.tb_DisplayQR.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(67, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 158;
            this.label2.Text = "EMPLOYEE ID";
            // 
            // tb_employeeID
            // 
            this.tb_employeeID.BackColor = System.Drawing.Color.Transparent;
            this.tb_employeeID.BorderRadius = 4;
            this.tb_employeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_employeeID.DefaultText = "0";
            this.tb_employeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_employeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_employeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_employeeID.DisabledState.Parent = this.tb_employeeID;
            this.tb_employeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_employeeID.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_employeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_employeeID.FocusedState.Parent = this.tb_employeeID;
            this.tb_employeeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_employeeID.ForeColor = System.Drawing.Color.Black;
            this.tb_employeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_employeeID.HoverState.Parent = this.tb_employeeID;
            this.tb_employeeID.Location = new System.Drawing.Point(71, 104);
            this.tb_employeeID.Name = "tb_employeeID";
            this.tb_employeeID.PasswordChar = '\0';
            this.tb_employeeID.PlaceholderText = "Employee ID";
            this.tb_employeeID.SelectedText = "";
            this.tb_employeeID.ShadowDecoration.Parent = this.tb_employeeID;
            this.tb_employeeID.Size = new System.Drawing.Size(89, 36);
            this.tb_employeeID.TabIndex = 162;
            // 
            // tb_totalHrs
            // 
            this.tb_totalHrs.BackColor = System.Drawing.Color.Transparent;
            this.tb_totalHrs.BorderRadius = 4;
            this.tb_totalHrs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_totalHrs.DefaultText = "";
            this.tb_totalHrs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_totalHrs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_totalHrs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_totalHrs.DisabledState.Parent = this.tb_totalHrs;
            this.tb_totalHrs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_totalHrs.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_totalHrs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_totalHrs.FocusedState.Parent = this.tb_totalHrs;
            this.tb_totalHrs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_totalHrs.ForeColor = System.Drawing.Color.Black;
            this.tb_totalHrs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_totalHrs.HoverState.Parent = this.tb_totalHrs;
            this.tb_totalHrs.Location = new System.Drawing.Point(226, 325);
            this.tb_totalHrs.Name = "tb_totalHrs";
            this.tb_totalHrs.PasswordChar = '\0';
            this.tb_totalHrs.PlaceholderText = "Total Hours";
            this.tb_totalHrs.ReadOnly = true;
            this.tb_totalHrs.SelectedText = "";
            this.tb_totalHrs.ShadowDecoration.Parent = this.tb_totalHrs;
            this.tb_totalHrs.Size = new System.Drawing.Size(92, 36);
            this.tb_totalHrs.TabIndex = 161;
            this.tb_totalHrs.Visible = false;
            this.tb_totalHrs.Leave += new System.EventHandler(this.tb_timeout_Leave);
            // 
            // lbl_totalworkhrs
            // 
            this.lbl_totalworkhrs.AutoSize = true;
            this.lbl_totalworkhrs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalworkhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalworkhrs.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_totalworkhrs.Location = new System.Drawing.Point(223, 302);
            this.lbl_totalworkhrs.Name = "lbl_totalworkhrs";
            this.lbl_totalworkhrs.Size = new System.Drawing.Size(196, 20);
            this.lbl_totalworkhrs.TabIndex = 155;
            this.lbl_totalworkhrs.Text = "TOTAL WORK HOURS:";
            this.lbl_totalworkhrs.Visible = false;
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.lbl_confirmAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_unameAccess);
            this.confirmAccessPanel.Controls.Add(this.tb_pass);
            this.confirmAccessPanel.Location = new System.Drawing.Point(626, 198);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(183, 120);
            this.confirmAccessPanel.TabIndex = 166;
            // 
            // lbl_confirmAccess
            // 
            this.lbl_confirmAccess.AutoSize = true;
            this.lbl_confirmAccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmAccess.ForeColor = System.Drawing.Color.Honeydew;
            this.lbl_confirmAccess.Location = new System.Drawing.Point(24, 5);
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
            this.tb_unameAccess.Location = new System.Drawing.Point(9, 28);
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
            // attendanceMainpanel
            // 
            this.attendanceMainpanel.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.attendanceMainpanel.ColumnCount = 3;
            this.attendanceMainpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.333333F));
            this.attendanceMainpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.attendanceMainpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.attendanceMainpanel.Controls.Add(this.tb_searchAttendances, 1, 0);
            this.attendanceMainpanel.Controls.Add(this.btn_addAttendance, 1, 2);
            this.attendanceMainpanel.Controls.Add(this.attendanceGrid, 1, 1);
            this.attendanceMainpanel.Location = new System.Drawing.Point(679, 376);
            this.attendanceMainpanel.Name = "attendanceMainpanel";
            this.attendanceMainpanel.RowCount = 3;
            this.attendanceMainpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24365F));
            this.attendanceMainpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.67513F));
            this.attendanceMainpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.33503F));
            this.attendanceMainpanel.Size = new System.Drawing.Size(450, 328);
            this.attendanceMainpanel.TabIndex = 167;
            this.attendanceMainpanel.Visible = false;
            // 
            // tb_searchAttendances
            // 
            this.tb_searchAttendances.BackColor = System.Drawing.Color.Transparent;
            this.tb_searchAttendances.BorderRadius = 4;
            this.tb_searchAttendances.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchAttendances.DefaultText = "";
            this.tb_searchAttendances.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_searchAttendances.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_searchAttendances.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchAttendances.DisabledState.Parent = this.tb_searchAttendances;
            this.tb_searchAttendances.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_searchAttendances.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_searchAttendances.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchAttendances.FocusedState.Parent = this.tb_searchAttendances;
            this.tb_searchAttendances.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_searchAttendances.ForeColor = System.Drawing.Color.Black;
            this.tb_searchAttendances.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_searchAttendances.HoverState.Parent = this.tb_searchAttendances;
            this.tb_searchAttendances.Location = new System.Drawing.Point(26, 3);
            this.tb_searchAttendances.Name = "tb_searchAttendances";
            this.tb_searchAttendances.PasswordChar = '\0';
            this.tb_searchAttendances.PlaceholderText = "Search";
            this.tb_searchAttendances.SelectedText = "";
            this.tb_searchAttendances.ShadowDecoration.Parent = this.tb_searchAttendances;
            this.tb_searchAttendances.Size = new System.Drawing.Size(165, 36);
            this.tb_searchAttendances.TabIndex = 140;
            this.tb_searchAttendances.TextChanged += new System.EventHandler(this.tb_searchAttendances_TextChanged);
            this.tb_searchAttendances.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_searchAttendances_KeyPress);
            // 
            // btn_addAttendance
            // 
            this.btn_addAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btn_addAttendance.BorderRadius = 4;
            this.btn_addAttendance.CheckedState.Parent = this.btn_addAttendance;
            this.btn_addAttendance.CustomImages.Parent = this.btn_addAttendance;
            this.btn_addAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addAttendance.DisabledState.Parent = this.btn_addAttendance;
            this.btn_addAttendance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addAttendance.ForeColor = System.Drawing.Color.White;
            this.btn_addAttendance.HoverState.Parent = this.btn_addAttendance;
            this.btn_addAttendance.Location = new System.Drawing.Point(26, 257);
            this.btn_addAttendance.Name = "btn_addAttendance";
            this.btn_addAttendance.ShadowDecoration.Parent = this.btn_addAttendance;
            this.btn_addAttendance.Size = new System.Drawing.Size(112, 43);
            this.btn_addAttendance.TabIndex = 105;
            this.btn_addAttendance.Text = "ADD ATTENDANCE";
            this.btn_addAttendance.UseTransparentBackground = true;
            this.btn_addAttendance.Click += new System.EventHandler(this.btn_addAttendance_Click);
            // 
            // attendanceGrid
            // 
            this.attendanceGrid.AllowUserToAddRows = false;
            this.attendanceGrid.AllowUserToDeleteRows = false;
            this.attendanceGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.attendanceGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.attendanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.attendanceGrid.BackgroundColor = System.Drawing.Color.White;
            this.attendanceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attendanceGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.attendanceGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attendanceGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.attendanceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceGrid.EnableHeadersVisualStyles = false;
            this.attendanceGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.attendanceGrid.Location = new System.Drawing.Point(26, 56);
            this.attendanceGrid.Name = "attendanceGrid";
            this.attendanceGrid.ReadOnly = true;
            this.attendanceGrid.RowHeadersVisible = false;
            this.attendanceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attendanceGrid.Size = new System.Drawing.Size(399, 195);
            this.attendanceGrid.TabIndex = 141;
            this.attendanceGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.attendanceGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.attendanceGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.attendanceGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.attendanceGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.attendanceGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.attendanceGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.attendanceGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.attendanceGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.attendanceGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.attendanceGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.attendanceGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.attendanceGrid.ThemeStyle.HeaderStyle.Height = 23;
            this.attendanceGrid.ThemeStyle.ReadOnly = true;
            this.attendanceGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.attendanceGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.attendanceGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.attendanceGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.attendanceGrid.ThemeStyle.RowsStyle.Height = 22;
            this.attendanceGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.attendanceGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.attendanceGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceGrid_CellDoubleClick);
            // 
            // btn_updateChanges
            // 
            this.btn_updateChanges.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateChanges.BorderRadius = 4;
            this.btn_updateChanges.CheckedState.Parent = this.btn_updateChanges;
            this.btn_updateChanges.CustomImages.Parent = this.btn_updateChanges;
            this.btn_updateChanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateChanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateChanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateChanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateChanges.DisabledState.Parent = this.btn_updateChanges;
            this.btn_updateChanges.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_updateChanges.ForeColor = System.Drawing.Color.White;
            this.btn_updateChanges.HoverState.Parent = this.btn_updateChanges;
            this.btn_updateChanges.Location = new System.Drawing.Point(488, 159);
            this.btn_updateChanges.Name = "btn_updateChanges";
            this.btn_updateChanges.ShadowDecoration.Parent = this.btn_updateChanges;
            this.btn_updateChanges.Size = new System.Drawing.Size(120, 36);
            this.btn_updateChanges.TabIndex = 164;
            this.btn_updateChanges.Text = "UPDATE";
            this.btn_updateChanges.UseTransparentBackground = true;
            this.btn_updateChanges.Visible = false;
            this.btn_updateChanges.Click += new System.EventHandler(this.btn_updateChanges_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.tableLayoutPanel1.Controls.Add(this.guna2TextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.guna2DataGridView1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(679, 376);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.24365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.67513F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.33503F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 328);
            this.tableLayoutPanel1.TabIndex = 167;
            this.tableLayoutPanel1.Visible = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 4;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(26, 3);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(165, 36);
            this.guna2TextBox1.TabIndex = 140;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.tb_searchAttendances_TextChanged);
            this.guna2TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_searchAttendances_KeyPress);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 4;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(26, 257);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(112, 43);
            this.guna2Button2.TabIndex = 105;
            this.guna2Button2.Text = "ADD ATTENDANCE";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.btn_addAttendance_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(26, 56);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(399, 195);
            this.guna2DataGridView1.TabIndex = 141;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 23;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendanceGrid_CellDoubleClick);
            // 
            // timeout
            // 
            this.timeout.Checked = true;
            this.timeout.CheckedState.Parent = this.timeout;
            this.timeout.Enabled = false;
            this.timeout.FillColor = System.Drawing.Color.LimeGreen;
            this.timeout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeout.HoverState.Parent = this.timeout;
            this.timeout.Location = new System.Drawing.Point(211, 247);
            this.timeout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeout.Name = "timeout";
            this.timeout.ShadowDecoration.Parent = this.timeout;
            this.timeout.Size = new System.Drawing.Size(129, 36);
            this.timeout.TabIndex = 163;
            this.timeout.Value = new System.DateTime(2022, 3, 19, 12, 0, 0, 0);
            // 
            // timein
            // 
            this.timein.Checked = true;
            this.timein.CheckedState.Parent = this.timein;
            this.timein.Enabled = false;
            this.timein.FillColor = System.Drawing.Color.LimeGreen;
            this.timein.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timein.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timein.HoverState.Parent = this.timein;
            this.timein.Location = new System.Drawing.Point(68, 247);
            this.timein.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timein.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timein.Name = "timein";
            this.timein.ShadowDecoration.Parent = this.timein;
            this.timein.Size = new System.Drawing.Size(128, 36);
            this.timein.TabIndex = 163;
            this.timein.Value = new System.DateTime(2022, 3, 19, 12, 0, 0, 0);
            // 
            // AttendanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SSIP.Properties.Resources.bg;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attendanceMainpanel);
            this.Controls.Add(this.confirmAccessPanel);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.btn_updateChanges);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_viewAttendances);
            this.Controls.Add(this.timein);
            this.Controls.Add(this.timeout);
            this.Controls.Add(this.workdate);
            this.Controls.Add(this.tb_totalHrs);
            this.Controls.Add(this.tb_DisplayQR);
            this.Controls.Add(this.tb_lname);
            this.Controls.Add(this.tb_employeeID);
            this.Controls.Add(this.tb_fname);
            this.Controls.Add(this.lbl_totalworkhrs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb_qrcode);
            this.Name = "AttendanceControl";
            this.Size = new System.Drawing.Size(838, 495);
            this.Load += new System.EventHandler(this.AttendanceControl_Load);
            this.Leave += new System.EventHandler(this.AttendanceControl_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).EndInit();
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            this.attendanceMainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_qrcode;
        private Guna.UI2.WinForms.Guna2TextBox tb_lname;
        private Guna.UI2.WinForms.Guna2TextBox tb_fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker workdate;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_viewAttendances;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_scan;
        private Guna.UI2.WinForms.Guna2ComboBox cboDevice;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox tb_DisplayQR;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tb_employeeID;
        private Guna.UI2.WinForms.Guna2TextBox tb_totalHrs;
        private System.Windows.Forms.Label lbl_totalworkhrs;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_unameAccess;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private System.Windows.Forms.TableLayoutPanel attendanceMainpanel;
        private Guna.UI2.WinForms.Guna2TextBox tb_searchAttendances;
        private Guna.UI2.WinForms.Guna2Button btn_addAttendance;
        private Guna.UI2.WinForms.Guna2DataGridView attendanceGrid;
        private Guna.UI2.WinForms.Guna2Button btn_updateChanges;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeout;
        private Guna.UI2.WinForms.Guna2DateTimePicker timein;
    }
}
