using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISniPIAL.forms;
using SISniPIAL.usercontrols;

namespace SISniPIAL
{
    public partial class Admin : Form
    {
        private readonly int _loggedInUserId;
        private readonly string _loggedInUser;
        private string userAdmin;

        private Studentuc studentUC;
        private Teacheruc teacherUC;
        private Dashboarduc dashboardUC;
        private Logsuc logsUC;
        private Subjectuc subjectUC;
        public Admin(int user_id, string username)
        {
            InitializeComponent();
            _loggedInUserId = user_id;
            _loggedInUser = username;
            this.userAdmin = username;

            Studentuc studentUC = new Studentuc(_loggedInUserId, _loggedInUser);
            studentUC.Visible = false;
            this.Controls.Add(studentUC);

            Teacheruc teacherUC = new Teacheruc(_loggedInUserId, _loggedInUser);
            teacherUC.Visible = false;
            this.Controls.Add(teacherUC);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = $"Welcome {userAdmin}!";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            if (dashboardUC == null)
            {
                dashboardUC = new Dashboarduc();
                dashboardUC.Location = new Point(260, 12);
                dashboardUC.Size = new Size(721, 540);
                this.Controls.Add(dashboardUC);
                dashboardUC.BringToFront();
            }
            else
            {
                dashboardUC.Visible = true;
                dashboardUC.BringToFront();

                dashboardUC.LoadChart();
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (studentUC == null)
            {
                studentUC = new Studentuc(_loggedInUserId, _loggedInUser);
                studentUC.Location = new Point(260, 12);
                studentUC.Size = new Size(721, 540);
                this.Controls.Add(studentUC);
                studentUC.BringToFront();
            }
            else
            {
                studentUC.Visible = true;
                studentUC.BringToFront();
            }
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            if (teacherUC == null)
            {
                teacherUC = new Teacheruc(_loggedInUserId, _loggedInUser);
                teacherUC.Location = new Point(260, 12);
                teacherUC.Size = new Size(721, 540);
                this.Controls.Add(teacherUC);
                teacherUC.BringToFront();
            }
            else
            {
                teacherUC.Visible = true;
                teacherUC.BringToFront();
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (logsUC == null)
            {
                logsUC = new Logsuc();
                logsUC.Location = new Point(260, 12);
                logsUC.Size = new Size(721, 540);
                this.Controls.Add(logsUC);
                logsUC.BringToFront();
            }
            else
            {
                logsUC.Visible = true;
                logsUC.BringToFront();
            }
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

        private void btnSubject_Click(object sender, EventArgs e)
        {
            if (subjectUC == null)
            {
                subjectUC = new Subjectuc(_loggedInUserId, _loggedInUser);
                subjectUC.Location = new Point(260, 12);
                subjectUC.Size = new Size(721, 540);
                this.Controls.Add(subjectUC);
                subjectUC.BringToFront();
            }
            else
            {
                subjectUC.Visible = true;
                subjectUC.BringToFront();
            }
        }
    }
}
