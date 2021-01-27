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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-03EGNPR\SQLEXPRESS;Initial Catalog=login_2;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand(@"select * from dbo.user_info where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            bool x = rdr.Read();
            if (x.Equals(true))
            {
                MessageBox.Show("WELCOME");
            }
            else if (x.Equals(false))
            {
                MessageBox.Show("unsuccessfull ");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
