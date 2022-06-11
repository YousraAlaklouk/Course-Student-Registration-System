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
    public partial class Reporting3 : Form
    {
        // connect to the database
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public Reporting3()
        {
            InitializeComponent();
        }
        DataTable Courses;
        // reload button 
        private void butRlod_Click(object sender, EventArgs e)
        {
            txtSrchCrs.Clear();
            combSrch.SelectedIndex = -1;
            gridCrsSrch.Columns.Clear();

            try
            {
                //reload the data grid view
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Courses ", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Courses = new DataTable();
                sda.Fill(Courses);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Courses;
                gridCrsSrch.DataSource = bSource;
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
        }

        private void Reporting3_Load(object sender, EventArgs e)
        {

            try
            {
                //fill the data grid view
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Courses ", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Courses = new DataTable();
                sda.Fill(Courses);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Courses;
                gridCrsSrch.DataSource = bSource;
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
            combSrch.Focus();
        }

        private void txtSrchCrs_TextChanged(object sender, EventArgs e)
        {
            // check if the text box have a single latter ot not
            if (txtSrchCrs.Text.Length > 0)
            {

            
            connection.Open();
            DataTable dtResult = new DataTable();
                if (connection.State == ConnectionState.Open)
                {
                    // every if in this try is according an index in the combo box
                    try
                    {
                        if (combSrch.SelectedIndex == 0)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE CourseID =" + txtSrchCrs.Text + "", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 1)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Name LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 2)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Title LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 3)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Credit LIKE '%" + Convert.ToInt16(txtSrchCrs.Text) + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 4)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE State LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 5)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Descreption LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 6)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Type LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                            // we must use inner join 
                            //important
                        }
                        else if (combSrch.SelectedIndex == 7)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Intructor1Number LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 8)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE DurationFrom LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 9)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE DurationTo LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 10)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE PricePerMonth LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 11)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE CourseRoom LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }

                        else if (combSrch.SelectedIndex == 12)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Days LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


                        }
                        else if (combSrch.SelectedIndex == 13)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Courses WHERE Time LIKE '%" + txtSrchCrs.Text + "%'", connection);
                            Courses = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Courses);

                            gridCrsSrch.DataSource = Courses;


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
}
