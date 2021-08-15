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
    public partial class UploadMarks : Form
    {   public String dept;
        public static string cls;
        public string id;
        public UploadMarks(String dept,string id)
        {
            InitializeComponent();
            this.id = id;
            this.dept = dept;
            label2.Text = "Obtained Marks in " + dept;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            String text2 = textBox2.Text;

            if (text=="" || text2 =="" || cls=="") 
            {
                MessageBox.Show("Please Fill Up Properly");
            }
            else
            {

                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                string sql = "Update Marks" + cls + " Set " + dept + "=" + textBox2.Text + " Where ID=" + textBox1.Text;

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //Opening the connection:
                    con.Open();

                    // cmd.Parameters.Add("@param1", SqlDbType.Int).Value = textBox1.Text;
                    //cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBox2.Text;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    //Disconnect
                    con.Close();
                    MessageBox.Show("Marks Successfully Uploaded");
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cls = "XI";
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;" +
                                   "database = AIC;" +
                                   "integrated security = SSPI";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from MarksXI", con);

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cls = "XII";

            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;" +
                                   "database = AIC;" +
                                   "integrated security = SSPI";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from MarksXII", con);

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher t = new Teacher(id);
            t.Show();
            
        }
    }
}
