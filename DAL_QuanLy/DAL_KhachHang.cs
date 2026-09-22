using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLy
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable getKhachHang()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu: " + ex.Message);
            }

            return dt;
        }
        public bool truTienTichLuy(int maKH, decimal soTien)
        {
            string query = "UPDATE KhachHang SET TongTienTichLuy = TongTienTichLuy - @SoTien WHERE MaKH = @MaKH";

            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = soTien;
                        cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = maKH;

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hàm truTienTichLuy: " + ex.Message);
                return false;
            }
        }
        public DTO_KhachHang getBySDT(string sdt)
        {
            using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM KhachHang WHERE SDT = @SDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SDT", sdt);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new DTO_KhachHang
                    {
                        MaKH = Convert.ToInt32(reader["MaKH"]),
                        HoTen = reader["HoTen"].ToString(),
                        SDT = reader["SDT"].ToString(),
                        Email = reader["Email"].ToString(),
                        TongTienTichLuy = Convert.ToDecimal(reader["TongTienTichLuy"]),
                        Voucher = Convert.ToBoolean(reader["Voucher"]),
                        DiaChi = reader["DiaChi"].ToString()
                    };
                }
            }

            return null; // không tìm thấy
        }

        public bool themKH(DTO_KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    bool voucherStatus = kh.Voucher;
                    if (kh.TongTienTichLuy >= 300000)
                    {
                        voucherStatus = true;
                    }
                    
                    string sql = @"INSERT INTO KhachHang 
                    (HoTen, SDT, Email, DiaChi, TongTienTichLuy, Voucher)
                    VALUES (@HoTen, @SDT, @Email, @DiaChi, @TongTienTichLuy, @Voucher)";
                    
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                    cmd.Parameters.AddWithValue("@Email", kh.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                    cmd.Parameters.AddWithValue("@TongTienTichLuy", kh.TongTienTichLuy);
                    cmd.Parameters.AddWithValue("@Voucher", voucherStatus); 



                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm Khách hàng: " + ex.Message);
            }
        }
                
            

        public List<int> GetMaKHByTheLoai(string theLoai)
        {
            List<int> ds = new List<int>();

            string sql = @"SELECT DISTINCT kh.MaKH
                            FROM KhachHang kh
                            JOIN HoaDon hd ON kh.MaKH = hd.MaKH
                            JOIN ChiTietHoaDon ct ON hd.MaHD = ct.MaHD
                            JOIN Sach s ON ct.MaSach = s.MaSach
                            WHERE s.TheLoai = @TheLoai
                          ";

            SqlParameter[] param = { new SqlParameter("@TheLoai", theLoai) };

            DBConnect db = new DBConnect();
            DataTable dt = db.GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                ds.Add(Convert.ToInt32(row["MaKH"]));
            }

            return ds;
        }

        public int taoKhachTuDong(string sdt, string email, string diaChi)
        {
            using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
            {
                conn.Open();

                string sql = @"INSERT INTO KhachHang(HoTen, SDT, Email, DiaChi, TongTienTichLuy, Voucher)
                VALUES (N'Khách lẻ', @SDT, @Email, @DiaChi, 0, 0);
                SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    bool voucherStatus = kh.Voucher;
                    if (kh.TongTienTichLuy >= 300000)
                    {
                        voucherStatus = true;
                    }

                    string sql = @"UPDATE KhachHang SET 
                    HoTen = @HoTen,
                    SDT = @SDT,
                    Email = @Email,
                    DiaChi = @DiaChi,
                    TongTienTichLuy = @TongTienTichLuy,
                    Voucher = @Voucher
                    WHERE MaKH = @MaKH";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                    cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                    cmd.Parameters.AddWithValue("@Email", kh.Email);
                    cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                    cmd.Parameters.AddWithValue("@TongTienTichLuy", kh.TongTienTichLuy);
                    cmd.Parameters.AddWithValue("@Voucher", voucherStatus); 
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi sửa Khách hàng: " + ex.Message);
            }
        }

        public bool xoaKhachHang(string maKH)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@MaKH", maKH);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa KhachHamg: " + ex.Message);
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
                                   SET TongTienTichLuy = ISNULL(TongTienTichLuy, 0) + @TongTien,
                                       Voucher = CASE 
                                                    WHEN (ISNULL(TongTienTichLuy, 0) + @TongTien) >= 300000 THEN 1 
                                                    ELSE Voucher 
                                                 END
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

        public int getMaKH_BySDT(string sdt)
        {
            using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
            {
                conn.Open();

                string sql = "SELECT MaKH FROM KhachHang WHERE SDT = @SDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SDT", sdt);

                object result = cmd.ExecuteScalar();

                if (result != null)
                    return Convert.ToInt32(result);

                return -1;
            }
        }

        public int ThemKhachHang_DangKy(string ten, string sdt, string email, string diaChi)
        {
            using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
            {
                conn.Open();

                string sql = @"INSERT INTO KhachHang(HoTen, SDT, Email, DiaChi, TongTienTichLuy, Voucher)
                       OUTPUT INSERTED.MaKH
                       VALUES(@ten, @sdt,@email, @diaChi, 0, 0)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@diaChi", diaChi);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool CapNhatVoucherTuDong(int maKH)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    string sql = "UPDATE KhachHang SET Voucher = 1 WHERE MaKH = @MaKH";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}