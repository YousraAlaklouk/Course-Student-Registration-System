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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public StudentRegistration()
        {
            InitializeComponent();
        }



        private void subBut_Click(object sender, EventArgs e)
        {
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Students VALUES(@name, @surname,@middle ,@sex,@birtdate ,@age ,@phone,@email,@address,@faculty,@dep)", connection);

                }
                catch
                {

                }
                MessageBox.Show("Submitted , If You want to Add Money to your account Go to Student Payment", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form Form1 = new StudentNumber();
                Form1.ShowDialog();
                this.Close();
            }

        }

        private void caclBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }

        private void resBut_Click(object sender, EventArgs e)
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

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToAssignACourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new AssignACourse();
            Form1.ShowDialog();
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new StudentRegistration();
            Form1.ShowDialog();
        }

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

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            connection.Open();
            SqlCommand sc = new SqlCommand("SELECT FaculityName  FROM Faculities", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sc);
            adapter.SelectCommand = sc;
            DataTable Faculity = new DataTable();
            adapter.Fill(Faculity);
            comboFacu.DataSource = Faculity;
            comboFacu.DisplayMember = "FaculityName";
            comboFacu.ValueMember = "FaculityID";
            comboDep.SelectedIndex = -1;

            connection.Close();


        }

        private void comboDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}