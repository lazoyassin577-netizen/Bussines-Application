using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyProject
{
    public partial class Customer : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-RLKUK9C\SQLEXPRESS;Initial Catalog=Bad;Integrated Security=True;TrustServerCertificate=True;";

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // پشکنینی ستانداردی فۆرماتی ئیمەیڵ (دەق + @ + دۆمەین + . + پاشگر)
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email.Trim(), pattern, RegexOptions.IgnoreCase);
        }

        public Customer()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void Customer_Load(object? sender, EventArgs e)
        {
            if (cmbType is ComboBox combo && combo.Items.Count == 0)
            {
                combo.Items.Add("Customer");
                combo.Items.Add("Dealer");
                combo.SelectedIndex = 0;
            }

            LoadCustomersData();
        }

        private void LoadCustomersData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CustomerID, Type, Name, Contact, Email, Address FROM Customers ORDER BY CustomerID ASC";

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
                MessageBox.Show("هەڵە لە هێنانی زانیاری کڕیاران: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtCustomerID.Clear();
            if (cmbType is ComboBox cb) cb.SelectedIndex = 0; else cmbType.Text = "";
            txtName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtName.Focus();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            // ئەگەر خانەی ئیمەیڵ پڕکرابووەوە، پشکنین بکات کە ئایا دروستە
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("تکایە ئیمەیڵێکی دروست بنووسە بە فۆرماتی نموونەیی (example@gmail.com)!", "هەڵەی ئیمەیڵ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("تکایە ناوی کڕیار و ژمارەی مۆبایل پڕبکەرەوە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Customers (Type, Name, Contact, Email, Address) 
                                     VALUES (@Type, @Name, @Contact, @Email, @Address)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Type", cmbType.Text.Trim());
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("کڕیارەکە بە سەرکەوتوویی زیادکرا!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadCustomersData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە کاتی زیادکردندا: " + ex.Message, "هەڵەی داتابەیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0 || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("تکایە کڕیارێک لە خشتەکە دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ئەگەر خانەی ئیمەیڵ پڕکرابووەوە، پشکنین بکات کە ئایا دروستە
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("تکایە ئیمەیڵێکی دروست بنووسە بە فۆرماتی نموونەیی (example@gmail.com)!", "هەڵەی ئیمەیڵ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("ناو و ژمارەی مۆبایل ناتوانرێت بە بەتاڵی بمێننەوە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Customers 
                                     SET Type = @Type, Name = @Name, Contact = @Contact, Email = @Email, Address = @Address 
                                     WHERE CustomerID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", customerId);
                        cmd.Parameters.AddWithValue("@Type", cmbType.Text.Trim());
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(txtEmail.Text) ? (object)DBNull.Value : txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("زانیاری کڕیارەکە نوێکرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadCustomersData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە نوێکردنەوەدا: " + ex.Message, "هەڵەی داتابەیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0 || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("تکایە سەرەتا کڕیارێک لە خشتەکە دیاری بکە بۆ سڕینەوە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("ئایا دڵنیایت لە سڕینەوەی ئەم کڕیارە؟", "دڵنیابوونەوە", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int customerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Customers WHERE CustomerID = @ID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", customerId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("کڕیارەکە سڕدرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    LoadCustomersData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هەڵە لە سڕینەوەدا: " + ex.Message, "هەڵەی داتابەیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells[0].Value?.ToString() ?? "";
                cmbType.Text = row.Cells[1].Value?.ToString() ?? "";
                txtName.Text = row.Cells[2].Value?.ToString() ?? "";
                txtContact.Text = row.Cells[3].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells[4].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells[5].Value?.ToString() ?? "";
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e) => SearchCustomers();
        private void txtSearch_TextChanged(object? sender, EventArgs e) => SearchCustomers();

        private void SearchCustomers()
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadCustomersData();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT CustomerID, Type, Name, Contact, Email, Address 
                                     FROM Customers 
                                     WHERE Name LIKE @Key OR Contact LIKE @Key";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Key", "%" + keyword + "%");

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
    }
}