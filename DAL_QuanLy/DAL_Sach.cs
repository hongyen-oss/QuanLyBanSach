using System;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_Sach : DBConnect
    {
        // XEM danh sách sách
        public DataTable getSach()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SACH", conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
            return dt;
        }
        public DataTable TimSachTheoTheLoai(int maTheLoai)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM SACH WHERE MaTheLoai = @MaTL",
                        conn);

                    cmd.Parameters.AddWithValue(
                        "@MaTL",
                        maTheLoai);

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi khi lấy dữ liệu: " + ex.Message);
            }

            return dt;
        }
        public DataTable SearchSach(string keyword)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
            {
                string sql = "SELECT * FROM Sach WHERE TenSach LIKE @key OR TacGia LIKE @key";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public bool themSach(DTO_Sach s)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = @"INSERT INTO SACH 
                    (TenSach, TacGia, MaTheLoai, GiaBan, SoLuongTon, NgayNhapKho, TrangThai, HinhAnh, MoTa)
                    VALUES (@TenSach, @TacGia, @MaTheLoai, @GiaBan, @SoLuongTon, @NgayNhapKho, @TrangThai, @HinhAnh, @MoTa)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                   // cmd.Parameters.AddWithValue("@MaSach", s.MaSach);
                    cmd.Parameters.AddWithValue("@TenSach", s.TenSach);
                    cmd.Parameters.AddWithValue("@TacGia", s.TacGia);
                    cmd.Parameters.AddWithValue("@MaTheLoai", s.MaTheLoai);
                    cmd.Parameters.AddWithValue("@GiaBan", s.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", s.SoLuongTon);
                    cmd.Parameters.AddWithValue("@NgayNhapKho", s.NgayNhapKho);
                    cmd.Parameters.AddWithValue("@TrangThai", s.TrangThai);
                    cmd.Parameters.AddWithValue("@HinhAnh", s.HinhAnh);
                    cmd.Parameters.AddWithValue("@MoTa", s.MoTa);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm sách: " + ex.Message);
            }
        }

      
        public bool suaSach(DTO_Sach s)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE SACH SET 
                TenSach = @TenSach,
                TacGia = @TacGia,
                MaTheLoai = @MaTheLoai,
                GiaBan = @GiaBan,
                SoLuongTon = @SoLuongTon,
                NgayNhapKho = @NgayNhapKho,
                TrangThai = @TrangThai,
                HinhAnh = @HinhAnh,
                MoTa = @MoTa
                WHERE MaSach = @MaSach"; 

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaSach", s.MaSach);

                    cmd.Parameters.AddWithValue("@TenSach", s.TenSach);
                    cmd.Parameters.AddWithValue("@TacGia", s.TacGia);
                    cmd.Parameters.AddWithValue("@MaTheLoai", s.MaTheLoai);
                    cmd.Parameters.AddWithValue("@GiaBan", s.GiaBan);
                    cmd.Parameters.AddWithValue("@SoLuongTon", s.SoLuongTon);
                    cmd.Parameters.AddWithValue("@NgayNhapKho", s.NgayNhapKho);
                    cmd.Parameters.AddWithValue("@TrangThai", s.TrangThai);
                    cmd.Parameters.AddWithValue("@HinhAnh", s.HinhAnh);
                    cmd.Parameters.AddWithValue("@MoTa", s.MoTa);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi sửa sách: " + ex.Message);
            }
        }

        
        public bool xoaSach(string maSach)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM SACH WHERE MaSach = @MaSach";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaSach", maSach);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa sách: " + ex.Message);
            }
        }
        public bool truTonKho(string maSach, int soLuong)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = @"UPDATE Sach
                           SET SoLuongTon = SoLuongTon - @SoLuong
                           WHERE MaSach = @MaSach AND SoLuongTon >= @SoLuong";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@MaSach", maSach);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi trừ tồn kho: " + ex.Message);
            }
        }

    }
}