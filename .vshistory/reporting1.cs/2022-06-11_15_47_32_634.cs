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
        // connect to the database
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public reporting1()
        {
            InitializeComponent();
        }
        DataTable Students;
        //reload button
        private void butRlod_Click(object sender, EventArgs e)
        {
            txtStuSrch.Clear();
            combSrch.SelectedIndex = -1;
            gridStuSrch.Columns.Clear();

            try
            {// reload the datagridview
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Students", connection);
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
                txtStuSrch.Focus();

            }
        }

        private void reporting1_Load(object sender, EventArgs e)
        {

            try
            {
                // to fill the data grid view from the student table
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Students ", connection);

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
            if (txtStuSrch.TextLength > 0)
            {


                try
                {
                    //every if in this try is about an index in the combobox
                    connection.Open();
                    //if he want to search about the student number 
                    if (combSrch.SelectedIndex == 0)
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE StudentNumber =" + txtStuSrch.Text + "", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;


                    }
                    else if (combSrch.SelectedIndex == 1)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE Name LIKE '%" + txtStuSrch.Text + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



                    }
                    else if (combSrch.SelectedIndex == 2)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE MiddleName LIKE '%" + txtStuSrch.Text + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;


                    }
                    else if (combSrch.SelectedIndex == 3)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE Surname LIKE '%" + txtStuSrch.Text + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



                    }
                    else if (combSrch.SelectedIndex == 4)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE BirthDate LIKE '%" + txtStuSrch.Text.ToString() + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



                    }
                    else if (combSrch.SelectedIndex == 5)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE Faculty LIKE '%" + txtStuSrch.Text + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



                    }
                    else if (combSrch.SelectedIndex == 6)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE Sex LIKE '%" + txtStuSrch.Text + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



                    }
                    else if (combSrch.SelectedIndex == 7)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE Age LIKE '%" + txtStuSrch.Text.ToString() + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;
                    }
                    else if (combSrch.SelectedIndex == 8)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE PhoneNumber LIKE'%" + txtStuSrch.Text.ToString() + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



                    }
                    else if (combSrch.SelectedIndex == 9)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE Email LIKE '%" + txtStuSrch.Text + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



                    }
                    else if (combSrch.SelectedIndex == 10)
                    {

                        SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Students WHERE Address LIKE '%" + txtStuSrch.Text + "%'", connection);
                        Students = new DataTable();
                        //to fill the data grid view according to the text written
                        cmd.Fill(Students);

                        gridStuSrch.DataSource = Students;



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

