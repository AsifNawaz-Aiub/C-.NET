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
    public partial class StudentStatus : Form
    {
        public static string cls;
        public StudentStatus()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || cls=="" )
            {
                MessageBox.Show("Please fillup properly");

            }

            else {

                if (cls == "xi")
                {
                    //Initiating SQL Connection:
                    SqlConnection con = new SqlConnection();

                    //ConnectionString:
                    con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                    //Generating SQL Query
                    String sql = "select * from StudentsXI where ID ='" + txtId.Text + "'";
                    SqlCommand command = new SqlCommand(sql, con);

                    //Opening the connection:
                    con.Open();

                    //Execute SQL Query:
                    SqlDataReader DR = command.ExecuteReader();

                    if (DR.HasRows)
                    {
                        //Binding reader to binding source
                        BindingSource source = new BindingSource();
                        source.DataSource = DR;

                        //Binding gridview or control datacsource to binding source:
                        dataGridView1.DataSource = source;

                        //Disconnect
                        con.Close();
                    }
                    else { MessageBox.Show("Error"); }
                }

                else if(cls=="XII"){

                    //Initiating SQL Connection:
                    SqlConnection con = new SqlConnection();

                    //ConnectionString:
                    con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                    //Generating SQL Query
                    String sql = "select * from StudentsXII where ID ='" + txtId.Text + "'";
                    SqlCommand command = new SqlCommand(sql, con);

                    //Opening the connection:
                    con.Open();

                    //Execute SQL Query:
                    SqlDataReader DR = command.ExecuteReader();

                    if (DR.HasRows)
                    {
                        //Binding reader to binding source
                        BindingSource source = new BindingSource();
                        source.DataSource = DR;

                        //Binding gridview or control datacsource to binding source:
                        dataGridView1.DataSource = source;

                        //Disconnect
                        con.Close();
                    }
                    else { MessageBox.Show("Error"); }

                }
            
            
            }




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cls = "XII";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cls = "XII";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

            //Generating SQL Query
            String sql = "select * from StudentsXI ";
            SqlCommand command = new SqlCommand(sql, con);

            //Opening the connection:
            con.Open();

            //Execute SQL Query:
            SqlDataReader DR = command.ExecuteReader();

            if (DR.HasRows)
            {
                //Binding reader to binding source
                BindingSource source = new BindingSource();
                source.DataSource = DR;

                //Binding gridview or control datacsource to binding source:
                dataGridView1.DataSource = source;

                //Disconnect
                con.Close();
            }
            else { MessageBox.Show("Error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

            //Generating SQL Query
            String sql = "select * from StudentsXII";
            SqlCommand command = new SqlCommand(sql, con);

            //Opening the connection:
            con.Open();

            //Execute SQL Query:
            SqlDataReader DR = command.ExecuteReader();

            //Binding reader to binding source
            BindingSource source = new BindingSource();
            source.DataSource = DR;

            //Binding gridview or control datacsource to binding source:
            dataGridView1.DataSource = source;

            //Disconnect
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show(); 
        }
    }
}
