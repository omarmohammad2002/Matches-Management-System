<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StadiumManager.aspx.cs" Inherits="MS3_DB.StadiumManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            STADIUM MANAGER PAGE<br />
            <br />
            <br />
            <asp:Button ID="View_all_related_information_of_the_Stadium" runat="server" OnClick="View_all_related_information_of_the_Stadium_Click" Text="View all related information of the Stadium" />
            <br />
            <br />
            <asp:Button ID="View_all_requests_he_already_received" runat="server" OnClick="View_all_requests_he_already_received_Click" Text="View all requests he already received" />
            <br />
            <br />
            Accepting request<br />
            Host name<br />
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Guest name<br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Start time<br />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Accept" />
            <br />
            <br />
            Rejecting request<br />
            Host name<br />
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Guest name<br />
            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Start time<br />
            <asp:TextBox ID="TextBox6" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reject" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
