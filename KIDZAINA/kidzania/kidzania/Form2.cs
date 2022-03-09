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

namespace kidzania
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        SqlConnection gam = new SqlConnection(@"server=(local);Database=kidzania;integrated security=true");
        SqlDataAdapter daaaa;
        DataTable dtttt = new DataTable();
        public Form2()
        {
            InitializeComponent();
            daaaa = new SqlDataAdapter("select * from game", gam);
            daaaa.Fill(dtttt);
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Prog_d_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String cs = "data source=(local);database=kidzania;integrated security=SSIP";
            SqlConnection connect = new SqlConnection(cs);
            connect.Open();
            SqlCommand cmd = new SqlCommand("Select thats_the_kidzania From Admin", connect);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            textBox1.Text = cmd.ExecuteReader().ToString();
            connect.Close();
        }
    }
}
