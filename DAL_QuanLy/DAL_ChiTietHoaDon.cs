using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLy
{
    public class DAL_ChiTietHoaDon : DBConnect
    {
        public DataTable getChiTietHoaDon(string maHD)
        {
            // Sử dụng JOIN để lấy GiaBan từ bảng Sach
            string sql = @"SELECT ct.MaSach, s.TenSach, s.GiaBan, ct.SoLuong, 
                   (s.GiaBan * ct.SoLuong) AS DonGia 
                   FROM CHITIETHOADON ct 
                   JOIN SACH s ON ct.MaSach = s.MaSach 
                   WHERE ct.MaHD = '" + maHD + "'";
            return GetDataTable(sql);
        }
        public bool themChiTiet(DTO_ChiTietHoaDon ct)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO ChiTietHoaDon
                (MaHD, MaSach, SoLuong, DonGia)
                VALUES (@MaHD, @MaSach, @SoLuong, @DonGia)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaHD", ct.MaHD);
                    cmd.Parameters.AddWithValue("@MaSach", ct.MaSach);
                    cmd.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                    cmd.Parameters.AddWithValue("@DonGia", ct.DonGia);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi chi tiết hóa đơn: " + ex.Message);
            }
        }
    }
}