namespace MyProject
{
    partial class AdminDashboard
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
            menuStrip1 = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            purchasesSalesToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            lblLoggedInUser = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, categoryToolStripMenuItem, productToolStripMenuItem, inventoryToolStripMenuItem, transactionToolStripMenuItem, purchasesSalesToolStripMenuItem, customerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1915, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(74, 32);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(110, 32);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(98, 32);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(114, 32);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(136, 32);
            transactionToolStripMenuItem.Text = "Transaction";
            // 
            // purchasesSalesToolStripMenuItem
            // 
            purchasesSalesToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            purchasesSalesToolStripMenuItem.Name = "purchasesSalesToolStripMenuItem";
            purchasesSalesToolStripMenuItem.Size = new Size(171, 32);
            purchasesSalesToolStripMenuItem.Text = "Purchases,Sales";
            purchasesSalesToolStripMenuItem.Click += purchasesSalesToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(114, 32);
            customerToolStripMenuItem.Text = "Customer";
            customerToolStripMenuItem.Click += customerToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(128, 117);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1750, 830);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            lblLoggedInUser.ForeColor = Color.DodgerBlue;
            lblLoggedInUser.Location = new Point(61, 53);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(65, 25);
            lblLoggedInUser.TabIndex = 3;
            lblLoggedInUser.Text = "label1";
            lblLoggedInUser.Click += lblLoggedInUser_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1915, 996);
            Controls.Add(lblLoggedInUser);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "A";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private Panel mainPanel;
        private ToolStripMenuItem purchasesSalesToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private Label lblLoggedInUser;
    }
}