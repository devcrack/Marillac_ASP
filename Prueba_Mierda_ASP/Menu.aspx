<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Prueba_Mierda_ASP.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilos_generales.css" rel="stylesheet" />

    <style type="text/css">

.imagen_login {
    background-image: url('logoMarillac.png');
    background-repeat:no-repeat;
}

.auto-style1 
{
    text-align: center;
}

.border_button
{
    border-top-left-radius: 20px;
    border-top-right-radius: 20px;
    border-bottom-right-radius: 20px;
    border-bottom-left-radius : 20px;
}
    </style>
</head>
<body style="height: 637px">
    <form id="form1" runat="server">
    <div style="height: 497px; margin-left: 40px;" class="auto-style1">
        
        <%--<asp:Label ID="Label1" runat="server" Font-Size="Larger" style="z-index: 1; left: 591px; top: 21px; position: absolute; height: 33px; width: 274px" Text="Crentro de Ayuda Marillac"></asp:Label>--%>
        <asp:Button ID="Button_Beneficiarios" runat="server" OnClick="Button_Beneficiarios_Click" style="z-index: 1; left: 674px; top: 227px; position: absolute; height: 41px; width: 100px" Text="Beneficiarios" CssClass="buttons" />
        <asp:Button ID="Button_Hijos" runat="server" OnClick="Button_psicologos_Click" style="z-index: 1; left: 532px; top: 301px; position: absolute; height: 41px; width: 100px; text-align: justify;" Text="Hijos" CssClass="buttons" />
        <asp:Button ID="Button_Actividades" runat="server" OnClick="Button_Actividades_Click" style="z-index: 1; left: 679px; top: 301px; position: absolute; height: 41px; width: 100px" Text="Actividades" CssClass="buttons"/>
        <asp:Button ID="Button_Profesores0" runat="server" OnClick="Button_Beneficiarios_Click" style="z-index: 1; left: 816px; top: 227px; position: absolute; height: 41px; width: 100px" Text="Profesores"  CssClass="buttons"/>
        <asp:Button ID="Button_Psicologos1" runat="server" OnClick="Button_psicologos_Click" style="z-index: 1; left: 534px; top: 230px; position: absolute; height: 41px; width: 100px; text-align: justify;" Text="Psicologos" CssClass="buttons"/>
        <asp:Button ID="Button_Actividades0" runat="server" OnClick="Button_Beneficiarios_Click" style="z-index: 1; left: 819px; top: 301px; position: absolute; height: 41px; width: 100px" Text="Salir" CssClass="buttons"/>
        <asp:Image ID="Image1" runat="server" style="z-index: 1; left: 528px; top: 74px; position: absolute; height: 116px; width: 386px; margin-top: 3px;" CssClass="imagen_login" />
        &nbsp;&nbsp;&nbsp;
                
    &nbsp;&nbsp;&nbsp;
        
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
