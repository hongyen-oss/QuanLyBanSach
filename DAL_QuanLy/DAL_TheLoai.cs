using System;
using System.Data;
using System.Data.SqlClient; 

namespace DAL_QuanLy
{
    
    public class DAL_TheLoai : DBConnect
    {
        public DataTable getTheLoai()
        {
           
            string sql = "SELECT * FROM THELOAI";

            try
            {
                return GetDataTable(sql); 
            }
            catch
            {
                return null;
            }
        }
        public bool kiemTraTonTai(string maTL)
        {
            
            string sql = "SELECT * FROM THELOAI WHERE MaTheLoai = '" + maTL + "'";
            DataTable dt = GetDataTable(sql);
            return dt.Rows.Count > 0; // Trả về true nếu tìm thấy
        }
    }
}