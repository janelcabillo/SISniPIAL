namespace SISniPIAL.usercontrols
{
    partial class Teacheruc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacheruc));
            dgvTeacher = new DataGridView();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            btnAssign = new Button();
            panelTeacher = new Panel();
            txtSpecialization = new TextBox();
            txtDepartment = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtStatus = new TextBox();
            lblStatus = new Label();
            dtpHireDate = new DateTimePicker();
            lblHireDate = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblAddTeacher = new Label();
            lblTeacherCount = new Label();
            panelAssignSubject = new Panel();
            btnBack = new Button();
            btnSaveAssign = new Button();
            lblSubjectName = new Label();
            cmbSubjects = new ComboBox();
            lblAssign = new Label();
            panelView = new Panel();
            rtbDetails = new RichTextBox();
            btnClose = new Button();
            dgvSub = new DataGridView();
            pbTeacherPP = new PictureBox();
            lblTeacherDetails = new Label();
            panelListStudents = new Panel();
            dgvStudents = new DataGridView();
            btnBackButton = new Button();
            lblStudentsEnrolled = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelTeacher.SuspendLayout();
            panelAssignSubject.SuspendLayout();
            panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTeacherPP).BeginInit();
            panelListStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvTeacher
            // 
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(3, 56);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowHeadersWidth = 51;
            dgvTeacher.Size = new Size(715, 399);
            dgvTeacher.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(46, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(185, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearch
            // 
            pbSearch.Image = (Image)resources.GetObject("pbSearch.Image");
            pbSearch.Location = new Point(14, 13);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(26, 28);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 3;
            pbSearch.TabStop = false;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(37, 472);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(117, 52);
            btnAddNew.TabIndex = 4;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Gold;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(302, 472);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 52);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(565, 472);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 52);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.White;
            btnView.BackgroundImage = (Image)resources.GetObject("btnView.BackgroundImage");
            btnView.BackgroundImageLayout = ImageLayout.Zoom;
            btnView.FlatStyle = FlatStyle.Popup;
            btnView.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.Location = new Point(555, 13);
            btnView.Name = "btnView";
            btnView.Size = new Size(37, 27);
            btnView.TabIndex = 10;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnAssign
            // 
            btnAssign.FlatStyle = FlatStyle.Popup;
            btnAssign.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssign.Location = new Point(607, 13);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(94, 27);
            btnAssign.TabIndex = 11;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // panelTeacher
            // 
            panelTeacher.BackColor = Color.DimGray;
            panelTeacher.Controls.Add(txtSpecialization);
            panelTeacher.Controls.Add(txtDepartment);
            panelTeacher.Controls.Add(btnCancel);
            panelTeacher.Controls.Add(btnSave);
            panelTeacher.Controls.Add(txtStatus);
            panelTeacher.Controls.Add(lblStatus);
            panelTeacher.Controls.Add(dtpHireDate);
            panelTeacher.Controls.Add(lblHireDate);
            panelTeacher.Controls.Add(txtPhone);
            panelTeacher.Controls.Add(txtEmail);
            panelTeacher.Controls.Add(txtLastName);
            panelTeacher.Controls.Add(txtFirstName);
            panelTeacher.Controls.Add(lblAddTeacher);
            panelTeacher.Location = new Point(315, 0);
            panelTeacher.Name = "panelTeacher";
            panelTeacher.Size = new Size(405, 540);
            panelTeacher.TabIndex = 12;
            panelTeacher.Visible = false;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialization.Location = new Point(223, 284);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PlaceholderText = "Specialization:";
            txtSpecialization.Size = new Size(151, 25);
            txtSpecialization.TabIndex = 16;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(41, 284);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department:";
            txtDepartment.Size = new Size(151, 25);
            txtDepartment.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(238, 472);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 52);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(41, 472);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 52);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(101, 365);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(97, 25);
            txtStatus.TabIndex = 13;
            txtStatus.Text = "Active";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(41, 369);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 17);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(117, 216);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(258, 27);
            dtpHireDate.TabIndex = 11;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHireDate.Location = new Point(41, 223);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(69, 17);
            lblHireDate.TabIndex = 10;
            lblHireDate.Text = "HireDate:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(223, 163);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(151, 25);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(41, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(151, 25);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(223, 89);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name:";
            txtLastName.Size = new Size(151, 25);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(41, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name:";
            txtFirstName.Size = new Size(151, 25);
            txtFirstName.TabIndex = 1;
            // 
            // lblAddTeacher
            // 
            lblAddTeacher.Dock = DockStyle.Top;
            lblAddTeacher.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTeacher.Location = new Point(0, 0);
            lblAddTeacher.Name = "lblAddTeacher";
            lblAddTeacher.Size = new Size(405, 53);
            lblAddTeacher.TabIndex = 0;
            lblAddTeacher.Text = "Add Teacher";
            lblAddTeacher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeacherCount
            // 
            lblTeacherCount.AutoSize = true;
            lblTeacherCount.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherCount.Location = new Point(254, 20);
            lblTeacherCount.Name = "lblTeacherCount";
            lblTeacherCount.Size = new Size(46, 17);
            lblTeacherCount.TabIndex = 13;
            lblTeacherCount.Text = "label1";
            // 
            // panelAssignSubject
            // 
            panelAssignSubject.BackColor = SystemColors.GrayText;
            panelAssignSubject.Controls.Add(btnBack);
            panelAssignSubject.Controls.Add(btnSaveAssign);
            panelAssignSubject.Controls.Add(lblSubjectName);
            panelAssignSubject.Controls.Add(cmbSubjects);
            panelAssignSubject.Controls.Add(lblAssign);
            panelAssignSubject.Location = new Point(152, 83);
            panelAssignSubject.Name = "panelAssignSubject";
            panelAssignSubject.Size = new Size(408, 307);
            panelAssignSubject.TabIndex = 14;
            panelAssignSubject.Visible = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(21, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(32, 28);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveAssign
            // 
            btnSaveAssign.BackColor = Color.SteelBlue;
            btnSaveAssign.FlatStyle = FlatStyle.Popup;
            btnSaveAssign.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAssign.Location = new Point(102, 219);
            btnSaveAssign.Name = "btnSaveAssign";
            btnSaveAssign.Size = new Size(208, 49);
            btnSaveAssign.TabIndex = 5;
            btnSaveAssign.Text = "Save";
            btnSaveAssign.UseVisualStyleBackColor = false;
            btnSaveAssign.Click += btnSaveAssign_Click;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(62, 121);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(61, 17);
            lblSubjectName.TabIndex = 2;
            lblSubjectName.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            cmbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubjects.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(129, 113);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(222, 25);
            cmbSubjects.TabIndex = 1;
            // 
            // lblAssign
            // 
            lblAssign.AutoSize = true;
            lblAssign.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssign.Location = new Point(129, 23);
            lblAssign.Name = "lblAssign";
            lblAssign.Size = new Size(147, 24);
            lblAssign.TabIndex = 0;
            lblAssign.Text = "Assign Subject";
            // 
            // panelView
            // 
            panelView.BackColor = Color.LightGray;
            panelView.Controls.Add(rtbDetails);
            panelView.Controls.Add(btnClose);
            panelView.Controls.Add(dgvSub);
            panelView.Controls.Add(pbTeacherPP);
            panelView.Controls.Add(lblTeacherDetails);
            panelView.Location = new Point(143, 57);
            panelView.Margin = new Padding(3, 4, 3, 4);
            panelView.Name = "panelView";
            panelView.Size = new Size(442, 397);
            panelView.TabIndex = 15;
            panelView.Visible = false;
            // 
            // rtbDetails
            // 
            rtbDetails.BackColor = Color.LightGray;
            rtbDetails.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDetails.Location = new Point(21, 89);
            rtbDetails.Name = "rtbDetails";
            rtbDetails.ReadOnly = true;
            rtbDetails.ScrollBars = RichTextBoxScrollBars.None;
            rtbDetails.Size = new Size(175, 273);
            rtbDetails.TabIndex = 7;
            rtbDetails.Text = "";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Location = new Point(395, 33);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 24);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvSub
            // 
            dgvSub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Location = new Point(202, 89);
            dgvSub.Margin = new Padding(3, 4, 3, 4);
            dgvSub.Name = "dgvSub";
            dgvSub.RowHeadersWidth = 51;
            dgvSub.Size = new Size(215, 273);
            dgvSub.TabIndex = 5;
            dgvSub.CellContentClick += dgvSub_CellContentClick;
            // 
            // pbTeacherPP
            // 
            pbTeacherPP.Image = (Image)resources.GetObject("pbTeacherPP.Image");
            pbTeacherPP.Location = new Point(21, 25);
            pbTeacherPP.Name = "pbTeacherPP";
            pbTeacherPP.Size = new Size(56, 48);
            pbTeacherPP.SizeMode = PictureBoxSizeMode.Zoom;
            pbTeacherPP.TabIndex = 3;
            pbTeacherPP.TabStop = false;
            // 
            // lblTeacherDetails
            // 
            lblTeacherDetails.AutoSize = true;
            lblTeacherDetails.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherDetails.Location = new Point(159, 37);
            lblTeacherDetails.Name = "lblTeacherDetails";
            lblTeacherDetails.Size = new Size(140, 22);
            lblTeacherDetails.TabIndex = 2;
            lblTeacherDetails.Text = "Teacher Details";
            // 
            // panelListStudents
            // 
            panelListStudents.BackColor = Color.DimGray;
            panelListStudents.BorderStyle = BorderStyle.Fixed3D;
            panelListStudents.Controls.Add(dgvStudents);
            panelListStudents.Controls.Add(btnBackButton);
            panelListStudents.Controls.Add(lblStudentsEnrolled);
            panelListStudents.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelListStudents.Location = new Point(0, 0);
            panelListStudents.Name = "panelListStudents";
            panelListStudents.Size = new Size(231, 540);
            panelListStudents.TabIndex = 8;
            panelListStudents.Visible = false;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(9, 54);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(209, 449);
            dgvStudents.TabIndex = 2;
            // 
            // btnBackButton
            // 
            btnBackButton.BackgroundImage = (Image)resources.GetObject("btnBackButton.BackgroundImage");
            btnBackButton.BackgroundImageLayout = ImageLayout.Zoom;
            btnBackButton.FlatStyle = FlatStyle.Popup;
            btnBackButton.Location = new Point(9, 6);
            btnBackButton.Name = "btnBackButton";
            btnBackButton.Size = new Size(29, 24);
            btnBackButton.TabIndex = 1;
            btnBackButton.UseVisualStyleBackColor = true;
            btnBackButton.Click += btnBackButton_Click;
            // 
            // lblStudentsEnrolled
            // 
            lblStudentsEnrolled.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsEnrolled.Location = new Point(44, 0);
            lblStudentsEnrolled.Name = "lblStudentsEnrolled";
            lblStudentsEnrolled.Size = new Size(159, 39);
            lblStudentsEnrolled.TabIndex = 0;
            lblStudentsEnrolled.Text = "Students Enrolled";
            lblStudentsEnrolled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Teacheruc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(panelListStudents);
            Controls.Add(panelView);
            Controls.Add(panelAssignSubject);
            Controls.Add(lblTeacherCount);
            Controls.Add(btnAssign);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvTeacher);
            Controls.Add(panelTeacher);
            Name = "Teacheruc";
            Size = new Size(721, 540);
            Load += Teacheruc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            panelTeacher.ResumeLayout(false);
            panelTeacher.PerformLayout();
            panelAssignSubject.ResumeLayout(false);
            panelAssignSubject.PerformLayout();
            panelView.ResumeLayout(false);
            panelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTeacherPP).EndInit();
            panelListStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTeacher;
        private TextBox txtSearch;
        private PictureBox pbSearch;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private Button btnAssign;
        private Panel panelTeacher;
        private TextBox txtSpecialization;
        private TextBox txtDepartment;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtStatus;
        private Label lblStatus;
        private DateTimePicker dtpHireDate;
        private Label lblHireDate;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblAddTeacher;
        private Label lblTeacherCount;
        private Panel panelAssignSubject;
        private Button btnBack;
        private Button btnSaveAssign;
        private Label lblSubjectName;
        private ComboBox cmbSubjects;
        private Label lblAssign;
        private Panel panelView;
        private Label lblTeacherDetails;
        private PictureBox pbTeacherPP;
        private DataGridView dgvSub;
        private Button btnClose;
        private RichTextBox rtbDetails;
        private Panel panelListStudents;
        private Button btnBackButton;
        private Label lblStudentsEnrolled;
        private DataGridView dgvStudents;
    }
}
