namespace GUI_QuanLy

{
    partial class ucSach
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
            lblTenSach = new Label();
            lblGiaBan = new Label();
            picAnhSach = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picAnhSach).BeginInit();
            SuspendLayout();
            // 
            // lblTenSach
            // 
            lblTenSach.AutoEllipsis = true;
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(46, 130);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(67, 20);
            lblTenSach.TabIndex = 0;
            lblTenSach.Text = "Tên Sách";
            lblTenSach.Click += lblTenSach_Click;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(46, 156);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(60, 20);
            lblGiaBan.TabIndex = 1;
            lblGiaBan.Text = "Giá Bán";
            lblGiaBan.Click += label2_Click;
            // 
            // picAnhSach
            // 
            picAnhSach.Location = new Point(17, 3);
            picAnhSach.Name = "picAnhSach";
            picAnhSach.Size = new Size(125, 122);
            picAnhSach.TabIndex = 2;
            picAnhSach.TabStop = false;
            picAnhSach.Click += picAnhSach_Click;
            // 
            // ucSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picAnhSach);
            Controls.Add(lblGiaBan);
            Controls.Add(lblTenSach);
            Name = "ucSach";
            Size = new Size(171, 181);
            Load += ucSach_Load;
            ((System.ComponentModel.ISupportInitialize)picAnhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenSach;
        private Label lblGiaBan;
        private PictureBox picAnhSach;
    }
}
