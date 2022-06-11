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

            }
            else
            {
                txtCrsDat.Visible = false;
            }
        }

        private void Reporting4_Load(object sender, EventArgs e)
        {
            try
            {


                connection.Open();
                if (radioStu.Checked)
                {


                    SqlCommand cm = new SqlCommand("SELECT * FROM Students", connection);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cm;
                    Students = new DataTable();
                    sda.Fill(Students);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = Students;
                    gridRep.DataSource = bSource;
                    sda.Update(Students);

                }
                else if (radioInst.Checked)
                {
                    SqlCommand cm = new SqlCommand("SELECT * FROM Instructors ", connection);

                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cm;
                    Instructors = new DataTable();
                    sda.Fill(Instructors);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = Instructors;
                    gridRep.DataSource = bSource;
                    sda.Update(Instructors);
                }
                else 
                {
                    SqlCommand cm = new SqlCommand("SELECT * FROM Courses ", connection);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cm;
                    Courses = new DataTable();
                    sda.Fill(Courses);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = Courses;
                    gridRep.DataSource = bSource;
                    sda.Update(Courses);
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
            radioStu.Focus();
            txtCrs.Visible = false;
            txtCrsDat.Visible = false;
            txtInst.Visible = false;
            txtStu.Visible = false;


        }
    
        private void reloadbut_Click(object sender, EventArgs e)
        {
            txtCrs.Clear();
            txtCrsDat.Clear();
            txtInst.Clear();
            txtStu.Clear();
            gridRep.Columns.Clear();
            radioCrs.Checked = false;
            radioCrsDat.Checked = false;
            radioInst.Checked = false;
            radioStu.Checked = false;
        }

        private void txtStu_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(DATEDIFF(month, GETDATE(), '"+txtStu.Text+"') ) FROM Students", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlCommand;
                Students = new DataTable();
                sda.Fill(Students);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = Students;
                gridRep.DataSource = bSource;
                sda.Update(Students);

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
