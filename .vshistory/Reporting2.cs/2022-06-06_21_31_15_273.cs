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
    public partial class Reporting2 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public Reporting2()
        {
            InitializeComponent();
        }
        DataTable Instructors;

        private void butRlod_Click(object sender, EventArgs e)
        {
            txtInsSrch.Clear();
            combsrch.SelectedIndex = -1;
            dataSrchIns.Columns.Clear();
        }

        private void Reporting2_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM Instructors ", connection);
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Instructors = new DataTable();
                sda.Fill(Instructors);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Instructors;
                dataSrchIns.DataSource = bSource;
                sda.Update(Instructors);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
            combsrch.Focus();

        }

        private void txtInsSrch_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {   //if he want to search about the student number 
                    if (combsrch.SelectedIndex == 0)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE InstructorNumber =" + txtInsSrch.Text + "", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


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
        }
    }
}
