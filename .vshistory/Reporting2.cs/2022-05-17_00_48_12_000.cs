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
    public partial class Reporting2 : Form
    {
/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/        public Reporting2()
        {
            InitializeComponent();
        }

        private void butRlod_Click(object sender, EventArgs e)
        {
            txtInsSrch.Clear();
            combsrch.SelectedIndex = -1;
            dataSrchIns.Columns.Clear();
        }

        private void Reporting2_Load(object sender, EventArgs e)
        {
            combsrch.Focus();

        }
    }
}
