namespace GUI_QuanLy
{
    partial class GUI_NhanVien
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
            dgvNV = new DataGridView();
            label1 = new Label();
            txt = new Label();
            label23 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtMaNV = new TextBox();
            txtHoTenNV = new TextBox();
            txtSDTnv = new TextBox();
            cboCaTruc = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtGmail = new TextBox();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNV).BeginInit();
            SuspendLayout();
            // 
            // dgvNV
            // 
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNV.Location = new Point(4, 2);
            dgvNV.Name = "dgvNV";
            dgvNV.RowHeadersWidth = 51;
            dgvNV.Size = new Size(1155, 219);
            dgvNV.TabIndex = 0;
            dgvNV.CellClick += dgvNV_CellClick;
            dgvNV.CellContentClick += dgvNV_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 251);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Nhân viên";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(37, 400);
            txt.Name = "txt";
            txt.Size = new Size(35, 20);
            txt.TabIndex = 2;
            txt.Text = "SDT";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(37, 322);
            label23.Name = "label23";
            label23.Size = new Size(56, 20);
            label23.TabIndex = 3;
            label23.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 255);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Ca trực";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(944, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Location = new Point(944, 396);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Location = new Point(944, 349);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 255, 128);
            button4.Location = new Point(944, 300);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = SystemColors.Menu;
            txtMaNV.Enabled = false;
            txtMaNV.Location = new Point(168, 248);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(210, 27);
            txtMaNV.TabIndex = 9;
            // 
            // txtHoTenNV
            // 
            txtHoTenNV.Location = new Point(168, 315);
            txtHoTenNV.Name = "txtHoTenNV";
            txtHoTenNV.Size = new Size(210, 27);
            txtHoTenNV.TabIndex = 10;
            // 
            // txtSDTnv
            // 
            txtSDTnv.Location = new Point(168, 393);
            txtSDTnv.Name = "txtSDTnv";
            txtSDTnv.Size = new Size(210, 27);
            txtSDTnv.TabIndex = 11;
            // 
            // cboCaTruc
            // 
            cboCaTruc.FormattingEnabled = true;
            cboCaTruc.Location = new Point(608, 251);
            cboCaTruc.Name = "cboCaTruc";
            cboCaTruc.Size = new Size(210, 28);
            cboCaTruc.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 400);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 13;
            label2.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(517, 322);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 16;
            label3.Text = "Gmail";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(608, 315);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(210, 27);
            txtGmail.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(608, 393);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(210, 27);
            txtDiaChi.TabIndex = 18;
            // 
            // GUI_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1165, 450);
            Controls.Add(txtDiaChi);
            Controls.Add(txtGmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboCaTruc);
            Controls.Add(txtSDTnv);
            Controls.Add(txtHoTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label23);
            Controls.Add(txt);
            Controls.Add(label1);
            Controls.Add(dgvNV);
            Name = "GUI_NhanVien";
            Text = "NhanVien";
            Load += GUI_NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNV;
        private Label label1;
        private Label txt;
        private Label label23;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtMaNV;
        private TextBox txtHoTenNV;
        private TextBox txtSDTnv;
        private ComboBox cboCaTruc;
        private Label label2;
        private Label label3;
        private TextBox txtGmail;
        private TextBox txtDiaChi;
    }
}