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
        //connect to the database
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");

        public CourseCreation()
        {
            InitializeComponent();
        }


        private void CourseCreation_Load(object sender, EventArgs e)
        {

            combState.Text = "close";
            txtCrsNm.Focus();


        }

        // create button 
        private void crtButt_Click(object sender, EventArgs e)
        {


            connection.Open();
            string C = "Close";
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    // insert into course table

                    SqlCommand cmd = new SqlCommand("INSERT INTO Courses(Name,Title, Credit , State, Descreption ,Type  )" +
                        "  VALUES (@name , @title, @credit,@state,@desc,@type  )", connection);


                    cmd.Parameters.AddWithValue("@name", txtCrsNm.Text.Trim());
                    cmd.Parameters.AddWithValue("@title", txtCrsTi.Text.Trim());
                    cmd.Parameters.AddWithValue("@credit", numCrsCrdt.Value.ToString());
                    cmd.Parameters.AddWithValue("@state", C);
                    if (txtDescr.Text.Trim().Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@desc", txtDescr.Text.Trim());

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@desc", DBNull.Value);

                    }
                    cmd.Parameters.AddWithValue("@type", combTyp.SelectedItem);


                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {

                        MessageBox.Show("Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("something went wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {

                    connection.Close();


                }

            }

        }
        // cancel button 
        private void cancButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }
        // reset button 
        private void resButt_Click(object sender, EventArgs e)
        {
            clear();

        }
        // clear method
        private void clear()
        {
            txtCrsNm.Clear();
            txtCrsTi.Clear();
            txtDescr.Clear();
            numCrsCrdt.Value = 0;

            combState.SelectedIndex = -1;
            combTyp.SelectedIndex = -1;

        }
        // menu strip to go to course creation form
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new CourseCreation();
            form.ShowDialog();
        }
        // menue strip close
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // menue strip exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
