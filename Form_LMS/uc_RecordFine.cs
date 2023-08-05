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
    public partial class uc_RecordFine : UserControl
    {
        public uc_RecordFine()
        {
            InitializeComponent();
        }

        private void uc_RecordFine_Load(object sender, EventArgs e)
        {
            dGV_fine_list.DataSource = GetFineList();
            dGV_fine_list.Columns[0].Width = 100;
            dGV_fine_list.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_fine_list.Columns[1].Width = 100;
            dGV_fine_list.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_fine_list.Columns[2].Width = 200;
            dGV_fine_list.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_fine_list.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGV_fine_list.Columns[6].Width = 100;
            dGV_fine_list.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_fine_list.Columns[7].Width = 100;
            dGV_fine_list.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            Font headerFont = new Font("Lora", 10, FontStyle.Bold);
            foreach (DataGridViewColumn column in dGV_fine_list.Columns)
            {
                column.HeaderCell.Style.Font = headerFont;
            }
            Font cellFont = new Font("Lora", 9);
            dGV_fine_list.DefaultCellStyle.Font = cellFont;
        }

        DataTable GetFineList()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("FineList", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                connection.Close();
            }

            return dt;
        }

        private void dGV_fine_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_text();
        }

        private void Update_text()
        {
            int i = dGV_fine_list.CurrentRow.Index;
            tB_fineID.Text = dGV_fine_list.Rows[i].Cells[0].Value.ToString();
            tB_memID.Text = dGV_fine_list.Rows[i].Cells[1].Value.ToString();
            tB_memName.Text = dGV_fine_list.Rows[i].Cells[2].Value.ToString();
            tB_fineType.Text = dGV_fine_list.Rows[i].Cells[3].Value.ToString();
            tB_fineAmount.Text = dGV_fine_list.Rows[i].Cells[4].Value.ToString();
            tB_fineDate.Text = dGV_fine_list.Rows[i].Cells[5].Value.ToString();
            tB_fineStatus.Text = dGV_fine_list.Rows[i].Cells[6].Value.ToString();
            tB_payID.Text = dGV_fine_list.Rows[i].Cells[7].Value.ToString();
        }
    }
}
