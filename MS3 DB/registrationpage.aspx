<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrationpage.aspx.cs" Inherits="MS3_DB.registrationpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="registrationpage" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="REGISTRATION PAGE"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Users registration type"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="1"> Sports Association Manager</asp:ListItem>
                <asp:ListItem Value="2">Club Representative</asp:ListItem>
                <asp:ListItem Value="3">Stadium Manager</asp:ListItem>
                <asp:ListItem Value="4">Fan</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="namereg" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="username"></asp:Label>
            <br />
            <asp:TextBox ID="usernamereg" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="password"></asp:Label>
            <br />
            <asp:TextBox ID="passwordreg" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="if club representative, write name of an already existing club"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Club]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="if stadium manager, write name of an already existing stadium"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CONNECTION %>" SelectCommand="SELECT [name] FROM [Stadium]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="if fan, write your national id number"></asp:Label>
            <br />
            <asp:TextBox ID="nationalidreg" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="if fan, write your phone number"></asp:Label>
            <br />
            <asp:TextBox ID="numberreg" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="if fan, write your birthdate"></asp:Label>
            <br />
            <asp:TextBox ID="birthdatereg" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="if fan, write your address"></asp:Label>
            <br />
            <asp:TextBox ID="addressreg" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="CREATEACCOUNTID" runat="server" Text="CREATE ACCOUNT" OnClick="CreateClick" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
