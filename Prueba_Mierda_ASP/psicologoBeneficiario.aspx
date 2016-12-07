﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="psicologoBeneficiario.aspx.cs" Inherits="Prueba_Mierda_ASP.psicologoBeneficiario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="nombre" runat="server" CssClass="auto-style3" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            Apellido paterno:
            <asp:TextBox ID="paterno" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            Apellido materno:
            <asp:TextBox ID="materno" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            Teléfono:
            <asp:TextBox ID="telefono" runat="server" CssClass="auto-style1" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="salir" runat="server" OnClick="salir_Click" Text="Salir" />
    
    </div>
    </form>
</body>
</html>
