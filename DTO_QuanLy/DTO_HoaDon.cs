using System;

namespace DTO_QuanLy
{
    public class DTO_HoaDon
    {
        public int MaKH { get; set; } 
        public DateTime NgayLap { get; set; }
        public int MaHD { get; set; }
        public string HinhThucTT { get; set; }
        public int MaNV { get; set; }
        public decimal TongTien { get; set; }

        public DTO_HoaDon() { }

        public DTO_HoaDon(int maHD, DateTime ngayLap, int maKH, int maNV, string hinhThucTT, decimal tongTien)
        {
            MaHD = maHD;
            NgayLap = ngayLap;
            MaKH = maKH;
            MaNV = maNV;
            HinhThucTT = hinhThucTT;
            TongTien = tongTien;
        }
    }
}