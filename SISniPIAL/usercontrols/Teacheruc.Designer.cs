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
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelTeacher.SuspendLayout();
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
            // Teacheruc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(lblTeacherCount);
            Controls.Add(panelTeacher);
            Controls.Add(btnAssign);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvTeacher);
            Name = "Teacheruc";
            Size = new Size(721, 540);
            Load += Teacheruc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            panelTeacher.ResumeLayout(false);
            panelTeacher.PerformLayout();
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
    }
}
