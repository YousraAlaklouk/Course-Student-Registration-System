using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Course_Student_Registration_System
{
    public partial class PaymentReport : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public PaymentReport()
        {
            InitializeComponent();
        }
        DataTable Payment;
        private void butRlod_Click(object sender, EventArgs e)
        {
            checkDntComp.Checked = false;
            checkStdComp.Checked = false;
            txtsrch.Clear();
            dataPayment.Columns.Clear();
        }

        private void PaymentReport_Load(object sender, EventArgs e)
        {
            txtsrch.Focus();
            connection.Open();


            SqlCommand cm = new SqlCommand("SELECT * FROM Payment", connection);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cm;
            Payment = new DataTable();
            sda.Fill(Payment);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = Payment;
            dataPayment.DataSource = bSource;
            sda.Update(Payment);

            connection.Close();
        }



        private void butNtfy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" notified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtsrch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (checkStdComp.Checked)
                {
                    SqlDataAdapter cmd = new SqlDataAdapter("SELECT P.PaymentID , S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE Amount = 0 OR StudentName LIKE '" + txtsrch.Text + "'", connection);
                    Payment = new DataTable();
                    //to fill the data grid view according to the text written
                    cmd.Fill(Payment);

                    dataPayment.DataSource = Payment;

                }
                else if (checkDntComp.Checked)
                {
                    SqlDataAdapter cmd = new SqlDataAdapter("SELECT P.PaymentID , S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE Amount LIKE '%-%' OR StudentName LIKE '" + txtsrch.Text + "'", connection);
                    Payment = new DataTable();
                    //to fill the data grid view according to the text written
                    cmd.Fill(Payment);

                    dataPayment.DataSource = Payment;
                }
                else
                {

                    SqlDataAdapter cmd = new SqlDataAdapter("SELECT P.PaymentID , S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE PaymentID =" + txtsrch.Text + " OR StudentName LIKE '" + txtsrch.Text + "'", connection);
                    Payment = new DataTable();
                    //to fill the data grid view according to the text written
                    cmd.Fill(Payment);

                    dataPayment.DataSource = Payment;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close()
            }

            
        }
    }
}
