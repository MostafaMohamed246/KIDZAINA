using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kidzania
{
    public partial class admin : MetroFramework.Forms.MetroForm
    {
        bool isopen=true;
        int wid,x;
        public admin(DataTable dt)
        {
            InitializeComponent();
            wid = panel1.Width;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Top = button3.Top;
            panel2.Height = button3.Height;
            panel2.Visible = true;
            my_account1.Visible = false; ;
            userControl11.Visible = true;
            userControl21.Visible = false;
            employees1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Top = button5.Top;
            panel2.Height = button5.Height;
            panel2.Visible = true;
            Form3 us = new Form3();
            us.ShowDialog();
           
        }
        private void button8_Click(object sender, EventArgs e)
        {
            panel2.Top = button8.Top;
            panel2.Height = button8.Height;
            panel2.Visible = true;
           // Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Top = button1.Top;
            panel2.Height = button1.Height;
            panel2.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Top = button7.Top;
            panel2.Height = button7.Height;
            panel2.Visible = true;
            Form4 g = new Form4();
            g.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Top = button6.Top;
            panel2.Height = button6.Height;
            panel2.Visible = true;
            my_account1.Visible = true;
            userControl11.Visible = false;
            userControl21.Visible = false;
            employees1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Top = button4.Top;
            panel2.Height = button4.Height;
            panel2.Visible = true;
            my_account1.Visible = false;
            userControl11.Visible = false;
            userControl21.Visible = false;
            employees1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (isopen)
                x = 406;
            else
                x = 93;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employees1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isopen)
            {
                panel1.Width -= 10;
                x -= 10;
                pictureBox2.Location = new Point(x, 17);
                if (panel1.Width<=90)
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
