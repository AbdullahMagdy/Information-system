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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("viewallcourses1", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@id", textBox1.Text));
            SqlDataReader rdr = com.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name");
           

            DataRow row;
            while (rdr.Read())
            {
                row = tbl.NewRow();
                row["Name"] = rdr["Name"];
                tbl.Rows.Add(row);
            }
            rdr.Close();
            con.Close();

            dataGridView1.DataSource = tbl;


        }
    }
}
