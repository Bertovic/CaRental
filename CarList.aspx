<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarList.aspx.cs" Inherits="CaRental.CarList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>
            <asp:ListView ID="carList" runat="server" DataKeyNames="CarID" GroupItemCount="3" ItemType="CaRental.Models.Car" SelectMethod="GetCars">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    </td>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="CarDetails.aspx?carID=<%#:Item.CarID %>">
                                        <img src="/Images/<%#:Item.Images %>" width="250" height="200" style="border:solid" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="CarDetails.aspx?carID=<%#:Item.CarID %>" style="color:yellow">
                                        <span>
                                            <%#:Item.CarName %>
                                        </span>
                                    </a>
                                    <br />
                                    <span style="color:yellow">
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice) %>
                                    </span>
                                    <br />
                                    <a href="AddToCart.aspx?carID=<%#:Item.CarID %>" style="color:yellow">
                                        <span class=" CarListItem">
                                            <b>Add To Cart</b>
                                        </span>
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
