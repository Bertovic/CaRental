<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarDetails.aspx.cs" Inherits="CaRental.CarDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="carDetail" runat="server" ItemType="CaRental.Models.Car" SelectMethod="GetCar" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1 style="color:yellow"><%#:Item.CarName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Images/<%#:Item.Images %>" style="border:solid;height:300px;width:350px" alt="<%#:Item.CarName %>" />
                                                       
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align:top;text-align:left;color:yellow;">
                        <b>Description:</b><br /><%#:Item.Description %>
                        <br />
                        <span>
                            <b>Price:</b>&nbsp;<%#:String.Format("{0:c}", Item.UnitPrice) %>
                        </span>
                        <br />
                        <span>
                            <b>Car Number:</b>&nbsp;<%#:Item.CarID %>
                        </span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
