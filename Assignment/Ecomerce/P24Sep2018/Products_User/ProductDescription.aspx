<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDescription.aspx.cs" Inherits="P24Sep2018.Products_User.ProductDescription" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div id="Description">
            <asp:Image ID="ProductImage" runat="server" Height="153px" Width="160px" />
            <br />
            <asp:Label ID="ProductName" runat="server" Text="ProductName"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Price" runat="server" Text="Price"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Description" runat="server" Text="Description"></asp:Label>
            <br />
            <br />
            <asp:Button ID="AddToCart" runat="server" OnClick="AddToCart_Click" Text="Add To Cart" />
        </div>
    </asp:Content>
