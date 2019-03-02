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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            // previous 
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // added 
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
            MessageBox.Show("Added");
            con.Close();
        } 


       

        private void button6_Click(object sender, EventArgs e)
        {
            // update with id 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string q = @"update admin_stud set  password = @varpass where ID= @varid";
            SqlCommand com = new SqlCommand(q, con);

            SqlParameter par_pass = new SqlParameter("@varpass", textBox4.Text);
            com.Parameters.Add(par_pass);
            SqlParameter par_id = new SqlParameter("@varid", textBox1.Text);
            com.Parameters.Add(par_id);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //delete 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string deleteString = @"delete from admin_stud where Name = @varname";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = deleteString;
            cmd.Connection = con;
            SqlParameter par_name = new SqlParameter("@varname", textBox3.Text);
            cmd.Parameters.Add(par_name);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // added p2
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("insertdata3", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", textBox6.Text);
            com.Parameters.AddWithValue("@name", textBox7.Text);
            com.Parameters.AddWithValue("@phone", textBox8.Text);
           


            com.ExecuteNonQuery();
            MessageBox.Show("Added");
            con.Close();
           


        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string q = @"update admin_depart set  phone = @varphone where Dep_ID= @varid";
            SqlCommand com = new SqlCommand(q, con);

            SqlParameter par_phone = new SqlParameter("@varphone", textBox8.Text);
            com.Parameters.Add(par_phone);
            SqlParameter par_id = new SqlParameter("@varid", textBox6.Text);
            com.Parameters.Add(par_id);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // delete 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            string deleteString = @"delete from admin_depart where Dep_Name = @varname";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = deleteString;
            cmd.Connection = con;
            SqlParameter par_name = new SqlParameter("@varname", textBox7.Text);
            cmd.Parameters.Add(par_name);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }


      

       
      
    }
}
