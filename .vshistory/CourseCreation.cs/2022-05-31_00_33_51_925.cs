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
    public partial class CourseCreation : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public CourseCreation()
        {
            InitializeComponent();
        }


        private void CourseCreation_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sc = new SqlCommand("SELECT FirstName, InstructorNumber FROM Instructors", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            adapter.SelectCommand = sc;
            DataTable University = new DataTable();
            adapter.Fill(University);
            combInstN1.DataSource = University;
            combInstN1.DisplayMember = "FirstName";
            combInstN1.ValueMember = "InstructorNumber";
            /*            combInstN1.SelectedIndex = -1;
            */
            labIns1Nm.Text = combInstN1.SelectedValue.ToString();
            connection.Close();

            connection.Open();
            SqlCommand sR = new SqlCommand("SELECT FirstName, InstructorNumber FROM Instructors", connection);
            SqlDataAdapter adapter2 = new SqlDataAdapter(sR);
            adapter2.SelectCommand = sR;
            DataTable University2 = new DataTable();
            adapter2.Fill(University2);
            combInstN2.DataSource = University2;
            combInstN2.DisplayMember = "FirstName";
            combInstN2.ValueMember = "InstructorNumber";
            /*            combInstN2.SelectedIndex = -1;
             *            
            */
            labInst2Nm.Text = combInstN1.SelectedValue.ToString();

            connection.Close();


            connection.Open();
            SqlCommand sA = new SqlCommand("SELECT FirstName, InstructorNumber FROM Instructors", connection);
            SqlDataAdapter adapter3 = new SqlDataAdapter(sA);
            adapter3.SelectCommand = sA;
            DataTable University3 = new DataTable();
            adapter3.Fill(University3);
            combInstN3.DataSource = University3;
            combInstN3.DisplayMember = "FirstName";
            combInstN3.ValueMember = "InstructorNumber";
            /*            combInstN3.SelectedIndex = -1;
            */
            labIns3Nm.Text = combInstN1.SelectedValue.ToString();

            connection.Close();

            txtCrsNm.Focus();
            labInst2.Visible = false;
            labInst3.Visible = false;
            combInstN2.Visible = false;
            combInstN3.Visible = false;
            checkInst1.Checked = true;
            lab1Ins2Nm.Visible = false;
            labInst2Nm.Visible = false;
            lab1Ins3Nm.Visible = false;
            labIns3Nm.Visible = false;

        }

        private void checkInst2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInst2.Checked == true)
            {
                labInst2.Visible = true;
                combInstN2.Visible = true;
                labInst2Nm.Visible = true;
                lab1Ins2Nm.Visible = true;

            }
            else
            if (checkInst3.Checked = true && checkInst2.Checked == true)
            {
                labInst2.Visible = true;
                combInstN2.Visible = true;
                labInst2Nm.Visible = true;
                lab1Ins2Nm.Visible = true;
                lab1Ins3Nm.Visible = false;
                labIns3Nm.Visible = false;
                labInst3.Visible = false;
                combInstN3.Visible = false;

            }
            else
            {
                labInst2.Visible = false;
                combInstN2.Visible = false;
                lab1Ins2Nm.Visible = false;
                labInst2Nm.Visible = false;
            }
        }
        private void checkInst3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInst3.Checked == true && checkInst2.Checked == true)
            {
                labInst3.Visible = true;
                combInstN3.Visible = true;
                lab1Ins3Nm.Visible = true;
                labIns3Nm.Visible = true;


            }

            else
            {
                labInst3.Visible = false;
                combInstN3.Visible = false;
                lab1Ins3Nm.Visible = false;
                labIns3Nm.Visible = false;
            }

        }
        private void crtButt_Click(object sender, EventArgs e)
        {

            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {


                    SqlCommand cmd = new SqlCommand("INSERT INTO Courses VALUES (@name , @title, @credit,@state,@desc,@type ,@ins1 , @ins2, @ins3 , @from,@to ,@price,@room,@day ,@time)", connection);
                    cmd.Parameters.AddWithValue("@name", txtCrsNm.Text.Trim());
                    cmd.Parameters.AddWithValue("@title", txtCrsTi.Text.Trim());
                    cmd.Parameters.AddWithValue("@credit", numCrsCrdt.Value.ToString());
                    cmd.Parameters.AddWithValue("@title", txtCrsTi.Text.Trim());
                    cmd.Parameters.AddWithValue("@state", combState.SelectedText);
                    if (txtDescr.Text.Trim().Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@desc", txtDescr.Text.Trim());

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@desc", DBNull.Value);

                    }
                    cmd.Parameters.AddWithValue("@type", combState.SelectedText);
                    cmd.Parameters.AddWithValue("@ins1", combInstN1.SelectedValue);
                    if (checkInst2.Checked)
                    {
                        cmd.Parameters.AddWithValue("@ins2", combInstN2.SelectedValue);


                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ins2", DBNull.Value);

                    }
                    if (checkInst3.Checked)
                    {
                        cmd.Parameters.AddWithValue("@ins3", combInstN3.SelectedValue);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ins3", DBNull.Value);

                    }


                    MessageBox.Show("Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("something went wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            }

        private void cancButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }

        private void resButt_Click(object sender, EventArgs e)
        {
            txtCrsNm.Clear();
            txtCrsTi.Clear();
            txtDescr.Clear();
            numCrsCrdt.Value = 0;
            combInstN1.SelectedIndex = -1;
            combInstN2.SelectedIndex = -1;
            combInstN3.SelectedIndex = -1;
            combState.SelectedIndex = -1;
            combTyp.SelectedIndex = -1;
            checkInst2.Checked = false;
            checkInst3.Checked = false;

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new CourseCreation();
            form.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
    }
}
