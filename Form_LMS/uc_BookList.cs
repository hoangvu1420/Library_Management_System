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
    public partial class uc_BookList : UserControl
    {
        public uc_BookList()
        {
            InitializeComponent();
        }

        private void uc_bookList_Load(object sender, EventArgs e)
        {
            dGV_book.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_book.DataSource = GetBookList();
            dGV_book.Columns[0].Width = 100;
            dGV_book.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_book.Columns[1].Width = 400;
            dGV_book.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_book.Columns[2].Width = 120;
            dGV_book.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_book.Columns[5].Width = 120;
            dGV_book.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dGV_book.Columns[6].Visible = false;
            dGV_book.Columns[7].Visible = false;

        }

        DataTable GetBookList()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {

                SqlCommand cmd = new SqlCommand("BookInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    data.Load(reader);
                }
                /* another approach
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(data);
                }
                */
                connection.Close();

            }

            return data;
        }

        private void dGV_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_detail(dGV_book.CurrentRow.Index);
        }

        private void Update_detail(int i)
        {
            tB_ID.Text = dGV_book.Rows[i].Cells[0].Value.ToString();
            tB_title.Text = dGV_book.Rows[i].Cells[1].Value.ToString();
            tB_pub_year.Text = dGV_book.Rows[i].Cells[2].Value.ToString();
            tB_author.Text = dGV_book.Rows[i].Cells[3].Value.ToString();
            tB_category.Text = dGV_book.Rows[i].Cells[4].Value.ToString();
            tB_num_cop.Text = dGV_book.Rows[i].Cells[5].Value.ToString();
            tB_created_time.Text = DateTime.Parse(dGV_book.Rows[i].Cells[6].Value.ToString()).ToString("dd/MM/yyyy HH:mm:ss");
            tB_updated_time.Text = DateTime.Parse(dGV_book.Rows[i].Cells[7].Value.ToString()).ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void dGV_book_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                DataGridViewCellStyle headerStyle = e.CellStyle;
                headerStyle.Font = new Font(headerStyle.Font, FontStyle.Bold);
            }
        }

        private void uc_bookList_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                dGV_book.DataSource = GetBookList();
                dGV_book.Columns[0].Width = 100;
                dGV_book.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_book.Columns[1].Width = 400;
                dGV_book.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_book.Columns[2].Width = 120;
                dGV_book.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_book.Columns[5].Width = 120;
                dGV_book.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dGV_book.Columns[6].Visible = false;
                dGV_book.Columns[7].Visible = false;

                tB_searchBookID.Text = "";
                tB_searchTitle.Text = "";
                tB_searchAuthor.Text = "";
                tB_searchCategory.Text = "";
                tB_searchPubYear.Text = "";
                tB_searchStockNum.Text = "";
            }
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            string book_id = null;
            string book_title = null;
            string book_author = null;
            string book_category = null;
            int pub_year = 0;
            int stock_num = 0;

            if(!string.IsNullOrEmpty(tB_searchPubYear.Text))
            {
                pub_year = Convert.ToInt32(tB_searchPubYear.Text);
            }
            if(!string.IsNullOrEmpty(tB_searchStockNum.Text))
            {
                stock_num = Convert.ToInt32(tB_searchStockNum.Text);
            }

            if(!string.IsNullOrEmpty(tB_searchBookID.Text))
            {
                book_id = tB_searchBookID.Text;
            }
            if (!string.IsNullOrEmpty(tB_searchTitle.Text))
            {
                book_title = tB_searchTitle.Text;
            }
            if (!string.IsNullOrEmpty(tB_searchAuthor.Text))
            {
                book_author = tB_searchAuthor.Text;
            }
            if (!string.IsNullOrEmpty(tB_searchCategory.Text))
            {
                book_category = tB_searchCategory.Text;
            }

            using(SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("FilterBooks", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@bookID", book_id));
                cmd.Parameters.Add(new SqlParameter("@Title", book_title));
                if (string.IsNullOrEmpty(tB_searchPubYear.Text))
                {
                    cmd.Parameters.Add(new SqlParameter("@Publication_year", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Publication_year", pub_year));
                }
                cmd.Parameters.Add(new SqlParameter("@Author", book_author));
                cmd.Parameters.Add(new SqlParameter("@Category", book_category));
                if (string.IsNullOrEmpty(tB_searchStockNum.Text))
                {
                    cmd.Parameters.Add(new SqlParameter("@NumStock", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@NumStock", stock_num));
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        dGV_book.DataSource = data;
                        dGV_book.Columns[0].Width = 100;
                        dGV_book.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dGV_book.Columns[1].Width = 400;
                        dGV_book.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dGV_book.Columns[2].Width = 120;
                        dGV_book.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dGV_book.Columns[5].Width = 120;
                        dGV_book.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        dGV_book.Columns[6].Visible = false;
                        dGV_book.Columns[7].Visible = false;
                        Update_detail(0);
                    }
                    else
                    {
                        MessageBox.Show("No book found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                connection.Close();
            }
        }
    }
}
