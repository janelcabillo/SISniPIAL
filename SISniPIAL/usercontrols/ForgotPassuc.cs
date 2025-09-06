using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Security;
using Microsoft.Data.SqlClient;
using MimeKit;
using MailKit.Net.Smtp;

namespace SISniPIAL.forms
{
    public partial class ForgotPassuc : UserControl
    {
        public string otpcode;
        public ForgotPassuc()
        {
            InitializeComponent();
        }
        private void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("SIS", "nellypial.ccsdump@gmail.com"));
                message.To.Add(new MailboxAddress("", toEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate("nellypial.ccsdump@gmail.com", "gsbh pivg ojhh xuau");
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();
                string query = @"SELECT Email FROM student WHERE Email=@em
                                 UNION 
                                 SELECT Email FROM teacher WHERE Email=@em";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@em", email);
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    Random random = new Random();
                    otpcode = random.Next(100000, 999999).ToString();

                    SendEmail(email, "Your OTP Code", $"Your OTP code is {otpcode}");
                    MessageBox.Show("OTP sent to your email!");
                }
                else
                {
                    MessageBox.Show("Email not found!");
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text == otpcode)
            {
                MessageBox.Show("OTP Verified! Please Enter New Password");
                panelResetPass.Visible = true;

            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string newpass = txtNewPass.Text;
            string email = txtEmail.Text;

            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                con.Open();


                string getUserQuery = @"
                    SELECT s.FirstName
                    FROM student s
                    WHERE s.Email = @em
                    UNION
                    SELECT t.FirstName
                    FROM teacher t
                    WHERE t.Email = @em";

                SqlCommand cmdGet = new SqlCommand(getUserQuery, con);
                cmdGet.Parameters.AddWithValue("@em", email);
                var usernameObj = cmdGet.ExecuteScalar();

                if (usernameObj != null)
                {
                    string username = usernameObj.ToString();


                    string updateQuery = "UPDATE user_login SET password_hash = @pas WHERE username = @uname";
                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);
                    cmdUpdate.Parameters.AddWithValue("@pas", newpass);
                    cmdUpdate.Parameters.AddWithValue("@uname", username);

                    int rows = cmdUpdate.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Password Updated Successfully!");
                        LoginForm login = new LoginForm();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password in user_login!");
                    }
                }
                else
                {
                    MessageBox.Show("No matching user found for this email!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
