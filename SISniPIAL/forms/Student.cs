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

namespace SISniPIAL
{
    public partial class Student : Form
    {
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;
        private string userStudent;

        private int _studentId;
        public Student(int userId, string username, int studentId)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            _loggedInUser = username;
            this.userStudent = username;
            _studentId = studentId;

            LoadStudentInfo();
            LoadAssignedSubjects();
        }
        private void LoadStudentInfo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                {
                    string query = @"
                        SELECT FirstName, LastName, DateOfBirth, Gender, Email, Phone, Address, EnrollmentDate, Status
                        FROM student
                        WHERE StudentId = @StudentId";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@StudentId", _studentId);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        rtbStudentInfo.Text =
                            $"👤 Name: {reader["FirstName"]} {reader["LastName"]}\n" +
                            $"📅 DOB: {Convert.ToDateTime(reader["DateOfBirth"]).ToShortDateString()}\n" +
                            $"🚻 Gender: {reader["Gender"]}\n" +
                            $"📧 Email: {reader["Email"]}\n" +
                            $"📞 Phone: {reader["Phone"]}\n" +
                            $"🏠 Address: {reader["Address"]}\n" +
                            $"🗓️ Enrolled: {Convert.ToDateTime(reader["EnrollmentDate"]).ToShortDateString()}\n" +
                            $"📌 Status: {reader["Status"]}";
                    }
                    else
                    {
                        rtbStudentInfo.Text = "⚠️ Student record not found.";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading student info:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAssignedSubjects()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
                {
                    string query = @"
                        SELECT 
                            s.SubjectCode AS [Subject Code],
                            s.SubjectName AS [Subject Name],
                            s.Units AS [Units],
                            ISNULL(t.FirstName + ' ' + t.LastName, 'Not Assigned') AS [Teacher]
                        FROM StudentCourse sc
                        INNER JOIN subject s ON sc.SubjectId = s.SubjectId
                        LEFT JOIN teacher t ON sc.TeacherId = t.TeacherId
                        WHERE sc.StudentId = @StudentId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@StudentId", _studentId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStudentSub.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            lblWelcomeStudent.Text = $"Welcome {userStudent}!";
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
    }
}
