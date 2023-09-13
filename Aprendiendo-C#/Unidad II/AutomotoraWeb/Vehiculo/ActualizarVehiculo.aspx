<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ActualizarVehiculo.aspx.cs" Inherits="AutomotoraWeb.Vehiculo.ActualizarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    <table>
        <tr>
            <td><asp:Label ID="lblId" runat="server" Text="Id vehículo"></asp:Label></td>
            <td><asp:Label ID="lblIdValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblMarca" runat="server" Text="Marca Vehículo"></asp:Label></td>
            <td><asp:TextBox ID="txtMarca" runat="server" Text=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblModelo" runat="server" Text="Modelo vehículo"></asp:Label></td>
            <td><asp:TextBox ID="txtModelo" runat="server" Text=""></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAnio" runat="server" Text="Año del vehículo"></asp:Label></td>
            <td><asp:Label ID="lblAnioValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblVIN" runat="server" Text="VIN vehículo"></asp:Label></td>
            <td><asp:Label ID="lblVIN_Value" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblTipoMotor" runat="server" Text="Tipo motor vehículo"></asp:Label></td>
            <td><asp:Label ID="lblTipoMotorValue" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnVolver" runat="server" Text="Volver" OnClientClick="JavaScript:window.history.back(1); return false;"/></td>
            <td><asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/></td>
        </tr>
    </table>
</asp:Content>
