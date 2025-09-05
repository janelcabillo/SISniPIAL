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
            panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStudentPP).BeginInit();
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
            lblWelcomeStudent.AutoSize = true;
            lblWelcomeStudent.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeStudent.Location = new Point(57, 115);
            lblWelcomeStudent.Name = "lblWelcomeStudent";
            lblWelcomeStudent.Size = new Size(136, 18);
            lblWelcomeStudent.TabIndex = 1;
            lblWelcomeStudent.Text = "Welcome Student!";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(993, 564);
            Controls.Add(panelStudent);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStudentPP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStudent;
        private PictureBox pbStudentPP;
        private Button btnLogout;
        private Label lblWelcomeStudent;
    }
}