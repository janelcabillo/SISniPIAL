using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SISniPIAL.forms
{
    public partial class Dashboarduc : UserControl
    {
        private int animateStep = 0;
        private int studentCountFinal;
        private int teacherCountFinal;
        private int subjectCountFinal;
        private System.Windows.Forms.Timer chartTimer;

        public Dashboarduc()
        {
            InitializeComponent();
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
            if (chartDashboard.Series.Count == 0 ||
                chartDashboard3.Series.Count < 2 ||
                chartDashboard4.Series.Count == 0)
            {
                chartTimer?.Stop();
                return;
            }

            int totalSteps = Math.Max(Math.Max(studentCountFinal, teacherCountFinal), subjectCountFinal);
            if (totalSteps == 0) totalSteps = 1;

            double t = (double)animateStep / totalSteps;
            double ease = 1 - Math.Pow(1 - t, 3);

            double displayStudent = Math.Round(studentCountFinal * ease);
            double displayTeacher = Math.Round(teacherCountFinal * ease);
            double displaySubject = Math.Round(subjectCountFinal * ease);

            // Doughnut chart
            chartDashboard.Series[0].Points[0].YValues[0] = displayStudent;
            chartDashboard.Series[0].Points[1].YValues[0] = displayTeacher;

            // Pie chart
            chartDashboard2.Series[0].Points[0].YValues[0] = displayStudent;
            chartDashboard2.Series[0].Points[1].YValues[0] = displayTeacher;

            // Column chart (Students vs Teachers)
            chartDashboard3.Series["Students"].Points[0].YValues[0] = displayStudent;
            chartDashboard3.Series["Teachers"].Points[0].YValues[0] = displayTeacher;

            // Column chart (Subjects)
            chartDashboard4.Series["Subjects"].Points[0].YValues[0] = displaySubject;

            chartDashboard.Invalidate();
            chartDashboard2.Invalidate();
            chartDashboard3.Invalidate();
            chartDashboard4.Invalidate();

            animateStep++;

            if (animateStep > totalSteps)
            {
                chartDashboard.Series[0].Points[0].YValues[0] = studentCountFinal;
                chartDashboard.Series[0].Points[1].YValues[0] = teacherCountFinal;

                chartDashboard2.Series[0].Points[0].YValues[0] = studentCountFinal;
                chartDashboard2.Series[0].Points[1].YValues[0] = teacherCountFinal;

                chartDashboard3.Series["Students"].Points[0].YValues[0] = studentCountFinal;
                chartDashboard3.Series["Teachers"].Points[0].YValues[0] = teacherCountFinal;

                chartDashboard4.Series["Subjects"].Points[0].YValues[0] = subjectCountFinal;

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
            int SubjectCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DatabaseConnection.conString))
                {
                    connection.Open();

                    SqlCommand cmdStudent = new SqlCommand("SELECT COUNT(*) FROM student WHERE Status = 'Active'", connection);
                    StudentCount = (int)cmdStudent.ExecuteScalar();

                    SqlCommand cmdTeacher = new SqlCommand("SELECT COUNT(*) FROM teacher WHERE Status = 'Active'", connection);
                    TeacherCount = (int)cmdTeacher.ExecuteScalar();

                    SqlCommand cmdSubject = new SqlCommand("SELECT COUNT(*) FROM subject WHERE Status = 'Active'", connection);
                    SubjectCount = (int)cmdSubject.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message);
                StudentCount = 0;
                TeacherCount = 0;
                SubjectCount = 0;
            }

            studentCountFinal = StudentCount;
            teacherCountFinal = TeacherCount;
            subjectCountFinal = SubjectCount;

            // Doughnut chart (Students vs Teachers)
            chartDashboard.Series.Clear();
            Series doughnutSeries = new Series("Counts")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true,
                Label = "#VALX: #VAL (#PERCENT{P0})"
            };
            doughnutSeries.Points.AddXY("Students", StudentCount);
            doughnutSeries.Points.AddXY("Teachers", TeacherCount);
            chartDashboard.Series.Add(doughnutSeries);

            // Pie chart (Students vs Teachers)
            chartDashboard2.Series.Clear();
            Series pieSeries = new Series("Counts")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#VALX: #VAL (#PERCENT{P0})"
            };
            pieSeries.Points.AddXY("Students", StudentCount);
            pieSeries.Points.AddXY("Teachers", TeacherCount);
            chartDashboard2.Series.Add(pieSeries);

            // Column chart (Students vs Teachers)
            chartDashboard3.Series.Clear();
            Series studentSeries = new Series("Students")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue,
                IsValueShownAsLabel = true
            };
            studentSeries.Points.AddXY("People", StudentCount);

            Series teacherSeries = new Series("Teachers")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Orange,
                IsValueShownAsLabel = true
            };
            teacherSeries.Points.AddXY("People", TeacherCount);

            chartDashboard3.Series.Add(studentSeries);
            chartDashboard3.Series.Add(teacherSeries);
            chartDashboard3.ChartAreas[0].AxisX.Interval = 1;

            // Column chart for Active Subjects
            chartDashboard4.Series.Clear();
            Series subjectSeries = new Series("Subjects")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.MediumSeaGreen,
                IsValueShownAsLabel = true
            };
            subjectSeries.Points.AddXY("Subjects", SubjectCount);
            chartDashboard4.Series.Add(subjectSeries);
            chartDashboard4.ChartAreas[0].AxisX.Interval = 1;

            StartChartAnimation();
        }

        private void Dashboarduc_Load(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
