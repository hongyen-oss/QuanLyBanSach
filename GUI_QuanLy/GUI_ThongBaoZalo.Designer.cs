namespace GUI_QuanLy
{
    partial class GUI_ThongBaoZalo
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
            dgvThongBao = new DataGridView();
            btnGuiMoi = new Button();
            label1 = new Label();
            cboTheLoai = new ComboBox();
            btnLoc = new Button();
            label2 = new Label();
            txtNoiDung = new TextBox();
            btnGmail = new Button();
            label3 = new Label();
            cboChonSach = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvThongBao).BeginInit();
            SuspendLayout();
            // 
            // dgvThongBao
            // 
            dgvThongBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongBao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongBao.Location = new Point(12, 12);
            dgvThongBao.Name = "dgvThongBao";
            dgvThongBao.RowHeadersWidth = 51;
            dgvThongBao.Size = new Size(1098, 199);
            dgvThongBao.TabIndex = 0;
            dgvThongBao.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnGuiMoi
            // 
            btnGuiMoi.BackColor = Color.SpringGreen;
            btnGuiMoi.Location = new Point(774, 255);
            btnGuiMoi.Name = "btnGuiMoi";
            btnGuiMoi.Size = new Size(167, 45);
            btnGuiMoi.TabIndex = 1;
            btnGuiMoi.Text = "Gửi thông báo Zalo";
            btnGuiMoi.UseVisualStyleBackColor = false;
            btnGuiMoi.Click += btnGuiMoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 240);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Lọc theo thể loại";
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(191, 234);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(184, 28);
            cboTheLoai.TabIndex = 3;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.Yellow;
            btnLoc.Location = new Point(423, 234);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(57, 29);
            btnLoc.TabIndex = 4;
            btnLoc.Text = "LỌC";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 378);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new Point(191, 340);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(298, 98);
            txtNoiDung.TabIndex = 150;
            // 
            // btnGmail
            // 
            btnGmail.BackColor = Color.PaleTurquoise;
            btnGmail.Location = new Point(774, 331);
            btnGmail.Name = "btnGmail";
            btnGmail.Size = new Size(167, 45);
            btnGmail.TabIndex = 7;
            btnGmail.Text = "Gửi thông báo Gmail";
            btnGmail.UseVisualStyleBackColor = false;
            btnGmail.Click += btnGmail_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 301);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 8;
            label3.Text = "Sách";
            // 
            // cboChonSach
            // 
            cboChonSach.FormattingEnabled = true;
            cboChonSach.Location = new Point(191, 289);
            cboChonSach.Name = "cboChonSach";
            cboChonSach.Size = new Size(184, 28);
            cboChonSach.TabIndex = 9;
            cboChonSach.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // GUI_ThongBaoZalo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 450);
            Controls.Add(cboChonSach);
            Controls.Add(label3);
            Controls.Add(btnGmail);
            Controls.Add(txtNoiDung);
            Controls.Add(label2);
            Controls.Add(btnLoc);
            Controls.Add(cboTheLoai);
            Controls.Add(label1);
            Controls.Add(btnGuiMoi);
            Controls.Add(dgvThongBao);
            Name = "GUI_ThongBaoZalo";
            Text = "GUI_ThongBaoZalo";
            Load += GUI_ThongBaoZalo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThongBao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThongBao;
        private Button btnGuiMoi;
        private Label label1;
        private ComboBox cboTheLoai;
        private Button btnLoc;
        private Label label2;
        private TextBox txtNoiDung;
        private Button btnGmail;
        private Label label3;
        private ComboBox cboChonSach;
    }
}