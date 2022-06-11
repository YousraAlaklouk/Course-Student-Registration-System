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
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }



        private void stRegBut_Click(object sender, EventArgs e)
        {
            
           
                Form UserInterface = new StudentRegistration();
                UserInterface.ShowDialog();
            
        }

        private void instRegBut_Click(object sender, EventArgs e)
        {

            Form UserInterface = new Instructor_Registration();
            UserInterface.ShowDialog();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {

            Form UserInterface = new AdminLogIn();
            UserInterface.ShowDialog();
        }

        private void asnCrsBut_Click(object sender, EventArgs e)
        {

            Form AdminInterface = new AssignACourse();
            AdminInterface.ShowDialog();
            

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            stRegBut.Focus();
        }

        private void butStPay_Click(object sender, EventArgs e)
        {
            Form frm = new StudentPayment();
            frm.ShowDialog();
        }
    }
}
