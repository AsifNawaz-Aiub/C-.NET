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
    public partial class FindStudentInfo : Form
    {
        public string id;
        public FindStudentInfo(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FindStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFindID.Text=="") {

                MessageBox.Show("Please Give An Id First");
            }
            else {
                int id2 = int.Parse(txtFindID.Text);// This should be removed as your database table has Int type not nvarchar type

                if (id2 >= 1200)

                {
                    SqlConnection con = new SqlConnection();


                    //ConnectionString:
                    con.ConnectionString = "data source = DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                    SqlCommand cmd = new SqlCommand("select * from StudentsXII where ID=" + id2, con);
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
                }
                else
                {
                    SqlConnection con = new SqlConnection();


                    //ConnectionString:
                    con.ConnectionString = "data source =DESKTOP-EFOSC40\\MSQL;database = AIC;integrated security = SSPI";

                    SqlCommand cmd = new SqlCommand("select * from StudentsXI where ID=" + id2, con);
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

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principle p = new Principle(id);
            p.Show();
        }
    }
}
