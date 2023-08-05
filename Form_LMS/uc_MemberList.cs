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
    public partial class uc_MemberList : UserControl
    {
        public uc_MemberList()
        {
            InitializeComponent();
        }

        private void uc_MemberList_Load(object sender, EventArgs e)
        {
            dGV_member.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV_member.DataSource = GetMemberList();
            dGV_member.Columns[0].Width = 100;
            dGV_member.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV_member.Columns[1].Width = 300;
            dGV_member.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dGV_member.Columns[7].Visible = false;
            dGV_member.Columns[9].Visible = false;
            dGV_member.Columns[10].Visible = false;
        }

        DataTable GetMemberList()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {

                SqlCommand cmd = new SqlCommand("MemberInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    data.Load(reader);
                }
                connection.Close();

            }

            return data;
        }

        private void dGV_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_detail(dGV_member.CurrentRow.Index);
        }

        private void Update_detail(int i)
        {
            tB_ID.Text = dGV_member.Rows[i].Cells[0].Value.ToString();
            tB_name.Text = dGV_member.Rows[i].Cells[1].Value.ToString();
            tB_birthday.Text = dGV_member.Rows[i].Cells[2].Value.ToString();
            tB_sex.Text = dGV_member.Rows[i].Cells[3].Value.ToString();
            tB_phone.Text = dGV_member.Rows[i].Cells[4].Value.ToString();
            tB_mem_status.Text = dGV_member.Rows[i].Cells[5].Value.ToString();
            tB_membership.Text = dGV_member.Rows[i].Cells[6].Value.ToString();
            tB_memFee.Text = dGV_member.Rows[i].Cells[7].Value.ToString();
            if (dGV_member.Rows[i].Cells[8].Value.ToString() == "-")
                tB_memDate.Text = "-";
            else
                tB_memDate.Text = dGV_member.Rows[i].Cells[8].Value.ToString();
            tB_addTime.Text = DateTime.Parse(dGV_member.Rows[i].Cells[9].Value.ToString()).ToString("dd/MM/yyyy HH:mm:ss");
            tB_updateTime.Text = DateTime.Parse(dGV_member.Rows[i].Cells[10].Value.ToString()).ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void uc_MemberList_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                dGV_member.DataSource = GetMemberList();
                dGV_member.Columns[0].Width = 100;
                dGV_member.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dGV_member.Columns[1].Width = 300;
                dGV_member.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dGV_member.Columns[7].Visible = false;
                dGV_member.Columns[9].Visible = false;
                dGV_member.Columns[10].Visible = false;
            }
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            string memID = null;
            string memName = null;
            string memSex = null;
            int DoBday = 0;
            int DoBmonth = 0;
            string membership = null;

            if(!string.IsNullOrEmpty(tB_searchMemberID.Text))
            {
                memID = tB_searchMemberID.Text;
            }
            if(!string.IsNullOrEmpty(tB_searchName.Text))
            {
                memName = tB_searchName.Text;
            }
            if(!string.IsNullOrEmpty(tB_searchSex.Text))
            {
                memSex = tB_searchSex.Text;
            }
            if(!string.IsNullOrEmpty(tB_searchBirthday.Text))
            {
                string[] parts = tB_searchBirthday.Text.Split('/');
                if (!int.TryParse(parts[0], out DoBday) || !int.TryParse(parts[1], out DoBmonth))
                {
                    MessageBox.Show("Invalid date format, use the format dd/mm");
                    return;
                }
            }
            if(!string.IsNullOrEmpty(tB_searchMembership.Text))
            {
                membership = tB_searchMembership.Text;
            }

            using(SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                SqlCommand cmd = new SqlCommand("FilterMembers", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@memID", memID);
                cmd.Parameters.AddWithValue("@name", memName);
                if(DoBday == 0 && DoBmonth == 0)
                {
                    cmd.Parameters.AddWithValue("@DoB_day", DBNull.Value);
                    cmd.Parameters.AddWithValue("@DoB_month", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DoB_day", DoBday);
                    cmd.Parameters.AddWithValue("@DoB_month", DoBmonth);
                }
                cmd.Parameters.AddWithValue("@sex", memSex);
                cmd.Parameters.AddWithValue("@membership", membership);
                connection.Open();

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        dGV_member.DataSource = data;
                        Update_detail(0);
                        dGV_member.Columns[0].Width = 100;
                        dGV_member.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dGV_member.Columns[1].Width = 300;
                        dGV_member.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                        dGV_member.Columns[7].Visible = false;
                        dGV_member.Columns[9].Visible = false;
                        dGV_member.Columns[10].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No results found");
                    }
                }
                connection.Close();
            }
        }
    }
}
