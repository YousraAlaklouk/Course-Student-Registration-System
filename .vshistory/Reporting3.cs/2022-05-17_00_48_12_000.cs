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
    public partial class Reporting3 : Form
    {
/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/        public Reporting3()
        {
            InitializeComponent();
        }

        private void butRlod_Click(object sender, EventArgs e)
        {
            txtSrchCrs.Clear();
            combSrch.SelectedIndex = -1;
            gridCrsSrch.Columns.Clear();
        }

        private void Reporting3_Load(object sender, EventArgs e)
        {
            combSrch.Focus();
        }
    }
}
