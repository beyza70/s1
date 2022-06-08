<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kayıt_ol.aspx.cs" Inherits="GOLDA.Kayıt_ol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            width: 14px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <h1>Kullanıcı Kaydet</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Kullanıcı Adı</td>
                    <td class="auto-style3">:</td>
                    <td>
                        <asp:TextBox ID="txt_kadi_kaydet" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Şifre</td>
                    <td class="auto-style3">:</td>
                    <td>
                        <asp:TextBox ID="txt_sifre_kaydet" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_kaydet" runat="server" OnClick="btn_kaydet_Click" Text="Kaydet" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="lbl_kayit" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="giris_sayfasi" runat="server" OnClick="giris_sayfasi_Click" Text="Giriş Sayfasına Git" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
    
</body>
</html>
