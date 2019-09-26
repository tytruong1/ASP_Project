<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DANGKY.aspx.cs" Inherits="GUI.DANGKY" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                    <table>
                        <tr>
                            <td>Tên Tài Khoản:</td>
                            <td>
                                <asp:TextBox ID="txtTenTK" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Mật Khẩu:</td>
                            <td>
                                <asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Email:</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>SĐT:</td>
                            <td>
                               <asp:TextBox ID="txtSoDienThoai" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Địa Chỉ:</td>
                            <td>
                                <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Họ Tên:</td>
                            <td>
                                <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Ảnh Đại Diện:</td>
                            <td>
                                <asp:TextBox ID="txtAnhDaiDien" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Button ID="btnDangKy" runat="server" Text="Đăng Ký" OnClick="btnDangKy_Click"></asp:Button></td>
                            <td>
                                <asp:Button ID="btnHuyBo" runat="server" Text="Hủy Bỏ"></asp:Button>
                            </td>
                        </tr>
                    </table>
        </center>
        </div>
    </form>
</body>
</html>
