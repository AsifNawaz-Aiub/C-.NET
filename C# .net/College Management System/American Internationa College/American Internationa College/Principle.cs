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
    public partial class Principle : Form
    {
        public string id;
        public Principle(string id)
        {
            this.id = id;
            InitializeComponent();

            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source =DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select * from Principle where ID='" + id+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            lblID.Text = dt.Rows[0][0].ToString();
            lblName.Text = dt.Rows[0][1].ToString();
            lblGraduation.Text = dt.Rows[0][2].ToString();
            lblInstitution.Text = dt.Rows[0][3].ToString();
            lblPGraduation.Text = dt.Rows[0][4].ToString();
            lblPGInstitution.Text = dt.Rows[0][5].ToString();
            lblPhone.Text = dt.Rows[0][6].ToString();
            lblEmail.Text = dt.Rows[0][7].ToString();
            lblAddress.Text = dt.Rows[0][8].ToString();
            lblGender.Text = dt.Rows[0][9].ToString();
           
        }

        private void Principle_Load(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindStudentInfo ss = new FindStudentInfo(id);
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCApplicants tc = new TCApplicants(id);
            this.Hide();
            tc.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblGraduation_Click(object sender, EventArgs e)
        {

        }

        private void lblInstitution_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindTeacherInfo ft = new FindTeacherInfo(id);
            ft.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
}
