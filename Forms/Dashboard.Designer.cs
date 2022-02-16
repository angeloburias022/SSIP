
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
            this.btn_sched_sub = new System.Windows.Forms.Button();
            this.btn_dispatch_sub = new System.Windows.Forms.Button();
            this.btn_managecus_sub = new System.Windows.Forms.Button();
            this.btn_menu_employees = new System.Windows.Forms.Button();
            this.emp_panel = new System.Windows.Forms.Panel();
            this.btn_attendance_sub = new System.Windows.Forms.Button();
            this.btn_manageEmp_sub = new System.Windows.Forms.Button();
            this.btn_payroll_sub = new System.Windows.Forms.Button();
            this.nav_panel = new System.Windows.Forms.Panel();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.btn_auditLogs = new System.Windows.Forms.Button();
            this.btn_main_settings = new System.Windows.Forms.Button();
            this.services_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_main_services = new System.Windows.Forms.Button();
            this.inventory_panel = new System.Windows.Forms.Panel();
            this.btn_equip_inv = new System.Windows.Forms.Button();
            this.btn_sales_inv = new System.Windows.Forms.Button();
            this.btn_main_invent = new System.Windows.Forms.Button();
            this.dispatchFormPanel = new System.Windows.Forms.Panel();
            this.mainServiceControl1 = new SSIP.UserForms.MainServiceControl();
            this.Customers_panel.SuspendLayout();
            this.emp_panel.SuspendLayout();
            this.nav_panel.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.services_panel.SuspendLayout();
            this.inventory_panel.SuspendLayout();
            this.dispatchFormPanel.SuspendLayout();
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
            this.CityChart.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.CityChart_ChildChanged);
            // 
            // logo_panel
            // 
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(180, 99);
            this.logo_panel.TabIndex = 0;
            // 
            // btn_menu_cust
            // 
            this.btn_menu_cust.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menu_cust.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu_cust.FlatAppearance.BorderSize = 0;
            this.btn_menu_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu_cust.Location = new System.Drawing.Point(0, 99);
            this.btn_menu_cust.Name = "btn_menu_cust";
            this.btn_menu_cust.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_cust.Size = new System.Drawing.Size(180, 50);
            this.btn_menu_cust.TabIndex = 0;
            this.btn_menu_cust.Text = "Customers";
            this.btn_menu_cust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu_cust.UseVisualStyleBackColor = false;
            this.btn_menu_cust.Click += new System.EventHandler(this.btn_menu_cust_Click);
            // 
            // Customers_panel
            // 
            this.Customers_panel.Controls.Add(this.btn_sched_sub);
            this.Customers_panel.Controls.Add(this.btn_dispatch_sub);
            this.Customers_panel.Controls.Add(this.btn_managecus_sub);
            this.Customers_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customers_panel.Location = new System.Drawing.Point(0, 149);
            this.Customers_panel.Name = "Customers_panel";
            this.Customers_panel.Size = new System.Drawing.Size(180, 153);
            this.Customers_panel.TabIndex = 5;
            // 
            // btn_sched_sub
            // 
            this.btn_sched_sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sched_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sched_sub.FlatAppearance.BorderSize = 0;
            this.btn_sched_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sched_sub.Location = new System.Drawing.Point(0, 100);
            this.btn_sched_sub.Name = "btn_sched_sub";
            this.btn_sched_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_sched_sub.Size = new System.Drawing.Size(180, 53);
            this.btn_sched_sub.TabIndex = 2;
            this.btn_sched_sub.Text = "Schedule";
            this.btn_sched_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sched_sub.UseVisualStyleBackColor = false;
            // 
            // btn_dispatch_sub
            // 
            this.btn_dispatch_sub.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dispatch_sub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dispatch_sub.FlatAppearance.BorderSize = 0;
            this.btn_dispatch_sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dispatch_sub.Location = new System.Drawing.Point(0, 50);
            this.btn_dispatch_sub.Name = "btn_dispatch_sub";
            this.btn_dispatch_sub.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_dispatch_sub.Size = new System.Drawing.Size(180, 50);
            this.btn_dispatch_sub.TabIndex = 1;
            this.btn_dispatch_sub.Text = "Dispatch";
            this.btn_dispatch_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dispatch_sub.UseVisualStyleBackColor = false;
            this.btn_dispatch_sub.Click += new System.EventHandler(this.btn_dispatch_sub_Click_1);
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
            this.btn_managecus_sub.Size = new System.Drawing.Size(180, 50);
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
            this.btn_menu_employees.Location = new System.Drawing.Point(0, 302);
            this.btn_menu_employees.Name = "btn_menu_employees";
            this.btn_menu_employees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_menu_employees.Size = new System.Drawing.Size(180, 50);
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
            this.emp_panel.Location = new System.Drawing.Point(0, 352);
            this.emp_panel.Name = "emp_panel";
            this.emp_panel.Size = new System.Drawing.Size(180, 118);
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
            this.btn_attendance_sub.Size = new System.Drawing.Size(180, 50);
            this.btn_attendance_sub.TabIndex = 1;
            this.btn_attendance_sub.Text = "Attendance";
            this.btn_attendance_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendance_sub.UseVisualStyleBackColor = false;
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
            this.btn_manageEmp_sub.Size = new System.Drawing.Size(180, 50);
            this.btn_manageEmp_sub.TabIndex = 2;
            this.btn_manageEmp_sub.Text = "Manage Employees";
            this.btn_manageEmp_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageEmp_sub.UseVisualStyleBackColor = false;
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
            this.btn_payroll_sub.Size = new System.Drawing.Size(180, 50);
            this.btn_payroll_sub.TabIndex = 3;
            this.btn_payroll_sub.Text = "PayRoll";
            this.btn_payroll_sub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payroll_sub.UseVisualStyleBackColor = false;
            // 
            // nav_panel
            // 
            this.nav_panel.AutoScroll = true;
            this.nav_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.nav_panel.Size = new System.Drawing.Size(197, 526);
            this.nav_panel.TabIndex = 16;
            // 
            // settings_panel
            // 
            this.settings_panel.Controls.Add(this.btn_auditLogs);
            this.settings_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_panel.Location = new System.Drawing.Point(0, 753);
            this.settings_panel.Name = "settings_panel";
            this.settings_panel.Size = new System.Drawing.Size(180, 57);
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
            this.btn_auditLogs.Size = new System.Drawing.Size(180, 50);
            this.btn_auditLogs.TabIndex = 28;
            this.btn_auditLogs.Text = "Audit Logs";
            this.btn_auditLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_auditLogs.UseVisualStyleBackColor = false;
            // 
            // btn_main_settings
            // 
            this.btn_main_settings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_main_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_settings.FlatAppearance.BorderSize = 0;
            this.btn_main_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_settings.Location = new System.Drawing.Point(0, 703);
            this.btn_main_settings.Name = "btn_main_settings";
            this.btn_main_settings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_settings.Size = new System.Drawing.Size(180, 50);
            this.btn_main_settings.TabIndex = 27;
            this.btn_main_settings.Text = "Settings";
            this.btn_main_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_settings.UseVisualStyleBackColor = false;
            this.btn_main_settings.Click += new System.EventHandler(this.btn_main_settings_Click);
            // 
            // services_panel
            // 
            this.services_panel.Controls.Add(this.button1);
            this.services_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.services_panel.Location = new System.Drawing.Point(0, 658);
            this.services_panel.Name = "services_panel";
            this.services_panel.Size = new System.Drawing.Size(180, 45);
            this.services_panel.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(180, 50);
            this.button1.TabIndex = 26;
            this.button1.Text = "Customer\'s Archived";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_main_services
            // 
            this.btn_main_services.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_main_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main_services.FlatAppearance.BorderSize = 0;
            this.btn_main_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_services.Location = new System.Drawing.Point(0, 608);
            this.btn_main_services.Name = "btn_main_services";
            this.btn_main_services.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_services.Size = new System.Drawing.Size(180, 50);
            this.btn_main_services.TabIndex = 26;
            this.btn_main_services.Text = "Services";
            this.btn_main_services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_services.UseVisualStyleBackColor = false;
            this.btn_main_services.Click += new System.EventHandler(this.btn_main_services_Click);
            // 
            // inventory_panel
            // 
            this.inventory_panel.Controls.Add(this.btn_equip_inv);
            this.inventory_panel.Controls.Add(this.btn_sales_inv);
            this.inventory_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventory_panel.Location = new System.Drawing.Point(0, 520);
            this.inventory_panel.Name = "inventory_panel";
            this.inventory_panel.Size = new System.Drawing.Size(180, 88);
            this.inventory_panel.TabIndex = 23;
            this.inventory_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.inventory_panel_Paint);
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
            this.btn_equip_inv.Size = new System.Drawing.Size(180, 50);
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
            this.btn_sales_inv.Size = new System.Drawing.Size(180, 50);
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
            this.btn_main_invent.Location = new System.Drawing.Point(0, 470);
            this.btn_main_invent.Name = "btn_main_invent";
            this.btn_main_invent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_main_invent.Size = new System.Drawing.Size(180, 50);
            this.btn_main_invent.TabIndex = 19;
            this.btn_main_invent.Text = "Inventories";
            this.btn_main_invent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main_invent.UseVisualStyleBackColor = false;
            this.btn_main_invent.Click += new System.EventHandler(this.btn_main_invent_Click);
            // 
            // dispatchFormPanel
            // 
            this.dispatchFormPanel.Controls.Add(this.mainServiceControl1);
            this.dispatchFormPanel.Location = new System.Drawing.Point(957, 49);
            this.dispatchFormPanel.Name = "dispatchFormPanel";
            this.dispatchFormPanel.Size = new System.Drawing.Size(200, 100);
            this.dispatchFormPanel.TabIndex = 18;
            this.dispatchFormPanel.Visible = false;
            // 
            // mainServiceControl1
            // 
            this.mainServiceControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainServiceControl1.BackgroundImage")));
            this.mainServiceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainServiceControl1.Location = new System.Drawing.Point(0, 0);
            this.mainServiceControl1.Name = "mainServiceControl1";
            this.mainServiceControl1.Size = new System.Drawing.Size(200, 100);
            this.mainServiceControl1.TabIndex = 17;
            this.mainServiceControl1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1185, 526);
            this.Controls.Add(this.dispatchFormPanel);
            this.Controls.Add(this.nav_panel);
            this.Controls.Add(this.Services_pie_chart);
            this.Controls.Add(this.DispatchedChart);
            this.Controls.Add(this.CityChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.settings_panel.ResumeLayout(false);
            this.services_panel.ResumeLayout(false);
            this.inventory_panel.ResumeLayout(false);
            this.dispatchFormPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_sched_sub;
        private System.Windows.Forms.Button btn_dispatch_sub;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel settings_panel;
        private System.Windows.Forms.Button btn_auditLogs;
        private System.Windows.Forms.Button btn_main_settings;
        private UserForms.MainServiceControl mainServiceControl1;
        private System.Windows.Forms.Panel dispatchFormPanel;
    }
}