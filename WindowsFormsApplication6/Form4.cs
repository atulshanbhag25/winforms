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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid gid=Guid.NewGuid();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-03EGNPR\SQLEXPRESS;Initial Catalog=login_2;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT into dbo.user_info(user_id,username,firstname,lastname,password,mob)VALUES('"+gid+"','"+textBox4.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox5.Text+"','"+textBox3.Text+"')",con);
            SqlDataReader rdr = cmd.ExecuteReader();
            bool x = rdr.Read();
            if (x.Equals(false))
            {
                MessageBox.Show("WELCOME");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
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
