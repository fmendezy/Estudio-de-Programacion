<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ControlesASPNET.aspx.cs" Inherits="PrimerosPasosConASPNET.ControlesASPNET" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID=lblMensaje runat="server" Text="Escribe un mensaje"></asp:Label>
    <asp:TextBox ID=txtMensaje runat="server" Text="Escribe un mensaje"></asp:TextBox>
    <asp:Button ID="btnEnviarMensaje" runat="server" Text="Enviar Mensaje" OnClick="btnEnviarMensaje_Click"/>
    <br />
    <br />
    <asp:Label ID="lblMensajeRecibido" runat="server" Text=""></asp:Label>
</asp:Content>
