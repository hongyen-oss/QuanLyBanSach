namespace GUI_QuanLy
{
    partial class UC_LichSuDonHang
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
            dgvDonHang = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // dgvDonHang
            // 
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(0, 53);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.Size = new Size(1170, 367);
            dgvDonHang.TabIndex = 0;
            dgvDonHang.CellClick += dgvDonHang_CellClick;
            dgvDonHang.CellContentClick += dgvDonHang_CellContentClick;
            dgvDonHang.CellFormatting += dgvDonHang_CellFormatting;
            // 
            // UC_LichSuDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvDonHang);
            Name = "UC_LichSuDonHang";
            Size = new Size(1170, 432);
            Load += UC_LichSuDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDonHang;
    }
}
