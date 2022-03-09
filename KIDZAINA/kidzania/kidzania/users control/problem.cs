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
    public partial class problem : UserControl
    {
        DataTable dt = new DataTable();
       programing.employee em = new programing.employee();
        public problem()
        {
            InitializeComponent();
            dt = employee.datat;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            metroGrid1.Visible = true;
            label3.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            metroGrid1.DataSource = em.viewp(int.Parse(employee.datat.Rows[0][0].ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            programing.employee em = new programing.employee();
            em.addquestion(employee.datat.Rows[0][0].ToString(), textBox1.Text);
            textBox1.Clear();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
