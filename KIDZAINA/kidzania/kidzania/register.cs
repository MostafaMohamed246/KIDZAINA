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
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace kidzania
{
    public partial class register : MetroFramework.Forms.MetroForm
    {
        string s;
        int x=0,c=0, pn=0, ph=0, pe=0, pass=0, cpass=0, pb_click=0, tb_click=0,c1=0;
        int pb_click2 = 0, tb_click2 = 0, c2 = 0;
        int gent=-1;
        string sphone;
        DateTime d;
        private static register frm;
        programing.signup re = new programing.signup();
        programing.sponsor sp = new programing.sponsor();
        ///_____________________________________________________________________
        sqlconnention.Class1 sqlc = new sqlconnention.Class1();
        public register()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        public static void MyDelay(int seconds)
        {
            DateTime dt = DateTime.Now + TimeSpan.FromSeconds(seconds);

            do { } while (DateTime.Now < dt);
        }
        private void tb_cpass_TextChanged(object sender, EventArgs e)
        {
            if(tb_cpass.Text!=tb_pass.Text&& !string.IsNullOrEmpty(tb_pass.Text)&& !string.IsNullOrEmpty(tb_cpass.Text))
            {
                label2.Text = "the conferm password and password are not same";
                pictureBox1.Image = Properties.Resources.Delete_48px;
            }
            else
            {
                label2.Text = " ";
                pictureBox1.Image = null;
            }
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
                pict_coremail.Image = null;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gent = 0;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gent = 1;
        }
        private void register_Load(object sender, EventArgs e)
        {
            //byte[] image = (byte[])sp.viewadv(0).Rows[0][0];
            //MemoryStream ms = new MemoryStream();
            //BackgroundImage = Image.FromStream(ms);
            int d = DateTime.Now.Year;
            for (int i = 0; i < 100; i++)
                 com_years.Items.Add(d - i);
        }
        private void tb_child_Click(object sender, EventArgs e)
        {
            tb_click2 = 0;
            tb_click = 0;
            if (c==0)
            tb_child.Clear();
            panel_c.BackColor = Color.Brown;
            tb_child.ForeColor = Color.Brown;
            pb_c.Image = Properties.Resources.User_50pxp;
//_________________________________________________________________
            tb_pn.ForeColor = Color.DimGray;
            panel_np.BackColor = Color.Black;
            pb_pn.Image = Properties.Resources.Guardian_50px;
//_________________________________________________________________
            tb_p.ForeColor = Color.DimGray;
            panel_p.BackColor = Color.Black;
            pb_p.Image = Properties.Resources.Phone_50pxp;
//_________________________________________________________________
           tb_email.ForeColor = Color.DimGray;
            panel_email.BackColor= Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxp;
//_________________________________________________________________
            tb_pass.ForeColor = Color.DimGray;
            pan_pass.BackColor = Color.Black;
            pb_pass.Image = Properties.Resources.Lock_64px;
//_________________________________________________________________
            tb_cpass.ForeColor = Color.DimGray;
            panel_cpass.BackColor = Color.Black;
            pb_cpass.Image = Properties.Resources.Lock_64px;
//_________________________________________________________________
            if (c2 == 1)
                pict_see1.Image = Properties.Resources.Invisible_50px; 
            if (c2 == 0)
                pict_see1.Image = Properties.Resources.Eye_50px;
            if (c1 == 1)
                picture_see.Image = Properties.Resources.Invisible_50px;
            if (c1 == 0)
                picture_see.Image = Properties.Resources.Eye_50px;
            c++;
        }
        private void tb_pn_Click(object sender, EventArgs e)
        {
            tb_click2 = 0;
            tb_click = 0;
            tb_child.ForeColor = Color.Black;
            panel_c.BackColor = Color.Black;
            pb_c.Image = Properties.Resources.User_50px;
//_________________________________________________________________
            if (pn == 0)
                tb_pn.Clear();
            tb_pn.ForeColor = Color.Brown;
            panel_np.BackColor = Color.Brown;
            pb_pn.Image = Properties.Resources.Guardian_50pxp;
 //_________________________________________________________________
            tb_p.ForeColor = Color.DimGray;
            tb_p.ForeColor = Color.DimGray;
            panel_p.BackColor = Color.Black;
            pb_p.Image = Properties.Resources.Phone_50pxp;
//_________________________________________________________________
            tb_email.ForeColor = Color.DimGray;
            panel_email.BackColor = Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxp;
//_________________________________________________________________
            tb_pass.ForeColor = Color.DimGray;
            pan_pass.BackColor = Color.Black;
            pb_pass.Image = Properties.Resources.Lock_64px;
//_________________________________________________________________
            tb_cpass.ForeColor = Color.DimGray;
            panel_cpass.BackColor = Color.Black;
            pb_cpass.Image = Properties.Resources.Lock_64px;
            if (c2 == 1)
                pict_see1.Image = Properties.Resources.Invisible_50px;
             else if (c2 == 0)
                pict_see1.Image = Properties.Resources.Eye_50px;
            if (c1 == 1)
                picture_see.Image = Properties.Resources.Invisible_50px; 
            else if (c1 == 0)
                picture_see.Image = Properties.Resources.Eye_50px;
            pn++;
        }
        private void tb_p_Click(object sender, EventArgs e)
        {
            tb_click2 = 0;
            tb_click = 0;
            tb_child.ForeColor = Color.Black;
            panel_c.BackColor = Color.Black;
            pb_c.Image = Properties.Resources.User_50px;
            //_________________________________________________________________
            tb_pn.ForeColor = Color.DimGray;
            panel_np.BackColor = Color.Black;
            pb_pn.Image = Properties.Resources.Guardian_50px;
            //_________________________________________________________________
            if (ph == 0)
                tb_p.Clear();
            tb_p.ForeColor = Color.Brown;
            panel_p.BackColor = Color.Brown;
            pb_p.Image = Properties.Resources.Phone_50px;
            //_________________________________________________________________
            tb_email.ForeColor = Color.DimGray;
            panel_email.BackColor = Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxp;
            //_________________________________________________________________
            tb_pass.ForeColor = Color.DimGray;
            pan_pass.BackColor = Color.Black;
            pb_pass.Image = Properties.Resources.Lock_64px;
            //_________________________________________________________________
            tb_cpass.ForeColor = Color.DimGray;
            panel_cpass.BackColor = Color.Black;
            pb_cpass.Image = Properties.Resources.Lock_64px;
            //_________________________________________________________________
            ph++;
            if (c2 == 1)
            {
                pict_see1.Image = Properties.Resources.Invisible_50px;
            }
             if (c2 == 0)
            {
                pict_see1.Image = Properties.Resources.Eye_50px;
            }

            if (c1 == 1)
            {
                picture_see.Image = Properties.Resources.Invisible_50px;
            }
            if (c1 == 0)
            {
                picture_see.Image = Properties.Resources.Eye_50px;
            }
        }
        private void tb_email_Click(object sender, EventArgs e)
        {
            tb_click2 = 0;
            tb_click = 0;
            tb_child.ForeColor = Color.Black;
            panel_c.BackColor = Color.Black;
            pb_c.Image = Properties.Resources.User_50px;
            //_________________________________________________________________
            tb_pn.ForeColor = Color.DimGray;
            panel_np.BackColor = Color.Black;
            pb_pn.Image = Properties.Resources.Guardian_50px;
            //_________________________________________________________________
            tb_p.ForeColor = Color.DimGray;
            panel_p.BackColor = Color.Black;
            pb_p.Image = Properties.Resources.Phone_50pxp;
            //_________________________________________________________________
            if (pe == 0)
                tb_email.Clear();
            tb_email.ForeColor = Color.Brown;
           panel_email.BackColor = Color.Brown;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxc;
            //_________________________________________________________________
            tb_pass.ForeColor = Color.DimGray;
            pan_pass.BackColor = Color.Black;
            pb_pass.Image = Properties.Resources.Lock_64px;
            //_________________________________________________________________
            tb_cpass.ForeColor = Color.DimGray;
            panel_cpass.BackColor = Color.Black;
            pb_cpass.Image = Properties.Resources.Lock_64px;
            //_________________________________________________________________
            pe++;
            if (c2 == 1)
                pict_see1.Image = Properties.Resources.Invisible_50px;
            else if (c2 == 0)
                pict_see1.Image = Properties.Resources.Eye_50px;
            if (c1 == 1)
                picture_see.Image = Properties.Resources.Invisible_50px;
            else if (c1 == 0)
                picture_see.Image = Properties.Resources.Eye_50px;
        }
        private void tb_pass_Click(object sender, EventArgs e)
        {
            tb_click2 = 0;
            tb_click = 1;
            tb_child.ForeColor = Color.Black;
            panel_c.BackColor = Color.Black;
            pb_c.Image = Properties.Resources.User_50px;
            //_________________________________________________________________
            tb_pn.ForeColor = Color.DimGray;
            panel_np.BackColor = Color.Black;
            pb_pn.Image = Properties.Resources.Guardian_50px;
            //_________________________________________________________________
            tb_p.ForeColor = Color.DimGray;
            panel_p.BackColor = Color.Black;
            pb_p.Image = Properties.Resources.Phone_50pxp;
            //_________________________________________________________________
            tb_email.ForeColor = Color.DimGray;
            panel_email.BackColor = Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxp;
            //_________________________________________________________________
            if (pass == 0)
                tb_pass.Clear();
            if(pb_click==0)
            tb_pass.PasswordChar = '*';
            tb_pass.ForeColor = Color.Brown;
            pan_pass.BackColor = Color.Brown;
            pb_pass.Image = Properties.Resources.Lock_64pxp;
            //_________________________________________________________________
            tb_cpass.ForeColor = Color.DimGray;
            panel_cpass.BackColor = Color.Black;
            pb_cpass.Image = Properties.Resources.Lock_64px;
            //_________________________________________________________________
            pass++;
            if (c2 == 1)
                pict_see1.Image = Properties.Resources.Invisible_50px;
            else if (c2 == 0)
                pict_see1.Image = Properties.Resources.Eye_50px;
            if (c1 == 1)
                picture_see.Image = Properties.Resources.Invisible_50pxc;
            else if (c1 == 0)
                picture_see.Image = Properties.Resources.Eye_50pxc;
                    
        }
        private void tb_cpass_Click(object sender, EventArgs e)
        {
            tb_click2 = 1;
            tb_click = 0;
            tb_child.ForeColor = Color.Black;
            panel_c.BackColor = Color.Black;
            pb_c.Image = Properties.Resources.User_50px;
            //_________________________________________________________
            tb_pn.ForeColor = Color.DimGray;
            panel_np.BackColor = Color.Black;
            pb_pn.Image = Properties.Resources.Guardian_50px;
            //_________________________________________________________________
            tb_p.ForeColor = Color.DimGray;
            panel_p.BackColor = Color.Black;
            pb_p.Image = Properties.Resources.Phone_50pxp;
            //_________________________________________________________________
            tb_email.ForeColor = Color.DimGray;
            panel_email.BackColor = Color.Black;
            pb_email.Image = Properties.Resources.Secured_Letter_50pxp;
            //_________________________________________________________________
            tb_pass.ForeColor = Color.DimGray;
            pan_pass.BackColor = Color.Black;
            pb_pass.Image = Properties.Resources.Lock_64px;
            //_________________________________________________________________
            if (cpass == 0)
                tb_cpass.Clear();
            if (pb_click2 == 0)
                tb_cpass.PasswordChar='*';
            tb_cpass.ForeColor = Color.Brown;
            panel_cpass.BackColor = Color.Brown;
            pb_cpass.Image = Properties.Resources.Lock_64pxp;
            //_________________________________________________________________
            cpass++;
            if (c2 == 1)
                pict_see1.Image = Properties.Resources.Invisible_50pxc;
            else if (c2 == 0)
                pict_see1.Image = Properties.Resources.Eye_50pxc;
            if (c1 == 1)
                picture_see.Image = Properties.Resources.Invisible_50px;
            else if (c1 == 0)
                picture_see.Image = Properties.Resources.Eye_50px;
        }
        private void picture_see_Click(object sender, EventArgs e)
                {
                    if (pb_click == 0)
                    {
                        if (tb_click == 0)
                            picture_see.Image = Properties.Resources.Invisible_50px;
                        else if (tb_click == 1)
                            picture_see.Image = Properties.Resources.Invisible_50pxc;
                        tb_pass.PasswordChar = '\0';
                        pb_click = 1;
                        c1 = 1;
                    }
                    else if (pb_click == 1)
                    {
                        if (tb_click == 0)
                            picture_see.Image = Properties.Resources.Eye_50px;
                        else if (tb_click == 1)
                            picture_see.Image = Properties.Resources.Eye_50pxc;
                        tb_pass.PasswordChar = '*';
                        pb_click = 0;
                        c1 = 0;
                    }
                }
        private void pict_see1_Click(object sender, EventArgs e)
        {
            if (pb_click2 == 0)
            {
                if (tb_click2 == 0)
                    pict_see1.Image = Properties.Resources.Invisible_50px;
                else if (tb_click2 == 1)
                    pict_see1.Image = Properties.Resources.Invisible_50pxc;
                tb_cpass.PasswordChar = '\0';
                pb_click2 = 1;
                c2 = 1;
            }
            else if (pb_click2 == 1)
            {

                if (tb_click2 == 0)
                    pict_see1.Image = Properties.Resources.Eye_50px;
                else if (tb_click2 == 1)
                    pict_see1.Image = Properties.Resources.Eye_50pxc;
                tb_cpass.PasswordChar = '*';
                pb_click = 0;
                c2 =0;
            }
        }
        //____________________________________________________
         void button1_Click(object sender, EventArgs e)
        {
            x = 0;
            if (!string.IsNullOrEmpty(tb_child.Text) && !string.IsNullOrEmpty(tb_pn.Text))
            {
                s = tb_child.Text + tb_pn.Text;
            }
            if (string.IsNullOrEmpty(tb_child.Text)) { 
                label2.Text = "Please enter your complete data!";
                pictureBox0.Image = Properties.Resources.Delete_48px;
                x--;
            }
           else if (!string.IsNullOrEmpty(tb_child.Text))
            {
                label2.Text = " ";
                pictureBox0.Image = null;
                x++;
            }
            if (string.IsNullOrEmpty(tb_pn.Text))
            {
                label2.Text = "Please enter your complete data!";
                pict_corname.Image = Properties.Resources.Delete_48px;
                x--;
            }
            else if (!string.IsNullOrEmpty(tb_pn.Text)&&x==1)
            {
                label2.Text = " ";
                pict_corname.Image = null;
                x++;
            }
             if (string.IsNullOrEmpty(tb_p.Text))
            {

                label2.Text = "Please enter your complete data!";
                pictcorphone.Image = Properties.Resources.Delete_48px;
                x--;
            }
          else  if (!string.IsNullOrEmpty(tb_p.Text) && x == 2)
            {
                sphone = tb_p.Text;
                if (!int.TryParse(sphone, out int n))
                {
                    label2.Text = "Please enter your complete data!";
                    pictcorphone.Image = Properties.Resources.Delete_48px;
                    x--;
                }
                else
                {
                    label2.Text = " ";
                    pictcorphone.Image = null;
                    x++;
                }
            

            }
            if (string.IsNullOrEmpty(tb_pass.Text))
                {
                    label2.Text = "Please enter your complete data!";
                x--;
                }
            else if (!string.IsNullOrEmpty(tb_pass.Text) && x == 3)
            {
                label2.Text = " ";
                x++;
            }
            if (com_years.SelectedIndex>-1 && com_month.SelectedIndex > -1 && com_day.SelectedIndex > -1 && x == 4) {
                string month = (com_month.SelectedIndex + 1).ToString();
                string day = com_day.SelectedItem.ToString();
                string year = com_years.SelectedItem.ToString();
                string date = month + " " + day + " " + year;
                d = new DateTime();
                d = DateTime.Parse(date);
                label2.Text = " ";
                pictureBox2.Image = null;
                x++;
            }
            else if(com_years.SelectedIndex == -1 || com_month.SelectedIndex == -1 || com_day.SelectedIndex == -1)
            {
                label2.Text = "Please enter your complete data!";
                pictureBox2.Image = Properties.Resources.Delete_48px;
                x--;
            }
                if (re.checkforname(s) == 1)
                {
                    label2.Text = "this name is found Please try other name";
                    pictureBox0.Image = Properties.Resources.Delete_48px;
                x--;
                }
                else if (re.checkforname(s) == 0 && x == 5)
                {
                label2.Text = " ";
                pictureBox0.Image = null;
                x++;
                }
                if (re.checkforphane(tb_p.Text) == 1)
                {
                    label2.Text = "this phone number is found Please try other phone number";
                    pictcorphone.Image = Properties.Resources.Delete_48px;
                x--;
                }

                else if (re.checkforphane(tb_p.Text) == 0 && x == 6)
                {
                label2.Text = " ";
                pictcorphone.Image = null;
                x++;
                }
                
                if (re.checkforemail(tb_email.Text) == 1)
                {
                    label2.Text = "this email is found Please try other email";
                    pict_coremail.Image = Properties.Resources.Delete_48px;
                x--;
                }
                else if (re.checkforemail(tb_email.Text) == 0 && x == 7)
                {
                label2.Text = " ";
                pict_coremail.Image = null;
                x++;
                }
            if (gent==-1)
            {
                label2.Text = "Please Enter the gender";
                pictureBox3.Image = Properties.Resources.Delete_48px;
                x--;
            }
            else if(gent != -1 && x == 8)
            {
                label2.Text = " ";
                pictureBox3.Image = null;
                    x++;
            }
            if (x==9)
            {
                re.sign_up(s, tb_pass.Text, sphone, gent, tb_email.Text, d);
                label2.ForeColor = Color.Green;
                label2.Text = "Done ^_^";
                MetroFramework.MetroMessageBox.Show(this, "that is done"," done", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                MyDelay(3);
                label2.ForeColor = Color.Red;
                this.Hide();
            }
         }
        //____________________________________________________
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
