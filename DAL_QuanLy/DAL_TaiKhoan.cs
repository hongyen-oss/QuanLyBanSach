using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL_QuanLy
{
    public class DAL_TaiKhoan : DBConnect

    {
        public int KiemTraDangNhap(string username, string password)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string query = @"SELECT RoleID 
                         FROM TaiKhoan 
                         WHERE Username = @u 
                         AND Password = @p 
                         AND TrangThai = 1";

                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                object result = cmd.ExecuteScalar();
                return (result != null) ? Convert.ToInt32(result) : -1;
            }
            catch
            {
                return -1;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }
        public int LayMaKH(string username)
        {
            _conn.Open();

            string sql =
            @"
    SELECT MaKH
    FROM TaiKhoan
    WHERE Username = @u
    ";

            SqlCommand cmd =
                new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue(
                "@u",
                username
            );

            object kq =
                cmd.ExecuteScalar();

            _conn.Close();

            if (kq == null || kq == DBNull.Value)
                return 0;

            return Convert.ToInt32(kq);
        }
        public bool KiemTraTonTai(string user)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE Username = @u";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@u", user);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }
        public bool DangKy(string user, string pass, int maKH)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string sql = @"INSERT INTO TaiKhoan
                       (Username, Password, MaKH, RoleID, TrangThai)
                       VALUES (@u, @p, @makh, 3, 1)";

                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                cmd.Parameters.AddWithValue("@makh", maKH);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }
        public bool KiemTraTrungTen(string user)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed) _conn.Open(); // PHẢI CÓ DÒNG NÀY

                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE Username = @u";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@u", user);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch { return false; }
            finally { if (_conn.State == ConnectionState.Open) _conn.Close(); }
        }
        public DataTable LayThongTinTaiKhoan(string username)
        {
            DataTable dt = new DataTable();

            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string sql = @"
        SELECT 
            tk.Username,
            tk.Password,
            kh.HoTen,
            kh.SDT,
            kh.Email,
            kh.TongTienTichLuy AS TienTichLuy
        FROM TaiKhoan tk
        LEFT JOIN KhachHang kh
            ON tk.MaKH = kh.MaKH
        WHERE tk.Username = @user";

                SqlCommand cmd = new SqlCommand(sql, _conn);

                cmd.Parameters.AddWithValue("@user", username);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }
        public bool CapNhatTaiKhoan(
    string username,
    string password,
    string hoTen,
    string sdt,
    string email)
        {
            try
            {
                _conn.Open();

                // UPDATE TÀI KHOẢN
                string sqlTK = @"
        UPDATE TaiKhoan
        SET Password = @Password
        WHERE Username = @Username";

                SqlCommand cmdTK = new SqlCommand(sqlTK, _conn);

                cmdTK.Parameters.AddWithValue("@Username", username);
                cmdTK.Parameters.AddWithValue("@Password", password);

                cmdTK.ExecuteNonQuery();

                // UPDATE KHÁCH HÀNG
                string sqlKH = @"
        UPDATE KhachHang
        SET HoTen = @HoTen,
            SDT = @SDT,
            Email = @Email
        WHERE MaKH =
        (
            SELECT MaKH
            FROM TaiKhoan
            WHERE Username = @Username
        )";

                SqlCommand cmdKH = new SqlCommand(sqlKH, _conn);

                cmdKH.Parameters.AddWithValue("@Username", username);
                cmdKH.Parameters.AddWithValue("@HoTen", hoTen);
                cmdKH.Parameters.AddWithValue("@SDT", sdt);
                cmdKH.Parameters.AddWithValue("@Email", email);

                cmdKH.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool XoaTaiKhoan(string username)
        {
            string queryTK = "UPDATE TaiKhoan SET TrangThai = 0 WHERE Username = @Username";

            string queryKH = @"UPDATE KhachHang 
                       SET TrangThai = 0 
                       WHERE MaKH = (SELECT MaKH FROM TaiKhoan WHERE Username = @Username)";

            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                using (SqlTransaction trans = _conn.BeginTransaction())
                {
                    try
                    {
                        // Cập nhật bảng TaiKhoan
                        int rowsTK = 0;
                        using (SqlCommand cmdTK = new SqlCommand(queryTK, _conn, trans))
                        {
                            cmdTK.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username.Trim();
                            rowsTK = cmdTK.ExecuteNonQuery();
                        }

                        // Cập nhật bảng KhachHang
                        using (SqlCommand cmdKH = new SqlCommand(queryKH, _conn, trans))
                        {
                            cmdKH.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = username.Trim();
                            cmdKH.ExecuteNonQuery();
                        }
                        if (rowsTK > 0)
                        {
                            trans.Commit();
                            return true;
                        }
                        else
                        {
                            trans.Rollback();
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback(); // Hủy bỏ toàn bộ nếu xảy ra lỗi giữa chừng
                        throw new Exception("Lỗi trong quá trình cập nhật chuỗi liên kết: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi Database khi xóa tài khoản và khách hàng: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }
        public bool TaoTaiKhoanNhanVien(string user, string pass, int maNV)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                string sql = @"INSERT INTO TaiKhoan (Username, Password, MaNhanVien, MaKH, RoleID, TrangThai) 
                       VALUES (@user, @pass, @maNV, NULL, 2, 1)";

                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@maNV", maNV);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int LayMaNhanVienTuUsername(string username)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();
                string sql = "SELECT MaNhanVien FROM TaiKhoan WHERE Username = @u";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@u", username);

            object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return 0; 

                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                return 0; 
            }
            finally { if (_conn.State == ConnectionState.Open) _conn.Close(); }
        
    }
    
    }
    
}
