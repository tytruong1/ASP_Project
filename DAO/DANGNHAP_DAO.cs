using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DANGNHAP_DAO
    {
        public static bool KT_TaiKhoan_TonTai(string tk)
        {
            string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENTAIKHOAN=@TENTK";
            SqlParameter[] paramet = new SqlParameter[1];
            paramet[0] = new SqlParameter("@TENTK", tk);

            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, paramet).Rows[0][0]) == 1;
        }

        public static string KiemTraTaiKhoan(string tk)
        {
            string query = "SELECT MATKHAU FROM TAIKHOAN WHERE TENTAIKHOAN=@TENTK";
            SqlParameter[] paramet = new SqlParameter[1];
            paramet[0] = new SqlParameter("@TENTK", tk);

            return DataProvider.ExecuteSelectQuery(query, paramet).Rows[0][0].ToString();
        }
    }
}
