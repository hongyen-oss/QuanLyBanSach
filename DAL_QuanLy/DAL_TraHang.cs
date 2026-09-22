using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace DAL_QuanLy
{
    public class DAL_TraHang : DBConnect
    {
        // Tạo phiếu trả
        public int TaoPhieuTra(
            int maHD,
            string lyDo,
            decimal tongTienHoan)
        {
            _conn.Open();

            string sql =
            @"
            INSERT INTO TraHang
            (
                MaHD,
                NgayTra,
                LyDo,
                TongTienHoan,
                TrangThai
            )

            OUTPUT INSERTED.MaTra

            VALUES
            (
                @MaHD,
                GETDATE(),
                @LyDo,
                @TongTienHoan,
                N'Chờ duyệt'
            )
            ";

            SqlCommand cmd =
                new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue(
                "@MaHD",
                maHD
            );

            cmd.Parameters.AddWithValue(
                "@LyDo",
                lyDo
            );

            cmd.Parameters.AddWithValue(
                "@TongTienHoan",
                tongTienHoan
            );

            int maTra =
                Convert.ToInt32(
                    cmd.ExecuteScalar()
                );

            _conn.Close();

            return maTra;
        }
        public int TaoTraHang(
    int maHD,
    string lyDo,
    decimal tongTien)
        {
            _conn.Open();

            string sql =
            @"
    INSERT INTO TraHang
    (
        MaHD,
        NgayTra,
        LyDo,
        TongTienHoan,
        TrangThai
    )

    OUTPUT INSERTED.MaTra

    VALUES
    (
        @MaHD,
        GETDATE(),
        @LyDo,
        @TongTien,
        N'Chờ duyệt'
    )
    ";

            SqlCommand cmd =
                new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue(
                "@MaHD",
                maHD
            );

            cmd.Parameters.AddWithValue(
                "@LyDo",
                lyDo
            );

            cmd.Parameters.AddWithValue(
                "@TongTien",
                tongTien
            );

            int maTra =
                Convert.ToInt32(
                    cmd.ExecuteScalar()
                );

            _conn.Close();

            return maTra;
        }
        public DataTable LayCTHoaDon(int maHD)
        {
            _conn.Open();

            string sql =
            @"
    SELECT
        CT.MaSach,
        S.TenSach,
        CT.SoLuong,
        CT.DonGia,
        (CT.SoLuong * CT.DonGia) AS ThanhTien

    FROM ChiTietHoaDon CT

    INNER JOIN Sach S
    ON CT.MaSach = S.MaSach

    WHERE CT.MaHD = @MaHD
    ";

            SqlCommand cmd =
                new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue(
                "@MaHD",
                maHD
            );

            SqlDataAdapter da =
                new SqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            _conn.Close();

            return dt;
        }

        // thêm chi tiết trả
        public void ThemCTTraHang(
            int maTra,
            int maSach,
            int soLuong,
            decimal tienHoan)
        {
            _conn.Open();

            string sql =
            @"
            INSERT INTO CT_TraHang
            (
                MaTra,
                MaSach,
                SoLuong,
                TienHoan
            )

            VALUES
            (
                @MaTra,
                @MaSach,
                @SoLuong,
                @TienHoan
            )
            ";

            SqlCommand cmd =
                new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue(
                "@MaTra",
                maTra
            );

            cmd.Parameters.AddWithValue(
                "@MaSach",
                maSach
            );

            cmd.Parameters.AddWithValue(
                "@SoLuong",
                soLuong
            );

            cmd.Parameters.AddWithValue(
                "@TienHoan",
                tienHoan
            );

            cmd.ExecuteNonQuery();

            _conn.Close();
        }

        // load phiếu trả
        public DataTable LayTraHang()
        {
            _conn.Open();

            string sql =
            @"
            SELECT *
            FROM TraHang
            ORDER BY NgayTra DESC
            ";

            SqlDataAdapter da =
                new SqlDataAdapter(sql, _conn);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            _conn.Close();

            return dt;
        }

        // duyệt trả hàng
        public void DuyetTraHang(int maTra)
        {
            _conn.Open();

            string sql =
            @"
            UPDATE TraHang
            SET TrangThai = N'Đã duyệt'
            WHERE MaTra = @MaTra
            ";

            SqlCommand cmd =
                new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue(
                "@MaTra",
                maTra
            );

            cmd.ExecuteNonQuery();

            _conn.Close();
        }
        public void CopyChiTietTra(
    int maTra,
    int maHD)
        {
            _conn.Open();

            string sql =
            @"
    INSERT INTO CT_TraHang
    (
        MaTra,
        MaSach,
        SoLuong,
        TienHoan
    )

    SELECT
        @MaTra,
        MaSach,
        SoLuong,
        SoLuong * DonGia

    FROM ChiTietHoaDon

    WHERE MaHD = @MaHD
    ";

            SqlCommand cmd =
                new SqlCommand(sql, _conn);

            cmd.Parameters.AddWithValue(
                "@MaTra",
                maTra
            );

            cmd.Parameters.AddWithValue(
                "@MaHD",
                maHD
            );

            cmd.ExecuteNonQuery();

            _conn.Close();
        }
    }
        
}
