using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNV = new DAL_NhanVien();

        public DataTable getNhanVien()
        {
            return dalNV.getNhanVien();
        }

        public bool themNhanVien(DTO_NhanVien nv)
        {
            return dalNV.themNhanVien(nv);
        }

        public bool suaNhanVien(DTO_NhanVien nv)
        {
            return dalNV.suaNhanVien(nv);
        }

        public bool xoaNhanVien(int ma)
        {
            return dalNV.xoaNhanVien(ma);
        }
       

        public int LayMaNVCuoiCung()
        {
            return dalNV.LayMaNVCuoiCung();
        }

    }
}