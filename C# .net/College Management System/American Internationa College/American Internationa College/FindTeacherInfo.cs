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
    public partial class FindTeacherInfo : Form
    {
        public string id;
        public FindTeacherInfo(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindID.Text=="") {

                MessageBox.Show("Give An ID First");
            }
            else {

                int id = int.Parse(txtFindID.Text);

                if (id >= 100)

                {
                    SqlConnection con = new SqlConnection();


                    //ConnectionString:
                    con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                    SqlCommand cmd = new SqlCommand("select * from Teachers where ID=" + id, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found for this ID");
                    }
                    else
                    {

                        lblName.Text = dt.Rows[0][0].ToString();
                        lblID.Text = dt.Rows[0][1].ToString();
                        lblDepartment.Text = dt.Rows[0][2].ToString();
                        lblAddress.Text = dt.Rows[0][3].ToString();
                        lblPhone.Text = dt.Rows[0][4].ToString();
                        lblEmail.Text = dt.Rows[0][5].ToString();
                        lblGraduation.Text = dt.Rows[0][6].ToString();
                        lblInstitution.Text = dt.Rows[0][7].ToString();
                        lblGender.Text = dt.Rows[0][8].ToString();

                    }
                }


            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principle p = new Principle(id);
            p.Show();
        }
    }
}
