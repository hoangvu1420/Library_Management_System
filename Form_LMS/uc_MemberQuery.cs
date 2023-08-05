using System;
using System.Collections;
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
    public partial class uc_MemberQuery : UserControl
    {
        public uc_MemberQuery()
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
                query = "SELECT * FROM v_numberOfLoansByMember volbm\n" +
                        "ORDER BY volbm.[Member ID] ASC";
                ExecQuery();
            }
            else if (cB_query.SelectedIndex == 1)
            {
                query = "SELECT * FROM v_aboutToExpire vte\n" +
                        "ORDER BY vte.[Member ID] ASC";
                ExecQuery();
            }
            else if (cB_query.SelectedIndex == 2)
            {
                query = "SELECT * FROM v_numberOfFinesByMember vofbm\n" +
                        "ORDER BY vofbm.[Member ID] ASC";
                ExecQuery();
            }
            else if (cB_query.SelectedIndex == 3)
            {
                query = "SELECT * FROM v_paymentStatistics vs\n" +
                        "ORDER BY vs.[Member ID] ASC";
                ExecQuery();
                dGV_result.Columns[0].Width = 150;
                dGV_result.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_result.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dGV_result.Columns[2].Width = 150;
                dGV_result.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_result.Columns[3].Width = 150;
                dGV_result.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_result.Columns[4].Width = 150;
                dGV_result.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            if(cB_query.SelectedIndex < 3)
            {
                dGV_result.Columns[0].Width = 200;
                dGV_result.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_result.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dGV_result.Columns[2].Width = 200;
                dGV_result.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_result.Columns[3].Width = 200;
                dGV_result.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private void ExecQuery()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    dGV_result.DataSource = dt;
                }

                connection.Close();
            }
        }
    }
}
