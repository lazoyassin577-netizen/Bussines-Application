using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MyProject
{
    public partial class Category : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-RLKUK9C\SQLEXPRESS;Initial Catalog=Bad;Integrated Security=True;TrustServerCertificate=True;";

        public Category()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Category_Load(object? sender, EventArgs e)
        {
            LoadDatas();
        }

        private void LoadDatas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT CategoryID, Title, Description FROM Categories ORDER BY CategoryID ASC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە بارکردنی داتاکاندا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtCategoryID.Clear();
            txtTitle.Clear();
            txtDescription.Clear();
            txtTitle.Focus();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("تکایە ناونیشانی کاتێگۆری بنووسە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Categories (Title, Description) VALUES (@title, @description)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", string.IsNullOrWhiteSpace(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("کاتێگۆری بە سەرکەوتوویی زیادکرا!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadDatas();
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
                MessageBox.Show("تکایە سەرەتا کاتێگۆرییەک لە خشتەکە دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("تکایە ناونیشانی کاتێگۆری بە بەتاڵی جێمەهێڵە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            try
            {
                int categoryId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Categories SET Title = @title, Description = @desc WHERE CategoryID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@desc", string.IsNullOrWhiteSpace(txtDescription.Text) ? (object)DBNull.Value : txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", categoryId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("کاتێگۆرییەکە نوێکرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDatas();
                            ClearInputs();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە کاتی نوێکردنەوەدا: " + ex.Message, "هەڵەی داتابەیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0 || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("تکایە کاتێگۆرییەک لە خشتەکە دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("ئایا دڵنیایت لە سڕینەوەی ئەم کاتێگۆرییە؟", "دڵنیابوونەوە", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int categoryId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Categories WHERE CategoryID = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", categoryId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("کاتێگۆرییەکە سڕدرایەوە!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDatas();
                                ClearInputs();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("هەڵە لە کاتی سڕینەوەدا: " + ex.Message, "هەڵەی داتابەیس", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtCategoryID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtTitle.Text = row.Cells[1].Value?.ToString() ?? "";
                txtDescription.Text = row.Cells[2].Value?.ToString() ?? "";
            }
        }

        // گەڕانی دروست لە خشتەی Categories بەپێی Title و Description
        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT CategoryID, Title, Description 
                                     FROM Categories 
                                     WHERE Title LIKE @Search OR Description LIKE @Search 
                                     ORDER BY CategoryID ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + keyword + "%");

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