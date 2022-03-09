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

namespace kidzania
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        SqlConnection gam = new SqlConnection(@"server=(local);Database=kidzania;integrated security=true");
        SqlDataAdapter daaaa;
        DataTable dtttt = new DataTable();
        SqlCommandBuilder insert_delet_updat;
        public Form4()
        {
            InitializeComponent();
            daaaa = new SqlDataAdapter("select * from game", gam);
            daaaa.Fill(dtttt);
            metroGrid1.DataSource = dtttt;
        }
            private void metroButton2_Click(object sender, EventArgs e)
        {
            insert_delet_updat = new SqlCommandBuilder(daaaa);
            daaaa.Update(dtttt);
            MessageBox.Show("Passed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
