namespace SISniPIAL
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            panelStudent = new Panel();
            pbStudentPP = new PictureBox();
            btnLogout = new Button();
            lblWelcomeStudent = new Label();
            lblStudentProfile = new Label();
            rtbStudentInfo = new RichTextBox();
            dgvStudentSub = new DataGridView();
            panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStudentPP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentSub).BeginInit();
            SuspendLayout();
            // 
            // panelStudent
            // 
            panelStudent.BackColor = Color.Gray;
            panelStudent.Controls.Add(pbStudentPP);
            panelStudent.Controls.Add(btnLogout);
            panelStudent.Controls.Add(lblWelcomeStudent);
            panelStudent.Location = new Point(0, 0);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(254, 567);
            panelStudent.TabIndex = 10;
            // 
            // pbStudentPP
            // 
            pbStudentPP.Image = (Image)resources.GetObject("pbStudentPP.Image");
            pbStudentPP.Location = new Point(73, 12);
            pbStudentPP.Name = "pbStudentPP";
            pbStudentPP.Size = new Size(103, 87);
            pbStudentPP.SizeMode = PictureBoxSizeMode.Zoom;
            pbStudentPP.TabIndex = 0;
            pbStudentPP.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.AppWorkspace;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(36, 505);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(179, 47);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcomeStudent
            // 
            lblWelcomeStudent.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeStudent.Location = new Point(0, 115);
            lblWelcomeStudent.Name = "lblWelcomeStudent";
            lblWelcomeStudent.Size = new Size(254, 26);
            lblWelcomeStudent.TabIndex = 1;
            lblWelcomeStudent.Text = "Welcome Student!";
            lblWelcomeStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudentProfile
            // 
            lblStudentProfile.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentProfile.Location = new Point(273, 12);
            lblStudentProfile.Name = "lblStudentProfile";
            lblStudentProfile.Size = new Size(708, 48);
            lblStudentProfile.TabIndex = 11;
            lblStudentProfile.Text = "Student Profile";
            lblStudentProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtbStudentInfo
            // 
            rtbStudentInfo.BackColor = Color.Gray;
            rtbStudentInfo.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbStudentInfo.Location = new Point(273, 74);
            rtbStudentInfo.Name = "rtbStudentInfo";
            rtbStudentInfo.Size = new Size(371, 478);
            rtbStudentInfo.TabIndex = 12;
            rtbStudentInfo.Text = "";
            // 
            // dgvStudentSub
            // 
            dgvStudentSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentSub.Location = new Point(665, 74);
            dgvStudentSub.Name = "dgvStudentSub";
            dgvStudentSub.RowHeadersWidth = 51;
            dgvStudentSub.Size = new Size(316, 478);
            dgvStudentSub.TabIndex = 13;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(993, 564);
            Controls.Add(dgvStudentSub);
            Controls.Add(rtbStudentInfo);
            Controls.Add(lblStudentProfile);
            Controls.Add(panelStudent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panelStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbStudentPP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentSub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStudent;
        private PictureBox pbStudentPP;
        private Button btnLogout;
        private Label lblWelcomeStudent;
        private Label lblStudentProfile;
        private RichTextBox rtbStudentInfo;
        private DataGridView dgvStudentSub;
    }
}