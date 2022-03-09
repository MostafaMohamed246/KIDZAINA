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
using System.IO;

namespace kidzania
{
    public partial class Form6 : MetroFramework.Forms.MetroForm
    {
        SqlConnection userr = new SqlConnection(@"server=(local);Database=kidzania;integrated security=true");
        SqlDataAdapter daa;
        DataTable dtt = new DataTable();
        DataTable tt = new DataTable();
        public Form6(DataTable td)
        {
            InitializeComponent();
            daa = new SqlDataAdapter("select * from visiter", userr);
            daa.Fill(dtt);
            tt = td;
            metroGrid1.DataSource = dtt;       
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imag = (byte[])metroGrid1.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(imag);
            pictureBox1.Image = Image.FromStream(ms);
            textBox1.Text = metroGrid1.CurrentRow.Cells[2].Visible.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt =new DateTime();
                dt = dateTimePicker1.Value;                
                SqlConnection con = new SqlConnection("Data Source=(local)\\SQL;Initial Catalog=kidzania;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ticket(Ticket_date , Ticket_vaildiation,Game,Visiter_id) values(@datatime , @v,@g,@id)  ", con);
                cmd.Parameters.AddWithValue("@Emp_id", dt);
                cmd.Parameters.AddWithValue("@v", 1);
                cmd.Parameters.AddWithValue("@g", int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                cmd.Parameters.AddWithValue("@id", int.Parse(tt.Rows[0][0].ToString()));
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
