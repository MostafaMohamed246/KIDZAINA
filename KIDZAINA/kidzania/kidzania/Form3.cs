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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        SqlConnection userr = new SqlConnection(@"server=(local);Database=kidzania;integrated security=true");
        SqlDataAdapter daa;
        DataTable dtt = new DataTable();
        SqlCommandBuilder inser_dele_upda;
        public Form3()
        {
            InitializeComponent();
          
            daa = new SqlDataAdapter("select * from visiter", userr);
            daa.Fill(dtt);
            metroGrid1.DataSource = dtt;
        }
            private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            inser_dele_upda = new SqlCommandBuilder(daa);
            daa.Update(dtt);
            MessageBox.Show("Passed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
