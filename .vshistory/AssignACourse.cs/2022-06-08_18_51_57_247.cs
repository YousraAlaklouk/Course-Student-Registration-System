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
    public partial class AssignACourse : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public AssignACourse()
        {
            InitializeComponent();
        }
        DataTable Courses;

        public void clear()
        {
            txtStdNm.Clear();
            combCrs.SelectedIndex = -1;
            gridCrs.Columns.Clear();
            labStNam.Text = "";
        }
        private void assignBut_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Assigned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("You Have a Preliminary Payments which is ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            clear();

        }

        private void resBut_Click(object sender, EventArgs e)
        {
            clear();


        }

        private void cancBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }

        private void AssignACourse_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Courses WHERE State = 'open'", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Courses = new DataTable();
                sda.Fill(Courses);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Courses;
                gridCrs.DataSource = bSource;
                sda.Update(Courses);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                connection.Open();
                SqlCommand sR = new SqlCommand("SELECT CourseID , Name FROM Courses WHERE State = 'open'", connection);
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

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            txtStdNm.Focus();
        }

        private void searchBut_Click(object sender, EventArgs e)
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
