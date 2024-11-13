using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HETHONG
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSach frmsach = new FormSach();
            frmsach.Show();
            //this.Hide();
        }

        private void btloaisach_Click(object sender, EventArgs e)
        {
            FormLoaiSach frmloaisach = new FormLoaiSach();
            frmloaisach.Show();
            //this.Hide();
        }

        private void bthoadon_Click(object sender, EventArgs e)
        {
            FormHoaDon frmhoadon = new FormHoaDon();
            frmhoadon.Show();
            //this.Hide();
        }
    }
}
