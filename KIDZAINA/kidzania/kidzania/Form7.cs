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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            programing.employee em = new programing.employee();
            metroGrid1.DataSource = em.viewvisiter(int.Parse(employee.datat.Rows[0][0].ToString()));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
