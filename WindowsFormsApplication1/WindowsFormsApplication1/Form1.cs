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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main obj = new Main();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 obj = new Form4();
            this.Hide();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // cancel 
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // log in 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            string query = "Select * from admin_info where Name = '" + txtname.Text.Trim() + "' and password = '" + txtpass.Text.Trim() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count == 1)
            {
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Please , Check your info ");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // log in instructor
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            // register admin
            panel2.Visible = true;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("insertdata5", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", textBox1.Text);
            com.Parameters.AddWithValue("@name", textBox2.Text);
            com.Parameters.AddWithValue("@email", textBox4.Text);
            com.Parameters.AddWithValue("@password", textBox3.Text);
           
            string q = @"insert into admin_info (Name , password) values (@name ,@password )";
            SqlCommand com1 = new SqlCommand(q, con);
            SqlParameter Name = new SqlParameter("@name", textBox2.Text);
            com1.Parameters.Add(Name);
            SqlParameter pass = new SqlParameter("@password", textBox3.Text);
            com1.Parameters.Add(pass);

            com1.ExecuteNonQuery();


            com.ExecuteNonQuery();
            MessageBox.Show("Registered");
            con.Close();
        }

       

       
    }
}
