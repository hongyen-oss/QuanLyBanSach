namespace GUI_QuanLy
{
    partial class UC_Trahang
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
            dgvSach = new DataGridView();
            lblMaHD = new Label();
            lblTongTien = new Label();
            txtLyDo = new TextBox();
            btnGui = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = SystemColors.ControlLight;
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(0, 0);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(911, 188);
            dgvSach.TabIndex = 0;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Location = new Point(179, 216);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(52, 20);
            lblMaHD.TabIndex = 1;
            lblMaHD.Text = "MaHD";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(179, 279);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 20);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Tổng tiền";
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(179, 335);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.ScrollBars = ScrollBars.Vertical;
            txtLyDo.Size = new Size(189, 97);
            txtLyDo.TabIndex = 3;
            // 
            // btnGui
            // 
            btnGui.BackColor = Color.IndianRed;
            btnGui.Location = new Point(677, 312);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(94, 50);
            btnGui.TabIndex = 4;
            btnGui.Text = "Trả hàng";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnGui_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 216);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã Hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 365);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Lý do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 279);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 7;
            label3.Text = "Tổng tiền";
            // 
            // UC_Trahang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGui);
            Controls.Add(txtLyDo);
            Controls.Add(lblTongTien);
            Controls.Add(lblMaHD);
            Controls.Add(dgvSach);
            Margin = new Padding(2);
            Name = "UC_Trahang";
            Size = new Size(911, 445);
            Load += UC_Trahang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSach;
        private Label lblMaHD;
        private Label lblTongTien;
        private TextBox txtLyDo;
        private Button btnGui;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
