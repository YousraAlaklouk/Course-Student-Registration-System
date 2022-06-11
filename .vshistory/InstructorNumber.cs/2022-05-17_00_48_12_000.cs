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
    public partial class InstructorNumber : Form
    {
/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/        public InstructorNumber()
        {
            InitializeComponent();
        }

        private void okButt_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void InstructorNumber_Load(object sender, EventArgs e)
        {
            okButt.Focus();
        }
    }
}
