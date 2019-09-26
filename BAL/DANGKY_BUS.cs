using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
   public class DANGKY_BUS
    {
       public static string DangKyThongTin(TAIKHOAN account)
       {
           if(DANGKY_DAO.DangKyThongTin(account))
               return "Đăng Ký Thành Công";
           return "Đăng Ký Thất Bại";
       }
    }
}
