<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="PrimerosPasosConASPNET.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtPrimerNumero" runat="server" Text=""></asp:TextBox>
            <asp:TextBox ID="txtSegundoNumero" runat="server" Text=""></asp:TextBox>
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
            <br /> <br /> 
            <asp:Label ID="lblResultados" runat="server" Text=""></asp:Label>
            <br /> <br /> 
            <asp:Label ID="lblSuma" runat="server" Text=""></asp:Label>
            <br /> 
            <asp:Label ID="lblMultiplicacion" runat="server" Text=""></asp:Label>
            <br /> 
            <asp:Label ID="lblResta" runat="server" Text=""></asp:Label>
            <br /> 
            <asp:Label ID="lblDivision" runat="server" Text=""></asp:Label>
            <br /> 


        </div>
    </form>
</body>
</html>
