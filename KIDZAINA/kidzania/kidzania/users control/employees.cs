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
    public partial class employees : UserControl
    {
        programing.employee em = new programing.employee();
        public employees()
        {
          
            InitializeComponent();
            metroGrid1.DataSource = em.viewem();
            metroGrid2.DataSource = em.viewem();
            metroGrid4.DataSource = em.viewem();
 

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {
        metroGrid1.DataSource=em.viewem();

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {
            metroGrid4.DataSource = em.viewem();
        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {
            metroGrid2.DataSource = em.viewem();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              em.deleteem(metroGrid2.CurrentRow.Cells[0].Value.ToString());
           
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            programing.sponsor sp = new programing.sponsor();
            programing.signup sing = new programing.signup();
                MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            Byte[]imge = ms.ToArray();
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox3.Text)  && !string.IsNullOrEmpty(textBox2.Text)&& !string.IsNullOrEmpty(textBox4.Text)&&sing.checkforname(textBox1.Text)!=1)
            {
                em.addem(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, int.Parse(numericUpDown1.Value.ToString()), imge);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Title = "upload Advertising";
            openFileDialog1.Filter = " Images Files |  *.PNG ; *.GIF ; *.BMP; *.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            }
        }

        private void metroGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            programing.sponsor sp = new programing.sponsor();
            programing.signup sing = new programing.signup();
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            Byte[] imge = ms.ToArray();
            if (!string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrEmpty(textBox9.Text) )
            {
                em.upem(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, int.Parse(numericUpDown1.Value.ToString()), imge);
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

        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "upload Advertising";
            openFileDialog1.Filter = " Images Files |  *.PNG ; *.GIF ; *.BMP; *.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox12.Text = metroGrid4.CurrentRow.Cells[1].Value.ToString();
            textBox11.Text = metroGrid4.CurrentRow.Cells[2].Value.ToString();
            textBox10.Text = metroGrid4.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = metroGrid4.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = metroGrid4.CurrentRow.Cells[5].Value.ToString();
            numericUpDown2.Value= int.Parse(metroGrid4.CurrentRow.Cells[3].Value.ToString());
            byte[] image = (byte[])metroGrid4.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(image);
            pictureBox2.Image = Image.FromStream(ms);
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            button8.Visible = true;
            button7.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
