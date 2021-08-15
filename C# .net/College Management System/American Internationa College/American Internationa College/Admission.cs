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
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;" +
                                   "database = AIC;" +
                                   "integrated security = SSPI";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from Results", con);

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

        private void btnApprove_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";


            SqlCommand cmdR = new SqlCommand("select * from Registration",con);
            SqlDataAdapter sdaR = new SqlDataAdapter(cmdR);
            DataTable dtR = new DataTable();
            sdaR.Fill(dtR);


            SqlCommand cmdRe = new SqlCommand("select * from Results",con);
            SqlDataAdapter sdaRe = new SqlDataAdapter(cmdRe);
            DataTable dtRe = new DataTable();
            sdaRe.Fill(dtRe);



            for (int i = 0; i < dtR.Rows.Count; i++)
            {
                for (int j = 0; j < dtRe.Rows.Count; j++)
                {
                    if (dtR.Rows[i][12].ToString() == dtRe.Rows[j][1].ToString())
                    {
                        MessageBox.Show("Approved"); 
                        String name = dtR.Rows[i][0].ToString();
                        string ID = dtR.Rows[i][12].ToString();
                        int id = int.Parse(ID);
                        String father = dtR.Rows[i][1].ToString();
                        String mother = dtR.Rows[i][2].ToString();
                        String dob = dtR.Rows[i][3].ToString();
                        String address = dtR.Rows[i][4].ToString();
                        String phone = dtR.Rows[i][5].ToString();
                        String ssc = dtR.Rows[i][6].ToString();
                        String pass = dtR.Rows[i][7].ToString();
                        String sscg = dtR.Rows[i][8].ToString();
                        String gender = dtR.Rows[i][9].ToString();
                        String religion = dtR.Rows[i][10].ToString();
                        String email = dtR.Rows[i][11].ToString();

                        string sql = "INSERT INTO StudentsXI(Name,ID,Father,Mother,DOB,Address,Phone,SSCResult,PassingYear,SSCGroup,Gender,Religion,Email) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11,@param12,@param13)";
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            //Opening the connection:
                            con.Open();

                            cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = name;
                            cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 50).Value = ID;
                            cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = father;
                            cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = mother;
                            cmd.Parameters.Add("@param5", SqlDbType.Date).Value = dob;
                            cmd.Parameters.Add("@param6", SqlDbType.NVarChar, 50).Value = address;
                            cmd.Parameters.Add("@param7", SqlDbType.NVarChar, 50).Value = phone;
                            cmd.Parameters.Add("@param8", SqlDbType.NVarChar, 50).Value = ssc;
                            cmd.Parameters.Add("@param9", SqlDbType.NVarChar, 50).Value = pass;
                            cmd.Parameters.Add("@param10", SqlDbType.VarChar, 50).Value = sscg;
                            cmd.Parameters.Add("@param11", SqlDbType.VarChar, 50).Value = gender;
                            cmd.Parameters.Add("@param12", SqlDbType.VarChar, 50).Value = religion;
                            cmd.Parameters.Add("@param13", SqlDbType.NVarChar, 50).Value = email;


                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();

                            //Disconnect
                            con.Close();

                        }


                    }



                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin fa = new Admin();
            fa.Show(); 
        }
    }
}
