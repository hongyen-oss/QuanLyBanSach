using BUS_QuanLy;
using DAL_QuanLy;
using DTO_QuanLy;
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

namespace GUI_QuanLy
{
    public partial class GUI_Sach : Form
    {
        string sourceFilePath = "";
        string selectedFileName = "";
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_Sach busSach = new BUS_Sach();
        BUS_TheLoai busTheLoai = new BUS_TheLoai();
        public GUI_Sach()
        {
            InitializeComponent();
            LoadComboBoxTheLoai();
        }
        private void LoadComboBoxTheLoai()
        {
            DataTable dt = busTheLoai.getTheLoai();
            if (dt != null && dt.Rows.Count > 0)
            {
                cboMaTheLoai.DataSource = dt;


                cboMaTheLoai.DisplayMember = "TenTheLoai";
                cboMaTheLoai.ValueMember = "MaTheLoai";

                cboMaTheLoai.SelectedIndex = -1;
            }
        }
        private void dgvSach_Click(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSach.SelectedRows[0];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtTacGia.Text = row.Cells[2].Value.ToString();
                cboMaTheLoai.Text = row.Cells[3].Value.ToString();
                txtGiaBan.Text = row.Cells[4].Value.ToString();
                txtSoLuongTon.Text = row.Cells[5].Value.ToString();
                dtpNgayNhap.Value = Convert.ToDateTime(row.Cells[6].Value);
                txtTrangThai.Text = row.Cells[7].Value.ToString();
                txtMoTa.Text = row.Cells[8].Value.ToString();


            }
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            
            dgvSach.DataSource = busSach.getSach();
        }
        private void GUI_Sach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = busSach.getSach();
            txtSoLuongTon.Clear();
            txtTrangThai.Clear();
            txtMoTa.Clear();
        }

        private void btnThem_Click_1(object sender, EventArgs e)

        {
            if (cboMaTheLoai.SelectedValue != null)
            {
               
                string maDuocChon = cboMaTheLoai.SelectedValue.ToString();
                Console.WriteLine("Mã bạn chọn để lưu là: " + maDuocChon);
            }
            BUS_TheLoai busTheLoai = new BUS_TheLoai();
            BUS_KhachHang busKhachHang = new BUS_KhachHang();
            BUS_ThongBao busTB = new BUS_ThongBao();

            try
            {

                string maSach = txtMaSach.Text.Trim();
                string tenSach = txtTenSach.Text.Trim();
                string tacGia = txtTacGia.Text.Trim();

               
                if (cboMaTheLoai.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một thể loại từ danh sách!");
                    return;
                }
                int maTL = Convert.ToInt32(cboMaTheLoai.SelectedValue);

                if (!busTheLoai.kiemTraTonTai(maTL.ToString()))
                {
                    MessageBox.Show("Mã thể loại này không tồn tại trong hệ thống!");
                    return;
                }

                decimal giaBan = decimal.Parse(txtGiaBan.Text.Trim());
                int soLuong = int.Parse(txtSoLuongTon.Text.Trim());
                DateTime ngayNhap = dtpNgayNhap.Value;

                if (!string.IsNullOrEmpty(sourceFilePath))
                {
                    string projectPath = Application.StartupPath + @"\Images\";
                    if (!Directory.Exists(projectPath)) Directory.CreateDirectory(projectPath);

                    string destFilePath = Path.Combine(projectPath, selectedFileName);

                    if (!File.Exists(destFilePath))
                    {
                        File.Copy(sourceFilePath, destFilePath);
                    }
                }
                else
                {
                    // Nếu không chọn ảnh, có thể gán một ảnh mặc định
                    selectedFileName = "no_image.png";
                }
                string moTa = txtMoTa.Text;

                DTO_Sach s = new DTO_Sach(
                    maSach,
                    tenSach,
                    tacGia,
                    maTL,
                    giaBan,
                    soLuong,
                    ngayNhap,
                    txtTrangThai.Text,
                    selectedFileName,
                    moTa
                );

                if (busSach.themSach(s))
                {
                    var dsKH = busKhachHang.LayKhachTheoTheLoai(maTL.ToString());

                    foreach (int maKH in dsKH)
                    {
                        busTB.GuiThongBao(maKH, tenSach);
                    }

                    MessageBox.Show("Thêm sách thành công!");


                    sourceFilePath = "";
                    selectedFileName = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private decimal tinhGiaBanSauGiam(DataRow rowSach)
        {
            decimal giaGoc = Convert.ToDecimal(rowSach["GiaBan"]);
            DateTime ngayNhap = Convert.ToDateTime(rowSach["NgayNhapKho"]);

            // Tính số ngày chênh lệch giữa hiện tại và ngày nhập kho
            TimeSpan diff = DateTime.Now - ngayNhap;

            if (diff.TotalDays > 30)
            {
                // Giảm 15%
                return giaGoc * 0.85m;
            }
            return giaGoc;
        }
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (cboMaTheLoai.SelectedValue != null)
            {
                // Lấy mã thể loại (ví dụ: "TL01" hoặc số 1 tùy kiểu dữ liệu DB)
                string maDuocChon = cboMaTheLoai.SelectedValue.ToString();

                // Dùng mã này để truyền vào hàm Insert hoặc Update
                Console.WriteLine("Mã bạn chọn để lưu là: " + maDuocChon);
            }
            string path = Application.StartupPath + "\\Images\\" + selectedFileName;
            if (System.IO.File.Exists(path))
            {
                picSach.Image = Image.FromFile(path);
            }
            else
            {
                picSach.Image = null; // Hoặc ảnh mặc định
            }
            if (dgvSach.SelectedRows.Count > 0)
            {
                if (txtMaSach.Text != "" && txtTenSach.Text != "")
                {
                    DTO_Sach s = new DTO_Sach(
                        txtMaSach.Text,
                        txtTenSach.Text,
                        txtTacGia.Text,
                        Convert.ToInt32(cboMaTheLoai.SelectedValue),
                        decimal.Parse(txtGiaBan.Text),
                        int.Parse(txtSoLuongTon.Text),
                        dtpNgayNhap.Value,
                        txtTrangThai.Text,
                        selectedFileName,
                        txtMoTa.Text

                    );

                    if (busSach.suaSach(s))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvSach.DataSource = busSach.getSach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn cuốn sách muốn sửa");
            }

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            {
                if (dgvSach.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvSach.SelectedRows[0];
                    string maSach = row.Cells[0].Value.ToString();

                    if (busSach.xoaSach(maSach))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvSach.DataSource = busSach.getSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn cuốn sách muốn xóa");
                }
            }

        }
        private void txtSoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void GUI_Sach_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void txtSoLuongTon_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuongTon.Text))
            {
                txtTrangThai.Text = "";
                return;
            }

            if (int.TryParse(txtSoLuongTon.Text, out int soLuong))
            {
                if (soLuong > 0)
                {
                    txtTrangThai.Text = "Còn hàng";
                    txtTrangThai.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    txtTrangThai.Text = "Hết hàng";
                    txtTrangThai.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                txtTrangThai.Text = "Không hợp lệ";
                txtTrangThai.ForeColor = System.Drawing.Color.Orange;
            }
        }

        private void txtTrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCHonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sourceFilePath = ofd.FileName;

                    selectedFileName = System.IO.Path.GetFileName(ofd.FileName);

                    picSach.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void dgvSach_Click_1(object sender, EventArgs e)
        {
            if (dgvSach.CurrentRow != null)
            {
                DataGridViewRow row = dgvSach.CurrentRow;

                txtMaSach.Text = row.Cells["MaSach"].Value?.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value?.ToString();
                cboMaTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value;
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                if (row.Cells["NgayNhapKho"].Value != null)
                {
                    dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["NgayNhapKho"].Value);
                }

                // XỬ LÝ HÌNH ẢNH
                try
                {
                    var cellValue = row.Cells["HinhAnh"].Value;
                    if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                    {
                        string tenFile = cellValue.ToString().Trim();

                        string thuMucAnh = Path.Combine(Application.StartupPath, "Images");
                        string duongDanFull = Path.Combine(thuMucAnh, tenFile);

                        if (File.Exists(duongDanFull))
                        {
                            using (FileStream fs = new FileStream(duongDanFull, FileMode.Open, FileAccess.Read))
                            {
                                picSach.Image = Image.FromStream(fs);
                            }
                            picSach.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            picSach.Image = null;
                            MessageBox.Show("Thiếu file: " + duongDanFull);
                        }
                    }
                    else
                    {
                        picSach.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load ảnh: " + ex.Message);
                    picSach.Image = null;
                }
            }
        }

        private void cboMaTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaTheLoai.SelectedValue != null && cboMaTheLoai.ValueMember != "")
            {
                try
                {
                    // Lấy mã số an toàn
                    int ma = Convert.ToInt32(cboMaTheLoai.SelectedValue);
                }
                catch { }
            }
        }
    }

}
