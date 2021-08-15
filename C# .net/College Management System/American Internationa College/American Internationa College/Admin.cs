using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace American_Internationa_College
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrincipalStatus ps = new PrincipalStatus();
            ps.Show();

        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            Admission ad = new Admission();
            this.Hide();
            ad.Show(); 
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 alo = new Form1();
            alo.Show();
        }

        private void btnStudentStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentStatus ss = new StudentStatus();
            ss.Show();
        }

        private void btnTeacherStatus_Click(object sender, EventArgs e)
        {
            TeacherStatus ts = new TeacherStatus();
            this.Hide();
            ts.Show();
        }
    }
}
