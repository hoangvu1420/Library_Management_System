using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_LMS
{
    public partial class uc_TransReturn : UserControl
    {
        public uc_TransReturn()
        {
            InitializeComponent();
        }

        private void uc_TransReturn_Load(object sender, EventArgs e)
        {
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

            dTP_returnDate.Format = DateTimePickerFormat.Custom;
            dTP_returnDate.CustomFormat = "dd/MM/yyyy";
        }

        public class Book
        {
            public string BookID { get; set; }
            public string Title { get; set; }
            public short Stock_num { get; set; }

        }
        public class Loan
        {
            public string LoanID { get; set; }
            public DateTime LoanDate { get; set; }
            public DateTime DueDate { get; set; }
            public Int32 num_loan_book { get; set; }
        }

        string memID;
        Loan loan = new Loan();
        private BindingList<Book> bookList = new BindingList<Book>();

        private List<string> loanList = new List<string>();
        short book_num = 0;

        DateTime returnDate;
        string returnStatus;

        private void tB_memID1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                memID = tB_memID1.Text;
                using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("UnreturnedLoanSearch", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@memID", memID));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Member ID does not exists or this member currently has no unreturned loan.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tB_memID1.Text = string.Empty;
                            tB_memID2.Text = string.Empty;
                            tB_loanID.Text = string.Empty;
                            tB_loanDate.Text = string.Empty;
                            tB_dueDate.Text = string.Empty;
                            tB_book_loan_num.Text = string.Empty;
                            tB_memName.Text = string.Empty;
                            return;
                        }
                        loan.LoanID = (string)reader["Loan ID"];
                        loan.LoanDate = DateTime.ParseExact((string)reader["Loan Date"], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        loan.DueDate = DateTime.ParseExact((string)reader["Due Date"], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        loan.num_loan_book = (Int32)reader["Number of loaned book"];

                        tB_memID2.Text = memID;
                        tB_loanID.Text = loan.LoanID.ToString();
                        tB_loanDate.Text = loan.LoanDate.ToString("dd/MM/yyyy");
                        tB_dueDate.Text = loan.DueDate.ToString("dd/MM/yyyy");
                        tB_book_loan_num.Text = loan.num_loan_book.ToString();
                        tB_memName.Text = (string)reader["Member Name"];
                        returnDate = dTP_returnDate.Value;
                        if (returnDate.Date > loan.DueDate.Date)
                        {
                            tB_returnStatus.Text = "Returned book overdue";
                        }
                        else
                        {
                            tB_returnStatus.Text = "Normal";
                        }
                    }


                    SqlCommand cmd2 = new SqlCommand("SearchLoanList", connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@LoanID", loan.LoanID));

                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = (string)reader[0];
                            loanList.Add(value);
                        }
                    }

                    connection.Close();
                }
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

                    newBook.BookID = (string)reader["ID"];
                    newBook.Title = (string)reader["Title"];
                    newBook.Stock_num = (short)reader["Number in stock"];

                }

                connection.Close();
            }

            bool bookAdded = false;
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
                foreach (string item in loanList)
                {
                    if (newBook.BookID == item)
                    {
                        bookList.Add(newBook);
                        book_num++;
                        bookAdded = true;
                        tB_book_return_num.Text = book_num.ToString();
                        break;
                    }
                }

                if (!bookAdded)
                {
                    MessageBox.Show("This book was not included in the list of loaned books.".ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This book has already been added to the list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //tB_bookID.Text = string.Empty;
        }

        private List<string> missBookID = new List<string>();

        private void bt_Finish_Click(object sender, EventArgs e)
        {
            if (tB_memID1.Text == string.Empty || cB_book_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all informations.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int return_value;
            returnDate = dTP_returnDate.Value;

            if (cB_book_status.SelectedIndex == 0)
                returnStatus = "Normal";
            else if (cB_book_status.SelectedIndex == 1)
                returnStatus = "Returned with damaged book";

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                var bookTable = new DataTable();
                bookTable.Columns.Add("BookID", typeof(string));
                bookTable.Columns.Add("Title", typeof(string));
                bookTable.Columns.Add("Stock_num", typeof(short));

                foreach (var book in bookList)
                {
                    bookTable.Rows.Add(book.BookID, book.Title, book.Stock_num);
                }

                SqlCommand cmd = new SqlCommand("InsertReturn", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@memID", memID));
                cmd.Parameters.Add(new SqlParameter("@returnDate", returnDate));
                cmd.Parameters.Add(new SqlParameter("@returnStatus", returnStatus));
                cmd.Parameters.Add(new SqlParameter("@BookList", bookTable));
                cmd.Parameters.Add("@RE_ID_out", SqlDbType.SmallInt).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@return", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                short RE_ID = (short)cmd.Parameters["@RE_ID_out"].Value;
                return_value = (int)cmd.Parameters["@return"].Value;

                SqlCommand cmd1 = new SqlCommand("CheckReturnBookList", connection);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add(new SqlParameter("@RE_ID", RE_ID));

                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string value = (string)reader[0];
                        missBookID.Add(value);
                    }
                }

                connection.Close();
            }

            if (return_value != 0)
            {
                string fine_state;
                using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("UnpaidFineSearch", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@memID", memID));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        fine_state = (string)reader["Fine Type"];
                    }

                    connection.Close();
                }

                if (missBookID.Count > 0)
                {

                    MessageBox.Show("This book return has returned less than the number of books of the corresponding loan and, at the same time, violated regulations by: " + fine_state +
                    ".\nTherefore, the member will immediately be required to pay the fine for the violation, then the missing books will be added to a new loan.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uc_TransPayment1 paymentControl = new uc_TransPayment1
                    {
                        MemberID = memID,
                        MissBookList = missBookID,
                        sw = 1,
                        Date = returnDate
                    };
                    this.Parent.Controls.Add(paymentControl);
                    this.Hide();

                    this.Parent.Size = new Size(1081, 742);
                    paymentControl.BringToFront();
                    paymentControl.Size = new Size(833, 696);
                    paymentControl.Location = new Point(224, 0);

                }
                else
                {
                    MessageBox.Show("Return has been processed successfully with violation: " + fine_state, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();

            }
            else
            {
                if (missBookID.Count > 0)
                {
                    MessageBox.Show("This Return has returned less than the number of loaned book." +
                        " The Loan interface will be display that will add the missing books to a new loan, " +
                        "the member can add more books to the loan.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    uc_TransLoan loanControl = new uc_TransLoan
                    {
                        MemID = memID,
                        ReLoanList = missBookID,
                        Date = returnDate
                    };
                    this.Parent.Controls.Add(loanControl);
                    this.Hide();

                    this.Parent.Size = new Size(1370, 742);
                    loanControl.BringToFront();
                    loanControl.Size = new Size(1130, 696);
                    loanControl.Location = new Point(224, 0);

                }
                else
                {
                    MessageBox.Show("Return has been processed successfully with no violation.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Hide();
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
                bookList.RemoveAt(index);
                book_num--;
                tB_book_return_num.Text = book_num.ToString();
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

        private void tB_memID1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tB_memID1.Text))
            {
                tB_memID1_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            }
        }

        private void cB_book_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_book_status.SelectedIndex == 1)
            {
                if (tB_returnStatus.Text == "Returned book overdue")
                {
                    tB_returnStatus.Text = "Returned book overdue and damaged book";
                }
                else if (tB_returnStatus.Text == "Normal")
                {
                    tB_returnStatus.Text = "Returned with damaged book";
                }
            }
            else
            {
                if (tB_returnStatus.Text == "Returned book overdue and damaged book")
                {
                    tB_returnStatus.Text = "Returned book overdue";
                }
                else
                {
                    if(tB_returnStatus.Text != "Returned book overdue")
                    {
                        tB_returnStatus.Text = "Normal";
                    }
                }
            }
        }

        private void dTP_returnDate_ValueChanged(object sender, EventArgs e)
        {
            returnDate = dTP_returnDate.Value;
            if (returnDate.Date > loan.DueDate.Date)
            {
                if (tB_returnStatus.Text == "Normal")
                {
                    tB_returnStatus.Text = "Returned book overdue";
                }
                else if (tB_returnStatus.Text == "Returned with damaged book")
                {
                    tB_returnStatus.Text = "Returned book overdue and damaged book";
                }
            }
            else
            {
                if (tB_returnStatus.Text == "Returned with damaged book")
                {
                    //
                }
                else if (tB_returnStatus.Text == "Returned book overdue and damaged book")
                {
                    tB_returnStatus.Text = "Returned with damaged book";
                }
                else
                {
                    tB_returnStatus.Text = "Normal";
                }
            }
        }

        private void uc_TransReturn_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                tB_memID1.Text = "";
                tB_loanID.Text = "";
                tB_loanDate.Text = "";
                tB_dueDate.Text = "";
                tB_book_loan_num.Text = "";
                tB_book_return_num.Text = "";
                tB_returnStatus.Text = "";
                cB_book_status.SelectedIndex = -1;
                bookList.Clear();
                tB_memID2.Text = "";
                tB_memName.Text = "";
                tB_bookID.Text = "";
                dTP_returnDate.Value = DateTime.Now;
            }
        }
    }
}
