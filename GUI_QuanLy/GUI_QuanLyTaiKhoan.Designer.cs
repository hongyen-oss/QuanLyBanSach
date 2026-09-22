namespace GUI_QuanLy
{
    partial class GUI_QuanLyTaiKhoan
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
            lblTienTichLuy = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            btnDangXuat = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTienTichLuy
            // 
            lblTienTichLuy.AutoSize = true;
            lblTienTichLuy.Location = new Point(268, 393);
            lblTienTichLuy.Name = "lblTienTichLuy";
            lblTienTichLuy.Size = new Size(88, 20);
            lblTienTichLuy.TabIndex = 0;
            lblTienTichLuy.Text = "Tiền tích lũy";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(268, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(268, 169);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(268, 102);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(125, 27);
            txtUser.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(268, 26);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(268, 246);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 5;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(578, 137);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(94, 45);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(578, 293);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 38);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(578, 216);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 46);
            btnCapNhat.TabIndex = 9;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(lblTienTichLuy);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtSDT);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 450);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 391);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 12;
            label6.Text = "Tổng tích lũy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 330);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 250);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 10;
            label4.Text = "SDT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 173);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 106);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Họ Ten";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4395949;
            pictureBox1.Location = new Point(3, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // GUI_QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 453);
            Controls.Add(panel1);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnDangXuat);
            Name = "GUI_QuanLyTaiKhoan";
            Text = "GUI_QuanLyTaiKhoan";
            Load += GUI_QuanLyTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTienTichLuy;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtUser;
        private TextBox txtTen;
        private TextBox txtSDT;
        private Button btnDangXuat;
        private Button btnXoa;
        private Button btnCapNhat;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}