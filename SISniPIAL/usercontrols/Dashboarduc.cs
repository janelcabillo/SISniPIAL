using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace SISniPIAL.forms
{
    public partial class Dashboarduc : UserControl
    {
        private int animateStep = 0;
        private int studentCountFinal;
        private int teacherCountFinal;
        private System.Windows.Forms.Timer chartTimer;
        public Dashboarduc()
        {
            InitializeComponent();
            //this.Load += new System.EventHandler(this.Dashboarduc_Load);
        }

        private void StartChartAnimation()
        {
            if (chartTimer != null)
            {
                chartTimer.Stop();
                chartTimer.Tick -= AnimateCharts;
                chartTimer.Dispose();
                chartTimer = null;
            }

            chartTimer = new System.Windows.Forms.Timer();
            chartTimer.Interval = 15;
            chartTimer.Tick += AnimateCharts;
            animateStep = 0;
            chartTimer.Start();
        }

        private void AnimateCharts(object sender, EventArgs e)
        {
            if (chartDashboard.Series.Count == 0 || chartDashboard3.Series.Count < 2)
            {
                chartTimer?.Stop();
                return;
            }

            // Determine total steps: don't exceed the final count
            int totalSteps = Math.Max(studentCountFinal, teacherCountFinal);

            if (totalSteps == 0) totalSteps = 1; // prevent division by zero

            // Ease-out factor (cubic)
            double t = (double)animateStep / totalSteps;
            double ease = 1 - Math.Pow(1 - t, 3);

            // Calculate current values
            double displayStudent = Math.Round(studentCountFinal * ease);
            double displayTeacher = Math.Round(teacherCountFinal * ease);

            // Doughnut chart
            chartDashboard.Series[0].Points[0].YValues[0] = displayStudent;
            chartDashboard.Series[0].Points[1].YValues[0] = displayTeacher;

            // Pie chart
            chartDashboard2.Series[0].Points[0].YValues[0] = displayStudent;
            chartDashboard2.Series[0].Points[1].YValues[0] = displayTeacher;

            // Column chart
            chartDashboard3.Series["Students"].Points[0].YValues[0] = displayStudent;
            chartDashboard3.Series["Teachers"].Points[0].YValues[0] = displayTeacher;

            chartDashboard.Invalidate();
            chartDashboard2.Invalidate();
            chartDashboard3.Invalidate();

            animateStep++;

            // Stop when done
            if (animateStep > totalSteps)
            {
                chartDashboard.Series[0].Points[0].YValues[0] = studentCountFinal;
                chartDashboard.Series[0].Points[1].YValues[0] = teacherCountFinal;

                chartDashboard2.Series[0].Points[0].YValues[0] = studentCountFinal;
                chartDashboard2.Series[0].Points[1].YValues[0] = teacherCountFinal;

                chartDashboard3.Series["Students"].Points[0].YValues[0] = studentCountFinal;
                chartDashboard3.Series["Teachers"].Points[0].YValues[0] = teacherCountFinal;

                chartTimer.Stop();
            }
        }


        private void chartDashboard_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
        public void LoadChart()
        {
            animateStep = 0;
            int StudentCount = 0;
            int TeacherCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConnection.conString))
                {
                    connection.Open();

                    SqlCommand cmdStudent = new SqlCommand("SELECT COUNT(*) FROM student", connection);
                    StudentCount = (int)cmdStudent.ExecuteScalar();

                    SqlCommand cmdTeacher = new SqlCommand("SELECT COUNT(*) FROM teacher", connection);
                    TeacherCount = (int)cmdTeacher.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data" + ex.Message);
                StudentCount = 0;
                TeacherCount = 0;
            }
            studentCountFinal = StudentCount;
            teacherCountFinal = TeacherCount;

            //doughnut chart
            chartDashboard.Series.Clear();
            Series doughnutSeries = new Series("Counts");
            doughnutSeries.ChartType = SeriesChartType.Doughnut;
            doughnutSeries.IsValueShownAsLabel = true;

            doughnutSeries.Label = "#VALX: #VAL (#PERCENT{P0})";

            doughnutSeries.Points.AddXY("Students", StudentCount);
            doughnutSeries.Points.AddXY("Teachers", TeacherCount);
            chartDashboard.Series.Add(doughnutSeries);

            //pie chart
            chartDashboard2.Series.Clear();
            Series pieSeries = new Series("Counts");
            pieSeries.ChartType = SeriesChartType.Pie;
            pieSeries.IsValueShownAsLabel = true;
            pieSeries.Label = "#VALX: #VAL (#PERCENT{P0})";

            pieSeries.Points.AddXY("Students", StudentCount);
            pieSeries.Points.AddXY("Teachers", TeacherCount);
            chartDashboard2.Series.Add(pieSeries);

            //column chart
            chartDashboard3.Series.Clear();

            // Common X-axis label
            string xLabel = "People";

            // Students series
            Series studentSeries = new Series("Students");
            studentSeries.ChartType = SeriesChartType.Column;
            studentSeries.Points.AddXY(xLabel, StudentCount);
            studentSeries.Color = Color.SteelBlue;
            studentSeries.IsValueShownAsLabel = true;

            // Teachers series
            Series teacherSeries = new Series("Teachers");
            teacherSeries.ChartType = SeriesChartType.Column;
            teacherSeries.Points.AddXY(xLabel, TeacherCount);
            teacherSeries.Color = Color.Orange;
            teacherSeries.IsValueShownAsLabel = true;

            // Add series
            chartDashboard3.Series.Add(studentSeries);
            chartDashboard3.Series.Add(teacherSeries);

            // X-axis settings
            chartDashboard3.ChartAreas[0].AxisX.Interval = 1;


            StartChartAnimation();
        }

        private void Dashboarduc_Load(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
