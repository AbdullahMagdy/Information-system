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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string q = @"update instructor1 set  password = @varpass where ID= @varid";
            SqlCommand com = new SqlCommand(q, con);

            SqlParameter par_pass = new SqlParameter("@varpass", textBox6.Text);
            com.Parameters.Add(par_pass);
            SqlParameter par_id = new SqlParameter("@varid", textBox1.Text);
            com.Parameters.Add(par_id);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // delete
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string deleteString = @"delete from instructor1 where ID = @varid";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = deleteString;
            cmd.Connection = con;
            SqlParameter par_id = new SqlParameter("@varid", textBox1.Text);
            cmd.Parameters.Add(par_id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");

        }
    }
}
