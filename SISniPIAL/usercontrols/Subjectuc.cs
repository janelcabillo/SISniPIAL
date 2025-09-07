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
        }
        public void LoadSubject()
        {
            string query = "SELECT SubjectCode, SubjectName, Units FROM subject";

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
                lblAddSubject.Text = "Add Student";  // title for add mode
                panelSubject.Visible = true;
                panelSubject.BringToFront();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                // get selected student's ID
                selectedSubjectId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectId"].Value);

                // load data into form fields
                txtSubjectCode.Text = dgvSubject.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
                txtSubjectName.Text = dgvSubject.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                txtUnits.Text = dgvSubject.SelectedRows[0].Cells["Units"].Value.ToString();

                // this enable update mode
                isUpdateMode = true;

                // change label text to "Update Student"
                lblAddSubject.Text = "Update Student";

                // shows the panel
                panelSubject.Visible = true;
                panelSubject.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
