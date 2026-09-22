using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_Sach
    {
        DAL_Sach dalSach = new DAL_Sach();

        
        public DataTable getSach()
        {
            return dalSach.getSach();
        }
        
        public DataTable timKiemSach(string keyword)
        {
            return dalSach.SearchSach(keyword);
        }

        public bool themSach(DTO_Sach s)
        {
            return dalSach.themSach(s);
        }

        public bool suaSach(DTO_Sach s)
        {
            return dalSach.suaSach(s);
        }

       
        public bool xoaSach(string MaSach)
        {
            return dalSach.xoaSach(MaSach);
        }
    }
}