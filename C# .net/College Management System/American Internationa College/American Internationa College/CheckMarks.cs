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
    public partial class CheckMarks : Form
    {
        public string id;
        public CheckMarks(string id)
        {
            this.id = id;
            int id2 = int.Parse(id);
            

            if (id2 >= 1200)
            {

                InitializeComponent();
                SqlConnection con = new SqlConnection();


                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                SqlCommand cmd = new SqlCommand("select * from MarksXII where ID=" + id2, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lblBangla.Text = dt.Rows[0][1].ToString();
                lblEnglish.Text = dt.Rows[0][2].ToString();
                lblPhysics.Text = dt.Rows[0][3].ToString();
                lblChemistry.Text = dt.Rows[0][4].ToString();
                lblBiology.Text = dt.Rows[0][5].ToString();
                lblMath.Text = dt.Rows[0][6].ToString();
                lblICT.Text = dt.Rows[0][7].ToString();
              


            }
            else
            {
                InitializeComponent();
                SqlConnection con = new SqlConnection();


                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                SqlCommand cmd = new SqlCommand("select * from MarksXI where ID=" + id2, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lblBangla.Text = dt.Rows[0][1].ToString();
                lblEnglish.Text = dt.Rows[0][2].ToString();
                lblPhysics.Text = dt.Rows[0][3].ToString();
                lblChemistry.Text = dt.Rows[0][4].ToString();
                lblBiology.Text = dt.Rows[0][5].ToString();
                lblMath.Text = dt.Rows[0][6].ToString();
                lblICT.Text = dt.Rows[0][7].ToString();

            }
        }

        private void CheckMarks_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student s = new Student(id);
            this.Hide();
            s.Show();
        }
    }
}
