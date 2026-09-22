using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLy
{
    public class DAL_DonHang : DBConnect
    {
        public void ThemCTDonHang(int maPhieuDat, string maSach, int soLuong, decimal donGia)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"INSERT INTO CT_DonHang (MaPhieuDat, MaSach, SoLuong, DonGia)
                           VALUES (@MaPhieuDat, @MaSach, @SoLuong, @DonGia)";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat);
            cmd.Parameters.AddWithValue("@MaSach", maSach);
            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
            cmd.Parameters.AddWithValue("@DonGia", donGia);

            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public DataTable LayLichSuDonHang(int maKH)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"SELECT MaPhieuDat, NgayDat, TongTien, TrangThai, LoaiDonHang, HinhThucNhan, PhuongThucTT
                           FROM DonHang
                           WHERE MaKH = @MaKH
                           ORDER BY NgayDat DESC";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaKH", maKH);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _conn.Close();

            return dt;
        }

        public int LayMaHDTheoDonHang(int maPhieuDat)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"SELECT MaHD FROM HoaDon WHERE MaPhieuDat = @MaPhieuDat";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat);

            object kq = cmd.ExecuteScalar();
            _conn.Close();

            if (kq == null || kq == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToInt32(kq);
        }

        public void CongKhoKhiHuy(int maTra)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();
            SqlTransaction transaction = _conn.BeginTransaction();
            try
            {
                string sql = @"UPDATE Sach 
                               SET SoLuongTon = Sach.SoLuongTon + CT.SoLuong 
                               FROM Sach 
                               INNER JOIN CT_TraHang CT ON Sach.MaSach = CT.MaSach 
                               WHERE CT.MaTra = @MaTra";

                SqlCommand cmd = new SqlCommand(sql, _conn, transaction);
                cmd.Parameters.AddWithValue("@MaTra", maTra);
                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally { _conn.Close(); }
        }

        public DataTable LayDonYeuCauHuy()
        {
            string sql = @"SELECT * FROM TraHang WHERE TrangThai = N'Chờ duyệt' ORDER BY NgayTra DESC";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
            return dt;
        }
        
        public void CapNhatTrangThai(int maPhieuDat, string trangThai)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"UPDATE DonHang SET TrangThai = @TrangThai WHERE MaPhieuDat = @Ma";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);
            cmd.Parameters.AddWithValue("@Ma", maPhieuDat);

            cmd.ExecuteNonQuery();
            _conn.Close();
        }
        public int LayMaPhieuDatTheoMaHD(int maHD)
        {
            string query = "SELECT MaPhieuDat FROM HoaDon WHERE MaHD = @MaHD";

            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHD;

                        object result = cmd.ExecuteScalar();

                        // Nếu tìm thấy thì trả về mã số (int), không thấy trả về 0
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hàm LayMaPhieuDatTheoMaHD: " + ex.Message);
                return 0;
            }
        }
        public int TaoHoaDonTuDonHang(int maPhieuDat, int maKH, int maNV, string hinhThucTT, decimal tongTien)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"INSERT INTO HoaDon (NgayLap, MaKH, MaNV, HinhThucTT, TongTien, MaPhieuDat)
                           OUTPUT INSERTED.MaHD
                           VALUES (GETDATE(), @MaKH, @MaNV, @HinhThucTT, @TongTien, @MaPhieuDat)";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaKH", maKH);
            if (maNV == 0)
            {
                cmd.Parameters.AddWithValue("@MaNV", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@MaNV", maNV);
            }
            cmd.Parameters.AddWithValue("@HinhThucTT", hinhThucTT);
            cmd.Parameters.AddWithValue("@TongTien", tongTien);
            cmd.Parameters.AddWithValue("@MaPhieuDat", maPhieuDat);

            int maHD = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();

            return maHD;
        }
        public bool CapNhatTongTienDonHang(int maPhieuDat, decimal soTienMoi)
        {
            string query = "UPDATE PhieuDat SET TongTien = @SoTienMoi WHERE MaPhieuDat = @MaPhieuDat";

            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@SoTienMoi", SqlDbType.Decimal).Value = soTienMoi;
                        cmd.Parameters.Add("@MaPhieuDat", SqlDbType.Int).Value = maPhieuDat;

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi CapNhatTongTienDonHang: " + ex.Message);
                return false;
            }
        }
        public bool TruTienTichLuyKhachHangTheoMaHD(int maHD, decimal tongTien)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_conn.ConnectionString))
                {
                    conn.Open();

                    int maKH = -1;
                    string queryGetKH = "SELECT MaKH FROM HoaDon WHERE MaHD = @MaHD";
                    using (SqlCommand cmdGet = new SqlCommand(queryGetKH, conn))
                    {
                        cmdGet.Parameters.AddWithValue("@MaHD", maHD);
                        object obj = cmdGet.ExecuteScalar();
                        if (obj != null && obj != DBNull.Value)
                        {
                            maKH = Convert.ToInt32(obj);
                        }
                    }

                   
                    if (maKH == -1) return false;

                    if (maKH > 1)
                    {
                        string queryUpdate = @"UPDATE KhachHang 
                                       SET TongTienTichLuy = CASE WHEN (TongTienTichLuy - @TongTien) < 0 THEN 0 ELSE (TongTienTichLuy - @TongTien) END 
                                       WHERE MaKH = @MaKH";

                        using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@TongTien", tongTien);
                            cmdUpdate.Parameters.AddWithValue("@MaKH", maKH);

                            cmdUpdate.ExecuteNonQuery(); 
                        }
                    }

                    return true; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi chi tiết trừ tiền tích lũy: " + ex.Message);
                return false;
            }
        }
        public bool CapNhatTrangThaiTraHang(int maTra, string trangThai)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed) _conn.Open();

                string sql = "UPDATE TraHang SET TrangThai = @trangThai WHERE MaTra = @maTra";
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@trangThai", trangThai);
                cmd.Parameters.AddWithValue("@maTra", maTra);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch { return false; }
            finally { _conn.Close(); }
        }

        public DataTable LayDonHang()
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"SELECT * FROM DonHang ORDER BY NgayDat DESC";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _conn.Close();

            return dt;
        }

        public void ChuyenCTDonHangSangHoaDon(int maDH, int maHD)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"INSERT INTO ChiTietHoaDon (MaHD, MaSach, SoLuong, DonGia)
                           SELECT @MaHD, MaSach, SoLuong, DonGia
                           FROM CT_DonHang
                           WHERE MaPhieuDat = @MaDH";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.Parameters.AddWithValue("@MaDH", maDH);

            cmd.ExecuteNonQuery();
            _conn.Close();
        }

        public void TruKho(int maDH)
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"UPDATE S
                           SET S.SoLuongTon = S.SoLuongTon - CT.SoLuong
                           FROM Sach S
                           INNER JOIN CT_DonHang CT ON S.MaSach = CT.MaSach
                           WHERE CT.MaPhieuDat = @MaDH";

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddWithValue("@MaDH", maDH);

            cmd.ExecuteNonQuery();
            _conn.Close();
        }

      
        public int TaoDonHang(
            int maKH,
            DateTime hanChotNhan,
            decimal tongTien,
            decimal tienCoc,
            string loaiDon,
            string hinhThucNhan,
            string diaChi,
            string ghiChu,
            string phuongThucTT,
            decimal phiShip )
        {
            if (_conn.State == ConnectionState.Closed) _conn.Open();

            string sql = @"INSERT INTO DonHang
            (
                MaKH,
                HanCHotNhan,
                NgayDat,
                TongTien,
                TienCoc,
                TrangThai,
                LoaiDonHang,
                HinhThucNhan,
                DiaChiGiaoHang,
                GhiChu,
                PhuongThucTT,
                PhiVanChuyen
                
            )
            OUTPUT INSERTED.MaPhieuDat
            VALUES
            (
                @MaKH,
                @HanChotNhan,
                GETDATE(),
                @TongTien,
                @TienCoc,
                N'Chờ xác nhận',
                @LoaiDonHang,
                @HinhThucNhan,
                @DiaChi,
                @GhiChu,
                @PhuongThucTT,
                @PhiVanCHuyen
            )";

            SqlCommand cmd = new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue("@MaKH", maKH);
            cmd.Parameters.AddWithValue("@HanChotNhan", hanChotNhan);
            cmd.Parameters.AddWithValue("@TongTien", tongTien);
            cmd.Parameters.AddWithValue("@TienCoc", tienCoc);
            cmd.Parameters.AddWithValue("@LoaiDonHang", loaiDon);
            cmd.Parameters.AddWithValue("@HinhThucNhan", hinhThucNhan);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
            cmd.Parameters.AddWithValue("@PhuongThucTT", phuongThucTT);
            cmd.Parameters.AddWithValue("@PhiVanChuyen", phiShip);



            int ma = Convert.ToInt32(cmd.ExecuteScalar());
            _conn.Close();

            return ma;
        }
    }
}