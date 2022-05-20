
namespace SSIP.Forms
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Services_pie_chart = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.DispatchedChart = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CityChart = new LiveCharts.WinForms.CartesianChart();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_currentUser = new System.Windows.Forms.Label();
            this.btn_menu_cust = new System.Windows.Forms.Button();
            this.Customers_panel = new System.Windows.Forms.Panel();
            this.btn_managecus_sub = new System.Windows.Forms.Button();
            this.btn_menu_employees = new System.Windows.Forms.Button();
            this.emp_panel = new System.Windows.Forms.Panel();
            this.btn_attendance_sub = new System.Windows.Forms.Button();
            this.btn_manageEmp_sub = new System.Windows.Forms.Button();
            this.btn_payroll_sub = new System.Windows.Forms.Button();
            this.nav_panel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.btn_signout = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.btn_viewchangePass = new System.Windows.Forms.Button();
            this.btn_auditLogs = new System.Windows.Forms.Button();
            this.btn_main_settings = new System.Windows.Forms.Button();
            this.services_panel = new System.Windows.Forms.Panel();
            this.btn_Dispatch = new System.Windows.Forms.Button();
            this.btn_pos = new System.Windows.Forms.Button();
            this.btn_Sched = new System.Windows.Forms.Button();
            this.btn_main_services = new System.Windows.Forms.Button();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.btn_prodInventory = new System.Windows.Forms.Button();
            this.btn_equip_inv = new System.Windows.Forms.Button();
            this.btn_main_invent = new System.Windows.Forms.Button();
            this.dispatchFormPanel = new System.Windows.Forms.Panel();
            this.mainServiceControl1 = new SSIP.UserForms.MainServiceControl();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.employeesControl1 = new SSIP.UserformControls.EmployeeControl();
            this.customersControl1Panel = new System.Windows.Forms.Panel();
            this.customersControl1 = new SSIP.UserformControls.CustomersControl();
            this.attendanceControlpanel = new System.Windows.Forms.Panel();
            this.attendanceControl1 = new SSIP.UserformControls.AttendanceControl();
            this.payroll_mainPanel = new System.Windows.Forms.Panel();
            this.payrollControl1 = new SSIP.UserformControls.PayrollControl();
            this.productInvPanel = new System.Windows.Forms.Panel();
            this.productInvControl1 = new SSIP.UserformControls.ProductInvControl();
            this.equipControlPanel = new System.Windows.Forms.Panel();
            this.equipInvControl1 = new SSIP.UserformControls.EquipInvControl();
            this.auditControlPanel = new System.Windows.Forms.Panel();
            this.auditControl1 = new SSIP.UserformControls.AuditControl();
            this.pos_controlPanel = new System.Windows.Forms.Panel();
            this.salesControl1 = new SSIP.UserformControls.SalesControl();
            this.time_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_username = new System.Windows.Forms.Label();
            this.dispatchePanel = new System.Windows.Forms.Panel();
            this.dispatchesControl1 = new SSIP.UserformControls.DispatchesControl();
            this.changePassPanel = new System.Windows.Forms.Panel();
            this.tb_current = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_check = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_confirmAccess = new System.Windows.Forms.Label();
            this.confirmAccessPanel = new System.Windows.Forms.Panel();
            this.tb_confirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_confirm = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_newPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_usernameee = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Customers_panel.SuspendLayout();
            this.emp_panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.services_panel.SuspendLayout();
            this.inventory_panel.SuspendLayout();
            this.dispatchFormPanel.SuspendLayout();
            this.employeePanel.SuspendLayout();
            this.customersControl1Panel.SuspendLayout();
            this.attendanceControlpanel.SuspendLayout();
            this.payroll_mainPanel.SuspendLayout();
            this.productInvPanel.SuspendLayout();
            this.equipControlPanel.SuspendLayout();
            this.auditControlPanel.SuspendLayout();
            this.pos_controlPanel.SuspendLayout();
            this.dispatchePanel.SuspendLayout();
            this.changePassPanel.SuspendLayout();
            this.confirmAccessPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Services_pie_chart
            // 
            this.Services_pie_chart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Services_pie_chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services_pie_chart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Services_pie_chart.Location = new System.Drawing.Point(275, 65);
            this.Services_pie_chart.Name = "Services_pie_chart";
            this.Services_pie_chart.Size = new System.Drawing.Size(377, 213);
            this.Services_pie_chart.TabIndex = 14;
            this.Services_pie_chart.Text = "elementHost1";
            this.Services_pie_chart.Child = this.pieChart1;
            // 
            // DispatchedChart
            // 
            this.DispatchedChart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DispatchedChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispatchedChart.Location = new System.Drawing.Point(658, 65);
            this.DispatchedChart.Name = "DispatchedChart";
            this.DispatchedChart.Size = new System.Drawing.Size(398, 213);
            this.DispatchedChart.TabIndex = 12;
            this.DispatchedChart.Text = "cartesianChart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(375, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Services Performance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(774, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "RFB\'s Performance";
            // 
            // CityChart
            // 
            this.CityChart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CityChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityChart.Location = new System.Drawing.Point(275, 294);
            this.CityChart.Name = "CityChart";
            this.CityChart.Size = new System.Drawing.Size(781, 204);
            this.CityChart.TabIndex = 13;
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo_panel.Controls.Add(this.pictureBox1);
            this.logo_panel.Controls.Add(this.label6);
            this.logo_panel.Controls.Add(this.lbl_currentUser);
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(170, 176);
            this.logo_panel.TabIndex = 0;
            this.logo_panel.Click += new System.EventHandler(this.logo_panel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(39, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Welcome";
            // 
            // lbl_currentUser
            // 
            this.lbl_currentUser.AutoSize = true;
            this.lbl_currentUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_currentUser.Location = new System.Drawing.Point(70, 148);
            this.lbl_currentUser.Name = "lbl_currentUser";
            this.lbl_currentUser.Size = new System.Drawing.Size(131, 25);
            this.lbl_currentUser.TabIndex = 9;
            this.lbl_currentUser.Text = "Current user";
            // 
            // btn_menu_cust
            // 
            this.btn_menu_cust.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_menu_cust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu_cust.BackgroundImage")));
            this.btn_menu_cust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_cust.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu_cust.FlatAppearance.BorderSize = 0;
            this.btn_menu_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu_cust.Location = new System.Drawing.Point(0, 176);
            this.btn_menu_cust.Name = "btn_menu_cust";
            this.btn_menu_cust.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_cust.Size = new System.Drawing.Size(170, 52);
            this.btn_menu_cust.TabIndex = 0;
            this.btn_menu_cust.Text = "Customer";
            this.btn_menu_cust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu_cust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu_cust.UseVisualStyleBackColor = false;
            this.btn_menu_cust.Click += new System.EventHandler(this.btn_menu_cust_Click);
            // 
            // Customers_panel
            // 
            this.Customers_panel.Controls.Add(this.btn_managecus_sub);
            this.Customers_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customers_panel.Location = new System.Drawing.Point(0, 228);
            this.Customers_panel.Name = "Customers_panel";
            this.Customers_panel.Size = new System.Drawing.Size(170, 47);
            this.Customers_panel.TabIndex = 5;
            // 
            // btn_managecus_sub
            // 
            this.btn_managecus_sub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_managecus_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_managecus_sub.FlatAppearance.BorderSize = 0;
            this.btn_managecus_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managecus_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_managecus_sub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_managecus_sub.Location = new System.Drawing.Point(0, 0);
            this.btn_managecus_sub.Name = "btn_managecus_sub";
            this.btn_managecus_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_managecus_sub.Size = new System.Drawing.Size(170, 50);
            this.btn_managecus_sub.TabIndex = 3;
            this.btn_managecus_sub.Text = "Manage Customer";
            this.btn_managecus_sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_managecus_sub.UseVisualStyleBackColor = false;
            this.btn_managecus_sub.Click += new System.EventHandler(this.btn_managecus_sub_Click);
            // 
            // btn_menu_employees
            // 
            this.btn_menu_employees.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_menu_employees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu_employees.BackgroundImage")));
            this.btn_menu_employees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menu_employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu_employees.FlatAppearance.BorderSize = 0;
            this.btn_menu_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu_employees.Location = new System.Drawing.Point(0, 275);
            this.btn_menu_employees.Name = "btn_menu_employees";
            this.btn_menu_employees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_employees.Size = new System.Drawing.Size(170, 50);
            this.btn_menu_employees.TabIndex = 0;
            this.btn_menu_employees.Text = "Employee";
            this.btn_menu_employees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu_employees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_menu_employees.UseVisualStyleBackColor = false;
            this.btn_menu_employees.Click += new System.EventHandler(this.btn_menu_employees_Click);
            // 
            // emp_panel
            // 
            this.emp_panel.Controls.Add(this.btn_attendance_sub);
            this.emp_panel.Controls.Add(this.btn_manageEmp_sub);
            this.emp_panel.Controls.Add(this.btn_payroll_sub);
            this.emp_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.emp_panel.Location = new System.Drawing.Point(0, 325);
            this.emp_panel.Name = "emp_panel";
            this.emp_panel.Size = new System.Drawing.Size(170, 144);
            this.emp_panel.TabIndex = 5;
            // 
            // btn_attendance_sub
            // 
            this.btn_attendance_sub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_attendance_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendance_sub.FlatAppearance.BorderSize = 0;
            this.btn_attendance_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance_sub.Location = new System.Drawing.Point(0, 100);
            this.btn_attendance_sub.Name = "btn_attendance_sub";
            this.btn_attendance_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_attendance_sub.Size = new System.Drawing.Size(170, 44);
            this.btn_attendance_sub.TabIndex = 1;
            this.btn_attendance_sub.Text = "Attendance";
            this.btn_attendance_sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_attendance_sub.UseVisualStyleBackColor = false;
            this.btn_attendance_sub.Click += new System.EventHandler(this.btn_attendance_sub_Click);
            // 
            // btn_manageEmp_sub
            // 
            this.btn_manageEmp_sub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_manageEmp_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manageEmp_sub.FlatAppearance.BorderSize = 0;
            this.btn_manageEmp_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageEmp_sub.Location = new System.Drawing.Point(0, 50);
            this.btn_manageEmp_sub.Name = "btn_manageEmp_sub";
            this.btn_manageEmp_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_manageEmp_sub.Size = new System.Drawing.Size(170, 50);
            this.btn_manageEmp_sub.TabIndex = 2;
            this.btn_manageEmp_sub.Text = "Manage Employees";
            this.btn_manageEmp_sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_manageEmp_sub.UseVisualStyleBackColor = false;
            this.btn_manageEmp_sub.Click += new System.EventHandler(this.btn_manageEmp_sub_Click);
            // 
            // btn_payroll_sub
            // 
            this.btn_payroll_sub.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_payroll_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_payroll_sub.FlatAppearance.BorderSize = 0;
            this.btn_payroll_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payroll_sub.Location = new System.Drawing.Point(0, 0);
            this.btn_payroll_sub.Name = "btn_payroll_sub";
            this.btn_payroll_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_payroll_sub.Size = new System.Drawing.Size(170, 50);
            this.btn_payroll_sub.TabIndex = 3;
            this.btn_payroll_sub.Text = "PayRoll";
            this.btn_payroll_sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_payroll_sub.UseVisualStyleBackColor = false;
            this.btn_payroll_sub.Visible = false;
            this.btn_payroll_sub.Click += new System.EventHandler(this.btn_payroll_sub_Click);
            // 
            // nav_panel
            // 
            this.nav_panel.AutoScroll = true;
            this.nav_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nav_panel.Controls.Add(this.userPanel);
            this.nav_panel.Controls.Add(this.settings_panel);
            this.nav_panel.Controls.Add(this.btn_main_settings);
            this.nav_panel.Controls.Add(this.services_panel);
            this.nav_panel.Controls.Add(this.btn_main_services);
            this.nav_panel.Controls.Add(this.inventory_panel);
            this.nav_panel.Controls.Add(this.btn_main_invent);
            this.nav_panel.Controls.Add(this.emp_panel);
            this.nav_panel.Controls.Add(this.btn_menu_employees);
            this.nav_panel.Controls.Add(this.Customers_panel);
            this.nav_panel.Controls.Add(this.btn_menu_cust);
            this.nav_panel.Controls.Add(this.logo_panel);
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(187, 598);
            this.nav_panel.TabIndex = 16;
            this.nav_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.nav_panel_Paint);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.btn_signout);
            this.userPanel.Controls.Add(this.lbl_time);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 984);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(170, 165);
            this.userPanel.TabIndex = 29;
            // 
            // btn_signout
            // 
            this.btn_signout.AutoSize = true;
            this.btn_signout.BackColor = System.Drawing.Color.Transparent;
            this.btn_signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_signout.Location = new System.Drawing.Point(28, 82);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(112, 25);
            this.btn_signout.TabIndex = 10;
            this.btn_signout.Text = "SIGN OUT";
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_time.Location = new System.Drawing.Point(28, 131);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(96, 25);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "00:00:00";
            this.lbl_time.Visible = false;
            // 
            // settings_panel
            // 
            this.settings_panel.Controls.Add(this.btn_viewchangePass);
            this.settings_panel.Controls.Add(this.btn_auditLogs);
            this.settings_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_panel.Location = new System.Drawing.Point(0, 862);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(170, 122);
            this.settings_panel.TabIndex = 17;
            // 
            // btn_viewchangePass
            // 
            this.btn_viewchangePass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_viewchangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_viewchangePass.FlatAppearance.BorderSize = 0;
            this.btn_viewchangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewchangePass.Location = new System.Drawing.Point(0, 50);
            this.btn_viewchangePass.Name = "btn_viewchangePass";
            this.btn_viewchangePass.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btn_viewchangePass.Size = new System.Drawing.Size(170, 50);
            this.btn_viewchangePass.TabIndex = 29;
            this.btn_viewchangePass.Text = "Change Password";
            this.btn_viewchangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewchangePass.UseVisualStyleBackColor = false;
            this.btn_viewchangePass.Click += new System.EventHandler(this.btn_viewchangePass_Click);
            // 
            // btn_auditLogs
            // 
            this.btn_auditLogs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_auditLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_auditLogs.FlatAppearance.BorderSize = 0;
            this.btn_auditLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auditLogs.Location = new System.Drawing.Point(0, 0);
            this.btn_auditLogs.Name = "btn_auditLogs";
            this.btn_auditLogs.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btn_auditLogs.Size = new System.Drawing.Size(170, 50);
            this.btn_auditLogs.TabIndex = 28;
            this.btn_auditLogs.Text = "Audit Logs";
            this.btn_auditLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_auditLogs.UseVisualStyleBackColor = false;
            this.btn_auditLogs.Click += new System.EventHandler(this.btn_auditLogs_Click);
            // 
            // btn_main_settings
            // 
            this.btn_main_settings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_main_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_main_settings.BackgroundImage")));
            this.btn_main_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_main_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_settings.FlatAppearance.BorderSize = 0;
            this.btn_main_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_settings.Location = new System.Drawing.Point(0, 812);
            this.btn_main_settings.Name = "btn_main_settings";
            this.btn_main_settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_settings.Size = new System.Drawing.Size(170, 50);
            this.btn_main_settings.TabIndex = 27;
            this.btn_main_settings.Text = "Settings";
            this.btn_main_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_settings.UseVisualStyleBackColor = false;
            this.btn_main_settings.Click += new System.EventHandler(this.btn_main_settings_Click);
            // 
            // services_panel
            // 
            this.services_panel.Controls.Add(this.btn_Dispatch);
            this.services_panel.Controls.Add(this.btn_pos);
            this.services_panel.Controls.Add(this.btn_Sched);
            this.services_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.services_panel.Location = new System.Drawing.Point(0, 666);
            this.services_panel.Name = "services_panel";
            this.services_panel.Size = new System.Drawing.Size(170, 146);
            this.services_panel.TabIndex = 17;
            // 
            // btn_Dispatch
            // 
            this.btn_Dispatch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Dispatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Dispatch.FlatAppearance.BorderSize = 0;
            this.btn_Dispatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dispatch.Location = new System.Drawing.Point(0, 100);
            this.btn_Dispatch.Name = "btn_Dispatch";
            this.btn_Dispatch.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Dispatch.Size = new System.Drawing.Size(170, 46);
            this.btn_Dispatch.TabIndex = 28;
            this.btn_Dispatch.Text = "Dispatch";
            this.btn_Dispatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Dispatch.UseVisualStyleBackColor = false;
            this.btn_Dispatch.Click += new System.EventHandler(this.btn_Dispatch_Click);
            // 
            // btn_pos
            // 
            this.btn_pos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pos.FlatAppearance.BorderSize = 0;
            this.btn_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pos.Location = new System.Drawing.Point(0, 50);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_pos.Size = new System.Drawing.Size(170, 50);
            this.btn_pos.TabIndex = 27;
            this.btn_pos.Text = "Point of Sale";
            this.btn_pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pos.UseVisualStyleBackColor = false;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // btn_Sched
            // 
            this.btn_Sched.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sched.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Sched.FlatAppearance.BorderSize = 0;
            this.btn_Sched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sched.Location = new System.Drawing.Point(0, 0);
            this.btn_Sched.Name = "btn_Sched";
            this.btn_Sched.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Sched.Size = new System.Drawing.Size(170, 50);
            this.btn_Sched.TabIndex = 26;
            this.btn_Sched.Text = "Schedule";
            this.btn_Sched.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sched.UseVisualStyleBackColor = false;
            this.btn_Sched.Click += new System.EventHandler(this.btn_Sched_Click);
            // 
            // btn_main_services
            // 
            this.btn_main_services.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_main_services.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_main_services.BackgroundImage")));
            this.btn_main_services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_main_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_services.FlatAppearance.BorderSize = 0;
            this.btn_main_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_services.Location = new System.Drawing.Point(0, 616);
            this.btn_main_services.Name = "btn_main_services";
            this.btn_main_services.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_services.Size = new System.Drawing.Size(170, 50);
            this.btn_main_services.TabIndex = 26;
            this.btn_main_services.Text = "Services";
            this.btn_main_services.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_services.UseVisualStyleBackColor = false;
            this.btn_main_services.Click += new System.EventHandler(this.btn_main_services_Click);
            // 
            // inventory_panel
            // 
            this.inventory_panel.Controls.Add(this.btn_prodInventory);
            this.inventory_panel.Controls.Add(this.btn_equip_inv);
            this.inventory_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventory_panel.Location = new System.Drawing.Point(0, 521);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(170, 95);
            this.inventory_panel.TabIndex = 23;
            this.inventory_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.inventory_panel_Paint);
            // 
            // btn_prodInventory
            // 
            this.btn_prodInventory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_prodInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prodInventory.FlatAppearance.BorderSize = 0;
            this.btn_prodInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prodInventory.Location = new System.Drawing.Point(0, 50);
            this.btn_prodInventory.Name = "btn_prodInventory";
            this.btn_prodInventory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_prodInventory.Size = new System.Drawing.Size(170, 45);
            this.btn_prodInventory.TabIndex = 26;
            this.btn_prodInventory.Text = "Product Inventory";
            this.btn_prodInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_prodInventory.UseVisualStyleBackColor = false;
            this.btn_prodInventory.Click += new System.EventHandler(this.btn_prodInventory_Click);
            // 
            // btn_equip_inv
            // 
            this.btn_equip_inv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_equip_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_equip_inv.FlatAppearance.BorderSize = 0;
            this.btn_equip_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equip_inv.Location = new System.Drawing.Point(0, 0);
            this.btn_equip_inv.Name = "btn_equip_inv";
            this.btn_equip_inv.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_equip_inv.Size = new System.Drawing.Size(170, 50);
            this.btn_equip_inv.TabIndex = 25;
            this.btn_equip_inv.Text = "Equipment Inventory";
            this.btn_equip_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_equip_inv.UseVisualStyleBackColor = false;
            this.btn_equip_inv.Click += new System.EventHandler(this.btn_equip_inv_Click);
            // 
            // btn_main_invent
            // 
            this.btn_main_invent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_main_invent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_main_invent.BackgroundImage")));
            this.btn_main_invent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_main_invent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_invent.FlatAppearance.BorderSize = 0;
            this.btn_main_invent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_invent.Location = new System.Drawing.Point(0, 469);
            this.btn_main_invent.Name = "btn_main_invent";
            this.btn_main_invent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_invent.Size = new System.Drawing.Size(170, 52);
            this.btn_main_invent.TabIndex = 19;
            this.btn_main_invent.Text = "Inventories";
            this.btn_main_invent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_main_invent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_main_invent.UseVisualStyleBackColor = false;
            this.btn_main_invent.Click += new System.EventHandler(this.btn_main_invent_Click);
            // 
            // dispatchFormPanel
            // 
            this.dispatchFormPanel.Controls.Add(this.mainServiceControl1);
            this.dispatchFormPanel.Location = new System.Drawing.Point(561, 366);
            this.dispatchFormPanel.Name = "dispatchFormPanel";
            this.dispatchFormPanel.Size = new System.Drawing.Size(76, 68);
            this.dispatchFormPanel.TabIndex = 18;
            this.dispatchFormPanel.Visible = false;
            // 
            // mainServiceControl1
            // 
            this.mainServiceControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.mainServiceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainServiceControl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mainServiceControl1.Location = new System.Drawing.Point(0, 0);
            this.mainServiceControl1.Name = "mainServiceControl1";
            this.mainServiceControl1.Size = new System.Drawing.Size(76, 68);
            this.mainServiceControl1.TabIndex = 17;
            this.mainServiceControl1.Visible = false;
            // 
            // employeePanel
            // 
            this.employeePanel.BackColor = System.Drawing.Color.Transparent;
            this.employeePanel.Controls.Add(this.employeesControl1);
            this.employeePanel.Location = new System.Drawing.Point(658, 325);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(73, 67);
            this.employeePanel.TabIndex = 19;
            this.employeePanel.Visible = false;
            // 
            // employeesControl1
            // 
            this.employeesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesControl1.emp_setter = false;
            this.employeesControl1.Location = new System.Drawing.Point(0, 0);
            this.employeesControl1.Name = "employeesControl1";
            this.employeesControl1.Size = new System.Drawing.Size(73, 67);
            this.employeesControl1.TabIndex = 0;
            // 
            // customersControl1Panel
            // 
            this.customersControl1Panel.Controls.Add(this.customersControl1);
            this.customersControl1Panel.Location = new System.Drawing.Point(778, 325);
            this.customersControl1Panel.Name = "customersControl1Panel";
            this.customersControl1Panel.Size = new System.Drawing.Size(65, 67);
            this.customersControl1Panel.TabIndex = 21;
            this.customersControl1Panel.Visible = false;
            // 
            // customersControl1
            // 
            this.customersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersControl1.Location = new System.Drawing.Point(0, 0);
            this.customersControl1.Name = "customersControl1";
            this.customersControl1.Size = new System.Drawing.Size(65, 67);
            this.customersControl1.TabIndex = 20;
            this.customersControl1.Visible = false;
            // 
            // attendanceControlpanel
            // 
            this.attendanceControlpanel.Controls.Add(this.attendanceControl1);
            this.attendanceControlpanel.Location = new System.Drawing.Point(929, 325);
            this.attendanceControlpanel.Name = "attendanceControlpanel";
            this.attendanceControlpanel.Size = new System.Drawing.Size(69, 100);
            this.attendanceControlpanel.TabIndex = 22;
            this.attendanceControlpanel.Visible = false;
            // 
            // attendanceControl1
            // 
            this.attendanceControl1.BackColor = System.Drawing.Color.Transparent;
            this.attendanceControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("attendanceControl1.BackgroundImage")));
            this.attendanceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceControl1.Location = new System.Drawing.Point(0, 0);
            this.attendanceControl1.Name = "attendanceControl1";
            this.attendanceControl1.Size = new System.Drawing.Size(69, 100);
            this.attendanceControl1.TabIndex = 1;
            this.attendanceControl1.Visible = false;
            // 
            // payroll_mainPanel
            // 
            this.payroll_mainPanel.Controls.Add(this.payrollControl1);
            this.payroll_mainPanel.Location = new System.Drawing.Point(689, 410);
            this.payroll_mainPanel.Name = "payroll_mainPanel";
            this.payroll_mainPanel.Size = new System.Drawing.Size(54, 70);
            this.payroll_mainPanel.TabIndex = 23;
            this.payroll_mainPanel.Visible = false;
            // 
            // payrollControl1
            // 
            this.payrollControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payrollControl1.Location = new System.Drawing.Point(0, 0);
            this.payrollControl1.Name = "payrollControl1";
            this.payrollControl1.Size = new System.Drawing.Size(54, 70);
            this.payrollControl1.TabIndex = 24;
            this.payrollControl1.UserFirstname = null;
            // 
            // productInvPanel
            // 
            this.productInvPanel.Controls.Add(this.productInvControl1);
            this.productInvPanel.Location = new System.Drawing.Point(778, 410);
            this.productInvPanel.Name = "productInvPanel";
            this.productInvPanel.Size = new System.Drawing.Size(85, 77);
            this.productInvPanel.TabIndex = 24;
            this.productInvPanel.Visible = false;
            // 
            // productInvControl1
            // 
            this.productInvControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productInvControl1.Location = new System.Drawing.Point(0, 0);
            this.productInvControl1.Name = "productInvControl1";
            this.productInvControl1.Size = new System.Drawing.Size(85, 77);
            this.productInvControl1.TabIndex = 25;
            // 
            // equipControlPanel
            // 
            this.equipControlPanel.Controls.Add(this.equipInvControl1);
            this.equipControlPanel.Location = new System.Drawing.Point(899, 139);
            this.equipControlPanel.Name = "equipControlPanel";
            this.equipControlPanel.Size = new System.Drawing.Size(60, 50);
            this.equipControlPanel.TabIndex = 26;
            this.equipControlPanel.Visible = false;
            // 
            // equipInvControl1
            // 
            this.equipInvControl1.BackColor = System.Drawing.Color.Gainsboro;
            this.equipInvControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipInvControl1.Location = new System.Drawing.Point(0, 0);
            this.equipInvControl1.Name = "equipInvControl1";
            this.equipInvControl1.Size = new System.Drawing.Size(60, 50);
            this.equipInvControl1.TabIndex = 25;
            // 
            // auditControlPanel
            // 
            this.auditControlPanel.Controls.Add(this.auditControl1);
            this.auditControlPanel.Location = new System.Drawing.Point(379, 366);
            this.auditControlPanel.Name = "auditControlPanel";
            this.auditControlPanel.Size = new System.Drawing.Size(86, 83);
            this.auditControlPanel.TabIndex = 27;
            this.auditControlPanel.Visible = false;
            // 
            // auditControl1
            // 
            this.auditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auditControl1.Location = new System.Drawing.Point(0, 0);
            this.auditControl1.Name = "auditControl1";
            this.auditControl1.Size = new System.Drawing.Size(86, 83);
            this.auditControl1.TabIndex = 0;
            // 
            // pos_controlPanel
            // 
            this.pos_controlPanel.Controls.Add(this.salesControl1);
            this.pos_controlPanel.Location = new System.Drawing.Point(275, 388);
            this.pos_controlPanel.Name = "pos_controlPanel";
            this.pos_controlPanel.Size = new System.Drawing.Size(74, 61);
            this.pos_controlPanel.TabIndex = 28;
            this.pos_controlPanel.Visible = false;
            // 
            // salesControl1
            // 
            this.salesControl1.CurrentUser = null;
            this.salesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesControl1.Location = new System.Drawing.Point(0, 0);
            this.salesControl1.Name = "salesControl1";
            this.salesControl1.Size = new System.Drawing.Size(74, 61);
            this.salesControl1.TabIndex = 0;
            this.salesControl1.user = null;
            // 
            // time_timer
            // 
            this.time_timer.Interval = 1000;
            this.time_timer.Tick += new System.EventHandler(this.time_timer_Tick);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_username.Location = new System.Drawing.Point(218, 535);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(170, 25);
            this.lbl_username.TabIndex = 29;
            this.lbl_username.Text = "user\'s Firstname";
            this.lbl_username.Visible = false;
            // 
            // dispatchePanel
            // 
            this.dispatchePanel.Controls.Add(this.dispatchesControl1);
            this.dispatchePanel.Location = new System.Drawing.Point(716, 122);
            this.dispatchePanel.Name = "dispatchePanel";
            this.dispatchePanel.Size = new System.Drawing.Size(85, 97);
            this.dispatchePanel.TabIndex = 30;
            this.dispatchePanel.Visible = false;
            // 
            // dispatchesControl1
            // 
            this.dispatchesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dispatchesControl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dispatchesControl1.Location = new System.Drawing.Point(0, 0);
            this.dispatchesControl1.Name = "dispatchesControl1";
            this.dispatchesControl1.Size = new System.Drawing.Size(85, 97);
            this.dispatchesControl1.TabIndex = 31;
            // 
            // changePassPanel
            // 
            this.changePassPanel.BackColor = System.Drawing.Color.Transparent;
            this.changePassPanel.Controls.Add(this.tb_current);
            this.changePassPanel.Controls.Add(this.btn_check);
            this.changePassPanel.Controls.Add(this.lbl_confirmAccess);
            this.changePassPanel.Controls.Add(this.confirmAccessPanel);
            this.changePassPanel.Location = new System.Drawing.Point(942, 535);
            this.changePassPanel.Name = "changePassPanel";
            this.changePassPanel.Size = new System.Drawing.Size(521, 281);
            this.changePassPanel.TabIndex = 32;
            this.changePassPanel.Visible = false;
            // 
            // tb_current
            // 
            this.tb_current.BackColor = System.Drawing.Color.Transparent;
            this.tb_current.BorderRadius = 4;
            this.tb_current.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_current.DefaultText = "";
            this.tb_current.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_current.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_current.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_current.DisabledState.Parent = this.tb_current;
            this.tb_current.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_current.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_current.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_current.FocusedState.Parent = this.tb_current;
            this.tb_current.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_current.ForeColor = System.Drawing.Color.Black;
            this.tb_current.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_current.HoverState.Parent = this.tb_current;
            this.tb_current.Location = new System.Drawing.Point(176, 97);
            this.tb_current.Name = "tb_current";
            this.tb_current.PasswordChar = '*';
            this.tb_current.PlaceholderText = "Current Password";
            this.tb_current.SelectedText = "";
            this.tb_current.ShadowDecoration.Parent = this.tb_current;
            this.tb_current.Size = new System.Drawing.Size(165, 36);
            this.tb_current.TabIndex = 128;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.Transparent;
            this.btn_check.BorderRadius = 4;
            this.btn_check.CheckedState.Parent = this.btn_check;
            this.btn_check.CustomImages.Parent = this.btn_check;
            this.btn_check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_check.DisabledState.Parent = this.btn_check;
            this.btn_check.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.HoverState.Parent = this.btn_check;
            this.btn_check.Location = new System.Drawing.Point(362, 94);
            this.btn_check.Name = "btn_check";
            this.btn_check.ShadowDecoration.Parent = this.btn_check;
            this.btn_check.Size = new System.Drawing.Size(146, 37);
            this.btn_check.TabIndex = 144;
            this.btn_check.Text = "CHECK";
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_confirmAccess
            // 
            this.lbl_confirmAccess.AutoSize = true;
            this.lbl_confirmAccess.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmAccess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_confirmAccess.Location = new System.Drawing.Point(18, 105);
            this.lbl_confirmAccess.Name = "lbl_confirmAccess";
            this.lbl_confirmAccess.Size = new System.Drawing.Size(158, 20);
            this.lbl_confirmAccess.TabIndex = 122;
            this.lbl_confirmAccess.Text = "Change Password:";
            // 
            // confirmAccessPanel
            // 
            this.confirmAccessPanel.BackColor = System.Drawing.Color.Transparent;
            this.confirmAccessPanel.Controls.Add(this.tb_confirm);
            this.confirmAccessPanel.Controls.Add(this.btn_confirm);
            this.confirmAccessPanel.Controls.Add(this.label4);
            this.confirmAccessPanel.Controls.Add(this.tb_newPass);
            this.confirmAccessPanel.Controls.Add(this.label3);
            this.confirmAccessPanel.Location = new System.Drawing.Point(15, 137);
            this.confirmAccessPanel.Name = "confirmAccessPanel";
            this.confirmAccessPanel.Size = new System.Drawing.Size(503, 110);
            this.confirmAccessPanel.TabIndex = 143;
            this.confirmAccessPanel.Visible = false;
            // 
            // tb_confirm
            // 
            this.tb_confirm.BackColor = System.Drawing.Color.Transparent;
            this.tb_confirm.BorderRadius = 4;
            this.tb_confirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_confirm.DefaultText = "";
            this.tb_confirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_confirm.DisabledState.Parent = this.tb_confirm;
            this.tb_confirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_confirm.Enabled = false;
            this.tb_confirm.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_confirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_confirm.FocusedState.Parent = this.tb_confirm;
            this.tb_confirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_confirm.ForeColor = System.Drawing.Color.Black;
            this.tb_confirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_confirm.HoverState.Parent = this.tb_confirm;
            this.tb_confirm.Location = new System.Drawing.Point(161, 61);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.PasswordChar = '*';
            this.tb_confirm.PlaceholderText = "Confirm Password";
            this.tb_confirm.SelectedText = "";
            this.tb_confirm.ShadowDecoration.Parent = this.tb_confirm;
            this.tb_confirm.Size = new System.Drawing.Size(165, 36);
            this.tb_confirm.TabIndex = 127;
            this.tb_confirm.TextChanged += new System.EventHandler(this.tb_confirm_TextChanged);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.BorderRadius = 4;
            this.btn_confirm.CheckedState.Parent = this.btn_confirm;
            this.btn_confirm.CustomImages.Parent = this.btn_confirm;
            this.btn_confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirm.DisabledState.Parent = this.btn_confirm;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.HoverState.Parent = this.btn_confirm;
            this.btn_confirm.Location = new System.Drawing.Point(347, 6);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.ShadowDecoration.Parent = this.btn_confirm;
            this.btn_confirm.Size = new System.Drawing.Size(146, 37);
            this.btn_confirm.TabIndex = 144;
            this.btn_confirm.Text = "CONFIRM CHANGE";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 126;
            this.label4.Text = "Change Password:";
            // 
            // tb_newPass
            // 
            this.tb_newPass.BackColor = System.Drawing.Color.Transparent;
            this.tb_newPass.BorderRadius = 4;
            this.tb_newPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_newPass.DefaultText = "";
            this.tb_newPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_newPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_newPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_newPass.DisabledState.Parent = this.tb_newPass;
            this.tb_newPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_newPass.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tb_newPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_newPass.FocusedState.Parent = this.tb_newPass;
            this.tb_newPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_newPass.ForeColor = System.Drawing.Color.Black;
            this.tb_newPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_newPass.HoverState.Parent = this.tb_newPass;
            this.tb_newPass.Location = new System.Drawing.Point(161, 11);
            this.tb_newPass.Name = "tb_newPass";
            this.tb_newPass.PasswordChar = '*';
            this.tb_newPass.PlaceholderText = "New Password";
            this.tb_newPass.SelectedText = "";
            this.tb_newPass.ShadowDecoration.Parent = this.tb_newPass;
            this.tb_newPass.Size = new System.Drawing.Size(165, 36);
            this.tb_newPass.TabIndex = 125;
            this.tb_newPass.TextChanged += new System.EventHandler(this.tb_newPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 124;
            this.label3.Text = "New Password:";
            // 
            // lbl_usernameee
            // 
            this.lbl_usernameee.BackColor = System.Drawing.Color.Black;
            this.lbl_usernameee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_usernameee.Location = new System.Drawing.Point(1062, 96);
            this.lbl_usernameee.Name = "lbl_usernameee";
            this.lbl_usernameee.Size = new System.Drawing.Size(49, 15);
            this.lbl_usernameee.TabIndex = 33;
            this.lbl_usernameee.Text = "username";
            this.lbl_usernameee.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(557, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "RFB\'s Cities Performance";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(1147, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 34);
            this.btn_exit.TabIndex = 34;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1192, 598);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_usernameee);
            this.Controls.Add(this.changePassPanel);
            this.Controls.Add(this.dispatchePanel);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pos_controlPanel);
            this.Controls.Add(this.auditControlPanel);
            this.Controls.Add(this.equipControlPanel);
            this.Controls.Add(this.productInvPanel);
            this.Controls.Add(this.payroll_mainPanel);
            this.Controls.Add(this.attendanceControlpanel);
            this.Controls.Add(this.customersControl1Panel);
            this.Controls.Add(this.employeePanel);
            this.Controls.Add(this.dispatchFormPanel);
            this.Controls.Add(this.nav_panel);
            this.Controls.Add(this.Services_pie_chart);
            this.Controls.Add(this.DispatchedChart);
            this.Controls.Add(this.CityChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Customers_panel.ResumeLayout(false);
            this.emp_panel.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.settings_panel.ResumeLayout(false);
            this.services_panel.ResumeLayout(false);
            this.inventory_panel.ResumeLayout(false);
            this.dispatchFormPanel.ResumeLayout(false);
            this.employeePanel.ResumeLayout(false);
            this.customersControl1Panel.ResumeLayout(false);
            this.attendanceControlpanel.ResumeLayout(false);
            this.payroll_mainPanel.ResumeLayout(false);
            this.productInvPanel.ResumeLayout(false);
            this.equipControlPanel.ResumeLayout(false);
            this.auditControlPanel.ResumeLayout(false);
            this.pos_controlPanel.ResumeLayout(false);
            this.dispatchePanel.ResumeLayout(false);
            this.changePassPanel.ResumeLayout(false);
            this.changePassPanel.PerformLayout();
            this.confirmAccessPanel.ResumeLayout(false);
            this.confirmAccessPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost Services_pie_chart;
        private LiveCharts.Wpf.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart DispatchedChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    //    private UserForms.MainServiceControl mainServiceControl;
        private LiveCharts.WinForms.CartesianChart CityChart;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Button btn_menu_cust;
        private System.Windows.Forms.Panel Customers_panel;
        private System.Windows.Forms.Button btn_managecus_sub;
        private System.Windows.Forms.Button btn_menu_employees;
        private System.Windows.Forms.Panel emp_panel;
        private System.Windows.Forms.Button btn_manageEmp_sub;
        private System.Windows.Forms.Button btn_payroll_sub;
        private System.Windows.Forms.Panel nav_panel;
        private System.Windows.Forms.Button btn_attendance_sub;
        private System.Windows.Forms.Button btn_main_invent;
        private System.Windows.Forms.Panel inventory_panel;
        private System.Windows.Forms.Button btn_equip_inv;
        private System.Windows.Forms.Panel services_panel;
        private System.Windows.Forms.Button btn_main_services;
        private System.Windows.Forms.Button btn_Sched;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Button btn_auditLogs;
        private System.Windows.Forms.Button btn_main_settings;
        private UserForms.MainServiceControl mainServiceControl1;
        private System.Windows.Forms.Panel dispatchFormPanel;
        private System.Windows.Forms.Panel employeePanel;
        private UserformControls.EmployeeControl employeesControl1;
        private UserformControls.CustomersControl customersControl1;
        private System.Windows.Forms.Panel customersControl1Panel;
        private UserformControls.AttendanceControl attendanceControl1;
        private System.Windows.Forms.Panel attendanceControlpanel;
        private System.Windows.Forms.Panel payroll_mainPanel;
        private UserformControls.PayrollControl payrollControl1;
        private System.Windows.Forms.Button btn_prodInventory;
        private System.Windows.Forms.Panel productInvPanel;
        private UserformControls.ProductInvControl productInvControl1;
        private UserformControls.EquipInvControl equipInvControl1;
        private System.Windows.Forms.Panel equipControlPanel;
        private System.Windows.Forms.Panel auditControlPanel;
        private UserformControls.AuditControl auditControl1;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Panel pos_controlPanel;
        private UserformControls.SalesControl salesControl1;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Timer time_timer;
        private System.Windows.Forms.Label lbl_time;
        public System.Windows.Forms.Label lbl_currentUser;
        public System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_Dispatch;
        private System.Windows.Forms.Panel dispatchePanel;
        private UserformControls.DispatchesControl dispatchesControl1;
        private System.Windows.Forms.Button btn_viewchangePass;
        private System.Windows.Forms.Panel changePassPanel;
        private System.Windows.Forms.Label lbl_confirmAccess;
        private System.Windows.Forms.Panel confirmAccessPanel;
        private Guna.UI2.WinForms.Guna2Button btn_check;
        private Guna.UI2.WinForms.Guna2TextBox tb_confirm;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tb_newPass;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tb_current;
        private Guna.UI2.WinForms.Guna2Button btn_confirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_usernameee;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label btn_signout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label6;
    }
}