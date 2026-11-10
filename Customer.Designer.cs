namespace MyProject
{
    partial class Customer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCustomerID = new TextBox();
            txtName = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            cmbType = new ComboBox();
            txtSearch = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(91, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(91, 188);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 0;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(91, 261);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(91, 345);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 0;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(91, 428);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(91, 522);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 0;
            label6.Text = "Address";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(199, 122);
            txtCustomerID.Margin = new Padding(4);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(313, 29);
            txtCustomerID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 261);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(313, 29);
            txtName.TabIndex = 1;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(187, 345);
            txtContact.Margin = new Padding(4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(313, 29);
            txtContact.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 428);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 29);
            txtEmail.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(182, 522);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(313, 29);
            txtAddress.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(520, 169);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(904, 382);
            dataGridView1.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkTurquoise;
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.ForeColor = Color.PapayaWhip;
            btnAdd.Location = new Point(386, 637);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(241, 62);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkTurquoise;
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            btnUpdate.ForeColor = Color.PapayaWhip;
            btnUpdate.Location = new Point(659, 637);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(241, 62);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkTurquoise;
            btnDelete.DialogResult = DialogResult.OK;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.ForeColor = Color.PapayaWhip;
            btnDelete.Location = new Point(939, 637);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(241, 62);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkTurquoise;
            btnSearch.DialogResult = DialogResult.OK;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSearch.ForeColor = Color.PapayaWhip;
            btnSearch.Location = new Point(930, 103);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(173, 45);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(187, 188);
            cmbType.Margin = new Padding(4);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(325, 29);
            cmbType.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1111, 119);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(313, 29);
            txtSearch.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1933, 47);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(573, 12);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 0;
            label7.Text = "Customer";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Location = new Point(0, 1019);
            panel2.Name = "panel2";
            panel2.Size = new Size(1933, 47);
            panel2.TabIndex = 5;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cmbType);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(txtSearch);
            Controls.Add(txtCustomerID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customer";
            TransparencyKey = Color.FromArgb(192, 0, 0);
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCustomerID;
        private TextBox txtName;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private ComboBox cmbType;
        private TextBox txtSearch;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
    }
}