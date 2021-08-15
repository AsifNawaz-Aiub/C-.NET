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
    
    public partial class Student : Form
    {
        
        public string id;
        public Student()
        {
            InitializeComponent();
        }
        public Student(String id)
        {
            this.id = id;
            int id2 = int.Parse(id);
          
            if (id2 >= 1200)
            {

                InitializeComponent();
                SqlConnection con = new SqlConnection();


                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                SqlCommand cmd = new SqlCommand("select * from StudentsXII where ID=" + id2, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lblName.Text = dt.Rows[0][0].ToString();
                lblID.Text = dt.Rows[0][1].ToString();
                lblFather.Text = dt.Rows[0][2].ToString();
                lblMother.Text = dt.Rows[0][3].ToString();
                lblDOB.Text = dt.Rows[0][4].ToString();
                lblAddress.Text = dt.Rows[0][5].ToString();
                lblPhone.Text = dt.Rows[0][6].ToString();
                lblSSCResult.Text = dt.Rows[0][7].ToString();
                lblPassingYear.Text = dt.Rows[0][8].ToString();
                lblGroup.Text = dt.Rows[0][9].ToString();
                lblGender.Text = dt.Rows[0][10].ToString();
                lblReligion.Text = dt.Rows[0][11].ToString();
                lblClass.Text = "XII";
           

            }
            else
            {
                InitializeComponent();
                SqlConnection con = new SqlConnection();


                //ConnectionString:
                con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                SqlCommand cmd = new SqlCommand("select * from StudentsXI where ID=" + id2, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lblName.Text = dt.Rows[0][0].ToString();
                lblID.Text = dt.Rows[0][1].ToString();
                lblFather.Text = dt.Rows[0][2].ToString();
                lblMother.Text = dt.Rows[0][3].ToString();
                lblDOB.Text = dt.Rows[0][4].ToString();
                lblAddress.Text = dt.Rows[0][5].ToString();
                lblPhone.Text = dt.Rows[0][6].ToString();
                lblSSCResult.Text = dt.Rows[0][7].ToString();
                lblPassingYear.Text = dt.Rows[0][8].ToString();
                lblGroup.Text = dt.Rows[0][9].ToString();
                lblGender.Text = dt.Rows[0][10].ToString();
                lblReligion.Text = dt.Rows[0][11].ToString();
                lblClass.Text = "XI";
                
            }
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyTc atc = new ApplyTc(id);
            this.Hide();
            atc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckMarks cm = new CheckMarks(id);
            this.Hide();
            cm.Show();

            }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
    }

