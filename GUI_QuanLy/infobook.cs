using DAL_QuanLy;
using DTO_QuanLy;
using GUI_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace GUI_QuanLy
{
    public partial class infobook : Form
    {
        string maSach = "";
        string duongDanAnh = "";
        public string SelectedMaSach;

        private DTO_Sach _sach;
        private DTO_Sach sachHienTai;

        public infobook()
        {
            InitializeComponent();
         //   sachHienTai = _sach;

        }


        public infobook(DTO_Sach sach) : this()
        {
            this._sach = sach;
            this.sachHienTai = sach;
            HienThiThongTin();
            
            if (sach == null) return;

            lblTenSach.Text = sach.TenSach;
            lblGiaBan.Text = string.Format("{0:N0} VNĐ", sach.GiaBan);

            rtxtMoTa.Text = sach.MoTa;
            try
            {
                if (Session.RoleID != null && (Session.RoleID == 1 || Session.RoleID == 2))
                {
                    btnThemGioHang.Visible = false;
                    btnDatMua.Visible = false;
                }
                else
                {
                    btnThemGioHang.Visible = true;
                    btnDatMua.Visible = true;
                }
            }
            catch
            {
                btnThemGioHang.Visible = true;
                btnDatMua.Visible = true;
            }
            if (!string.IsNullOrEmpty(sach.HinhAnh))
            {
                try
                {
                    duongDanAnh = Path.Combine(Application.StartupPath, "Images", sach.HinhAnh);

                    if (File.Exists(duongDanAnh))
                    {
                        picAnhBia.Image = Image.FromFile(duongDanAnh);
                        picAnhBia.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load ảnh: " + ex.Message);
                }
            }
        }

        private void infobook_Load(object sender, EventArgs e)
        {

        }
        private void HienThiThongTin()
        {
            if (_sach == null) return;

            maSach = _sach.MaSach;

            lblTenSach.Text = _sach.TenSach;
            lblGiaBan.Text = string.Format("{0:N0} VNĐ", _sach.GiaBan);
            rtxtMoTa.Text = _sach.MoTa;

            if (!string.IsNullOrEmpty(_sach.HinhAnh))
            {
                duongDanAnh = Path.Combine(
                    Application.StartupPath,
                    "Images",
                    _sach.HinhAnh
                );

                if (File.Exists(duongDanAnh))
                {
                    picAnhBia.Image = Image.FromFile(duongDanAnh);
                    picAnhBia.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            int sl = (int)numericSoLuong.Value;

            DAL_GioHang dal = new DAL_GioHang();

            dal.ThemGioHang(
                Session.Username,
                _sach.MaSach,
                sl
            );
            DTO_GioHang sach = GioHangSession.DanhSachGioHang
                .FirstOrDefault(x => x.MaSach == maSach);
           

            if (sach != null)
            {
                sach.SoLuong += sl;
            }
            else
            {
                DTO_GioHang gh = new DTO_GioHang()
                {
                    MaSach = _sach.MaSach,
                    TenSach = _sach.TenSach,
                    GiaBan = _sach.GiaBan,
                    SoLuong = sl,
                    HinhAnh = duongDanAnh
                };

                GioHangSession.DanhSachGioHang.Add(gh);
            }
            MessageBox.Show($"Đã thêm '{_sach.TenSach}' vào giỏ hàng!");
            this.Close();
        }

        private void btnDatMua_Click(object sender, EventArgs e)
        {
            if (sachHienTai == null)
            {
                MessageBox.Show("Không tìm thấy thông tin sách!");
                return;
            }

            if (numericSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng lớn hơn 0!");
                
                return;
            }

            decimal giaSachThucTe = 0;

            string chuoiGia = lblGiaBan.Text
                .Replace("VNĐ", "")
                .Replace(",", "")
                .Trim();

            decimal.TryParse(chuoiGia, out giaSachThucTe);

            List<DTO_GioHang> dsMuaNgay =
                new List<DTO_GioHang>();

            DTO_GioHang sachMua =
                new DTO_GioHang
                {
                    MaSach = sachHienTai.MaSach,
                    TenSach = sachHienTai.TenSach,
                    GiaBan = giaSachThucTe,
                    SoLuong = Convert.ToInt32(numericSoLuong.Value),
                    HinhAnh = sachHienTai.HinhAnh
                };

            dsMuaNgay.Add(sachMua);

            UC_Donhang ucDonHang =
                new UC_Donhang(dsMuaNgay);

            if (Form1.instance != null)
            {
                Form1.instance.LoadControl(ucDonHang);
            }
        }

        private void picAnhBia_Click(object sender, EventArgs e)
        {

        }
    }
}
