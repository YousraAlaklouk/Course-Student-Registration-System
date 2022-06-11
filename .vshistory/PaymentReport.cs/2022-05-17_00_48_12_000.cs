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
    public partial class PaymentReport : Form
    {
/*        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/        public PaymentReport()
        {
            InitializeComponent();
        }

        private void butRlod_Click(object sender, EventArgs e)
        {
            checkDntComp.Checked = false;
            checkDntPay.Checked = false;
            checkStdComp.Checked = false;
            txtsrch.Clear();
            dataPayment.Columns.Clear();
        }

        private void PaymentReport_Load(object sender, EventArgs e)
        {
            txtsrch.Focus();
        }



        private void butNtfy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" notified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
