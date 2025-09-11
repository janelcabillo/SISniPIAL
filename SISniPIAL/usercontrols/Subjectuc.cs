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
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;

        private bool isUpdateMode = false;
        private int selectedSubjectId = -1;
        public Subjectuc(int user_id, string username)
        {
            InitializeComponent();
            _loggedInUserId = user_id;
            _loggedInUser = username;
            LoadSubject();
            ShowSubjectCount();
        }
        public void LoadSubject()
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                string query = "SELECT * FROM subject ORDER BY SubjectId DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSubject.DataSource = dt;
            }
        }
        private void LoadSubjectsWithSearch(string searchText = "")
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                string query = @"
                    SELECT * FROM subject
                    WHERE 
                        SubjectCode LIKE @search OR
                        SubjectName LIKE @search OR
                        CAST(Units AS VARCHAR) LIKE @search
                    ORDER BY SubjectId DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSubject.DataSource = dt;
                }
            }
        }
        private void ClearFields()
        {
            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            nudUnits.Value = nudUnits.Minimum;
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


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            isUpdateMode = false;
            selectedSubjectId = -1;

            lblAddSubject.Text = "Add Subject";
            panelSubject.Visible = true;
            panelSubject.BringToFront();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtSubjectCode.Text.Trim();
            string name = txtSubjectName.Text.Trim();
            int units = (int)nudUnits.Value;

            List<string> errors = new List<string>();
            if (string.IsNullOrEmpty(code)) errors.Add("Subject Code is required.");
            if (string.IsNullOrEmpty(name)) errors.Add("Subject Name is required.");
            if (units <= 0) errors.Add("Units must be greater than zero.");

            if (errors.Count > 0)
            {
                MessageBox.Show("Please fix the following:\n\n" + string.Join("\n", errors), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();

                if (isUpdateMode && selectedSubjectId > 0)
                {
                    string updateQuery = @"UPDATE subject SET SubjectCode=@code, SubjectName=@name, Units=@units WHERE SubjectId=@id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@units", units);
                        cmd.Parameters.AddWithValue("@id", selectedSubjectId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Subject updated successfully!");
                    Logger.Logs(_loggedInUserId, "Update Subject", $"User {_loggedInUser} updated subject {code} - {name}.");
                }
                else
                {
                    string insertQuery = @"INSERT INTO subject (SubjectCode, SubjectName, Units) VALUES (@code, @name, @units)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@units", units);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Subject added successfully!");
                    Logger.Logs(_loggedInUserId, "Add Subject", $"User {_loggedInUser} added subject {code} - {name}.");
                    ShowSubjectCount();
                }
            }

            ClearFields();
            panelSubject.Visible = false;
            isUpdateMode = false;
            selectedSubjectId = -1;
            LoadSubject();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelSubject.Visible = false;

            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            nudUnits.Value = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                selectedSubjectId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectId"].Value);
                txtSubjectCode.Text = dgvSubject.SelectedRows[0].Cells["SubjectCode"].Value.ToString();
                txtSubjectName.Text = dgvSubject.SelectedRows[0].Cells["SubjectName"].Value.ToString();
                nudUnits.Value = Convert.ToDecimal(dgvSubject.SelectedRows[0].Cells["Units"].Value);

                isUpdateMode = true;
                lblAddSubject.Text = "Update Subject";
                panelSubject.Visible = true;
                panelSubject.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a subject to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                int subjectId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectId"].Value);
                string subjectName = dgvSubject.SelectedRows[0].Cells["SubjectName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete subject \"{subjectName}\"?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                    {
                        con.Open();
                        string deleteQuery = "DELETE FROM subject WHERE SubjectId = @id";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@id", subjectId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Subject deleted successfully!");
                    Logger.Logs(_loggedInUserId, "Delete Subject", $"User {_loggedInUser} deleted subject {subjectName}.");
                    LoadSubject();
                    ShowSubjectCount();
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSubjectsWithSearch(txtSearch.Text.Trim());
        }
    }
}
