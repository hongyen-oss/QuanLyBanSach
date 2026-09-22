namespace GUI_QuanLy
{
    partial class KhachHang
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
            dgvKH = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtTichLuy = new Label();
            txtGmail = new TextBox();
            chkVoucher = new CheckBox();
            txtTich_Luy = new TextBox();
            label1 = new Label();
            txtMaKH = new TextBox();
            btnLamMoi = new Button();
            label6 = new Label();
            cboDiaChi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            SuspendLayout();
            // 
            // dgvKH
            // 
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Location = new Point(303, 11);
            dgvKH.Name = "dgvKH";
            dgvKH.RowHeadersWidth = 51;
            dgvKH.Size = new Size(938, 347);
            dgvKH.TabIndex = 0;
            dgvKH.CellClick += dgvKH_CellClick;
            dgvKH.CellContentClick += dgvKH_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 255);
            button1.Location = new Point(28, 387);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 1;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Location = new Point(133, 387);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 2;
            button2.Text = "Thêm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(241, 387);
            button3.Name = "button3";
            button3.Size = new Size(94, 41);
            button3.TabIndex = 3;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 78);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 186);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 7;
            label3.Text = "Gmail";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 130);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 8;
            label4.Text = "SDT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 335);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 9;
            label5.Text = "Voucher";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(84, 123);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(198, 27);
            txtSDT.TabIndex = 12;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(84, 71);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(198, 27);
            txtHoTen.TabIndex = 13;
            // 
            // txtTichLuy
            // 
            txtTichLuy.AutoSize = true;
            txtTichLuy.Location = new Point(16, 285);
            txtTichLuy.Name = "txtTichLuy";
            txtTichLuy.Size = new Size(59, 20);
            txtTichLuy.TabIndex = 16;
            txtTichLuy.Text = "Tích lũy";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(84, 178);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(198, 27);
            txtGmail.TabIndex = 17;
            // 
            // chkVoucher
            // 
            chkVoucher.AutoSize = true;
            chkVoucher.Location = new Point(84, 334);
            chkVoucher.Name = "chkVoucher";
            chkVoucher.Size = new Size(84, 24);
            chkVoucher.TabIndex = 18;
            chkVoucher.Text = "Voucher";
            chkVoucher.UseVisualStyleBackColor = true;
            // 
            // txtTich_Luy
            // 
            txtTich_Luy.Location = new Point(84, 278);
            txtTich_Luy.Name = "txtTich_Luy";
            txtTich_Luy.ReadOnly = true;
            txtTich_Luy.Size = new Size(198, 27);
            txtTich_Luy.TabIndex = 11;
            txtTich_Luy.TextChanged += txtGmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            txtMaKH.BackColor = SystemColors.ControlLight;
            txtMaKH.Enabled = false;
            txtMaKH.Location = new Point(84, 15);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(198, 27);
            txtMaKH.TabIndex = 14;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Yellow;
            btnLamMoi.Location = new Point(377, 387);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 41);
            btnLamMoi.TabIndex = 19;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 234);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 20;
            label6.Text = "Địa chỉ";
            // 
            // cboDiaChi
            // 
            cboDiaChi.FormattingEnabled = true;
            cboDiaChi.Location = new Point(84, 226);
            cboDiaChi.Name = "cboDiaChi";
            cboDiaChi.Size = new Size(198, 28);
            cboDiaChi.TabIndex = 21;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1253, 450);
            Controls.Add(cboDiaChi);
            Controls.Add(label6);
            Controls.Add(btnLamMoi);
            Controls.Add(chkVoucher);
            Controls.Add(txtGmail);
            Controls.Add(txtTichLuy);
            Controls.Add(txtMaKH);
            Controls.Add(txtHoTen);
            Controls.Add(txtSDT);
            Controls.Add(txtTich_Luy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvKH);
            Name = "KhachHang";
            Text = "KhachHang";
            Load += KhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKH;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private Label txtTichLuy;
        private TextBox txtGmail;
        private CheckBox chkVoucher;
        private TextBox txtTich_Luy;
        private Label label1;
        private TextBox txtMaKH;
        private Button btnLamMoi;
        private Label label6;
        private ComboBox cboDiaChi;
    }
}