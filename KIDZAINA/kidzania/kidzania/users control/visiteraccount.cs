using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kidzania.users_control
{
    public partial class visiteraccount : UserControl
    {
        DataTable td = new DataTable();
        public visiteraccount()
        {
            InitializeComponent();
        }

        private void visiteraccount_Load(object sender, EventArgs e)
        {
        td=visiter.dta;
            textBox1.Text = td.Rows[0][0].ToString();
            textBox2.Text = td.Rows[0][3].ToString();
            textBox3.Text = td.Rows[0][8].ToString();
            textBox4.Text = td.Rows[0][1].ToString();
            byte[] imag =(byte[]) td.Rows[0][6];
            MemoryStream ms = new MemoryStream(imag);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            button2.Visible = true;
            textBox5.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "upload Advertising";
            openFileDialog1.Filter = " Images Files |  *.PNG ; *.GIF ; *.BMP; *.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            programing.sponsor sp = new programing.sponsor();
            programing.signup sing = new programing.signup();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] imge = ms.ToArray();
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text) && sing.checkforname(textBox1.Text) != 1)
            {
               
                label1.ForeColor = Color.Green;
                label1.Text = "Done ^_^";

                this.Hide();

            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Please enter your complete data!";
            }
        }


    }
    
}
