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
                {   //if he want to search about the Instructor Number 
                    if (combsrch.SelectedIndex == 0)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE InstructorNumber =" + txtInsSrch.Text + "", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 1)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE JobTitle LIKE %" + txtInsSrch.Text.ToString() + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 2)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE VancacyNumber LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 3)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE FirstName LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 4)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE LastName LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 5)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE MiddleName LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 6)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE IDNumber LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 7)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE GraduationDate LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 8)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE BirthDate LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 9)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Disability LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 10)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Email LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 11)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Address LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 12)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE PhoneNumber LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 13)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Postcode LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 14)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Degree LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 15)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE BachelorUniversity LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 16)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE BachelorMajor LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 17)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE MasterUniversity LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 18)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE MasterSpecialized LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 19)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE PhDUniversity LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 20)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE PhDSpecialized LIKE %" + txtInsSrch.Text + "%", connection);
                        Instructors = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Instructors);

                        dataSrchIns.DataSource = Instructors;


                    }
                    else if (combsrch.SelectedIndex == 21)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE SubjectsToTeach LIKE %" + txtInsSrch.Text + "%", connection);
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
