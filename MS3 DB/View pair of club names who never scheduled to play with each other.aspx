<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View pair of club names who never scheduled to play with each other.aspx.cs" Inherits="MS3_DB.View_pair_of_club_names_who_never_scheduled_to_play_with_each_other" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="club1" HeaderText="club1" SortExpression="club1" />
                    <asp:BoundField DataField="club2" HeaderText="club2" SortExpression="club2" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT c1.name as club1 ,c2.name as club2
FROM club c1, club c2
where c1.id &gt; c2.id and not exists (select c11.name, c22.name
				from match m inner join club c11 on m.host_ID = c11.id 
				inner join club c22 on m.guest_id = c22.id
				where (c11.id = c1.id and c22.id = c2.id) OR (c11.id  = c2.id and c22.id = c1.id));"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
