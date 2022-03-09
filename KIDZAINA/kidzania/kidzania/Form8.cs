using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace kidzania
{
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        SqlConnection userr = new SqlConnection(@"server=(local);Database=kidzania;integrated security=true");
        SqlDataAdapter daa;
        DataTable dtt = new DataTable();
        DataTable data = new DataTable();
        public Form8(DataTable dt)
        {
            
            data = dt;
            InitializeComponent();
            daa = new SqlDataAdapter("select * from game where guide='"+data.Rows[0][1].ToString()+"'", userr);
            daa.Fill(dtt);
            label2.Text = dtt.Rows[0][1].ToString();
            MessageBox.Show("Passed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=kidzania;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into problem(employee_id, problem) values(@Emp_id , @problems)  ", con);
                cmd.Parameters.AddWithValue("@Emp_id", int.Parse(data.Rows[0][0].ToString()));
                cmd.Parameters.AddWithValue("@problems", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
