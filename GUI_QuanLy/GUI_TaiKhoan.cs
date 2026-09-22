using DAL_QuanLy;
using DTO_QuanLy;
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
    public partial class GUI_TaiKhoan : Form
    {

        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();

        public GUI_TaiKhoan()
        {
            InitializeComponent();

        }
        private void MoFormTheoRole(int role)
        {
            this.Hide();

            Form f = null;

            if (role == 1)
            {
                f = new GUI_Maincs(role);
            }
            else if (role == 2)
            {
                f = new GUI_Maincs(role);
            }
            else
            {
                f = new GUI_QuanLy.Form1();
            }

            f.FormClosed += (s, args) => this.Close();

            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            BUS_TaiKhoan bus = new BUS_TaiKhoan();
            DAL_TaiKhoan dal = new DAL_TaiKhoan();

            int role = bus.DangNhap(user, pass);

            if (role != -1)
            {
                Session.Username = user;
                Session.MaNhanVien = dal.LayMaNhanVienTuUsername(user);//
            
                Session.RoleID = role;
                Session.MaKH = bus.LayMaKH(user);

                MessageBox.Show("Đăng nhập thành công!");

                Form f;

                if (role == 1 || role == 2)
                {
                    f = new GUI_Maincs(role);
                }
                else
                {
                    f = new Form1();
                }

                f.FormClosed += (s, args) => this.Close();

                f.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void linkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormRegister().ShowDialog();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUI_TaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
