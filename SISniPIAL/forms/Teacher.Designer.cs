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
            lblTeacherProfile = new Label();
            rtbTeacherInfo = new RichTextBox();
            dgvTeacherSub = new DataGridView();
            lbListStudents = new ListBox();
            btnCloseList = new Button();
            panelTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTeacherPP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherSub).BeginInit();
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
            lblWelcomeTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTeacher.Location = new Point(0, 115);
            lblWelcomeTeacher.Name = "lblWelcomeTeacher";
            lblWelcomeTeacher.Size = new Size(254, 26);
            lblWelcomeTeacher.TabIndex = 1;
            lblWelcomeTeacher.Text = "Welcome Teacher!";
            lblWelcomeTeacher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeacherProfile
            // 
            lblTeacherProfile.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherProfile.Location = new Point(273, 12);
            lblTeacherProfile.Name = "lblTeacherProfile";
            lblTeacherProfile.Size = new Size(708, 48);
            lblTeacherProfile.TabIndex = 12;
            lblTeacherProfile.Text = "Teacher Profile";
            lblTeacherProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtbTeacherInfo
            // 
            rtbTeacherInfo.BackColor = Color.Gray;
            rtbTeacherInfo.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbTeacherInfo.Location = new Point(273, 74);
            rtbTeacherInfo.Name = "rtbTeacherInfo";
            rtbTeacherInfo.Size = new Size(371, 478);
            rtbTeacherInfo.TabIndex = 13;
            rtbTeacherInfo.Text = "";
            // 
            // dgvTeacherSub
            // 
            dgvTeacherSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacherSub.Location = new Point(665, 74);
            dgvTeacherSub.Name = "dgvTeacherSub";
            dgvTeacherSub.RowHeadersWidth = 51;
            dgvTeacherSub.Size = new Size(316, 478);
            dgvTeacherSub.TabIndex = 14;
            dgvTeacherSub.CellContentClick += dgvTeacherSub_CellContentClick;
            // 
            // lbListStudents
            // 
            lbListStudents.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbListStudents.FormattingEnabled = true;
            lbListStudents.ItemHeight = 19;
            lbListStudents.Location = new Point(665, 74);
            lbListStudents.Name = "lbListStudents";
            lbListStudents.Size = new Size(316, 479);
            lbListStudents.TabIndex = 15;
            lbListStudents.Visible = false;
            // 
            // btnCloseList
            // 
            btnCloseList.BackColor = SystemColors.Window;
            btnCloseList.BackgroundImage = (Image)resources.GetObject("btnCloseList.BackgroundImage");
            btnCloseList.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseList.FlatStyle = FlatStyle.Popup;
            btnCloseList.ForeColor = SystemColors.Window;
            btnCloseList.Location = new Point(942, 86);
            btnCloseList.Name = "btnCloseList";
            btnCloseList.Size = new Size(29, 30);
            btnCloseList.TabIndex = 16;
            btnCloseList.UseVisualStyleBackColor = false;
            btnCloseList.Visible = false;
            btnCloseList.Click += btnCloseList_Click;
            // 
            // Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(997, 568);
            Controls.Add(btnCloseList);
            Controls.Add(lbListStudents);
            Controls.Add(dgvTeacherSub);
            Controls.Add(rtbTeacherInfo);
            Controls.Add(lblTeacherProfile);
            Controls.Add(panelTeacher);
            Name = "Teacher";
            Text = "Teacher";
            Load += Teacher_Load;
            panelTeacher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTeacherPP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeacherSub).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTeacher;
        private PictureBox pbTeacherPP;
        private Button btnLogout;
        private Label lblWelcomeTeacher;
        private Label lblTeacherProfile;
        private RichTextBox rtbTeacherInfo;
        private DataGridView dgvTeacherSub;
        private ListBox lbListStudents;
        private Button btnCloseList;
    }
}