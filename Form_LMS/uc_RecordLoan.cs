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
    public partial class uc_RecordLoan : UserControl
    {
        public uc_RecordLoan()
        {
            InitializeComponent();
        }

        private void uc_RecordLoan_Load(object sender, EventArgs e)
        {
            dGV_loan_list.DataSource = GetLoanList();
            dGV_loan_list.Columns[0].Width = 100;
            dGV_loan_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_loan_list.Columns[1].Width = 100;
            dGV_loan_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_loan_list.Columns[2].Width = 150;
            dGV_loan_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_loan_list.Columns[3].Width = 150;
            dGV_loan_list.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_loan_list.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_loan_list.Columns[6].Width = 100;
            dGV_loan_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            Font headerFont = new Font("Lora", 10, FontStyle.Bold);
            foreach (DataGridViewColumn column in dGV_loan_list.Columns)
            {
                column.HeaderCell.Style.Font = headerFont;
            }
            Font cellFont = new Font("Lora", 10);
            dGV_loan_list.DefaultCellStyle.Font = cellFont;


        }

        DataTable GetLoanList()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("LoanList", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    data.Load(reader);
                }

                connection.Close();
            }

            return data;
        }

        private void Update_text()
        {
            int i = dGV_loan_list.CurrentRow.Index;
            tB_loanID.Text = dGV_loan_list.Rows[i].Cells[0].Value.ToString();
            tB_memID.Text = dGV_loan_list.Rows[i].Cells[1].Value.ToString();
            tB_loanDate.Text = dGV_loan_list.Rows[i].Cells[2].Value.ToString();
            tB_dueDate.Text = dGV_loan_list.Rows[i].Cells[3].Value.ToString();
            tB_numLoaned.Text = dGV_loan_list.Rows[i].Cells[4].Value.ToString();
            tB_loanStatus.Text = dGV_loan_list.Rows[i].Cells[5].Value.ToString();
            tB_returnID.Text = dGV_loan_list.Rows[i].Cells[6].Value.ToString();

            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("GetLoanList", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@loanID", tB_loanID.Text));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    data.Load(reader);
                }

                connection.Close();
            }
            dGV_book_list.DataSource = data;

            dGV_book_list.Columns[0].Width = 150;
            dGV_book_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_book_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Font headerFont = new Font("Lora", 10, FontStyle.Bold);
            Font cellFont = new Font("Lora", 10);
            foreach (DataGridViewColumn column in dGV_book_list.Columns)
            {
                column.HeaderCell.Style.Font = headerFont;
            }
            dGV_book_list.DefaultCellStyle.Font = cellFont;
        }

        private void dGV_loan_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_text();
        }
    }
}
