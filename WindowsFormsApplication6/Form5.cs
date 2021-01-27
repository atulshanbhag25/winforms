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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-03EGNPR\SQLEXPRESS;Initial Catalog=login_2;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE from dbo.user_info where user_id='"+textBox1.Text+"'",con);
            SqlDataReader rdr = cmd.ExecuteReader();
            MessageBox.Show("deleted successfully");
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_2DataSet1.user_info' table. You can move, or remove it, as needed.
            this.user_infoTableAdapter.Fill(this.login_2DataSet1.user_info);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
