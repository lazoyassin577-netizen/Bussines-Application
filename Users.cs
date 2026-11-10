using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MyProject
{
    public partial class Users : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-RLKUK9C\SQLEXPRESS;Initial Catalog=Bad;Integrated Security=True;TrustServerCertificate=True;";

        public Users()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellClick += dataGridView1_CellClick;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void Users_Load(object? sender, EventArgs e)
        {
            if (cmbGender.Items.Count == 0)
            {
                cmbGender.Items.Add("Male");
                cmbGender.Items.Add("Female");
            }
            cmbGender.SelectedIndex = 0;

            if (cmbUserType.Items.Count == 0)
            {
                cmbUserType.Items.Add("Administrator");
                cmbUserType.Items.Add("User");
            }
            cmbUserType.SelectedIndex = 0;

            LoadUsersData();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // پشکنینی ستانداردی فۆرماتی ئیمەیڵ (دەق + @ + دۆمەین + . + پاشگر)
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email.Trim(), pattern, RegexOptions.IgnoreCase);
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasLetter = Regex.IsMatch(password, @"[a-zA-Z]");
            bool hasDigit = Regex.IsMatch(password, @"[0-9]");
            bool hasSpecial = Regex.IsMatch(password, @"[^a-zA-Z0-9]");

            return hasLetter && hasDigit && hasSpecial;
        }

        private void LoadUsersData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT UserID, FirstName, LastName, Email, UserName, Password, 
                                            Contact, Gender, Address, UserType 
                                     FROM Users ORDER BY UserID ASC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە هێنانی زانیاری بەکارهێنەران: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtUserID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtContact.Clear();
            cmbGender.SelectedIndex = 0;
            txtAddress.Clear();
            cmbUserType.SelectedIndex = 0;
            txtFirstName.Focus();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("تکایە خانە سەرەکییەکان پڕبکەرەوە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("وشەی نهێنی دەبێت بە لایەنی کەم ٨ پیت بێت و پیت و ژمارە و هێمای تێدابێت!", "هەڵەی پاسۆرد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // ئەگەر خانەی ئیمەیڵ پڕکرابووەوە، پشکنین بکات کە ئایا دروستە
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("تکایە ئیمەیڵێکی دروست بنووسە بە فۆرماتی نموونەیی (example@gmail.com)!", "هەڵەی ئیمەیڵ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("وشەی نهێنی و دووبارەکردنەوەکەی وەک یەک نین!", "هەڵەی پاسۆرد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Users (FirstName, LastName, Email, UserName, Password, Contact, Gender, Address, UserType) 
                                     VALUES (@FirstName, @LastName, @Email, @UserName, @Password, @Contact, @Gender, @Address, @UserType)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@Contact", string.IsNullOrWhiteSpace(txtContact.Text) ? (object)DBNull.Value : txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("بەکارهێنەرەکە بە سەرکەوتوویی زیادکرا!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadUsersData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە کاتی زیادکردندا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0 || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("تکایە بەکارهێنەرێک لەناو خشتەکە دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("وشەی نهێنی دەبێت بە لایەنی کەم ٨ پیت بێت و پیت و ژمارە و هێمای تێدابێت!", "هەڵەی پاسۆرد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("وشەی نهێنی و دووبارەکردنەوەکەی یەک ناگرنەوە!", "هەڵەی پاسۆرد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int userId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Users 
                                     SET FirstName=@FirstName, LastName=@LastName, Email=@Email, 
                                         UserName=@UserName, Password=@Password, Contact=@Contact, 
                                         Gender=@Gender, Address=@Address, UserType=@UserType 
                                     WHERE UserID=@ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", userId);
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@Contact", string.IsNullOrWhiteSpace(txtContact.Text) ? (object)DBNull.Value : txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserType", cmbUserType.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("زانیارییەکان نوێکرانەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadUsersData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە نوێکردنەوەدا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0 || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("تکایە بەکارهێنەرێک لە خشتەکە دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("ئایا دڵنیایت لە سڕینەوەی ئەم بەکارهێنەرە؟", "دڵنیابوونەوە", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int userId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @ID", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", userId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("بەکارهێنەرەکە سڕدرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadUsersData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هەڵە لە سڕینەوەدا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtUserID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtFirstName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtLastName.Text = row.Cells[2].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells[3].Value?.ToString() ?? "";
                txtUserName.Text = row.Cells[4].Value?.ToString() ?? "";
                txtPassword.Text = row.Cells[5].Value?.ToString() ?? "";
                txtConfirmPassword.Text = row.Cells[5].Value?.ToString() ?? "";
                txtContact.Text = row.Cells[6].Value?.ToString() ?? "";
                cmbGender.Text = row.Cells[7].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells[8].Value?.ToString() ?? "";
                cmbUserType.Text = row.Cells[9].Value?.ToString() ?? "";
            }
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT UserID, FirstName, LastName, Email, UserName, Password, 
                                            Contact, Gender, Address, UserType 
                                     FROM Users 
                                     WHERE FirstName LIKE @Search 
                                        OR LastName LIKE @Search 
                                        OR UserName LIKE @Search";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text.Trim() + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە گەڕاندا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}