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
    public partial class AssignInstructor : Form
    {
        //connect to the database
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public AssignInstructor()
        {
            InitializeComponent();
        }

        public AdminInterface AdminInterface
        {
            get => default;
            set
            {
            }
        }

        private void AssignInstructor_Load(object sender, EventArgs e)
        {
            try
            {

                // fill the first combo box for instructotrs 
                connection.Open();
                SqlCommand sc = new SqlCommand("SELECT FirstName, InstructorNumber FROM Instructors", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sc);
                adapter.SelectCommand = sc;
                DataTable University = new DataTable();
                adapter.Fill(University);
                combInstN1.DataSource = University;
                combInstN1.DisplayMember = "FirstName";
                combInstN1.ValueMember = "InstructorNumber";
                labIns1Nm.Text = combInstN1.SelectedValue.ToString();

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connection.Close();
            }
            try
            {
                connection.Open();
                SqlCommand sR = new SqlCommand("SELECT CourseID , Name FROM Courses ", connection);
                SqlDataAdapter adapter2 = new SqlDataAdapter(sR);
                adapter2.SelectCommand = sR;
                DataTable University2 = new DataTable();
                adapter2.Fill(University2);
                combCrs.DataSource = University2;
                combCrs.DisplayMember = "Name";
                combCrs.ValueMember = "CourseID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load fucntion");
            }
            finally
            {
                connection.Close();
            }

        }


        // fill the label with the instructor number he chose
        private void combInstN1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void butAs_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                SqlCommand sd = new SqlCommand("INSERT INTO Assign VALUES (@crs,@ins1) ", connection);


                sd.Parameters.AddWithValue("@crs", combCrs.SelectedValue);
                sd.Parameters.AddWithValue("@ins1", combInstN1.SelectedValue);
                sd.ExecuteNonQuery();
                MessageBox.Show("Assigned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

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
        public void clear()
        {
            combCrs.SelectedIndex = -1;
            combInstN1.SelectedIndex = -1;
            lab1Ins1Nm.Text = "";
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
    }


}

