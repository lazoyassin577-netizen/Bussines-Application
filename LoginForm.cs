using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyProject
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-RLKUK9C\SQLEXPRESS;Initial Catalog=Bad;Integrated Security=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object? sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            chkShowPassword.Checked = false;

            if (cmbUserType.Items.Count == 0)
            {
                cmbUserType.Items.Add("Administrator");
                cmbUserType.Items.Add("User");
            }
            cmbUserType.SelectedIndex = 0;
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkForgotPassword_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordForm forgotForm = new ChangePasswordForm();
            forgotForm.ShowDialog();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userType = cmbUserType.SelectedItem != null ? cmbUserType.SelectedItem.ToString()! : "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("تکایە ناوی بەکارهێنەر و وشەی نهێنی بنووسە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(userType))
            {
                MessageBox.Show("تکایە جۆری بەکارهێنەر (User Type) دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT COUNT(*) FROM Users 
                                     WHERE UserName = @User AND Password = @Pass AND UserType = @Type";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", username);
                        cmd.Parameters.AddWithValue("@Pass", password);
                        cmd.Parameters.AddWithValue("@Type", userType);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("چوونەژوورەوە سەرکەوتوو بوو!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();

                            if (userType == "Administrator")
                            {
                                AdminDashboard adminDashboard = new AdminDashboard(username);
                                adminDashboard.FormClosed += (s, args) => Application.Exit();
                                adminDashboard.Show();
                            }
                            else if (userType == "User")
                            {
                                Users userForm = new Users();
                                userForm.FormClosed += (s, args) => Application.Exit();
                                userForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ناوی بەکارهێنەر، وشەی نهێنی یان جۆری ئەکاونتەکە هەڵەیە!", "هەڵەی چوونەژوورەوە", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە پەیوەندی داتابەیس: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}