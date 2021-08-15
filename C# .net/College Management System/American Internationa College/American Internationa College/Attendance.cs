using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace American_Internationa_College
{
    public partial class Attendance : Form
    {
        public string id;
        public string cls;
        public Attendance(string id)
        {
            this.id = id;
            InitializeComponent();


        }

        private void btnAssign_Click(object sender, EventArgs e)
        {


            if (cls == null) {

                MessageBox.Show("Please Assign Class First!");
            }

            else {
                //Namespace:


                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                string sql = "INSERT into Attendance" + cls + " (Date) VALUES(@param1)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //Opening the connection:
                    con.Open();

                    cmd.Parameters.Add("@param1", SqlDbType.DateTime).Value = dateTimePicker1.Text;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    //Disconnect
                    con.Close();
                }


            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cls = "XI";
            //SqlConnection con = new SqlConnection();

            ////ConnectionString:
            //con.ConnectionString = con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";


            ////Generating SQL Query
            //SqlCommand command = new SqlCommand("select * from AttendanceXI", con);

            ////Opening the connection:
            //con.Open();

            ////Execute SQL Query:
            //SqlDataReader DR = command.ExecuteReader();

            ////Binding reader to binding source
            //BindingSource source = new BindingSource();
            //source.DataSource = DR;

            ////Binding gridview or control datacsource to binding source:
            //dataGridView1.DataSource = source;

            ////Disconnect
            //con.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cls = "XII";

            //SqlConnection con = new SqlConnection();

            ////ConnectionString:
            //con.ConnectionString = con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";


            ////Generating SQL Query
            //SqlCommand command = new SqlCommand("select * from AttendanceXII", con);

            ////Opening the connection:
            //con.Open();

            ////Execute SQL Query:
            //SqlDataReader DR = command.ExecuteReader();

            ////Binding reader to binding source
            //BindingSource source = new BindingSource();
            //source.DataSource = DR;

            ////Binding gridview or control datacsource to binding source:
            //dataGridView1.DataSource = source;

            ////Disconnect
            //con.Close();


        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (cls == "")
            {
                MessageBox.Show("Please Assign Class First!");
            
            }

            else {

                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                String dt = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string sql = "UPDATE Attendance" + cls + " SET [" + textBox1.Text + "] = 1 where Date ='" + dt + "'   ";
                MessageBox.Show(sql);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //Opening the connection:
                    con.Open();


                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();



                    //Execute SQL Query:
                    SqlCommand command = new SqlCommand("select * From Attendance"+cls+"", con);
                    SqlDataReader DR = command.ExecuteReader();

                    //Binding reader to binding source
                    BindingSource source = new BindingSource();
                    source.DataSource = DR;

                    //Binding gridview or control datacsource to binding source:
                    dataGridView1.DataSource = source;



                    //Disconnect
                    con.Close();
                }


            }




        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (cls=="") {

                MessageBox.Show("Please Assign Class First!");
            
            }

            else 
            {
                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                String dt = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string sql = "UPDATE Attendance" + cls + " SET [" + textBox1.Text + "] = 0 where Date ='" + dt + "'   ";
                MessageBox.Show(sql);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //Opening the connection:
                    con.Open();


                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();



                    //Execute SQL Query:
                    SqlCommand command = new SqlCommand("select * From Attendance" + cls + "", con);
                    SqlDataReader DR = command.ExecuteReader();

                    //Binding reader to binding source
                    BindingSource source = new BindingSource();
                    source.DataSource = DR;

                    //Binding gridview or control datacsource to binding source:
                    dataGridView1.DataSource = source;



                    //Disconnect
                    con.Close();
                }


            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher tchr = new Teacher(id);
            tchr.Show();

        }
    }
}
