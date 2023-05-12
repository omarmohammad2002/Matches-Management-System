<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View All upcoming matches.aspx.cs" Inherits="MS3_DB.View_All_upcoming_matches" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="start_time" HeaderText="start_time" SortExpression="start_time" />
                <asp:BoundField DataField="end_time" HeaderText="end_time" SortExpression="end_time" />
                <asp:BoundField DataField="attendees" HeaderText="attendees" SortExpression="attendees" />
                <asp:BoundField DataField="host_id" HeaderText="host_id" SortExpression="host_id" />
                <asp:BoundField DataField="guest_id" HeaderText="guest_id" SortExpression="guest_id" />
                <asp:BoundField DataField="stadium_id" HeaderText="stadium_id" SortExpression="stadium_id" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="select * from match where start_time &gt;current_timestamp"></asp:SqlDataSource>
    </form>
</body>
</html>
