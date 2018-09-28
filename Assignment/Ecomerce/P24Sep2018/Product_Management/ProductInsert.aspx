<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductInsert.aspx.cs" Inherits="P24Sep2018.Product_Management.ProductInsert" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Product Brand</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Name] FROM [ProductBrands]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Product Name</td>
                    <td>
                        <asp:TextBox ID="ProductName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Price</td>
                    <td>
                        <asp:TextBox ID="ProductPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Product URL</td>
                    <td>
                        <asp:TextBox ID="ProductURL" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Description</td>
                    <td>
                        <asp:TextBox ID="Description" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <table class="auto-style1">
                <tr>
                   
                   
                     <%if (Request.QueryString["Act"] == "1")
                         {%>
                    <td class="auto-style3">
                        <asp:Button ID="Update" runat="server" OnClick="Update_Click" Text="Update" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
                    </td>
                    <%}
    else
    {%>
                     <td class="auto-style3">
                        <asp:Button ID="Insert" runat="server" OnClick="Insert_Click" Text="Insert" />
                    </td><%} %>
                </tr>
            </table>
        </div>
   </asp:Content>