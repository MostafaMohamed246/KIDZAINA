using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace kidzania
{

    public partial class login : MetroFramework.Forms.MetroForm
    {
        //data type
        public struct user
        {
            public DataTable da;
            public int usertype;
        };
        user s=new user();
        int user1 = 0;
        int passward= 0;
        int tb_click=0;
        int pb_click = 0;
        int cl = 1;
        register form_reg = new register();
        programing.login log = new programing.login();
        ////////////////////////////////////////////////////////
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_Click(object sender, EventArgs e)
        {    
            if(user1==0)
            textBox1.Clear();
            pictureBox2.Image = Properties.Resources.User_50pxp;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.BackColor = Color.Brown;
            textBox1.ForeColor = Color.Brown;
            //____________________________________________________________
            pictureBox3.Image = Properties.Resources.Lock_64px;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            panel2.BackColor= Color.Black;
            textBox2.ForeColor = Color.DimGray;
            user1++;
            tb_click = 0;
            if (cl == 0)
            {
                pictureBox4.Image = Properties.Resources.Invisible_50px;
            }
            else if (cl == 1)
            {
                pictureBox4.Image = Properties.Resources.Eye_50px;
            }
        }
        //____________________________________________________________
        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            pictureBox2.Image = Properties.Resources.User_50px;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.BackColor = Color.Black;
            textBox1.ForeColor = Color.DimGray;
            if(passward==0)
            textBox2.Clear();
            if(tb_click!=1)
            textBox2.PasswordChar = ('*');
            pictureBox3.Image = Properties.Resources.Lock_64pxp;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            panel2.BackColor = Color.Brown;
            textBox2.ForeColor = Color.Brown;
            passward++;
            tb_click = 1;
            if (cl == 0)
            {
                    pictureBox4.Image = Properties.Resources.Invisible_50pxc;
            }
            else if (cl == 1)
            {
                    pictureBox4.Image = Properties.Resources.Eye_50pxc;
            }
        }
        //____________________________________________________________
        private void button1_Click_1(object sender, EventArgs e)
        { 
            s.da = log.log_in(textBox1.Text, textBox2.Text).da;
            s.usertype = log.log_in(textBox1.Text, textBox2.Text).usertype;
                if (s.usertype == 1 || s.usertype == 0)
                {

                this.Hide();
                    adv form = new adv(s.da);
                    form.ShowDialog();

                this.Close();
            }
                else if (s.usertype==2)
                {
                this.Hide();
                employee form_employee = new employee(s.da);
                    form_employee.ShowDialog();
                this.Close();
            }
                else if (s.usertype == 3)
            {
                this.Hide();
                admin form_admin = new admin(s.da);
                    form_admin.ShowDialog();
                this.Close();
                }        
            else
            {
                label2.Text = "The User Name or password you entered is incorrect !";
            }
        }
        //____________________________________________________________
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //____________________________________________________________
        private void timer1_Tick(object sender, EventArgs e)
        {
            form_reg.Show();
            form_reg.Left += 100;
            if (form_reg.Left >= 1230)
            {
                
                timer1.Stop();
                this.TopMost = false;
                form_reg.TopMost= true;
                timer2.Start();
            }
        }
        //___________________________________________________________
        private void timer2_Tick(object sender, EventArgs e)
        {
            form_reg.Left -= 50;
            if (form_reg.Left <= 295)
            {
                timer2.Stop();
                

            }
        }
        //____________________________________________________________
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pb_click == 0)
            {
                if (tb_click == 0)
                    pictureBox4.Image = Properties.Resources.Invisible_50px;
                else if (tb_click == 1)
                    pictureBox4.Image = Properties.Resources.Invisible_50pxc;
                textBox2.PasswordChar = '\0';
                pb_click = 1;
                cl = 0;
            }
            else if(pb_click==1)
            {

                if (tb_click == 0)
                    pictureBox4.Image = Properties.Resources.Eye_50px;
                else if (tb_click == 1)
                    pictureBox4.Image = Properties.Resources.Eye_50pxc;
                textBox2.PasswordChar = '*';
                pb_click = 0;
                cl = 1;
            }
        }
        //____________________________________________________________
        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
    
        }
    }
}
