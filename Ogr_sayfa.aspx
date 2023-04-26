<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ogr_sayfa.aspx.cs" Inherits="Ogrenci_kayıt_otomasyon.Ogr_sayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" BackColor="#3366CC" ForeColor="White" Height="62px" OnClick="Button1_Click" style="margin-left: 394px" Text="ÖĞRENCİ LİSTELE" Width="175px" />
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="200px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" style="margin-left: 213px" Width="520px"></asp:ListBox>
    </form>
</body>
</html>
