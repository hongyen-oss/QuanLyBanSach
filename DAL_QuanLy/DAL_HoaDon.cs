using System;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_HoaDon : DBConnect
    {

        //XEM 
        public DataTable getHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy danh sách hóa đơn: " + ex.Message);
            }
            return dt;
        }

        // THÊM hóa đơn
        public bool themHoaDon(DTO_HoaDon hd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO HoaDon
                    (NgayLap, MaKH, MaNV, HinhThucTT, TongTien)
                    VALUES (@NgayLap, @MaKH, @MaNV, @HinhThucTT, @TongTien)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                   // cmd.Parameters.AddWithValue("@MaHD", hd.MaHD);
                    cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                    cmd.Parameters.AddWithValue("@MaKH", hd.MaKH);
                    cmd.Parameters.AddWithValue("@MaNV", hd.MaNV);
                    cmd.Parameters.AddWithValue("@HinhThucTT", hd.HinhThucTT);
                    cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm hóa đơn: " + ex.Message);
            }
        }

        // SỬA hóa đơn
        public bool suaHoaDon(DTO_HoaDon hd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE HoaDon SET
                    NgayLap = @NgayLap,
                    MaKH = @MaKH,
                    MaNV = @MaNV,
                    HinhThucTT = @HinhThucTT,
                    TongTien = @TongTien
                    WHERE MaHD = @MaHD";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                 //   cmd.Parameters.AddWithValue("@MaHD", hd.MaHD);
                    cmd.Parameters.AddWithValue("@NgayLap", hd.NgayLap);
                    cmd.Parameters.AddWithValue("@MaKH", hd.MaKH);
                    cmd.Parameters.AddWithValue("@MaNV", hd.MaNV);
                    cmd.Parameters.AddWithValue("@HinhThucTT", hd.HinhThucTT);
                    cmd.Parameters.AddWithValue("@TongTien", hd.TongTien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi sửa hóa đơn: " + ex.Message);
            }
        }
        public int getLastInsertID()
        {
            using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(MaHD) FROM HoaDon", conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public bool congTienTichLuy(int maKH, decimal tongTien)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE KhachHang
                           SET TongTienTichLuy = ISNULL(TongTienTichLuy,0) + @TongTien
                           WHERE MaKH = @MaKH";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@TongTien", tongTien);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi cộng tiền tích lũy: " + ex.Message);
            }
        }

    }
}
