using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyProject
{
    public partial class AdminDashboard : Form
    {
        private string loggedInUsername = "";

        // Constructor accepting the username string
        public AdminDashboard(string username = "Admin")
        {
            InitializeComponent();
            loggedInUsername = username;
        }



        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = $"User: {loggedInUsername}";
        }

        private void OpenChildForm(Form childForm)
        {
            mainPanel.Controls.Clear();

            childForm.TopLevel = false; // تەنها ئەمە وەک خاسیەت بە کۆد دەمێنێتەوە
            childForm.Dock = DockStyle.Fill; // بۆ ئەوەی فۆڕمی منداڵ لە ناو پەڕەی سەرەکی بگوازرێتەوە

            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void productToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string currentUsername = lblLoggedInUser.Text;
            OpenChildForm(new Products());

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users());
        }
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Category());
        }

        private void purchasesSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchasesAndSales());
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLoggedInUser_Click(object sender, EventArgs e)
        {

        }
    }
}
