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
    public partial class uc_MemberUpdate : UserControl
    {
        public uc_MemberUpdate()
        {
            InitializeComponent();
            dTP_birthday.Format = DateTimePickerFormat.Custom;
            dTP_birthday.CustomFormat = "dd/MM/yyyy";
            dTP_birthday1.Format = DateTimePickerFormat.Custom;
            dTP_birthday1.CustomFormat = "dd/MM/yyyy";
        }

        string memberID;

        private void bt_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_memberID.Text))
            {
                MessageBox.Show("Please enter member ID to update.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            memberID = tB_memberID.Text.ToString();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("MemberSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", memberID));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        tB_name.Text = reader["Full name"].ToString();
                        dTP_birthday.Value = Convert.ToDateTime(reader["Date of birth"]);
                        cB_sex.Text = reader["Sex"].ToString();
                        tB_phone.Text = reader["Phone"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Member ID not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                connection.Close();
            }

            tB_name1.Text = tB_name.Text;
            dTP_birthday1.Value = dTP_birthday.Value;
            cB_sex1.Text = cB_sex.Text;
            tB_phone1.Text = tB_phone.Text;
        }

        private void tB_memberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_search_Click(sender, e);
            }
        }

        private void bT_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_name.Text) || string.IsNullOrEmpty(tB_phone.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to update this member?", "Confirm Update!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                SqlCommand cmd = new SqlCommand("UpdateMember", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@memID", memberID));
                cmd.Parameters.Add(new SqlParameter("@u_name", tB_name1.Text));
                cmd.Parameters.Add(new SqlParameter("@u_sex", cB_sex1.Text));
                cmd.Parameters.Add(new SqlParameter("@u_DoB", dTP_birthday1.Value));
                cmd.Parameters.Add(new SqlParameter("@u_phone", tB_phone1.Text));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Update member successfully.", "Update Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tB_memberID.Text = "";
            tB_name.Text = "";
            dTP_birthday.Value = DateTime.Now;
            cB_sex.SelectedIndex = 0;
            tB_phone.Text = "";
            tB_name1.Text = "";
            dTP_birthday1.Value = DateTime.Now;
            cB_sex1.SelectedIndex = 0;
            tB_phone1.Text = "";
        }
    }
}
