<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SportsAssociationManager.aspx.cs" Inherits="MS3_DB.SportsAssociationManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SPORTS ASSOCIATION MANAGER PAGE<br />
            <br />
            <br />
            <br />
            Add Match<br />
            Host club name<br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Guest club name<br />
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            Start time<br />
            <asp:TextBox ID="TextBox3" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            End time<br />
        </div>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Addmatchbutton1" runat="server" OnClick="Addmatchbutton" Text="Add Match" Width="132px" />
        </p>
        <p>
            DELETE MATCH</p>
        <p>
            Host club name</p>
        <p>
            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
        </p>
        <p>
            Guest club name</p>
        <p>
            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
        </p>
        <p>
            Start time</p>
        <p>
            <asp:TextBox ID="TextBox7" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
        </p>
        <p>
            End time</p>
        <p>
            <asp:TextBox ID="TextBox8" runat="server" TextMode="DateTimeLocal" OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="deletematch" runat="server" style="margin-bottom: 0px" Text="Delete Match" OnClick="deletematch_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            VIEWS :</p>
        <p>
            <asp:Button ID="View_All_upcoming_matches" runat="server" Text="View All upcoming matches" OnClick="View_All_upcoming_matches_Click" />
            </p>
        <p>
            <asp:Button ID="View_already_played_matches" runat="server" Text="View already played matches" OnClick="View_already_played_matches_Click" />
        </p>
        <p>
            <asp:Button ID="View_pair_of_club_names_who_never_scheduled_to_play_with_each_other" runat="server" Text="View pair of club names who never scheduled to play with each other" OnClick="View_pair_of_club_names_who_never_scheduled_to_play_with_each_other_Click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
