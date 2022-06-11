﻿using System;
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
        // connect to the database
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public Reporting2()
        {
            InitializeComponent();
        }
        DataTable Instructors;
        // reload button 
        private void butRlod_Click(object sender, EventArgs e)
        {
            // reload the datagridview

            try
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Instructors ", connection);

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
                txtInsSrch.Clear();
                combsrch.SelectedIndex = -1;

            }
        }

        private void Reporting2_Load(object sender, EventArgs e)
        {

            try
            {
                // fill the data grid view
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Instructors ", connection);

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
            // check if the text box have a single latter
            if(txtInsSrch.TextLength > 0 )
            {

            
            connection.Open();
            DataTable dtResult = new DataTable();
                if (connection.State == ConnectionState.Open)
                {
                    // every if in this try is according to the combobox index
                    try
                    {


                        //if he want to search about the Instructor Number 
                        if (combsrch.SelectedIndex == 0)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE InstructorNumber =" + Convert.ToInt16(txtInsSrch.Text) + "", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 1)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE JobTitle LIKE '%" + Convert.ToString(txtInsSrch.Text) + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 2)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE VancacyNumber =" + Convert.ToInt16(txtInsSrch.Text) + "", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 3)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE FirstName LIKE '%" + txtInsSrch.Text + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 4)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE LastName LIKE '%" + txtInsSrch.Text + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 5)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE MiddleName LIKE '%" + txtInsSrch.Text + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 6)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE IDNumber LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 7)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE GraduationDate LIKE %" + txtInsSrch.ToString() + "%", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 8)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE BirthDate LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 9)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Disability LIKE %" + txtInsSrch.Text.ToString() + "%", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 10)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Email LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 11)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Address LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 12)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE PhoneNumber LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 13)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Postcode LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 14)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE Degree LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 15)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE BachelorUniversity LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 16)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE BachelorMajor LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 17)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE MasterUniversity LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 18)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE MasterSpecialized LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 19)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE PhDUniversity LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 20)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE PhDSpecialized LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
                            Instructors = new DataTable();
                            //to fill the data grid view according to the text written
                            cmd.Fill(Instructors);

                            dataSrchIns.DataSource = Instructors;


                        }
                        else if (combsrch.SelectedIndex == 21)
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Instructors WHERE SubjectsToTeach LIKE '%" + txtInsSrch.Text.ToString() + "%'", connection);
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
}
