namespace HETHONG
{
    partial class FormSach
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
            hienthisach = new DataGridView();
            bttimkiem = new Button();
            btthem = new Button();
            btsua = new Button();
            btxoa = new Button();
            txttimkiem = new TextBox();
            bthoat = new Button();
            label1 = new Label();
            txtmasach = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txttensach = new TextBox();
            txttacgia = new TextBox();
            txtgia = new TextBox();
            txtsoluong = new TextBox();
            txtmota = new RichTextBox();
            txtmaloaisach = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)hienthisach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // hienthisach
            // 
            hienthisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthisach.Location = new Point(34, 71);
            hienthisach.Name = "hienthisach";
            hienthisach.RowHeadersWidth = 51;
            hienthisach.Size = new Size(591, 394);
            hienthisach.TabIndex = 0;
            // 
            // bttimkiem
            // 
            bttimkiem.Location = new Point(877, 33);
            bttimkiem.Name = "bttimkiem";
            bttimkiem.Size = new Size(94, 29);
            bttimkiem.TabIndex = 1;
            bttimkiem.Text = "Tìm kiếm ";
            bttimkiem.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            btthem.Location = new Point(119, 41);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 2;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btsua
            // 
            btsua.Location = new Point(342, 41);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 3;
            btsua.Text = "Sửa";
            btsua.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(595, 41);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 4;
            btxoa.Text = "Xóa";
            btxoa.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(535, 35);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(302, 27);
            txttimkiem.TabIndex = 5;
            // 
            // bthoat
            // 
            bthoat.Location = new Point(841, 41);
            bthoat.Name = "bthoat";
            bthoat.Size = new Size(94, 29);
            bthoat.TabIndex = 6;
            bthoat.Text = "Thoát ";
            bthoat.UseVisualStyleBackColor = true;
            bthoat.Click += bthoat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã sách ";
            // 
            // txtmasach
            // 
            txtmasach.Location = new Point(131, 33);
            txtmasach.Name = "txtmasach";
            txtmasach.Size = new Size(198, 27);
            txtmasach.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 89);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 9;
            label2.Text = "Tên sách ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 142);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 10;
            label3.Text = "Tác giả ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 197);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 11;
            label4.Text = "Giá bán ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 258);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 12;
            label5.Text = "Số lượng tồn ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 306);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 13;
            label6.Text = "Mô tả ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 463);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 14;
            label7.Text = "Mã loại sách ";
            // 
            // txttensach
            // 
            txttensach.Location = new Point(131, 86);
            txttensach.Name = "txttensach";
            txttensach.Size = new Size(198, 27);
            txttensach.TabIndex = 15;
            // 
            // txttacgia
            // 
            txttacgia.Location = new Point(131, 142);
            txttacgia.Name = "txttacgia";
            txttacgia.Size = new Size(198, 27);
            txttacgia.TabIndex = 16;
            // 
            // txtgia
            // 
            txtgia.Location = new Point(131, 194);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(198, 27);
            txtgia.TabIndex = 17;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(131, 255);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(198, 27);
            txtsoluong.TabIndex = 18;
            // 
            // txtmota
            // 
            txtmota.Location = new Point(120, 312);
            txtmota.Name = "txtmota";
            txtmota.Size = new Size(209, 110);
            txtmota.TabIndex = 19;
            txtmota.Text = "";
            // 
            // txtmaloaisach
            // 
            txtmaloaisach.Location = new Point(131, 460);
            txtmaloaisach.Name = "txtmaloaisach";
            txtmaloaisach.Size = new Size(198, 27);
            txtmaloaisach.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 493);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hienthisach);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(382, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(653, 493);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 30);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 1;
            label8.Text = "Nhập thông tin";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btthem);
            groupBox3.Controls.Add(btsua);
            groupBox3.Controls.Add(btxoa);
            groupBox3.Controls.Add(bthoat);
            groupBox3.Location = new Point(12, 505);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1023, 76);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức Năng";
            // 
            // FormSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 593);
            Controls.Add(txtmaloaisach);
            Controls.Add(txtmota);
            Controls.Add(txtsoluong);
            Controls.Add(txtgia);
            Controls.Add(txttacgia);
            Controls.Add(txttensach);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtmasach);
            Controls.Add(label1);
            Controls.Add(txttimkiem);
            Controls.Add(bttimkiem);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "FormSach";
            Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)hienthisach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView hienthisach;
        private Button bttimkiem;
        private Button btthem;
        private Button btsua;
        private Button btxoa;
        private TextBox txttimkiem;
        private Button bthoat;
        private Label label1;
        private TextBox txtmasach;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txttensach;
        private TextBox txttacgia;
        private TextBox txtgia;
        private TextBox txtsoluong;
        private RichTextBox txtmota;
        private TextBox txtmaloaisach;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private GroupBox groupBox3;
    }
}