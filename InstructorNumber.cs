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
    public partial class InstructorNumber : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public string fname;
        public string lname;
        public InstructorNumber()
        {
            InitializeComponent();
        }



        private void okButt_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void InstructorNumber_Load(object sender, EventArgs e)
        {
            okButt.Focus();
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {

                    String query = "SELECT InstructorNumber FROM Instructors WHERE FirstName = @first AND LastName=@last";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@first", fname);
                    cmd.Parameters.AddWithValue("@last", lname);
                    string ID1 = cmd.ExecuteScalar().ToString();
                    labInstNum.Text = ID1;
                    //int i = cmd.ExecuteNonQuery();
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
