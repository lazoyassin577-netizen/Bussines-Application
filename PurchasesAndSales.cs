using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyProject
{
    public partial class PurchasesAndSales : Form
    {

        private void ApplyModernDashboardTheme()
        {
            // ١. ڕەنگی گشتی فۆڕمەکە دەبێتە خۆڵەمێشییەکی زۆر کاڵ و سەردەمییانە
            this.BackColor = Color.FromArgb(244, 246, 249);
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            // ٢. نوێکردنەوەی هەموو پانێڵەکان وەک کارتی سپی و پاک
            Color cardColor = Color.White;
            Color borderLineColor = Color.FromArgb(226, 232, 240);
            Color textColor = Color.FromArgb(30, 41, 59);

            foreach (Control c in this.Controls)
            {
                if (c is Panel p)
                {
                    p.BackColor = cardColor;
                    p.BorderStyle = BorderStyle.FixedSingle;

                    // ڕێکخستنی کۆنتڕۆڵەکانی ناو هەر کارتێک
                    foreach (Control inner in p.Controls)
                    {
                        if (inner is Label lbl)
                        {
                            lbl.ForeColor = textColor;
                            lbl.Font = new Font("Segoe UI Semibold", 9.5F);
                        }
                        else if (inner is TextBox txt)
                        {
                            txt.BorderStyle = BorderStyle.FixedSingle;
                            txt.Font = new Font("Segoe UI", 10F);
                            txt.BackColor = Color.FromArgb(250, 252, 255);
                        }
                    }
                }
            }

           

            // ٤. دیزاینی مۆدێرن و سەرنجڕاکێشی DataGridView
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.FromArgb(241, 245, 249);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // ستایلی Header
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235); // شینی فەرمی زۆر گەش
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F);
            dataGridView1.ColumnHeadersHeight = 40;

            // ستایلی دێڕەکان
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254); // شینێکی کاڵی هێمن لە کاتی سلێکت
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dataGridView1.RowTemplate.Height = 34;

            // ٥. ستایلی دوگمەکان (Flat, بەرزایی گونجاو و ڕەنگی پڕۆفیشناڵ)
            StyleButton(btnSearchCustomer, Color.FromArgb(71, 85, 105));   // خۆڵەمێشی شینکی (Slate)
            StyleButton(btnAddToCart, Color.FromArgb(37, 99, 235));        // شینی سەرنجڕاکێش
            StyleButton(btnSaveTransaction, Color.FromArgb(22, 163, 74));  // سەوزی مۆدێرن
        }

        private void StyleButton(Button btn, Color bg)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bg;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private void StyleModernButton(Button btn, Color backColor)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        private readonly string connectionString = @"Data Source=DESKTOP-RLKUK9C\SQLEXPRESS;Initial Catalog=Bad;Integrated Security=True;TrustServerCertificate=True;";
        private string loggedInUser = "";
        private DataTable cartTable = new DataTable();

        public PurchasesAndSales(string username = "Admin")
        {
            InitializeComponent();
            loggedInUser = username;

            SetupCartTable();

            // بەستنەوەی ڕووداوەکان
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // btnAddToCart.Click += btnAddToCart_Click;
            // btnSaveTransaction.Click += btnSaveTransaction_Click;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtPaidAmount.TextChanged += txtPaidAmount_TextChanged;
            txtProductID.KeyDown += txtProductID_KeyDown;
        }

        private void SetupCartTable()
        {
            // دروستکردنی ستوونەکانی DataGridView وەک دیزاینەکەی ناو وێنەکە
            cartTable.Columns.Add("ID", typeof(int));
            cartTable.Columns.Add("Name", typeof(string));
            cartTable.Columns.Add("Category", typeof(string));
            cartTable.Columns.Add("Price", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Total", typeof(decimal));

            dataGridView1.DataSource = cartTable;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            ResetCalculations();
        }

        private void ResetCalculations()
        {
            txtSubTotal.Text = "0.00";
            txtDiscount.Text = "0";
            txtGrandTotal.Text = "0.00";
            txtPaidAmount.Text = "0.00";
            //txtReturnAmount.Text = "0.00";
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // پشکنینی ستانداردی فۆرماتی ئیمەیڵ (دەق + @ + دۆمەین + . + پاشگر)
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email.Trim(), pattern, RegexOptions.IgnoreCase);
        }

        // داواکاری: گەڕان بە مۆبایلی کڕیار و هێنانی زانیارییەکان بۆ خانەکانی دەق
        private void btnSearchCustomer_Click(object? sender, EventArgs e)
        {
            string phone = txtSearchPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("تکایە ژمارەی مۆبایل بنووسە بۆ گەڕان!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         

            if (!string.IsNullOrWhiteSpace(txtCustomerEmail.Text) && !IsValidEmail(txtCustomerEmail.Text))
            {
                MessageBox.Show("تکایە ئیمەیڵێکی دروست بنووسە بە فۆرماتی نموونەیی (example@gmail.com)!", "هەڵەی ئیمەیڵ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerEmail.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Name, Email, Address FROM Customers WHERE Contact = @Phone";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCustomerName.Text = reader["Name"]?.ToString() ?? "";
                                txtCustomerEmail.Text = reader["Email"]?.ToString() ?? "";
                                txtCustomerAddress.Text = reader["Address"]?.ToString() ?? "";
                            }
                            else
                            {
                                MessageBox.Show("هیچ کڕیارێک بەم ژمارە مۆبایلە نەدۆزرایەوە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCustomerName.Clear();
                                txtCustomerEmail.Clear();
                                txtCustomerAddress.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە گەڕانی کڕیار: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // دۆزینەوەی بەرهەم لە خشتەی Products کاتێک لە خانەی ID دوگمەی Enter لێدەدەیت
        private void txtProductID_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // بێدەنگکردنی دەنگی بیپی کیبۆرد
                if (int.TryParse(txtProductID.Text.Trim(), out int prodId))
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "SELECT ProductName, Category FROM Products WHERE ProductID = @ID";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID", prodId);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        txtProductName.Text = reader["ProductName"]?.ToString() ?? "";
                                        txtCategory.Text = reader["Category"]?.ToString() ?? "";
                                        txtPrice.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("هیچ کاڵایەک بەم ژمارەیە (ID) نییە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtProductName.Clear();
                                        txtCategory.Clear();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("هەڵە: " + ex.Message);
                    }
                }
            }
        }

        // داواکاری: زیادکردنی زانیاری بەرهەم بۆ ناو خشتەی DataGridView
        private void btnAddToCart_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("تکایە بەرهەمێک دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                MessageBox.Show("تکایە نرخی دروست داخڵ بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("تکایە بڕی دروست (Quantity) بنووسە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            int.TryParse(txtProductID.Text.Trim(), out int pid);
            decimal rowTotal = price * qty;

            cartTable.Rows.Add(pid, txtProductName.Text.Trim(), txtCategory.Text.Trim(), price, qty, rowTotal);

            // دووبارە هەژمارکردنەوەی باڵانسەکان
            CalculateTotals();

            // پاککردنەوەی خانەی بەرهەم بۆ داخڵکردنی کاڵای نوێ
            txtProductID.Clear();
            txtProductName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtProductID.Focus();
        }

        // هەژمارکردنی پارە (Sub Total, Discount %, Grand Total, Return Amount)
        private void CalculateTotals()
        {
            decimal subTotal = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                subTotal += Convert.ToDecimal(row["Total"]);
            }

            txtSubTotal.Text = subTotal.ToString("0.00");

            decimal.TryParse(txtDiscount.Text.Trim(), out decimal discountPercent);
            decimal discountValue = subTotal * (discountPercent / 100);
            decimal grandTotal = subTotal - discountValue;

            txtGrandTotal.Text = grandTotal.ToString("0.00");

            CalculateReturn();
        }

        private void txtDiscount_TextChanged(object? sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtPaidAmount_TextChanged(object? sender, EventArgs e)
        {
            CalculateReturn();
        }

        private void CalculateReturn()
        {
            decimal.TryParse(txtGrandTotal.Text.Trim(), out decimal grandTotal);
            decimal.TryParse(txtPaidAmount.Text.Trim(), out decimal paid);

            decimal returnAmount = paid - grandTotal;
            txtReturnAmount.Text = returnAmount.ToString("0.00");
        }

        // داواکاری: خەزنکردنی هەموو زانیارییەکان لە خشتەی Transaction لەگەڵ AddedDate و AddedBy
        private void btnSaveTransaction_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("تکایە سەرەتا کڕیارێک دیاری بکە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("هیچ کاڵایەک لەناو خشتەی کڕین نییە!", "ئاگاداری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(txtSubTotal.Text.Trim(), out decimal subTotal);
            decimal.TryParse(txtDiscount.Text.Trim(), out decimal discount);
            decimal.TryParse(txtGrandTotal.Text.Trim(), out decimal grandTotal);
            decimal.TryParse(txtPaidAmount.Text.Trim(), out decimal paid);
            decimal.TryParse(txtReturnAmount.Text.Trim(), out decimal returnAmount);

            // کات و بەرواری ئێستای کۆمپیوتەر
            DateTime currentDateTime = DateTime.Now;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    foreach (DataRow row in cartTable.Rows)
                    {
                        string query = @"INSERT INTO dbo.[Transaction]
                                        (CustomerPhone, CustomerName, CustomerEmail, CustomerAddress,
                                         ProductID, ProductName, Category, Price, Quantity, Total,
                                         SubTotal, Discount, GrandTotal, PaidAmount, ReturnAmount,
                                         AddedDate, AddedBy)
                                        VALUES
                                        (@CPhone, @CName, @CEmail, @CAddress,
                                         @PID, @PName, @Category, @Price, @Qty, @RowTotal,
                                         @SubTotal, @Discount, @GrandTotal, @Paid, @Return,
                                         @Date, @AddedBy)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CPhone", txtSearchPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@CName", txtCustomerName.Text.Trim());
                            cmd.Parameters.AddWithValue("@CEmail", txtCustomerEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@CAddress", txtCustomerAddress.Text.Trim());

                            cmd.Parameters.AddWithValue("@PID", row["ID"]);
                            cmd.Parameters.AddWithValue("@PName", row["Name"]);
                            cmd.Parameters.AddWithValue("@Category", row["Category"]);
                            cmd.Parameters.AddWithValue("@Price", row["Price"]);
                            cmd.Parameters.AddWithValue("@Qty", row["Quantity"]);
                            cmd.Parameters.AddWithValue("@RowTotal", row["Total"]);

                            cmd.Parameters.AddWithValue("@SubTotal", subTotal);
                            cmd.Parameters.AddWithValue("@Discount", discount);
                            cmd.Parameters.AddWithValue("@GrandTotal", grandTotal);
                            cmd.Parameters.AddWithValue("@Paid", paid);
                            cmd.Parameters.AddWithValue("@Return", returnAmount);

                            // داواکارییەکانی: بەروار بەپێی کاتی کۆمپیوتەر و ناوی بەکارهێنەری داخڵبوو
                            cmd.Parameters.AddWithValue("@Date", currentDateTime);
                            cmd.Parameters.AddWithValue("@AddedBy", loggedInUser);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("مامەڵەکە بە سەرکەوتوویی لە خشتەی Transaction تۆمارکرا!", "سەرکەوتوو", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // پاککردنەوەی هەموو خانەکان بۆ مامەڵەی دواتر
                    cartTable.Clear();
                    txtSearchPhone.Clear();
                    txtCustomerName.Clear();
                    txtCustomerEmail.Clear();
                    txtCustomerAddress.Clear();
                    ResetCalculations();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هەڵە لە کاتی سەیڤکردندا: " + ex.Message, "هەڵە", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PurchasesAndSales_Load(object sender, EventArgs e)
        {
            ApplyModernDashboardTheme();
        }
    }
}