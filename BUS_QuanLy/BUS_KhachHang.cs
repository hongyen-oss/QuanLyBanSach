using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalKH = new DAL_KhachHang();

        public int taoKhachTuDong(string sdt)
        {
            return dalKH.taoKhachTuDong(sdt, "", "");
        }

        public string DiaChi { get; set; }
        public DTO_KhachHang getBySDT(string sdt)
        {
            return dalKH.getBySDT(sdt);
        }
        public int getMaKH_BySDT(string sdt)
        {
            return dalKH.getMaKH_BySDT(sdt);
        }

        public DataTable getKhachHang()
        {
            return dalKH.getKhachHang();
        }


        public bool themKH(DTO_KhachHang kh)
        {
            return dalKH.themKH(kh);
        }

        public bool suaKhachHang(DTO_KhachHang kh)
        {
            return dalKH.suaKhachHang(kh);
        }


        public bool xoaKhachHang(string MaKH)
        {
            return dalKH.xoaKhachHang(MaKH);
        }
        public List<int> LayKhachTheoTheLoai(string theLoai)
        {
            return dalKH.GetMaKHByTheLoai(theLoai);
        }
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();

        public bool CapNhatVoucherTuDong(int maKH)
        {
            return dalKH.CapNhatVoucherTuDong(maKH);
        }
    }
}