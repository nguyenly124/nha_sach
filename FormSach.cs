using NhaSach; // Đảm bảo bạn đã thêm thư viện NhaSach đúng
using System;
using System.Data;
using System.Windows.Forms;

namespace HETHONG
{
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
        }

        Ketnoidb kn = new Ketnoidb();

        private void btthem_Click(object sender, EventArgs e)
        {
            // Thêm mã xử lý cho button "Thêm"
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            try
            {
                string query = "select * from sach";
                DataSet ds = kn.LayDuLieu(query);

                if (ds != null && ds.Tables.Count > 0)
                {
                    hienthisach.DataSource = ds.Tables[0]; // Gán dữ liệu vào DataGridView
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của label2
        }

        private void bthoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form khi click nút "Thoát"
        }

        
    }
}
