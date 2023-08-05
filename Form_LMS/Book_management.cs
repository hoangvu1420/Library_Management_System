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
    public partial class Book_management : Form
    {
        public Book_management()
        {
            InitializeComponent();
            this.Size = new Size(1073, 559);
            uc_insertBook1.Hide();
            uc_bookList1.Hide();
            uc_BookQuery1.Hide();
            uc_UpdateBook1.Hide();
        }

        private void bt_insert_book_Click(object sender, EventArgs e)
        {
            lb1.SendToBack();
            uc_insertBook1.Hide();
            uc_bookList1.Hide();
            uc_BookQuery1.Hide();
            uc_UpdateBook1.Hide();

            this.Size = new Size(1073, 559);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_insertBook1.Show();
        }

        private void bt_book_list_Click(object sender, EventArgs e)
        {
            lb1.SendToBack();
            uc_insertBook1.Hide();
            uc_bookList1.Hide();
            uc_BookQuery1.Hide();
            uc_UpdateBook1.Hide();

            this.Size = new Size(1718, 1003);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_bookList1.Show();
        }

        private void bt_query_Click(object sender, EventArgs e)
        {
            lb1.SendToBack();

            uc_insertBook1.Hide();
            uc_bookList1.Hide();
            uc_BookQuery1.Hide();
            uc_UpdateBook1.Hide();

            this.Size = new Size(1392, 745);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_BookQuery1.Show();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            lb1.SendToBack();

            uc_insertBook1.Hide();
            uc_bookList1.Hide();
            uc_BookQuery1.Hide();
            uc_UpdateBook1.Hide();

            this.Size = new Size(1190, 1003);
            CenterFormOnScreen(Screen.FromControl(this));
            uc_UpdateBook1.Show();
        }

        private void CenterFormOnScreen(Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            int x = bounds.Left + (bounds.Width - this.Width) / 2;
            int y = bounds.Top + (bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        private void Book_management_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
