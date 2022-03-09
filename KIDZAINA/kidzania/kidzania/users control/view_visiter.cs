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
    public partial class view_visiter : UserControl
    {
        public view_visiter()
        {
            InitializeComponent();
        }

        private void view_visiter_Load(object sender, EventArgs e)
        {
            programing.employee em = new programing.employee();
            metroGrid1.DataSource = em.viewvisiter(int.Parse(employee.datat.Rows[0][0].ToString()));
        }
    }
}
