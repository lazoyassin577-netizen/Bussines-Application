namespace MyProject
{
    partial class ChangePasswordForm
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
            btnSave = new Button();
            label1 = new Label();
            txtUser = new TextBox();
            txtNewPass = new TextBox();
            label2 = new Label();
            btnCancel = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            btnSave.Location = new Point(161, 315);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(290, 58);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(64, 90);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(212, 90);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(352, 38);
            txtUser.TabIndex = 2;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(212, 170);
            txtNewPass.Multiline = true;
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(352, 45);
            txtNewPass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(64, 181);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "NewPassword";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.MenuHighlight;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            btnCancel.Location = new Point(212, 396);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(171, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-17, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 58);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(-8, 509);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 41);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Highlight;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(258, 17);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 0;
            label3.Text = "Forget Password";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            CancelButton = btnCancel;
            ClientSize = new Size(630, 548);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNewPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
           // Load += ChangePasswordForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtNewPass;
        private Label label2;
        private Button btnCancel;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
    }
}