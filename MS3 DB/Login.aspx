<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MS3_DB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="loginpage" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please login using username and password"></asp:Label>
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="USERNAME"></asp:Label>
        <br />
        <asp:TextBox ID="USERNAME" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="PASSWORD"></asp:Label>
        <br />
        <asp:TextBox ID="PASSWORD" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="LOGINID" runat="server" OnClick="LOGINCLICK" Text="LOGIN" />
        <br />
        <br />
        Dont have an account?
        <asp:Button ID="REGISTERID" runat="server" Text="REGISTER" OnClick="REGISTERCLICK" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
