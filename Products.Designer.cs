namespace MyProject
{
    partial class Products
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
            label7 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtSearch = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtAddedDate = new TextBox();
            txtAddedBy = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(131, 76);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(116, 134);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(86, 205);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 0;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(66, 282);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 0;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(83, 358);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 0;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(62, 409);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 0;
            label6.Text = "Added Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(65, 477);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 0;
            label7.Text = "Added By";
            // 
            // txtID
            // 
            txtID.Location = new Point(185, 81);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(223, 23);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 136);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 23);
            txtName.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(497, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 23);
            txtSearch.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(185, 282);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(223, 23);
            txtDescription.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(185, 358);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(223, 23);
            txtQuantity.TabIndex = 1;
            // 
            // txtAddedDate
            // 
            txtAddedDate.Location = new Point(185, 409);
            txtAddedDate.Name = "txtAddedDate";
            txtAddedDate.Size = new Size(223, 23);
            txtAddedDate.TabIndex = 1;
            // 
            // txtAddedBy
            // 
            txtAddedBy.Location = new Point(185, 482);
            txtAddedBy.Name = "txtAddedBy";
            txtAddedBy.Size = new Size(223, 23);
            txtAddedBy.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Orange;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(773, 71);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(624, 628);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 60);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(845, 628);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 60);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Orange;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1064, 628);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(497, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 465);
            dataGridView1.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(185, 205);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(222, 23);
            cmbCategory.TabIndex = 4;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 789);
            Controls.Add(cmbCategory);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtAddedBy);
            Controls.Add(txtAddedDate);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtSearch);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Products";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Products";
            Load += Products_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label7;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtSearch;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtAddedDate;
        private TextBox txtAddedBy;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private ComboBox cmbCategory;
    }
}