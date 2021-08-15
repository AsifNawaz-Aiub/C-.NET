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
    public partial class Teacher : Form
    {
        public String dept;
        public string id;
        public Teacher()
        {
            InitializeComponent();
        }
        public Teacher(String id)
        {
            this.id = id;
            InitializeComponent();
            SqlConnection con = new SqlConnection();


            //ConnectionString:
            con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

            SqlCommand cmd = new SqlCommand("select * from Teachers where ID=" + id, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            label6.Text = dt.Rows[0][0].ToString();
            label7.Text = dt.Rows[0][1].ToString();
            label8.Text = dt.Rows[0][2].ToString();
            label9.Text = dt.Rows[0][3].ToString();
            label11.Text = dt.Rows[0][5].ToString();
            dept= dt.Rows[0][2].ToString(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UploadMarks um = new UploadMarks(dept,id);
            um.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance atn = new Attendance(id);
            atn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 nfrm = new Form1();
            nfrm.Show();
        }
    }
}
