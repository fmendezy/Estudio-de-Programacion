<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ActualizarPelicula.aspx.cs" Inherits="CineWeb.Pelicula.ActualizarPelicula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"/>
    <table>
        <tr>
            <td><asp:Label ID="lblId" runat="server" Text="ID" /></td>
            <td><asp:Label ID="lblId_Value" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblNombre" runat="server" Text="Nombre pelicula"/></td>
            <td><asp:Label ID="lblNombre_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblValoracion" runat="server" Text="Ingrese la nueva valoración" /></td>
            <td><asp:DropDownList ID="ddlValoracion" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEnCartelera" runat="server" Text="Quitar o poner en cartelera"/></td>
            <td><asp:CheckBox ID="chkEnCartelera" runat="server" Text="Quitar o poner en cartelera"/></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnVolver" runat="server" Text="Volver" OnClientClick="JavaScript:window.history.back(1); return false;"/></td>
            <td><asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/></td>
        </tr>
    </table>
</asp:Content>
