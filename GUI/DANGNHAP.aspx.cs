using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace GUI
{
    public partial class DANGNHAP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text, password = txtNatKhau.Text;
            if (TAIKHOAN_BUS.KiemTraTaiKhoan(username, password))
            {
                Response.Write("Đăng Nhập Thành Công");
            }
            else
            {
                Response.Write("Đăng Nhập Thất Bại");
            }
        }
    }
}