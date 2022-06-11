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
/*    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Thesis;Integrated Security=True");
*/    public partial class StudentPayment : Form
    {
        public StudentPayment()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtPay.Clear();
            txtStNm.Clear();
            labStNam.Text = "";
        }

        private void payButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }

        private void resButt_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cancButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();

        }

        private void StudentPayment_Load(object sender, EventArgs e)
        {
            txtStNm.Focus();
        }
    }
}
