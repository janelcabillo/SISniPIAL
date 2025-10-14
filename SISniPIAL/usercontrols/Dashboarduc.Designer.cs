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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDashboard2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartDashboard3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard3).BeginInit();
            SuspendLayout();
            // 
            // chartDashboard
            // 
            chartDashboard.BorderlineColor = Color.DimGray;
            chartArea4.Name = "ChartArea1";
            chartDashboard.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartDashboard.Legends.Add(legend4);
            chartDashboard.Location = new Point(32, 35);
            chartDashboard.Name = "chartDashboard";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartDashboard.Series.Add(series4);
            chartDashboard.Size = new Size(314, 220);
            chartDashboard.TabIndex = 0;
            chartDashboard.Text = "chart1";
            chartDashboard.Click += chartDashboard_Click;
            // 
            // chartDashboard2
            // 
            chartArea5.Name = "ChartArea1";
            chartDashboard2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chartDashboard2.Legends.Add(legend5);
            chartDashboard2.Location = new Point(375, 35);
            chartDashboard2.Name = "chartDashboard2";
            chartDashboard2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            chartDashboard2.Series.Add(series5);
            chartDashboard2.Size = new Size(314, 220);
            chartDashboard2.TabIndex = 1;
            chartDashboard2.Text = "chart1";
            // 
            // chartDashboard3
            // 
            chartArea6.Name = "ChartArea1";
            chartDashboard3.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chartDashboard3.Legends.Add(legend6);
            chartDashboard3.Location = new Point(32, 289);
            chartDashboard3.Name = "chartDashboard3";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartDashboard3.Series.Add(series6);
            chartDashboard3.Size = new Size(314, 220);
            chartDashboard3.TabIndex = 2;
            chartDashboard3.Text = "chart1";
            // 
            // Dashboarduc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(chartDashboard3);
            Controls.Add(chartDashboard2);
            Controls.Add(chartDashboard);
            Name = "Dashboarduc";
            Size = new Size(721, 540);
            Load += Dashboarduc_Load;
            ((System.ComponentModel.ISupportInitialize)chartDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDashboard3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard3;
    }
}
