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
using SISniPIAL.forms;

namespace SISniPIAL.usercontrols
{
    public partial class Teacheruc : UserControl
    {
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;

        private bool isUpdateMode = false;
        private int selectedTeacherId = -1;
        public Teacheruc(int user_id, string username)
        {
            InitializeComponent();
            _loggedInUserId = user_id;
            _loggedInUser = username;
            LoadTeachers();
            ShowTeacherCount();
        }
        private void LoadSubjects()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
            {
                string query = "SELECT SubjectId, SubjectName FROM subject ORDER BY SubjectName ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbSubjects.DataSource = dt;
                cmbSubjects.DisplayMember = "SubjectName";
                cmbSubjects.ValueMember = "SubjectId";
                cmbSubjects.SelectedIndex = -1; // Optional: no selection at start
            }
        }

        private void ShowTeacherCount()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
                {
                    conn.Open();
                    string countquery = "SELECT COUNT(*) FROM teacher WHERE Status ='Active'";
                    SqlCommand cmd = new SqlCommand(countquery, conn);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblTeacherCount.Text = $"Teacher Active: {count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Teacher Count: " + ex.Message);
            }
        }
        private void LoadTeachersWithSearch(string searchText = "")
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
            {
                string query = @"
                    SELECT TeacherId, FirstName, LastName, Email, Phone,
                           HireDate, Department, Specialization, Status
                    FROM teacher
                    WHERE 
                        FirstName LIKE @search OR
                        LastName LIKE @search OR
                        Email LIKE @search OR
                        Phone LIKE @search OR
                        CONVERT(NVARCHAR, HireDate, 23) LIKE @search OR
                        Department LIKE @search OR
                        Specialization LIKE @search OR
                        Status LIKE @search
                ";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTeacher.DataSource = dt; // your DataGridView
                }
            }
        }
        private void LoadTeachers()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
            {
                string query = "SELECT * From teacher WHERE Status = 'Active' Order by TeacherId desc";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvTeacher.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtSpecialization.Clear();
            txtStatus.Clear();
            dtpHireDate.Value = DateTime.Today;
        }

        private void Teacheruc_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtStatus.Visible = true;
            lblStatus.Visible = true;
            if (!panelTeacher.Visible)
            {
                lblAddTeacher.Text = "Add Teacher";  // 🔹 Title for Add mode
                panelTeacher.Visible = true;
                panelTeacher.BringToFront();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                errors.Add("First Name is required.");
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
                errors.Add("Last Name is required.");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                errors.Add("Email is required.");
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                errors.Add("Phone number is required.");
            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
                errors.Add("Department is required.");
            if (string.IsNullOrWhiteSpace(txtSpecialization.Text))
                errors.Add("Specialization is required.");

            // If there are any errors, show them all at once
            if (errors.Count > 0)
            {
                MessageBox.Show(
                    "Please do check the following:\n\n" + string.Join("\n", errors),
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();

                if (isUpdateMode && selectedTeacherId > 0)
                {
                    // 1. Get the linked user_id for this teacher
                    int userId = -1;
                    using (SqlCommand cmdGetUserId = new SqlCommand("SELECT userId FROM teacher WHERE TeacherId = @id", con))
                    {
                        cmdGetUserId.Parameters.AddWithValue("@id", selectedTeacherId);
                        object obj = cmdGetUserId.ExecuteScalar();
                        if (obj != null)
                            userId = Convert.ToInt32(obj);
                    }

                    // 2. Update teacher table
                    string updateQuery = @"UPDATE teacher SET  
                                            FirstName = @first_name,
                                            LastName = @last_name,
                                            Email = @email,
                                            Phone = @phone,
                                            HireDate = @hire_date,
                                            Department = @department,
                                            Specialization = @specialization,
                                            Status = @status
                                           WHERE TeacherId = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@hire_date", dtpHireDate.Value.Date);
                        cmd.Parameters.AddWithValue("@department", txtDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedTeacherId);

                        cmd.ExecuteNonQuery();
                    }

                    // 3. Update linked user_login table (if exists)
                    if (userId > 0)
                    {
                        string updateUserQuery = @"UPDATE user_login 
                                   SET username = @username, 
                                       password_hash = @password_hash
                                   WHERE userId = @user_id";
                        using (SqlCommand cmdUser = new SqlCommand(updateUserQuery, con))
                        {
                            cmdUser.Parameters.AddWithValue("@username", txtFirstName.Text.Trim());
                            cmdUser.Parameters.AddWithValue("@password_hash", txtLastName.Text.Trim());
                            cmdUser.Parameters.AddWithValue("@user_id", userId);
                            cmdUser.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Teacher updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.Logs(_loggedInUserId, "Updated Teacher", $"Admin {_loggedInUser} updated teacher {firstName} {lastName}.");

                }
                else
                {
                    // 1. Insert into user_login & get new user_id
                    string insertUserQuery = @"INSERT INTO user_login(username, password_hash, roleId) 
                                                VALUES (@username, @password_hash, @role_id); 
                                                SELECT CAST(SCOPE_IDENTITY() AS INT);
                                                ";

                    int newUserId;
                    using (SqlCommand cmdUser = new SqlCommand(insertUserQuery, con))
                    {
                        cmdUser.Parameters.AddWithValue("@username", txtFirstName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@password_hash", txtLastName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@role_id", 3); // Teacher role

                        newUserId = (int)cmdUser.ExecuteScalar();
                    }

                    // 2. Insert into teacher (teacher_id auto-generated by DB)
                    string insertTeacherQuery = @"INSERT INTO teacher 
                              (FirstName, LastName, Email, Phone, HireDate, Department, Specialization, Status, userId) 
                              VALUES (@first_name, @last_name, @email, @phone, @hire_date, @department, @specialization, @status, @user_id)";

                    using (SqlCommand cmdTeacher = new SqlCommand(insertTeacherQuery, con))
                    {
                        cmdTeacher.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@hire_date", dtpHireDate.Value.Date);
                        cmdTeacher.Parameters.AddWithValue("@department", txtDepartment.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@specialization", txtSpecialization.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmdTeacher.Parameters.AddWithValue("@user_id", newUserId);

                        cmdTeacher.ExecuteNonQuery();

                        MessageBox.Show("Teacher added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Logger.Logs(_loggedInUserId, "Added Teacher", $"Admin {_loggedInUser} added teacher {firstName} {lastName}.");
                        ShowTeacherCount();
                    }
                }

                // Reset form
                ClearFields();
                panelTeacher.Visible = false;
                isUpdateMode = false;
                selectedTeacherId = -1;

                // Reload teacher list
                LoadTeachers();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelTeacher.Visible = false;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDepartment.Clear();
            txtSpecialization.Clear();
            txtStatus.Clear();
            dtpHireDate.Value = DateTime.Now;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtStatus.Visible = false;
            lblStatus.Visible = false;

            if (dgvTeacher.SelectedRows.Count > 0)
            {
                selectedTeacherId = Convert.ToInt32(dgvTeacher.SelectedRows[0].Cells["TeacherId"].Value);

                // Load data
                txtFirstName.Text = dgvTeacher.SelectedRows[0].Cells["FirstName"].Value?.ToString();
                txtLastName.Text = dgvTeacher.SelectedRows[0].Cells["LastName"].Value?.ToString();
                txtEmail.Text = dgvTeacher.SelectedRows[0].Cells["Email"].Value?.ToString();
                txtPhone.Text = dgvTeacher.SelectedRows[0].Cells["Phone"].Value?.ToString();
                dtpHireDate.Value = Convert.ToDateTime(dgvTeacher.SelectedRows[0].Cells["HireDate"].Value);
                txtDepartment.Text = dgvTeacher.SelectedRows[0].Cells["Department"].Value?.ToString();
                txtSpecialization.Text = dgvTeacher.SelectedRows[0].Cells["Specialization"].Value?.ToString();
                txtStatus.Text = dgvTeacher.SelectedRows[0].Cells["Status"].Value?.ToString();

                // Update mode
                isUpdateMode = true;

                // 🔹 Change label text to "Update Teacher"
                lblAddTeacher.Text = "Update Teacher";

                // Show panel
                panelTeacher.Visible = true;
                panelTeacher.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a teacher to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.CurrentRow != null)
            {
                // Get first and last name from the selected row
                string firstName = dgvTeacher.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
                string lastName = dgvTeacher.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
                string teacherId = dgvTeacher.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete teacher {firstName} {lastName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
                    {
                        conn.Open();
                        string deleteQuery = "UPDATE teacher SET Status = 'Inactive' WHERE TeacherId = @id";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", teacherId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadTeachers();
                    MessageBox.Show($"Teacher {firstName} {lastName} marked as inactive successfully.");
                    Logger.Logs(_loggedInUserId, "Deactivated Teacher", $"Admin {_loggedInUser} deleted teacher {firstName} {lastName}.");
                    ShowTeacherCount();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadTeachersWithSearch(txtSearch.Text.Trim());
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher first before assigning a subject.",
                                "No Teacher Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            panelAssignSubject.Visible = true;
            panelAssignSubject.BringToFront();
            LoadSubjects();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelAssignSubject.Visible = false;
        }

        private void btnSaveAssign_Click(object sender, EventArgs e)
        {
            if (cmbSubjects.SelectedValue == null || Convert.ToInt32(cmbSubjects.SelectedValue) == 0)
            {
                MessageBox.Show("Please select a valid subject.");
                return;
            }

            if (dgvTeacher.CurrentRow == null)
            {
                MessageBox.Show("Please select a teacher first.");
                return;
            }

            int teacherId = Convert.ToInt32(dgvTeacher.CurrentRow.Cells[0].Value);
            int courseId = Convert.ToInt32(cmbSubjects.SelectedValue);

            using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
            {
                string query = @"INSERT INTO TeacherCourse (TeacherId, SubjectId) 
                         VALUES (@teacherId, @subjectId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@teacherId", teacherId);
                cmd.Parameters.AddWithValue("@subjectId", courseId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject assigned successfully!");
                    panelAssignSubject.Visible = false;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("This teacher is already enrolled in that subject.");
                    else
                        MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            panelView.BringToFront();
            panelView.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelView.Visible = false;
        }
    }
}
