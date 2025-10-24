using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using SISniPIAL.forms;
namespace SISniPIAL
{
    public partial class LoginForm : Form
    {
        private ForgotPassuc forgotpassUC;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //validate inputs first
            List<string> missingFields = new List<string>();
            if (string.IsNullOrEmpty(username)) missingFields.Add("Username");
            if (string.IsNullOrEmpty(password)) missingFields.Add("Password");

            if (missingFields.Count > 0)
            {
                string message = "Please enter the following required fields:\n- " + string.Join("\n- ", missingFields);
                MessageBox.Show(message);
                return;
            }

            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                try
                {
                    con.Open();

                    //get user info including failed attempts and lockout status
                    string query = @"SELECT userId, roleId, password_hash, failed_attempts, lockout_until
                                    FROM user_login WHERE username = @username";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int user_id = Convert.ToInt32(reader["userId"]);
                        int role_id = Convert.ToInt32(reader["roleId"]);
                        string dbPassword = reader["password_hash"].ToString();
                        int failedAttempts = reader["failed_attempts"] == DBNull.Value
                            ? 0
                            : Convert.ToInt32(reader["failed_attempts"]);
                        DateTime? lockoutUntil = reader["lockout_until"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["lockout_until"]);

                        reader.Close();

                        //check if accouunt is locked
                        if (lockoutUntil.HasValue && lockoutUntil > DateTime.Now)
                        {
                            MessageBox.Show($"Account locked. Do try again at {lockoutUntil}");
                            return;
                        }

                        //check passwords
                        if (dbPassword == password)
                        {
                            //resets failed attempts
                            string resetQuery = "UPDATE user_login SET failed_attempts = 0, lockout_until = NULL WHERE userId = @id";
                            SqlCommand resetCmd = new SqlCommand(resetQuery, con);
                            resetCmd.Parameters.AddWithValue("@id", user_id);
                            resetCmd.ExecuteNonQuery();

                            Logger.Logs(user_id, "Login", $"User {username} logged in");

                            switch (role_id)
                            {
                                case 1:
                                    Admin admin = new Admin(user_id, username);
                                    admin.Show();
                                    this.Hide();
                                    break;
                                case 2:
                                    Student student = new Student(user_id, username);
                                    student.Show();
                                    this.Hide();
                                    break;
                                case 3:
                                    Teacher teacher = new Teacher(user_id, username);
                                    teacher.Show();
                                    this.Hide();
                                    break;
                                default:
                                    MessageBox.Show("Unknown user role.");
                                    break;
                            }
                        }
                        else
                        {
                            //wrong pass handling
                            failedAttempts++;
                            if (failedAttempts >= 3)
                            {
                                DateTime lockoutTime = DateTime.Now.AddMinutes(1);
                                string lockQuery = "UPDATE user_login SET failed_attempts = @fa, lockout_until = @lu WHERE userId = @id";
                                SqlCommand lockCmd = new SqlCommand(lockQuery, con);
                                lockCmd.Parameters.AddWithValue("@fa", failedAttempts);
                                lockCmd.Parameters.AddWithValue("@lu", lockoutTime);
                                lockCmd.Parameters.AddWithValue("@id", user_id);
                                lockCmd.ExecuteNonQuery();

                                MessageBox.Show("Reached failed attempts. Account locked for 1 min.");
                            }
                            else
                            {
                                string updateQuery = "UPDATE user_login SET failed_attempts = @fa WHERE userId = @id";
                                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                                updateCmd.Parameters.AddWithValue("@fa", failedAttempts);
                                updateCmd.Parameters.AddWithValue("@id", user_id);
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show($"Invalid password. Attempts left: {3 - failedAttempts}");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void lnklblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotpassUC.Location = new Point(521, 34);
            forgotpassUC.Visible = true;
            forgotpassUC.BringToFront();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            forgotpassUC = new ForgotPassuc();
            panelLoginForm.Controls.Add(forgotpassUC); // Add inside the panel, not the form
            forgotpassUC.Dock = DockStyle.Fill;      // Fill the panel completely
            forgotpassUC.Visible = false;

            this.AcceptButton = btnLogin;
        }
    }
}
