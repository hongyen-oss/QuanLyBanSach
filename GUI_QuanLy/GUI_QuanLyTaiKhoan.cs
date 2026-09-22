using BUS_QuanLy;
using DAL_QuanLy;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QuanLy
{
    public partial class GUI_QuanLyTaiKhoan : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();

        string Username = "";
        public GUI_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void GUI_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

            hienThiThongTin();
        }
        void hienThiThongTin()
        {
            DataTable dt =
                busTaiKhoan.LayThongTinTaiKhoan(Session.Username);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                txtTen.Text = r["HoTen"].ToString();

                txtUser.Text = r["Username"].ToString();

                txtPass.Text = r["Password"].ToString();

                txtSDT.Text = r["SDT"].ToString();

                txtEmail.Text = r["Email"].ToString();

                lblTienTichLuy.Text =
                    Convert.ToDecimal(r["TienTichLuy"])
                    .ToString("N0") + " VNĐ";
            }

            // KHÔNG CHO SỬA
            txtUser.Enabled = false;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string xacNhanMK = Interaction.InputBox(
        "Nhập mật khẩu để xác nhận cập nhật:",
        "Xác nhận",
        ""
    );

            // kiểm tra mật khẩu đúng không
            int role = busTaiKhoan.DangNhap(
                Session.Username,
                xacNhanMK
            );

            if (role == -1)
            {
                MessageBox.Show("Mật khẩu không đúng!");
                return;
            }

            bool kq = busTaiKhoan.CapNhatTaiKhoan(
                Session.Username,
                txtPass.Text,
                txtTen.Text,
                txtSDT.Text,
                txtEmail.Text
            );

            if (kq)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string nhapPass = Interaction.InputBox(
        "Nhập mật khẩu để xác nhận xóa tài khoản:",
        "Xác nhận xóa",
        ""
    );

            // Bấm Cancel
            if (nhapPass == "")
                return;

            // Sai mật khẩu
            if (nhapPass != txtPass.Text)
            {
                MessageBox.Show(
                    "Mật khẩu không đúng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn chắc chắn muốn xóa tài khoản?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        bool kq = busTaiKhoan.XoaTaiKhoan(txtUser.Text);

                        if (kq)
                        {
                            MessageBox.Show("Đã xóa tài khoản!");
                            Session.Username = "";
                            Session.RoleID = 0;
                            Session.MaKH = 0;
                            this.Close();
                            new GUI_TaiKhoan().Show();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại! Không tìm thấy tên tài khoản khớp trong hệ thống.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Session.Username = "";
            Session.MaKH = 0;
            Session.RoleID = 0;

            GUI_TaiKhoan f = new GUI_TaiKhoan();

            f.Show();

            Form1.instance.Close();
        }
    }
}
