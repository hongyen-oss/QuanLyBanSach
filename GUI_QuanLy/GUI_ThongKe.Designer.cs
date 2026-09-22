namespace GUI_QuanLy
{
    partial class GUI_ThongKe
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
            tab1 = new TabControl();
            tabPage1 = new TabPage();
            pnlChartKH = new Panel();
            dgvKhachHang = new DataGridView();
            tabPage2 = new TabPage();
            pnlChartDT = new Panel();
            dgvDoanhThu = new DataGridView();
            tabPage3 = new TabPage();
            pnlChartSach = new Panel();
            dgvSach = new DataGridView();
            label1 = new Label();
            numTopSach = new ComboBox();
            dtpTuNgay = new DateTimePicker();
            lblTuNgay = new Label();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            btnThongKe = new Button();
            label2 = new Label();
            lblTongDoanhThu = new Label();
            tab1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // tab1
            // 
            tab1.Controls.Add(tabPage1);
            tab1.Controls.Add(tabPage2);
            tab1.Controls.Add(tabPage3);
            tab1.Location = new Point(0, 115);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new Size(1206, 410);
            tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pnlChartKH);
            tabPage1.Controls.Add(dgvKhachHang);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1198, 377);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Khách hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlChartKH
            // 
            pnlChartKH.Dock = DockStyle.Fill;
            pnlChartKH.Location = new Point(522, 3);
            pnlChartKH.Name = "pnlChartKH";
            pnlChartKH.Size = new Size(673, 371);
            pnlChartKH.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = SystemColors.ControlLight;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Left;
            dgvKhachHang.Location = new Point(3, 3);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(519, 371);
            dgvKhachHang.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnlChartDT);
            tabPage2.Controls.Add(dgvDoanhThu);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1198, 377);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Doanh thu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlChartDT
            // 
            pnlChartDT.Dock = DockStyle.Fill;
            pnlChartDT.Location = new Point(616, 3);
            pnlChartDT.Name = "pnlChartDT";
            pnlChartDT.Size = new Size(579, 371);
            pnlChartDT.TabIndex = 1;
            pnlChartDT.Paint += pnlChartDT_Paint;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.BackgroundColor = SystemColors.ControlLight;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Dock = DockStyle.Left;
            dgvDoanhThu.Location = new Point(3, 3);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.Size = new Size(613, 371);
            dgvDoanhThu.TabIndex = 0;
            dgvDoanhThu.CellContentClick += dgvDoanhThu_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pnlChartSach);
            tabPage3.Controls.Add(dgvSach);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1198, 377);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sách";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // pnlChartSach
            // 
            pnlChartSach.BackColor = Color.White;
            pnlChartSach.Dock = DockStyle.Fill;
            pnlChartSach.Location = new Point(570, 3);
            pnlChartSach.Name = "pnlChartSach";
            pnlChartSach.Size = new Size(625, 371);
            pnlChartSach.TabIndex = 1;
            pnlChartSach.Paint += panel1_Paint;
            // 
            // dgvSach
            // 
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = SystemColors.ControlLight;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Dock = DockStyle.Left;
            dgvSach.Location = new Point(3, 3);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(567, 371);
            dgvSach.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(968, 92);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Top bán chạy";
            // 
            // numTopSach
            // 
            numTopSach.FormattingEnabled = true;
            numTopSach.Items.AddRange(new object[] { "Tất cả", "5", "10", "15", "20" });
            numTopSach.Location = new Point(1071, 84);
            numTopSach.Name = "numTopSach";
            numTopSach.Size = new Size(84, 28);
            numTopSach.TabIndex = 0;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(147, 32);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new Point(65, 34);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(62, 20);
            lblTuNgay.TabIndex = 2;
            lblTuNgay.Text = "Từ ngày";
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new Point(537, 34);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(72, 20);
            lblDenNgay.TabIndex = 3;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(634, 32);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 4;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Yellow;
            btnThongKe.Location = new Point(968, 25);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(112, 39);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Xem thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 87);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 6;
            label2.Text = "Tổng doanh thu";
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(437, 87);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(50, 20);
            lblTongDoanhThu.TabIndex = 7;
            lblTongDoanhThu.Text = "label3";
            // 
            // GUI_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1216, 525);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThongKe);
            Controls.Add(numTopSach);
            Controls.Add(dtpDenNgay);
            Controls.Add(lblDenNgay);
            Controls.Add(lblTuNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(tab1);
            Name = "GUI_ThongKe";
            Text = "GUI_ThongKe";
            Load += GUI_ThongKe_Load;
            tab1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tab1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DateTimePicker dtpTuNgay;
        private Label lblTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private DataGridView dgvKhachHang;
        private DataGridView dgvDoanhThu;
        private DataGridView dgvSach;
        private Panel pnlChartSach;
        private Panel pnlChartDT;
        private Panel pnlChartKH;
        private Label label1;
        private ComboBox numTopSach;
        private Label label2;
        private Label lblTongDoanhThu;
    }
}