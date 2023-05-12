<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FAN.aspx.cs" Inherits="MS3_DB.FAN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            FAN PAGE<br />
            Date<br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Button ID="View_all_matches_that_have_available_tickets" runat="server" Text="View all matches that have available tickets" OnClick="View_all_matches_that_have_available_tickets_Click" />
            <br />
            <br />
            Purchase ticket
            <br />
            Host club<br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Guest club<br />
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Start time<br />
            <asp:TextBox ID="TextBox4" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Purchase" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
