﻿namespace SISniPIAL.forms
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
            chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartDashboard).BeginInit();
            SuspendLayout();
            // 
            // chartDashboard
            // 
            chartDashboard.BorderlineColor = Color.DimGray;
            chartArea1.Name = "ChartArea1";
            chartDashboard.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDashboard.Legends.Add(legend1);
            chartDashboard.Location = new Point(59, 38);
            chartDashboard.Name = "chartDashboard";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDashboard.Series.Add(series1);
            chartDashboard.Size = new Size(607, 467);
            chartDashboard.TabIndex = 0;
            chartDashboard.Text = "chart1";
            chartDashboard.Click += chartDashboard_Click;
            // 
            // Dashboarduc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(chartDashboard);
            Name = "Dashboarduc";
            Size = new Size(721, 540);
            Load += Dashboarduc_Load;
            ((System.ComponentModel.ISupportInitialize)chartDashboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
    }
}
