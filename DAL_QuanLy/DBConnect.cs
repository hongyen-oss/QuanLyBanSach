using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=.;Initial Catalog=QuanLyBanSach;Integrated Security=True");
        
        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
                da.Fill(dt);
            }
            catch { }
            return dt;
        }

       
        public bool ExecuteNonQuery(string sql)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                if (cmd.ExecuteNonQuery() > 0) return true;
            }
            catch { return false; }
            finally { _conn.Close(); }
            return false;
        }
    }
}
    