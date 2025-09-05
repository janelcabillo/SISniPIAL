namespace SISniPIAL.forms
{
    partial class ForgotPassuc
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
            lblForgotPass = new Label();
            txtEmail = new TextBox();
            btnSendCode = new Button();
            btnBack = new Button();
            txtVerificationCode = new TextBox();
            btnVerify = new Button();
            panelResetPass = new Panel();
            btnCancel = new Button();
            btnReset = new Button();
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            lblCreateNewPass = new Label();
            panelResetPass.SuspendLayout();
            SuspendLayout();
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblForgotPass.Location = new Point(55, 31);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(238, 32);
            lblForgotPass.TabIndex = 1;
            lblForgotPass.Text = "Forgot Password?";
            lblForgotPass.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(43, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Email:";
            txtEmail.Size = new Size(266, 25);
            txtEmail.TabIndex = 2;
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.SteelBlue;
            btnSendCode.FlatStyle = FlatStyle.Popup;
            btnSendCode.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendCode.Location = new Point(43, 139);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(266, 41);
            btnSendCode.TabIndex = 3;
            btnSendCode.Text = "Send Code";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(43, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(266, 41);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back To Login";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtVerificationCode
            // 
            txtVerificationCode.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVerificationCode.Location = new Point(43, 235);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.PlaceholderText = "xxxxxx";
            txtVerificationCode.Size = new Size(266, 25);
            txtVerificationCode.TabIndex = 5;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.SteelBlue;
            btnVerify.FlatStyle = FlatStyle.Popup;
            btnVerify.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerify.Location = new Point(43, 278);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(266, 41);
            btnVerify.TabIndex = 6;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // panelResetPass
            // 
            panelResetPass.Controls.Add(btnCancel);
            panelResetPass.Controls.Add(btnReset);
            panelResetPass.Controls.Add(txtConfirmPass);
            panelResetPass.Controls.Add(txtNewPass);
            panelResetPass.Controls.Add(lblCreateNewPass);
            panelResetPass.Location = new Point(0, 0);
            panelResetPass.Name = "panelResetPass";
            panelResetPass.Size = new Size(355, 475);
            panelResetPass.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gray;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(57, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(252, 54);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.SteelBlue;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(57, 265);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(252, 54);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPass.Location = new Point(55, 186);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PlaceholderText = "Confirm Password:";
            txtConfirmPass.Size = new Size(254, 27);
            txtConfirmPass.TabIndex = 2;
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPass.Location = new Point(55, 129);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PlaceholderText = "New Password:";
            txtNewPass.Size = new Size(254, 27);
            txtNewPass.TabIndex = 1;
            // 
            // lblCreateNewPass
            // 
            lblCreateNewPass.AutoSize = true;
            lblCreateNewPass.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateNewPass.Location = new Point(57, 52);
            lblCreateNewPass.Name = "lblCreateNewPass";
            lblCreateNewPass.RightToLeft = RightToLeft.No;
            lblCreateNewPass.Size = new Size(252, 28);
            lblCreateNewPass.TabIndex = 0;
            lblCreateNewPass.Text = "Create New Password";
            // 
            // ForgotPassuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(panelResetPass);
            Controls.Add(btnVerify);
            Controls.Add(txtVerificationCode);
            Controls.Add(btnBack);
            Controls.Add(btnSendCode);
            Controls.Add(txtEmail);
            Controls.Add(lblForgotPass);
            Name = "ForgotPassuc";
            Size = new Size(355, 475);
            panelResetPass.ResumeLayout(false);
            panelResetPass.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblForgotPass;
        private TextBox txtEmail;
        private Button btnSendCode;
        private Button btnBack;
        private TextBox txtVerificationCode;
        private Button btnVerify;
        private Panel panelResetPass;
        private Button btnCancel;
        private Button btnReset;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private Label lblCreateNewPass;
    }
}
