using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TAIKHOAN_BUS
    {
        public static bool KiemTraTaiKhoan(string tk, string mk)
        {
            if (DANGNHAP_DAO.KT_TaiKhoan_TonTai(tk))
                return DANGNHAP_DAO.KiemTraTaiKhoan(tk) == mk;
            return false;
        }
    }
}
