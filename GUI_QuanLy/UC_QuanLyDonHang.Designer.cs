namespace GUI_QuanLy
{
    partial class UC_QuanLyDonHang
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
            tabDonHang = new TabControl();
            tabPage1 = new TabPage();
            btnHoanThanh = new Button();
            btnDangGiao = new Button();
            btnXacNhan = new Button();
            dgvDonHang = new DataGridView();
            tabHuy = new TabPage();
            btnHuy = new Button();
            dgvHuy = new DataGridView();
            tabDonHang.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            tabHuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHuy).BeginInit();
            SuspendLayout();
            // 
            // tabDonHang
            // 
            tabDonHang.Controls.Add(tabPage1);
            tabDonHang.Controls.Add(tabHuy);
            tabDonHang.Location = new Point(0, 3);
            tabDonHang.Name = "tabDonHang";
            tabDonHang.SelectedIndex = 0;
            tabDonHang.Size = new Size(1197, 432);
            tabDonHang.TabIndex = 0;
            tabDonHang.SelectedIndexChanged += tabDonHang_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 224, 192);
            tabPage1.Controls.Add(btnHoanThanh);
            tabPage1.Controls.Add(btnDangGiao);
            tabPage1.Controls.Add(btnXacNhan);
            tabPage1.Controls.Add(dgvDonHang);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1189, 399);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đơn hàng";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnHoanThanh
            // 
            btnHoanThanh.Location = new Point(915, 316);
            btnHoanThanh.Name = "btnHoanThanh";
            btnHoanThanh.Size = new Size(94, 40);
            btnHoanThanh.TabIndex = 7;
            btnHoanThanh.Text = "Hoàn thành";
            btnHoanThanh.UseVisualStyleBackColor = true;
            btnHoanThanh.Click += btnHoanThanh_Click_1;
            // 
            // btnDangGiao
            // 
            btnDangGiao.Location = new Point(708, 316);
            btnDangGiao.Name = "btnDangGiao";
            btnDangGiao.Size = new Size(94, 40);
            btnDangGiao.TabIndex = 6;
            btnDangGiao.Text = "Đang Giao";
            btnDangGiao.UseVisualStyleBackColor = true;
            btnDangGiao.Click += btnDangGiao_Click_1;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(500, 316);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 40);
            btnXacNhan.TabIndex = 5;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click_1;
            // 
            // dgvDonHang
            // 
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.BackgroundColor = SystemColors.ControlLight;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(6, 8);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.Size = new Size(1177, 261);
            dgvDonHang.TabIndex = 4;
            dgvDonHang.CellContentClick += dgvDonHang_CellContentClick;
            // 
            // tabHuy
            // 
            tabHuy.BackColor = SystemColors.GradientInactiveCaption;
            tabHuy.Controls.Add(btnHuy);
            tabHuy.Controls.Add(dgvHuy);
            tabHuy.ForeColor = Color.Black;
            tabHuy.Location = new Point(4, 29);
            tabHuy.Name = "tabHuy";
            tabHuy.Padding = new Padding(3);
            tabHuy.Size = new Size(1189, 399);
            tabHuy.TabIndex = 1;
            tabHuy.Text = "Yêu cầu hủy";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Yellow;
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(542, 322);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 46);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Xác nhận";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // dgvHuy
            // 
            dgvHuy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHuy.BackgroundColor = SystemColors.ControlLight;
            dgvHuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHuy.Location = new Point(0, 6);
            dgvHuy.Name = "dgvHuy";
            dgvHuy.RowHeadersWidth = 51;
            dgvHuy.Size = new Size(1190, 266);
            dgvHuy.TabIndex = 5;
            // 
            // UC_QuanLyDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabDonHang);
            Name = "UC_QuanLyDonHang";
            Size = new Size(1197, 435);
            Load += UC_QuanLyDonHang_Load;
            tabDonHang.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            tabHuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHuy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabDonHang;
        private TabPage tabPage1;
        private Button btnHoanThanh;
        private Button btnDangGiao;
        private Button btnXacNhan;
        private DataGridView dgvDonHang;
        private TabPage tabHuy;
        private DataGridView dgvHuy;
        private Button btnHuy;
    }
}
