namespace HETHONG
{
    partial class FormLoaiSach
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtmaloai = new TextBox();
            txttenloai = new TextBox();
            txtmotaloai = new RichTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            hienthiloaisach = new DataGridView();
            groupBox3 = new GroupBox();
            btthoat = new Button();
            btxoa = new Button();
            btsua = new Button();
            btthem = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienthiloaisach).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 59);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã loại sách ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 126);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên loại sách ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 186);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Mô tả ";
            // 
            // txtmaloai
            // 
            txtmaloai.Location = new Point(169, 52);
            txtmaloai.Name = "txtmaloai";
            txtmaloai.Size = new Size(197, 27);
            txtmaloai.TabIndex = 3;
            // 
            // txttenloai
            // 
            txttenloai.Location = new Point(169, 119);
            txttenloai.Name = "txttenloai";
            txttenloai.Size = new Size(197, 27);
            txttenloai.TabIndex = 4;
            // 
            // txtmotaloai
            // 
            txtmotaloai.Location = new Point(169, 197);
            txtmotaloai.Name = "txtmotaloai";
            txtmotaloai.Size = new Size(197, 120);
            txtmotaloai.TabIndex = 5;
            txtmotaloai.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(29, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 346);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hienthiloaisach);
            groupBox2.Location = new Point(404, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 347);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu ";
            // 
            // hienthiloaisach
            // 
            hienthiloaisach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthiloaisach.Location = new Point(17, 26);
            hienthiloaisach.Name = "hienthiloaisach";
            hienthiloaisach.RowHeadersWidth = 51;
            hienthiloaisach.Size = new Size(351, 315);
            hienthiloaisach.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btthoat);
            groupBox3.Controls.Add(btxoa);
            groupBox3.Controls.Add(btsua);
            groupBox3.Controls.Add(btthem);
            groupBox3.Location = new Point(29, 377);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(749, 61);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btthoat
            // 
            btthoat.Location = new Point(635, 26);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 3;
            btthoat.Text = "Thoát ";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(472, 26);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(94, 29);
            btxoa.TabIndex = 2;
            btxoa.Text = "Xóa ";
            btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            btsua.Location = new Point(296, 26);
            btsua.Name = "btsua";
            btsua.Size = new Size(94, 29);
            btsua.TabIndex = 1;
            btsua.Text = "Sửa ";
            btsua.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            btthem.Location = new Point(140, 26);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 0;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            // 
            // FormLoaiSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(txtmotaloai);
            Controls.Add(txttenloai);
            Controls.Add(txtmaloai);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormLoaiSach";
            Text = "FormLoaiSach";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hienthiloaisach).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtmaloai;
        private TextBox txttenloai;
        private RichTextBox txtmotaloai;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView hienthiloaisach;
        private GroupBox groupBox3;
        private Button btthoat;
        private Button btxoa;
        private Button btsua;
        private Button btthem;
    }
}