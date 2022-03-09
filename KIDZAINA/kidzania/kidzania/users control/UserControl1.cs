using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kidzania.users_control
{
    public partial class UserControl1 : UserControl
       
    {
        public static int ID;
        programing.sponsor sp = new programing.sponsor();
        public UserControl1()
        {
            InitializeComponent();
           
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
           
            metroGrid1.DataSource= sp.view();

        }      

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UserControl2 second = new UserControl2();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(second);
            second.Location = new Point(426, 63);


        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
         byte[] image=(byte[]) sp.viewimage(metroGrid1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "upload Advertising";
            openFileDialog1.Filter = " Images Files |  *.PNG ; *.GIF ; *.BMP; *.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                Byte[] imge = ms.ToArray();
                sp.addadv(metroGrid1.CurrentRow.Cells[0].Value.ToString(), imge);
            }

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            sp.deletesponsor(metroGrid1.CurrentRow.Cells[0].Value.ToString());
            metroGrid1.DataSource = sp.view();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            sp.addind(metroGrid1.CurrentRow.Cells[0].Value.ToString(), -1);
            sp.deleteadv(metroGrid1.CurrentRow.Cells[0].Value.ToString());
            metroGrid1.DataSource = sp.view();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {if (metroComboBox1.SelectedIndex == 0 || metroComboBox1.SelectedIndex == 1)
            {
                DataTable td = new DataTable();
                td=sp.checkindex(metroComboBox1.SelectedIndex);
                if (td.Rows.Count == 0)
                    sp.addind(metroGrid1.CurrentRow.Cells[0].Value.ToString(), metroComboBox1.SelectedIndex);
                else
                    MetroFramework.MetroMessageBox.Show(this, "this location there are ads you are sure put this ads in this location"," ads location ", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        else
              sp.addind(metroGrid1.CurrentRow.Cells[0].Value.ToString(), metroComboBox1.SelectedIndex);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = sp.view();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            edit_ads second = new edit_ads();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(second);
            second.Location = new Point(426, 63);
            ID = int.Parse(metroGrid1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
