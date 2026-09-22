using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_GioHang : DBConnect
    {
        // THÊM GIỎ HÀNG
        public void ThemGioHang(
            string username,
            string maSach,
            int soLuong)
        {
            try
            {
                _conn.Open();

                // tìm mã giỏ hàng
                string sqlGH =
                    "SELECT MaGH FROM GIOHANG " +
                    "WHERE Username = @Username";

                SqlCommand cmdGH =
                    new SqlCommand(sqlGH, _conn);

                cmdGH.Parameters.AddWithValue(
                    "@Username",
                    username
                );

                object result = cmdGH.ExecuteScalar();

                int maGH;

                // chưa có giỏ hàng
                if (result == null)
                {
                    string insertGH =
                        "INSERT INTO GIOHANG(Username) " +
                        "OUTPUT INSERTED.MaGH " +
                        "VALUES(@Username)";

                    SqlCommand cmdInsert =
                        new SqlCommand(insertGH, _conn);

                    cmdInsert.Parameters.AddWithValue(
                        "@Username",
                        username
                    );

                    maGH =
                        Convert.ToInt32(
                            cmdInsert.ExecuteScalar()
                        );
                }
                else
                {
                    maGH = Convert.ToInt32(result);
                }

                // kiểm tra sách đã tồn tại chưa
                string check =
                    "SELECT SoLuong FROM CT_GIOHANG " +
                    "WHERE MaGH=@MaGH AND MaSach=@MaSach";

                SqlCommand cmdCheck =
                    new SqlCommand(check, _conn);

                cmdCheck.Parameters.AddWithValue(
                    "@MaGH",
                    maGH
                );

                cmdCheck.Parameters.AddWithValue(
                    "@MaSach",
                    maSach
                );

                object sl = cmdCheck.ExecuteScalar();

                // nếu có rồi -> cộng số lượng
                if (sl != null)
                {
                    string update =
                        "UPDATE CT_GIOHANG " +
                        "SET SoLuong = SoLuong + @SL " +
                        "WHERE MaGH=@MaGH " +
                        "AND MaSach=@MaSach";

                    SqlCommand cmdUpdate =
                        new SqlCommand(update, _conn);

                    cmdUpdate.Parameters.AddWithValue(
                        "@SL",
                        soLuong
                    );

                    cmdUpdate.Parameters.AddWithValue(
                        "@MaGH",
                        maGH
                    );

                    cmdUpdate.Parameters.AddWithValue(
                        "@MaSach",
                        maSach
                    );

                    cmdUpdate.ExecuteNonQuery();
                }
                else
                {
                    // chưa có -> insert mới
                    string insert =
                        "INSERT INTO CT_GIOHANG " +
                        "(MaGH, MaSach, SoLuong) " +
                        "VALUES(@MaGH,@MaSach,@SL)";

                    SqlCommand cmdInsertCT =
                        new SqlCommand(insert, _conn);

                    cmdInsertCT.Parameters.AddWithValue(
                        "@MaGH",
                        maGH
                    );

                    cmdInsertCT.Parameters.AddWithValue(
                        "@MaSach",
                        maSach
                    );

                    cmdInsertCT.Parameters.AddWithValue(
                        "@SL",
                        soLuong
                    );

                    cmdInsertCT.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi thêm giỏ hàng: " + ex.Message
                );
            }
            finally
            {
                _conn.Close();
            }
        }
        public void CapNhatSoLuong(
    string username,
    string maSach,
    int soLuong)
        {
            try
            {
                _conn.Open();

                string sql =
                    @"UPDATE CT_GIOHANG
              SET SoLuong = @SoLuong
              WHERE MaSach = @MaSach
              AND MaGH IN
              (
                  SELECT MaGH
                  FROM GIOHANG
                  WHERE Username = @Username
              )";

                SqlCommand cmd =
                    new SqlCommand(sql, _conn);

                cmd.Parameters.AddWithValue(
                    "@SoLuong",
                    soLuong
                );

                cmd.Parameters.AddWithValue(
                    "@MaSach",
                    maSach
                );

                cmd.Parameters.AddWithValue(
                    "@Username",
                    username
                );

                cmd.ExecuteNonQuery();
            }
            finally
            {
                _conn.Close();
            }
        }
        public void XoaGioHang(
    string username,
    string maSach)
        {
            try
            {
                _conn.Open();

                string sql =
                    @"DELETE FROM CT_GIOHANG
              WHERE MaSach = @MaSach
              AND MaGH IN
              (
                  SELECT MaGH
                  FROM GIOHANG
                  WHERE Username = @Username
              )";

                SqlCommand cmd =
                    new SqlCommand(sql, _conn);

                cmd.Parameters.AddWithValue(
                    "@MaSach",
                    maSach
                );

                cmd.Parameters.AddWithValue(
                    "@Username",
                    username
                );

                cmd.ExecuteNonQuery();
            }
            finally
            {
                _conn.Close();
            }
        }
        // LẤY GIỎ HÀNG
        public List<DTO_GioHang> LayGioHang(
            string username)
        {
            List<DTO_GioHang> ds =
                new List<DTO_GioHang>();

            try
            {
                _conn.Open();

                string sql =
                    @"SELECT 
                        s.MaSach,
                        s.TenSach,
                        s.GiaBan,
                        ct.SoLuong,
                        s.HinhAnh
                      FROM GIOHANG gh
                      JOIN CT_GIOHANG ct
                           ON gh.MaGH = ct.MaGH
                      JOIN SACH s
                           ON s.MaSach = ct.MaSach
                      WHERE gh.Username = @Username";

                SqlCommand cmd =
                    new SqlCommand(sql, _conn);

                cmd.Parameters.AddWithValue(
                    "@Username",
                    username
                );

                SqlDataReader rd =
                    cmd.ExecuteReader();

                while (rd.Read())
                {
                    DTO_GioHang item =
                        new DTO_GioHang();

                    item.MaSach =
                        rd["MaSach"].ToString();

                    item.TenSach =
                        rd["TenSach"].ToString();

                    item.GiaBan =
                        Convert.ToDecimal(
                            rd["GiaBan"]
                        );

                    item.SoLuong =
                        Convert.ToInt32(
                            rd["SoLuong"]
                        );

                    item.HinhAnh =
                        rd["HinhAnh"].ToString();

                    ds.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Lỗi load giỏ hàng: " +
                    ex.Message
                );
            }
            finally
            {
                _conn.Close();
            }

            return ds;
        }
    }
}