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
    public partial class adv : Form
    {
        programing.sponsor sp = new programing.sponsor();
            public int x;
        DataTable dtable=new DataTable();
        DataTable dta = new DataTable();
        public adv(DataTable dt)
        {
            InitializeComponent();
            dtable = dt;
            dta = sp.viewadv(1);

        }
        public static void MyDelay(int seconds)
        {
            DateTime dt = DateTime.Now + TimeSpan.FromSeconds(seconds);

            do { } while (DateTime.Now < dt);
        }

        private void adv_Load(object sender, EventArgs e)
        { 
        //{
        //    if (dta.Rows[0][0] != null)
        //    {
        //        byte[] image = (byte[])dta.Rows[0][0];
        //        MemoryStream ms = new MemoryStream();
        //        BackgroundImage = Image.FromStream(ms);
        //    }
            x = 10;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(x!=0)
            {
                label2.Text = x.ToString() + "s";
                MyDelay(1);
                x--;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                visiter form = new visiter(dtable);
                form.ShowDialog();
            }
        }
    }
}
