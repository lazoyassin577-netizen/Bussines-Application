using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyProject
{
    public partial class ChangePasswordForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-RLKUK9C\SQLEXPRESS;Initial Catalog=Bad;Integrated Security=True;TrustServerCertificate=True;";

        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("تکایە هەموو خانەکان پڕبکەرەوە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Password = @Pass WHERE UserName = @User";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Pass", newPassword);
                        cmd.Parameters.AddWithValue("@User", username);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("وشەی نهێنی بە سەرکەوتوویی نوێکرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("هیچ بەکارهێنەرێک بەم ناوە نەدۆزرایەوە!", "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە گۆڕینی وشەی نهێنی: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}