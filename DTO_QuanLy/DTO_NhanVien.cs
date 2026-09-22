using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_NhanVien
    {
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string CaTruc { get; set; }
        public string DiaChi { get; set; }
        public string Gmail { get; set; }

        // Constructor dùng khi thêm mới (không cần mã nếu mã tự tăng) hoặc cập nhật
        public DTO_NhanVien(int ma, string ten, string sdt, string ca, string diachi, string gmail)
        {
            this.MaNhanVien = ma;
            this.HoTen = ten;
            this.SDT = sdt;
            this.CaTruc = ca;
            this.DiaChi=diachi;
            this.Gmail=gmail;
        }
    }
}
