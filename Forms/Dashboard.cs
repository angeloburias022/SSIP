using LiveCharts;
using LiveCharts.Wpf;
using SSIP.AccessControls;
using SSIP.Models;
using SSIP.UserformControls;
using SSIP.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.Forms
{
    public partial class Dashboard : Form
    {
        #region declarations
        MainServiceControl ms = new MainServiceControl();
        public Dashboard()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        #endregion

        #region load charts
        private void Dashboard_Load(object sender, EventArgs e)
        {
            time_timer.Start();
            //this.dispatchControl1.Visible = false;
            //this.mainServiceControl.BringToFront();
            //   this.mainServiceControl.Visible = false;

            try
            {
                #region NCR chart

                // NCR chart
                using (DashboardEntities db = new DashboardEntities())
                {
                    var data = db.SpNCRChart(); // get the stored proc inside the entity
                    ColumnSeries col = new ColumnSeries() // access the cartesian chart
                    {
                        DataLabels = true,
                        Values = new ChartValues<int>(),
                        LabelPoint = point => point.Y.ToString()
                    };

                    Axis ax = new Axis()
                    {
                        Separator = new Separator() { Step = 1, IsEnabled = false }
                    };

                    ax.Labels = new List<string>();


                    // loop through the database
                    foreach (var city in data)
                    {

                        col.Values.Add(city.caloocan.Value);
                        ax.Labels.Add("Caloocan");



                        col.Values.Add(city.laspinas.Value);
                        ax.Labels.Add("Las pinas");



                        col.Values.Add(city.makati.Value);
                        ax.Labels.Add("Makati");



                        col.Values.Add(city.malabon.Value);
                        ax.Labels.Add("Malabon");



                        col.Values.Add(city.mandaluyong.Value);
                        ax.Labels.Add("Mandaluyong");



                        col.Values.Add(city.manila.Value);
                        ax.Labels.Add("Manila");



                        col.Values.Add(city.muntinlupa.Value);
                        ax.Labels.Add("Muntinlupa");



                        col.Values.Add(city.navotas.Value);
                        ax.Labels.Add("Navotas");




                        col.Values.Add(city.paranaque.Value);
                        ax.Labels.Add("Paranaque");


                        col.Values.Add(city.pasay.Value);
                        ax.Labels.Add("Pasay");


                        col.Values.Add(city.pasig.Value);
                        ax.Labels.Add("Pasig");


                        col.Values.Add(city.pateros.Value);
                        ax.Labels.Add("Pateros");



                        col.Values.Add(city.quezon.Value);
                        ax.Labels.Add("Quezon");


                        col.Values.Add(city.sanjuan.Value);
                        ax.Labels.Add("San juan");



                        col.Values.Add(city.taguig.Value);
                        ax.Labels.Add("Taguig");


                        col.Values.Add(city.valenzuela.Value);
                        ax.Labels.Add("Valenzuela");





                    }


                    CityChart.Series.Add(col);
                    CityChart.AxisX.Add(ax);
                    CityChart.AxisY.Add(
                        new Axis
                        {
                            LabelFormatter = value => value.ToString(),
                            Separator = new Separator()
                        });


                }

                #endregion

                #region Dispatch Chart


                // Dispatched chart
                using (DashboardEntities db = new DashboardEntities())
                {
                    var data = db.SpGetNoOfDispatched(); // get the stored proc inside the entity
                    ColumnSeries col = new ColumnSeries() // access the cartesian chart
                    {
                        DataLabels = true,
                        Values = new ChartValues<int>(),
                        LabelPoint = point => point.Y.ToString()
                    };

                    Axis ax = new Axis()
                    {
                        Separator = new Separator() { Step = 1, IsEnabled = false }
                    };

                    ax.Labels = new List<string>();


                    //   loop through the database
                    foreach (var disp in data)
                    {

                        col.Values.Add(disp.Value);
                        ax.Labels.Add("Dispatched");




                    }


                    DispatchedChart.Series.Add(col);
                    DispatchedChart.AxisX.Add(ax);
                    DispatchedChart.AxisY.Add(
                        new Axis
                        {
                            LabelFormatter = value => value.ToString(),
                            Separator = new Separator()
                        });


                }
                #endregion

                #region Services chart  
                // Services chart
                SeriesCollection series = new SeriesCollection();
                using (DashboardEntities db = new DashboardEntities())
                {
                    var data = db.SpServicesChart(); // get the stored proc inside the entity


                    Func<ChartPoint, string> labelPoint = chartPoint =>
                      string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);




                    try
                    {
                        foreach (var services in data)
                        {
                            PieSeries pie_cleaning = new PieSeries
                            {
                                DataLabels = true,
                                LabelPoint = labelPoint,
                                Title = "Cleaning",
                                Values = new ChartValues<int> { services.clea.Value }
                            };

                            PieSeries pie_repair = new PieSeries
                            {
                                DataLabels = true,
                                LabelPoint = labelPoint,
                                Title = "Repair",
                                Values = new ChartValues<int> { services.rep.Value }
                            };

                            PieSeries pie_ins = new PieSeries
                            {
                                DataLabels = true,
                                LabelPoint = labelPoint,
                                Title = "Installation",
                                Values = new ChartValues<int> { services.ins.Value }
                            };

                            PieSeries pie_checkup = new PieSeries
                            {
                                DataLabels = true,
                                LabelPoint = labelPoint,
                                Title = "Check-up",
                                Values = new ChartValues<int> { services.che.Value }
                            };


                            series.Add(pie_cleaning);
                            series.Add(pie_repair);
                            series.Add(pie_ins);
                            series.Add(pie_checkup);
                            pieChart1.Series = series;
                        }

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("something went wrong" + error);
                    }

                    pieChart1.LegendLocation = LegendLocation.Right;

                    //SeriesCollection series = new SeriesCollection();

                    //foreach (var obj in db.SpServicesChart())
                    //    series.Add(new PieSeries() { Title = obj.che.ToString(), Values = new ChartValues<int> { obj.clea.ToString(), ChartValues = new ChartValues<string>, } DataLabels = true, LabelPoint = LabelPoint);
                    //pieChart1.Series = series;
                }
                #endregion

            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong in Dashboard" + error);
            }
        }
        #endregion

        #region load user name
 
        public string LabelText
        {
            get
            {
                return this.lbl_currentUser.Text;
            }
            set
            {
                this.lbl_currentUser.Text = value;
            }
        }
        #endregion

        #region main clicks event handler
        private void btn_menu_cust_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Customers_panel);
        }
        private void btn_dispatch_sub_Click(object sender, EventArgs e)
        {
            // logic here
            HideSubMenu();
        }
        private void btn_mangecus_sub_Click(object sender, EventArgs e)
        {
            // logic here
            HideSubMenu();
        }
        private void btn_main_invent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(inventory_panel);
        }
        private void btn_main_services_Click(object sender, EventArgs e)
        {
            ShowSubMenu(services_panel);
        }
        private void inventory_panel_Paint(object sender, PaintEventArgs e)
        {
            //HideEmployeesPanelControl();
            //HideMainServicesPanelControl();
            //HideCustomersPanelControl();
            //HideAttendanceControl();
            //HidePayRollControl();

            //HideSubMenu();
        }
        private void btn_menu_employees_Click(object sender, EventArgs e)
        {
            ShowSubMenu(emp_panel);
        }
        private void btn_main_settings_Click(object sender, EventArgs e)
        {
            ShowSubMenu(settings_panel);
        }
        #endregion

        #region Hide and show sub menu
        private void HideSubMenu()
        {
            if (Customers_panel.Visible == true)
                Customers_panel.Visible = false;

            if (emp_panel.Visible == true)
                emp_panel.Visible = false;

            if (inventory_panel.Visible == true)
                inventory_panel.Visible = false;

            if (services_panel.Visible == true)
                services_panel.Visible = false;

            if (settings_panel.Visible == true)
                settings_panel.Visible = false;

        }
        private void CustomizeDesign()
        {

            Customers_panel.Visible = false;
            emp_panel.Visible = false;
            inventory_panel.Visible = false;
            services_panel.Visible = false;
            settings_panel.Visible = false;


            //btn_dispatch_sub.Visible = false;
            //btn_sched_sub.Visible = false;
            //btn_managecus_sub.Visible = false;


            //btn_attendance_sub.Visible = false;
            //btn_manageEmp_sub.Visible = false;
            //btn_payroll_sub.Visible = false;


            //btn_sales_sub.Visible = false;
            //btn_equip_sub.Visible = false;

            //btn_cus_archived_sub.Visible = false;
            //btn_audit_sub.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        #endregion

        #region Hide and Show control panel
        private void ShowPOSControl()
        {
            pos_controlPanel.Dock = DockStyle.Fill;
            pos_controlPanel.Visible = true;
            this.salesControl1.BringToFront();
            this.salesControl1.Show();
          
        }
        private void HidePOSControl()
        {
            pos_controlPanel.Hide();
            pos_controlPanel.Dock = DockStyle.None;
        }
        private void ShowAudControl()
        {
            auditControlPanel.Dock = DockStyle.Fill;
            auditControlPanel.Visible = true;
            this.auditControl1.BringToFront();
            this.auditControl1.Show();

        }
        private void HideAudControl()
        {
            auditControlPanel.Hide();
            auditControlPanel.Dock = DockStyle.None;
        }
        private void ShowEquipInvControl()
        {
            equipControlPanel.Dock = DockStyle.Fill;
            equipControlPanel.Visible = true;
            this.equipInvControl1.BringToFront();
            this.equipInvControl1.Show();

        }
        private void HideEquipInvControl()
        {
            equipControlPanel.Hide();
            equipControlPanel.Dock = DockStyle.None;
        }
        private void ShowProductInvControl()
        {
            productInvPanel.Dock = DockStyle.Fill;
            productInvPanel.Visible = true;
            this.payrollControl1.BringToFront();
            this.payrollControl1.Show();

        }
        private void HideProductInvControl()
        {
            productInvPanel.Hide();
            productInvPanel.Dock = DockStyle.None;
        }
        private void ShowMainServicesControl()
        {
            dispatchFormPanel.Dock = DockStyle.Fill;
            this.mainServiceControl1.BringToFront();
            this.mainServiceControl1.Show();

            dispatchFormPanel.Visible = true;
            dispatchFormPanel.Dock = DockStyle.Fill;
        }
        private void HideMainServicesPanelControl()
        {
            dispatchFormPanel.Hide();
            dispatchFormPanel.Dock = DockStyle.None;
        }
        private void ShowEmployeesPanelControl()
        {
            this.employeesControl1.BringToFront();
            this.employeesControl1.Show();
            this.employeePanel.Visible = true;
            this.employeePanel.Dock = DockStyle.Fill;
        }
        private void HideEmployeesPanelControl()
        {
            employeePanel.Hide();
            employeePanel.Dock = DockStyle.None;
        }
        private void ShowCustomersPanelControl()
        {
            this.customersControl1.BringToFront();
            this.customersControl1.Show();
            this.customersControl1Panel.Visible = true;
            this.customersControl1Panel.Dock = DockStyle.Fill;
        }
        private void HideCustomersPanelControl()
        {
            customersControl1Panel.Hide();
            customersControl1Panel.Dock = DockStyle.None;
        }
        private void ShowAttendanceControl()
        {
            attendanceControlpanel.Dock = DockStyle.Fill;
            this.attendanceControl1.BringToFront();
            this.attendanceControl1.Show();

            attendanceControlpanel.Visible = true;
            attendanceControlpanel.Dock = DockStyle.Fill;
        }
        private void HideAttendanceControl()
        {
            attendanceControlpanel.Hide();
            attendanceControlpanel.Dock = DockStyle.None;
        }
        private void ShowPayRollControl()
        {
            this.payroll_mainPanel.Visible = true;
            this.payroll_mainPanel.Dock = DockStyle.Fill;
           
        }
        private void HidePayRollControl()
        {
            this.payroll_mainPanel.Visible = false;
            this.payroll_mainPanel.Dock = DockStyle.None;
        }
        #endregion

        #region sub clicks event handler
        private void btn_pos_Click(object sender, EventArgs e)
        {
            HideMainServicesPanelControl();
            HideEmployeesPanelControl();
            HideCustomersPanelControl();
            HideAttendanceControl();
            HidePayRollControl();
            HideProductInvControl();
            HideEquipInvControl();
            HideAudControl();

            ShowPOSControl();
            HideSubMenu();
        }
        private void btn_auditLogs_Click(object sender, EventArgs e)
        {
            HideEmployeesPanelControl();
            HideMainServicesPanelControl();
            HideCustomersPanelControl();
            HideAttendanceControl();
            HideProductInvControl();
            HideEquipInvControl();
            HidePOSControl();

            ShowAudControl();
            HideSubMenu();
        }
        private void btn_dispatchSched_Click(object sender, EventArgs e)
        {
            HideEmployeesPanelControl();
            HideMainServicesPanelControl();
            HideCustomersPanelControl();
            HideAttendanceControl();
            HidePayRollControl();
            HideProductInvControl();
            HideEquipInvControl();
            HideAudControl();
            HidePOSControl();

            ShowMainServicesControl();
            HideSubMenu();
        }
        private void btn_equip_inv_Click(object sender, EventArgs e)
        {
            HideEmployeesPanelControl();
            HideMainServicesPanelControl();
            HideCustomersPanelControl();
            HideAttendanceControl();
            HideProductInvControl();
            HideAudControl();
            HidePOSControl();

            ShowEquipInvControl();
            HideSubMenu();
        }
        private void btn_sales_inv_Click(object sender, EventArgs e)
        {
            HideEmployeesPanelControl();
            HideMainServicesPanelControl();
            HideCustomersPanelControl();
            HideAttendanceControl();
            HidePayRollControl();
            HideEquipInvControl();
            HideAudControl();
            HidePOSControl();

            HideSubMenu();
        }
        private void btn_attendance_sub_Click(object sender, EventArgs e)
        {
            HideEmployeesPanelControl();
            HideMainServicesPanelControl();
            HideCustomersPanelControl();
            HideProductInvControl();
            HidePayRollControl();
            HideAudControl();
            HidePOSControl();

            ShowAttendanceControl();
            HideSubMenu();
        }
        private void btn_payroll_sub_Click(object sender, EventArgs e)
        {
            HideMainServicesPanelControl();
            HideEmployeesPanelControl();
            HideAttendanceControl();
            HideCustomersPanelControl();
            HideProductInvControl();
            HideEquipInvControl();
            HideAudControl();
            HidePOSControl();

            ShowPayRollControl();
            HideSubMenu();
        }
        private void btn_prodInventory_Click(object sender, EventArgs e)
        {
            HideMainServicesPanelControl();
            HideEmployeesPanelControl();
            HideAttendanceControl();
            HidePayRollControl();
            HideAttendanceControl();
            HideEquipInvControl();
            HideAudControl();
            HidePOSControl();

            ShowProductInvControl();
            HideSubMenu();
        }     
        private void btn_manageEmp_sub_Click(object sender, EventArgs e)
        {
            HideMainServicesPanelControl();
            HideEmployeesPanelControl();
            HideCustomersPanelControl();
            HideAttendanceControl();
            HidePayRollControl();
            HideProductInvControl();
            HideEquipInvControl();
            HideAudControl();
            HidePOSControl();

            ShowEmployeesPanelControl();
            HideSubMenu();
        }
        private void btn_managecus_sub_Click(object sender, EventArgs e)
        {
            HideMainServicesPanelControl();
            HideEmployeesPanelControl();
            HideAttendanceControl();
            HidePayRollControl();
            HideProductInvControl();
            HideEquipInvControl();
            HideAudControl();
            HidePOSControl();

            ShowCustomersPanelControl();
            HideSubMenu();
        }
        #endregion

        private void time_timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = string.Format("{0:hh:mm tt}", DateTime.Now);
        }
    }
}
