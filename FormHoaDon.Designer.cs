namespace HETHONG
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txttenkh = new TextBox();
            txtngay = new TextBox();
            txtmahd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            bttimkiem = new Button();
            txttimkiem = new TextBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btthoat = new Button();
            btxoa = new Button();
            btsua = new Button();
            btthem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txttenkh);
            groupBox1.Controls.Add(txtngay);
            groupBox1.Controls.Add(txtmahd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 414);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(16, 257);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(244, 27);
            txttenkh.TabIndex = 5;
            // 
            // txtngay
            // 
            txtngay.Location = new Point(16, 164);
            txtngay.Name = "txtngay";
            txtngay.Size = new Size(244, 27);
            txtngay.TabIndex = 4;
            // 
            // txtmahd
            // 
            txtmahd.Location = new Point(16, 83);
            txtmahd.Name = "txtmahd";
            txtmahd.Size = new Size(244, 27);
            txtmahd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 234);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 141);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày lập ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 60);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(bttimkiem);
            groupBox2.Controls.Add(txttimkiem);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(351, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 412);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(473, 314);
            dataGridView1.TabIndex = 3;
            // 
            // bttimkiem
            // 
            bttimkiem.Location = new Point(397, 36);
            bttimkiem.Name = "bttimkiem";
            bttimkiem.Size = new Size(94, 29);
            bttimkiem.TabIndex = 2;
            bttimkiem.Text = "Tìm kiếm ";
            bttimkiem.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(176, 38);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(183, 27);
            txttimkiem.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 45);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 0;
            label4.Text = "Nhập thông tin ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btthoat);
            groupBox3.Controls.Add(btxoa);
            groupBox3.Controls.Add(btsua);
            groupBox3.Controls.Add(btthem);
            groupBox3.Location = new Point(17, 439);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(863, 76);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btthoat
            // 
            btthoat.Location = new Point(647, 38);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 3;
            btthoat.Text = "Thoát ";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(455, 38);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 2;
            btxoa.Text = "Xóa ";
            btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            btsua.Location = new Point(276, 38);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 1;
            btsua.Text = "Sửa ";
            btsua.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            btthem.Location = new Point(83, 38);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 0;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 527);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txttenkh;
        private TextBox txtngay;
        private TextBox txtmahd;
        private Button btthoat;
        private Button btxoa;
        private Button btsua;
        private Button btthem;
        private Label label4;
        private DataGridView dataGridView1;
        private Button bttimkiem;
        private TextBox txttimkiem;
    }
}