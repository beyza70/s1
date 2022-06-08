<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kullanici_girisi.aspx.cs" Inherits="GOLDA.Kullanici_girisi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 139px;
            height: 26px;
        }
        .auto-style5 {
            width: 207px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style2 {
            width: 139px;
        }
        .auto-style3 {
            width: 207px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h2>Kullanıcı Girişi</h2>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Kullanıcı Adı</td>
                <td id="txt_kadi0" class="auto-style5">
                    <asp:TextBox ID="Txt_kadi" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">Şifre</td>
                <td id="txt_sifre0" class="auto-style3">
                    <asp:TextBox ID="Txt_sifre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btn_giris" runat="server" OnClick="btn_giris_Click" Text="Giris" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_kayıt_ol" runat="server" OnClick="btn_kayıt_ol_Click" Text="Kayıt Ol" />
                    <br />
                    <br />
                    <asp:Label ID="lbl_giris" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </form>
    
</body>
</html>
