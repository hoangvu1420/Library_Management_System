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
    public partial class uc_TransPayment1 : UserControl
    {
        public string MemberID { get; set; }
        public List<string> MissBookList { get; set; }
        public int sw { get; set; }
        public DateTime Date { get; set; }
        public uc_TransPayment1()
        {
            InitializeComponent();
        }

        private void uc_TransPayment1_Load(object sender, EventArgs e)
        {
            dTP_paymentDate.Format = DateTimePickerFormat.Custom;
            dTP_paymentDate.CustomFormat = "dd/MM/yyyy";

            tB_memID.Text = MemberID.ToString();
            tB_memID.Enabled = false;

            memID = tB_memID.Text.ToString();

            cB_pay_type.SelectedIndex = sw;
            cB_pay_type.Enabled = false;

            dTP_paymentDate.Value = Date;
            dTP_paymentDate.Enabled = false;

            if (sw == 0)
            {
                label7.Text = "Number of renewal months:";
                label7.Location = new Point(82, 271);
                label7.Font = new Font("Lora", 10, FontStyle.Regular);
                tB_month_num.Enabled = true;
                tB_pay_amount.Enabled = false;
            }
            else if (sw == 1)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("UnpaidFineSearch", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@memID", MemberID));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        fine.FineType = (string)reader["Fine Type"];
                        fine.FineAmount = (decimal)reader["Fine Amount"];
                    }

                    connection.Close();
                }
                label7.Text = "Fine:";
                label7.Location = new Point(250, 271);
                label7.Font = new Font("Lora", 12, FontStyle.Regular);
                tB_month_num.Enabled = false;
                tB_month_num.Text = fine.FineType.ToString();
                tB_pay_amount.Enabled = false;
                tB_pay_amount.Text = fine.FineAmount.ToString("N0");
            }

        }

        public class Fine
        {
            public string FineType { get; set; }
            public decimal FineAmount { get; set; }
        }
        Fine fine = new Fine();

        public class Membership
        {
            public string Title { get; set; }
            public decimal Fee { get; set; }
            public DateTime ExDate { get; set; }
        }
        Membership type = new Membership();

        int month_num = 0;
        decimal payAmount = 0;
        string memID;

        private void bT_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_month_num.Text) && tB_month_num.Enabled == true)
            {
                MessageBox.Show("Please enter number of renewal months.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime payDate = Date;
            string payMethod = cB_pay_method.SelectedItem.ToString();
            string payType = cB_pay_type.SelectedItem.ToString();
            if (cB_pay_type.SelectedIndex == 0)
            {
                month_num = Convert.ToInt32(tB_month_num.Text);
            }
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

            if (sw == 0)
            {
                MessageBox.Show("Seccessfully granted membership to member " + memID, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The fine has been successfully paid. The member's status will be restored to normal.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Now, the Loan interface will be diaplayed that can make new a loan for the missing books, " +
                    "members can add more books to the loan if they want.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                uc_TransLoan loanControl = new uc_TransLoan
                {
                    MemID = memID,
                    ReLoanList = MissBookList,
                    Date = payDate
                };
                this.Parent.Controls.Add(loanControl);
                this.Parent.Size = new Size(1370, 742);
                loanControl.BringToFront();
                loanControl.Size = new Size(1130, 696);
                loanControl.Location = new Point(224, 0);

            }
            this.Hide();
        }

        private void tB_month_num_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(tB_month_num.Text, out int month_num))
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("MembershipSearch", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (!string.IsNullOrEmpty(memID))
                    {
                        cmd.Parameters.Add(new SqlParameter("@memID", memID));
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        type.Title = (string)reader["Membership"];
                        type.Fee = (decimal)reader["Membership Fee"];
                        type.ExDate = (DateTime)reader["Expiry Date"];
                        payAmount = month_num * type.Fee;
                    }

                    connection.Close();
                }
                tB_pay_amount.Enabled = false;
                tB_pay_amount.Text = payAmount.ToString("N0");
            }
        }

        private void tB_month_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tB_month_num_Leave(sender, e);
            }
        }
    }
}
