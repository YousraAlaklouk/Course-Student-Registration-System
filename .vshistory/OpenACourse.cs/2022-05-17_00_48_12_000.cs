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
    public partial class OpenACourse : Form
    {
/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/        public OpenACourse()
        {
            InitializeComponent();
        }

        private void opnBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opened", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cancBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();


        }

        private void resBut_Click(object sender, EventArgs e)
        {
            txtDays.Clear();
            txtRoom.Clear();
            txtTim.Clear();
            txtDurFr.Clear();
            txtDurTo.Clear();
            txtPric.Clear();
            combCrs.SelectedIndex = -1;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void OpenACourse_Load(object sender, EventArgs e)
        {
            combCrs.Focus();
        }
    }
}
