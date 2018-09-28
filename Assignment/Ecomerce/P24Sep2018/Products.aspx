<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="P22Sep2018_Auth.Products" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
        <div>
            <asp:TextBox ID="SearchBox" runat="server"  style="height: 22px"></asp:TextBox>
            <%--<asp:Button ID="Button1" runat="server" Text="products" OnClick="Button1_Click" />--%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Search" runat="server" OnClick="Search_Click" Text="Search" />
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </div>
    
</asp:Content>
