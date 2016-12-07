<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_Pacientes.aspx.cs" Inherits="Prueba_Mierda_ASP.WebForm_Pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilos_generales.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label8" runat="server" CssClass="headers" style="z-index: 1; left: 597px; top: 11px; position: absolute" Text="Pacientes"></asp:Label>
    
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 613px; top: 61px; position: absolute" Text="Pacientes con Seguimiento"></asp:Label>
    
    </div>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 613px; top: 299px; position: absolute" Text="Pacientes sin Seguimiento"></asp:Label>
        <asp:Table ID="Table_Alta" runat="server" style="z-index: 1; left: 610px; top: 90px; position: absolute; height: 189px; width: 580px" BorderStyle="Solid">
        </asp:Table>
        <asp:Table ID="Table_No_Alta" runat="server" style="z-index: 1; left: 610px; top: 330px; position: absolute; height: 189px; width: 580px" BorderStyle="Solid">
        </asp:Table>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 160px; top: 70px; position: absolute" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 311px; top: 70px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 160px; top: 100px; position: absolute" Text="Apellido Paterno:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 311px; top: 100px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 160px; top: 130px; position: absolute" Text="Apellido Materno:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 311px; top: 130px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 160px; top: 160px; position: absolute" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 311px; top: 160px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 160px; top: 190px; position: absolute" Text="Colonia:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 311px; top: 190px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 160px; top: 220px; position: absolute" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 311px; top: 220px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 160px; top: 250px; position: absolute" Text="Sexo:"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 311px; top: 250px; position: absolute; width: 60px;"></asp:TextBox>

        <asp:Button ID="Button_Alta" runat="server" style="z-index: 1; left: 160px; top: 310px; position: absolute; width: 60px;" Text="Alta" />
        <asp:Button ID="Button_Baja" runat="server" style="z-index: 1; left: 260px; top: 310px; position: absolute; width: 60px;" Text="Baja" />
        <asp:Button ID="Button_Salir" runat="server" style="z-index: 1; left: 360px; top: 310px; position: absolute; width: 60px;" Text="Salir" />
    </form>
</body>
</html>
