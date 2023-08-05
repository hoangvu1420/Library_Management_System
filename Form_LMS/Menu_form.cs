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
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void Menu_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void bt_add_trans_Click(object sender, EventArgs e)
        {
            Add_transaction add_Trans = new Add_transaction();
            this.Hide();
            add_Trans.ShowDialog();
            add_Trans = null;
            this.Show();
        }

        private void bt_trans_record_Click(object sender, EventArgs e)
        {
            Transaction_record trans_Record = new Transaction_record();
            this.Hide();
            trans_Record.ShowDialog();
            trans_Record = null;
            this.Show();
        }

        private void bt_book_management_Click(object sender, EventArgs e)
        {
            Book_management book_Form = new Book_management();
            this.Hide();
            book_Form.ShowDialog();
            book_Form = null;
            this.Show();
        }

        private void bt_member_management_Click(object sender, EventArgs e)
        {
            Member_management show_Form = new Member_management();
            this.Hide();
            show_Form.ShowDialog();
            show_Form = null;
            this.Show();
        }
    }
}
