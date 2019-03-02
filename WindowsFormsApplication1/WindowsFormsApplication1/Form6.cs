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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update courses
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string q = @"update course1 set  Name = @varname where code= @varcode";
            SqlCommand com = new SqlCommand(q, con);

            SqlParameter par_name = new SqlParameter("@varname", textBox2.Text);
            com.Parameters.Add(par_name);
            SqlParameter par_code = new SqlParameter("@varcode", textBox1.Text);
            com.Parameters.Add(par_code);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // delete courses
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string deleteString = @"delete from course1 where code = @varcode";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = deleteString;
            cmd.Connection = con;
            SqlParameter par_d = new SqlParameter("@varcode", textBox1.Text);
            cmd.Parameters.Add(par_d);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }
    }
}
