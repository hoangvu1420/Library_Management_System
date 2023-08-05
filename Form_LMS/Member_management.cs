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
    public partial class Member_management : Form
    {
        public Member_management()
        {
            InitializeComponent();
            this.Size = new Size(1122, 604);
            uc_MemberList1.Hide();
            uc_MemberInsert1.Hide();
            uc_MemberQuery1.Hide();
            uc_MemberUpdate1.Hide();
            lb1.SendToBack();
        }

        private void bt_insert_member_Click(object sender, EventArgs e)
        {
            uc_MemberInsert1.Hide();
            uc_MemberList1.Hide();
            uc_MemberQuery1.Hide();
            uc_MemberUpdate1.Hide();

            this.Size = new Size(1122, 604);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_MemberInsert1.Show();
            uc_MemberInsert1.BringToFront();
        }

        private void bt_member_list_Click(object sender, EventArgs e)
        {
            uc_MemberInsert1.Hide();
            uc_MemberList1.Hide();
            uc_MemberQuery1.Hide();
            uc_MemberUpdate1.Hide();

            this.Size = new Size(1709, 1013);
            CenterFormOnScreen(Screen.FromControl(this));

            uc_MemberList1.Show();
            uc_MemberList1.BringToFront();
        }

        private void Member_management_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CenterFormOnScreen(Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            int x = bounds.Left + (bounds.Width - this.Width) / 2;
            int y = bounds.Top + (bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void bt_query_Click(object sender, EventArgs e)
        {
            uc_MemberInsert1.Hide();
            uc_MemberList1.Hide();
            uc_MemberQuery1.Hide();
            uc_MemberUpdate1.Hide();

            this.Size = new Size(1392, 745);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_MemberQuery1.Show();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            uc_MemberInsert1.Hide();
            uc_MemberList1.Hide();
            uc_MemberQuery1.Hide();
            uc_MemberUpdate1.Hide();

            this.Size = new Size(1195, 1013);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_MemberUpdate1.Show();
        }
    }
}
