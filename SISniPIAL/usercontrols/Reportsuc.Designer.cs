namespace SISniPIAL.forms
{
    partial class Reportsuc
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
            btnStudent = new Button();
            btnTeacher = new Button();
            btnSubject = new Button();
            panelReport = new Panel();
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(13, 96);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(94, 29);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeacher.Location = new Point(13, 247);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new Size(94, 29);
            btnTeacher.TabIndex = 1;
            btnTeacher.Text = "Teacher";
            btnTeacher.UseVisualStyleBackColor = true;
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnSubject
            // 
            btnSubject.FlatStyle = FlatStyle.Flat;
            btnSubject.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubject.Location = new Point(13, 409);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(94, 29);
            btnSubject.TabIndex = 2;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            btnSubject.Click += btnSubject_Click;
            // 
            // panelReport
            // 
            panelReport.BackColor = Color.Gray;
            panelReport.Location = new Point(122, 17);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(584, 510);
            panelReport.TabIndex = 3;
            // 
            // Reportsuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(panelReport);
            Controls.Add(btnSubject);
            Controls.Add(btnTeacher);
            Controls.Add(btnStudent);
            Name = "Reportsuc";
            Size = new Size(721, 540);
            Load += Reportsuc_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudent;
        private Button btnTeacher;
        private Button btnSubject;
        private Panel panelReport;
    }
}
