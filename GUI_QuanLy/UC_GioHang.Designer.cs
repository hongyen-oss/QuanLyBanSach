namespace GUI_QuanLy
{
    partial class UC_GioHang
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
            panelBottom = new Panel();
            btnMuaHang = new Button();
            lblTongTien = new Label();
            flowGioHang = new FlowLayoutPanel();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.Info;
            panelBottom.Controls.Add(btnMuaHang);
            panelBottom.Controls.Add(lblTongTien);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 372);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(924, 96);
            panelBottom.TabIndex = 0;
            panelBottom.Paint += panelBottom_Paint;
            // 
            // btnMuaHang
            // 
            btnMuaHang.BackColor = Color.FromArgb(192, 64, 0);
            btnMuaHang.ForeColor = SystemColors.ButtonHighlight;
            btnMuaHang.Location = new Point(25, 52);
            btnMuaHang.Name = "btnMuaHang";
            btnMuaHang.Size = new Size(94, 29);
            btnMuaHang.TabIndex = 1;
            btnMuaHang.Text = "Mua hàng";
            btnMuaHang.UseVisualStyleBackColor = false;
            btnMuaHang.Click += btnMuaHang_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.BackColor = SystemColors.Info;
            lblTongTien.ForeColor = Color.Blue;
            lblTongTien.Location = new Point(29, 18);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 20);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền";
            // 
            // flowGioHang
            // 
            flowGioHang.AutoScroll = true;
            flowGioHang.BorderStyle = BorderStyle.FixedSingle;
            flowGioHang.Dock = DockStyle.Fill;
            flowGioHang.Location = new Point(0, 0);
            flowGioHang.Name = "flowGioHang";
            flowGioHang.Size = new Size(924, 372);
            flowGioHang.TabIndex = 2;
            flowGioHang.Paint += flowGioHang_Paint_1;
            // 
            // UC_GioHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowGioHang);
            Controls.Add(panelBottom);
            Name = "UC_GioHang";
            Size = new Size(924, 468);
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBottom;
        private Button btnMuaHang;
        private Label lblTongTien;
        private FlowLayoutPanel flowGioHang;
    }
}
