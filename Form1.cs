﻿namespace HETHONG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string pass = txtpass.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            if (name != "admin")
            {
                MessageBox.Show("Đăng nhập thất bại ");
                return;
            }
            else if (pass != "1234")
            {
                MessageBox.Show(" Đăng nhập thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");            
               
                FormMenu menuForm = new FormMenu();
                menuForm.Show();  // Hiển thị FormMenu
                this.Hide();
            }
            // Thêm logic để lưu thông tin vào cơ sở dữ liệu hoặc file
            MessageBox.Show("Đăng ký thành công!");
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
