using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_LMS
{
    public partial class uc_BookUpdate : UserControl
    {
        public uc_BookUpdate()
        {
            InitializeComponent();
        }

        string bookID;

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_bookID.Text))
            {
                MessageBox.Show("Please enter book ID to update.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bookID = tB_bookID.Text.ToString();
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("BookSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", bookID));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tB_title.Text = reader["Title"].ToString();
                        tB_author.Text = reader["Author(s)"].ToString();
                        tB_category.Text = reader["Category(s)"].ToString();
                        tB_pubYear.Text = reader["Publication year"].ToString();
                        tB_num_cop.Text = reader["Number in stock"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                connection.Close();
            }

            tB_title1.Text = tB_title.Text;
            tB_author1.Text = tB_author.Text;
            tB_category1.Text = tB_category.Text;
            tB_pub_year1.Text = tB_pubYear.Text;
            tB_book_stock1.Text = tB_num_cop.Text;
        }

        private void tB_bookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_search_Click(sender, e);
            }
        }

        private void bT_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_title1.Text) || string.IsNullOrEmpty(tB_author1.Text) || string.IsNullOrEmpty(tB_category1.Text) || string.IsNullOrEmpty(tB_pub_year1.Text) || string.IsNullOrEmpty(tB_book_stock1.Text))
            {
                MessageBox.Show("Please fill in all fields.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to update this book?", "Confirm Update!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            var authorTable = new DataTable();
            authorTable.Columns.Add("author_name");
            var authorList = tB_author1.Text.Split(',');
            foreach (var author in authorList)
            {
                authorTable.Rows.Add(author.Trim());
            }
            var categoryTable = new DataTable();
            categoryTable.Columns.Add("category_name");
            var categoryList = tB_category1.Text.Split(',');
            foreach (var category in categoryList)
            {
                categoryTable.Rows.Add(category.Trim());
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                SqlCommand cmd = new SqlCommand("UpdateBook", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@bookID", bookID));
                cmd.Parameters.Add(new SqlParameter("@u_title", tB_title1.Text));
                cmd.Parameters.Add(new SqlParameter("@u_pub_year", tB_pub_year1.Text));
                cmd.Parameters.Add(new SqlParameter("@u_num_cop", tB_book_stock1.Text));
                cmd.Parameters.Add(new SqlParameter("@u_au_list", authorTable));
                cmd.Parameters.Add(new SqlParameter("@u_cat_list", categoryTable));

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Book updated successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tB_bookID.Text = "";
            tB_title.Text = "";
            tB_author.Text = "";
            tB_category.Text = "";
            tB_pubYear.Text = "";
            tB_num_cop.Text = "";
            tB_title1.Text = "";
            tB_author1.Text = "";
            tB_category1.Text = "";
            tB_pub_year1.Text = "";
            tB_book_stock1.Text = "";
        }
    }
}
