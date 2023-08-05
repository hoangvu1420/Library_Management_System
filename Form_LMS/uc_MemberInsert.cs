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
    public partial class uc_MemberInsert : UserControl
    {
        public uc_MemberInsert()
        {
            InitializeComponent();
            dTP_birthday.Format = DateTimePickerFormat.Custom;
            dTP_birthday.CustomFormat = "dd/MM/yyyy";
        }

        private void bT_save_Click(object sender, EventArgs e)
        {
            string name = tB_name.Text;
            string phone = tB_phone.Text;
            string birthday = dTP_birthday.Value.ToString("yyyy-MM-dd");
            string sex = cB_sex.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("InsertMember", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@birthday", birthday));
                cmd.Parameters.Add(new SqlParameter("@sex", sex));
                cmd.Parameters.Add(new SqlParameter("@phone", phone));

                SqlParameter resultParam = new SqlParameter("@result", SqlDbType.Int);
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                cmd.ExecuteNonQuery();

                int output = (int)cmd.Parameters["@result"].Value;

                connection.Close();
                if (output == 0)
                    MessageBox.Show("Member already exsists", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Member inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tB_name.Text = "";
            tB_phone.Text = "";
            dTP_birthday.Value = DateTime.Now;
            cB_sex.SelectedIndex = -1;
        }
    }
}
