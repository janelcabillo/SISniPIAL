namespace SISniPIAL.forms
{
    partial class Subjectuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjectuc));
            dgvSubject = new DataGridView();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelSubject = new Panel();
            nudUnits = new NumericUpDown();
            txtSubjectName = new TextBox();
            lblUnits = new Label();
            lblSubjectName = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            lblEnrollDate = new Label();
            txtSubjectCode = new TextBox();
            lblAddSubject = new Label();
            btnView = new Button();
            lblSubjectCount = new Label();
            panelView = new Panel();
            rtbDetails = new RichTextBox();
            btnClose = new Button();
            dgvInfo = new DataGridView();
            lblSubjectDetails = new Label();
            panelListStudents = new Panel();
            dgvStudents = new DataGridView();
            btnBackButton = new Button();
            lblStudentsEnrolled = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnits).BeginInit();
            panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).BeginInit();
            panelListStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvSubject
            // 
            dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(3, 56);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.Size = new Size(715, 399);
            dgvSubject.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(46, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(185, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pbSearch
            // 
            pbSearch.Image = (Image)resources.GetObject("pbSearch.Image");
            pbSearch.Location = new Point(14, 13);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(26, 28);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 4;
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
            btnAddNew.TabIndex = 5;
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
            btnUpdate.TabIndex = 6;
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
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelSubject
            // 
            panelSubject.BackColor = Color.DimGray;
            panelSubject.Controls.Add(nudUnits);
            panelSubject.Controls.Add(txtSubjectName);
            panelSubject.Controls.Add(lblUnits);
            panelSubject.Controls.Add(lblSubjectName);
            panelSubject.Controls.Add(btnCancel);
            panelSubject.Controls.Add(btnSave);
            panelSubject.Controls.Add(lblEnrollDate);
            panelSubject.Controls.Add(txtSubjectCode);
            panelSubject.Controls.Add(lblAddSubject);
            panelSubject.Location = new Point(315, 0);
            panelSubject.Name = "panelSubject";
            panelSubject.Size = new Size(405, 540);
            panelSubject.TabIndex = 10;
            panelSubject.Visible = false;
            // 
            // nudUnits
            // 
            nudUnits.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudUnits.Location = new Point(159, 276);
            nudUnits.Name = "nudUnits";
            nudUnits.Size = new Size(120, 25);
            nudUnits.TabIndex = 18;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubjectName.Location = new Point(159, 200);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(205, 25);
            txtSubjectName.TabIndex = 17;
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnits.Location = new Point(41, 283);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(50, 19);
            lblUnits.TabIndex = 16;
            lblUnits.Text = "Units:";
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(41, 205);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(115, 19);
            lblSubjectName.TabIndex = 15;
            lblSubjectName.Text = "Subject Name:";
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
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollDate.Location = new Point(41, 120);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(112, 19);
            lblEnrollDate.TabIndex = 10;
            lblEnrollDate.Text = "Subject Code:";
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubjectCode.Location = new Point(159, 115);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(205, 25);
            txtSubjectCode.TabIndex = 6;
            // 
            // lblAddSubject
            // 
            lblAddSubject.Dock = DockStyle.Top;
            lblAddSubject.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSubject.Location = new Point(0, 0);
            lblAddSubject.Name = "lblAddSubject";
            lblAddSubject.Size = new Size(405, 53);
            lblAddSubject.TabIndex = 0;
            lblAddSubject.Text = "Add Subject";
            lblAddSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnView
            // 
            btnView.BackColor = Color.White;
            btnView.BackgroundImage = (Image)resources.GetObject("btnView.BackgroundImage");
            btnView.BackgroundImageLayout = ImageLayout.Zoom;
            btnView.FlatStyle = FlatStyle.Popup;
            btnView.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.Location = new Point(654, 13);
            btnView.Name = "btnView";
            btnView.Size = new Size(37, 27);
            btnView.TabIndex = 19;
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // lblSubjectCount
            // 
            lblSubjectCount.AutoSize = true;
            lblSubjectCount.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectCount.Location = new Point(254, 20);
            lblSubjectCount.Name = "lblSubjectCount";
            lblSubjectCount.Size = new Size(46, 17);
            lblSubjectCount.TabIndex = 11;
            lblSubjectCount.Text = "label1";
            // 
            // panelView
            // 
            panelView.BackColor = Color.LightGray;
            panelView.Controls.Add(rtbDetails);
            panelView.Controls.Add(btnClose);
            panelView.Controls.Add(dgvInfo);
            panelView.Controls.Add(lblSubjectDetails);
            panelView.Location = new Point(143, 57);
            panelView.Margin = new Padding(3, 4, 3, 4);
            panelView.Name = "panelView";
            panelView.Size = new Size(442, 397);
            panelView.TabIndex = 20;
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
            rtbDetails.TabIndex = 6;
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
            btnClose.TabIndex = 5;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvInfo
            // 
            dgvInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfo.Location = new Point(202, 89);
            dgvInfo.Margin = new Padding(3, 4, 3, 4);
            dgvInfo.Name = "dgvInfo";
            dgvInfo.RowHeadersWidth = 51;
            dgvInfo.Size = new Size(215, 273);
            dgvInfo.TabIndex = 4;
            dgvInfo.CellContentClick += dgvInfo_CellContentClick;
            // 
            // lblSubjectDetails
            // 
            lblSubjectDetails.AutoSize = true;
            lblSubjectDetails.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubjectDetails.Location = new Point(159, 37);
            lblSubjectDetails.Name = "lblSubjectDetails";
            lblSubjectDetails.Size = new Size(136, 22);
            lblSubjectDetails.TabIndex = 2;
            lblSubjectDetails.Text = "Subject Details";
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
            panelListStudents.TabIndex = 9;
            panelListStudents.Visible = false;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(9, 53);
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
            btnBackButton.Location = new Point(9, 5);
            btnBackButton.Name = "btnBackButton";
            btnBackButton.Size = new Size(29, 24);
            btnBackButton.TabIndex = 1;
            btnBackButton.UseVisualStyleBackColor = true;
            btnBackButton.Click += btnBackButton_Click;
            // 
            // lblStudentsEnrolled
            // 
            lblStudentsEnrolled.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsEnrolled.Location = new Point(43, 0);
            lblStudentsEnrolled.Name = "lblStudentsEnrolled";
            lblStudentsEnrolled.Size = new Size(159, 39);
            lblStudentsEnrolled.TabIndex = 0;
            lblStudentsEnrolled.Text = "Students Enrolled";
            lblStudentsEnrolled.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Subjectuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(btnView);
            Controls.Add(panelListStudents);
            Controls.Add(panelView);
            Controls.Add(lblSubjectCount);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvSubject);
            Controls.Add(panelSubject);
            Name = "Subjectuc";
            Size = new Size(721, 540);
            Load += Subjectuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            panelSubject.ResumeLayout(false);
            panelSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnits).EndInit();
            panelView.ResumeLayout(false);
            panelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInfo).EndInit();
            panelListStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSubject;
        private TextBox txtSearch;
        private PictureBox pbSearch;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelSubject;
        private Button btnCancel;
        private Button btnSave;
        private Label lblEnrollDate;
        private Label lblAddSubject;
        private TextBox txtSubjectName;
        private Label lblUnits;
        private Label lblSubjectName;
        private TextBox txtSubjectCode;
        private Label lblSubjectCount;
        private NumericUpDown nudUnits;
        private Button btnView;
        private Panel panelView;
        private RichTextBox rtbDetails;
        private Button btnClose;
        private DataGridView dgvInfo;
        private Label lblSubjectDetails;
        private Panel panelListStudents;
        private DataGridView dgvStudents;
        private Button btnBackButton;
        private Label lblStudentsEnrolled;
    }
}
