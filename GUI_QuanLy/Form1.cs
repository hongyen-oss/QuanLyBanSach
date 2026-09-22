using BUS_QuanLy;
using GUI_QuanLy;
using System;
using System.Windows.Forms;

namespace GUI_QuanLy

{
    
    public partial class Form1 : Form
    {
        
        UC_GioHang uc = new UC_GioHang();
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        public void LoadControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Trangchu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_Donhang());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int maHD = 1;

            LoadControl(new UC_Trahang(maHD));
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Click(object sender, EventArgs e)
        {

        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            UC_GioHang uc = new UC_GioHang();

            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadControl(new UC_LichSuDonHang());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            GUI_QuanLyTaiKhoan f =
                new GUI_QuanLyTaiKhoan();

            f.TopLevel = false;

            f.FormBorderStyle = FormBorderStyle.None;

            f.Dock = DockStyle.Fill;

            panelMain.Controls.Add(f);

            f.Show();
        }
    }
}
