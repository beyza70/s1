<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kayıt.aspx.cs" Inherits="GOLDA.Kayıt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 52px;
        }
        .auto-style2 {
            width: 1130px;
        }
    </style>
</head>
<body style="height: 588px">
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">
                <asp:FileUpload ID="fu_vardiya" runat="server" />
                <asp:Button ID="btn_gönder" runat="server" OnClick="btn_gönder_Click" Text="Gönder" />
            </h1>
        </div>
        <p>
        <asp:Label ID="lbl_kaydet" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style2">
            <asp:Calendar ID="Calendar_Tarih" runat="server" format="dd/MM/yyyy" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="274px" OnSelectionChanged="Calendar_Tarih_SelectionChanged">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="D_göster" runat="server" OnClick="D_göster_Click" Text="Dosyayı Göster" />
            <asp:Button ID="D_sil" runat="server" OnClick="D_sil_Click" Text="Dosya Sil" />
        </p>
        <p>
            <asp:GridView ID="GridView_Vardiya" runat="server"  Width="504px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
&nbsp;</p>
    </form>
</body>
</html>
