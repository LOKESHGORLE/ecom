<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductManagement1.aspx.cs" Inherits="P24Sep2018.Product_Management.ProductManagement1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Insert" runat="server" Text="Add To Cart" />
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
