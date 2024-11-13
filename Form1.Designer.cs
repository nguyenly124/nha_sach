namespace HETHONG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtname = new TextBox();
            txtpass = new TextBox();
            btdangnhap = new Button();
            btthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 44);
            label1.Name = "label1";
            label1.Size = new Size(174, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 115);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu ";
            // 
            // txtname
            // 
            txtname.Location = new Point(207, 113);
            txtname.Name = "txtname";
            txtname.Size = new Size(254, 27);
            txtname.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(207, 182);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(254, 27);
            txtpass.TabIndex = 4;
            // 
            // btdangnhap
            // 
            btdangnhap.Location = new Point(207, 251);
            btdangnhap.Name = "btdangnhap";
            btdangnhap.Size = new Size(94, 29);
            btdangnhap.TabIndex = 5;
            btdangnhap.Text = "Đăng nhập";
            btdangnhap.UseVisualStyleBackColor = true;
            btdangnhap.Click += btdangnhap_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(370, 250);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 6;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 362);
            Controls.Add(btthoat);
            Controls.Add(btdangnhap);
            Controls.Add(txtpass);
            Controls.Add(txtname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtname;
        private TextBox txtpass;
        private Button btdangnhap;
        private Button btthoat;
    }
}
