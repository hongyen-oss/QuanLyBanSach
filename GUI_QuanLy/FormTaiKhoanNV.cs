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
    public partial class FormTaiKhoanNV : Form
    {
        int _maNV;
        BUS_TaiKhoan busTK = new BUS_TaiKhoan();

        public FormTaiKhoanNV(int maNV)
        {
            InitializeComponent();
            _maNV = maNV;
        }

        private void FormTaiKhoanNV_Load(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            if (busTK.TaoTaiKhoanNhanVien(txtUser.Text, txtPass.Text, _maNV))
            {
                MessageBox.Show("Tạo tài khoản thành công!");
                this.Visible = false;
            }
        }
    }
}
