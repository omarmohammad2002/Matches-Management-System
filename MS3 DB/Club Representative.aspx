<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Club Representative.aspx.cs" Inherits="MS3_DB.Club_Representative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CLUB REPRESENTATIVE PAGE<br />
            <br />
            VIEWS:<br />
            <asp:Button ID="View_pair_of_club_names_who_never_scheduled_to_play_with_each_other" runat="server" Text="View club information" OnClick="View_pair_of_club_names_who_never_scheduled_to_play_with_each_other_Click" />
            <br />
            <br />
            <asp:Button ID="View_all_upcoming_matches_for_the_club" runat="server" Text="View all upcoming matches for the club" OnClick="View_all_upcoming_matches_for_the_club_Click" />
            <br />
            <br />
            <asp:Button ID="View_all_available_stadiums" runat="server" Text="View all available stadiums" OnClick="View_all_available_stadiums_Click" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <br />
            Sending Requests :<br />
            Stadium name
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Stadium]"></asp:SqlDataSource>
            <br />
            Start time<br />
            <asp:TextBox ID="TextBox3" runat="server" TextMode ="DateTimeLocal"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send request" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView3" runat="server">
            </asp:GridView>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
