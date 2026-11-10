namespace MyProject
{
    partial class PurchasesAndSales
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
            txtSearchPhone = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerAddress = new TextBox();
            btnSearchCustomer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnAddToCart = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnSaveTransaction = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtReturnAmount = new TextBox();
            txtPaidAmount = new TextBox();
            txtGrandTotal = new TextBox();
            txtDiscount = new TextBox();
            txtSubTotal = new TextBox();
            label16 = new Label();
            label17 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchPhone
            // 
            txtSearchPhone.Location = new Point(160, 60);
            txtSearchPhone.Name = "txtSearchPhone";
            txtSearchPhone.Size = new Size(116, 23);
            txtSearchPhone.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(160, 121);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(116, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(457, 125);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(373, 23);
            txtCustomerEmail.TabIndex = 0;
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(1037, 78);
            txtCustomerAddress.Multiline = true;
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(200, 70);
            txtCustomerAddress.TabIndex = 0;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.Brown;
            btnSearchCustomer.FlatStyle = FlatStyle.Popup;
            btnSearchCustomer.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSearchCustomer.ForeColor = SystemColors.ButtonFace;
            btnSearchCustomer.Location = new Point(313, 48);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(86, 43);
            btnSearchCustomer.TabIndex = 1;
            btnSearchCustomer.Text = "search";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(10, 58);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 2;
            label1.Text = "Search By Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(13, 119);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(390, 123);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(949, 127);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 2;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(19, 61);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 2;
            label5.Text = "ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(66, 59);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(53, 23);
            txtProductID.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(232, 57);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(197, 23);
            txtProductName.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(543, 57);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(164, 23);
            txtCategory.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(170, 57);
            label6.Name = "label6";
            label6.Size = new Size(56, 21);
            label6.TabIndex = 2;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(457, 57);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 2;
            label7.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(798, 55);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(86, 23);
            txtPrice.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(1010, 59);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(116, 23);
            txtQuantity.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(733, 61);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 2;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(927, 57);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 2;
            label9.Text = "Quantity";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.Brown;
            btnAddToCart.FlatStyle = FlatStyle.Popup;
            btnAddToCart.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAddToCart.ForeColor = SystemColors.ButtonFace;
            btnAddToCart.Location = new Point(1148, 51);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(89, 37);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(696, 459);
            dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(btnSaveTransaction);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtReturnAmount);
            panel1.Controls.Add(txtPaidAmount);
            panel1.Controls.Add(txtGrandTotal);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtSubTotal);
            panel1.Location = new Point(712, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 528);
            panel1.TabIndex = 5;
            // 
            // btnSaveTransaction
            // 
            btnSaveTransaction.BackColor = Color.Brown;
            btnSaveTransaction.FlatStyle = FlatStyle.Popup;
            btnSaveTransaction.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSaveTransaction.ForeColor = SystemColors.ButtonFace;
            btnSaveTransaction.Location = new Point(114, 423);
            btnSaveTransaction.Name = "btnSaveTransaction";
            btnSaveTransaction.Size = new Size(340, 48);
            btnSaveTransaction.TabIndex = 2;
            btnSaveTransaction.Text = "Save";
            btnSaveTransaction.UseVisualStyleBackColor = false;
            btnSaveTransaction.Click += btnSaveTransaction_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label15.Location = new Point(72, 340);
            label15.Name = "label15";
            label15.Size = new Size(156, 25);
            label15.TabIndex = 1;
            label15.Text = "Return Amount ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label14.Location = new Point(72, 285);
            label14.Name = "label14";
            label14.Size = new Size(129, 25);
            label14.TabIndex = 1;
            label14.Text = "Paid Amount";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label13.Location = new Point(72, 225);
            label13.Name = "label13";
            label13.Size = new Size(55, 25);
            label13.TabIndex = 1;
            label13.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.Location = new Point(72, 168);
            label12.Name = "label12";
            label12.Size = new Size(91, 25);
            label12.TabIndex = 1;
            label12.Text = "Discount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(72, 109);
            label11.Name = "label11";
            label11.Size = new Size(95, 25);
            label11.TabIndex = 1;
            label11.Text = "Sub Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label10.Location = new Point(13, 15);
            label10.Name = "label10";
            label10.Size = new Size(111, 25);
            label10.TabIndex = 0;
            label10.Text = "Calculation";
            // 
            // txtReturnAmount
            // 
            txtReturnAmount.Location = new Point(243, 340);
            txtReturnAmount.Name = "txtReturnAmount";
            txtReturnAmount.ReadOnly = true;
            txtReturnAmount.Size = new Size(116, 23);
            txtReturnAmount.TabIndex = 0;
            // 
            // txtPaidAmount
            // 
            txtPaidAmount.Location = new Point(243, 288);
            txtPaidAmount.Name = "txtPaidAmount";
            txtPaidAmount.ReadOnly = true;
            txtPaidAmount.Size = new Size(116, 23);
            txtPaidAmount.TabIndex = 0;
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(243, 225);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(116, 23);
            txtGrandTotal.TabIndex = 0;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(243, 163);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(116, 23);
            txtDiscount.TabIndex = 0;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(243, 104);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(116, 23);
            txtSubTotal.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 5);
            label16.Name = "label16";
            label16.Size = new Size(59, 15);
            label16.TabIndex = 6;
            label16.Text = "Customer";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 26);
            label17.Name = "label17";
            label17.Size = new Size(54, 15);
            label17.TabIndex = 6;
            label17.Text = "Products";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSearchCustomer);
            panel2.Controls.Add(txtCustomerAddress);
            panel2.Controls.Add(txtCustomerEmail);
            panel2.Controls.Add(txtCustomerName);
            panel2.Controls.Add(txtSearchPhone);
            panel2.Location = new Point(6, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1243, 168);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(label17);
            panel3.Controls.Add(btnAddToCart);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtQuantity);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(txtCategory);
            panel3.Controls.Add(txtProductName);
            panel3.Controls.Add(txtProductID);
            panel3.Location = new Point(6, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(1243, 132);
            panel3.TabIndex = 8;
            // 
            // PurchasesAndSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 884);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PurchasesAndSales";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            Load += PurchasesAndSales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearchPhone;
        private TextBox txtCustomerName;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerAddress;
        private Button btnSearchCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private Label label6;
        private Label label7;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label8;
        private Label label9;
        private Button btnAddToCart;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label10;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtReturnAmount;
        private TextBox txtPaidAmount;
        private TextBox txtGrandTotal;
        private TextBox txtDiscount;
        private TextBox txtSubTotal;
        private Label label16;
        private Label label17;
        private Panel panel2;
        private Panel panel3;
        private Button btnSaveTransaction;
    }
}