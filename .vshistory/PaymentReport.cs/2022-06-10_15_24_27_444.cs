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
        }

        private void PaymentReport_Load(object sender, EventArgs e)
        {
            txtsrch.Focus();
            connection.Open();


            SqlCommand cm = new SqlCommand("SELECT  P.PaymentID , P.StudentNumber ,S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber", connection);
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



            
        }

        private void butFiltr_Click(object sender, EventArgs e)
        {
            if (txtsrch.TextLength > 0)
            {


                try
                {
                    connection.Open();
                    if (checkStdComp.Checked)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT  P.PaymentID , P.StudentNumber ,S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE P.Amount >= 0 AND S.Name LIKE '%" + txtsrch.Text + "%'", connection);
                        Payment = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Payment);

                        dataPayment.DataSource = Payment;

                    }
                    else if (checkDntComp.Checked)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT  P.PaymentID , P.StudentNumber ,S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE P.Amount LIKE '-%' AND S.Name LIKE '%" + txtsrch.Text + "%'", connection);
                        Payment = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Payment);

                        dataPayment.DataSource = Payment;
                    }
                    else
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT  P.PaymentID , P.StudentNumber ,S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE S.Name LIKE '%" + txtsrch.Text + "%'", connection);
                        Payment = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Payment);

                        dataPayment.DataSource = Payment;

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else if (txtsrch.TextLength == 0)
            {
                try
                {
                    connection.Open();
                    if (checkDntComp.Checked)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT  P.PaymentID , P.StudentNumber ,S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE P.Amount LIKE '-%'", connection);
                        Payment = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Payment);

                        dataPayment.DataSource = Payment;
                    }
                    if (checkStdComp.Checked)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT  P.PaymentID , P.StudentNumber ,S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber WHERE P.Amount >= 0  ", connection);
                        Payment = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Payment);

                        dataPayment.DataSource = Payment;

                    }
                    else
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT  P.PaymentID , P.StudentNumber ,S.Name , P.Amount FROM Payment P INNER JOIN Students S ON S.StudentNumber = P.StudentNumber", connection);
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
                finally { connection.Close(); }
                }
        }

        private void checkStdComp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkDntComp_CheckedChanged(object sender, EventArgs e)
        {



        }
    }
}
