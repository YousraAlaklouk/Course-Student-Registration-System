using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Student_Registration_System
{
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
        }
        private void crtCrsBut_Click(object sender, EventArgs e)
        {
            // open course creation form
            Form AdminInterface = new CourseCreation();
            AdminInterface.ShowDialog();
        }
        private void ButSrchStu_Click(object sender, EventArgs e)
        {
            // open report1 form 
            Form AdminInterface = new reporting1();
            AdminInterface.ShowDialog();
        }
        private void butSrchIns_Click(object sender, EventArgs e)
        {
            //open reporting2 form 
            Form AdminInterface = new Reporting2();
            AdminInterface.ShowDialog();
        }
        private void butSrchCrs_Click(object sender, EventArgs e)
        {
            // open reporting3 form
            Form AdminInterface = new Reporting3();
            AdminInterface.ShowDialog();
        }
        private void butSrchSum_Click(object sender, EventArgs e)
        {
            //open reporting 4 form
            Form AdminInterface = new Reporting4();
            AdminInterface.ShowDialog();
        }
        private void opnCrsBut_Click(object sender, EventArgs e)
        {// open open a course form
            Form AdminInterface = new OpenACourse();
            AdminInterface.ShowDialog();
        }
        private void butPay_Click(object sender, EventArgs e)
        {// open payment report form
            Form AdminInterface = new PaymentReport();
            AdminInterface.ShowDialog();
        }







        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
       
        private void AdminInterface_Load_1(object sender, EventArgs e)
        {
            // start from the first button 
            crtCrsBut.Focus();

        }
    }
}