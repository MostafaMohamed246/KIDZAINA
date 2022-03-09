using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace kidzania.users_control
{
    public partial class vister_ad : UserControl
    {
        SqlConnection userr = new SqlConnection(@"server=(local)\SQLEXPRESS;Database=kidzania;integrated security=true");
        SqlDataAdapter daa;
        DataTable dtt = new DataTable();
        SqlCommandBuilder inser_dele_upda;
        public vister_ad()
        {
            InitializeComponent();
            daa = new SqlDataAdapter("select * from visiter", userr);
            daa.Fill(dtt);
           metroGrid1.DataSource = dtt;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inser_dele_upda = new SqlCommandBuilder(daa);
            daa.Update(dtt);
            MessageBox.Show("Passed Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
