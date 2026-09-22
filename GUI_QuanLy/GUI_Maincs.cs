using BUS_QuanLy;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_Maincs : Form
    {
        private int userRole;
        public GUI_Maincs(int role)
        {
            InitializeComponent();
            this.userRole = role;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Form currentForm = null;
        void loadForm(Form f)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = f;

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);

            f.BringToFront();
            f.Show();


        }
        private void GUI_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            loadForm(new GUI_Sach());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            loadForm(new KhachHang());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new GUI_NhanVien(this.userRole));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new GUI_HoaDon(this.userRole));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.userRole == 1)
            {
                loadForm(new GUI_ThongBaoZalo());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // loadForm(new GUI_ThongBaoZalo());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            UC_Trangchu trangChu = new UC_Trangchu();

            loadPage(trangChu);
        }
        private void loadPage(UserControl uc)
        {
            panelMain.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            UC_QuanLyDonHang uc =
                new UC_QuanLyDonHang();

            uc.Dock = DockStyle.Fill;

            panelMain.Controls.Add(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.userRole == 1)
            {
                loadForm(new GUI_ThongKe());
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GUI_Maincs_Load(object sender, EventArgs e)
        {
            if (this.userRole == 2)
            {
                button4.Visible = false;
            }
            else if (this.userRole == 1)
            {
                button4.Visible = true;
            }
            if (this.userRole == 2)
            {
                button1.Visible = false;

            }
            else if (this.userRole == 1)
            {
                button1.Visible = true;
            }
            if (this.userRole == 1)
            {
                btnDonHang.Visible = false;

            }
            else if (this.userRole == 2)
            {
                btnDonHang.Visible = true;
            }
        }
    }

}
