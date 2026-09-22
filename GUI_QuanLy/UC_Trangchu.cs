using BUS_QuanLy;
using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLy
{

    public partial class UC_Trangchu : UserControl
    {

        public UC_Trangchu()
        {
            InitializeComponent();
        }
        BUS_Sach busSach = new BUS_Sach();
        

        private void UC_Trangchu_Load(object sender, EventArgs e)
        {

            LoadDataSach();
            LoadTheLoai();
        }
        private void LoadTheLoai()
        {
            DAL_TheLoai dal =
                new DAL_TheLoai();

            DataTable dt =
                dal.getTheLoai();

            DataRow dr = dt.NewRow();

            dr["MaTheLoai"] = 0;
            dr["TenTheLoai"] = "Tất cả";

            dt.Rows.InsertAt(dr, 0);

            cboTheLoai.DataSource = dt;

            cboTheLoai.DisplayMember =
                "TenTheLoai";

            cboTheLoai.ValueMember =
                "MaTheLoai";
        }
        private void LoadSachTheoTheLoai(int maTL)
        {

            DAL_Sach dal = new DAL_Sach();

            DataTable dt;

            if (maTL == 0)
            {
                dt = dal.getSach();
            }
            else
            {
                dt = dal.TimSachTheoTheLoai(maTL);
            }

            flpDanhSachSach.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ucSach item = new ucSach();

                string ma = row["MaSach"].ToString();
                string ten = row["TenSach"].ToString();
                string tacGia = row["TacGia"].ToString();
                int maLoai = Convert.ToInt32(row["MaTheLoai"]);
                decimal gia = Convert.ToDecimal(row["GiaBan"]);
                int slTon = Convert.ToInt32(row["SoLuongTon"]);
                DateTime ngayNhap = Convert.ToDateTime(row["NgayNhapKho"]);
                string trangThai = row["TrangThai"].ToString();
                string anh = row["HinhAnh"].ToString();
                string moTa = row["MoTa"].ToString();

                item.DoDuLieu(
                    ma,
                    ten,
                    gia.ToString("N0"),
                    anh
                );

                DTO_Sach sachDTO =
                    new DTO_Sach(
                        ma,
                        ten,
                        tacGia,
                        maLoai,
                        gia,
                        slTon,
                        ngayNhap,
                        trangThai,
                        anh,
                        moTa
                    );

                item.Tag = sachDTO;

                item.Click += itemSach_Click;

                flpDanhSachSach.Controls.Add(item);
            }
        }


        public void LoadDataSach(string keyword = "")
        {
            DataTable dt;
            if (string.IsNullOrEmpty(keyword))
                dt = busSach.getSach(); // Lấy tất cả
            else
                dt = busSach.timKiemSach(keyword); // Lấy theo từ khóa

            flpDanhSachSach.Controls.Clear();
            // DataTable dt = busSach.getSach();
            // flpDanhSachSach.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ucSach item = new ucSach();

                string ma = row["MaSach"].ToString();
                string ten = row["TenSach"].ToString();
                string tacGia = row["TacGia"].ToString();
                int maLoai = Convert.ToInt32(row["MaTheLoai"]);
                decimal gia = Convert.ToDecimal(row["GiaBan"]);
                int slTon = Convert.ToInt32(row["SoLuongTon"]);
                DateTime ngayNhap = Convert.ToDateTime(row["NgayNhapKho"]);
                string trangThai = row["TrangThai"].ToString();
                string anh = row["HinhAnh"].ToString();
                string moTa = row["MoTa"].ToString();
                item.DoDuLieu(ma, ten, gia.ToString("N0") + " VNĐ", anh);

                DTO_Sach sachDTO = new DTO_Sach(ma, ten, tacGia, maLoai, gia, slTon, ngayNhap, trangThai, anh, moTa);

                item.Tag = sachDTO;
                item.Click += itemSach_Click;

                flpDanhSachSach.Controls.Add(item);
            }
        }


        private void itemSach_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            DTO_Sach data = null;
            if (control is ucSach)
                data = (DTO_Sach)control.Tag;
            else
                data = (DTO_Sach)control.Parent.Tag;

            if (data != null)
            {
                infobook frm = new infobook(data);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }


        private void btnSach_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flpDanhSachSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void flpDanhSachSach_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            // Gọi hàm đã có sẵn và truyền tham số vào
            LoadDataSach(keyword);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataSach(txtSearch.Text.Trim());

        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTheLoai.SelectedValue == null)
                return;

            if (cboTheLoai.SelectedValue is DataRowView)
                return;

            int maTL =
                Convert.ToInt32(cboTheLoai.SelectedValue);

            LoadSachTheoTheLoai(maTL);
        }
    }
}
