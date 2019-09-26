<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DANGNHAP.aspx.cs" Inherits="GUI.DANGNHAP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tài Khoản:<asp:TextBox ID="txtTaiKhoan" runat="server"></asp:TextBox><br />
            Mật Khẩu:<asp:TextBox ID="txtNatKhau" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="btnDangNhap" OnClick="btnDangNhap_Click" runat="server" Text="Đăng Nhập" />
        </div>
    </form>
</body>
</html>
