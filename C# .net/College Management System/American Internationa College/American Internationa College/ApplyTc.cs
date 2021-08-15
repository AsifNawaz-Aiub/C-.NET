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
    public partial class ApplyTc : Form
    {
        public string id;
        public ApplyTc(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Student s = new Student(id);
            this.Hide();
            s.Show();

            }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

            //Generating SQL Query
            string sql = "INSERT INTO TcApplicants(ID,Name,DesiredInstitute,Class) VALUES(@param1,@param2,@param3,@param4)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = int.Parse(txtID.Text);
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = txtName.Text;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txtDesiredInstitute.Text;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = cmbClass.Text;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("You have applied successfully");

                //Disconnect
                con.Close();
            }

        }
    }
}
