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
    public partial class uc_TransMembership : UserControl
    {
        public uc_TransMembership()
        {
            InitializeComponent();
        }

        private List<MembershipType> membershipTypes;

        private void GetMembershipDetail()
        {
            cB_mem_type.DataSource = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM membership_type", connection);
                SqlDataReader reader = command.ExecuteReader();

                membershipTypes = new List<MembershipType>();

                while (reader.Read())
                {
                    MembershipType type = new MembershipType();

                    type.Id = (short)reader["MST_ID"];
                    type.Title = (string)reader["Title"];
                    type.Fee = (decimal)reader["Fee"];
                    type.MaxNumBook = (short)reader["Max_num_book"];
                    type.MaxLoanDay = (short)reader["Max_loan_day"];

                    membershipTypes.Add(type);
                }

                cB_mem_type.DataSource = membershipTypes;
                cB_mem_type.DisplayMember = "Title";
                cB_mem_type.ValueMember = "Id";

                reader.Close();

            }
        }

        private void tB_memID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string memberID = tB_memID.Text;
                string query = "SELECT m.Name, " +
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
                    else
                    {
                        while (reader.Read())
                        {
                            tB_memName.Text = reader["Name"].ToString();
                            tB_current_mem.Text = reader["Membership"].ToString();
                        }
                    }
                    connection.Close();
                }
            }
        }
        private void tB_memID_Leave(object sender, EventArgs e)
        {
            tB_memID_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
        public class MembershipType
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Fee { get; set; }
            public int MaxNumBook { get; set; }
            public int MaxLoanDay { get; set; }
        }

        private void cB_mem_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_mem_type.SelectedItem != null)
            {
                MembershipType selectedType = (MembershipType)cB_mem_type.SelectedItem;

                tB_mem_fee.Text = selectedType.Fee.ToString("N0");
                tB_max_book.Text = selectedType.MaxNumBook.ToString();
                tB_max_day.Text = selectedType.MaxLoanDay.ToString();
            }
        }

        private void bT_save_Click(object sender, EventArgs e)
        {
            string memberID = tB_memID.Text;
            while (cB_mem_type.SelectedItem == null)
            {
                MessageBox.Show("Please chose membership type.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MembershipType selectedType = (MembershipType)cB_mem_type.SelectedItem;
            string memType = selectedType.Title.ToString();
            DateTime addDate = dTP_addedDate.Value;
            DateTime expiry_date = addDate;
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("InsertMembership", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@memID", memberID));
                cmd.Parameters.Add(new SqlParameter("@mem_type", memType));
                cmd.Parameters.Add(new SqlParameter("@ex_date", expiry_date));

                cmd.ExecuteNonQuery();
            }

            uc_TransPayment1 paymentControl = new uc_TransPayment1
            {
                MemberID = memberID,
                sw = 0,
                Date = addDate
            };
            this.Parent.Controls.Add(paymentControl);
            this.Hide();
            paymentControl.BringToFront();
            paymentControl.Size = new Size(833, 696);
            paymentControl.Location = new Point(224, 0);

        }

        private void uc_TransMembership_Load(object sender, EventArgs e)
        {
            dTP_addedDate.Format = DateTimePickerFormat.Custom;
            dTP_addedDate.CustomFormat = "dd/MM/yyyy";
            GetMembershipDetail();
        }

        private void uc_TransMembership_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false)
            {
                tB_memID.Text = string.Empty;
                tB_memName.Text = string.Empty;
                tB_current_mem.Text = string.Empty;
                tB_mem_fee.Text = string.Empty;
                tB_max_book.Text = string.Empty;
                tB_max_day.Text = string.Empty;
                cB_mem_type.SelectedIndex = -1;
                dTP_addedDate.Value = DateTime.Now;

            }
        }
    }
}
