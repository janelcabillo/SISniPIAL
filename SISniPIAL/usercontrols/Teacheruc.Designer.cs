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
            btnClose = new Button();
            dgvSub = new DataGridView();
            lblDetails = new Label();
            pbTeacherPP = new PictureBox();
            lblTeacherDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelTeacher.SuspendLayout();
            panelAssignSubject.SuspendLayout();
            panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSub).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTeacherPP).BeginInit();
            SuspendLayout();
            // 
            // dgvTeacher
            // 
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(3, 42);
            dgvTeacher.Margin = new Padding(3, 2, 3, 2);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowHeadersWidth = 51;
            dgvTeacher.Size = new Size(626, 299);
            dgvTeacher.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(40, 10);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(162, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearch
            // 
            pbSearch.Image = (Image)resources.GetObject("pbSearch.Image");
            pbSearch.Location = new Point(12, 10);
            pbSearch.Margin = new Padding(3, 2, 3, 2);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(23, 21);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 3;
            pbSearch.TabStop = false;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.ForestGreen;
            btnAddNew.FlatStyle = FlatStyle.Popup;
            btnAddNew.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.Location = new Point(32, 354);
            btnAddNew.Margin = new Padding(3, 2, 3, 2);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(102, 39);
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
            btnUpdate.Location = new Point(264, 354);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 39);
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
            btnDelete.Location = new Point(494, 354);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 39);
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
            btnView.Location = new Point(486, 10);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(32, 20);
            btnView.TabIndex = 10;
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnAssign
            // 
            btnAssign.FlatStyle = FlatStyle.Popup;
            btnAssign.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssign.Location = new Point(531, 10);
            btnAssign.Margin = new Padding(3, 2, 3, 2);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(82, 20);
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
            panelTeacher.Location = new Point(276, 0);
            panelTeacher.Margin = new Padding(3, 2, 3, 2);
            panelTeacher.Name = "panelTeacher";
            panelTeacher.Size = new Size(354, 405);
            panelTeacher.TabIndex = 12;
            panelTeacher.Visible = false;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpecialization.Location = new Point(195, 213);
            txtSpecialization.Margin = new Padding(3, 2, 3, 2);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.PlaceholderText = "Specialization:";
            txtSpecialization.Size = new Size(133, 21);
            txtSpecialization.TabIndex = 16;
            // 
            // txtDepartment
            // 
            txtDepartment.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(36, 213);
            txtDepartment.Margin = new Padding(3, 2, 3, 2);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.PlaceholderText = "Department:";
            txtDepartment.Size = new Size(133, 21);
            txtDepartment.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(208, 354);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 39);
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
            btnSave.Location = new Point(36, 354);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 39);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(88, 274);
            txtStatus.Margin = new Padding(3, 2, 3, 2);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(85, 21);
            txtStatus.TabIndex = 13;
            txtStatus.Text = "Active";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(36, 277);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpHireDate
            // 
            dtpHireDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(102, 162);
            dtpHireDate.Margin = new Padding(3, 2, 3, 2);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(226, 23);
            dtpHireDate.TabIndex = 11;
            // 
            // lblHireDate
            // 
            lblHireDate.AutoSize = true;
            lblHireDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHireDate.Location = new Point(36, 167);
            lblHireDate.Name = "lblHireDate";
            lblHireDate.Size = new Size(59, 15);
            lblHireDate.TabIndex = 10;
            lblHireDate.Text = "HireDate:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(195, 122);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(133, 21);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(36, 122);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email:";
            txtEmail.Size = new Size(133, 21);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(195, 67);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name:";
            txtLastName.Size = new Size(133, 21);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(36, 67);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name:";
            txtFirstName.Size = new Size(133, 21);
            txtFirstName.TabIndex = 1;
            // 
            // lblAddTeacher
            // 
            lblAddTeacher.Dock = DockStyle.Top;
            lblAddTeacher.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTeacher.Location = new Point(0, 0);
            lblAddTeacher.Name = "lblAddTeacher";
            lblAddTeacher.Size = new Size(354, 40);
            lblAddTeacher.TabIndex = 0;
            lblAddTeacher.Text = "Add Teacher";
            lblAddTeacher.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTeacherCount
            // 
            lblTeacherCount.AutoSize = true;
            lblTeacherCount.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherCount.Location = new Point(222, 15);
            lblTeacherCount.Name = "lblTeacherCount";
            lblTeacherCount.Size = new Size(41, 15);
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
            panelAssignSubject.Location = new Point(133, 62);
            panelAssignSubject.Margin = new Padding(3, 2, 3, 2);
            panelAssignSubject.Name = "panelAssignSubject";
            panelAssignSubject.Size = new Size(357, 230);
            panelAssignSubject.TabIndex = 14;
            panelAssignSubject.Visible = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(18, 14);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(28, 21);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaveAssign
            // 
            btnSaveAssign.BackColor = Color.SteelBlue;
            btnSaveAssign.FlatStyle = FlatStyle.Popup;
            btnSaveAssign.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveAssign.Location = new Point(89, 164);
            btnSaveAssign.Margin = new Padding(3, 2, 3, 2);
            btnSaveAssign.Name = "btnSaveAssign";
            btnSaveAssign.Size = new Size(182, 37);
            btnSaveAssign.TabIndex = 5;
            btnSaveAssign.Text = "Save";
            btnSaveAssign.UseVisualStyleBackColor = false;
            btnSaveAssign.Click += btnSaveAssign_Click;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(54, 91);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(51, 15);
            lblSubjectName.TabIndex = 2;
            lblSubjectName.Text = "Subject:";
            // 
            // cmbSubjects
            // 
            cmbSubjects.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(113, 85);
            cmbSubjects.Margin = new Padding(3, 2, 3, 2);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(195, 23);
            cmbSubjects.TabIndex = 1;
            // 
            // lblAssign
            // 
            lblAssign.AutoSize = true;
            lblAssign.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssign.Location = new Point(113, 17);
            lblAssign.Name = "lblAssign";
            lblAssign.Size = new Size(123, 19);
            lblAssign.TabIndex = 0;
            lblAssign.Text = "Assign Subject";
            // 
            // panelView
            // 
            panelView.BackColor = Color.LightGray;
            panelView.Controls.Add(btnClose);
            panelView.Controls.Add(dgvSub);
            panelView.Controls.Add(lblDetails);
            panelView.Controls.Add(pbTeacherPP);
            panelView.Controls.Add(lblTeacherDetails);
            panelView.Location = new Point(125, 43);
            panelView.Name = "panelView";
            panelView.Size = new Size(387, 298);
            panelView.TabIndex = 15;
            panelView.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Location = new Point(346, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(19, 18);
            btnClose.TabIndex = 6;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvSub
            // 
            dgvSub.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSub.Location = new Point(155, 67);
            dgvSub.Name = "dgvSub";
            dgvSub.Size = new Size(210, 205);
            dgvSub.TabIndex = 5;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetails.Location = new Point(18, 96);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(90, 90);
            lblDetails.TabIndex = 4;
            lblDetails.Text = "<Name\r\nEmail\r\nPhone\r\nHireDate\r\nDepartment\r\nSpecialization>";
            // 
            // pbTeacherPP
            // 
            pbTeacherPP.Image = (Image)resources.GetObject("pbTeacherPP.Image");
            pbTeacherPP.Location = new Point(18, 19);
            pbTeacherPP.Margin = new Padding(3, 2, 3, 2);
            pbTeacherPP.Name = "pbTeacherPP";
            pbTeacherPP.Size = new Size(49, 36);
            pbTeacherPP.SizeMode = PictureBoxSizeMode.Zoom;
            pbTeacherPP.TabIndex = 3;
            pbTeacherPP.TabStop = false;
            // 
            // lblTeacherDetails
            // 
            lblTeacherDetails.AutoSize = true;
            lblTeacherDetails.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeacherDetails.Location = new Point(139, 28);
            lblTeacherDetails.Name = "lblTeacherDetails";
            lblTeacherDetails.Size = new Size(110, 17);
            lblTeacherDetails.TabIndex = 2;
            lblTeacherDetails.Text = "Teacher Details";
            // 
            // Teacheruc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(panelTeacher);
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
            Controls.Add(panelView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Teacheruc";
            Size = new Size(631, 405);
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
        private Label lblDetails;
        private DataGridView dgvSub;
        private Button btnClose;
    }
}
