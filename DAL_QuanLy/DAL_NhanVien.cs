using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLy
{
    public class DAL_NhanVien : DBConnect
    {
        
        public DataTable getNhanVien()
        {
            string sql = "SELECT * FROM NhanVien";
            return GetDataTable(sql);
        }

        // Thêm nhân viên
        public bool themNhanVien(DTO_NhanVien nv)
        {
            string sql = string.Format("INSERT INTO NhanVien(HoTen, SDT, CaTruc, DiaChi, Gmail) VALUES(N'{0}', '{1}', N'{2}', N'{3}', N'{4}')",
                nv.HoTen, nv.SDT, nv.CaTruc, nv.DiaChi, nv.Gmail);
            return ExecuteNonQuery(sql);
        }

        // Sửa nhân viên
        public bool suaNhanVien(DTO_NhanVien nv)
        {
            string sql = string.Format("UPDATE NhanVien SET HoTen = N'{0}', SDT = '{1}', CaTruc = N'{2}', Gmail = '{3}', DiaChi = N'{4}' WHERE MaNhanVien = {5}",
        nv.HoTen, nv.SDT, nv.CaTruc, nv.DiaChi, nv.Gmail, nv.MaNhanVien);
            return ExecuteNonQuery(sql);
        }

        // Xóa nhân viên
        public bool xoaNhanVien(int ma)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNhanVien = " + ma;
            return ExecuteNonQuery(sql);
        }
        public object ExecuteScalar(string sql)
        {
            if (_conn.State == ConnectionState.Closed)
                _conn.Open();

            SqlCommand cmd = new SqlCommand(sql, _conn);
            object result = cmd.ExecuteScalar(); 

            _conn.Close();
            return result;
        }
        public int LayMaNVCuoiCung()
        {
            string sql = "SELECT ISNULL(MAX(MaNhanVien), 0) FROM NhanVien";
            return Convert.ToInt32(ExecuteScalar(sql));
        }
    }
}
