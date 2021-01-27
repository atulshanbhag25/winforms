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

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-03EGNPR\SQLEXPRESS;Initial Catalog=login_2;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from dbo.admin_info where username='"+textBox1.Text+"'and password='"+textBox2.Text+"'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            bool x = rdr.Read();
            if (x.Equals(true))
            {
                this.Hide();
                Form5 form5 = new Form5();
                form5.Show();
            }
            else if (x.Equals(false))
            {
                MessageBox.Show("unsuccessfull go to signup page");
                this.Hide();
                Form6 form6 = new Form6();
                form6.Show();
            }

        }
    }
}
