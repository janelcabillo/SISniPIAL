using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private bool TeacherExists(int teacherId)
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM teacher WHERE TeacherId = @id AND Status = 'Active'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", teacherId);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private void LoadStudentsForTeacherSubject(DataGridView dgv, int teacherId, int subjectId)
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();
                string query = @"
            SELECT 
                s.StudentId,
                s.FirstName + ' ' + s.LastName AS StudentName
            FROM StudentCourse sc
            INNER JOIN student s ON sc.StudentId = s.StudentId
            WHERE sc.SubjectId = @subject_id 
              AND sc.TeacherId = @teacher_id
              AND s.Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    cmd.Parameters.AddWithValue("@teacher_id", teacherId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.Columns.Clear(); // ✅ Clear any old columns
                    dgv.DataSource = dt;
                    dgv.ReadOnly = true;
                    dgv.AllowUserToAddRows = false;

                    // ✅ Clean column headers
                    dgv.Columns["StudentId"].HeaderText = "Student ID";
                    dgv.Columns["StudentName"].HeaderText = "Student Name";
                }
            }
        }


        private void LoadSubjectDetails(RichTextBox rtb, int subjectId)
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();
                string query = "SELECT * FROM subject WHERE SubjectId = @subject_id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rtb.Clear();
                            rtb.ReadOnly = true;

                            AppendBold(rtb, "Subject Code: ");
                            rtb.AppendText($"{reader["SubjectCode"]}\n");

                            AppendBold(rtb, "Subject Name: ");
                            rtb.AppendText($"{reader["SubjectName"]}\n");

                            AppendBold(rtb, "Units: ");
                            rtb.AppendText($"{reader["Units"]}\n");
                        }
                        else
                        {
                            rtb.Clear();
                            rtb.AppendText("No subject found for the selected ID.");
                        }
                    }
                }
            }
        }

        // Helper for bold text in RichTextBox
        private void AppendBold(RichTextBox rtb, string text)
        {
            rtb.SelectionFont = new Font(rtb.Font, FontStyle.Bold);
            rtb.AppendText(text);
            rtb.SelectionFont = new Font(rtb.Font, FontStyle.Regular);
        }

        public void LoadSubject()
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                string query = "SELECT * FROM subject WHERE Status = 'Active' ORDER BY SubjectId DESC";
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
            WHERE Status = 'Active' AND 
                  (SubjectCode LIKE @search OR
                   SubjectName LIKE @search OR
                   CAST(Units AS VARCHAR) LIKE @search)
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
                    string countquery = "SELECT COUNT(*) FROM subject WHERE Status = 'Active'";
                    SqlCommand cmd = new SqlCommand(countquery, conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblSubjectCount.Text = $"Subjects Active: {count}";
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
            if (dgvSubject.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int subjectId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectId"].Value);
            string subjectName = dgvSubject.SelectedRows[0].Cells["SubjectName"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete subject \"{subjectName}\"?\nThis will mark it inactive and remove assignments.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                {
                    con.Open();
                    using (SqlTransaction tran = con.BeginTransaction())
                    {
                        try
                        {
                            // 1) mark subject inactive (soft delete)
                            using (SqlCommand cmd = new SqlCommand("UPDATE subject SET Status = 'Inactive' WHERE SubjectId = @id", con, tran))
                            {
                                cmd.Parameters.AddWithValue("@id", subjectId);
                                cmd.ExecuteNonQuery();
                            }

                            // 2) remove teacher assignments for that subject
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM TeacherCourse WHERE SubjectId = @id", con, tran))
                            {
                                cmd.Parameters.AddWithValue("@id", subjectId);
                                cmd.ExecuteNonQuery();
                            }

                            // 3) remove student enrollments for that subject (or set TeacherId = NULL if you prefer)
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM StudentCourse WHERE SubjectId = @id", con, tran))
                            {
                                cmd.Parameters.AddWithValue("@id", subjectId);
                                cmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Subject deleted (marked inactive) successfully!");
                Logger.Logs(_loggedInUserId, "Delete Subject", $"User {_loggedInUser} marked subject {subjectName} inactive.");
                LoadSubject();
                ShowSubjectCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting subject: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSubjectsWithSearch(txtSearch.Text.Trim());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                int subjectId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectId"].Value);

                LoadSubjectDetails(rtbDetails, subjectId);
                LoadAssignedTeachers(dgvInfo, subjectId);

                panelView.BringToFront();
                panelView.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a subject to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvInfo.Columns[e.ColumnIndex].Name == "ViewStudents")
            {
                try
                {
                    int teacherId = Convert.ToInt32(dgvInfo.Rows[e.RowIndex].Cells["TeacherId"].Value);
                    int subjectId = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["SubjectId"].Value);

                    if (!TeacherExists(teacherId))
                    {
                        MessageBox.Show("This teacher has been deleted. No students to show.",
                            "Teacher Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAssignedTeachers(dgvInfo, subjectId);
                        return;
                    }

                    LoadStudentsForTeacherSubject(dgvStudents, teacherId, subjectId);

                    panelListStudents.BringToFront();
                    panelListStudents.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadAssignedTeachers(DataGridView dgvInfo, int subjectId)
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();
                string query = @"
            SELECT 
                t.TeacherId,
                t.FirstName + ' ' + t.LastName AS TeacherName
            FROM TeacherCourse tc
            INNER JOIN teacher t ON tc.TeacherId = t.TeacherId
            WHERE tc.SubjectId = @subject_id AND t.Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@subject_id", subjectId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvInfo.Columns.Clear(); // ✅ Clear old columns
                    dgvInfo.DataSource = dt;
                    dgvInfo.ReadOnly = true;
                    dgvInfo.AllowUserToAddRows = false;

                    // ✅ Add "View Students" button column
                    DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn
                    {
                        HeaderText = "Students",
                        Text = "View Students",
                        Name = "ViewStudents",
                        UseColumnTextForButtonValue = true
                    };
                    dgvInfo.Columns.Add(viewBtn);

                    // ✅ Optional: Adjust display
                    dgvInfo.Columns["TeacherId"].Visible = false; // Hide internal ID
                    dgvInfo.Columns["TeacherName"].HeaderText = "Teacher Name";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelView.Visible = false;
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            panelListStudents.Visible = false;
        }
    }
}
