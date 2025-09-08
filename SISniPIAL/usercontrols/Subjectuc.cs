using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SISniPIAL.forms
{
    public partial class Subjectuc : UserControl
    {
        private bool isUpdateMode = false;
        private int selectedSubjectId = -1;
        public Subjectuc()
        {
            InitializeComponent();
        }

        private void Subjectuc_Load(object sender, EventArgs e)
        {
            LoadSubject();
            ShowSubjectCount();
        }
        private void ShowSubjectCount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
                {
                    conn.Open();
                    string countquery = "SELECT COUNT(*) FROM subject";
                    SqlCommand cmd = new SqlCommand(countquery, conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblSubjectCount.Text = $"Subject Active: {count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Subject Count: " + ex.Message);
            }
        }
        public void LoadSubject()
        {
            string query = "SELECT SubjectId, SubjectCode, SubjectName, Units FROM subject order by SubjectId desc";

            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    dgvSubject.DataSource = dt;

                    // Optional: Auto-size columns nicely
                    dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!panelSubject.Visible)
            {
                lblAddSubject.Text = "Add Subject";  // title for add mode
                panelSubject.Visible = true;
                panelSubject.BringToFront();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                // Get selected SubjectId
                selectedSubjectId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectId"].Value);

                // Load data into form fields
                txtSubjectCode.Text = dgvSubject.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
                txtSubjectName.Text = dgvSubject.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                txtUnits.Text = dgvSubject.SelectedRows[0].Cells["Units"].Value.ToString();

                // Enable update mode
                isUpdateMode = true;

                // Change label text to "Update Subject"
                lblAddSubject.Text = "Update Subject";

                // Show the panel
                panelSubject.Visible = true;
                panelSubject.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a subject to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelSubject.Visible = false;

            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            txtUnits.Clear();
        }
    }
}
