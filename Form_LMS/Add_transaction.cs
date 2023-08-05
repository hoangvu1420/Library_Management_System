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
    public partial class Add_transaction : Form
    {
        public Add_transaction()
        {
            InitializeComponent();
            uc_TransMembership1.Hide();
            uc_TransLoan1.Hide();
            uc_TransPayment1.Hide();
            uc_TransReturn1.Hide();
            lb1.SendToBack();
        }

        private void bt_add_membership_Click(object sender, EventArgs e)
        {
            uc_TransMembership1.Hide();
            uc_TransLoan1.Hide();
            uc_TransPayment1.Hide();
            uc_TransReturn1.Hide();
            this.Size = new Size(1081, 742);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_TransMembership1.Show();
        }

        private void Add_trans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void bt_payment_Click(object sender, EventArgs e)
        {
            uc_TransMembership1.Hide();
            uc_TransLoan1.Hide();
            uc_TransPayment1.Hide();
            uc_TransReturn1.Hide();
            this.Size = new Size(1081, 742);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_TransPayment1.Show();
        }

        private void bt_loan_Click(object sender, EventArgs e)
        {
            uc_TransMembership1.Hide();
            uc_TransLoan1.Hide();
            uc_TransPayment1.Hide();
            uc_TransReturn1.Hide();
            this.Size = new Size(1370, 742);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_TransLoan1.Show();
            uc_TransLoan1.Location = new Point(224, 0);
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            uc_TransMembership1.Hide();
            uc_TransLoan1.Hide();
            uc_TransPayment1.Hide();
            uc_TransReturn1.Hide();
            this.Size = new Size(1370, 742);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_TransReturn1.Show();
            uc_TransReturn1.Location = new Point(224, 0);
        }

        private void CenterFormOnScreen(Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            int x = bounds.Left + (bounds.Width - this.Width) / 2;
            int y = bounds.Top + (bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }
    }
}
