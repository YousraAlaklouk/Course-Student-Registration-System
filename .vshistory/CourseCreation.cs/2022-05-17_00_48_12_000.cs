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
/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/        public CourseCreation()
        {
            InitializeComponent();
        }


        private void CourseCreation_Load(object sender, EventArgs e)
        {
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
            MessageBox.Show("Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
