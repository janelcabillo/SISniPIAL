namespace SISniPIAL
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            pbAdminPP = new PictureBox();
            lblWelcomeAdmin = new Label();
            btnDashboard = new Button();
            btnStudent = new Button();
            btnTeacher = new Button();
            btnSubject = new Button();
            btnLogs = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            panelAdmin = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbAdminPP).BeginInit();
            panelAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // pbAdminPP
            // 
            pbAdminPP.Image = (Image)resources.GetObject("pbAdminPP.Image");
            pbAdminPP.Location = new Point(64, 9);
            pbAdminPP.Margin = new Padding(3, 2, 3, 2);
            pbAdminPP.Name = "pbAdminPP";
            pbAdminPP.Size = new Size(90, 65);
            pbAdminPP.SizeMode = PictureBoxSizeMode.Zoom;
            pbAdminPP.TabIndex = 0;
            pbAdminPP.TabStop = false;
            // 
            // lblWelcomeAdmin
            // 
            lblWelcomeAdmin.AutoSize = true;
            lblWelcomeAdmin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeAdmin.Location = new Point(56, 86);
            lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            lblWelcomeAdmin.Size = new Size(103, 15);
            lblWelcomeAdmin.TabIndex = 1;
            lblWelcomeAdmin.Text = "Welcome Admin!";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.AppWorkspace;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(32, 112);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(157, 35);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.AppWorkspace;
            btnStudent.FlatStyle = FlatStyle.Popup;
            btnStudent.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(32, 170);
            btnStudent.Margin = new Padding(3, 2, 3, 2);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(157, 35);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = SystemColors.AppWorkspace;
            btnTeacher.FlatStyle = FlatStyle.Popup;
            btnTeacher.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(32, 209);
            btnTeacher.Margin = new Padding(3, 2, 3, 2);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(157, 35);
            btnTeacher.TabIndex = 4;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnSubject
            // 
            btnSubject.BackColor = SystemColors.AppWorkspace;
            btnSubject.FlatStyle = FlatStyle.Popup;
            btnSubject.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubject.Location = new Point(32, 249);
            btnSubject.Margin = new Padding(3, 2, 3, 2);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(157, 35);
            btnSubject.TabIndex = 5;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = false;
            btnSubject.Click += btnSubject_Click;
            // 
            // btnLogs
            // 
            btnLogs.BackColor = SystemColors.AppWorkspace;
            btnLogs.FlatStyle = FlatStyle.Popup;
            btnLogs.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.Location = new Point(32, 289);
            btnLogs.Margin = new Padding(3, 2, 3, 2);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(157, 35);
            btnLogs.TabIndex = 6;
            btnLogs.Text = "Logs";
            btnLogs.UseVisualStyleBackColor = false;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.AppWorkspace;
            btnReports.FlatStyle = FlatStyle.Popup;
            btnReports.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Location = new Point(32, 328);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(157, 35);
            btnReports.TabIndex = 7;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.AppWorkspace;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(32, 379);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(157, 35);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.Gray;
            panelAdmin.Controls.Add(pbAdminPP);
            panelAdmin.Controls.Add(btnLogout);
            panelAdmin.Controls.Add(lblWelcomeAdmin);
            panelAdmin.Controls.Add(btnReports);
            panelAdmin.Controls.Add(btnDashboard);
            panelAdmin.Controls.Add(btnLogs);
            panelAdmin.Controls.Add(btnStudent);
            panelAdmin.Controls.Add(btnSubject);
            panelAdmin.Controls.Add(btnTeacher);
            panelAdmin.Location = new Point(0, 0);
            panelAdmin.Margin = new Padding(3, 2, 3, 2);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(222, 425);
            panelAdmin.TabIndex = 9;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(869, 423);
            Controls.Add(panelAdmin);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)pbAdminPP).EndInit();
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbAdminPP;
        private Label lblWelcomeAdmin;
        private Button btnDashboard;
        private Button btnStudent;
        private Button btnTeacher;
        private Button btnSubject;
        private Button btnLogs;
        private Button btnReports;
        private Button btnLogout;
        private Panel panelAdmin;
    }
}