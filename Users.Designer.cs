namespace MyProject
{
    partial class Users
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
            l = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtUserID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            dataGridView1 = new DataGridView();
            cmbGender = new ComboBox();
            cmbUserType = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblClose = new LinkLabel();
            panel1 = new Panel();
            label11 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            l.Location = new Point(40, 123);
            l.Name = "l";
            l.Size = new Size(61, 21);
            l.TabIndex = 0;
            l.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 178);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 0;
            label2.Text = "FirstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(24, 224);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 0;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 274);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(24, 326);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 0;
            label5.Text = "User Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(24, 389);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 0;
            label6.Text = "PassWord";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(21, 440);
            label7.Name = "label7";
            label7.Size = new Size(148, 21);
            label7.TabIndex = 0;
            label7.Text = "Confirm Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(40, 493);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 0;
            label8.Text = "Contact";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(39, 554);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 0;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(48, 602);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 0;
            label10.Text = "Address";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(157, 125);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(345, 23);
            txtUserID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(153, 178);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(345, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(152, 222);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(345, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(152, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(345, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(153, 328);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(345, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(152, 389);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(346, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(175, 440);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(322, 23);
            txtConfirmPassword.TabIndex = 1;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(157, 493);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(340, 23);
            txtContact.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(157, 602);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(345, 77);
            txtAddress.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(602, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(768, 546);
            dataGridView1.TabIndex = 2;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(157, 537);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(345, 23);
            cmbGender.TabIndex = 3;
            // 
            // cmbUserType
            // 
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Location = new Point(152, 703);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(350, 23);
            cmbUserType.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 705);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "User Type";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(602, 125);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search Here";
            txtSearch.Size = new Size(421, 49);
            txtSearch.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Aqua;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdd.Location = new Point(179, 767);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(233, 60);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Aqua;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnUpdate.Location = new Point(480, 767);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(233, 60);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Aqua;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDelete.Location = new Point(740, 767);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(233, 60);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblClose.LinkColor = Color.Black;
            lblClose.Location = new Point(1314, 18);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(62, 28);
            lblClose.TabIndex = 5;
            lblClose.TabStop = true;
            lblClose.Text = "Close";
            lblClose.Click += lblClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lblClose);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1439, 83);
            panel1.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label11.ForeColor = Color.Aqua;
            label11.Location = new Point(604, 28);
            label11.Name = "label11";
            label11.Size = new Size(63, 28);
            label11.TabIndex = 6;
            label11.Text = "Users";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(-10, 840);
            panel2.Name = "panel2";
            panel2.Size = new Size(1515, 50);
            panel2.TabIndex = 7;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 884);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbUserType);
            Controls.Add(cmbGender);
            Controls.Add(dataGridView1);
            Controls.Add(txtAddress);
            Controls.Add(txtContact);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtSearch);
            Controls.Add(txtUserID);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(l);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtUserID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtContact;
        private TextBox txtAddress;
        private DataGridView dataGridView1;
        private ComboBox cmbGender;
        private ComboBox cmbUserType;
        private Label label1;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private LinkLabel lblClose;
        private Panel panel1;
        private Panel panel2;
        private Label label11;
    }
}
