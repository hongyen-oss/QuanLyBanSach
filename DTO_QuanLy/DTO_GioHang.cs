using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_QuanLy
{
    public class DTO_GioHang
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string HinhAnh { get; set; }

        public decimal ThanhTien
        {
            get { return GiaBan * SoLuong; }
        }
    }
   
}
