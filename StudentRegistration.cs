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
    public partial class StudentRegistration : Form
    {
        //connect to the database 
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public StudentRegistration()
        {
            InitializeComponent();
        }

        // fill faculty combo box from database
        private void StudentRegistration_Load_1(object sender, EventArgs e)
        {
            txtName.Focus();

            try
            {
                connection.Open();

                SqlCommand sc = new SqlCommand("SELECT FaculityName , FaculityId  FROM Faculities", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sc);
                adapter.SelectCommand = sc;
                DataTable Faculity = new DataTable();
                adapter.Fill(Faculity);
                comboFacu.DataSource = Faculity;
                comboFacu.DisplayMember = "FaculityName";
                comboFacu.ValueMember = "FaculityID";
                comboFacu.SelectedIndex = -1;
                comboFacu.SelectedValueChanged += ComboFacu_SelectedValueChanged;
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

        // fill department combobox according to the faculty from database
        private void ComboFacu_SelectedValueChanged(object? sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Department , DepartmentID FROM Department WHERE FacultyID = @ID ", connection);
            cmd.Parameters.AddWithValue("@ID", comboFacu.SelectedValue);

            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
            adapter2.SelectCommand = cmd;
            DataTable Department = new DataTable();
            adapter2.Fill(Department);
            comboDep.DataSource = Department;
            comboDep.DisplayMember = "Department";
            comboDep.ValueMember = "DepartmentID";
            comboDep.SelectedIndex = -1;
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
        //submit button
        private void subBut_Click(object sender, EventArgs e)
        {
            string female = "Female";
            string male = "Male";
            int wallet = 0;
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES(@name, @surname,@middle ,@sex,@birtdate ,@age ,@phone,@email,@address,@faculty,@dep, @Wallet , GETDATE())", connection);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@surname", txtSur.Text.Trim());
                    if (txtMi.Text.Length > 0) {
                        cmd.Parameters.AddWithValue("@middle", txtMi.Text.Trim());

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@middle", DBNull.Value);

                    }
                    if ( radioFemal.Checked)
                    {
                        cmd.Parameters.AddWithValue("sex", female);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("sex", male);


                    }
                    cmd.Parameters.AddWithValue("@birtdate", maskedBirth.Text.Trim());
                    cmd.Parameters.AddWithValue("age", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("phone", maskedPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("address", richAdress.Text.Trim());
                    cmd.Parameters.AddWithValue("faculty", comboFacu.SelectedValue);
                    cmd.Parameters.AddWithValue("dep", comboDep.SelectedValue);
                    cmd.Parameters.AddWithValue("Wallet", wallet);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted , If You want to Add Money to your account Go to Student Payment", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StudentNumber StudentRegistration = new StudentNumber();
                    StudentRegistration.fname = txtName.Text.Trim();
                    StudentRegistration.lname = txtSur.Text.Trim();
                    StudentRegistration.ShowDialog();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show( ex.Message);
                }
                finally
                {
                    connection.Close();

                }

            }

        }
        //cancel button
        private void caclBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }
        //reset button
        private void resBut_Click(object sender, EventArgs e)
        {
            clear();
        }
        // clear method
        private void clear()
        {
            txtAge.Clear();
            txtEmail.Clear();
            txtMi.Clear();
            txtName.Clear();
            txtSur.Clear();
            richAdress.Clear();
            maskedBirth.Clear();
            maskedPhone.Clear();
            comboDep.SelectedIndex = -1;
            comboFacu.SelectedIndex = -1;
            radioFemal.Checked = true;
        }

        // from the menue strip tp show the middle name
        private void showMiddleNameBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showMiddleNameBoxToolStripMenuItem.Checked == false)
            {
                labMidd.Visible = false;
                txtMi.Visible = false;
            }
            else if (showMiddleNameBoxToolStripMenuItem.Checked == true)
            {
                labMidd.Visible = true;
                txtMi.Visible = true;
            }
        }

        //close from menu strip
        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // from menu strip 

        private void goToAssignACourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new AssignACourse();
            Form1.ShowDialog();
        }
        //new from menu strip
        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new StudentRegistration();
            Form1.ShowDialog();
        }
        // combo box from menu strip 
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
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
            else if(toolStripComboBox1.SelectedIndex == 2)
            {
                Form Form1 = new CourseCreation();
                Form1.ShowDialog(this);
                toolStripComboBox1.SelectedIndex = -1;

            }


        }


    }
}