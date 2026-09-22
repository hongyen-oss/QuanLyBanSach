using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BUS_QuanLy
{
    public class BUS_ThongBao
    {
        DAL_ThongBao dal = new DAL_ThongBao();

        public void GuiThongBao(int maKH, string tenSach)
        {
            DTO_ThongBao tb = new DTO_ThongBao()
            {
                MaKH = maKH,
                NoiDung = $"Sách mới '{tenSach}' vừa về!",
                NgayGui = DateTime.Now,
                TrangThai = "Đã gửi"
            };

            dal.InsertThongBao(tb);
        }
        public DataTable GetAllThongBao()
        {
            return dal.GetAllThongBao();
        }
        public DataTable LayTheLoai()
        {
            return dal.GetDanhSachTheLoai();
        }
        public DataTable GetKhachHangTheoTheLoai(string tenTheLoai)
        {
            return dal.GetKhachHangTheoTheLoai(tenTheLoai);
        }
        public DataTable LaySachMoiNhatTheoTheLoai(string tenTheLoai)
        {
            return dal.LaySachMoiNhatTheoTheLoai(tenTheLoai);
        }
    }
   


    internal class BUS_ThongBaoZalo
    {
    }
}
