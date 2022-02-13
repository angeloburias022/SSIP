using LiveCharts;
using LiveCharts.Wpf;
using SSIP.AccessControls;
using SSIP.Models;
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
        public Dashboard()
        { 
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
          
          //this.dispatchControl1.Visible = false;
          //this.mainServiceControl.BringToFront();
          this.mainServiceControl.Visible = false;

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
                MessageBox.Show("Something went wrong" + error);
            }
        }

    
    }
}
