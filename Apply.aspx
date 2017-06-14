<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Apply.aspx.cs" Inherits="Apply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grant Application</title>
</head>
<body>
    <h1>Apply for a Grant</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Grant Type"></asp:Label>
        <asp:DropDownList ID="grantType" runat="server" ValidateRequestMode="Enabled"></asp:DropDownList>

         <asp:Label ID="Label2" runat="server" Text="Grant Explanation"></asp:Label>
        <asp:TextBox ID="explanation" runat="server" OnTextChanged="explanation_TextChanged" ValidateRequestMode="Enabled"></asp:TextBox><br />

         <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
        <asp:TextBox ID="amount" runat="server" ValidateRequestMode="Enabled" Visible="False"></asp:TextBox><br />

        <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>
        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />

    </div>
    </form>
</body>
</html>
