﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="CaRental.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead">
        <h1 style="color:yellow">Shopping Cart</h1>
    </div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="false" ShowFooter="true" GridLines="Vertical" CellPadding="4" ItemType="CaRental.Models.CartItem" SelectMethod="GetShoppingCartItems" CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="Car.CarID" HeaderText="ID" SortExpression="CarID" />
            <asp:BoundField DataField="Car.CarName" HeaderText="Name" />
            <asp:BoundField DataField="Car.UnitPrice" HeaderText="Price (each)" DataFormatString="{0:c}" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40" runat="server" Text="<%#:Item.Quantity %>">

                    </asp:TextBox>
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Item Total">
                <ItemTemplate>
                    <%#:String.Format("{0:c}",((Convert.ToDouble(Item.Quantity)) * Convert.ToDouble(Item.Car.UnitPrice))) %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Remove Item">
                <ItemTemplate>
                    <asp:CheckBox ID="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: "></asp:Label>
            <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <br />
    <table>
        <tr>
            <td>
                <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" ></asp:Button>
            </td>
            <td>
                <!--Placeholder for checkout -->
            </td>
        </tr>
    </table>
</asp:Content>
