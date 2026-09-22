namespace GUI_QuanLy
{
    partial class GUI_TaiKhoan
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
            label1 = new Label();
            txtUser = new TextBox();
            Password = new Label();
            txtPass = new TextBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 99);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(321, 92);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(185, 27);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(193, 190);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(321, 183);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(185, 27);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(321, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.Highlight;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(331, 408);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "REGISTER";
            linkLabel1.LinkClicked += linkDangKy_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(244, 379);
            label2.Name = "label2";
            label2.Size = new Size(279, 20);
            label2.TabIndex = 7;
            label2.Text = "Dành cho khách hàng đăng ký thành viên";
            // 
            // GUI_TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(795, 496);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(Password);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Name = "GUI_TaiKhoan";
            Text = "GUI_TaiKhoan";
            Load += GUI_TaiKhoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private Label Password;
        private TextBox txtPass;
        private Button btnLogin;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}