namespace GUI_QuanLy
{
    partial class infobook
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
            picAnhBia = new PictureBox();
            lblTenSach = new Label();
            lblGiaBan = new Label();
            rtxtMoTa = new RichTextBox();
            btnThemGioHang = new Button();
            btnDatMua = new Button();
            label1 = new Label();
            numericSoLuong = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).BeginInit();
            SuspendLayout();
            // 
            // picAnhBia
            // 
            picAnhBia.Location = new Point(29, 32);
            picAnhBia.Name = "picAnhBia";
            picAnhBia.Size = new Size(175, 207);
            picAnhBia.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhBia.TabIndex = 0;
            picAnhBia.TabStop = false;
            picAnhBia.Click += picAnhBia_Click;
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(294, 47);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(67, 20);
            lblTenSach.TabIndex = 1;
            lblTenSach.Text = "Tên Sách";
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(294, 94);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(60, 20);
            lblGiaBan.TabIndex = 2;
            lblGiaBan.Text = "Giá Bán";
            // 
            // rtxtMoTa
            // 
            rtxtMoTa.BorderStyle = BorderStyle.None;
            rtxtMoTa.Location = new Point(12, 305);
            rtxtMoTa.Name = "rtxtMoTa";
            rtxtMoTa.ReadOnly = true;
            rtxtMoTa.Size = new Size(199, 133);
            rtxtMoTa.TabIndex = 3;
            rtxtMoTa.Text = "";
            // 
            // btnThemGioHang
            // 
            btnThemGioHang.BackColor = Color.PeachPuff;
            btnThemGioHang.Location = new Point(306, 314);
            btnThemGioHang.Name = "btnThemGioHang";
            btnThemGioHang.Size = new Size(136, 39);
            btnThemGioHang.TabIndex = 4;
            btnThemGioHang.Text = "Thêm vào Giỏ ";
            btnThemGioHang.UseVisualStyleBackColor = false;
            btnThemGioHang.Click += btnThemGioHang_Click;
            // 
            // btnDatMua
            // 
            btnDatMua.BackColor = Color.IndianRed;
            btnDatMua.Location = new Point(306, 372);
            btnDatMua.Name = "btnDatMua";
            btnDatMua.Size = new Size(136, 39);
            btnDatMua.TabIndex = 5;
            btnDatMua.Text = "Mua ngay";
            btnDatMua.UseVisualStyleBackColor = false;
            btnDatMua.Click += btnDatMua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 274);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 6;
            label1.Text = "Mô tả";
            // 
            // numericSoLuong
            // 
            numericSoLuong.Location = new Point(403, 140);
            numericSoLuong.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericSoLuong.Name = "numericSoLuong";
            numericSoLuong.Size = new Size(64, 27);
            numericSoLuong.TabIndex = 7;
            numericSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 147);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Số lượng";
            // 
            // infobook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(521, 450);
            Controls.Add(label2);
            Controls.Add(numericSoLuong);
            Controls.Add(label1);
            Controls.Add(btnDatMua);
            Controls.Add(btnThemGioHang);
            Controls.Add(rtxtMoTa);
            Controls.Add(lblGiaBan);
            Controls.Add(lblTenSach);
            Controls.Add(picAnhBia);
            Name = "infobook";
            Text = "infobook";
            Load += infobook_Load;
            ((System.ComponentModel.ISupportInitialize)picAnhBia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAnhBia;
        private Label lblTenSach;
        private Label lblGiaBan;
        private RichTextBox rtxtMoTa;
        private Button btnThemGioHang;
        private Button btnDatMua;
        private Label label1;
        private NumericUpDown numericSoLuong;
        private Label label2;
    }
}