<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Prueba_Mierda_ASP.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 637px">
    <form id="form1" runat="server">
    <div style="height: 497px">
        
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" style="z-index: 1; left: 591px; top: 21px; position: absolute; height: 33px; width: 274px" Text="Crentro de Ayuda Marillac"></asp:Label>
        <asp:Button ID="Button_Beneficiarios" runat="server" OnClick="Button_Beneficiarios_Click" style="z-index: 1; left: 614px; top: 101px; position: absolute; height: 41px; width: 84px" Text="Beneficiarios" />
        <asp:Button ID="Button_Psicologos0" runat="server" OnClick="Button_psicologos_Click" style="z-index: 1; left: 491px; top: 100px; position: absolute; height: 41px; width: 84px" Text="Psicologos" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 496px; top: 179px; position: absolute; width: 109px" Text="Usuario:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 495px; top: 231px; position: absolute; width: 91px" Text="Password:"></asp:Label>
        
    </div>
    </form>
</body>
</html>
