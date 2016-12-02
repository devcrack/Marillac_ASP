<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForM_Beneficiarios.aspx.cs" Inherits="Prueba_Mierda_ASP.WebForM_Beneficiarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="estilos_generales.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">        
        <div style="height: 563px">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 590px; top: 28px; position: absolute; height: 52px; width: 195px; text-align: center" Text="Beneficiarios"></asp:Label>
            <asp:TextBox ID="TextBox_2" runat="server" style="z-index: 1; left: 689px; top: 170px; position: absolute; margin-top: 0px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 559px; top: 168px; position: absolute; right: 685px" Text="Apellido Paterno"></asp:Label>
            <asp:TextBox ID="TextBox_1" runat="server" style="z-index: 1; left: 689px; top: 113px; position: absolute; margin-top: 0px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 556px; top: 116px; position: absolute; right: 765px" Text="Nombre"></asp:Label>
    </div>
    </form>
</body>
</html>
