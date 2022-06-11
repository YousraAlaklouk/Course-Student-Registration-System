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
    public partial class Instructor_Registration : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public Instructor_Registration()
        {
            InitializeComponent();
        }
        //these 2 because i will use them in the instructor number form to show the one who did registered the instructor number
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        private void Instructor_Registration_Load(object sender, EventArgs e)
        {
            //TO MAKE THE START FROM THE TITLE
            txtTitle.Focus();
            //THE DEGREE WILL START FROM THE FIRST FIELD
            comboDegree.SelectedIndex = 0;
            //CONTROL THE ABILITY AND VISIBILITY FROM THE FIRST ( OPENING THE FORM)
            labBach.Enabled = true;
            txtBacUni.Enabled = true;
            txtBacMaj.Enabled = true;
            labBachMaj.Enabled = true;
            labMas.Enabled = false;
            txtMasUni.Enabled = false;
            txtMasSpe.Enabled = false;
            labPhD.Enabled = false;
            txtPhDUni.Enabled = false;
            txtPhDSpe.Enabled = false;
            labMasSpe.Enabled = false;
            labPhDSpe.Enabled = false;
            labDis.Visible = false;
            txtDis.Visible = false;


        }
        private void comboDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IF HIS DEGREE IS BACHLOR SO HE CAN ADD A BACHLOR UNIVERSITY AND MAJOR , SO THIS IF WILL CONTROL THE ABILITY
            // OF THE LABELS AND TEXT BOXES FOR THE DEGREES 
            if (comboDegree.SelectedIndex == 0)
            {
                labBach.Enabled = true;
                txtBacUni.Enabled = true;
                txtBacMaj.Enabled = true;
                labBachMaj.Enabled = true;
                labMas.Enabled = false;
                txtMasUni.Enabled = false;
                txtMasSpe.Enabled = false;
                labPhD.Enabled = false;
                txtPhDUni.Enabled = false;
                txtPhDSpe.Enabled = false;
                labMasSpe.Enabled = false;
                labPhDSpe.Enabled = false;

            }
            else
            if (comboDegree.SelectedIndex == 1)
            {
                labBach.Enabled = true;
                txtBacUni.Enabled = true;
                txtBacMaj.Enabled = true;
                labMas.Enabled = true;
                txtMasUni.Enabled = true;
                txtMasSpe.Enabled = true;
                labBachMaj.Enabled = true;
                labMasSpe.Enabled = true;
                labPhD.Enabled = false;
                txtPhDUni.Enabled = false;
                txtPhDSpe.Enabled = false;
                labPhDSpe.Enabled = false;
            }
            else
            if (comboDegree.SelectedIndex == 2)
            {
                labBach.Enabled = true;
                txtBacUni.Enabled = true;
                txtBacMaj.Enabled = true;
                labMas.Enabled = true;
                txtMasUni.Enabled = true;
                txtMasSpe.Enabled = true;
                labPhD.Enabled = true;
                txtPhDUni.Enabled = true;
                txtPhDSpe.Enabled = true;
                labBachMaj.Enabled = true;
                labMasSpe.Enabled = true;
                labPhDSpe.Enabled = true;


            }
            // I ADDED THIS ONE BECAUSE IF HE KEPT CHANGING THE DEGREE 
            else
            {
                labBach.Enabled = false;
                txtBacUni.Enabled = false;
                txtBacMaj.Enabled = false;
                labMas.Enabled = false;
                txtMasUni.Enabled = false;
                txtMasSpe.Enabled = false;
                labPhD.Enabled = false;
                txtPhDUni.Enabled = false;
                txtPhDSpe.Enabled = false;
                labBachMaj.Enabled = false;
                labMasSpe.Enabled = false;
                labPhDSpe.Enabled = false;
            }

        }



        private void radioDisNo_CheckedChanged(object sender, EventArgs e)
        {
            //IF HE DOES NOT HAVE ANY DISABILITY THE LABEL AND THE TEXT BOX WILL NOT BE VISIBLE TO HIM
            if (radioDisNo.Checked)
            {
                labDis.Visible = false;
                txtDis.Visible = false;
            }
        }

        private void radioDisYes_CheckedChanged(object sender, EventArgs e)
        {
            //IF HE HAS ANY DISABILITY THE LABEL AND THE TEXT BOX WILL BE SHOWN 
            if (radioDisYes.Checked)
            {
                labDis.Visible = true;
                txtDis.Visible = true;
            }
        }

        private void subButt_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Instructors VALUES( @job ,@van ,@first,@last ,@mid , @id, @grad,@birth," +
                    "@dis ,@email,@address,@phone,@postcode,@degree,@bauni,@bacmajor,@masuni,@masspe,@phduni,@phdspe,@subjects)", connection);
                cmd.Parameters.AddWithValue("@job", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@van", txtVnNm.Text.ToString());
                cmd.Parameters.AddWithValue("first", txtFn.Text.Trim());
                cmd.Parameters.AddWithValue("@last", txtLn.Text.Trim());

                // IF HE DOES NOT ENTER A MIDDLE NAME IT WILL BE STORED AS NULL, because it is optional
                if (txtMn.Text.Trim().Length>0)
                {
                    cmd.Parameters.AddWithValue("@mid", txtMn.Text.Trim());

                }
                else
                {
                    cmd.Parameters.AddWithValue("@mid", DBNull.Value);

                }
                cmd.Parameters.AddWithValue("id", txtIDNm.Text.Trim());
                cmd.Parameters.AddWithValue("@grad", txtGrDate.Text.Trim());
                cmd.Parameters.AddWithValue("@birth",txtBD.Text.Trim());
                //if the instructor does not have any disapility it will be stored as null
                if (radioDisNo.Checked)
                {
                    cmd.Parameters.AddWithValue("@dis", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@dis", txtDis.Text.Trim());
                }
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAd.Text.Trim());

                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@postcode",txtPc.Text.Trim());
                cmd.Parameters.AddWithValue("@bauni", txtBacUni.Text.Trim());
                cmd.Parameters.AddWithValue("@bacmajor", txtBacMaj.Text.Trim());
                cmd.Parameters.AddWithValue("@degree", comboDegree.SelectedItem);

                //if the degree is Bachalor then he can not enter master university , specilize , phd uni or specialized
                if (comboDegree.SelectedIndex == 0)
                {
/*                    txtMasUni.Text = "NULL";
*/                    cmd.Parameters.AddWithValue("@masuni", DBNull.Value);
/*                    txtMasSpe.Text = "NULL";
*/                    cmd.Parameters.AddWithValue("@masspe", DBNull.Value);
/*                    txtPhDUni.Text = "NULL";
*/                    cmd.Parameters.AddWithValue("@phduni", DBNull.Value);
/*                    txtPhDSpe.Text = "NULL";
*/                    cmd.Parameters.AddWithValue("@phdspe", DBNull.Value);
                }
                //if the degree is master ha can not enter phd university or specilized
                else
                    if (comboDegree.SelectedIndex == 1)
                {
/*                    txtPhDUni.Text = "NULL";
                    txtPhDSpe.Text = "NULL";*/
                    cmd.Parameters.AddWithValue("@masuni", txtMasUni.Text.Trim());
                    cmd.Parameters.AddWithValue("@masspe", txtMasSpe.Text.Trim());
                    cmd.Parameters.AddWithValue("@phduni", DBNull.Value);
                    cmd.Parameters.AddWithValue("@phdspe", DBNull.Value);
                }
                else
                //if the degree is phd he can enter all 
                {
                    cmd.Parameters.AddWithValue("@masuni", txtMasUni.Text.Trim());
                    cmd.Parameters.AddWithValue("@masspe", txtMasSpe.Text.Trim());
                    cmd.Parameters.AddWithValue("@phduni", txtPhDUni.Text.Trim());
                    cmd.Parameters.AddWithValue("@phdspe", txtPhDSpe.Text.Trim());
                }

                // if he did not enter any thing in the subject text box it will be stored as null to the database
                if (txtSubjects.Text.Trim().Length > 0)
                {
                    cmd.Parameters.AddWithValue("@subjects", txtSubjects.Text.Trim());

                }
                else
                {
/*                    txtSubjects.Text = "NULL";
*/                    cmd.Parameters.AddWithValue("@subjects", DBNull.Value);

                }
                SetValueForText1 = txtFn.Text;
                SetValueForText2 = txtLn.Text;

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {

                    MessageBox.Show("Submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    InstructorNumber Instructor_Registration = new InstructorNumber();
                    Instructor_Registration.fname = txtFn.Text;
                    Instructor_Registration.lname = txtLn.Text;

                    Instructor_Registration.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data Unsaved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            connection.Close();
        }

        private void cancButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }

        private void resButt_Click(object sender, EventArgs e)
        {
            //TO RESET ALL THE FIELD
            txtAd.Clear();
            txtBacMaj.Clear();
            txtBacUni.Clear();
            txtBD.Clear();
            txtDis.Clear();
            txtEmail.Clear();
            txtFn.Clear();
            txtGrDate.Clear();
            txtIDNm.Clear();
            txtLn.Clear();
            txtMasSpe.Clear();
            txtMasUni.Clear();
            txtMn.Clear();
            txtPc.Clear();
            txtPhDSpe.Clear();
            txtPhDUni.Clear();
            txtPhone.Clear();
            txtSubjects.Clear();
            txtTitle.Clear();
            txtVnNm.Clear();
            comboDegree.SelectedIndex = 0;
            radioDisNo.Checked = true;
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            // WHATEVER HE WILL CHOOSE FROM COMBOBOX HE WILL GO TO THE RIGHT PLACE
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                Form Form1 = new AdminLogIn();
                Form1.ShowDialog(this);
                toolStripComboBox1.SelectedIndex = -1;
            }
            else if (toolStripComboBox1.SelectedIndex == 1)
            {
                Form Form1 = new OpenACourse();
                Form1.ShowDialog(this);
                toolStripComboBox1.SelectedIndex = -1;

            }
            else if (toolStripComboBox1.SelectedIndex == 2)
            {
                Form Form1 = new CourseCreation();
                Form1.ShowDialog(this);
                toolStripComboBox1.SelectedIndex = -1;

            }


        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TO OPEN NEW FORM
            Form Form1 = new Instructor_Registration();
            Form1.ShowDialog();
        }
    }
}
