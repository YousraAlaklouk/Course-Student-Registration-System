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
   public partial class StudentPayment : Form
    {
        //connect the database
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public StudentPayment()
        {
            InitializeComponent();
        }



        //clear the fields method
        public void clear()
        {
            txtPay.Clear();
            txtStdNm.Clear();
            labStNam.Text = "";
            labSurname.Text = "";
            labWallet.Text = "";
        }

        //pay button 
        private void payButt_Click(object sender, EventArgs e)
        {
            try
            {


                connection.Open();
                //to update the wallet of the student
                SqlCommand cmd = new SqlCommand("UPDATE Students SET Wallet =Wallet + @w WHERE StudentNumber =@ID", connection);
                // to make a payment and insert that payment to the payment table
                SqlCommand sc = new SqlCommand("INSERT INTO Payment VALUES (@number ,@amount)", connection);
                //define the values 
                cmd.Parameters.AddWithValue("@w", Convert.ToInt16(txtPay.Text));
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(txtStdNm.Text));
                cmd.ExecuteNonQuery();
                // define the values 
                sc.Parameters.AddWithValue("@number", txtStdNm.Text.Trim());
                sc.Parameters.AddWithValue("amount", txtPay.Text.Trim());
                //add values to payment table

                sc.ExecuteNonQuery();
                MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //to clear all the fields
                clear();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }

        }
        //reset button to clear all the fields
        private void resButt_Click(object sender, EventArgs e)
        {
            clear();
        }
        // cansel button to cancel the operation and close this page
        private void cancButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();

        }

        private void StudentPayment_Load(object sender, EventArgs e)
        {
            // to start from the first textbox
            txtStdNm.Focus();
        }

        // search button will search for a student name and surname according to the student number
        private void butSrch_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    // show the student first name
                    SqlCommand cmd = new SqlCommand("SELECT  Name  FROM Students WHERE StudentNumber = " + txtStdNm.Text.ToString() + " ", connection);
                    labStNam.Text = cmd.ExecuteScalar().ToString();
                    //show the student last name
                    SqlCommand cd = new SqlCommand("SELECT  Surname  FROM Students WHERE StudentNumber = " + txtStdNm.Text.ToString() + " ", connection);
                    labSurname.Text = cd.ExecuteScalar().ToString();
                    //show the student wallet
                    SqlCommand cr = new SqlCommand("SELECT  Wallet  FROM Students WHERE StudentNumber = " + txtStdNm.Text.ToString() + " ", connection);
                    labWallet.Text = cr.ExecuteScalar().ToString();

                }
                catch
                {
                    MessageBox.Show("ERROR");

                }
                finally
                {

                    connection.Close();
                }
            }
        }
    }
}
