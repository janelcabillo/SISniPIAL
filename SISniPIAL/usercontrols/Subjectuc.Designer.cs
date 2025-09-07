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
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            panelSubject.SuspendLayout();
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
            txtSearch.Location = new Point(46, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(184, 27);
            txtSearch.TabIndex = 3;
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
            btnAddNew.Size = new Size(116, 52);
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
            btnUpdate.Size = new Size(116, 52);
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
            btnDelete.Location = new Point(564, 472);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 52);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panelSubject
            // 
            panelSubject.BackColor = Color.DimGray;
            panelSubject.Controls.Add(txtUnits);
            panelSubject.Controls.Add(txtSubjectName);
            panelSubject.Controls.Add(lblUnits);
            panelSubject.Controls.Add(lblSubjectName);
            panelSubject.Controls.Add(btnCancel);
            panelSubject.Controls.Add(btnSave);
            panelSubject.Controls.Add(lblEnrollDate);
            panelSubject.Controls.Add(txtSubjectCode);
            panelSubject.Controls.Add(lblAddSubject);
            panelSubject.Location = new Point(316, 0);
            panelSubject.Name = "panelSubject";
            panelSubject.Size = new Size(405, 540);
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
            txtSubjectName.Location = new Point(159, 200);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(205, 25);
            txtSubjectName.TabIndex = 17;
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnits.Location = new Point(41, 282);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(50, 19);
            lblUnits.TabIndex = 16;
            lblUnits.Text = "Units:";
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(41, 206);
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
            txtSubjectCode.Location = new Point(159, 114);
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
            // Subjectuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(panelSubject);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvSubject);
            Name = "Subjectuc";
            Size = new Size(721, 540);
            Load += Subjectuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            panelSubject.ResumeLayout(false);
            panelSubject.PerformLayout();
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
        private TextBox txtUnits;
        private TextBox txtSubjectName;
        private Label lblUnits;
        private Label lblSubjectName;
        private TextBox txtSubjectCode;
    }
}
