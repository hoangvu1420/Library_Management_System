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
    public partial class uc_BookQuery : UserControl
    {
        public uc_BookQuery()
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in dGV_result.Columns)
            {
                column.HeaderCell.Style.Font = headerFont;
            }
            dGV_result.DefaultCellStyle.Font = cellFont;
        }
        Font headerFont = new Font("Lora", 10, FontStyle.Bold);
        Font cellFont = new Font("Lora", 10);
        string query;

        private void cB_query_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_query.SelectedIndex == 0)
            {
                dGV_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                query = "SELECT * FROM v_author va\n" +
                        "ORDER BY va.[Number of books] DESC";
                ExecQuery();
            }
            else if (cB_query.SelectedIndex == 1)
            {
                dGV_result.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                query = "SELECT * FROM v_category vc\n" +
                        "ORDER BY vc.[Number of books] DESC";
                ExecQuery();
            }
            else if (cB_query.SelectedIndex == 2)
            {
                query = "SELECT * FROM v_unreturnedBooks vb\n" +
                        "ORDER BY vb.[Loaning quantity] DESC";
                ExecQuery();
                dGV_result.Columns[0].Width = 200;
                dGV_result.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_result.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dGV_result.Columns[2].Width = 200;
                dGV_result.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            else if (cB_query.SelectedIndex == 3)
            {
                query = "SELECT * FROM v_numberOfLoanedTimes volt\n" +
                        "ORDER BY volt.[Number of loaned times] DESC";
                ExecQuery();
                dGV_result.Columns[0].Width = 200;
                dGV_result.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_result.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dGV_result.Columns[2].Width = 200;
                dGV_result.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void ExecQuery()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dGV_result.DataSource = dt;

                connection.Close();
            }
        }
    }
}
