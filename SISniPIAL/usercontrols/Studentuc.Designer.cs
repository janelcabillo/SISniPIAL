namespace SISniPIAL.forms
{
    partial class Studentuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studentuc));
            dgvStudent = new DataGridView();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnView = new Button();
            btnAssign = new Button();
            panelStudent = new Panel();
            lblAddStudent = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtStatus = new TextBox();
            lblStatus = new Label();
            dtpEnrollDate = new DateTimePicker();
            lblEnrollDate = new Label();
            lblGender = new Label();
            cmbGender = new ComboBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            dtpDOB = new DateTimePicker();
            lbldob = new Label();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblStudentCount = new Label();
            panelAssignSubject = new Panel();
            btnBack = new Button();
            btnSaveAssign = new Button();
            cmbTeachers = new ComboBox();
            lblTeacherSubject = new Label();
            lblSubjectName = new Label();
            cmbSubjects = new ComboBox();
            lblAssign = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelStudent.SuspendLayout();
            panelAssignSubject.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(3, 56);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(715, 399);
            dgvStudent.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(46, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(185, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearch
            // 
            pbSearch.Image = (Image)resources.GetObject("pbSearch.Image");
            pbSearch.Location = new Point(14, 13);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(26, 28);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 2;
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
            btnAddNew.TabIndex = 3;
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
            btnUpdate.TabIndex = 4;
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
            btnDelete.TabIndex = 5;
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
            btnView.TabIndex = 6;
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnAssign
            // 
            btnAssign.FlatStyle = FlatStyle.Popup;
            btnAssign.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssign.Location = new Point(607, 13);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(94, 27);
            btnAssign.TabIndex = 7;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // panelStudent
            // 
            panelStudent.BackColor = Color.DimGray;
            panelStudent.Controls.Add(lblAddStudent);
            panelStudent.Controls.Add(btnCancel);
            panelStudent.Controls.Add(btnSave);
            panelStudent.Controls.Add(txtStatus);
            panelStudent.Controls.Add(lblStatus);
            panelStudent.Controls.Add(dtpEnrollDate);
            panelStudent.Controls.Add(lblEnrollDate);
            panelStudent.Controls.Add(lblGender);
            panelStudent.Controls.Add(cmbGender);
            panelStudent.Controls.Add(txtAddress);
            panelStudent.Controls.Add(txtPhone);
            panelStudent.Controls.Add(dtpDOB);
            panelStudent.Controls.Add(lbldob);
            panelStudent.Controls.Add(txtEmail);
            panelStudent.Controls.Add(txtLastName);
            panelStudent.Controls.Add(txtFirstName);
            panelStudent.Location = new Point(317, 0);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(405, 540);
            panelStudent.TabIndex = 9;
            panelStudent.Visible = false;
            // 
            // lblAddStudent
            // 
            lblAddStudent.Dock = DockStyle.Top;
            lblAddStudent.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStudent.Location = new Point(0, 0);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(405, 53);
            lblAddStudent.TabIndex = 0;
            lblAddStudent.Text = "Add Student";
            lblAddStudent.TextAlign = ContentAlignment.MiddleCenter;
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
            txtStatus.Location = new Point(277, 389);
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
            lblStatus.Location = new Point(217, 392);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 17);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollDate.Location = new Point(136, 325);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(238, 27);
            dtpEnrollDate.TabIndex = 11;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollDate.Location = new Point(41, 333);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(80, 17);
            lblEnrollDate.TabIndex = 10;
            lblEnrollDate.Text = "EnrollDate:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(41, 392);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 17);
            lblGender.TabIndex = 9;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(107, 389);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(84, 25);
            cmbGender.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(41, 263);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address:";
            txtAddress.Size = new Size(333, 25);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(223, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(151, 25);
            txtPhone.TabIndex = 6;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(136, 147);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(238, 27);
            dtpDOB.TabIndex = 5;
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldob.Location = new Point(41, 155);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(89, 17);
            lbldob.TabIndex = 4;
            lbldob.Text = "DateOfBirth:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(41, 208);
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
            // lblStudentCount
            // 
            lblStudentCount.AutoSize = true;
            lblStudentCount.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentCount.Location = new Point(254, 20);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(46, 17);
            lblStudentCount.TabIndex = 11;
            lblStudentCount.Text = "label1";
            // 
            // panelAssignSubject
            // 
            panelAssignSubject.BackColor = SystemColors.GrayText;
            panelAssignSubject.Controls.Add(btnBack);
            panelAssignSubject.Controls.Add(btnSaveAssign);
            panelAssignSubject.Controls.Add(cmbTeachers);
            panelAssignSubject.Controls.Add(lblTeacherSubject);
            panelAssignSubject.Controls.Add(lblSubjectName);
            panelAssignSubject.Controls.Add(cmbSubjects);
            panelAssignSubject.Controls.Add(lblAssign);
            panelAssignSubject.Location = new Point(152, 82);
            panelAssignSubject.Name = "panelAssignSubject";
            panelAssignSubject.Size = new Size(408, 307);
            panelAssignSubject.TabIndex = 12;
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
            // cmbTeachers
            // 
            cmbTeachers.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTeachers.FormattingEnabled = true;
            cmbTeachers.Location = new Point(120, 155);
            cmbTeachers.Name = "cmbTeachers";
            cmbTeachers.Size = new Size(222, 25);
            cmbTeachers.TabIndex = 4;
            // 
            // lblTeacherSubject
            // 
            lblTeacherSubject.AutoSize = true;
            lblTeacherSubject.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherSubject.Location = new Point(53, 158);
            lblTeacherSubject.Name = "lblTeacherSubject";
            lblTeacherSubject.Size = new Size(64, 17);
            lblTeacherSubject.TabIndex = 3;
            lblTeacherSubject.Text = "Teacher:";
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(53, 103);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(61, 17);
            lblSubjectName.TabIndex = 2;
            lblSubjectName.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            cmbSubjects.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(120, 98);
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
            // Studentuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(panelAssignSubject);
            Controls.Add(panelStudent);
            Controls.Add(lblStudentCount);
            Controls.Add(btnAssign);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudent);
            Name = "Studentuc";
            Size = new Size(721, 540);
            Load += Studentuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
            panelAssignSubject.ResumeLayout(false);
            panelAssignSubject.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private TextBox txtSearch;
        private PictureBox pbSearch;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnView;
        private Button btnAssign;
        private Panel panelStudent;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtStatus;
        private Label lblStatus;
        private DateTimePicker dtpEnrollDate;
        private Label lblEnrollDate;
        private Label lblGender;
        private ComboBox cmbGender;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DateTimePicker dtpDOB;
        private Label lbldob;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblAddStudent;
        private Label lblStudentCount;
        private Panel panelAssignSubject;
        private Label lblSubjectName;
        private ComboBox cmbSubjects;
        private Label lblAssign;
        private Button btnSaveAssign;
        private ComboBox cmbTeachers;
        private Label lblTeacherSubject;
        private Button btnBack;
    }
}
