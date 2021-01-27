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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-03EGNPR\SQLEXPRESS;Initial Catalog=login_2;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT into dbo.admin_info(username,firstname,lastname,password,mob)VALUES('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox3.Text + "')", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            bool x = rdr.Read();
            if (x.Equals(false))
            {

                MessageBox.Show("successfull");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else if (x.Equals(true))
            {
                MessageBox.Show("unsuccessfull ");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
