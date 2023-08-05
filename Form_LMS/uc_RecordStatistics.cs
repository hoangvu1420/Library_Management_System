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
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Policy;

namespace Form_LMS
{
    public partial class uc_RecordStatistics : UserControl
    {
        public uc_RecordStatistics()
        {
            InitializeComponent();

        }

        string topDay;
        decimal topRevenue = 0;
        string botDay;
        decimal botRevenue = decimal.MaxValue;

        private void uc_RecordStatistics_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                decimal revenue = 0;
                int days = 0;

                string query = @"SELECT * FROM v_RevenueSta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string date = Convert.ToDateTime(reader[0]).ToString("dd/MM");
                    int amount = Convert.ToInt32(reader[1]);
                    chart_revenue.Series["Revenue"].Points.AddXY(date, amount);
                    revenue += amount;
                    days++;
                    if (amount > topRevenue)
                    {
                        topRevenue = amount;
                        topDay = Convert.ToDateTime(reader[0]).ToString("dd/MM/yyyy");
                    }
                    if (amount < botRevenue)
                    {
                        botRevenue = amount;
                        botDay = Convert.ToDateTime(reader[0]).ToString("dd/MM/yyyy");
                    }
                }
                tB_revenue.Text = revenue.ToString("N0");
                tB_days.Text = days.ToString();
                tB_topRevenue.Text = topDay + " (" + topRevenue.ToString("N0") + ")";
                tB_botRevenue.Text = botDay + " (" + botRevenue.ToString("N0") + ")";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                string query = @"SELECT * FROM v_PaymentMethodSta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart_method.Series["Payment Method"].Points.AddXY(reader[0].ToString(), Convert.ToInt32(reader[1]));
                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                string query = @"SELECT * FROM v_PaymentTypeSta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart_type.Series["Payment Type"].Points.AddXY(reader[0].ToString(), Convert.ToInt32(reader[1]));
                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                int totalLoan = 0;
                int totalDays = 0;
                string query = @"SELECT * FROM v_LoanedQuantitySta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart_loanQuan.Series["Loaned quantity"].Points.AddXY(Convert.ToDateTime(reader[1]).ToString("dd/MM"), Convert.ToInt32(reader[0]));
                    totalLoan += Convert.ToInt32(reader[0]);
                    totalDays++;
                }
                tB_totalLoan.Text = totalLoan.ToString();
                tB_loanDays.Text = totalDays.ToString();
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                string query = @"SELECT * FROM v_LoanStatusSta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart_acpLoan.Series["Loan Status"].Points.AddXY(reader[0].ToString(), Convert.ToInt32(reader[1]));
                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                string query = @"SELECT * FROM v_LoanByMemberSta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart_loanMem.Series["Loan member"].Points.AddXY(reader[0].ToString(), Convert.ToInt32(reader[1]));
                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                int totalReturn = 0;
                string query = @"SELECT * FROM v_ReturnStatusSta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart_return.Series["Return status"].Points.AddXY(reader[0].ToString(), Convert.ToInt32(reader[1]));
                    totalReturn += Convert.ToInt32(reader[1]);
                }
                tB_returnNum.Text = totalReturn.ToString();
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.ConStr))
            {
                int totalFine = 0;
                int totalAmount = 0;
                string query = @"SELECT * FROM v_FineTypeSta";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart_fineNum.Series["Fine type"].Points.AddXY(reader[0].ToString(), Convert.ToInt32(reader[1]));
                    chart_fineAmount.Series["Fine amount"].Points.AddXY(reader[0].ToString(), Convert.ToInt32(reader[2]));
                    totalFine += Convert.ToInt32(reader[1]);
                    totalAmount += Convert.ToInt32(reader[2]);
                }
                tB_fineNum.Text = totalFine.ToString();
                tB_fineAmount.Text = totalAmount.ToString("N0");
            }
        }

        private void chart_loanQuan_Click(object sender, EventArgs e)
        {
            var pos = chart_loanQuan.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
            if (pos.ChartElementType == ChartElementType.DataPoint)
            {
                var point = pos.Object as DataPoint;
                var loanedQuantity = point.YValues[0];
                var date = point.AxisLabel;

                MessageBox.Show($"Loaned Quantity: {loanedQuantity}\nDate: {date}");
            }
        }

        private void chart_revenue_Click(object sender, EventArgs e)
        {
            var pos = chart_revenue.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
            if (pos.ChartElementType == ChartElementType.DataPoint)
            {
                var point = pos.Object as DataPoint;
                var revenue = point.YValues[0];
                var date = point.AxisLabel;

                MessageBox.Show($"Loaned Quantity: {revenue}\nDate: {date}");
            }
        }

        private void chart_loanMem_Click(object sender, EventArgs e)
        {
            var pos = chart_loanMem.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
            if (pos.ChartElementType == ChartElementType.DataPoint)
            {
                var point = pos.Object as DataPoint;
                var total = point.YValues[0];
                var memID = point.AxisLabel;

                MessageBox.Show($"Member ID: {memID}\nTotal loans: {total}");
            }
        }

        private void tP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tP.SelectedIndex == 0)
            {
                //chart_loanQuan.Click -= chart_loanQuan_Click;
            }
        }

        private void chart_revenue_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            HitTestResult result = chart_revenue.HitTest(mousePosition.X, mousePosition.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chart_loanQuan_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            HitTestResult result = chart_loanQuan.HitTest(mousePosition.X, mousePosition.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void chart_loanMem_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            HitTestResult result = chart_loanMem.HitTest(mousePosition.X, mousePosition.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
