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
    public partial class uc_TransPayment : UserControl
    {
        public uc_TransPayment()
        {
            InitializeComponent();
        }

        private void uc_TransPayment_Load(object sender, EventArgs e)
        {
            dTP_paymentDate.Format = DateTimePickerFormat.Custom;
            dTP_paymentDate.CustomFormat = "dd/MM/yyyy";
        }

        public class Membership
        {
            public string Title { get; set; }
            public decimal Fee { get; set; }
            public DateTime ExDate { get; set; }
        }

        public class Fine
        {
            public string FineType { get; set; }
            public decimal FineAmount { get; set; }
        }

        Fine fine = new Fine();
        Membership type = new Membership();
        string memID;
        string payType = null;
        decimal payAmount = 0;
        int month_num = 0;

        private void bT_save_Click(object sender, EventArgs e)
        {

            memID = tB_memID.Text.ToString();
            if (cB_pay_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose payment type.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            payType = cB_pay_type.SelectedItem.ToString();
            if (payType == "Membership fee payment")
            {
                if (string.IsNullOrEmpty(tB_month_num.Text))
                {
                    MessageBox.Show("Please enter number of renewal months.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                month_num = Convert.ToInt32(tB_month_num.Text);
                payAmount = decimal.Parse(tB_pay_amount.Text);
            }
            else
            {
                tB_month_num.Enabled = false;
                payAmount = Convert.ToDecimal(tB_pay_amount.Text);
            }
            if (cB_pay_type.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all fields.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime payDate = dTP_paymentDate.Value;
            string payMethod = cB_pay_method.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("InsertPayment", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@memID", memID));
                cmd.Parameters.Add(new SqlParameter("@renewal_month", month_num));
                cmd.Parameters.Add(new SqlParameter("@pay_date", payDate));
                cmd.Parameters.Add(new SqlParameter("@pay_method", payMethod));
                cmd.Parameters.Add(new SqlParameter("@pay_type", payType));

                cmd.ExecuteNonQuery();
                connection.Close();
            }

            if (payType == "Membership fee payment")
            {
                MessageBox.Show("Successfully extended membership for another " + month_num + " months.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (payType == "Fine payment")
            {
                MessageBox.Show("The fine has been successfully paid. The member's status will be restored to normal.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();

        }

        private void cB_pay_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_memID.Text))
            {
                MessageBox.Show("Please enter member ID.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cB_pay_type.SelectedIndex = -1;
                return;
            }
            memID = tB_memID.Text.ToString();
            tB_month_num.Text = string.Empty;
            tB_pay_amount.Text = string.Empty;
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("MembershipSearch", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlCommand cmd1 = new SqlCommand("UnpaidFineSearch", connection);
                cmd1.CommandType = CommandType.StoredProcedure;
                
                if(cB_pay_type.SelectedIndex == 0 && !string.IsNullOrEmpty(memID))
                {
                    cmd.Parameters.Add(new SqlParameter("@memID", memID));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.HasRows)
                        {
                            type = null;
                        }
                        else
                        {
                            type.Title = (string)reader["Membership"];
                            type.Fee = (decimal)reader["Membership Fee"];
                            type.ExDate = (DateTime)reader["Expiry Date"];
                        }
                    }
                }
                else if (cB_pay_type.SelectedIndex == 1 && !string.IsNullOrEmpty(memID))
                {
                    cmd1.Parameters.Add(new SqlParameter("@memID", memID));
                    using (SqlDataReader reader = cmd1.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.HasRows)
                        {
                            fine = null;
                        }
                        else
                        {
                            fine.FineType = (string)reader["Fine Type"];
                            fine.FineAmount = (decimal)reader["Fine Amount"];
                        }
                    }
                }
                connection.Close();
            }

            if (cB_pay_type.SelectedIndex == 0)
            {
                if (type == null)
                {
                    MessageBox.Show("This member does not currently have a membership, please add a membership before renewing.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cB_pay_type.SelectedIndex = -1;
                    return;
                }
                label7.Text = "Number of renewal months:";
                label7.Location = new Point(83, 271);
                label7.Font = new Font("Lora", 10, FontStyle.Regular);
                tB_month_num.Enabled = true;
                tB_pay_amount.Enabled = false;
            }
            else if (cB_pay_type.SelectedIndex == 1)
            {
                if (fine == null)
                {
                    MessageBox.Show("This member currently has no fine to pay.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cB_pay_type.SelectedIndex = -1;
                    return;
                }
                label7.Text = "Fine type:";
                label7.Location = new Point(208, 266);
                label7.Font = new Font("Lora", 12, FontStyle.Regular);
                tB_month_num.Enabled = false;
                tB_month_num.Text = fine.FineType.ToString();
                tB_pay_amount.Enabled = false;
                tB_pay_amount.Text = fine.FineAmount.ToString("N0");
            }

        }

        private void tB_month_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(tB_month_num.Text, out int month_num))
                {
                    payAmount = month_num * type.Fee;
                    tB_pay_amount.Enabled = false;
                    tB_pay_amount.Text = payAmount.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of month.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tB_month_num.Text = string.Empty;
                }
            }
        }

        private void tB_month_num_Leave(object sender, EventArgs e)
        {
            KeyEventArgs key = new KeyEventArgs(Keys.Enter);
            tB_month_num_KeyDown(sender, key);
        }

        private void tB_memID_Leave(object sender, EventArgs e)
        {
            string memberID = tB_memID.Text;
            string query =  "SELECT m.Name, " +
                            "ISNULL(mst.Title, '-') AS 'Membership' " +
                            "FROM member m " +
                            "LEFT JOIN membership ms ON m.M_ID = ms.M_ID " +
                            "LEFT JOIN membership_type mst ON ms.MST_ID = mst.MST_ID " +
                            "WHERE m.ID_withChar = '" + memberID + "'";
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("Member ID not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void uc_TransPayment_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                cB_pay_type.SelectedIndex = -1;
                tB_memID.Text = string.Empty;
                tB_month_num.Text = string.Empty;
                tB_pay_amount.Text = string.Empty;
                cB_pay_method.SelectedIndex = -1;
                dTP_paymentDate.Value = DateTime.Now;
            }
        }
    }
}
