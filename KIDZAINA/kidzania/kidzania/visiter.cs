using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace kidzania
{
    public partial class visiter : MetroFramework.Forms.MetroForm
    {
        bool isopen = true;
        int wid, x;
       public static DataTable dta = new DataTable();
        public visiter(DataTable dt)
        {
            InitializeComponent();
            dta = dt;
            wid = panel1.Width;
        }

        private void visiter_Load(object sender, EventArgs e)
        {
            //byte[] imag = (byte[])dta.Rows[0][6];
            //MemoryStream ms = new MemoryStream(imag);
            //pictureBox1.Image = Image.FromStream(ms);
            label1.Text = dta.Rows[0][0].ToString();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Top = button6.Top;
            panel2.Height = button6.Height;
            panel2.Visible = true;
            String cs = "data source=. ;database=kidzania;integrated security=True";
            SqlConnection connect = new SqlConnection(cs);
            connect.Open();
            int id = int.Parse(dta.Rows[0][7].ToString());
            SqlCommand cmd = new SqlCommand("Select* From visiter where VisiterId ='" + id + "';", connect);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Gender");
            tbl.Columns.Add("Birthdate");
            tbl.Columns.Add("Phone");
            tbl.Columns.Add("NumberofVisiting");
            tbl.Columns.Add("Email");
            DataRow r;
            while (reader.Read())
            {
                r = tbl.NewRow();
                r["ID"] = reader["VisiterID"];
                r["Name"] = reader["Visiter_Name"];
                r["Birthdate"] = reader["Visiterdate"];
                r["Gender"] = reader["VisiterGender"];
                r["Phane"] = reader["phane"];
                r["NumberofVisiting"] = reader["NumberofVisiting"];
                r["Email"] = reader["VisiterEmail"];
                tbl.Rows.Add(r);
            }
            reader.Close();
            connect.Close();
            metroGrid1.DataSource = tbl;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Top = button7.Top;
            panel2.Height = button7.Height;
            panel2.Visible = true;
            Form2 Prog_d = new Form2();
            Prog_d.ShowDialog();
            String cs = "data source=. ;database=kidzania;integrated security=SSIP";
            SqlConnection connect = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select From visitor", connect);
            connect.Open();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (isopen)
                x = 406;
            else
                x = 93;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Top = button1.Top;
            panel2.Height = button1.Height;
            panel2.Visible = true;
            Form2 f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Top = button3.Top;
            panel2.Height = button3.Height;
            panel2.Visible = true;
            Form6 f = new Form6(dta);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Top = button3.Top;
            panel2.Height = button3.Height;
            panel2.Visible = true;
            Form5 f = new Form5(dta);
            f.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Top = button5.Top;
            panel2.Height = button5.Height;
            panel2.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Top = button8.Top;
            panel2.Height = button8.Height;
            panel2.Visible = true;
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isopen)
            {
                panel1.Width -= 10;
                x -= 10;
                pictureBox2.Location = new Point(x, 17);
                if (panel1.Width <= 90)
                {
                    isopen = false;
                    timer1.Stop();
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width += 10;
                x += 10;
                pictureBox2.Location = new Point(x, 17);
                if (panel1.Width >= wid)
                {
                    isopen = true;
                    timer1.Stop();
                    this.Refresh();
                    pictureBox2.Location = new Point(416, 17);
                }

            }
        }
    }
}
