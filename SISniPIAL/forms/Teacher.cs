using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;
using SISniPIAL.forms;

namespace SISniPIAL
{
    public partial class Teacher : Form
    {
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;
        private string userTeacher;

        private int _teacherId;
        public Teacher(int userId, string username, int teacherId)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            _loggedInUser = username;
            this.userTeacher = username;
            _teacherId = teacherId;

            LoadTeacherInfo();
            LoadAssignedSubjectsAndStudents();
        }
        private void LoadTeacherInfo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                {
                    string query = @"
                        SELECT FirstName, LastName, Email, Phone, HireDate, Department, Specialization, Status 
                        FROM teacher 
                        WHERE TeacherId = @teacherId";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@teacherId", _teacherId);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        rtbTeacherInfo.Text =
                            $"👤 Name: {reader["FirstName"]} {reader["LastName"]}\n" +
                            $"📧 Email: {reader["Email"]}\n" +
                            $"📱 Phone: {reader["Phone"]}\n" +
                            $"🏫 Department: {reader["Department"]}\n" +
                            $"📘 Specialization: {reader["Specialization"]}\n" +
                            $"📅 Hire Date: {Convert.ToDateTime(reader["HireDate"]).ToShortDateString()}\n" +
                            $"🟢 Status: {reader["Status"]}";
                    }
                    else
                    {
                        rtbTeacherInfo.Text = "⚠️ No teacher info found.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teacher info:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAssignedSubjectsAndStudents()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                {
                    string query = @"
                        SELECT DISTINCT 
                            s.SubjectId,
                            s.SubjectName AS [Subject]
                        FROM TeacherCourse tc
                        INNER JOIN subject s ON tc.SubjectId = s.SubjectId
                        WHERE tc.TeacherId = @teacherId
                        ORDER BY s.SubjectName";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@teacherId", _teacherId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvTeacherSub.DataSource = dt;

                    // Add button column once
                    if (!dgvTeacherSub.Columns.Contains("btnViewStudents"))
                    {
                        DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn
                        {
                            Name = "btnViewStudents",
                            HeaderText = "Action",
                            Text = "View Students",
                            UseColumnTextForButtonValue = true,
                            Width = 120
                        };
                        dgvTeacherSub.Columns.Add(viewBtn);
                    }

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No assigned subjects found.",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentsForSubject(int subjectId)
        {
            lbListStudents.Items.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                {
                    string query = @"
                        SELECT st.FirstName + ' ' + st.LastName AS StudentName
                        FROM StudentCourse sc
                        INNER JOIN student st ON sc.StudentId = st.StudentId
                        WHERE sc.SubjectId = @subjectId AND sc.TeacherId = @teacherId
                        ORDER BY st.LastName, st.FirstName";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@subjectId", subjectId);
                    cmd.Parameters.AddWithValue("@teacherId", _teacherId);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lbListStudents.Items.Add(reader["StudentName"].ToString());
                    }

                    if (lbListStudents.Items.Count == 0)
                    {
                        lbListStudents.Items.Add("No students assigned to this subject.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Teacher_Load(object sender, EventArgs e)
        {
            lblWelcomeTeacher.Text = $"Welcome {userTeacher}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Logger.Logs(_loggedInUserId, "Logout", $"User {_loggedInUser} logged out.");

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void dgvTeacherSub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTeacherSub.Columns[e.ColumnIndex].Name == "btnViewStudents")
            {
                int subjectId = Convert.ToInt32(dgvTeacherSub.Rows[e.RowIndex].Cells["SubjectId"].Value);
                string subjectName = dgvTeacherSub.Rows[e.RowIndex].Cells["Subject"].Value.ToString();

                // Show listbox + close button
                lbListStudents.Visible = true;
                btnCloseList.Visible = true;

                // Make sure the Close button is on top of the ListBox
                btnCloseList.BringToFront();

                lbListStudents.Items.Clear();
                lbListStudents.Items.Add($"👩‍🎓 Students enrolled in {subjectName}:");
                lbListStudents.Items.Add("--------------------------------------");

                LoadStudentsForSubject(subjectId);
            }
        }

        private void btnCloseList_Click(object sender, EventArgs e)
        {
            lbListStudents.Visible = false;
            btnCloseList.Visible = false;
        }
    }
}
