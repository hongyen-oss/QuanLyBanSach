using System;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon = new DAL_HoaDon();
        DAL_ChiTietHoaDon dalCT = new DAL_ChiTietHoaDon();
        DAL_Sach dalSach = new DAL_Sach();
        DAL_KhachHang dalKH = new DAL_KhachHang();

        public bool themHoaDonFull(DTO_HoaDon hd, List<DTO_ChiTietHoaDon> listCT)
        {
            // 1. Thêm hóa đơn
            if (dalHoaDon.themHoaDon(hd))
            {
                
                int maHD = dalHoaDon.getLastInsertID(); 

                foreach (var ct in listCT)
                {
                    ct.MaHD = maHD;

                    // 2. Thêm chi tiết
                    dalCT.themChiTiet(ct);

                    // 3. Trừ kho
                    dalSach.truTonKho(ct.MaSach, ct.SoLuong);
                }

                // 4. Cộng tiền khách
                dalKH.congTienTichLuy(hd.MaKH, hd.TongTien);

                return true;
            }

            return false;
        }
        // XEM
        public DataTable getHoaDon()
        {
            return dalHoaDon.getHoaDon();
        }

        // THÊM
        public bool themHoaDon(DTO_HoaDon hd)
        {
            return dalHoaDon.themHoaDon(hd);
        }

        // SỬA
        public bool suaHoaDon(DTO_HoaDon hd)
        {
            return dalHoaDon.suaHoaDon(hd);
        }
    }
}