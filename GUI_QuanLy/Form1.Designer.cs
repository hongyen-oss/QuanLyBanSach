namespace GUI_QuanLy
{
    partial class Form1
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
            panel1 = new Panel();
            label1 = new Label();
            panelMenu = new Panel();
            button5 = new Button();
            btnGioHang = new Button();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(489, -8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 62);
            label1.TabIndex = 1;
            label1.Text = "BookStore";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlLight;
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(btnGioHang);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Location = new Point(0, 58);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(136, 515);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.FlatStyle = FlatStyle.System;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(8, 281);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(116, 37);
            button5.TabIndex = 7;
            button5.Text = "Đơn hàng";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnGioHang
            // 
            btnGioHang.AutoSize = true;
            btnGioHang.FlatStyle = FlatStyle.System;
            btnGioHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGioHang.Location = new Point(8, 234);
            btnGioHang.Margin = new Padding(2);
            btnGioHang.Name = "btnGioHang";
            btnGioHang.Size = new Size(116, 37);
            btnGioHang.TabIndex = 6;
            btnGioHang.Text = "Giỏ hàng";
            btnGioHang.UseVisualStyleBackColor = true;
            btnGioHang.Click += btnGioHang_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(7, 328);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(117, 37);
            button3.TabIndex = 4;
            button3.Text = "Tài khoản";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 190);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(116, 37);
            button1.TabIndex = 2;
            button1.Text = "Trang chủ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._636644559038217701;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ControlLight;
            panelMain.BorderStyle = BorderStyle.Fixed3D;
            panelMain.Location = new Point(140, 58);
            panelMain.Margin = new Padding(2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1157, 515);
            panelMain.TabIndex = 2;
            panelMain.Click += panelMain_Click;
            panelMain.Paint += panelMain_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 569);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "ABY Bookstore";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelMenu;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panelMain;
        private Button button3;
        private Button btnGioHang;
        private Button button5;
    }
}
