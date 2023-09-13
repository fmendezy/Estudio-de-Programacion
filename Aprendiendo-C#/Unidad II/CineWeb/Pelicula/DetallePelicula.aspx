<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetallePelicula.aspx.cs" Inherits="CineWeb.Pelicula.DetallePelicula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"/>
    <table>
        <tr>
            <td><asp:Label ID="lblId" runat="server" Text="Id" /></td>
            <td><asp:Label ID="lblId_Value" runat="server" Text="" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblNombre" runat="server" Text="Nombre pelicula" /></td>
            <td><asp:Label ID="lblNombre_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblDirector" runat="server" Text="Director" /></td>
            <td><asp:Label ID="lblDirector_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblIdioma" runat="server" Text="Idioma" /></td>
            <td><asp:Label ID="lblIdioma_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblDuracion" runat="server" Text="Duración en minutos" /></td>
            <td><asp:Label ID="lblDuracion_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblValoracion" runat="server" Text="Valoración" /></td>
            <td><asp:Label ID="lblValoracion_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEsTodoPublico" runat="server" Text="Es para todo público" /></td>
            <td><asp:Label ID="lblEsTodoPublico_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEnCartelera" runat="server" Text="Esta en cartelera" /></td>
            <td><asp:Label ID="lblEnCartelera_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblTieneSubtitulo" runat="server" Text="Es subtitulada" /></td>
            <td><asp:Label ID="lblTieneSubtitulo_Value" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblFechaEstreno" runat="server" Text="Fecha de estreno" /></td>
            <td><asp:Label ID="lblFechaEstreno_Value" runat="server"/></td>
        </tr>
        <tr>            
            <td><asp:Button ID="btnVolver" runat="server" Text="Volver" OnClientClick="JavaScript:window.history.back(1); return false;"/></td>
            <td><asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/></td>
            <td><asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/></td>
        </tr>
    </table>
</asp:Content>
