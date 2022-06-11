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
*/    public partial class Reporting4 : Form
    {
        public Reporting4()
        {
            InitializeComponent();
        }



        private void radioStu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioStu.Checked)
            {
                txtStu.Visible = true;
                labStu.Visible = true;
            }
            else
            {
                txtStu.Visible = false;
                labStu.Visible = false;
            }
        }

        private void radioInst_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInst.Checked)
            {
                txtInst.Visible = true;
                labIns.Visible = true;

            }
            else
            {
                txtInst.Visible= false;
                labIns.Visible = false;
            }
        }

        private void radioCrs_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCrs.Checked)
            {
                txtCrs.Visible = true;
                labcrs.Visible = true;

            }
            else
            {
                txtCrs.Visible= false;
                labcrs.Visible = false;
            }
        }

        private void radioCrsDat_CheckedChanged(object sender, EventArgs e)
        {
            if( radioCrsDat.Checked)
            {
                txtCrsDat.Visible = true;

            }
            else
            {
                txtCrsDat.Visible= false;
            }
        }

        private void Reporting4_Load(object sender, EventArgs e)
        {
            radioStu.Focus();
            txtCrs.Visible = false;
            txtCrsDat.Visible = false;
            txtInst.Visible = false;
            txtStu.Visible= false;
            labcrs.Visible= false;
            labIns.Visible= false;
            labStu.Visible= false;
            
        }

        private void reloadbut_Click(object sender, EventArgs e)
        {
            txtCrs.Clear();
            txtCrsDat.Clear();
            txtInst.Clear();
            txtStu.Clear();
            gridRep.Columns.Clear();
            radioCrs.Checked = false;
            radioCrsDat.Checked = false;
            radioInst.Checked = false;
            radioStu.Checked = false;
        }
    }
}
