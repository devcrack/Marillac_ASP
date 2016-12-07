<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WForm_Psicologos.aspx.cs" Inherits="Prueba_Mierda_ASP.WForm_Psicologos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilos_generales.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 563px">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 590px; top: 28px; position: absolute; height: 52px; width: 195px; text-align: center" Text="Psicologos"></asp:Label>

        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 220px; top: 100px; position: absolute; right: 999px; height: 18px;" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox_1" runat="server" style="z-index: 1; left: 393px; top: 140px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 220px; top: 140px; position: absolute; right: 984px" Text="Apellido Paterno"></asp:Label>
        <asp:TextBox ID="TextBox_3" runat="server" style="z-index: 1; left: 394px; top:100px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>
        <asp:TextBox ID="TextBox_2" runat="server" style="z-index: 1; left: 393px; top: 180px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>        
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 220px; top: 180px; position: absolute; right: 983px" Text="Apellido Materno"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 220px; top: 220px; position: absolute; right: 983px" Text="Direccion"></asp:Label>
        <asp:TextBox ID="TextBox_4" runat="server" style="z-index: 1; left: 393px; top: 220px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>        
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 220px; top: 260px; position: absolute; right: 983px" Text="Colonia"></asp:Label>
        <asp:TextBox ID="TextBox_5" runat="server" style="z-index: 1; left: 393px; top: 260px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>        
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 220px; top: 300px; position: absolute; right: 983px" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="TextBox_7" runat="server" style="z-index: 1; left: 393px; top: 300px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>    
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 220px; top: 340px; position: absolute; right: 983px" Text="Sexo:"></asp:Label>
        <asp:TextBox ID="TextBox_8" runat="server" style="z-index: 1; left: 393px; top: 339px; position: absolute; margin-top: 0px; width: 56px;"></asp:TextBox>    
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 220px; top: 380px; position: absolute; right: 983px" Text="Limite Pacientes:"></asp:Label>
        <asp:TextBox ID="TextBox_9" runat="server" style="z-index: 1; left: 393px; top: 380px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>    
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 220px; top: 420px; position: absolute; right: 983px" Text="Fecha Nacimiento:"></asp:Label>
        <asp:TextBox ID="TextBox_10" runat="server" style="z-index: 1; left: 393px; top: 420px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>    
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 220px; top: 460px; position: absolute; right: 983px" Text="Edad:"></asp:Label>
        <asp:TextBox ID="TextBox_11" runat="server" style="z-index: 1; left: 393px; top: 460px; position: absolute; margin-top: 0px; width: 56px;"></asp:TextBox>    
        <asp:Table ID="Table1" runat="server" style="z-index: 2; left: 600px; top: 100px; position: absolute; height: 216px; width: 588px" BorderStyle="Solid">
        </asp:Table>
        <asp:Button ID="Button_Alta" runat="server" style="z-index: 1; left: 220px; top: 490px; position: absolute; width: 100px;" Text="Alta" OnClick="Button1_Click" />
        <asp:Button ID="Button_Modificacion" runat="server" style="z-index: 1; left: 325px; top: 490px; position: absolute; width: 100px;" Text="Modificar" OnClick="Button1_Click" />
        <asp:Button ID="Button_Eliminar" runat="server" style="z-index: 1; left: 430px; top: 490px
; position: absolute; width: 100px;" Text="Eliminar" OnClick="Button1_Click" />
        <asp:Button ID="Button_Pacientes" runat="server" style="z-index: 1; left: 220px; top: 530px; position: absolute; width: 100px;" Text="Pacientes" OnClick="Button1_Click" />
        <asp:Button ID="Button_Limpiar" runat="server" style="z-index: 1; left: 325px; top: 530px; position: absolute; width: 100px;" Text="Limpiar Campos" OnClick="Button1_Click" />
        <asp:Button ID="Button_Salir" runat="server" style="z-index: 1; left: 430px; top: 530px; position: absolute; width: 100px;" Text="Salir" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
