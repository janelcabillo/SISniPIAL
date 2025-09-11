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
            txtUnits = new TextBox();
            txtSubjectName = new TextBox();
            lblUnits = new Label();
            lblSubjectName = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            lblEnrollDate = new Label();
            txtSubjectCode = new TextBox();
            lblAddSubject = new Label();
            lblSubjectCount = new Label();
            nudUnits = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnits).BeginInit();
            SuspendLayout();
            // 
            // dgvSubject
            // 
            dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubject.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(3, 42);
            dgvSubject.Margin = new Padding(3, 2, 3, 2);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.Size = new Size(626, 299);
            dgvSubject.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(40, 10);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(162, 23);
            txtSearch.TabIndex = 3;
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
            pbSearch.TabIndex = 4;
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
            btnUpdate.Location = new Point(264, 354);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 39);
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
            btnDelete.Location = new Point(494, 354);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 39);
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
            panelSubject.Location = new Point(276, 0);
            panelSubject.Margin = new Padding(3, 2, 3, 2);
            panelSubject.Name = "panelSubject";
            panelSubject.Size = new Size(354, 405);
            panelSubject.TabIndex = 10;
            panelSubject.Visible = false;
            // 
            // txtUnits
            // 
            txtUnits.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnits.Location = new Point(159, 276);
            txtUnits.Name = "txtUnits";
            txtUnits.Size = new Size(54, 25);
            txtUnits.TabIndex = 18;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubjectName.Location = new Point(139, 150);
            txtSubjectName.Margin = new Padding(3, 2, 3, 2);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(180, 21);
            txtSubjectName.TabIndex = 17;
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnits.Location = new Point(36, 212);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(42, 16);
            lblUnits.TabIndex = 16;
            lblUnits.Text = "Units:";
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(36, 154);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(98, 16);
            lblSubjectName.TabIndex = 15;
            lblSubjectName.Text = "Subject Name:";
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
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnrollDate.Location = new Point(36, 90);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(96, 16);
            lblEnrollDate.TabIndex = 10;
            lblEnrollDate.Text = "Subject Code:";
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubjectCode.Location = new Point(139, 86);
            txtSubjectCode.Margin = new Padding(3, 2, 3, 2);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(180, 21);
            txtSubjectCode.TabIndex = 6;
            // 
            // lblAddSubject
            // 
            lblAddSubject.Dock = DockStyle.Top;
            lblAddSubject.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddSubject.Location = new Point(0, 0);
            lblAddSubject.Name = "lblAddSubject";
            lblAddSubject.Size = new Size(354, 40);
            lblAddSubject.TabIndex = 0;
            lblAddSubject.Text = "Add Subject";
            lblAddSubject.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubjectCount
            // 
            lblSubjectCount.AutoSize = true;
            lblSubjectCount.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectCount.Location = new Point(222, 15);
            lblSubjectCount.Name = "lblSubjectCount";
            lblSubjectCount.Size = new Size(41, 15);
            lblSubjectCount.TabIndex = 11;
            lblSubjectCount.Text = "label1";
            // 
            // nudUnits
            // 
            nudUnits.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudUnits.Location = new Point(139, 207);
            nudUnits.Margin = new Padding(3, 2, 3, 2);
            nudUnits.Name = "nudUnits";
            nudUnits.Size = new Size(105, 21);
            nudUnits.TabIndex = 18;
            // 
            // Subjectuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(lblSubjectCount);
            Controls.Add(panelSubject);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvSubject);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Subjectuc";
            Size = new Size(631, 405);
            Load += Subjectuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            panelSubject.ResumeLayout(false);
            panelSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUnits).EndInit();
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
    }
}
