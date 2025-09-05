﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Asn1.Cmp;

namespace SISniPIAL.forms
{
    public partial class Studentuc : UserControl
    {
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;
        private bool isUpdateMode = false;
        private int selectedStudentId = -1;
        public Studentuc(int userId, string username)
        {
            InitializeComponent();
            _loggedInUserId = userId;
            _loggedInUser = username;
            LoadStudents();
        }
        private void LoadStudentsWithSearch(string searchText = "")
        {
            using (SqlConnection con = new SqlConnection(DatabaseConnection.conString))
            {
                string query = @"
                                SELECT StudentId, FirstName, LastName, DateOfBirth, Gender,
                                       Email, Phone, Address, EnrollmentDate, Status, userId
                                FROM student
                                WHERE 
                                    StudentId LIKE @search OR
                                    FirstName LIKE @search OR
                                    LastName LIKE @search OR
                                    CONVERT(VARCHAR, DateOfBirth, 23) LIKE @search OR
                                    Gender = @genderSearch OR
                                    Email LIKE @search OR
                                    Phone LIKE @search OR
                                    Address LIKE @search OR
                                    CONVERT(VARCHAR, EnrollmentDate, 23) LIKE @search OR
                                    Status LIKE @search
                                ORDER BY StudentId DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    string genderSearch = (searchText.Equals("male", StringComparison.OrdinalIgnoreCase) ||
                       searchText.Equals("female", StringComparison.OrdinalIgnoreCase))
                      ? searchText
                      : "";
                    // Add parameter with wildcard for LIKE
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    cmd.Parameters.AddWithValue("@genderSearch", genderSearch);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvStudent.DataSource = dt;
                }
            }
        }
        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
            {
                string query = "SELECT * FROM student WHERE Status = 'Active' order by StudentId desc";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvStudent.DataSource = dt;
            }
        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
            dtpDOB.Value = DateTime.Today;
            dtpEnrollDate.Value = DateTime.Today;
        }

        private void Studentuc_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtStatus.Visible = true;
            lblStatus.Visible = true;
            if (!panelStudent.Visible)
            {
                lblAddStudent.Text = "Add Student";  // title for add mode
                panelStudent.Visible = true;
                panelStudent.BringToFront();
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
            if (cmbGender.SelectedItem == null || string.IsNullOrWhiteSpace(cmbGender.SelectedItem?.ToString()))
                errors.Add("Gender is required.");
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                errors.Add("Email is required.");
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                errors.Add("Phone number is required.");
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                errors.Add("Address is required.");

            // if there are any errors, show them all at once
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

                if (isUpdateMode && selectedStudentId > 0)
                {
                    // first get the linked user_id from the student table
                    int userId = -1;
                    using (SqlCommand cmdGetUserId = new SqlCommand("SELECT userId FROM student WHERE StudentId = @id", con))
                    {
                        cmdGetUserId.Parameters.AddWithValue("@id", selectedStudentId);
                        object obj = cmdGetUserId.ExecuteScalar();
                        if (obj != null)
                            userId = Convert.ToInt32(obj);
                    }

                    // UPDATE student table
                    string updateQuery = @"UPDATE student SET  
                                        FirstName = @first_name,
                                        LastName = @last_name,
                                        DateOfBirth = @dob,
                                        Gender = @gender,
                                        Email = @email,
                                        Phone = @phone,
                                        Address = @address,
                                        EnrollmentDate = @enroll
                                       WHERE StudentId = @id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@enroll", dtpEnrollDate.Value.Date);
                        cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedStudentId);

                        cmd.ExecuteNonQuery();
                    }

                    // UPDATE user_login table (username & password)
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

                    MessageBox.Show("Student updated successfully!");
                    Logger.Log(_loggedInUserId, "Update Student", $"User {_loggedInUser} updated student {firstName} {lastName}.");
                }
                else
                {
                    // 1. Insert into user_login & get new user_id
                    string insertUserQuery = @"INSERT INTO user_login(username, password_hash, roleId) 
                                       VALUES (@username, @password_hash, @role_id); 
                                       SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    int newUserId;
                    using (SqlCommand cmdUser = new SqlCommand(insertUserQuery, con))
                    {
                        cmdUser.Parameters.AddWithValue("@username", txtFirstName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@password_hash", txtLastName.Text.Trim());
                        cmdUser.Parameters.AddWithValue("@role_id", 2);

                        newUserId = (int)cmdUser.ExecuteScalar();
                    }

                    // 2. Insert into student (student_id will be auto-generated by DB)
                    string insertStudentQuery = @"INSERT INTO student 
                                          (FirstName, LastName, DateOfBirth, Gender, Email, Phone, Address, EnrollmentDate, Status, userId) 
                                          VALUES (@first_name, @last_name, @dob, @gender, @email, @phone, @address, @enrollment, @status, @user_id)";

                    using (SqlCommand cmdStudent = new SqlCommand(insertStudentQuery, con))
                    {
                        cmdStudent.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                        cmdStudent.Parameters.AddWithValue("@gender", cmbGender.SelectedItem?.ToString() ?? "");
                        cmdStudent.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@enrollment", dtpEnrollDate.Value.Date);
                        cmdStudent.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                        cmdStudent.Parameters.AddWithValue("@user_id", newUserId);

                        cmdStudent.ExecuteNonQuery();
                        MessageBox.Show("Student added successfully!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Logger.Log(_loggedInUserId, "Add Student", $"User {_loggedInUser} added student {firstName} {lastName}.");
                    }
                }

                // this will reset form
                ClearFields();
                panelStudent.Visible = false;
                isUpdateMode = false;
                selectedStudentId = -1;

                // reload the data
                LoadStudents();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelStudent.Visible = false;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtStatus.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            dtpEnrollDate.Value = DateTime.Now;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtStatus.Visible = false;
            lblStatus.Visible = false;

            if (dgvStudent.SelectedRows.Count > 0)
            {
                // get selected student's ID
                selectedStudentId = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells["StudentId"].Value);

                // load data into form fields
                txtFirstName.Text = dgvStudent.SelectedRows[0].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvStudent.SelectedRows[0].Cells["LastName"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvStudent.SelectedRows[0].Cells["DateOfBirth"].Value);
                cmbGender.SelectedItem = dgvStudent.SelectedRows[0].Cells["Gender"].Value.ToString();
                txtEmail.Text = dgvStudent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPhone.Text = dgvStudent.SelectedRows[0].Cells["Phone"].Value.ToString();
                txtAddress.Text = dgvStudent.SelectedRows[0].Cells["Address"].Value.ToString();
                dtpEnrollDate.Value = Convert.ToDateTime(dgvStudent.SelectedRows[0].Cells["EnrollmentDate"].Value);
                txtStatus.Text = dgvStudent.SelectedRows[0].Cells["Status"].Value.ToString();

                // this enable update mode
                isUpdateMode = true;

                // change label text to "Update Student"
                lblAddStudent.Text = "Update Student";

                // shows the panel
                panelStudent.Visible = true;
                panelStudent.BringToFront();
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow != null)
            {
                string firstName = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                string lastName = dgvStudent.CurrentRow.Cells[2].Value.ToString();
                string studentId = dgvStudent.CurrentRow.Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete student {firstName} {lastName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
                    {
                        conn.Open();
                        string deleteQuery = "UPDATE student SET Status = 'Inactive' WHERE StudentId = @id";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadStudents();
                    MessageBox.Show($"Student {firstName} {lastName} marked as inactive successfully.");
                    Logger.Log(_loggedInUserId, "Deactivate Student", $"User {_loggedInUser} deactivated student {firstName} {lastName}.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudentsWithSearch(txtSearch.Text.Trim());
        }
    }
}
