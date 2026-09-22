using BUS_QuanLy;
using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace GUI_QuanLy
{

    public partial class GUI_HoaDon : Form
    {

        BUS_Sach busSach = new BUS_Sach();
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_HoaDon busHD = new BUS_HoaDon();

        DataTable dtSach = new DataTable();
        DataTable dtChiTiet = new DataTable();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        private DAL_Voucher dalVoucher = new DAL_Voucher();

        int maKH = -1;
        int maNV;

        private int userRole;


        public GUI_HoaDon(int role)
        {
            InitializeComponent();
            this.userRole = role;

        }
        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvChiTiet.Columns["btnXoa"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dtChiTiet.Rows.RemoveAt(e.RowIndex);

                    tinhTongTien();
                }
            }
        }
        private void GUI_HoaDon_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = Session.MaNhanVien.ToString();
            txtMaNV.ReadOnly = true;

            if (this.userRole == 1) // Nếu là Admin
            {
                tabControl1.SelectedTab = tabPage2;
                btnXem_Click(sender, e);
            }

            dtSach = busSach.getSach();

            // Khởi tạo các cột dữ liệu
            dtChiTiet.Columns.Add("MaSach");
            dtChiTiet.Columns.Add("TenSach");
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("GiaBan", typeof(decimal));
            dtChiTiet.Columns.Add("DonGia", typeof(decimal));
            dtChiTiet.Columns.Add("TongTien", typeof(decimal));

            dgvChiTiet.DataSource = dtChiTiet;

            // --- THÊM CỘT NÚT XÓA TẠI ĐÂY ---
            if (!dgvChiTiet.Columns.Contains("btnXoa"))
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                btnXoa.HeaderText = "Thao tác";
                btnXoa.Text = "Xóa";
                btnXoa.Name = "btnXoa";
                btnXoa.UseColumnTextForButtonValue = true;
                dgvChiTiet.Columns.Add(btnXoa);
            }
            // ---------------------------------

            cboThanhToan.Items.Add("Tiền mặt");
            cboThanhToan.Items.Add("Chuyển khoản");
            cboThanhToan.Items.Add("Momo");
            cboThanhToan.SelectedIndex = 0;

            XoaaTrangVoucherKhachHang();
        }
        private void DocSoTienThanhToan(double tongTien)
        {
            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Volume = 100;
                synth.Rate = 0;

                bool đãChọnGiọngViệt = false;
                string câuNói = $"Nhà sách xin cảm ơn. Quý khách đã thanh toán {tongTien} đồng";

                foreach (var voice in synth.GetInstalledVoices())
                {
                    var info = voice.VoiceInfo;

                    if (info.Culture.Name.Contains("vi") ||
                        info.Description.Contains("Vietnamese") ||
                        info.Name.Contains("An") ||
                        info.Name.Contains("OneCore"))
                    {
                        try
                        {
                            synth.SelectVoice(info.Name);
                            đãChọnGiọngViệt = true;
                            break;
                        }
                        catch { }
                    }
                }
                if (!đãChọnGiọngViệt)
                {
                    if (synth.GetInstalledVoices().Count > 0)
                    {
                        synth.SelectVoice(synth.GetInstalledVoices()[0].VoiceInfo.Name);
                    }
                    string câuNóiTiếngAnh = $"Thank you. Total payment is {tongTien} VND";
                    synth.SpeakAsync(câuNóiTiếngAnh);

                    Console.WriteLine("Hệ thống đang dùng giọng mặc định thay thế do Windows ẩn giọng Việt.");
                }
                else
                {
                    synth.SpeakAsync(câuNói);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực tế tại hệ thống âm thanh: " + ex.Message, "Thông báo lỗi");
            }
        }
       


        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            if (sdt == "")
            {
                txtTenKH.Text = "Khách lẻ không số";
                maKH = 0;
                XoaaTrangVoucherKhachHang();
                tinhTongTien();
                return;
            }

            var kh = busKH.getBySDT(sdt);

            if (kh != null)
            {
                txtTenKH.Text = kh.HoTen;
                maKH = kh.MaKH;

                NapVoucherKhachHang(maKH);
            }
            else
            {
                // Chưa đủ 10 số thì không tạo
                if (sdt.Length < 10)
                {
                    txtTenKH.Text = "Chưa đủ số điện thoại";
                    maKH = 0;
                    return;
                }

                maKH = busKH.taoKhachTuDong(sdt);

                txtTenKH.Text = "Khách lẻ (" + sdt + ")";

                XoaaTrangVoucherKhachHang();
            }

            tinhTongTien();
        }



        private void NapVoucherKhachHang(int maKhach)
        {
            try
            {
                dalVoucher.KiemTraVaPhatVoucherTuDong(maKhach);
                DataTable dt = dalVoucher.LayVoucherKhaDungCuaKhach(maKhach);

                DataRow dr = dt.NewRow();
                dr["MaVoucher"] = 0;
                dr["TenVoucher"] = "Không áp dụng Voucher ";
                dr["PhanTramGiam"] = 0;
                dr["DieuKienApDung"] = 0;
                dt.Rows.InsertAt(dr, 0);

                cboVoucher.DataSource = dt;
                cboVoucher.DisplayMember = "TenVoucher";
                cboVoucher.ValueMember = "MaVoucher";
                cboVoucher.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách mã ưu đãi: " + ex.Message);
            }
        }
        private void XoaaTrangVoucherKhachHang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaVoucher", typeof(int));
            dt.Columns.Add("TenVoucher", typeof(string));
            dt.Columns.Add("PhanTramGiam", typeof(int));
            dt.Columns.Add("DieuKienApDung", typeof(decimal));

            DataRow dr = dt.NewRow();
            dr["MaVoucher"] = 0;
            dr["TenVoucher"] = "Không áp dụng Voucher ";
            dr["PhanTramGiam"] = 0;
            dr["DieuKienApDung"] = 0;
            dt.Rows.Add(dr);

            cboVoucher.DataSource = dt;
            cboVoucher.DisplayMember = "TenVoucher";
            cboVoucher.ValueMember = "MaVoucher";
            cboVoucher.SelectedIndex = 0;
        }
        void hienSach()
        {
            string maSach = txtMaSach.Text.Trim();

            foreach (DataRow row in dtSach.Rows)
            {
                if (row["MaSach"].ToString() == maSach)
                {
                    txtTenSach.Text = row["TenSach"].ToString();

                    decimal giaBan = Convert.ToDecimal(row["GiaBan"]);
                    txtGiaBan.Text = giaBan.ToString();

                    txtSoLuong.Text = "1";
                    txtDonGia.Text = giaBan.ToString(); // 1 cuốn

                    return;
                }
            }

            MessageBox.Show("Không tìm thấy sách!");
        }

        private void txtMaSach_Leave(object sender, EventArgs e)
        {

        }

        private void txtMaSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                hienSach();
                btnThem.PerformClick();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtGiaBan.Text, out decimal giaBan) &&
                int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                txtDonGia.Text = (giaBan * soLuong).ToString();
            }
        }
        private void txtDonGia_TextChanged_1(object sender, EventArgs e)
        { }
        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                string maSach = txtMaSach.Text.Trim();
                string tenSach = txtTenSach.Text;

                if (maSach == "" || tenSach == "")
                {
                    MessageBox.Show("Nhập mã sách!");
                    return;
                }

                if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng sai!");
                    return;
                }

                decimal giaBan = Convert.ToDecimal(txtGiaBan.Text);
                decimal tongTien = giaBan * soLuong;


                foreach (DataRow s in dtSach.Rows)
                {
                    if (s["MaSach"].ToString() == maSach)
                    {
                        int ton = Convert.ToInt32(s["SoLuongTon"]);
                        if (soLuong > ton)
                        {
                            MessageBox.Show($"Kho còn {ton}");
                            return;
                        }
                        break;
                    }
                }

                foreach (DataRow r in dtChiTiet.Rows)
                {
                    if (r["MaSach"].ToString() == maSach)
                    {
                        int slCu = Convert.ToInt32(r["SoLuong"]);
                        int slMoi = slCu + soLuong;

                        decimal thanhTienMoi = slMoi * giaBan;

                        r["SoLuong"] = slMoi;
                        r["DonGia"] = thanhTienMoi;
                        r["TongTien"] = thanhTienMoi;

                        tinhTongTien();
                        return;
                    }
                }

                decimal donGia = giaBan * soLuong;

                dtChiTiet.Rows.Add(
                    maSach,
                    tenSach,
                    soLuong,
                    giaBan,
                    donGia,
                    donGia
                );

                tinhTongTien();

                txtMaSach.Clear();
                txtTenSach.Clear();
                txtGiaBan.Clear();
                txtDonGia.Clear();
                txtSoLuong.Clear(); // 
                txtMaSach.Focus();


                void tinhTongTien()
                {
                    decimal tong = 0;

                    foreach (DataRow row in dtChiTiet.Rows)
                    {
                        if (row["DonGia"] != DBNull.Value)
                            tong += Convert.ToDecimal(row["DonGia"]);
                    }

                    txtTongTien.Text = tong.ToString("N0");
                }
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
             if (maKH == -1)
             {
                 MessageBox.Show("Chọn khách hàng!");
                 return;
             }

             if (dtChiTiet.Rows.Count == 0)
             {
                 MessageBox.Show("Chưa có sản phẩm!");
                 return;
             }

             if (!int.TryParse(txtMaNV.Text, out int maNV))
             {
                 MessageBox.Show("Mã nhân viên sai!");
                 return;
             }


            // LẤY TỔNG THANH TOÁN CUỐI

            decimal tongTien = 0;

            string tienText = lblTongThanhToan.Text
                .Replace("VNĐ", "")
                .Replace(",", "")
                .Replace(".", "")
                .Trim();

            if (!decimal.TryParse(tienText, out tongTien))
            {
                MessageBox.Show("Không đọc được tổng thanh toán!");
                return;
            }
            MessageBox.Show("Tổng thanh toán = " + tongTien);

            // TẠO HÓA ĐƠN

            DTO_HoaDon hd = new DTO_HoaDon(
                0,
                dtpNgayLap.Value,
                maKH,
                maNV,
                cboThanhToan.Text,
                tongTien
            );

            List<DTO_ChiTietHoaDon> list = new List<DTO_ChiTietHoaDon>();

            foreach (DataRow row in dtChiTiet.Rows)
            {
                list.Add(new DTO_ChiTietHoaDon
                {
                    MaSach = row["MaSach"].ToString(),
                    SoLuong = Convert.ToInt32(row["SoLuong"]),
                    DonGia = Convert.ToDecimal(row["DonGia"])
                });
            }
            // LƯU HÓA ĐƠN

            if (busHD.themHoaDonFull(hd, list))
            {
                // CỘNG TÍCH LŨY

                if (maKH > 0)
                {
                    dalVoucher.KiemTraVaPhatVoucherTuDong(maKH);
                }
                DocSoTienThanhToan(Convert.ToDouble(tongTien));
                MessageBox.Show("Thanh toán thành công!");

                // RESET FORM
                dtChiTiet.Clear();

                txtTongTien.Text = "0";
                lblTongThanhToan.Text = "0 VNĐ";
                lblTienGiam.Text = "-0 VNĐ";

                txtSDT.Clear();
                txtTenKH.Clear();

                maKH = -1;

                cboVoucher.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Lưu thất bại!");
            }
        }
        void tinhTongTien()
        {
            decimal tongTienSachGoc = 0;

            // Tính tổng tiền sách
            foreach (DataRow row in dtChiTiet.Rows)
            {
                if (row["DonGia"] != DBNull.Value)
                {
                    tongTienSachGoc += Convert.ToDecimal(row["DonGia"]);
                }
            }

            // Hiển thị tổng tiền gốc
            txtTongTien.Text = tongTienSachGoc.ToString("N0");

            decimal soTienDuocGiam = 0;

            // Kiểm tra voucher
            if (cboVoucher.SelectedIndex > 0 && cboVoucher.SelectedItem != null)
            {
                DataRowView selectedVoucher = (DataRowView)cboVoucher.SelectedItem;

                decimal dieuKien =
                    Convert.ToDecimal(selectedVoucher["DieuKienApDung"]);

                int phanTramGiam =
                    Convert.ToInt32(selectedVoucher["PhanTramGiam"]);

                if (tongTienSachGoc >= dieuKien)
                {
                    soTienDuocGiam =
                        tongTienSachGoc * phanTramGiam / 100;
                }
                else
                {
                    MessageBox.Show(
                        $"Đơn hàng chưa đạt tối thiểu {dieuKien:N0} VNĐ",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    cboVoucher.SelectedIndex = 0;
                    return;
                }
            }

            // Tổng cuối cùng sau giảm
            decimal tongThanhToanCuoiCung =
                tongTienSachGoc - soTienDuocGiam;

            // Hiển thị tiền giảm
            lblTienGiam.Text =
                "-" + soTienDuocGiam.ToString("N0") + " VNĐ";

            // Hiển thị tổng thanh toán cuối
            lblTongThanhToan.Text =
                 tongThanhToanCuoiCung.ToString("N0") + " VNĐ";



        }
        private bool timSach(string maSach)
        {
            foreach (DataRow row in dtSach.Rows)
            {
                if (row["MaSach"].ToString().Trim() == maSach)
                {
                    txtTenSach.Text = row["TenSach"].ToString();

                    decimal giaBan = Convert.ToDecimal(row["GiaBan"]);
                    txtGiaBan.Text = giaBan.ToString();
                    txtSoLuong.Text = "1";
                    txtDonGia.Text = giaBan.ToString();

                    return true;
                }
            }
            return false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            try
            {

                if (busHD == null) busHD = new BUS_HoaDon();

                DataTable dt = busHD.getHoaDon();

                if (dt != null)
                {

                    dgvHoaDon.DataSource = dt;

                    if (dgvHoaDon.Columns.Contains("MaHD"))
                        dgvHoaDon.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";

                    if (dgvHoaDon.Columns.Contains("NgayLap"))
                        dgvHoaDon.Columns["NgayLap"].HeaderText = "Ngày Lập";

                    if (dgvHoaDon.Columns.Contains("MaKH"))
                        dgvHoaDon.Columns["MaKH"].HeaderText = "Mã Khách";

                    if (dgvHoaDon.Columns.Contains("MaNV"))
                        dgvHoaDon.Columns["MaNV"].HeaderText = "Mã NV";

                    if (dgvHoaDon.Columns.Contains("HinhThucTT"))
                        dgvHoaDon.Columns["HinhThucTT"].HeaderText = "Hình Thức TT";

                    if (dgvHoaDon.Columns.Contains("TongTien"))
                        dgvHoaDon.Columns["TongTien"].HeaderText = "Tổng Tiền";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThemMoi_Click_1(object sender, EventArgs e)
        {


        }

        private void GUI_DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            BUS_HoaDon busHD = new BUS_HoaDon();
            DataTable dt = busHD.getHoaDon();

            if (dt != null)
            {
                dgvHoaDon.DataSource = dt;

                if (dgvHoaDon.Columns.Count > 4)
                {
                    dgvHoaDon.Columns[0].HeaderText = "Mã HĐ";
                    dgvHoaDon.Columns[4].HeaderText = "Tổng Tiền";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMaSach_Leave_1(object sender, EventArgs e)
        {
            hienSach();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            dtChiTiet.Clear();
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaBan.Clear();
            txtDonGia.Clear();
            txtTongTien.Text = "0";
            txtSDT.Clear();
            txtTenKH.Clear();
            maKH = -1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cboVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTongTien();
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.userRole == 1 && tabControl1.SelectedTab == tabPage1)
            {
                tabControl1.SelectedTab = tabPage2;
                return;
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                btnXem_Click(sender, e);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        // Hàm dùng chung cho mọi nơi trong Form
        private void UpdateQRCode()
        {
            // 1. Kiểm tra điều kiện hiển thị (nếu cần)
            if (cboThanhToan.Text != "Chuyển khoản" && cboThanhToan.Text != "Momo")
            {
                picQR.Visible = false;
                return;
            }

            picQR.Visible = true;

            string bank = "970422";
            string stk = "9230666868";
            string template = "compact2";
            string accountName = "VO HONG YEN";

            string amount = new string(lblTongThanhToan.Text.Where(char.IsDigit).ToArray());
            string noidung = txtMaHD.Text.Trim();

            if (string.IsNullOrEmpty(noidung)) noidung = "CONG TY SACH ABYSTORE";

            string url = $"https://img.vietqr.io/image/MB-93230666868-compact2.png?amount={amount}&addInfo={Uri.EscapeDataString(noidung)}";

            picQR.SizeMode = PictureBoxSizeMode.Zoom;
            picQR.ImageLocation = url;
        }
        private void cboThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateQRCode();
        }

        private void lblTongThanhToan_TextChanged(object sender, EventArgs e)
        {
            UpdateQRCode();
        }
    }
}

