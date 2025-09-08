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
            lblAddStudent = new Label();
            lblCountStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelStudent.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(3, 42);
            dgvStudent.Margin = new Padding(3, 2, 3, 2);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(626, 299);
            dgvStudent.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(40, 10);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(162, 23);
            txtSearch.TabIndex = 1;
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
            pbSearch.TabIndex = 2;
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
            btnUpdate.Location = new Point(264, 354);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 39);
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
            btnDelete.Location = new Point(494, 354);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 39);
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
            btnView.Location = new Point(486, 10);
            btnView.Margin = new Padding(3, 2, 3, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(32, 20);
            btnView.TabIndex = 6;
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
            btnAssign.TabIndex = 7;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // panelStudent
            // 
            panelStudent.BackColor = Color.DimGray;
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
            panelStudent.Controls.Add(lblAddStudent);
            panelStudent.Location = new Point(277, 0);
            panelStudent.Margin = new Padding(3, 2, 3, 2);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(354, 405);
            panelStudent.TabIndex = 9;
            panelStudent.Visible = false;
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
            txtStatus.Location = new Point(242, 292);
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
            lblStatus.Location = new Point(190, 294);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status:";
            // 
            // dtpEnrollDate
            // 
            dtpEnrollDate.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollDate.Location = new Point(119, 244);
            dtpEnrollDate.Margin = new Padding(3, 2, 3, 2);
            dtpEnrollDate.Name = "dtpEnrollDate";
            dtpEnrollDate.Size = new Size(209, 23);
            dtpEnrollDate.TabIndex = 11;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollDate.Location = new Point(36, 250);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(68, 15);
            lblEnrollDate.TabIndex = 10;
            lblEnrollDate.Text = "EnrollDate:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(36, 294);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(51, 15);
            lblGender.TabIndex = 9;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(94, 292);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(74, 23);
            cmbGender.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(36, 197);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address:";
            txtAddress.Size = new Size(292, 21);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(195, 156);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone:";
            txtPhone.Size = new Size(133, 21);
            txtPhone.TabIndex = 6;
            // 
            // dtpDOB
            // 
            dtpDOB.CalendarFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(119, 110);
            dtpDOB.Margin = new Padding(3, 2, 3, 2);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(209, 23);
            dtpDOB.TabIndex = 5;
            // 
            // lbldob
            // 
            lbldob.AutoSize = true;
            lbldob.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldob.Location = new Point(36, 116);
            lbldob.Name = "lbldob";
            lbldob.Size = new Size(73, 15);
            lbldob.TabIndex = 4;
            lbldob.Text = "DateOfBirth:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(36, 156);
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
            // lblAddStudent
            // 
            lblAddStudent.Dock = DockStyle.Top;
            lblAddStudent.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStudent.Location = new Point(0, 0);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(354, 40);
            lblAddStudent.TabIndex = 0;
            lblAddStudent.Text = "Add Student";
            lblAddStudent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCountStudent
            // 
            lblCountStudent.AutoSize = true;
            lblCountStudent.Location = new Point(222, 16);
            lblCountStudent.Name = "lblCountStudent";
            lblCountStudent.Size = new Size(0, 15);
            lblCountStudent.TabIndex = 10;
            // 
            // Studentuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(lblCountStudent);
            Controls.Add(panelStudent);
            Controls.Add(btnAssign);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudent);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Studentuc";
            Size = new Size(631, 405);
            Load += Studentuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
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
        private Label lblCountStudent;
    }
}
