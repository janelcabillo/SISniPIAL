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
        public Dashboarduc()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Dashboarduc_Load);
        }

        private void chartDashboard_Click(object sender, EventArgs e)
        {
            LoadChart();
        }
        public void LoadChart()
        {
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
            }
            chartDashboard.Series.Clear();

            Series doughnutSeries = new Series("Counts");
            doughnutSeries.ChartType = SeriesChartType.Doughnut;
            doughnutSeries.IsValueShownAsLabel = true;
            doughnutSeries.Points.AddXY("Students", StudentCount);
            doughnutSeries.Points.AddXY("Teachers", TeacherCount);
            chartDashboard.Series.Add(doughnutSeries);
        }

        private void Dashboarduc_Load(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
