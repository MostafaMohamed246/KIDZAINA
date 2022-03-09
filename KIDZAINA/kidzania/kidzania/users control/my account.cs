using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kidzania.users_control
{
    public partial class my_account : UserControl
    {
        programing.sponsor sp = new programing.sponsor();
        DataTable dt = new DataTable();
        public my_account()
        {
            InitializeComponent();
            textBox1.Text = sp.viewadmin().Rows[0][1].ToString();
            textBox2.Text = sp.viewadmin().Rows[0][2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)&&!string.IsNullOrEmpty(textBox2.Text))
            {
                sp.Editadmin(textBox1.Text, textBox2.Text);
                MetroFramework.MetroMessageBox.Show(this, "done !");
             }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void my_account_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
