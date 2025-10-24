namespace SISniPIAL.forms
{
    partial class Dashboarduc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDashboard2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDashboard3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDashboard4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard4).BeginInit();
            SuspendLayout();
            // 
            // chartDashboard
            // 
            chartDashboard.BorderlineColor = Color.DimGray;
            chartArea1.Name = "ChartArea1";
            chartDashboard.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDashboard.Legends.Add(legend1);
            chartDashboard.Location = new Point(32, 35);
            chartDashboard.Name = "chartDashboard";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDashboard.Series.Add(series1);
            chartDashboard.Size = new Size(314, 220);
            chartDashboard.TabIndex = 0;
            chartDashboard.Text = "chart1";
            chartDashboard.Click += chartDashboard_Click;
            // 
            // chartDashboard2
            // 
            chartArea2.Name = "ChartArea1";
            chartDashboard2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDashboard2.Legends.Add(legend2);
            chartDashboard2.Location = new Point(375, 35);
            chartDashboard2.Name = "chartDashboard2";
            chartDashboard2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            chartDashboard2.Series.Add(series2);
            chartDashboard2.Size = new Size(314, 220);
            chartDashboard2.TabIndex = 1;
            chartDashboard2.Text = "chart1";
            // 
            // chartDashboard3
            // 
            chartArea3.Name = "ChartArea1";
            chartDashboard3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartDashboard3.Legends.Add(legend3);
            chartDashboard3.Location = new Point(32, 289);
            chartDashboard3.Name = "chartDashboard3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartDashboard3.Series.Add(series3);
            chartDashboard3.Size = new Size(314, 220);
            chartDashboard3.TabIndex = 2;
            chartDashboard3.Text = "chart1";
            // 
            // chartDashboard4
            // 
            chartArea4.Name = "ChartArea1";
            chartDashboard4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartDashboard4.Legends.Add(legend4);
            chartDashboard4.Location = new Point(375, 289);
            chartDashboard4.Name = "chartDashboard4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartDashboard4.Series.Add(series4);
            chartDashboard4.Size = new Size(314, 220);
            chartDashboard4.TabIndex = 3;
            chartDashboard4.Text = "chart1";
            // 
            // Dashboarduc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(chartDashboard4);
            Controls.Add(chartDashboard3);
            Controls.Add(chartDashboard2);
            Controls.Add(chartDashboard);
            Name = "Dashboarduc";
            Size = new Size(721, 540);
            Load += Dashboarduc_Load;
            ((System.ComponentModel.ISupportInitialize)chartDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard4;
    }
}
