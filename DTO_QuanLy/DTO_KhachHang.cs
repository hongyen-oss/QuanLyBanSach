using System;

namespace DTO_QuanLy
{
    public class DTO_KhachHang
    {

        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public decimal TongTienTichLuy { get; set; }
        public bool Voucher { get; set; }
        

        public DTO_KhachHang() { }


        public DTO_KhachHang(int maKH, string hoTen, string sdt,
                        string eMail, string diaChi, decimal tichLuy, bool voucher)
        {
            MaKH = maKH;
            HoTen = hoTen;
            SDT = sdt;
            Email = eMail;
            DiaChi = diaChi;
            TongTienTichLuy = tichLuy;
            Voucher = voucher;
        }
            
    }
}