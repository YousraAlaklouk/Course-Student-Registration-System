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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public StudentPayment()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtPay.Clear();
            txtStdNm.Clear();
            labStNam.Text = "";
        }

        private void payButt_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Students SET Wallet =Wallet + @w WHERE StudentID =@ID", connection);
                cmd.Parameters.AddWithValue("@w", txtPay.Text);
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(txtStdNm.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void resButt_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cancButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();

        }

        private void StudentPayment_Load(object sender, EventArgs e)
        {
            txtStdNm.Focus();
        }

        private void txtStNm_TextChanged(object sender, EventArgs e)
        {

            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT  Name  FROM Students WHERE StudentNumber = " + txtStdNm.Text.ToString() + " ", connection);
                    labStNam.Text = cmd.ExecuteScalar().ToString();
                    SqlCommand cd = new SqlCommand("SELECT  Surname  FROM Students WHERE StudentNumber = " + txtStdNm.Text.ToString() + " ", connection);
                    labSurname.Text = cd.ExecuteScalar().ToString();
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
