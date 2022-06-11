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
    public partial class reporting1 : Form
    {

/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/
        public reporting1()
        {
            InitializeComponent();
        }

        private void butRlod_Click(object sender, EventArgs e)
        {
            txtStuSrch.Clear();
            combSrch.SelectedIndex = -1;
            gridStuSrch.Columns.Clear();
        }

        private void reporting1_Load(object sender, EventArgs e)
        {
            combSrch.Focus();
        }
    }
}
