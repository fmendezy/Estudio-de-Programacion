<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FormularioConMasterPage.aspx.cs" Inherits="PrimerosPasosConASPNET.FormularioConMasterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Soy un texto dentro del cuerpo de una página,
        que hereda diseño común desde un MasterPage">
    </asp:Label>
</asp:Content>

