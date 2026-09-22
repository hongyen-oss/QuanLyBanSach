using DAL_QuanLy; 
using DAL_QuanLy;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
namespace BUS_QuanLy
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dalTK = new DAL_TaiKhoan();   
        DAL_KhachHang dalKH = new DAL_KhachHang();
        
        public int DangNhap(string username, string password)
        {
            return dalTK.KiemTraDangNhap(username, password);
        }
        

        public bool DangKy(string user, string pass, string ten, string sdt, string email, string DiaChi)
        {
            if (dalTK.KiemTraTonTai(user))
                return false;

            int maKH = dalKH.ThemKhachHang_DangKy(ten, sdt, email, DiaChi);

            return dalTK.DangKy(user, pass, maKH);
        }
        public int LayMaKH(string username)
        {
            DAL_TaiKhoan dal =
                new DAL_TaiKhoan();

            return dal.LayMaKH(username);
        }
        

        public DataTable LayThongTinTaiKhoan(string username)
        {
            return dalTK.LayThongTinTaiKhoan(username);
        }
        public bool CapNhatTaiKhoan(
    string username,
    string password,
    string hoTen,
    string sdt,
    string email)
        {
            return dalTK.CapNhatTaiKhoan(
                username,
                password,
                hoTen,
                sdt,
                email
            );
        }

        public bool XoaTaiKhoan(string username)
        {
            return dalTK.XoaTaiKhoan(username);
        }
        public bool TaoTaiKhoanNhanVien(string user, string pass, int maNV)
        {
            if (dalTK.KiemTraTonTai(user))
                return false;

            return dalTK.TaoTaiKhoanNhanVien(user, pass, maNV);
        }

    }
}