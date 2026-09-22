using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DAL_Voucher : DBConnect
    {

        public void KiemTraVaPhatVoucherTuDong(int maKH)
        {
            try
            {
                if (_conn.State == ConnectionState.Closed) _conn.Open();

                // 1. Lấy tổng tiền tích lũy hiện tại của khách hàng từ bảng KhachHang
                string sqlCheckTichLuy = "SELECT ISNULL(TongTienTichLuy, 0) FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand cmdCheck = new SqlCommand(sqlCheckTichLuy, _conn);
                cmdCheck.Parameters.AddWithValue("@MaKH", maKH);
                decimal tongTichLuy = Convert.ToDecimal(cmdCheck.ExecuteScalar());

                // 2. Nếu tích lũy >= 300,000 VNĐ, tiến hành tặng cả 3 mã vào ví khách hàng (nếu chưa có)
                if (tongTichLuy >= 300000)
                {
                   
                    string sqlPhatVoucher = @"
                IF NOT EXISTS (SELECT 1 FROM KhachHang_Voucher WHERE MaKH = @MaKH AND MaVoucher = 1)
                    INSERT INTO KhachHang_Voucher (MaKH, MaVoucher, NgayNhan) VALUES (@MaKH, 1, GETDATE());
                
                IF NOT EXISTS (SELECT 1 FROM KhachHang_Voucher WHERE MaKH = @MaKH AND MaVoucher = 2)
                    INSERT INTO KhachHang_Voucher (MaKH, MaVoucher, NgayNhan) VALUES (@MaKH, 2, GETDATE());
                
                IF NOT EXISTS (SELECT 1 FROM KhachHang_Voucher WHERE MaKH = @MaKH AND MaVoucher = 3)
                    INSERT INTO KhachHang_Voucher (MaKH, MaVoucher, NgayNhan) VALUES (@MaKH, 3, GETDATE());";

                    SqlCommand cmdPhat = new SqlCommand(sqlPhatVoucher, _conn);
                    cmdPhat.Parameters.AddWithValue("@MaKH", maKH);
                    cmdPhat.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { _conn.Close(); }
        } 
        // Lấy toàn bộ danh sách Voucher khách đang sở hữu và CHƯA TỪNG SỬ DỤNG ở các đơn trước
        public DataTable LayVoucherKhaDungCuaKhach(int maKH)
        {
            DataTable dt = new DataTable();
            try
            {
                if (_conn.State == ConnectionState.Closed) _conn.Open();

                
                string sql = @"
            SELECT V.MaVoucher, V.TenVoucher, V.PhanTramGiam, V.DieuKienApDung 
            FROM KhachHang_Voucher KHV
            INNER JOIN Voucher V ON KHV.MaVoucher = V.MaVoucher
            WHERE KHV.MaKH = @MaKH 
              AND V.TrangThai = 1 
              AND V.NgayHetHan >= GETDATE()";

                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally { _conn.Close(); }
            return dt;
        }
    }
}