using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form_LMS
{
    public partial class uc_BookInsert : UserControl
    {
        public uc_BookInsert()
        {
            InitializeComponent();
        }

        private void bT_save_Click(object sender, EventArgs e)
        {
            string title = tB_title.Text;
            string author = tB_author.Text;
            string category = tB_category.Text;
            int pubYear = Convert.ToInt32(tB_pubYear.Text);
            int num_cop = Convert.ToInt32(tB_num_cop.Text);

            string[] author_part = author.Split(',');
            for (int i = 0; i < author_part.Length; i++)
            {
                author_part[i] = author_part[i].Trim();
            }
            string[] category_part = category.Split(',');
            for (int i = 0; i < category_part.Length; i++)
            {
                category_part[i] = category_part[i].Trim();
            }

            int n = author_part.Length;

            if (author_part.Length < category_part.Length)
            {
                n = category_part.Length;
            }

            int return_value = 0;
            for (int i = 0; i < n; i++)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("InsertBook", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@title", title));

                    if (i >= author_part.Length)
                        cmd.Parameters.Add(new SqlParameter("@author", author_part[author_part.Length - 1]));
                    else
                        cmd.Parameters.Add(new SqlParameter("@author", author_part[i]));
                    if (i >= category_part.Length)
                        cmd.Parameters.Add(new SqlParameter("@category", category_part[category_part.Length - 1]));
                    else
                        cmd.Parameters.Add(new SqlParameter("@category", category_part[i]));

                    cmd.Parameters.Add(new SqlParameter("@pub_year", pubYear));
                    cmd.Parameters.Add(new SqlParameter("@num_cop", num_cop));

                    SqlParameter resultParam = new SqlParameter("@result", SqlDbType.Int);
                    resultParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultParam);

                    cmd.ExecuteNonQuery();

                    int output = (int)cmd.Parameters["@result"].Value;
                    return_value = output;
                    if (return_value == 0)
                    {
                        MessageBox.Show("Book already exsists", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();//
                        break;
                    }
                    connection.Close();
                }
            }
            if (return_value == 1)
            {
                MessageBox.Show("Successfully inserted new book", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            tB_author.Text = "";
            tB_category.Text = "";
            tB_title.Text = "";
            tB_pubYear.Text = "";
            tB_num_cop.Text = "";
        }
    }
}
