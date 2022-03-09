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
using System.Text.RegularExpressions;
namespace kidzania.users_control
{
    public partial class edit_ads : UserControl
    {
        programing.sponsor SP = new programing.sponsor();
            DataTable dat = new DataTable();
        public edit_ads()
        {
            InitializeComponent();
            dat = SP.view();
        }

        private void edit_ads_Load(object sender, EventArgs e)
        {
            tb_name.Text = dat.Rows[UserControl1.ID][1].ToString();
            tb_phone.Text = dat.Rows[UserControl1.ID][4].ToString();
            tb_phone.Text = dat.Rows[UserControl1.ID][5].ToString();
            if (dat.Rows[0][3].ToString()=="True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
            byte[] image = (byte[])dat.Rows[0][6];
            MemoryStream ms = new MemoryStream(image);
            pictureBox2.Image = Image.FromStream(ms);
        }
        MemoryStream ms = new MemoryStream();
        int v = -1;


        public static void MyDelay(int seconds)
        {
            DateTime dt = DateTime.Now + TimeSpan.FromSeconds(seconds);

            do { } while (DateTime.Now < dt);
        }
        private void pictcorphone_Click(object sender, EventArgs e)
        {

        }

        private void tb_p_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(tb_email.Text, @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$").Success)
            {
                label2.Text = "Please Enter a corret email";
                pict_coremail.Image = Properties.Resources.Delete_48px;
            }
            else
            {
                label2.Text = " ";
                pict_coremail.Image = Properties.Resources.Checkmark_48px;
            }
        }

        private void tb_child_Click(object sender, EventArgs e)
        {

            tb_name.Clear();
            panel_c.BackColor = Color.Brown;
            tb_name.ForeColor = Color.Brown;
            pb_c.Image = Properties.Resources.User_50pxp;
            //_________________________________________________________________
            tb_phone.ForeColor = Color.DimGray;
            panel_p.BackColor = Color.Black;
            pb_p.Image = Properties.Resources.Phone_50pxp;
            //_________________________________________________________________
            tb_email.ForeColor = Color.DimGray;
            panel_email.BackColor = Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxp;

        }

        private void tb_p_Click(object sender, EventArgs e)
        {

            panel_c.BackColor = Color.Black;
            tb_name.ForeColor = Color.DimGray;
            pb_c.Image = Properties.Resources.User_50px;
            //_________________________________________________________________
            tb_phone.Clear();
            tb_phone.ForeColor = Color.Brown;
            panel_p.BackColor = Color.Brown;
            pb_p.Image = Properties.Resources.Phone_50px;
            //_________________________________________________________________
            tb_email.ForeColor = Color.DimGray;
            panel_email.BackColor = Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxp;

        }

        private void tb_email_Click(object sender, EventArgs e)
        {
            panel_c.BackColor = Color.DimGray;
            tb_name.ForeColor = Color.Black;
            pb_c.Image = Properties.Resources.User_50px;
            //_________________________________________________________________
            tb_phone.ForeColor = Color.DimGray;
            panel_p.BackColor = Color.Black;
            pb_p.Image = Properties.Resources.Phone_50pxp;
            //_________________________________________________________________
            tb_email.Clear();
            tb_email.ForeColor = Color.Brown;
            panel_email.BackColor = Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "upload Advertising";
            openFileDialog1.Filter = " Images Files |  *.PNG ; *.GIF ; *.BMP; *.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            programing.sponsor sp = new programing.sponsor();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            Byte[] imge = ms.ToArray();
            if (!string.IsNullOrEmpty(tb_email.Text) && !string.IsNullOrEmpty(tb_phone.Text) && v != -1 && !string.IsNullOrEmpty(tb_name.Text))
            {
                sp.addsponsor(tb_name.Text, tb_phone.Text, imge, v, tb_email.Text);
                label1.ForeColor = Color.Green;
                label1.Text = "Done ^_^";
                MyDelay(3);
                this.Hide();
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Please enter your complete data!";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            v = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            v = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserControl1 second = new UserControl1();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(second);
            second.Location = new Point(426, 4);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            UserControl1 second = new UserControl1();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(second);
            second.Location = new Point(426, 63);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            Byte[] imge = ms.ToArray();
            if (!string.IsNullOrEmpty(tb_email.Text) && !string.IsNullOrEmpty(tb_phone.Text) && v != -1 && !string.IsNullOrEmpty(tb_name.Text))
            {
                SP.editsponsor(UserControl1.ID,tb_name.Text, tb_phone.Text, imge, v, tb_email.Text);
                label1.ForeColor = Color.Green;
                label1.Text = "Done ^_^";
                MyDelay(3);
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

    
