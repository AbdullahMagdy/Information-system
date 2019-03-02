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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            string query = "Select * from stud_login where Name = '" + txtname.Text.Trim() + "' and password = '" + txtpass.Text.Trim() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count == 1)
            {
                Form9 obj = new Form9();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Please , Check your info ");

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // register
            panel2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // previous
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("insertdata2", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", textBox1.Text);
            com.Parameters.AddWithValue("@name", textBox2.Text);
            com.Parameters.AddWithValue("@email", textBox3.Text);
            com.Parameters.AddWithValue("@password", textBox4.Text);
            com.Parameters.AddWithValue("@academic", textBox5.Text);
            com.ExecuteNonQuery();
            string q = @"insert into stud_login (Name , password) values (@name ,@password )";
            SqlCommand com1 = new SqlCommand(q, con);
            SqlParameter Name = new SqlParameter("@name", textBox2.Text);
            com1.Parameters.Add(Name);
            SqlParameter pass = new SqlParameter("@password", textBox4.Text);
            com1.Parameters.Add(pass);

            com1.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
