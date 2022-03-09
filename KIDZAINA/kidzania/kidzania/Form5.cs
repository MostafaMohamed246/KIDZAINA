using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace kidzania
{
   
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
         SqlConnection Feedback = new SqlConnection(@"Server=(local);DataBase=kidzania;Integrated Security=true;");
        SqlCommand cmd;
        int id;
        public Form5(DataTable da)
        {
            InitializeComponent();
          id=int.Parse(da.Rows[0][7].ToString());
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("Insert into rank( Vister_ID,Game_Id,Rate,feedback,Question) values(" + id + " , " + g_id.Text + " , " + r.Text + " , '" + f.Text + "' , '" + q.Text + "')", Feedback);
            Feedback.Open();
            cmd.ExecuteNonQuery();
            Feedback.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
