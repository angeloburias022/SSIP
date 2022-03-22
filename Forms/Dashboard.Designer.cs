
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
            this.btn_menu_cust = new System.Windows.Forms.Button();
            this.Customers_panel = new System.Windows.Forms.Panel();
            this.btn_cusArchived = new System.Windows.Forms.Button();
            this.btn_managecus_sub = new System.Windows.Forms.Button();
            this.btn_menu_employees = new System.Windows.Forms.Button();
            this.emp_panel = new System.Windows.Forms.Panel();
            this.btn_attendance_sub = new System.Windows.Forms.Button();
            this.btn_manageEmp_sub = new System.Windows.Forms.Button();
            this.btn_payroll_sub = new System.Windows.Forms.Button();
            this.nav_panel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.lbl_currentUser = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.btn_auditLogs = new System.Windows.Forms.Button();
            this.btn_main_settings = new System.Windows.Forms.Button();
            this.services_panel = new System.Windows.Forms.Panel();
            this.btn_pos = new System.Windows.Forms.Button();
            this.btn_dispatchSched = new System.Windows.Forms.Button();
            this.btn_main_services = new System.Windows.Forms.Button();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.btn_prodInventory = new System.Windows.Forms.Button();
            this.btn_equip_inv = new System.Windows.Forms.Button();
            this.btn_sales_inv = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // Services_pie_chart
            // 
            this.Services_pie_chart.BackColor = System.Drawing.Color.Transparent;
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
            this.DispatchedChart.BackColor = System.Drawing.Color.Transparent;
            this.DispatchedChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(299, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Services Performance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(714, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "RFB\'s Performance";
            // 
            // CityChart
            // 
            this.CityChart.BackColor = System.Drawing.Color.Transparent;
            this.CityChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityChart.Location = new System.Drawing.Point(255, 298);
            this.CityChart.Name = "CityChart";
            this.CityChart.Size = new System.Drawing.Size(801, 204);
            this.CityChart.TabIndex = 13;
            this.CityChart.Text = "cartesianChart2";
            // 
            // logo_panel
            // 
            this.logo_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_panel.BackgroundImage")));
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(232, 130);
            this.logo_panel.TabIndex = 0;
            // 
            // btn_menu_cust
            // 
            this.btn_menu_cust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu_cust.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu_cust.FlatAppearance.BorderSize = 0;
            this.btn_menu_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_cust.Location = new System.Drawing.Point(0, 130);
            this.btn_menu_cust.Name = "btn_menu_cust";
            this.btn_menu_cust.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_cust.Size = new System.Drawing.Size(232, 50);
            this.btn_menu_cust.TabIndex = 0;
            this.btn_menu_cust.Text = "Customers";
            this.btn_menu_cust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_cust.UseVisualStyleBackColor = false;
            this.btn_menu_cust.Click += new System.EventHandler(this.btn_menu_cust_Click);
            // 
            // Customers_panel
            // 
            this.Customers_panel.Controls.Add(this.btn_cusArchived);
            this.Customers_panel.Controls.Add(this.btn_managecus_sub);
            this.Customers_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customers_panel.Location = new System.Drawing.Point(0, 180);
            this.Customers_panel.Name = "Customers_panel";
            this.Customers_panel.Size = new System.Drawing.Size(232, 102);
            this.Customers_panel.TabIndex = 5;
            // 
            // btn_cusArchived
            // 
            this.btn_cusArchived.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cusArchived.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cusArchived.FlatAppearance.BorderSize = 0;
            this.btn_cusArchived.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cusArchived.Location = new System.Drawing.Point(0, 50);
            this.btn_cusArchived.Name = "btn_cusArchived";
            this.btn_cusArchived.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_cusArchived.Size = new System.Drawing.Size(232, 50);
            this.btn_cusArchived.TabIndex = 1;
            this.btn_cusArchived.Text = "Customer\'s Archived";
            this.btn_cusArchived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cusArchived.UseVisualStyleBackColor = false;
            // 
            // btn_managecus_sub
            // 
            this.btn_managecus_sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_managecus_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_managecus_sub.FlatAppearance.BorderSize = 0;
            this.btn_managecus_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managecus_sub.Location = new System.Drawing.Point(0, 0);
            this.btn_managecus_sub.Name = "btn_managecus_sub";
            this.btn_managecus_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_managecus_sub.Size = new System.Drawing.Size(232, 50);
            this.btn_managecus_sub.TabIndex = 3;
            this.btn_managecus_sub.Text = "Manage Customers";
            this.btn_managecus_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_managecus_sub.UseVisualStyleBackColor = false;
            this.btn_managecus_sub.Click += new System.EventHandler(this.btn_managecus_sub_Click);
            // 
            // btn_menu_employees
            // 
            this.btn_menu_employees.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu_employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu_employees.FlatAppearance.BorderSize = 0;
            this.btn_menu_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_menu_employees.Location = new System.Drawing.Point(0, 282);
            this.btn_menu_employees.Name = "btn_menu_employees";
            this.btn_menu_employees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_employees.Size = new System.Drawing.Size(232, 50);
            this.btn_menu_employees.TabIndex = 0;
            this.btn_menu_employees.Text = "Employees";
            this.btn_menu_employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_employees.UseVisualStyleBackColor = false;
            this.btn_menu_employees.Click += new System.EventHandler(this.btn_menu_employees_Click);
            // 
            // emp_panel
            // 
            this.emp_panel.Controls.Add(this.btn_attendance_sub);
            this.emp_panel.Controls.Add(this.btn_manageEmp_sub);
            this.emp_panel.Controls.Add(this.btn_payroll_sub);
            this.emp_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.emp_panel.Location = new System.Drawing.Point(0, 332);
            this.emp_panel.Name = "emp_panel";
            this.emp_panel.Size = new System.Drawing.Size(232, 144);
            this.emp_panel.TabIndex = 5;
            // 
            // btn_attendance_sub
            // 
            this.btn_attendance_sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_attendance_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendance_sub.FlatAppearance.BorderSize = 0;
            this.btn_attendance_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance_sub.Location = new System.Drawing.Point(0, 100);
            this.btn_attendance_sub.Name = "btn_attendance_sub";
            this.btn_attendance_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_attendance_sub.Size = new System.Drawing.Size(232, 50);
            this.btn_attendance_sub.TabIndex = 1;
            this.btn_attendance_sub.Text = "Attendance";
            this.btn_attendance_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendance_sub.UseVisualStyleBackColor = false;
            this.btn_attendance_sub.Click += new System.EventHandler(this.btn_attendance_sub_Click);
            // 
            // btn_manageEmp_sub
            // 
            this.btn_manageEmp_sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_manageEmp_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manageEmp_sub.FlatAppearance.BorderSize = 0;
            this.btn_manageEmp_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageEmp_sub.Location = new System.Drawing.Point(0, 50);
            this.btn_manageEmp_sub.Name = "btn_manageEmp_sub";
            this.btn_manageEmp_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_manageEmp_sub.Size = new System.Drawing.Size(232, 50);
            this.btn_manageEmp_sub.TabIndex = 2;
            this.btn_manageEmp_sub.Text = "Manage Employees";
            this.btn_manageEmp_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageEmp_sub.UseVisualStyleBackColor = false;
            this.btn_manageEmp_sub.Click += new System.EventHandler(this.btn_manageEmp_sub_Click);
            // 
            // btn_payroll_sub
            // 
            this.btn_payroll_sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_payroll_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_payroll_sub.FlatAppearance.BorderSize = 0;
            this.btn_payroll_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payroll_sub.Location = new System.Drawing.Point(0, 0);
            this.btn_payroll_sub.Name = "btn_payroll_sub";
            this.btn_payroll_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_payroll_sub.Size = new System.Drawing.Size(232, 50);
            this.btn_payroll_sub.TabIndex = 3;
            this.btn_payroll_sub.Text = "PayRoll";
            this.btn_payroll_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_sub.UseVisualStyleBackColor = false;
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
            this.nav_panel.Size = new System.Drawing.Size(249, 525);
            this.nav_panel.TabIndex = 16;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.lbl_currentUser);
            this.userPanel.Controls.Add(this.lbl_time);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPanel.Location = new System.Drawing.Point(0, 919);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(232, 165);
            this.userPanel.TabIndex = 29;
            // 
            // lbl_currentUser
            // 
            this.lbl_currentUser.AutoSize = true;
            this.lbl_currentUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_currentUser.Location = new System.Drawing.Point(3, 28);
            this.lbl_currentUser.Name = "lbl_currentUser";
            this.lbl_currentUser.Size = new System.Drawing.Size(177, 31);
            this.lbl_currentUser.TabIndex = 9;
            this.lbl_currentUser.Text = "Current user";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_time.Location = new System.Drawing.Point(48, 58);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(128, 31);
            this.lbl_time.TabIndex = 9;
            this.lbl_time.Text = "00:00:00";
            // 
            // settings_panel
            // 
            this.settings_panel.Controls.Add(this.btn_auditLogs);
            this.settings_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_panel.Location = new System.Drawing.Point(0, 867);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(232, 52);
            this.settings_panel.TabIndex = 17;
            // 
            // btn_auditLogs
            // 
            this.btn_auditLogs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_auditLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_auditLogs.FlatAppearance.BorderSize = 0;
            this.btn_auditLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_auditLogs.Location = new System.Drawing.Point(0, 0);
            this.btn_auditLogs.Name = "btn_auditLogs";
            this.btn_auditLogs.Padding = new System.Windows.Forms.Padding(36, 0, 0, 0);
            this.btn_auditLogs.Size = new System.Drawing.Size(232, 50);
            this.btn_auditLogs.TabIndex = 28;
            this.btn_auditLogs.Text = "Audit Logs";
            this.btn_auditLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_auditLogs.UseVisualStyleBackColor = false;
            this.btn_auditLogs.Click += new System.EventHandler(this.btn_auditLogs_Click);
            // 
            // btn_main_settings
            // 
            this.btn_main_settings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_main_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_settings.FlatAppearance.BorderSize = 0;
            this.btn_main_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_settings.Location = new System.Drawing.Point(0, 817);
            this.btn_main_settings.Name = "btn_main_settings";
            this.btn_main_settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_settings.Size = new System.Drawing.Size(232, 50);
            this.btn_main_settings.TabIndex = 27;
            this.btn_main_settings.Text = "Settings";
            this.btn_main_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_settings.UseVisualStyleBackColor = false;
            this.btn_main_settings.Click += new System.EventHandler(this.btn_main_settings_Click);
            // 
            // services_panel
            // 
            this.services_panel.Controls.Add(this.btn_pos);
            this.services_panel.Controls.Add(this.btn_dispatchSched);
            this.services_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.services_panel.Location = new System.Drawing.Point(0, 719);
            this.services_panel.Name = "services_panel";
            this.services_panel.Size = new System.Drawing.Size(232, 98);
            this.services_panel.TabIndex = 17;
            // 
            // btn_pos
            // 
            this.btn_pos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pos.FlatAppearance.BorderSize = 0;
            this.btn_pos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pos.Location = new System.Drawing.Point(0, 50);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_pos.Size = new System.Drawing.Size(232, 50);
            this.btn_pos.TabIndex = 27;
            this.btn_pos.Text = "Point of Sale";
            this.btn_pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pos.UseVisualStyleBackColor = false;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // btn_dispatchSched
            // 
            this.btn_dispatchSched.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dispatchSched.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dispatchSched.FlatAppearance.BorderSize = 0;
            this.btn_dispatchSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dispatchSched.Location = new System.Drawing.Point(0, 0);
            this.btn_dispatchSched.Name = "btn_dispatchSched";
            this.btn_dispatchSched.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_dispatchSched.Size = new System.Drawing.Size(232, 50);
            this.btn_dispatchSched.TabIndex = 26;
            this.btn_dispatchSched.Text = "Dispatch/Schedule";
            this.btn_dispatchSched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dispatchSched.UseVisualStyleBackColor = false;
            this.btn_dispatchSched.Click += new System.EventHandler(this.btn_dispatchSched_Click);
            // 
            // btn_main_services
            // 
            this.btn_main_services.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_main_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_services.FlatAppearance.BorderSize = 0;
            this.btn_main_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_services.Location = new System.Drawing.Point(0, 669);
            this.btn_main_services.Name = "btn_main_services";
            this.btn_main_services.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_services.Size = new System.Drawing.Size(232, 50);
            this.btn_main_services.TabIndex = 26;
            this.btn_main_services.Text = "Services";
            this.btn_main_services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_services.UseVisualStyleBackColor = false;
            this.btn_main_services.Click += new System.EventHandler(this.btn_main_services_Click);
            // 
            // inventory_panel
            // 
            this.inventory_panel.Controls.Add(this.btn_prodInventory);
            this.inventory_panel.Controls.Add(this.btn_equip_inv);
            this.inventory_panel.Controls.Add(this.btn_sales_inv);
            this.inventory_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventory_panel.Location = new System.Drawing.Point(0, 526);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(232, 143);
            this.inventory_panel.TabIndex = 23;
            this.inventory_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.inventory_panel_Paint);
            // 
            // btn_prodInventory
            // 
            this.btn_prodInventory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prodInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prodInventory.FlatAppearance.BorderSize = 0;
            this.btn_prodInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prodInventory.Location = new System.Drawing.Point(0, 100);
            this.btn_prodInventory.Name = "btn_prodInventory";
            this.btn_prodInventory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_prodInventory.Size = new System.Drawing.Size(232, 50);
            this.btn_prodInventory.TabIndex = 26;
            this.btn_prodInventory.Text = "Product Inventory";
            this.btn_prodInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prodInventory.UseVisualStyleBackColor = false;
            this.btn_prodInventory.Click += new System.EventHandler(this.btn_prodInventory_Click);
            // 
            // btn_equip_inv
            // 
            this.btn_equip_inv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_equip_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_equip_inv.FlatAppearance.BorderSize = 0;
            this.btn_equip_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equip_inv.Location = new System.Drawing.Point(0, 50);
            this.btn_equip_inv.Name = "btn_equip_inv";
            this.btn_equip_inv.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_equip_inv.Size = new System.Drawing.Size(232, 50);
            this.btn_equip_inv.TabIndex = 25;
            this.btn_equip_inv.Text = "Equipment Inventory";
            this.btn_equip_inv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_equip_inv.UseVisualStyleBackColor = false;
            this.btn_equip_inv.Click += new System.EventHandler(this.btn_equip_inv_Click);
            // 
            // btn_sales_inv
            // 
            this.btn_sales_inv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sales_inv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sales_inv.FlatAppearance.BorderSize = 0;
            this.btn_sales_inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales_inv.Location = new System.Drawing.Point(0, 0);
            this.btn_sales_inv.Name = "btn_sales_inv";
            this.btn_sales_inv.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_sales_inv.Size = new System.Drawing.Size(232, 50);
            this.btn_sales_inv.TabIndex = 24;
            this.btn_sales_inv.Text = "Sales Inventory";
            this.btn_sales_inv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_inv.UseVisualStyleBackColor = false;
            this.btn_sales_inv.Click += new System.EventHandler(this.btn_sales_inv_Click);
            // 
            // btn_main_invent
            // 
            this.btn_main_invent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_main_invent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_invent.FlatAppearance.BorderSize = 0;
            this.btn_main_invent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_invent.Location = new System.Drawing.Point(0, 476);
            this.btn_main_invent.Name = "btn_main_invent";
            this.btn_main_invent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_invent.Size = new System.Drawing.Size(232, 50);
            this.btn_main_invent.TabIndex = 19;
            this.btn_main_invent.Text = "Inventories";
            this.btn_main_invent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_invent.UseVisualStyleBackColor = false;
            this.btn_main_invent.Click += new System.EventHandler(this.btn_main_invent_Click);
            // 
            // dispatchFormPanel
            // 
            this.dispatchFormPanel.Controls.Add(this.mainServiceControl1);
            this.dispatchFormPanel.Location = new System.Drawing.Point(552, 366);
            this.dispatchFormPanel.Name = "dispatchFormPanel";
            this.dispatchFormPanel.Size = new System.Drawing.Size(85, 68);
            this.dispatchFormPanel.TabIndex = 18;
            this.dispatchFormPanel.Visible = false;
            // 
            // mainServiceControl1
            // 
            this.mainServiceControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainServiceControl1.BackgroundImage")));
            this.mainServiceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainServiceControl1.Location = new System.Drawing.Point(0, 0);
            this.mainServiceControl1.Name = "mainServiceControl1";
            this.mainServiceControl1.Size = new System.Drawing.Size(85, 68);
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
            this.employeesControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeesControl1.BackgroundImage")));
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
            this.customersControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customersControl1.BackgroundImage")));
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
            this.attendanceControlpanel.Location = new System.Drawing.Point(882, 334);
            this.attendanceControlpanel.Name = "attendanceControlpanel";
            this.attendanceControlpanel.Size = new System.Drawing.Size(69, 100);
            this.attendanceControlpanel.TabIndex = 22;
            this.attendanceControlpanel.Visible = false;
            // 
            // attendanceControl1
            // 
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
            this.payroll_mainPanel.Location = new System.Drawing.Point(690, 432);
            this.payroll_mainPanel.Name = "payroll_mainPanel";
            this.payroll_mainPanel.Size = new System.Drawing.Size(54, 70);
            this.payroll_mainPanel.TabIndex = 23;
            this.payroll_mainPanel.Visible = false;
            // 
            // payrollControl1
            // 
            this.payrollControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("payrollControl1.BackgroundImage")));
            this.payrollControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payrollControl1.Location = new System.Drawing.Point(0, 0);
            this.payrollControl1.Name = "payrollControl1";
            this.payrollControl1.Size = new System.Drawing.Size(54, 70);
            this.payrollControl1.TabIndex = 24;
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
            this.productInvControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productInvControl1.BackgroundImage")));
            this.productInvControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productInvControl1.Location = new System.Drawing.Point(0, 0);
            this.productInvControl1.Name = "productInvControl1";
            this.productInvControl1.Size = new System.Drawing.Size(85, 77);
            this.productInvControl1.TabIndex = 25;
            // 
            // equipControlPanel
            // 
            this.equipControlPanel.Controls.Add(this.equipInvControl1);
            this.equipControlPanel.Location = new System.Drawing.Point(978, 325);
            this.equipControlPanel.Name = "equipControlPanel";
            this.equipControlPanel.Size = new System.Drawing.Size(60, 50);
            this.equipControlPanel.TabIndex = 26;
            this.equipControlPanel.Visible = false;
            // 
            // equipInvControl1
            // 
            this.equipInvControl1.BackColor = System.Drawing.Color.White;
            this.equipInvControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("equipInvControl1.BackgroundImage")));
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
            this.auditControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("auditControl1.BackgroundImage")));
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
            this.salesControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesControl1.BackgroundImage")));
            this.salesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesControl1.Location = new System.Drawing.Point(0, 0);
            this.salesControl1.Name = "salesControl1";
            this.salesControl1.Size = new System.Drawing.Size(74, 61);
            this.salesControl1.TabIndex = 0;
            // 
            // time_timer
            // 
            this.time_timer.Interval = 1000;
            this.time_timer.Tick += new System.EventHandler(this.time_timer_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1185, 525);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
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
        private System.Windows.Forms.Button btn_cusArchived;
        private System.Windows.Forms.Button btn_managecus_sub;
        private System.Windows.Forms.Button btn_menu_employees;
        private System.Windows.Forms.Panel emp_panel;
        private System.Windows.Forms.Button btn_manageEmp_sub;
        private System.Windows.Forms.Button btn_payroll_sub;
        private System.Windows.Forms.Panel nav_panel;
        private System.Windows.Forms.Button btn_attendance_sub;
        private System.Windows.Forms.Button btn_main_invent;
        private System.Windows.Forms.Panel inventory_panel;
        private System.Windows.Forms.Button btn_sales_inv;
        private System.Windows.Forms.Button btn_equip_inv;
        private System.Windows.Forms.Panel services_panel;
        private System.Windows.Forms.Button btn_main_services;
        private System.Windows.Forms.Button btn_dispatchSched;
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
    }
}