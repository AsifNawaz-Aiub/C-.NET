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
    public partial class TCApplicants : Form
    {
        String id;
        public TCApplicants(String id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;" +
                                   "database = AIC;" +
                                   "integrated security = SSPI";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from TCApplicants", con);

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

        private void btnID_Click(object sender, EventArgs e)
        {

            if (txtID.Text=="") {
                MessageBox.Show("Please Give An ID First");
            
            }

            else {
                //Initiating SQL Connection:
                SqlConnection con = new SqlConnection();

                //ConnectionString:
                con.ConnectionString = "data source =DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                String sql1 = "Select * from TCApplicants where id= " + txtID.Text;

                SqlCommand cmd = new SqlCommand(sql1, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                String cls = dt.Rows[0][3].ToString();
                String id1 = dt.Rows[0][0].ToString();




                //Initiating SQL Connection:
                //SqlConnection con1 = new SqlConnection();

                //ConnectionString:
                //con.ConnectionString = "data source = localhost;database = AIC;integrated security = SSPI";

                //Generating SQL Query
                String sql = "select * from Students" + cls + " where ID =" + id1;
                //MessageBox.Show(sql);
                SqlCommand cmd1 = new SqlCommand(sql, con);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                string name = dt1.Rows[0][0].ToString();
                string id = dt1.Rows[0][1].ToString();
                string father = dt1.Rows[0][2].ToString();
                string mother = dt1.Rows[0][3].ToString();
                string dob = dt1.Rows[0][4].ToString();
                string add = dt1.Rows[0][5].ToString();
                string phone = dt1.Rows[0][6].ToString();
                string ssc = dt1.Rows[0][7].ToString();
                string pass = dt1.Rows[0][8].ToString();
                string sscg = dt1.Rows[0][9].ToString();
                string gender = dt1.Rows[0][10].ToString();
                string rel = dt1.Rows[0][11].ToString();
                string email = dt1.Rows[0][12].ToString();


                string sql3 = "INSERT INTO TransfarredStudents(Name,ID,Father,Mother,DOB,Address,Phone,SSCResult,PassingYear,SSCGroup,Gender,Religion,Email,class) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11,@param12,@param13,@param14)";

                using (SqlCommand cmd3 = new SqlCommand(sql3, con))
                {

                    //MessageBox.Show(name+id+father+mother+dob+add+phone+ssc+pass+sscg+gender+rel+email);
                    //Opening the connection:
                    con.Open();

                    cmd3.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = name;
                    cmd3.Parameters.Add("@param2", SqlDbType.NVarChar, 50).Value = id;
                    cmd3.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = father;
                    cmd3.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = mother;
                    cmd3.Parameters.Add("@param5", SqlDbType.Date).Value = dob;
                    cmd3.Parameters.Add("@param6", SqlDbType.NVarChar, 50).Value = add;
                    cmd3.Parameters.Add("@param7", SqlDbType.NVarChar, 50).Value = phone;
                    cmd3.Parameters.Add("@param8", SqlDbType.NVarChar, 50).Value = ssc;
                    cmd3.Parameters.Add("@param9", SqlDbType.NVarChar, 50).Value = pass;
                    cmd3.Parameters.Add("@param10", SqlDbType.VarChar, 50).Value = sscg;
                    cmd3.Parameters.Add("@param11", SqlDbType.VarChar, 50).Value = gender;
                    cmd3.Parameters.Add("@param12", SqlDbType.VarChar, 50).Value = rel;
                    cmd3.Parameters.Add("@param13", SqlDbType.NVarChar, 50).Value = email;
                    cmd3.Parameters.Add("@param14", SqlDbType.VarChar, 50).Value = cls;


                    cmd3.CommandType = CommandType.Text;
                    cmd3.ExecuteNonQuery();

                    //Disconnect
                    con.Close();
                }




                //Generating SQL Query
                string sql4 = "Delete From Students" + cls + " where ID=" + id1;
                using (SqlCommand cmd4 = new SqlCommand(sql4, con))
                {
                    //Opening the connection:
                    con.Open();

                    cmd4.CommandType = CommandType.Text;
                    cmd4.ExecuteNonQuery();

                    //Disconnect
                    con.Close();
                }


            }








        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principle p = new Principle(id);
            p.Show();
        }
    }
}
