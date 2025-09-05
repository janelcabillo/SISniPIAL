namespace SISniPIAL
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            panelTeacher = new Panel();
            pbTeacherPP = new PictureBox();
            btnLogout = new Button();
            lblWelcomeTeacher = new Label();
            panelTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTeacherPP).BeginInit();
            SuspendLayout();
            // 
            // panelTeacher
            // 
            panelTeacher.BackColor = Color.Gray;
            panelTeacher.Controls.Add(pbTeacherPP);
            panelTeacher.Controls.Add(btnLogout);
            panelTeacher.Controls.Add(lblWelcomeTeacher);
            panelTeacher.Location = new Point(0, 0);
            panelTeacher.Name = "panelTeacher";
            panelTeacher.Size = new Size(254, 567);
            panelTeacher.TabIndex = 11;
            // 
            // pbTeacherPP
            // 
            pbTeacherPP.Image = (Image)resources.GetObject("pbTeacherPP.Image");
            pbTeacherPP.Location = new Point(73, 12);
            pbTeacherPP.Name = "pbTeacherPP";
            pbTeacherPP.Size = new Size(103, 87);
            pbTeacherPP.SizeMode = PictureBoxSizeMode.Zoom;
            pbTeacherPP.TabIndex = 0;
            pbTeacherPP.TabStop = false;
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
            // lblWelcomeTeacher
            // 
            lblWelcomeTeacher.AutoSize = true;
            lblWelcomeTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(57, 115);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(138, 18);
            lblWelcomeTeacher.TabIndex = 1;
            lblWelcomeTeacher.Text = "Welcome Teacher!";
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(997, 568);
            Controls.Add(panelTeacher);
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            panelTeacher.ResumeLayout(false);
            panelTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTeacherPP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTeacher;
        private PictureBox pbTeacherPP;
        private Button btnLogout;
        private Label lblWelcomeTeacher;
    }
}