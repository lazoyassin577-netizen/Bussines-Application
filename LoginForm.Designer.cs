namespace MyProject
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnCancel = new Button();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkShowPassword = new CheckBox();
            cmbUserType = new ComboBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            lnkForgotPassword = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            btnLogin.Location = new Point(64, 446);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(433, 73);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.Location = new Point(60, 529);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(437, 68);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(118, 112);
            txtUserName.Margin = new Padding(5);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(361, 34);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(118, 82);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(117, 193);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            chkShowPassword.Location = new Point(118, 287);
            chkShowPassword.Margin = new Padding(5);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(125, 23);
            chkShowPassword.TabIndex = 3;
            chkShowPassword.Text = "ShowPassword";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.Click += chkShowPassword_CheckedChanged;
            // 
            // cmbUserType
            // 
            cmbUserType.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Location = new Point(118, 382);
            cmbUserType.Margin = new Padding(5);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(257, 29);
            cmbUserType.TabIndex = 5;
            cmbUserType.Text = "User Type";
            cmbUserType.Click += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(118, 223);
            txtPassword.Margin = new Padding(5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(354, 32);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-6, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 63);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(20, 15);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 2;
            label4.Text = "Login Form";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Location = new Point(-4, 663);
            panel2.Name = "panel2";
            panel2.Size = new Size(811, 47);
            panel2.TabIndex = 7;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lnkForgotPassword.Location = new Point(62, 605);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(163, 25);
            lnkForgotPassword.TabIndex = 8;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forget Password ";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 707);
            Controls.Add(lnkForgotPassword);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cmbUserType);
            Controls.Add(chkShowPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private CheckBox chkShowPassword;
        private ComboBox cmbUserType;
        private TextBox txtPassword;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private LinkLabel lnkForgotPassword;
    }
}