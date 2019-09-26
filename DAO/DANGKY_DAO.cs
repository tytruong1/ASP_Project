using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class DANGKY_DAO
    {
        public static bool DangKyThongTin(TAIKHOAN account)
        {
            string query = "INSERT INTO TAIKHOAN VALUES(@TenTaiKhoan,@MatKhau,@Email,@SDT,@DiaChi,@HoTen,@LaAdmin,@AnhDaiDien,@TrangThai)";
            SqlParameter[] paramet = new SqlParameter[9];
            paramet[0] = new SqlParameter("@TenTaiKhoan", account.tenTaiKhoan);
            paramet[1] = new SqlParameter("@MatKhau", account.matKhau);
            paramet[2] = new SqlParameter("@Email", account.email);
            paramet[3] = new SqlParameter("@SDT", account.sDT);
            paramet[4] = new SqlParameter("@DiaChi", account.diaChi);
            paramet[5] = new SqlParameter("@HoTen", account.hoTen);
            paramet[6] = new SqlParameter("@LaAdmin", account.laAdmin);
            paramet[7] = new SqlParameter("@AnhDaiDien", account.anhDaiDien);
            paramet[8] = new SqlParameter("@TrangThai", account.trangThai);
            return DataProvider.ExecuteInsertQuery(query, paramet) == 1;
        }
    }
}
