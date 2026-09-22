namespace GUI_QuanLy
{
    partial class UC_Donhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlThongTinKH = new Panel();
            grpHinhThuc = new GroupBox();
            radTaiCuaHang = new RadioButton();
            radGiaoTanNoi = new RadioButton();
            grpThongTin = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtDiaChi = new TextBox();
            txtGhiChu = new TextBox();
            txtSDT = new TextBox();
            lblTenKH = new Label();
            pnlGiaoHang = new Panel();
            label1 = new Label();
            lblPhiShip = new Label();
            cboThanhToan = new ComboBox();
            pnlDatTruoc = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtTienCoc = new TextBox();
            dtNgayHen = new DateTimePicker();
            flowSanPham = new FlowLayoutPanel();
            lblTongCong = new Label();
            btnDatHang = new Button();
            label7 = new Label();
            lblTongThanhToan = new Label();
            label9 = new Label();
            label10 = new Label();
            cboVoucher = new ComboBox();
            lblTienGiam = new Label();
            label8 = new Label();
            pnlThongTinKH.SuspendLayout();
            grpHinhThuc.SuspendLayout();
            grpThongTin.SuspendLayout();
            pnlGiaoHang.SuspendLayout();
            pnlDatTruoc.SuspendLayout();
            SuspendLayout();
            // 
            // pnlThongTinKH
            // 
            pnlThongTinKH.Controls.Add(grpHinhThuc);
            pnlThongTinKH.Controls.Add(grpThongTin);
            pnlThongTinKH.Location = new Point(0, 3);
            pnlThongTinKH.Name = "pnlThongTinKH";
            pnlThongTinKH.Size = new Size(477, 183);
            pnlThongTinKH.TabIndex = 0;
            // 
            // grpHinhThuc
            // 
            grpHinhThuc.BackColor = Color.FromArgb(255, 224, 192);
            grpHinhThuc.Controls.Add(radTaiCuaHang);
            grpHinhThuc.Controls.Add(radGiaoTanNoi);
            grpHinhThuc.Location = new Point(276, 3);
            grpHinhThuc.Name = "grpHinhThuc";
            grpHinhThuc.Size = new Size(218, 180);
            grpHinhThuc.TabIndex = 2;
            grpHinhThuc.TabStop = false;
            grpHinhThuc.Text = "Hình thức nhận hàng";
            // 
            // radTaiCuaHang
            // 
            radTaiCuaHang.AutoSize = true;
            radTaiCuaHang.Location = new Point(31, 133);
            radTaiCuaHang.Name = "radTaiCuaHang";
            radTaiCuaHang.Size = new Size(151, 24);
            radTaiCuaHang.TabIndex = 1;
            radTaiCuaHang.TabStop = true;
            radTaiCuaHang.Text = "Nhận tại cửa hàng";
            radTaiCuaHang.UseVisualStyleBackColor = true;
            radTaiCuaHang.CheckedChanged += radTaiCuaHang_CheckedChanged;
            // 
            // radGiaoTanNoi
            // 
            radGiaoTanNoi.AutoSize = true;
            radGiaoTanNoi.Location = new Point(34, 73);
            radGiaoTanNoi.Name = "radGiaoTanNoi";
            radGiaoTanNoi.Size = new Size(148, 24);
            radGiaoTanNoi.TabIndex = 0;
            radGiaoTanNoi.TabStop = true;
            radGiaoTanNoi.Text = "Giao hàng tận nơi";
            radGiaoTanNoi.UseVisualStyleBackColor = true;
            radGiaoTanNoi.CheckedChanged += radGiaoTanNoi_CheckedChanged_1;
            // 
            // grpThongTin
            // 
            grpThongTin.BackColor = Color.FromArgb(255, 224, 192);
            grpThongTin.Controls.Add(label6);
            grpThongTin.Controls.Add(label5);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(txtGhiChu);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(lblTenKH);
            grpThongTin.Location = new Point(3, 3);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(267, 180);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin KH";
            grpThongTin.Enter += grpThongTin_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 150);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 7;
            label6.Text = "Ghi chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 71);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 5;
            label4.Text = "SDT";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(78, 107);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(183, 27);
            txtDiaChi.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(78, 147);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(183, 27);
            txtGhiChu.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(78, 68);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(183, 27);
            txtSDT.TabIndex = 1;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            lblTenKH.Location = new Point(3, 39);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(56, 20);
            lblTenKH.TabIndex = 0;
            lblTenKH.Text = "Tên KH";
            // 
            // pnlGiaoHang
            // 
            pnlGiaoHang.BackColor = Color.FromArgb(255, 224, 192);
            pnlGiaoHang.Controls.Add(label1);
            pnlGiaoHang.Controls.Add(lblPhiShip);
            pnlGiaoHang.Controls.Add(cboThanhToan);
            pnlGiaoHang.Location = new Point(500, 2);
            pnlGiaoHang.Name = "pnlGiaoHang";
            pnlGiaoHang.Size = new Size(192, 184);
            pnlGiaoHang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 43);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "Thanh toán";
            // 
            // lblPhiShip
            // 
            lblPhiShip.AutoSize = true;
            lblPhiShip.Location = new Point(13, 132);
            lblPhiShip.Name = "lblPhiShip";
            lblPhiShip.Size = new Size(106, 20);
            lblPhiShip.TabIndex = 2;
            lblPhiShip.Text = "Phí vận chuyển";
            lblPhiShip.Click += lblPhiShip_Click;
            // 
            // cboThanhToan
            // 
            cboThanhToan.FormattingEnabled = true;
            cboThanhToan.Location = new Point(13, 72);
            cboThanhToan.Name = "cboThanhToan";
            cboThanhToan.Size = new Size(160, 28);
            cboThanhToan.TabIndex = 1;
            // 
            // pnlDatTruoc
            // 
            pnlDatTruoc.BackColor = Color.FromArgb(255, 224, 192);
            pnlDatTruoc.Controls.Add(label3);
            pnlDatTruoc.Controls.Add(label2);
            pnlDatTruoc.Controls.Add(txtTienCoc);
            pnlDatTruoc.Controls.Add(dtNgayHen);
            pnlDatTruoc.Location = new Point(698, 2);
            pnlDatTruoc.Name = "pnlDatTruoc";
            pnlDatTruoc.Size = new Size(284, 184);
            pnlDatTruoc.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 12);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Ngày lấy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Tiền cọc";
            // 
            // txtTienCoc
            // 
            txtTienCoc.Location = new Point(97, 110);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.ReadOnly = true;
            txtTienCoc.Size = new Size(125, 27);
            txtTienCoc.TabIndex = 1;
            // 
            // dtNgayHen
            // 
            dtNgayHen.Location = new Point(25, 42);
            dtNgayHen.Name = "dtNgayHen";
            dtNgayHen.Size = new Size(250, 27);
            dtNgayHen.TabIndex = 0;
            // 
            // flowSanPham
            // 
            flowSanPham.AutoScroll = true;
            flowSanPham.BackColor = Color.Gainsboro;
            flowSanPham.Location = new Point(3, 200);
            flowSanPham.Name = "flowSanPham";
            flowSanPham.Size = new Size(634, 259);
            flowSanPham.TabIndex = 3;
            flowSanPham.Paint += flowSanPham_Paint;
            // 
            // lblTongCong
            // 
            lblTongCong.AutoSize = true;
            lblTongCong.Location = new Point(789, 207);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(72, 20);
            lblTongCong.TabIndex = 4;
            lblTongCong.Text = "Tổng tiền";
            // 
            // btnDatHang
            // 
            btnDatHang.Location = new Point(763, 419);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(94, 40);
            btnDatHang.TabIndex = 5;
            btnDatHang.Text = "ĐẶT HÀNG";
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(659, 266);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 7;
            label7.Text = "Giảm giá";
            // 
            // lblTongThanhToan
            // 
            lblTongThanhToan.AutoSize = true;
            lblTongThanhToan.Location = new Point(789, 378);
            lblTongThanhToan.Name = "lblTongThanhToan";
            lblTongThanhToan.Size = new Size(118, 20);
            lblTongThanhToan.TabIndex = 9;
            lblTongThanhToan.Text = "Tổng thanh toán";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(655, 378);
            label9.Name = "label9";
            label9.Size = new Size(118, 20);
            label9.TabIndex = 10;
            label9.Text = "Tổng thanh toán";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(656, 207);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 11;
            label10.Text = "Tổng tiền";
            // 
            // cboVoucher
            // 
            cboVoucher.FormattingEnabled = true;
            cboVoucher.Location = new Point(789, 263);
            cboVoucher.Name = "cboVoucher";
            cboVoucher.Size = new Size(132, 28);
            cboVoucher.TabIndex = 12;
            cboVoucher.SelectedIndexChanged += cboVoucher_SelectedIndexChanged_1;
            // 
            // lblTienGiam
            // 
            lblTienGiam.AutoSize = true;
            lblTienGiam.Location = new Point(789, 329);
            lblTienGiam.Name = "lblTienGiam";
            lblTienGiam.Size = new Size(76, 20);
            lblTienGiam.TabIndex = 13;
            lblTienGiam.Text = "Tiền Giảm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 328);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 14;
            label8.Text = "Tiền giảm";
            // 
            // UC_Donhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(label8);
            Controls.Add(lblTienGiam);
            Controls.Add(cboVoucher);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lblTongThanhToan);
            Controls.Add(label7);
            Controls.Add(btnDatHang);
            Controls.Add(lblTongCong);
            Controls.Add(flowSanPham);
            Controls.Add(pnlDatTruoc);
            Controls.Add(pnlGiaoHang);
            Controls.Add(pnlThongTinKH);
            Margin = new Padding(2);
            Name = "UC_Donhang";
            Size = new Size(1048, 464);
            Load += UC_Donhang_Load;
            SizeChanged += UC_Donhang_SizeChanged;
            pnlThongTinKH.ResumeLayout(false);
            grpHinhThuc.ResumeLayout(false);
            grpHinhThuc.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            pnlGiaoHang.ResumeLayout(false);
            pnlGiaoHang.PerformLayout();
            pnlDatTruoc.ResumeLayout(false);
            pnlDatTruoc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlThongTinKH;
        private GroupBox grpThongTin;
        private TextBox txtDiaChi;
        private TextBox txtGhiChu;
        private TextBox txtSDT;
        private Label lblTenKH;
        private GroupBox grpHinhThuc;
        private RadioButton radTaiCuaHang;
        private RadioButton radGiaoTanNoi;
        private Panel pnlGiaoHang;
        private Label lblPhiShip;
        private ComboBox cboThanhToan;
        private Label label1;
        private Panel pnlDatTruoc;
        private TextBox txtTienCoc;
        private DateTimePicker dtNgayHen;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowSanPham;
        private Label lblTongCong;
        private Button btnDatHang;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private ComboBox comboBox1;
        private Label lblTongThanhToan;
        private Label label9;
        private Label label10;
        private ComboBox cboVoucher;
        private Label lblTienGiam;
        private Label label8;
    }
}
