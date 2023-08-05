using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_LMS
{
    public partial class Transaction_record : Form
    {

        public Transaction_record()
        {
            InitializeComponent();
            uc_RecordLoan1.Hide();
            uc_RecordReturn1.Hide();
            uc_RecordFine1.Hide();
            uc_RecordPayment1.Hide();
            uc_RecordStatistics1.Hide();
            this.Size = new Size(1581, 930);
            lb1.SendToBack();
        }

        private void bt_loan_re_Click(object sender, EventArgs e)
        {
            uc_RecordLoan1.Hide();
            uc_RecordReturn1.Hide();
            uc_RecordFine1.Hide();
            uc_RecordPayment1.Hide();
            uc_RecordStatistics1.Hide();
            this.Size = new Size(1581, 930);

            CenterFormOnScreen(Screen.FromControl(this));
            uc_RecordLoan1.Show();
            uc_RecordLoan1.BringToFront();
        }

        private void CenterFormOnScreen(Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            int x = bounds.Left + (bounds.Width - this.Width) / 2;
            int y = bounds.Top + (bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void bt_member_list_Click(object sender, EventArgs e)
        {
            uc_RecordLoan1.Hide();
            uc_RecordReturn1.Hide();
            uc_RecordFine1.Hide();
            uc_RecordPayment1.Hide();
            uc_RecordStatistics1.Hide();
            this.Size = new Size(1581, 930);

            CenterFormOnScreen(Screen.FromControl(this));
            uc_RecordReturn1.Show();
            uc_RecordReturn1.BringToFront();
        }

        private void bt_payment_record_Click(object sender, EventArgs e)
        {
            uc_RecordLoan1.Hide();
            uc_RecordReturn1.Hide();
            uc_RecordFine1.Hide();
            uc_RecordPayment1.Hide();
            uc_RecordStatistics1.Hide();
            this.Size = new Size(1581, 930);

            CenterFormOnScreen(Screen.FromControl(this));
            uc_RecordPayment1.Show();
            uc_RecordPayment1.BringToFront();
        }

        private void bt_fine_record_Click(object sender, EventArgs e)
        {
            uc_RecordLoan1.Hide();
            uc_RecordReturn1.Hide();
            uc_RecordFine1.Hide();
            uc_RecordPayment1.Hide();
            uc_RecordStatistics1.Hide();
            this.Size = new Size(1581, 930);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_RecordFine1.Show();
            uc_RecordFine1.BringToFront();
        }

        private void Transaction_record_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bt_Statistics_Click(object sender, EventArgs e)
        {
            uc_RecordLoan1.Hide();
            uc_RecordReturn1.Hide();
            uc_RecordFine1.Hide();
            uc_RecordPayment1.Hide();
            uc_RecordStatistics1.Hide();
            this.Size = new Size(1723, 1013);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_RecordStatistics1.Show();
            uc_RecordStatistics1.BringToFront();
        }
    }
}
