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

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // fill info tg , ta

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("insertdata10", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@std_id", textBox1.Text);
            com.Parameters.AddWithValue("@crs_id", textBox2.Text);
            com.Parameters.AddWithValue("@crs_name", textBox3.Text);
            com.Parameters.AddWithValue("@T_G", textBox4.Text);
            com.Parameters.AddWithValue("@T_A", textBox5.Text);
          
            com.ExecuteNonQuery();
            MessageBox.Show("Filled");
            con.Close();
        }
    }
}
