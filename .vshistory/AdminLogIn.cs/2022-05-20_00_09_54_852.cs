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


                    SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE Username = '"+txtEmOrUn.Text+"' OR Email= '"+txtEmOrUn.Text+"' AND Password ='"+txtPass.Text+"' ", connection);




                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Logged In , Welcome Back !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
                else
                {
                    MessageBox.Show("Data Unsaved, Error");
                }



                connection.Close();
                /*                if (txtEmOrUn.Text == "ADMIN" && txtPass.Text == "12345")
                                {

                                    try
                                    {



                                        MessageBox.Show("Logged In , Welcome Back !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        clear();
                                        //Add try catch
                                        Form AminLogIn = new AdminInterface();
                                        AminLogIn.ShowDialog();
                                    }

                                    catch
                                    {
                                        MessageBox.Show("wrong username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }*/
                /*                else
                                {
                                    MessageBox.Show("wrong username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }*/


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


