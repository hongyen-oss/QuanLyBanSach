using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_QuanLy
{
    public class DAL_ThongKe : DBConnect
    {
        public DataTable ThongKeKhachHang(DateTime tuNgay, DateTime denNgay)
        {
            return LayDuLieuProc("sp_ThongKeKhachHang", tuNgay, denNgay);
        }
        public DataTable ThongKeDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            return LayDuLieuProc("sp_ThongKeDoanhThu", tuNgay, denNgay);
        }


        public DataTable ThongKeSachBanChay(int top, DateTime tuNgay, DateTime denNgay)
        {
            return LaySachBanChay(top, tuNgay, denNgay);
        }

        public DataTable LaySachBanChay(int top, DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                if (_conn.State == ConnectionState.Closed) _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_ThongKeSachBanChay", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Top", top);
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }



        public DataTable LayDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                if (_conn.State == ConnectionState.Closed) _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_ThongKeDoanhThu", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
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


        public DataTable LayTopKhachHang(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ThongKeKhachHang", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@DenNgay", denNgay);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private DataTable LayDuLieuProc(string procName, DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            try
            {
                if (_conn.State == ConnectionState.Closed) _conn.Open();

                SqlCommand cmd = new SqlCommand(procName, _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }
    }
}