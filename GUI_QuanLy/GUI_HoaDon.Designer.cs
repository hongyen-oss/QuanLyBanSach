namespace GUI_QuanLy
{
    partial class GUI_HoaDon
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            picQR = new PictureBox();
            cboVoucher = new ComboBox();
            label12 = new Label();
            lblTienGiam = new Label();
            label13 = new Label();
            lblTongThanhToan = new Label();
            label14 = new Label();
            btnLuu = new Button();
            btnThemMoi = new Button();
            label11 = new Label();
            txtTongTien = new TextBox();
            dgvChiTiet = new DataGridView();
            panel3 = new Panel();
            dtpNgayLap = new DateTimePicker();
            cboThanhToan = new ComboBox();
            txtMaHD = new TextBox();
            txtMaNV = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            btnThem = new Button();
            txtDonGia = new TextBox();
            txtGiaBan = new TextBox();
            txtSoLuong = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txtTenKH = new TextBox();
            txtSDT = new TextBox();
            label2 = new Label();
            laybel1 = new Label();
            tabPage2 = new TabPage();
            dgvHoaDon = new DataGridView();
            btnXem = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1275, 541);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged_1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientActiveCaption;
            tabPage1.Controls.Add(picQR);
            tabPage1.Controls.Add(cboVoucher);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(lblTienGiam);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(lblTongThanhToan);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(btnLuu);
            tabPage1.Controls.Add(btnThemMoi);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(txtTongTien);
            tabPage1.Controls.Add(dgvChiTiet);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1267, 508);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tạo hóa đơn";
            tabPage1.Click += tabPage1_Click;
            // 
            // picQR
            // 
            picQR.Location = new Point(885, 6);
            picQR.Name = "picQR";
            picQR.Size = new Size(256, 230);
            picQR.SizeMode = PictureBoxSizeMode.StretchImage;
            picQR.TabIndex = 22;
            picQR.TabStop = false;
            // 
            // cboVoucher
            // 
            cboVoucher.FormattingEnabled = true;
            cboVoucher.Location = new Point(1008, 297);
            cboVoucher.Name = "cboVoucher";
            cboVoucher.Size = new Size(151, 28);
            cboVoucher.TabIndex = 21;
            cboVoucher.SelectedIndexChanged += cboVoucher_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(885, 348);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 20;
            label12.Text = "Tiền giảm";
            label12.Click += label12_Click;
            // 
            // lblTienGiam
            // 
            lblTienGiam.AutoSize = true;
            lblTienGiam.Location = new Point(1023, 348);
            lblTienGiam.Name = "lblTienGiam";
            lblTienGiam.Size = new Size(76, 20);
            lblTienGiam.TabIndex = 19;
            lblTienGiam.Text = "Tiền Giảm";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(885, 386);
            label13.Name = "label13";
            label13.Size = new Size(118, 20);
            label13.TabIndex = 17;
            label13.Text = "Tổng thanh toán";
            // 
            // lblTongThanhToan
            // 
            lblTongThanhToan.AutoSize = true;
            lblTongThanhToan.Location = new Point(1023, 386);
            lblTongThanhToan.Name = "lblTongThanhToan";
            lblTongThanhToan.Size = new Size(118, 20);
            lblTongThanhToan.TabIndex = 16;
            lblTongThanhToan.Text = "Tổng thanh toán";
            lblTongThanhToan.TextChanged += lblTongThanhToan_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(885, 306);
            label14.Name = "label14";
            label14.Size = new Size(69, 20);
            label14.TabIndex = 15;
            label14.Text = "Giảm giá";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(255, 255, 128);
            btnLuu.Location = new Point(1036, 428);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 53);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "LƯU";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(128, 255, 128);
            btnThemMoi.Location = new Point(885, 429);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 54);
            btnThemMoi.TabIndex = 12;
            btnThemMoi.Text = "THÊM MỚI";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(885, 259);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 8;
            label11.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(1008, 256);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(151, 27);
            txtTongTien.TabIndex = 4;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(9, 6);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(847, 202);
            dgvChiTiet.TabIndex = 3;
            dgvChiTiet.CellContentClick += dgvChiTiet_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Info;
            panel3.Controls.Add(dtpNgayLap);
            panel3.Controls.Add(cboThanhToan);
            panel3.Controls.Add(txtMaHD);
            panel3.Controls.Add(txtMaNV);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(489, 218);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 272);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Location = new Point(107, 125);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(250, 27);
            dtpNgayLap.TabIndex = 13;
            // 
            // cboThanhToan
            // 
            cboThanhToan.FormattingEnabled = true;
            cboThanhToan.Location = new Point(107, 181);
            cboThanhToan.Name = "cboThanhToan";
            cboThanhToan.Size = new Size(182, 28);
            cboThanhToan.TabIndex = 12;
            cboThanhToan.SelectedIndexChanged += cboThanhToan_SelectedIndexChanged;
            // 
            // txtMaHD
            // 
            txtMaHD.Enabled = false;
            txtMaHD.Location = new Point(107, 74);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.ReadOnly = true;
            txtMaHD.Size = new Size(182, 27);
            txtMaHD.TabIndex = 11;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(107, 19);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(182, 27);
            txtMaNV.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 189);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 9;
            label10.Text = "Thanh toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 130);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày lập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 77);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 7;
            label8.Text = "Mã HD";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 22);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 8;
            label9.Text = "Mã NV";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(txtDonGia);
            panel2.Controls.Add(txtGiaBan);
            panel2.Controls.Add(txtSoLuong);
            panel2.Controls.Add(txtTenSach);
            panel2.Controls.Add(txtMaSach);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(186, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 272);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.Location = new Point(191, 225);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 37);
            btnThem.TabIndex = 11;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Enabled = false;
            txtDonGia.Location = new Point(111, 181);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(174, 27);
            txtDonGia.TabIndex = 10;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Enabled = false;
            txtGiaBan.Location = new Point(111, 136);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.ReadOnly = true;
            txtGiaBan.Size = new Size(174, 27);
            txtGiaBan.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(111, 93);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(174, 27);
            txtSoLuong.TabIndex = 8;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtTenSach
            // 
            txtTenSach.Enabled = false;
            txtTenSach.Location = new Point(111, 55);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.ReadOnly = true;
            txtTenSach.Size = new Size(174, 27);
            txtTenSach.TabIndex = 7;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(111, 15);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(174, 27);
            txtMaSach.TabIndex = 6;
            txtMaSach.KeyDown += txtMaSach_KeyDown;
            txtMaSach.Leave += txtMaSach_Leave_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 144);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Giá Bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 188);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 100);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 22);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã Sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 62);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Sách";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(laybel1);
            panel1.Location = new Point(9, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 272);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(7, 120);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(148, 27);
            txtTenKH.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(7, 45);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(148, 27);
            txtSDT.TabIndex = 2;
            txtSDT.TextChanged += txtSDT_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 92);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách Hàng";
            // 
            // laybel1
            // 
            laybel1.AutoSize = true;
            laybel1.Location = new Point(7, 12);
            laybel1.Name = "laybel1";
            laybel1.Size = new Size(35, 20);
            laybel1.TabIndex = 0;
            laybel1.Text = "SDT";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Bisque;
            tabPage2.Controls.Add(dgvHoaDon);
            tabPage2.Controls.Add(btnXem);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1267, 508);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Xem hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = SystemColors.ControlLight;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(8, 25);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(1224, 367);
            dgvHoaDon.TabIndex = 1;
            dgvHoaDon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.Goldenrod;
            btnXem.Location = new Point(600, 415);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(94, 47);
            btnXem.TabIndex = 0;
            btnXem.Text = "XEM";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // GUI_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 552);
            Controls.Add(tabControl1);
            Name = "GUI_HoaDon";
            Text = "GUI_HoaDon";
            Load += GUI_HoaDon_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvChiTiet;
        private Panel panel3;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label laybel1;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtSoLuong;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private TextBox txtTenKH;
        private TextBox txtSDT;
        private Button btnLuu;
        private Button btnThemMoi;
        private Label label11;
        private TextBox txtTongTien;
        private TextBox txtMaHD;
        private TextBox txtMaNV;
        private Button btnThem;
        private TextBox txtDonGia;
        private TextBox txtGiaBan;
        private DateTimePicker dtpNgayLap;
        private ComboBox cboThanhToan;
        private Button btnXem;
        private DataGridView dgvHoaDon;
        private Label label12;
        private Label lblTienGiam;
        private Label label13;
        private Label lblTongThanhToan;
        private Label label14;
        private ComboBox cboVoucher;
        private PictureBox picQR;
    }
}