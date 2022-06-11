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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public OpenACourse()
        {
            InitializeComponent();
        }

        private void opnBut_Click(object sender, EventArgs e)
        {
            string open = "open";
            connection.Open();
            DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {
                try
                {


                    SqlCommand cmd = new SqlCommand("UPDATE Courses SET State= @state ,DurationFrom= @from , DurationTO= @to, PricePerMonth= @price, CourseRoom= @room , Days =@day, Time= @time , DATE = GETDATE() WHERE CourseID=@ID ", connection);
                    cmd.Parameters.AddWithValue("@ID", combCrs.SelectedValue);
                    cmd.Parameters.AddWithValue("@state", open);
                    cmd.Parameters.AddWithValue("@from",Convert.ToDateTime(txtDurFr.Text));
                    cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(txtDurTo.Text));
                    cmd.Parameters.AddWithValue("@price", txtPric.Text.Trim());
                    cmd.Parameters.AddWithValue("@room", txtRoom.Text.Trim());
                    cmd.Parameters.AddWithValue("@day", txtDays.Text.Trim());
                    cmd.Parameters.AddWithValue("@time", txtTim.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Opened", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    connection.Close();
                }

            }
        }

            private void cancBut_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();


            }


            private void closeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Close();

            }

            private void OpenACourse_Load(object sender, EventArgs e)
            {
                combCrs.Focus();

                connection.Open();
                SqlCommand sc = new SqlCommand("SELECT Name, CourseID FROM Courses", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sc);
                adapter.SelectCommand = sc;
                DataTable University = new DataTable();
                adapter.Fill(University);
                combCrs.DataSource = University;
                combCrs.DisplayMember = "Name";
                combCrs.ValueMember = "CourseID";
                connection.Close();
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
    }
    }
