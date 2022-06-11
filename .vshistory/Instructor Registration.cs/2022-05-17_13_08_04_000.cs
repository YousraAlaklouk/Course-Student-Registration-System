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
/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/        public Instructor_Registration()
        {
            InitializeComponent();
        }

        public InstructorNumber InstructorNumber
        {
            get => default;
            set
            {
            }
        }

        private void Instructor_Registration_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            comboDegree.SelectedIndex = 0;
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
            if (radioDisNo.Checked)
            {
                labDis.Visible = false;
                txtDis.Visible = false;
            }
        }

        private void radioDisYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDisYes.Checked)
            {
                labDis.Visible = true;
                txtDis.Visible = true;
            }
        }

        private void subButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submitted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form Instructor_Registration = new InstructorNumber();
            Instructor_Registration.ShowDialog();
            this.Close();
        }

        private void cancButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }

        private void resButt_Click(object sender, EventArgs e)
        {
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
            Form Form1 = new Instructor_Registration();
            Form1.ShowDialog();
        }
    }
}
