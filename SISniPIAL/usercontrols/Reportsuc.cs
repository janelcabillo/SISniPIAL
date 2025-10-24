using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SISniPIAL.forms
{
    public partial class Reportsuc : UserControl
    {
        private ReportViewer viewreport;
        public Reportsuc()
        {
            InitializeComponent();
            viewreport = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local,
                RightToLeft = RightToLeft.No
            };
            panelReport.Controls.Add(viewreport);

            // Load Student report by default when control loads
            this.Load += (s, e) => LoadReport("Student");
            SetActiveButton(btnStudent);
        }
        private void SetActiveButton(Button activeButton)
        {
            btnStudent.BackColor = SystemColors.Control;
            btnTeacher.BackColor = SystemColors.Control;

            activeButton.BackColor = Color.DarkGray;
            this.ActiveControl = null;
        }
        private void LoadReport(string reportType)
        {
            try
            {
                string reportFile = "";
                string datasetName = "";
                string query = "";

                // 🔹 Select the correct report file, dataset, and query
                switch (reportType)
                {
                    case "Student":
                        reportFile = "StudentReport.rdlc";
                        datasetName = "StudentDataSet";
                        query = "SELECT * FROM student WHERE Status = 'Active'";
                        break;

                    case "Teacher":
                        reportFile = "TeacherReport.rdlc";
                        datasetName = "TeacherDataSet";
                        query = "SELECT * FROM teacher WHERE Status = 'Active'";
                        break;

                    case "Subject":
                        reportFile = "SubjectReport.rdlc";
                        datasetName = "SubjectDataSet";
                        query = "SELECT * FROM subject WHERE Status = 'Active'";
                        break;

                    default:
                        MessageBox.Show("Invalid report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // 🔹 Verify report file exists
                string reportPath = Path.Combine(AppContext.BaseDirectory, "ReportFiles", reportFile);
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"Report file not found:\n{reportPath}",
                        "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 🔹 Configure ReportViewer
                viewreport.LocalReport.ReportPath = reportPath;

                using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"No data found for {reportType.ToLower()} report.",
                            "Empty Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 🔹 Bind data to report
                    ReportDataSource rds = new ReportDataSource(datasetName, dt);
                    viewreport.LocalReport.DataSources.Clear();
                    viewreport.LocalReport.DataSources.Add(rds);
                }

                viewreport.SetDisplayMode(DisplayMode.PrintLayout);
                viewreport.ZoomMode = ZoomMode.PageWidth;
                viewreport.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading {reportType} report:\n{ex.Message}",
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Reportsuc_Load(object sender, EventArgs e)
        {
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoadReport("Student");
            SetActiveButton(btnStudent);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            LoadReport("Teacher");
            SetActiveButton(btnTeacher);
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            LoadReport("Subject");
            SetActiveButton(btnSubject);
        }
    }
}
