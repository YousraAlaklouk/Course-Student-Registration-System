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
    public partial class AdminLogIn : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public AdminLogIn()
        {
            InitializeComponent();
        }


        public void clear()
        {
            txtEmOrUn.Clear();
            txtPass.Clear();
        }

        private void lginButt_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE (Username = '" + txtEmOrUn.Text + "' OR Email= '" + txtEmOrUn.Text + "' ) AND Password ='" + txtPass.Text + "' ", connection);




                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Logged In , Welcome Back !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        Form AminLogIn = new AdminInterface();
                        AminLogIn.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("wrong username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(" there is an error occured ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();

                }


            }

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

            private void AdminLogIn_Load(object sender, EventArgs e)
            {
                txtEmOrUn.Focus();
            }
        }
    }


