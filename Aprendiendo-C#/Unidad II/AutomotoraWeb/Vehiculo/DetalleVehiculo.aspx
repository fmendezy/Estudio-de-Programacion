<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalleVehiculo.aspx.cs" Inherits="AutomotoraWeb.Vehiculo.DetalleVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <br />
    <table>
        <tr>
            <td><asp:Label ID="lblId" runat="server" Text="Id"></asp:Label></td>
            <td><asp:Label ID="lblIdValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblMarca" runat="server" Text="Marca del vehículo"></asp:Label></td>
            <td><asp:Label ID="lblMarcaValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblModelo" runat="server" Text="Modelo del vehículo"></asp:Label></td>
            <td><asp:Label ID="lblModeloValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAnio" runat="server" Text="Año del vehículo"></asp:Label></td>
            <td><asp:Label ID="lblAnioValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblVIN" runat="server" Text="VIN del vehículo"></asp:Label></td>
            <td><asp:Label ID="lblVIN_Value" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblTipoMotor" runat="server" Text="Tipo motor"></asp:Label></td>
            <td><asp:Label ID="lblTipoMotorValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnVolver" runat="server" Text="Volver" OnClientClick="JavaScript:window.history.back(1); return false;" /></td>
            <td><asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/></td>
            <td><asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/></td>
        </tr>
    </table>
</asp:Content>
