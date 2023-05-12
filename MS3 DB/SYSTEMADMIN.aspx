<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SYSTEMADMIN.aspx.cs" Inherits="MS3_DB.SYSTEMADMIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SYSTEM ADMIN PAGE<br />
            <br />
            <br />
            <br />
            ADD NEW CLUB<br />
            NAME<br />
            <asp:TextBox ID="newclubname" runat="server"></asp:TextBox>
            <br />
            LOCATION<br />
            <asp:TextBox ID="newclublocname" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="addnewclubbutton" runat="server" Text="ADD CLUB" OnClick="addnewclubbutton_Click" />
            <br />
            <br />
            <br />
            DELETE CLUB<br />
            CLUB NAME<br />
            <asp:TextBox ID="deleteclubname" runat="server" Height="25px"></asp:TextBox>
            <br />
            <asp:Button ID="deleteclubbutton" runat="server" Text="DELETE CLUB" OnClick="deleteclubbutton_Click" />
            <br />
            <br />
            <br />
            ADD NEW STADIUM<br />
            NAME<br />
            <asp:TextBox ID="newstadiumname" runat="server"></asp:TextBox>
            <br />
            LOCATION<br />
            <asp:TextBox ID="newstadiumloc" runat="server"></asp:TextBox>
            <br />
            CAPACITY<br />
            <asp:TextBox ID="newstadiumcapacity" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addstadiumbutton" runat="server" Text="ADD STADIUM" OnClick="addstadiumbutton_Click" />
            <br />
            <br />
            <br />
            DELETE STADIUM<br />
            STADIUM NAME<br />
            <asp:TextBox ID="deletestadiumname" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="deletestadiumbutton" runat="server" Text="DELETE STADIUM" OnClick="deletestadiumbutton_Click" />
            <br />
            <br />
            <br />
            BLOCK FAN<br />
            FAN NATIONAL ID NUMBER<br />
            <asp:TextBox ID="nationalidnumber" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="blockfanbutton" runat="server" Text="BLOCK FAN" OnClick="blockfanbutton_Click" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
