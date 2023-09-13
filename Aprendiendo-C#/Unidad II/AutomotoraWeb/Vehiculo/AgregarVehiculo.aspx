<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarVehiculo.aspx.cs" Inherits="AutomotoraWeb.AgregarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="lblMarca" runat="server" Text="Ingrese marca del Vehiculo"></asp:Label></td>
            <td><asp:TextBox ID="txtMarca" runat="server" Text=""></asp:TextBox></td>       
        </tr>
        <tr>
            <td><asp:Label ID="lblModelo" runat="server" Text="Ingrese modelo del vehiculo"></asp:Label></td>
            <td><asp:TextBox ID="txtModelo" runat="server" Text="" ></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblAnio" runat="server" Text="Ingrese el año del vehículo"></asp:Label></td>
            <td><asp:DropDownList ID="ddlAnio" runat="server"></asp:DropDownList></td>
        </tr>
         <tr>
            <td><asp:Label ID="lblVIN" runat="server" Text="Ingrese el VIN del vehiculo" ></asp:Label></td>
            <td><asp:TextBox ID="txtVIN" runat="server" Text="" ></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblEsElectrico" runat="server" Text="Ingrese el tipo de motor"></asp:Label></td>
            <td><asp:CheckBox ID="chkEsElectrico" runat="server" Text="Es electrico"></asp:CheckBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnAgregarVehiculo" runat="server" Text="Agregar Vehiculo" OnClick="btnAgregarVehiculo_Click" Width="142px" ></asp:Button></td>
        </tr>
        </tr>
    </table>
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</asp:Content>