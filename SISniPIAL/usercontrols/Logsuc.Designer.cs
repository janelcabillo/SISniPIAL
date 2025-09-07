namespace SISniPIAL.forms
{
    partial class Logsuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logsuc));
            dgvLogs = new DataGridView();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogs.BackgroundColor = SystemColors.ControlDarkDark;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(3, 56);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new Size(715, 481);
            dgvLogs.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(46, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search:";
            txtSearch.Size = new Size(184, 25);
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
            pbSearch.TabIndex = 4;
            pbSearch.TabStop = false;
            // 
            // Logsuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(pbSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvLogs);
            Name = "Logsuc";
            Size = new Size(721, 540);
            Load += Logsuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLogs;
        private TextBox txtSearch;
        private PictureBox pbSearch;
    }
}
