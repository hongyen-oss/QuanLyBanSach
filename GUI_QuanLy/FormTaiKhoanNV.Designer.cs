namespace GUI_QuanLy
{
    partial class FormTaiKhoanNV
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
            btnTao = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtRePass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnTao
            // 
            btnTao.Location = new Point(150, 248);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(94, 29);
            btnTao.TabIndex = 0;
            btnTao.Text = "Tạo";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(135, 55);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(193, 27);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(135, 110);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(193, 27);
            txtPass.TabIndex = 2;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(135, 175);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(193, 27);
            txtRePass.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 58);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 117);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 182);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Nhập lại";
            // 
            // FormTaiKhoanNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 289);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRePass);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnTao);
            Name = "FormTaiKhoanNV";
            Load += FormTaiKhoanNV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTao;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtRePass;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
