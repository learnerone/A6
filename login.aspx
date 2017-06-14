<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <h1>Log In</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="User Name &nbsp;&nbsp;"></asp:Label>
        <asp:TextBox ID="userName" runat="server" ValidateRequestMode="Enabled"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Pass Word &nbsp;&nbsp;"></asp:Label><asp:TextBox ID="passWord" runat="server" ValidateRequestMode="Enabled"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Confirm Pass Word &nbsp;&nbsp;"></asp:Label><asp:TextBox ID="passWord2" runat="server" ValidateRequestMode="Enabled"></asp:TextBox><br />
        <asp:Label ID="errorLabal" runat="server" Text=""></asp:Label>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
    </div>
    </form>
</body>
</html>