using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyProject
{
    public partial class Products : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-RLKUK9C\SQLEXPRESS;Initial Catalog=Bad;Integrated Security=True;TrustServerCertificate=True;";
        private string loggedUser = "";

        // تەنها یەک کۆنسترەکتەر بۆ کردنەوە بەبێ پارامیتەر یان بە ناوی یوزەر
        public Products(string username = "Admin")
        {
            InitializeComponent();
            loggedUser = username;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // بەستنەوەی ڕووداوەکان تەنها یەکجار
            dataGridView1.CellClick += dataGridView1_CellClick;
            btnSearch.Click += btnSearch_Click;
        }

        private void Products_Load(object? sender, EventArgs e)
        {
            // هێنانی پۆلەکان لە خشتەی Categories بۆ ناو ComboBox
            LoadCategories();

            // هێنانی بەرهەمەکان بۆ ناو خشتە
            LoadProductsData();

            // دانانی بەروار و ناوی بەکارهێنەر بە شێوەی خۆکار
            txtAddedDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtAddedBy.Text = loggedUser;
        }

        // هێنانی کاتیگۆری لە خشتەی پۆلەکان
        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CategoryID, Title FROM Categories";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            cmbCategory.DataSource = dt;
                            cmbCategory.DisplayMember = "Title";
                            cmbCategory.ValueMember = "CategoryID";
                            cmbCategory.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە هێنانی پۆلەکان: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // بارکردنی سەرجەم بەرهەمەکان
        private void LoadProductsData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName, Category, Description, Quantity, AddedDate, OrderBy FROM Products ORDER BY ProductID ASC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە بارکردنی بەرهەمەکان: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            txtQuantity.Clear();
            txtAddedDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtAddedBy.Text = loggedUser;
            txtName.Focus();
        }

        // زیادکردنی بەرهەم (ADD)
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("تکایە ناوی بەرهەم بنووسە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("تکایە پۆلێک دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Products (ProductName, Category, Description, Quantity, AddedDate, OrderBy) 
                                     VALUES (@Name, @Category, @Description, @Qty, @Date, @OrderBy)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int.TryParse(txtQuantity.Text, out int qty);

                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@Qty", qty);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@OrderBy", string.IsNullOrWhiteSpace(txtAddedBy.Text) ? loggedUser : txtAddedBy.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("بەرهەمەکە بە سەرکەوتوویی زیادکرا!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadProductsData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە زیادکردندا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // دەستکاریکردنی بەرهەم (UPDATE)
        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0 || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("تکایە سەرەتا بەرهەمێک لە خشتەکە دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Products 
                                     SET ProductName = @Name, 
                                         Category = @Category, 
                                         Description = @Description, 
                                         Quantity = @Qty, 
                                         OrderBy = @OrderBy 
                                     WHERE ProductID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int.TryParse(txtQuantity.Text, out int qty);

                        cmd.Parameters.AddWithValue("@ID", productId);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrWhiteSpace(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@Qty", qty);
                        cmd.Parameters.AddWithValue("@OrderBy", txtAddedBy.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("بەرهەمەکە نوێکرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadProductsData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە نوێکردنەوەدا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // سڕینەوەی بەرهەم (DELETE)
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0 || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("تکایە بەرهەمێک لە خشتەکە دیاری بکە بۆ سڕینەوە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("ئایا دڵنیایت لە سڕینەوەی ئەم بەرهەمە؟", "دڵنیابوونەوە", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Products WHERE ProductID = @ID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", productId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("بەرهەمەکە سڕدرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    LoadProductsData();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هەڵە لە سڕینەوەدا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // گەڕان تەنها بەپێی Product ID
        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string searchInput = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchInput))
            {
                LoadProductsData();
                return;
            }

            if (!int.TryParse(searchInput, out int searchId))
            {
                MessageBox.Show("تکایە تەنها ژمارەی Product ID بنووسە لە خانەی گەڕان!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT ProductID, ProductName, Category, Description, Quantity, AddedDate, OrderBy 
                                     FROM Products 
                                     WHERE ProductID = @SearchID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchID", searchId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = dt;
                            }
                            else
                            {
                                MessageBox.Show("هیچ بەرهەمێک بەم IDیە نەدۆزرایەوە!", "ئەنجام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadProductsData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە گەڕاندا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // پڕکردنەوەی خانەکان لەگەڵ کلیککردن لەسەر دێڕێک لە DataGridView
        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtName.Text = row.Cells[1].Value?.ToString() ?? "";
                cmbCategory.Text = row.Cells[2].Value?.ToString() ?? "";
                txtDescription.Text = row.Cells[3].Value?.ToString() ?? "";
                txtQuantity.Text = row.Cells[4].Value?.ToString() ?? "0";

                if (row.Cells[5].Value != null && row.Cells[5].Value != DBNull.Value)
                {
                    if (DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime dateValue))
                    {
                        txtAddedDate.Text = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                    else
                    {
                        txtAddedDate.Text = row.Cells[5].Value.ToString()!;
                    }
                }
                else
                {
                    txtAddedDate.Clear();
                }

                txtAddedBy.Text = row.Cells[6].Value?.ToString() ?? "";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}