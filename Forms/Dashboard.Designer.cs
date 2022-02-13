
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
            this.nav_panel = new System.Windows.Forms.Panel();
            this.Services_pie_chart = new System.Windows.Forms.Integration.ElementHost();
            this.pieChart1 = new LiveCharts.Wpf.PieChart();
            this.DispatchedChart = new LiveCharts.WinForms.CartesianChart();
            this.CityChart = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainServiceControl = new SSIP.UserForms.MainServiceControl();
            this.SuspendLayout();
            // 
            // nav_panel
            // 
            this.nav_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nav_panel.Location = new System.Drawing.Point(0, 0);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(200, 536);
            this.nav_panel.TabIndex = 1;
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
            // mainServiceControl
            // 
            this.mainServiceControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainServiceControl.BackgroundImage")));
            this.mainServiceControl.Location = new System.Drawing.Point(997, 16);
            this.mainServiceControl.Name = "mainServiceControl";
            this.mainServiceControl.Size = new System.Drawing.Size(139, 111);
            this.mainServiceControl.TabIndex = 15;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1158, 536);
            this.Controls.Add(this.mainServiceControl);
            this.Controls.Add(this.Services_pie_chart);
            this.Controls.Add(this.DispatchedChart);
            this.Controls.Add(this.CityChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nav_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel nav_panel;
        private System.Windows.Forms.Integration.ElementHost Services_pie_chart;
        private LiveCharts.Wpf.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart DispatchedChart;
        private LiveCharts.WinForms.CartesianChart CityChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserForms.MainServiceControl mainServiceControl;
    }
}