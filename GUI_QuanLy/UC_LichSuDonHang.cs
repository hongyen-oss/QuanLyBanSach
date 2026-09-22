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
    public partial class UC_LichSuDonHang : UserControl
    {
        DAL_DonHang dal =
            new DAL_DonHang();

        public UC_LichSuDonHang()
        {
            InitializeComponent();

            LoadDonHang();
            if (dgvDonHang.Columns["btnHoanThanh"] == null)
            {
                ThemNutHoanThanh();
            }

            if (dgvDonHang.Columns["btnTra"] == null)
            {
                ThemNutTraHang();
            }
            if (dgvDonHang.Columns["btnHuyDon"] == null)
            {
                ThemNutHuyDon();
            }
        
        }

        // load lịch sử đơn hàng
        private void LoadDonHang()
        {
            dgvDonHang.DataSource =
                dal.LayLichSuDonHang(
                    Session.MaKH
                );
        }
        private void ThemNutHoanThanh()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnHoanThanh";
            btn.HeaderText = "Xác nhận";
            btn.Text = "Đã nhận hàng";
            btn.UseColumnTextForButtonValue = true;
            dgvDonHang.Columns.Add(btn);
        }

        // thêm nút trả hàng
        private void ThemNutTraHang()
        {
            DataGridViewButtonColumn btn =
                new DataGridViewButtonColumn();

            btn.Name = "btnTra";

            btn.HeaderText = "Trả hàng";

            btn.Text = "Trả hàng";

            btn.UseColumnTextForButtonValue = true;

            dgvDonHang.Columns.Add(btn);
        }
        private void ThemNutHuyDon()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnHuyDon";
            btn.HeaderText = "Hủy đơn";
            btn.Text = "Hủy đơn";
            btn.UseColumnTextForButtonValue = true;
            dgvDonHang.Columns.Add(btn);
        }


        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDonHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvDonHang.Columns.Count == 0) return;

            object value = dgvDonHang.Rows[e.RowIndex].Cells["TrangThai"].Value;
            if (value == null) return;
            string trangThai = value.ToString();

            if (dgvDonHang.Columns[e.ColumnIndex].Name == "btnTra")
            {
                if (trangThai != "Hoàn thành")
                {
                    e.Value = "";
                }
            }

            if (dgvDonHang.Columns[e.ColumnIndex].Name == "btnHoanThanh")
            {
                if (trangThai != "Đang giao")
                {
                    e.Value = "";
                }
            }

            // Nút Hủy Đơn
            if (dgvDonHang.Columns[e.ColumnIndex].Name == "btnHuyDon")
            {
                if (trangThai == "Đang giao" || trangThai == "Hoàn thành" || trangThai == "Đã hủy" || trangThai == "Đã trả hàng")
                {
                    e.Value = "";
                }
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0 || e.ColumnIndex < 0 || dgvDonHang.Rows[e.RowIndex].IsNewRow) return;

            if (!dgvDonHang.Columns.Contains("TrangThai") || dgvDonHang.Rows[e.RowIndex].Cells["TrangThai"].Value == null)
            {
                return;
            }
            string trangThai = dgvDonHang.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString().Trim();


            //Hủy
            if (dgvDonHang.Columns[e.ColumnIndex].Name == "btnHuyDon")
            {
                if (trangThai == "Đang giao" || trangThai == "Hoàn thành" || trangThai == "Đã hủy")
                {
                    MessageBox.Show("Đơn hàng đã được giao hoặc đã hoàn tất, không thể hủy đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!dgvDonHang.Columns.Contains("MaPhieuDat") || !dgvDonHang.Columns.Contains("TongTien"))
                        {
                            MessageBox.Show("Lỗi: Không tìm thấy cột 'MaPhieuDat' hoặc 'TongTien' trong hệ thống DataGridView!", "Lỗi cấu hình cột", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int maPhieuDat = Convert.ToInt32(dgvDonHang.Rows[e.RowIndex].Cells["MaPhieuDat"].Value);
                        decimal tongTien = Convert.ToDecimal(dgvDonHang.Rows[e.RowIndex].Cells["TongTien"].Value);

                        dal.CapNhatTrangThai(maPhieuDat, "Đã hủy");

                        string phuongThucTT = "";
                        if (dgvDonHang.Columns.Contains("PhuongThucTT") && dgvDonHang.Rows[e.RowIndex].Cells["PhuongThucTT"].Value != null)
                        {
                            phuongThucTT = dgvDonHang.Rows[e.RowIndex].Cells["PhuongThucTT"].Value.ToString().Trim();
                        }
                        else
                        {
                            foreach (DataGridViewColumn col in dgvDonHang.Columns)
                            {
                                if (col.Name.Equals("PhuongThucTT", StringComparison.OrdinalIgnoreCase) && dgvDonHang.Rows[e.RowIndex].Cells[col.Index].Value != null)
                                {
                                    phuongThucTT = dgvDonHang.Rows[e.RowIndex].Cells[col.Index].Value.ToString().Trim();
                                    break;
                                }
                            }
                        }

                        if (phuongThucTT.Equals("Chuyển khoản", StringComparison.OrdinalIgnoreCase))
                        {
                            DAL_KhachHang dalKH = new DAL_KhachHang();
                            bool kqTruTien = dalKH.truTienTichLuy(Convert.ToInt32(Session.MaKH), tongTien);

                            if (kqTruTien)
                            {
                                MessageBox.Show("Hủy đơn thành công! Tiền tích lũy của khách hàng đã được hoàn trừ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Đã hủy đơn nhưng không thể trừ tiền tích lũy (Có thể sai tên cột trong bảng KhachHang)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hủy đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LoadDonHang(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hệ thống khi hủy đơn: " + ex.Message);
                    }
                }
                return;
            }
            // "ĐÃ NHẬN HÀNG"
            if (dgvDonHang.Columns[e.ColumnIndex].Name == "btnHoanThanh")
            {
                if (trangThai != "Đang giao")
                {
                    MessageBox.Show("Đơn hàng chưa được giao hoặc đã hoàn thành từ trước!");
                    return;
                }

                DialogResult dr = MessageBox.Show("Bạn xác nhận đã nhận được đầy đủ gói hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        int maPhieuDat = Convert.ToInt32(dgvDonHang.Rows[e.RowIndex].Cells["MaPhieuDat"].Value);
                        decimal tongTien = Convert.ToDecimal(dgvDonHang.Rows[e.RowIndex].Cells["TongTien"].Value);

                        dal.CapNhatTrangThai(maPhieuDat, "Hoàn thành");

                        // Cộng tiền tích lũy 
                        DAL_KhachHang dalKH = new DAL_KhachHang();
                        dalKH.congTienTichLuy(Session.MaKH, tongTien);

                        MessageBox.Show("Cảm ơn bạn đã mua hàng! Đơn hàng đã hoàn thành.");

                        
                        LoadDonHang();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xử lý đơn hàng: " + ex.Message);
                    }
                }
                return; 
            }

            // NÚT TRẢ HÀNG
            if (dgvDonHang.Columns[e.ColumnIndex].Name == "btnTra")
            {
                if (trangThai != "Hoàn thành")
                {
                    MessageBox.Show("Chỉ được trả đơn hoàn thành!");
                    return;
                }

                int maPhieuDat = Convert.ToInt32(dgvDonHang.Rows[e.RowIndex].Cells["MaPhieuDat"].Value);
                int maHD = dal.LayMaHDTheoDonHang(maPhieuDat);

                if (maHD <= 0)
                {
                    MessageBox.Show("Đơn hàng chưa có hóa đơn!");
                    return;
                }

                Form1.instance.LoadControl(new UC_Trahang(maHD));
            }
        }

        
        

        private void UC_LichSuDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
