namespace GUI_QuanLy
{
    partial class GUI_Sach
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
            dgvSach = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpNgayNhap = new DateTimePicker();
            btnXem = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            txtTacGia = new TextBox();
            txtGiaBan = new TextBox();
            txtSoLuongTon = new TextBox();
            txtTrangThai = new TextBox();
            picSach = new PictureBox();
            label9 = new Label();
            btnCHonAnh = new Button();
            label10 = new Label();
            txtMoTa = new RichTextBox();
            cboMaTheLoai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSach).BeginInit();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(26, 12);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(1196, 259);
            dgvSach.TabIndex = 0;
            dgvSach.CellContentClick += dgvSach_CellContentClick;
            dgvSach.Click += dgvSach_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 290);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sách";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 347);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 399);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Tác giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(661, 283);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Mã thể loại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 333);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Giá bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(661, 390);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 6;
            label6.Text = "Ngày nhập kho";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(661, 442);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 7;
            label7.Text = "Số lượng tồn kho";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(661, 493);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 8;
            label8.Text = "Trạng thái";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.Location = new Point(802, 383);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(250, 27);
            dtpNgayNhap.TabIndex = 9;
            dtpNgayNhap.ValueChanged += dtpNgayNhap_ValueChanged;
            // 
            // btnXem
            // 
            btnXem.BackColor = SystemColors.MenuHighlight;
            btnXem.Location = new Point(1075, 303);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(94, 29);
            btnXem.TabIndex = 10;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click_1;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.Location = new Point(1075, 358);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Goldenrod;
            btnSua.Location = new Point(1075, 414);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.Location = new Point(1075, 474);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // txtMaSach
            // 
            txtMaSach.Enabled = false;
            txtMaSach.Location = new Point(128, 283);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(215, 27);
            txtMaSach.TabIndex = 15;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(128, 338);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(215, 27);
            txtTenSach.TabIndex = 16;
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(128, 392);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(215, 27);
            txtTacGia.TabIndex = 17;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(802, 330);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(250, 27);
            txtGiaBan.TabIndex = 19;
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.Location = new Point(802, 435);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.Size = new Size(250, 27);
            txtSoLuongTon.TabIndex = 20;
            txtSoLuongTon.TextChanged += txtSoLuongTon_TextChanged;
            txtSoLuongTon.KeyPress += txtSoLuongTon_KeyPress;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(802, 486);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(250, 27);
            txtTrangThai.TabIndex = 21;
            txtTrangThai.TextChanged += txtTrangThai_TextChanged;
            // 
            // picSach
            // 
            picSach.Location = new Point(478, 303);
            picSach.Name = "picSach";
            picSach.Size = new Size(144, 152);
            picSach.SizeMode = PictureBoxSizeMode.StretchImage;
            picSach.TabIndex = 23;
            picSach.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(388, 360);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 24;
            label9.Text = "Hình ảnh";
            // 
            // btnCHonAnh
            // 
            btnCHonAnh.BackColor = Color.Yellow;
            btnCHonAnh.Location = new Point(502, 474);
            btnCHonAnh.Name = "btnCHonAnh";
            btnCHonAnh.Size = new Size(94, 29);
            btnCHonAnh.TabIndex = 26;
            btnCHonAnh.Text = "Tải ảnh lên";
            btnCHonAnh.UseVisualStyleBackColor = false;
            btnCHonAnh.Click += btnCHonAnh_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 474);
            label10.Name = "label10";
            label10.Size = new Size(48, 20);
            label10.TabIndex = 27;
            label10.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(128, 435);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(215, 87);
            txtMoTa.TabIndex = 28;
            txtMoTa.Text = "";
            // 
            // cboMaTheLoai
            // 
            cboMaTheLoai.FormattingEnabled = true;
            cboMaTheLoai.Location = new Point(802, 282);
            cboMaTheLoai.Name = "cboMaTheLoai";
            cboMaTheLoai.Size = new Size(250, 28);
            cboMaTheLoai.TabIndex = 29;
            cboMaTheLoai.SelectedIndexChanged += cboMaTheLoai_SelectedIndexChanged;
            // 
            // GUI_Sach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1219, 534);
            Controls.Add(cboMaTheLoai);
            Controls.Add(txtMoTa);
            Controls.Add(label10);
            Controls.Add(btnCHonAnh);
            Controls.Add(label9);
            Controls.Add(picSach);
            Controls.Add(txtTrangThai);
            Controls.Add(txtSoLuongTon);
            Controls.Add(txtGiaBan);
            Controls.Add(txtTacGia);
            Controls.Add(txtTenSach);
            Controls.Add(txtMaSach);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnXem);
            Controls.Add(dtpNgayNhap);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSach);
            Name = "GUI_Sach";
            Text = "QuanLySach";
            Load += GUI_Sach_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpNgayNhap;
        private Button btnXem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMaSach;
        private TextBox txtTenSach;
        private TextBox txtTacGia;
        private TextBox txtGiaBan;
        private TextBox txtSoLuongTon;
        private TextBox txtTrangThai;
        private PictureBox picSach;
        private Label label9;
        private Button btnCHonAnh;
        private Label label10;
        private RichTextBox txtMoTa;
        private ComboBox cboMaTheLoai;
    }
}
