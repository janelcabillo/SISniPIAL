namespace SISniPIAL
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            panelLoginForm = new Panel();
            btnLogin = new Button();
            lnklblForgotPass = new LinkLabel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblLogin = new Label();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-19, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLoginForm
            // 
            panelLoginForm.BorderStyle = BorderStyle.Fixed3D;
            panelLoginForm.Controls.Add(btnLogin);
            panelLoginForm.Controls.Add(lnklblForgotPass);
            panelLoginForm.Controls.Add(txtPassword);
            panelLoginForm.Controls.Add(txtUsername);
            panelLoginForm.Controls.Add(lblLogin);
            panelLoginForm.Controls.Add(lblWelcome);
            panelLoginForm.Location = new Point(595, 46);
            panelLoginForm.Name = "panelLoginForm";
            panelLoginForm.Size = new Size(355, 475);
            panelLoginForm.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(113, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 59);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnklblForgotPass
            // 
            lnklblForgotPass.AutoSize = true;
            lnklblForgotPass.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnklblForgotPass.Location = new Point(176, 272);
            lnklblForgotPass.Name = "lnklblForgotPass";
            lnklblForgotPass.Size = new Size(128, 17);
            lnklblForgotPass.TabIndex = 4;
            lnklblForgotPass.TabStop = true;
            lnklblForgotPass.Text = "Forgot Password?";
            lnklblForgotPass.LinkClicked += lnklblForgotPass_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(47, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password:";
            txtPassword.Size = new Size(257, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(47, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username:";
            txtUsername.Size = new Size(257, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(113, 98);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(119, 26);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login now!";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(47, 46);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(257, 40);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to SIS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(993, 564);
            Controls.Add(panelLoginForm);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLoginForm.ResumeLayout(false);
            panelLoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panelLoginForm;
        private Label lblWelcome;
        private Label lblLogin;
        private Button btnLogin;
        private LinkLabel lnklblForgotPass;
        private TextBox txtPassword;
        private TextBox txtUsername;
    }
}
