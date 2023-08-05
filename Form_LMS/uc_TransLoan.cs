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
    public partial class uc_TransLoan : UserControl
    {
        public string MemID { get; set; }
        public List<string> ReLoanList { get; set; }
        public DateTime Date { get; set; }

        public uc_TransLoan()
        {
            InitializeComponent();
        }

        private void uc_TransLoan_Load(object sender, EventArgs e)
        {
            dTP_loanDate.Format = DateTimePickerFormat.Custom;
            dTP_loanDate.CustomFormat = "dd/MM/yyyy";


            dGV_book_list.DataSource = bookList;
            dGV_book_list.Columns[0].Width = 80;
            dGV_book_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_book_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_book_list.Columns[2].Width = 100;
            dGV_book_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Font headerFont = new Font("Lora", 9, FontStyle.Bold);
            foreach (DataGridViewColumn column in dGV_book_list.Columns)
            {
                column.HeaderCell.Style.Font = headerFont;
            }
            Font cellFont = new Font("Lora", 8);
            dGV_book_list.DefaultCellStyle.Font = cellFont;

            if (!string.IsNullOrEmpty(MemID))
            {
                memID = MemID;
                tB_memID1.Text = MemID;
                tB_memID1.Enabled = false;

                dTP_loanDate.Value = Date;
                dTP_loanDate.Enabled = false;

                using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
                {
                    connection.Open();

                    foreach (string bookID in ReLoanList)
                    {
                        SqlCommand cmd = new SqlCommand("BookSearch", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ID", bookID));

                        Book newBook = new Book();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();

                            newBook.BookID = (string)reader["ID"];
                            newBook.Title = (string)reader["Title"];
                            newBook.Stock_num = (short)reader["Number in stock"];
                        }

                        bookList.Add(newBook);
                        reloan_book_num++;
                        tB_numBook.Text = reloan_book_num.ToString();
                    }

                    connection.Close();
                }
                book_num = reloan_book_num;
                tB_memID1_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            }
        }
        public class Member
        {
            public string MemID { get; set; }
            public string Name { get; set; }
            public string Membership { get; set; }
            public short MaxBook { get; set; }
            public short MaxDay { get; set; }
        }
        public class Book
        {
            public string BookID { get; set; }
            public string Title { get; set; }
            public short Stock_num { get; set; }

        }
        private BindingList<Book> bookList = new BindingList<Book>();
        Member member = new Member();
        string memID;
        DateTime loanDate;
        short reloan_book_num = 0;
        short book_num = 0;
        short max_num_book;

        private void tB_memID1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetMembershipDetail();
            }
        }

        private void GetMembershipDetail()
        {
            memID = tB_memID1.Text.ToString();
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("MembershipDetailSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@memID", memID));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Member ID not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tB_memID1.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        member.Name = (string)reader["Member name"];
                        member.Membership = (string)reader["Membership"];
                        member.MaxBook = (short)reader["Max number of book"];
                        member.MaxDay = (short)reader["Max number of day"];

                        tB_memName1.Text = member.Name;
                        tB_membership1.Text = member.Membership;
                        tB_max_book.Text = member.MaxBook.ToString();
                        max_num_book = member.MaxBook;
                        tB_max_day.Text = member.MaxDay.ToString();

                        tB_dueDate.Text = (dTP_loanDate.Value.AddDays(member.MaxDay)).ToString("dd/MM/yyyy");

                        if (tB_membership1.Text != "-")
                        {
                            tB_memID2.Text = memID.ToString();
                            tB_memName2.Text = member.Name;

                            bt_Finish.Enabled = true;
                        }
                        else
                        {
                            tB_memID2.Text = string.Empty;
                            tB_memName2.Text = string.Empty;
                            tB_dueDate.Text = string.Empty;
                            dTP_loanDate.Enabled = false;
                            bt_Finish.Enabled = false;
                        }

                    }
                }

                connection.Close();
            }

        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            string bookID = tB_bookID.Text.ToString();
            if (string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Enter a Book ID to insert into the list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Book newBook = new Book();
            bool bookAdded = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("BookSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", bookID));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Book ID not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tB_bookID.Text = string.Empty;
                        return;
                    }
                    if ((short)reader["Number in stock"] == 0)
                    {
                        MessageBox.Show("The in stock quantity of this book is not enough, please select other book.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tB_bookID.Text = string.Empty;
                        return;
                    }
                    else
                    {
                        newBook.BookID = (string)reader["ID"];
                        newBook.Title = (string)reader["Title"];
                        newBook.Stock_num = (short)reader["Number in stock"];
                    }
                }

                connection.Close();
            }
            foreach (Book book in bookList)
            {
                if (book.BookID == newBook.BookID)
                {
                    bookAdded = true;
                    break;
                }
            }

            if (!bookAdded)
            {
                if (bookList.Count < max_num_book)
                {
                    bookList.Add(newBook);
                    book_num++;
                    tB_numBook.Text = book_num.ToString();
                }
                else
                {
                    MessageBox.Show("The maximum number of books this member can borrow has been reached.".ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This Book has already been added to the list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tB_bookID.Text = string.Empty;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            var selected_row = dGV_book_list.SelectedRows;
            if (selected_row.Count == 0)
            {
                MessageBox.Show("Please select row(s) to delete from the list", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewRow row in selected_row)
            {
                int index = row.Index;
                if (index >= reloan_book_num)
                {
                    bookList.RemoveAt(index);
                    book_num--;
                    tB_numBook.Text = book_num.ToString();
                }
                else
                {
                    MessageBox.Show("Can not delete this row", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void tB_bookID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_Add_Click(sender, e);
            }
        }

        private void dGV_book_list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                bt_Delete_Click(sender, e);
            }
        }

        private void bt_Finish_Click(object sender, EventArgs e)
        {
            if (tB_memID1.Text == "")
            {
                MessageBox.Show("Please fill in all informations.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int returnValue = 0;
            loanDate = dTP_loanDate.Value;

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                var bookReloanTable = new DataTable();
                bookReloanTable.Columns.Add("BookID", typeof(string));
                bookReloanTable.Columns.Add("Title", typeof(string));
                bookReloanTable.Columns.Add("Stock_num", typeof(short));

                for (int i = 0; i < reloan_book_num; i++)
                {
                    var book = bookList[i];
                    bookReloanTable.Rows.Add(book.BookID, book.Title, book.Stock_num);
                }

                var bookLoanTable = new DataTable();
                bookLoanTable.Columns.Add("BookID", typeof(string));
                bookLoanTable.Columns.Add("Title", typeof(string));
                bookLoanTable.Columns.Add("Stock_num", typeof(short));

                for (int i = reloan_book_num; i < bookList.Count; i++)
                {
                    var book = bookList[i];
                    bookLoanTable.Rows.Add(book.BookID, book.Title, book.Stock_num);
                }

                SqlCommand cmd = new SqlCommand("InsertLoan", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@memID", memID);
                cmd.Parameters.AddWithValue("@loanDate", loanDate);
                cmd.Parameters.AddWithValue("@BookLoanList", bookLoanTable);
                cmd.Parameters.AddWithValue("@BookReloanList", bookReloanTable);
                cmd.Parameters.Add("@return", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                returnValue = (int)cmd.Parameters["@return"].Value;
            }

            switch (returnValue)
            {
                case 0:
                    MessageBox.Show("Loan has been declined due to unpaid fine from the member.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("Loan has been declined due to unreturned loan from the member.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Loan has been declined due to expired membership.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    MessageBox.Show("Loan has been processed successfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show("Loan has been declined.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
            this.Hide();

        }
        private void tB_memID1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tB_memID1.Text))
            {
                KeyEventArgs key = new KeyEventArgs(Keys.Enter);
                tB_memID1_KeyDown(sender, key);
            }
        }

        private void dGV_book_list_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(MemID))
            {
                if (e.RowIndex < ReLoanList.Count && e.RowIndex >= 0 && !dGV_book_list.Rows[e.RowIndex].IsNewRow)
                {
                    dGV_book_list.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
            }

        }

        private void dTP_loanDate_ValueChanged(object sender, EventArgs e)
        {
            loanDate = dTP_loanDate.Value;
            tB_dueDate.Text = (loanDate.AddDays(member.MaxDay)).ToString("dd/MM/yyyy");
        }

        private void uc_TransLoan_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                tB_bookID.Text = string.Empty;
                tB_memID1.Text = string.Empty;
                tB_memID2.Text = string.Empty;
                tB_memName1.Text = string.Empty;
                tB_memName2.Text = string.Empty;
                tB_max_book.Text = string.Empty;
                tB_max_day.Text = string.Empty;
                tB_dueDate.Text = string.Empty;
                tB_membership1.Text = string.Empty;
                tB_numBook.Text = string.Empty;
                tB_dueDate.Text = string.Empty;
                dTP_loanDate.Value = DateTime.Now;
                dGV_book_list.Rows.Clear();
                bookList.Clear();
                book_num = 0;
                reloan_book_num = 0;
                memID = string.Empty;

            }
        }
    }
}
