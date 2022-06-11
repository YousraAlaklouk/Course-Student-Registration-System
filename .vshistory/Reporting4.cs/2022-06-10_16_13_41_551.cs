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
    public partial class Reporting4 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public Reporting4()
        {
            InitializeComponent();
        }

        DataTable Students;
        DataTable Instructors;
        DataTable Courses;


        private void radioStu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStu.Checked)
            {
                connection.Open();


                SqlCommand cm = new SqlCommand("SELECT * FROM Students", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Students = new DataTable();
                sda.Fill(Students);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Students;
                gridRep.DataSource = bSource;
                sda.Update(Students);

                connection.Close();
                txtStu.Visible = true;
            }
            else
            {
                txtStu.Visible = false;
            }
        }

        private void radioInst_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInst.Checked)
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Instructors ", connection);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Instructors = new DataTable();
                sda.Fill(Instructors);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Instructors;
                gridRep.DataSource = bSource;
                sda.Update(Instructors);
                connection.Close();
                txtInst.Visible = true;

            }
            else
            {
                txtInst.Visible = false;
            }
        }

        private void radioCrs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCrs.Checked)
            {
                txtCrs.Visible = true;
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Courses ", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Courses = new DataTable();
                sda.Fill(Courses);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Courses;
                gridRep.DataSource = bSource;
                sda.Update(Courses);
                connection.Close();

            }
            else
            {
                txtCrs.Visible = false;
            }
        }

        private void radioCrsDat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCrsDat.Checked)
            {
                txtCrsDat.Visible = true;
                connection.Open();
                SqlCommand cm = new SqlCommand("SELECT * FROM Courses ", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cm;
                Courses = new DataTable();
                sda.Fill(Courses);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Courses;
                gridRep.DataSource = bSource;
                sda.Update(Courses);
                connection.Close();

            }
            else
            {
                txtCrsDat.Visible = false;
            }
        }

        private void Reporting4_Load(object sender, EventArgs e)
        {

            radioStu.Focus();
            txtCrs.Visible = false;
            txtCrsDat.Visible = false;
            txtInst.Visible = false;
            txtStu.Visible = false;


        }

        private void reloadbut_Click(object sender, EventArgs e)
        {
            ////////
            txtCrs.Clear();
            txtCrsDat.Clear();
            txtInst.Clear();
            txtStu.Clear();
            radioCrsDat.Checked = false;
            radioInst.Checked = false;
            radioStu.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioStu.Checked)
            {


                try
                {
                    //THE COMMAND IS WRONG

                    connection.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("SELECT SELECT COUNT(*) FROM Students WHERE DATE BETWEEN '" + txtStu.Text + "' AND GETDATE()", connection);

                    Students = new DataTable();
                    cmd.Fill(Students);

                    gridRep.DataSource = Students; ;


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
            if (radioInst.Checked)

            {
                try
                {

                    connection.Open();
                    //THE COMMAND IS WRONG
                    SqlDataAdapter cmd = new SqlDataAdapter("SELECT SELECT COUNT(*) FROM Instructors WHERE DATE BETWEEN '"+txtInst.Text+"' AND GETDATE()", connection);


                    Instructors = new DataTable();
                    cmd.Fill(Instructors);
                    gridRep.DataSource = Instructors;


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
            if (radioCrs.Checked)

            {
                try
                {
                    //THE COMMAND IS WRONG

                    connection.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("SELECT SELECT COUNT(*) FROM Courses WHERE DATE BETWEEN '" + txtCrs.Text + "' AND GETDATE()", connection);
                        

                    Courses = new DataTable();
                    cmd.Fill(Courses);

                    gridRep.DataSource = Courses;

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
            if (radioCrsDat.Checked)

            {
                try
                {

                    connection.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter("SELECT  COUNT(*) FROM Courses WHERE DATE = '" +txtCrsDat.Text + "'", connection);

                    Courses = new DataTable();
                    cmd.Fill(Courses);

                    gridRep.DataSource = Courses;


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
