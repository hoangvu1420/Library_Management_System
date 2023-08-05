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
    public partial class uc_RecordReturn : UserControl
    {
        public uc_RecordReturn()
        {
            InitializeComponent();
        }

        private void uc_RecordReturn_Load(object sender, EventArgs e)
        {
            dGV_return_list.DataSource = GetReturnList();
            dGV_return_list.Columns[0].Width = 100;
            dGV_return_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_return_list.Columns[1].Width = 100;
            dGV_return_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_return_list.Columns[3].Width = 150;
            dGV_return_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_return_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Font headerFont = new Font("Lora", 10, FontStyle.Bold);
            foreach (DataGridViewColumn column in dGV_return_list.Columns)
            {
                column.HeaderCell.Style.Font = headerFont;
            }
            Font cellFont = new Font("Lora", 10);
            dGV_return_list.DefaultCellStyle.Font = cellFont;
        }

        DataTable GetReturnList()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("ReturnList", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    data.Load(reader);
                }

                connection.Close();
            }

            return data;
        }

        private void dGV_return_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_text();
        }

        private void Update_text()
        {
            int i = dGV_return_list.CurrentRow.Index;
            tB_returnID.Text = dGV_return_list.Rows[i].Cells[0].Value.ToString();
            tB_loanID.Text = dGV_return_list.Rows[i].Cells[1].Value.ToString();
            tB_memID.Text = dGV_return_list.Rows[i].Cells[2].Value.ToString();
            tB_returnDate.Text = dGV_return_list.Rows[i].Cells[3].Value.ToString();
            tB_loanQuantity.Text = dGV_return_list.Rows[i].Cells[4].Value.ToString();
            tB_returnQuantity.Text = dGV_return_list.Rows[i].Cells[5].Value.ToString();
            tB_returnStatus.Text = dGV_return_list.Rows[i].Cells[6].Value.ToString();

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("GetReturnList", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@returnID", tB_returnID.Text));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                connection.Close();
            }
            dGV_book_list.DataSource = dt;

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
    }
}
