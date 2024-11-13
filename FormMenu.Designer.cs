namespace HETHONG
{
    partial class FormMenu
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
            btloaisach = new Button();
            btsach = new Button();
            bthoadon = new Button();
            btbaocao = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btloaisach
            // 
            btloaisach.Location = new Point(73, 106);
            btloaisach.Name = "btloaisach";
            btloaisach.Size = new Size(141, 42);
            btloaisach.TabIndex = 0;
            btloaisach.Text = "Loại Sách ";
            btloaisach.UseVisualStyleBackColor = true;
            btloaisach.Click += btloaisach_Click;
            // 
            // btsach
            // 
            btsach.Location = new Point(73, 178);
            btsach.Name = "btsach";
            btsach.Size = new Size(141, 42);
            btsach.TabIndex = 1;
            btsach.Text = "Sách ";
            btsach.UseVisualStyleBackColor = true;
            btsach.Click += button2_Click;
            // 
            // bthoadon
            // 
            bthoadon.Location = new Point(73, 243);
            bthoadon.Name = "bthoadon";
            bthoadon.Size = new Size(141, 42);
            bthoadon.TabIndex = 2;
            bthoadon.Text = "Hóa Đơn";
            bthoadon.UseVisualStyleBackColor = true;
            bthoadon.Click += bthoadon_Click;
            // 
            // btbaocao
            // 
            btbaocao.Location = new Point(73, 311);
            btbaocao.Name = "btbaocao";
            btbaocao.Size = new Size(141, 42);
            btbaocao.TabIndex = 3;
            btbaocao.Text = "Báo cáo ";
            btbaocao.UseVisualStyleBackColor = true;
            btbaocao.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 25);
            label1.Name = "label1";
            label1.Size = new Size(320, 41);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ NHÀ SÁCH ";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btbaocao);
            Controls.Add(bthoadon);
            Controls.Add(btsach);
            Controls.Add(btloaisach);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btloaisach;
        private Button btsach;
        private Button bthoadon;
        private Button btbaocao;
        private Label label1;
    }
}