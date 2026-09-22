using System;

namespace DTO_QuanLy
{
    public class DTO_Sach
    {
        
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int MaTheLoai { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public string TrangThai { get; set; }
        private string hinhAnh;
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public string MoTa { get; set; }

        public DTO_Sach() { }

        
        public DTO_Sach(string maSach, string tenSach, string tacGia,
                        int maTheLoai, decimal giaBan,
                        int soLuongTon, DateTime ngayNhapKho, string trangThai, string anh, string moTa)
        {
            MaSach = maSach;
            TenSach = tenSach;
            TacGia = tacGia;
            MaTheLoai = maTheLoai;
            GiaBan = giaBan;
            SoLuongTon = soLuongTon;
            NgayNhapKho = ngayNhapKho;
            TrangThai = trangThai;
            HinhAnh = anh;
            MoTa = moTa;
        }
    }
}