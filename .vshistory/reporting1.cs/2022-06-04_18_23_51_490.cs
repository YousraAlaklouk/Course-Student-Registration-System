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
    public partial class reporting1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public reporting1()
        {
            InitializeComponent();
        }
        DataTable Students;

        private void butRlod_Click(object sender, EventArgs e)
        {
            txtStuSrch.Clear();
            combSrch.SelectedIndex = -1;
            gridStuSrch.Columns.Clear();
        }

        private void reporting1_Load(object sender, EventArgs e)
        {
            // to fill the data grid view from the student table
            connection.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM Thesis ORDER BY ThesisNo", connection);
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Students = new DataTable();
                sda.Fill(Students);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Students;
                gridStuSrch.DataSource = bSource;
                sda.Update(Students);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
            combSrch.Focus();
  

        }

        private void txtStuSrch_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {   //if he want to search about the student number 
                    if (combSrch.SelectedIndex == 0)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE StudentNumber ="+ txtStuSrch.Text+"", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;


                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
