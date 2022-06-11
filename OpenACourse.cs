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
        // connect to the database
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CNJT2HB\\SQLEXPRESS;Initial Catalog=Course Student Registration System;Integrated Security=True");
        public OpenACourse()
        {
            InitializeComponent();
        }

        // open button to open the course
        private void opnBut_Click(object sender, EventArgs e)
        {   // convert the dates from and to to datetime 
            DateTime d1 = Convert.ToDateTime(txtDurFr.Text);
            DateTime d2 = Convert.ToDateTime(txtDurTo.Text);
            // declare open string
            string open = "open";
            // compare between the dates because from must be before to so if from it's after ot equal  to date we will have an error
            if (DateTime.Compare(d1, d2) > 0 || DateTime.Compare(d1, d2) == 0)
            {
                MessageBox.Show("the date from is later or equal the date to ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clear();
            }
            // if from date is before to date the connection will start and we can add data
            else if (DateTime.Compare(d1, d2) < 0)
            {
                connection.Open();
                DataTable dtResult = new DataTable();
            if (connection.State == ConnectionState.Open)
            {

                    try
                    {


                        SqlCommand cmd = new SqlCommand("UPDATE Courses SET State= @state ,DurationFrom= @from , DurationTO= @to, PricePerMonth= @price, CourseRoom= @room , Days =@day, Time= @time , DATE = GETDATE() WHERE CourseID=@ID ", connection);
                        cmd.Parameters.AddWithValue("@ID", combCrs.SelectedValue);
                        cmd.Parameters.AddWithValue("@state", open);
                        cmd.Parameters.AddWithValue("@from", Convert.ToDateTime(txtDurFr.Text));
                        cmd.Parameters.AddWithValue("@to", Convert.ToDateTime(txtDurTo.Text));
                        cmd.Parameters.AddWithValue("@price", txtPric.Text.Trim());
                        cmd.Parameters.AddWithValue("@room", txtRoom.Text.Trim());
                        cmd.Parameters.AddWithValue("@day", txtDays.Text.Trim());
                        cmd.Parameters.AddWithValue("@time", txtTim.Text.Trim());
                        // execute the query 
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Opened", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();

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
        }
        // cancel button to cancel the operation 
            private void cancBut_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Cancelled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();


            }

        // the menu close
            private void closeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Close();

            }
        // the load form 
            private void OpenACourse_Load(object sender, EventArgs e)
            {
                combCrs.Focus();
            try
            {

            // to fill the combobox with spesific courses "opened courses' 
                connection.Open();
                SqlCommand sc = new SqlCommand("SELECT Name, CourseID FROM Courses WHERE State = 'Close'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sc);
                adapter.SelectCommand = sc;
                DataTable University = new DataTable();
                adapter.Fill(University);
                combCrs.DataSource = University;
                combCrs.DisplayMember = "Name";
                combCrs.ValueMember = "CourseID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }
        // reset button
        private void resBut_Click(object sender, EventArgs e)
        {
            clear();

        }
        //clear method to make it easy to call anywhere
        private void clear()
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
