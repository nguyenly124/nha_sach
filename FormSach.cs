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
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void btthem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            string query = "select * from sach";
            DataSet ds = kn.LayDuLieu(query);
            hienthisach.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
