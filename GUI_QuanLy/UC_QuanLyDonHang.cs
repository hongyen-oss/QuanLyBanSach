using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL_QuanLy;
using DTO_QuanLy;


namespace GUI_QuanLy
{
    public partial class UC_QuanLyDonHang : UserControl
    {
        DAL_DonHang dal = new DAL_DonHang();

        public UC_QuanLyDonHang()
        {
            InitializeComponent();
            LoadDonHang();
        }

        private void LoadDonHang()
        {
            dgvDonHang.DataSource =
                dal.LayDonHang();
        }

        private int LayMaDH()
        {
            return Convert.ToInt32(
                dgvDonHang.CurrentRow
                .Cells["MaPhieuDat"]
                .Value
            );
        }

        private int LayMaKH()
        {
            return Convert.ToInt32(
                dgvDonHang.CurrentRow
                .Cells["MaKH"]
                .Value
            );
        }
        private decimal LayTongTien()
        {
            return Convert.ToDecimal(
                dgvDonHang.CurrentRow
                .Cells["TongTien"]
                .Value
            );
        }
        private void UC_QuanLyDonHang_Load(object sender, EventArgs e)
        {

        }



        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn hàng!"
                );

                return;
            }

            int maDH =
                Convert.ToInt32(
                    dgvDonHang.CurrentRow
                    .Cells["MaPhieuDat"].Value
                );

            int maKH =
                Convert.ToInt32(
                    dgvDonHang.CurrentRow
                    .Cells["MaKH"].Value
                );

            decimal tongTien =
                Convert.ToDecimal(
                    dgvDonHang.CurrentRow
                    .Cells["TongTien"].Value
                );

            string hinhThucTT =
                dgvDonHang.CurrentRow
                .Cells["PhuongThucTT"]
                .Value.ToString();

            // TEST:
            int maNV = 0;

            DAL_DonHang dal =
                new DAL_DonHang();

            try
            {
                // 1 cập nhật trạng thái
                dal.CapNhatTrangThai(
                    maDH,
                    "Đã xác nhận"
                );

                // 2 tạo hóa đơn
                int maHD =
                    dal.TaoHoaDonTuDonHang(
                        maDH,
                        maKH,
                        maNV,
                        hinhThucTT,
                        tongTien
                    );

                // 3 chuyển CT đơn hàng
                dal.ChuyenCTDonHangSangHoaDon(
                    maDH,
                    maHD
                );

                // 4 trừ kho
                dal.TruKho(maDH);

                MessageBox.Show(
                    "Xác nhận đơn hàng thành công!"
                );

                LoadDonHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        private void btnDangGiao_Click_1(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn hàng!"
                );

                return;
            }

            int maDH =
                Convert.ToInt32(
                    dgvDonHang.CurrentRow
                    .Cells["MaPhieuDat"].Value
                );

            DAL_DonHang dal =
                new DAL_DonHang();

            try
            {
                dal.CapNhatTrangThai(
                    maDH,
                    "Đang giao"
                );

                MessageBox.Show(
                    "Đơn hàng đang được giao!"
                );

                LoadDonHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        private void btnHoanThanh_Click_1(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn hàng!"
                );

                return;
            }

            int maDH =
                Convert.ToInt32(
                    dgvDonHang.CurrentRow
                    .Cells["MaPhieuDat"].Value
                );

            int maKH =
                Convert.ToInt32(
                    dgvDonHang.CurrentRow
                    .Cells["MaKH"].Value
                );

            decimal tongTien =
                Convert.ToDecimal(
                    dgvDonHang.CurrentRow
                    .Cells["TongTien"].Value
                );

            DAL_DonHang dal =
                new DAL_DonHang();

            DAL_KhachHang dalKH =
                new DAL_KhachHang();

            try
            {
                // đổi trạng thái
                dal.CapNhatTrangThai(
                    maDH,
                    "Hoàn thành"
                );

                // cộng tiền tích lũy
                dalKH.congTienTichLuy(
                    maKH,
                    tongTien
                );

                MessageBox.Show(
                    "Giao hàng thành công!"
                );

                LoadDonHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvHuy.CurrentRow == null) return;

            try
            {
                int maHD = Convert.ToInt32(dgvHuy.CurrentRow.Cells["MaHD"].Value);
                int maTra = Convert.ToInt32(dgvHuy.CurrentRow.Cells["MaTra"].Value);
                decimal tongTienHoan = Convert.ToDecimal(dgvHuy.CurrentRow.Cells["TongTienHoan"].Value);

                dal.CapNhatTrangThaiTraHang(maTra, "Đã duyệt");

                dal.CongKhoKhiHuy(maHD);

                dal.TruTienTichLuyKhachHangTheoMaHD(maHD, tongTienHoan);

                int maPhieuDat = dal.LayMaPhieuDatTheoMaHD(maTra);
                if (maPhieuDat > 0)
                {
                    dal.CapNhatTrangThai(maPhieuDat, "Đã trả hàng");
                }
                MessageBox.Show("Xác nhận thành công! Sách đã hoàn kho và hệ thống đã khấu trừ tiền tích lũy của khách.");

                LoadDonHuy(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xử lý duyệt trả hàng: " + ex.Message);
            }
        }

        private void tabDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDonHang.SelectedIndex == 1) 
            {
                LoadDonHuy(); 
            }
            else 
            {
                LoadDonHang();
            }
        }
        private void LoadDonHuy()
        {
            DataTable dt = dal.LayDonYeuCauHuy();
           
            dgvHuy.DataSource = dt;
        }
    }
}

