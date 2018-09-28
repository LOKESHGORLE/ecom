<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventAndControl.aspx.cs" Inherits="EventAndControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <asp:Button runat="server" Text="Button" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
