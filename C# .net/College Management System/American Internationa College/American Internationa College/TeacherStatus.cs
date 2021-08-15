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
    public partial class TeacherStatus : Form
    {
        public static string gender;
        public TeacherStatus()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txttid.Text == "")
            {
                MessageBox.Show("Please Give An Id ");

            }
            else 
            {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                String sql = "select * from Teachers where ID =" + txttid.Text;
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


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Mention A Department ");

            }

            else
            {

                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                String sql = "select * from Teachers where Department = '" + comboBox1.Text+"'";
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

        }

        private void btnRecruit_Click(object sender, EventArgs e)
        {
            if (txtName.Text== "" || comboBox2.Text=="" || txtAddress.Text=="" || txtPhoneNo.Text=="" || txtEmail.Text==""   ) 
            {

                MessageBox.Show("Please Provide All The Information ");

            }

            else {

                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                string sql = "INSERT INTO  Teachers (Name,Department,Address, Phone,Email, Graduation,Institute,Gender) VALUES(@param1,@param2,@param3, @param4 ,@param5,@param6,@param7,@param8)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //Opening the connection:
                    con.Open();

                    cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = txtName.Text;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = comboBox2.Text; 
                    cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 50).Value = txtAddress.Text;
                    cmd.Parameters.Add("@param4", SqlDbType.NVarChar, 50).Value = txtPhoneNo.Text;
                    cmd.Parameters.Add("@param5", SqlDbType.NVarChar, 50).Value = txtEmail.Text;
                    cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@param8", SqlDbType.VarChar, 50).Value = gender;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    //Disconnect
                    con.Close();
                    MessageBox.Show(" Teacher Recruited");
                }



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

            //Generating SQL Query
            String sql = "select * from Teachers ";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admn = new Admin();
            admn.Show();
        }
    }
}
