<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prueba_Mierda_ASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Marillac</title>
    <link href="Estilos_Login.css" rel="stylesheet" />
    <style type="text/css">
        #form1 {
            width: 1260px;
            height: 507px;
            z-index: 1;
            left: 15px;
            top: 16px;
            position: absolute;
            margin-left: 0px;
        }
    </style>
</head>
<body style="z-index: 1; left: 52px; top: -2px; position: absolute; height: 638px; width: 1290px">
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" BorderStyle="Solid" style="z-index: 1; left: 460px; top: 23px; position: absolute; height: 116px; width: 365px; margin-top: 3px;" CssClass="imagen_login" />
        <asp:Label ID="Label1" runat="server" CssClass="Elementos_Login" Font-Size="Medium" style="z-index: 1; left: 461px; top: 180px; position: absolute; width: 81px" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 654px; top: 243px; position: absolute; width: 175px;" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 648px; top: 178px; position: absolute; width: 180px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" CssClass="Elementos_Login" style="z-index: 1; top: 245px; position: absolute; left: 456px; width: 85px" Text="Password:"></asp:Label>
        <asp:Button ID="Button_Ingresar" runat="server" CssClass="Elementos_Login" Font-Size="Medium" style="z-index: 1; left: 583px; top: 305px; position: absolute; width: 147px; height: 43px" Text="Ingresar" OnClick="Button_Ingresar_Click" />
    </form>
</body>
</html>
