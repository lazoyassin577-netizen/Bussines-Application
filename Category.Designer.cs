namespace MyProject
{
    partial class Category
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCategoryID = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(429, 1077);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(490, 95);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(958, 1077);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(490, 95);
            button2.TabIndex = 0;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1512, 1077);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(490, 95);
            button3.TabIndex = 0;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1879, 138);
            button4.Margin = new Padding(5, 6, 5, 6);
            button4.Name = "button4";
            button4.Size = new Size(293, 62);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(85, 129);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 1;
            label1.Text = "CategoryID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(85, 209);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(85, 304);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 1;
            label3.Text = "Description";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(214, 129);
            txtCategoryID.Margin = new Padding(5, 6, 5, 6);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(257, 34);
            txtCategoryID.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(183, 209);
            txtTitle.Margin = new Padding(5, 6, 5, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(257, 34);
            txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(220, 304);
            txtDescription.Margin = new Padding(5, 6, 5, 6);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(251, 126);
            txtDescription.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            btnAdd.Location = new Point(295, 647);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(198, 62);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            btnUpdate.Location = new Point(549, 647);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(198, 62);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            btnDelete.Location = new Point(795, 647);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(198, 62);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            btnSearch.Location = new Point(795, 123);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(142, 34);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(529, 123);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(257, 34);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(529, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 459);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(txtSearch);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Category";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Category";
            Load += Category_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCategoryID;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
    }
}