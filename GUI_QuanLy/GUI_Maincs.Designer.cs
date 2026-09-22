namespace GUI_QuanLy
{
    partial class GUI_Maincs
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
            panelMenu = new Panel();
            button4 = new Button();
            btnDonHang = new Button();
            btnTrangChu = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnKhachHang = new Button();
            btnSach = new Button();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.Info;
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnDonHang);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnSach);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(120, 532);
            panelMenu.TabIndex = 2;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ScrollBar;
            button4.Location = new Point(7, 438);
            button4.Name = "button4";
            button4.Size = new Size(98, 45);
            button4.TabIndex = 6;
            button4.Text = "Thống kê";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnDonHang
            // 
            btnDonHang.BackColor = SystemColors.ScrollBar;
            btnDonHang.Location = new Point(7, 314);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(98, 46);
            btnDonHang.TabIndex = 1;
            btnDonHang.Text = "Chờ xử lý";
            btnDonHang.UseVisualStyleBackColor = false;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = SystemColors.ScrollBar;
            btnTrangChu.Location = new Point(7, 35);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(98, 47);
            btnTrangChu.TabIndex = 5;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.Location = new Point(7, 261);
            button3.Name = "button3";
            button3.Size = new Size(98, 45);
            button3.TabIndex = 4;
            button3.Text = "Nhân Viên";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Location = new Point(7, 190);
            button2.Name = "button2";
            button2.Size = new Size(98, 63);
            button2.TabIndex = 3;
            button2.Text = "Đơn hàng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(7, 370);
            button1.Name = "button1";
            button1.Size = new Size(98, 60);
            button1.TabIndex = 2;
            button1.Text = "Thông báo Zalo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = SystemColors.ScrollBar;
            btnKhachHang.Location = new Point(7, 136);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(98, 43);
            btnKhachHang.TabIndex = 1;
            btnKhachHang.Text = "Khách Hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnSach
            // 
            btnSach.BackColor = SystemColors.ScrollBar;
            btnSach.Location = new Point(7, 88);
            btnSach.Name = "btnSach";
            btnSach.Size = new Size(98, 45);
            btnSach.TabIndex = 0;
            btnSach.Text = "Sách";
            btnSach.UseVisualStyleBackColor = false;
            btnSach.Click += btnSach_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ControlLight;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(120, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1203, 532);
            panelMain.TabIndex = 3;
            panelMain.Paint += panelMain_Paint;
            // 
            // GUI_Maincs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 532);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Name = "GUI_Maincs";
            Text = "GUI_Maincs";
            Load += GUI_Maincs_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnSach;
        private Button btnKhachHang;
        private Panel panelMain;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button btnTrangChu;
        private Button btnDonHang;
        private Button button4;
    }
}