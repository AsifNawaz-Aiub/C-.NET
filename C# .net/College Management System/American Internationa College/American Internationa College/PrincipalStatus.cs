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
    public partial class PrincipalStatus : Form
    {
        public PrincipalStatus()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select * from Principle", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            lblName.Text = dt.Rows[0][1].ToString();
            lblGrad.Text = dt.Rows[0][2].ToString();
            lblGi.Text = dt.Rows[0][3].ToString();
            lblPg.Text = dt.Rows[0][4].ToString();
            lblPgi.Text = dt.Rows[0][5].ToString();
            lblPhone.Text= dt.Rows[0][6].ToString();
            lblemail.Text= dt.Rows[0][7].ToString();
            lblAdd.Text= dt.Rows[0][8].ToString();
            lblgender.Text= dt.Rows[0][9].ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a1 = new Admin();
            a1.Show();
        }
    }
}
