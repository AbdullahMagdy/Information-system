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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //regist
            panel1.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //pre
            instructor.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // registeration 
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            instructor.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //login ya beeh
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            string query = "Select * from instructor_info where Name = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count == 1)
            {
                Form3 obj = new Form3();
                this.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("check your info or you have to registeger");

            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            instructor.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //registered 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("insertdata4", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", textBox3.Text);
            com.Parameters.AddWithValue("@name", textBox4.Text);
            com.Parameters.AddWithValue("@email", textBox5.Text);
            com.Parameters.AddWithValue("@title", textBox6.Text);
            com.Parameters.AddWithValue("@salary", textBox7.Text);
            com.Parameters.AddWithValue("@password", textBox8.Text);
            com.Parameters.AddWithValue("@depart_id", textBox9.Text);
            //
            string q = @"insert into instructor_info (Name , password) values (@name ,@password )";
            SqlCommand com1 = new SqlCommand(q, con);
            SqlParameter Name= new SqlParameter("@name", textBox4.Text);
                 com1.Parameters.Add(Name);
                 SqlParameter pass = new SqlParameter("@password", textBox8.Text);
                 com1.Parameters.Add(pass); 


          
            com1.ExecuteNonQuery();


            com.ExecuteNonQuery();
            MessageBox.Show("Registered");
            con.Close();
        }

     
    }
}
