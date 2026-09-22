using BUS_QuanLy;
using DAL_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class FormRegister : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        DAL_TaiKhoan dalTaiKhoan = new DAL_TaiKhoan();
        public FormRegister()
        {
            InitializeComponent();


            string[] danhSachDiaChi = { "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh",
                                    "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau",
                                       "Cần Thơ", "Cao Bằng", "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai",
                                        "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương",
                                         "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Thành phố Hồ Chí Minh", "Khánh Hòa", "Kiên Giang" };
            cboDiaChi.Items.Clear();
            cboDiaChi.Items.AddRange(danhSachDiaChi);
            cboDiaChi.SelectedIndex = -1;
            cboDiaChi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ giao diện
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string repass = txtRePass.Text.Trim();
            string ten = txtName.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string email = txtGmail.Text.Trim();
            string DiaChi = cboDiaChi.Text.Trim();



            int maKH = dalKhachHang.ThemKhachHang_DangKy(ten, sdt, email, DiaChi);

            if (maKH > 0)
            {

                bool result = dalTaiKhoan.DangKy(user, pass, maKH);

                if (result)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close(); // Đóng form đăng ký để về form đăng nhập
                }
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}


