namespace GUI_QuanLy
{
    partial class UC_Trangchu
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
            btnSearch = new PictureBox();
            txtSearch = new MaskedTextBox();
            flpDanhSachSach = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            cboTheLoai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.canva_search_tool_MAC1gBGUsB4;
            btnSearch.Location = new Point(33, 2);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(54, 35);
            btnSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSearch.TabIndex = 13;
            btnSearch.TabStop = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(97, 6);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(593, 27);
            txtSearch.TabIndex = 12;
            txtSearch.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flpDanhSachSach
            // 
            flpDanhSachSach.AutoScroll = true;
            flpDanhSachSach.BackColor = SystemColors.Info;
            flpDanhSachSach.Dock = DockStyle.Fill;
            flpDanhSachSach.Location = new Point(0, 39);
            flpDanhSachSach.Name = "flpDanhSachSach";
            flpDanhSachSach.Size = new Size(1202, 511);
            flpDanhSachSach.TabIndex = 15;
            flpDanhSachSach.Paint += flpDanhSachSach_Paint_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cboTheLoai);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 39);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(782, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 19;
            label1.Text = "Thể loại";
            // 
            // cboTheLoai
            // 
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(857, 5);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(209, 28);
            cboTheLoai.TabIndex = 14;
            cboTheLoai.SelectedIndexChanged += cboTheLoai_SelectedIndexChanged;
            // 
            // UC_Trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpDanhSachSach);
            Controls.Add(panel1);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(2);
            Name = "UC_Trangchu";
            Size = new Size(1202, 550);
            Load += UC_Trangchu_Load;
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnSearch;
        private MaskedTextBox txtSearch;
        private FlowLayoutPanel flpDanhSachSach;
        private Panel panel1;
        private ComboBox cboTheLoai;
        private Label label1;
    }
}
