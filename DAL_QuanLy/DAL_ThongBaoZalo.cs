using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Net;
using System.Net.Mail;
namespace DAL_QuanLy
{
    public class DAL_ThongBao: DBConnect
    {
        DBConnect db = new DBConnect();

        public DataTable GetDanhSachTheLoai()
        {
            string sql = "SELECT TenTheLoai FROM TheLoai";
            return db.GetDataTable(sql);
        }
        public void InsertThongBao(DTO_ThongBao tb)
        {
            string sql = "INSERT INTO ThongBaoZalo (MaKH, NoiDung, NgayGui, TrangThai) " +
                         "VALUES (@MaKH, @NoiDung, @NgayGui, @TrangThai)";

            SqlParameter[] param = {
            new SqlParameter("@MaKH", tb.MaKH),
            new SqlParameter("@NoiDung", tb.NoiDung),
            new SqlParameter("@NgayGui", tb.NgayGui),
            new SqlParameter("@TrangThai", tb.TrangThai)
        };


            DBConnect db = new DBConnect();
            DataTable dt = db.GetDataTable(sql);
        }
        public DataTable GetAllThongBao()
        {
            string sql = "SELECT * FROM ThongBaoZalo";
            DBConnect db = new DBConnect();
            return db.GetDataTable(sql);
        }
        
        public DataTable GetKhachHangTheoTheLoai(string tenTheLoai)
        {
            string sql = @"SELECT DISTINCT KH.MaKH, KH.HoTen, KH.SDT, KH.Email
                   FROM KhachHang KH
                   JOIN HoaDon HD ON KH.MaKH = HD.MaKH
                   JOIN ChiTietHoaDon CTHD ON HD.MaHD = CTHD.MaHD
                   JOIN Sach S ON CTHD.MaSach = S.MaSach
                   JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai
                   WHERE TL.TenTheLoai = N'" + tenTheLoai + "'";


            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void GuiMail(string emailNhan, string tieuDe, string noiDung)
        {
            string emailGui = "abystore.system@gmail.com";
            string matKhauUngDung = "idun rdmi kzke ebjv"; 

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(emailGui, matKhauUngDung),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(emailGui),
                Subject = tieuDe,
                Body = noiDung,
                IsBodyHtml = true,
            };
            mailMessage.To.Add(emailNhan);

            smtpClient.Send(mailMessage);
        }
        public DataTable LaySachMoiNhatTheoTheLoai(string tenTheLoai)
        {
            string sql = @"SELECT TOP 1 MaSach, TenSach, GiaBan, MoTa, HinhAnh, NgayNhapKho 
               FROM Sach S 
               JOIN TheLoai TL ON S.MaTheLoai = TL.MaTheLoai 
               WHERE TL.TenTheLoai = N'" + tenTheLoai + @"'
               ORDER BY NgayNhapKho DESC";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    internal class DAL_ThongBaoZalo
    {
    }
}
