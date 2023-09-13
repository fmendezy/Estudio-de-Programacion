<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarPelicula.aspx.cs" Inherits="CineWeb.Pelicula.AgregarPelicula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="lblNombre" runat="server" Text="Nombre Pelicula"></asp:Label></td>
            <td><asp:TextBox ID="txtNombre" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblDirector" runat="server" Text="Director"></asp:Label></td>
            <td><asp:TextBox ID="txtDirector" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblIdioma" runat="server" Text="Idioma"></asp:Label></td>
            <td><asp:DropDownList ID="ddlIdioma" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblDuracion" runat="server" Text="Duración"></asp:Label></td>
            <td><asp:TextBox ID="txtDuracion" runat="server" TextMode="Number"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblValoracion" runat="server" Text="Valoración"></asp:Label></td>
            <td><asp:DropDownList ID="ddlValoracion" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEsTodoPublico" runat="server" Text="Es para todo público"></asp:Label></td>
            <td><asp:CheckBox ID="chbEsTodoPublico" runat="server" Text="Todo público"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEnCartelera" runat="server" Text="Esta en Cartelera"></asp:Label></td>
            <td><asp:CheckBox ID="chbEnCartelera" runat="server" Text="En cartelera"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblTieneSubtitulos" runat="server" Text="Tiene Subtitulos"></asp:Label></td>
            <td><asp:CheckBox ID="chbTieneSubtitulos" runat="server" Text="Subtitulada"/></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblFechaEstreno" runat="server" Text="Fecha de estreno"></asp:Label></td>
            <td><asp:Calendar ID="calFechaEstreno" runat="server" FirstDayOfWeek="Monday" DayNameFormat="Shortest" BackColor="White" BorderColor="#999999" CellPadding="4" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
            <NextPrevStyle VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#808080" />
            <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" />
            <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
            <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
            <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnAgregarPelicula" runat="server" Text="Agregar Pelicula" OnClick="btnAgregarPelicula_Click"></asp:Button></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
