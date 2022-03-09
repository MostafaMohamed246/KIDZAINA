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

namespace kidzania
{
    public partial class employee : MetroFramework.Forms.MetroForm
    {
      public static  DataTable datat = new DataTable();
        public employee(DataTable dt)
        {
            InitializeComponent();
            datat = dt;
        }

        private void employee_Load(object sender, EventArgs e)
        {
            byte[] imag = (byte[])datat.Rows[0][6];
            MemoryStream ms = new MemoryStream(imag);
            pictureBox1.Image = Image.FromStream(ms);
            label1.Text = datat.Rows[0][1].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Top = button5.Top;
            panel2.Height = button5.Height;
            panel2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Top = button8.Top;
            panel2.Height = button8.Height;
            panel2.Visible = true;
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Top = button3.Top;
            panel2.Height = button3.Height;
            panel2.Visible = true;
            Form8 f = new Form8(datat);
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Top = button6.Top;
            panel2.Height = button6.Height;
            panel2.Visible = true;
            edit_employ1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Top = button2.Top;
            panel2.Height = button2.Height;
            panel2.Visible = true;
            Form7 f = new Form7();
            f.Show();
        }

        private void problem1_Load(object sender, EventArgs e)
        {

        }
    }
}
