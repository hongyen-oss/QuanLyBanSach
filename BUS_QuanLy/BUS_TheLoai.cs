using DAL_QuanLy;
using DTO_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class BUS_TheLoai
    {
        DAL_TheLoai dalTL = new DAL_TheLoai();

        public DataTable getTheLoai()
        {
            return dalTL.getTheLoai();
        }
       
        
        public bool kiemTraTonTai(string maTL)
        {
            // Gọi xuống hàm kiemTraTonTai của lớp DAL_TheLoai
            return dalTL.kiemTraTonTai(maTL);
        }
    }
}
