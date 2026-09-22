using DAL_QuanLy;
using DTO_QuanLy;
using GUI_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class UC_Donhang : UserControl
    {
        private List<DTO_GioHang> dsMua;
        private DAL_Voucher dalVoucher = new DAL_Voucher();
        private DAL_GioHang dalGH = new DAL_GioHang();
        public UC_Donhang()
        {
            InitializeComponent();

            if (Session.MaKH <= 0)
            {
                MessageBox.Show("Vui lòng đăng nhập!");
                return;
            }

            this.dsMua = dalGH.LayGioHang(Session.Username);

            LoadThanhToan();
            radGiaoTanNoi.Checked = true;
        }

        public UC_Donhang(
            List<DTO_GioHang> ds)
        {
            InitializeComponent();

            this.dsMua = ds;

            LoadThanhToan();
            radGiaoTanNoi.Checked = true;

        }
        private void LoadSanPham()
        {
            dtNgayHen.Value = DateTime.Now.AddDays(3);
            dtNgayHen.Enabled = false;

            if (dsMua == null || dsMua.Count == 0)
            {
                MessageBox.Show("Cảnh báo: Giỏ hàng đang trống!");
                return;
            }

            flowSanPham.Controls.Clear();
            decimal tong = 0;

            string thuMucAnh = Path.Combine(Application.StartupPath, "Images");

            foreach (var item in dsMua)
            {
                Panel pn = new Panel();
                pn.Width = flowSanPham.Width - 25;
                pn.Height = 100;

                PictureBox picSach = new PictureBox();
                picSach.Width = 70;
                picSach.Height = 85;
                picSach.Top = 8;
                picSach.Left = 20;
                picSach.SizeMode = PictureBoxSizeMode.Zoom;

                try
                {
                    string tenFileAnh = item.HinhAnh;
                    string duongDanAnhThucTe = Path.Combine(thuMucAnh, tenFileAnh);

                    if (!string.IsNullOrEmpty(tenFileAnh) && File.Exists(duongDanAnhThucTe))
                    {
                        picSach.Image = Image.FromFile(duongDanAnhThucTe);
                    }
                }
                catch
                {
                    // Tránh crash ứng dụng nếu lỗi file ảnh
                }

                Label lblTen = new Label();
                lblTen.Text = item.TenSach;
                lblTen.Top = 15;
                lblTen.Left = 110;
                lblTen.Width = 350;
                lblTen.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                Label lblSL = new Label();
                lblSL.Text = "SL: " + item.SoLuong;
                lblSL.Top = 45;
                lblSL.Left = 110;

                Label lblGia = new Label();
                lblGia.Text = item.ThanhTien.ToString("N0") + " VNĐ";
                lblGia.Top = 45;
                lblGia.Left = 220;

                pn.Controls.Add(picSach);
                pn.Controls.Add(lblTen);
                pn.Controls.Add(lblSL);
                pn.Controls.Add(lblGia);

                flowSanPham.Controls.Add(pn);

                tong += item.ThanhTien;
            }

            lblTongCong.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }
        //Khi chọn giao tận nơi
        private void radGiaoTanNoi_CheckedChanged(object sender, EventArgs e)
        {
            if (radTaiCuaHang.Checked)
            {
                TinhToanChiPhi();
            }
            //   pnlGiaoHang.Visible = true;
            //  pnlDatTruoc.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Donhang_Load(object sender, EventArgs e)
        {
            if (Session.MaKH <= 0)
            {
                MessageBox.Show("Vui lòng đăng nhập!");
                return;
            }

            flowSanPham.AutoScroll = true;
            flowSanPham.WrapContents = true;

            LoadSanPham();
            NapVoucherKhachHang(Session.MaKH);
            TinhToanChiPhi();
        
        }


        private void flowSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadThanhToan()
        {
            cboThanhToan.Items.Clear();

            cboThanhToan.Items.Add(
                "Tiền mặt"
            );

            cboThanhToan.Items.Add(
                "Chuyển khoản"
            );

            cboThanhToan.Items.Add(
                "Momo"
            );

            cboThanhToan.SelectedIndex = 0;
        }
        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (Session.MaKH <= 0)
            {
                MessageBox.Show("Lỗi: Không tìm thấy thông tin khách hàng. Vui lòng đăng nhập lại!");
                return;
            }
            if (cboThanhToan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!");
                return;
            }

            string phuongThucTT = cboThanhToan.SelectedItem.ToString();
            DAL_DonHang dal = new DAL_DonHang();

            decimal tongTienSachGoc = dsMua.Sum(x => x.ThanhTien);
            decimal soTienDuocGiam = 0;
            int maVoucherDaDung = 0;

            // Kiểm tra thông tin voucher được chọn
            if (cboVoucher.SelectedIndex > 0 && cboVoucher.SelectedValue != null)
            {
                DataRowView rowSelected = (DataRowView)cboVoucher.SelectedItem;
                int phanTramGiam = Convert.ToInt32(rowSelected["PhanTramGiam"]);
                maVoucherDaDung = Convert.ToInt32(cboVoucher.SelectedValue);

                soTienDuocGiam = tongTienSachGoc * phanTramGiam / 100;
            }

            decimal tongTienSachSauGiam = tongTienSachGoc - soTienDuocGiam;
            decimal tongCuoiCung = 0;
            decimal tienCoc = 0;
            string loaiDon = "";
            string hinhThucNhan = "";
            string diaChi = "";
            decimal phiShip = 0;

            DateTime hanChotNhan = dtNgayHen.Value;

            if (radGiaoTanNoi.Checked)
            {
                loaiDon = "Online";
                hinhThucNhan = "GiaoTanNoi";
                diaChi = txtDiaChi.Text;

                phiShip = (tongTienSachGoc > 200000) ? 10000 : 20000;
                tongCuoiCung = tongTienSachSauGiam + phiShip;
                tienCoc = 0;
            }
            else
            {
                loaiDon = "DatTruoc";
                hinhThucNhan = "TaiCuaHang";
                tongCuoiCung = tongTienSachSauGiam;
                diaChi = "";

                if (!decimal.TryParse(txtTienCoc.Text, out tienCoc))
                {
                    MessageBox.Show("Tiền cọc không hợp lệ!");
                    return;
                }
            }

            try
            {
                int maDH = dal.TaoDonHang(
                    Session.MaKH,
                    hanChotNhan,
                    tongCuoiCung,
                    tienCoc,
                    loaiDon,
                    hinhThucNhan,
                    diaChi,
                    txtGhiChu.Text,
                    phuongThucTT,
                    phiShip
                );

                foreach (var item in dsMua)
                {
                    dal.ThemCTDonHang(maDH, item.MaSach, item.SoLuong, item.GiaBan);
                }
                DAL_KhachHang dalKH = new DAL_KhachHang();

                dalKH.congTienTichLuy(
                    Session.MaKH,
                    tongCuoiCung
                );
                dalVoucher.KiemTraVaPhatVoucherTuDong(
    Session.MaKH
);

                DAL_GioHang dalGH = new DAL_GioHang();
                foreach (var item in dsMua)
                {
                    dalGH.XoaGioHang(Session.Username, item.MaSach);
                }

                MessageBox.Show("Đặt hàng thành công!");
                Form1.instance.LoadControl(new UC_GioHang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }


        private void grpThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void lblPhiShip_Click(object sender, EventArgs e)
        {

        }

        private void TinhToanChiPhi()
        {
            if (dsMua == null) return;

            decimal tongTienSachGoc = dsMua.Sum(x => x.ThanhTien);
            decimal phiVanChuyen = 0;
            decimal soTienDuocGiam = 0;
            decimal tienCoc = 0;
            decimal tongThanhToan = 0;

            if (cboVoucher.SelectedIndex > 0 && cboVoucher.SelectedItem != null)
            {
                DataRowView selectedVoucher = (DataRowView)cboVoucher.SelectedItem;
                decimal dieuKien = Convert.ToDecimal(selectedVoucher["DieuKienApDung"]);
                int phanTramGiam = Convert.ToInt32(selectedVoucher["PhanTramGiam"]);

                if (tongTienSachGoc >= dieuKien)
                {
                    soTienDuocGiam = tongTienSachGoc * phanTramGiam / 100;
                    lblTienGiam.Text = "-" + soTienDuocGiam.ToString("N0") + " VNĐ";
                }
                else
                {
                    MessageBox.Show($"Đơn hàng chưa đạt giá trị tối thiểu {dieuKien:N0} VNĐ để áp dụng mã giảm giá này!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboVoucher.SelectedIndex = 0;
                    return;
                }
            }
            else
            {
                lblTienGiam.Text = "0 VNĐ";
            }


            decimal tongTienSachSauGiam = tongTienSachGoc - soTienDuocGiam;

            if (radGiaoTanNoi.Checked)
            {
                phiVanChuyen = (tongTienSachGoc > 200000) ? 10000 : 20000;
                tienCoc = 0;
                tongThanhToan = tongTienSachSauGiam + phiVanChuyen;

                txtTienCoc.Enabled = false;
            }
            else
            {
                phiVanChuyen = 0;
                tienCoc = tongTienSachSauGiam * 0.5m; // Cọc 50% dựa trên tiền sách sau khi đã giảm
                tongThanhToan = tienCoc; // Tại quầy đặt trước chỉ thu tiền cọc

                txtTienCoc.Enabled = true;
            }


            lblPhiShip.Text = phiVanChuyen.ToString("N0") + " VNĐ";
            txtTienCoc.Text = tienCoc.ToString("N0");
            lblTongCong.Text = "Tổng tiền: " + tongTienSachGoc.ToString("N0") + " VNĐ";
            lblTongThanhToan.Text = tongThanhToan.ToString("N0") + " VNĐ";
        }


        private void radGiaoTanNoi_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radGiaoTanNoi.Checked)
            {
                dtNgayHen.Value =
                    DateTime.Now.AddDays(3);

                dtNgayHen.Enabled = false;
                LoadThanhToan();

                TinhToanChiPhi();
            }
        }

        private void radTaiCuaHang_CheckedChanged(object sender, EventArgs e)
        {
            if (radTaiCuaHang.Checked)
            {
                dtNgayHen.Enabled = true;
                if (cboThanhToan.SelectedIndex == 0)
                {
                    cboThanhToan.SelectedIndex = 1;
                }

                cboThanhToan.Items.Clear();
                cboThanhToan.Items.Add("Chuyển khoản");
                cboThanhToan.Items.Add("Momo");

                cboThanhToan.SelectedIndex = 0;

                TinhToanChiPhi();
            }
        }
        private void NapVoucherKhachHang(int maKH)
        {
            try
            {
              //  dalVoucher.KiemTraVaPhatVoucherTuDong(maKH);
                DataTable dt = dalVoucher.LayVoucherKhaDungCuaKhach(maKH);

                DataRow dr = dt.NewRow();
                dr["MaVoucher"] = 0;
                dr["TenVoucher"] = "Không áp dụng Voucher ";
                dr["PhanTramGiam"] = 0;
                dr["DieuKienApDung"] = 0;
                dt.Rows.InsertAt(dr, 0);

                cboVoucher.DataSource = dt;
                cboVoucher.DisplayMember = "TenVoucher";
                cboVoucher.ValueMember = "MaVoucher";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách mã ưu đãi: " + ex.Message);
            }
        }
        private void cboVoucher_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TinhToanChiPhi();
        }
       
        private void UC_Donhang_SizeChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
