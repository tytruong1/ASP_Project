using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;

namespace GUI
{
    public partial class DANGKY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            TAIKHOAN account = new TAIKHOAN(txtTenTK.Text, txtMatKhau.Text,txtEmail.Text, txtSoDienThoai.Text,txtDiaChi.Text, txtHoTen.Text, 0, txtAnhDaiDien.Text,1);
            Response.Write( DANGKY_BUS.DangKyThongTin(account));
        }
    }
}