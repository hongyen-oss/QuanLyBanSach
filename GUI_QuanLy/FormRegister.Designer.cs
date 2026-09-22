namespace GUI_QuanLy
{
    partial class FormRegister
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
            btnDangKy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtRePass = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            txtSdt = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtGmail = new TextBox();
            cboDiaChi = new ComboBox();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(787, 228);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 59);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 49);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 115);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 170);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhập lại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 235);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 4;
            label4.Text = "Họ Tên";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(328, 42);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(346, 27);
            txtUser.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(328, 108);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(346, 27);
            txtPass.TabIndex = 6;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(328, 163);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(346, 27);
            txtRePass.TabIndex = 7;
            txtRePass.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(328, 228);
            txtName.Name = "txtName";
            txtName.Size = new Size(346, 27);
            txtName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 295);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 9;
            label5.Text = "SDT";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(328, 288);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(346, 27);
            txtSdt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 422);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 11;
            label6.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 354);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 12;
            label7.Text = "Gmail";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(328, 347);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(346, 27);
            txtGmail.TabIndex = 13;
            // 
            // cboDiaChi
            // 
            cboDiaChi.FormattingEnabled = true;
            cboDiaChi.Location = new Point(328, 414);
            cboDiaChi.Name = "cboDiaChi";
            cboDiaChi.Size = new Size(346, 28);
            cboDiaChi.TabIndex = 14;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 500);
            Controls.Add(cboDiaChi);
            Controls.Add(txtGmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSdt);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(txtRePass);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangKy);
            Name = "FormRegister";
            Text = "FormRegister";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangKy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtRePass;
        private TextBox txtName;
        private Label label5;
        private TextBox txtSdt;
        private Label label6;
        private Label label7;
        private TextBox txtGmail;
        private ComboBox cboDiaChi;
    }
}