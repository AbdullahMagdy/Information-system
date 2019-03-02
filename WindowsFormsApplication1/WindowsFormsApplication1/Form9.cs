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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code 
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U0JFIH5;Initial Catalog=college system DB;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("viewall3", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@stud_id", textBox1.Text));
           
            SqlDataReader rdr = com.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("course_name");
            tbl.Columns.Add("total_grades");
            tbl.Columns.Add("total_attendance");


            DataRow row;
            while (rdr.Read())
            {
                row = tbl.NewRow();
                row["course_name"] = rdr["course_name"];
                row["total_grades"] = rdr["total_grades"];
                row["total_attendance"] = rdr["total_attendance"];

                tbl.Rows.Add(row);
            }
            rdr.Close();
            con.Close();

            dataGridView1.DataSource = tbl;

        }
    }
}
