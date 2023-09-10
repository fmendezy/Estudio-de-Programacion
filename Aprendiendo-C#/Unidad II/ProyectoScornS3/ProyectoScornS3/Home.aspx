<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProyectoScornS3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Soy un texto plano agregado directamente en <br />
            asp.net sin utilizar controles ni etiquetas,
            salvo por "br" que sirve como salto de linea.
            Cumple la misma funcion que "\n" es un string.<br />

            <asp:Label ID="lblSaludo" runat="server" Text="Hola!"></asp:Label>
        </div>
    </form>
</body>
</html>
