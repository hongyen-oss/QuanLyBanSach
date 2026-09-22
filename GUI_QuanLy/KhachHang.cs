using BUS_QuanLy;
using BUS_QuanLy;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Data.SqlClient; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI_QuanLy
{
    public partial class KhachHang : Form
    {
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        public KhachHang()
        {
            InitializeComponent();
            LoadComboBoxDiaChi();
        }
        private void HienThiDanhSachKH()
        {
            try
            {
                DataTable dt = busKhachHang.getKhachHang();

                if (dt != null)
                {
                    // Vòng lặp kiểm tra từng khách hàng trong bảng dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["TongTienTichLuy"] != DBNull.Value)
                        {
                            decimal tichLuy = Convert.ToDecimal(row["TongTienTichLuy"]);
                            bool daCoVoucher = row["Voucher"] != DBNull.Value && Convert.ToBoolean(row["Voucher"]);

                            if (tichLuy > 300000 && !daCoVoucher)
                            {
                                int maKH = Convert.ToInt32(row["MaKH"]);

                                DAL_KhachHang dalKH = new DAL_KhachHang();
                                dalKH.CapNhatVoucherTuDong(maKH);

                               
                                row["Voucher"] = true;
                            }
                        }
                    }
                }
                dgvKH.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tự động quét và nạp dữ liệu khách hàng: " + ex.Message);
            }
        }
        private void LoadComboBoxDiaChi()
        {
            string[] tinhThanh = {"An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bạc Liêu", "Bắc Ninh",
                                    "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau",
                                       "Cần Thơ", "Cao Bằng", "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai",
                                        "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương",
                                         "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hưng Yên","Thành phố Hồ Chí Minh", "Khánh Hòa", "Kiên Giang"
                                         };

            cboDiaChi.DataSource = tinhThanh;
            cboDiaChi.SelectedIndex = -1; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtGmail.Text = row.Cells["Email"].Value.ToString();
                txtTich_Luy.Text = row.Cells["TongTienTichLuy"].Value.ToString();
                cboDiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                // Xử lý checkbox voucher
                if (row.Cells["Voucher"].Value != DBNull.Value)
                    chkVoucher.Checked = Convert.ToBoolean(row.Cells["Voucher"].Value);
                else
                    chkVoucher.Checked = false;
            }
        }
        // Xem
        private void button1_Click(object sender, EventArgs e)
        {
         //   dgvKH.DataSource = busKhachHang.getKhachHang(); 
            HienThiDanhSachKH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên và số điện thoại!");
                    return;
                }

                if (cboDiaChi.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn địa chỉ tỉnh thành!");
                    return;
                }

                decimal tichLuy;
                if (!decimal.TryParse(txtTich_Luy.Text, out tichLuy))
                {
                    tichLuy = 0; 
                }

                DTO_KhachHang kh = new DTO_KhachHang(
                    0,
                    txtHoTen.Text.Trim(),
                    txtSDT.Text.Trim(),
                    txtGmail.Text.Trim(),
                    cboDiaChi.Text, 
                    tichLuy,
                    chkVoucher.Checked
                );
                if (busKhachHang.themKH(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    dgvKH.DataSource = busKhachHang.getKhachHang(); 
                    LamMoi(); 
                }
                else
                {
                    MessageBox.Show("Thêm thất bại, vui lòng kiểm tra lại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }
        // Xóa
       /* private void button4_Click(object sender, EventArgs e)
        {
            {
                if (dgvKH.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvKH.SelectedRows[0];
                    string maKH = row.Cells[0].Value.ToString();

                    if (busKhachHang.xoaKhachHang(maKH))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvKH.DataSource = busKhachHang.getKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn khách hàng muốn xóa");
                }
            }
        }
       */
        private void KhachHang_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKH();
        }
        // Sửa
        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvKH.CurrentRow == null || dgvKH.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa từ danh sách!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
                txtHoTen.Focus();
                return;
            }

            if (cboDiaChi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn địa chỉ tỉnh thành!");
                return;
            }

            try
            {
                int maKH = Convert.ToInt32(dgvKH.CurrentRow.Cells["MaKH"].Value);

                decimal tichLuy;
                if (!decimal.TryParse(txtTich_Luy.Text, out tichLuy))
                {
                    tichLuy = 0;
                }

                DTO_KhachHang kh = new DTO_KhachHang(
                    maKH,
                    txtHoTen.Text.Trim(),
                    txtSDT.Text.Trim(),
                    txtGmail.Text.Trim(),
                    cboDiaChi.Text,
                    tichLuy,
                    chkVoucher.Checked
                );
                if (busKhachHang.suaKhachHang(kh))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                    dgvKH.DataSource = busKhachHang.getKhachHang(); // Load lại bảng
                    LamMoi(); 
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng kiểm tra lại kết nối!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi: " + ex.Message);
            }
        }


        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];

                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtGmail.Text = row.Cells["Email"].Value.ToString();
                txtTich_Luy.Text = row.Cells["TongTienTichLuy"].Value.ToString();
                cboDiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                if (row.Cells["Voucher"].Value != DBNull.Value)
                {
                    chkVoucher.Checked = Convert.ToBoolean(row.Cells["Voucher"].Value);
                }
                else
                {
                    chkVoucher.Checked = false;
                }
            }
        }
        
        
        private void LamMoi()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtGmail.Clear();
            txtTich_Luy.Text = "0";
            chkVoucher.Checked = false;
            cboDiaChi.SelectedIndex = -1;
            chkVoucher.Checked = false;
            txtHoTen.Focus();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }
    }
}

