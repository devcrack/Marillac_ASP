<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WForm_Psicologos.aspx.cs" EnableEventValidation="false" Inherits="Prueba_Mierda_ASP.WForm_Psicologos"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="estilos_generales.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 563px; z-index: 1; left: 10px; top: 15px; position: absolute; width: 1340px;">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 590px; top: 28px; position: absolute; height: 52px; width: 195px; text-align: center" Text="Psicologos"></asp:Label>        
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 50px; top: 100px; position: absolute; right: 1193px; height: 18px;" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox_Nombre" runat="server" style="z-index: 1; left: 195px; top:100px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>
        <asp:TextBox ID="TextBox_ApP" runat="server" style="z-index: 1; left: 195px; top: 140px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 50px; top: 140px; position: absolute; right: 1141px" Text="Apellido Paterno"></asp:Label>        
        <asp:TextBox ID="TextBox_ApM" runat="server" style="z-index: 1; left: 195px; top: 180px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>        
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 50px; top: 180px; position: absolute; right: 1170px" Text="Apellido Materno"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 50px; top: 220px; position: absolute; right: 1177px" Text="Direccion"></asp:Label>
        <asp:TextBox ID="TextBox_Dir" runat="server" style="z-index: 1; left: 195px; top: 220px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 50px; top: 260px; position: absolute; right: 1172px" Text="Colonia"></asp:Label>
        <asp:TextBox ID="TextBox_Colon" runat="server" style="z-index: 1; left: 195px; top: 260px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>        
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 50px; top: 300px; position: absolute; right: 1174px" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="TextBox_Tel" runat="server" style="z-index: 1; left: 195px; top: 300px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>    
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 50px; top: 340px; position: absolute; right: 1250px" Text="Sexo:"></asp:Label>
        <%--<asp:TextBox ID="TextBox_Sex" runat="server" style="z-index: 1; left: 195px; top: 339px; position: absolute; margin-top: 0px; width: 56px;"></asp:TextBox>--%>    
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 50px; top: 380px; position: absolute; right: 1166px" Text="Limite Pacientes:"></asp:Label>
        <asp:TextBox ID="TextBox_LimitPac" runat="server" style="z-index: 1; left: 195px; top: 380px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>    
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 50px; top: 420px; position: absolute; right: 1155px" Text="Fecha Nacimiento:"></asp:Label>
        <asp:TextBox ID="TextBox_Fech_Nac" runat="server" style="z-index: 1; left: 195px; top: 420px; position: absolute; margin-top: 0px; width: 156px;"></asp:TextBox>    
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 50px; top: 460px; position: absolute; right: 1118px" Text="Edad:"></asp:Label>
        <asp:TextBox ID="TextBox_Edad" runat="server" style="z-index: 1; left: 195px; top: 460px; position: absolute; margin-top: 0px; width: 56px;"></asp:TextBox>    
        <asp:Button ID="Button_Alta" runat="server" style="z-index: 1; left: 50px; top: 490px; position: absolute; width: 100px;" Text="Alta" OnClick="Button1_Click" />
        <asp:Button ID="Button_Modificacion" runat="server" style="z-index: 1; left: 155px; top: 490px; position: absolute; width: 100px;" Text="Modificar" OnClick="Button1_Click" />
        <asp:Button ID="Button_Eliminar" runat="server" style="z-index: 1; left: 260px; top: 490px; position: absolute; width: 100px;" Text="Eliminar" OnClick="Button1_Click" />
        <asp:Button ID="Button_Pacientes" runat="server" style="z-index: 1; left: 50px; top: 530px; position: absolute; width: 100px;" Text="Pacientes" OnClick="Button1_Click" />
        <asp:Button ID="Button_Limpiar" runat="server" style="z-index: 1; left: 155px; top: 530px; position: absolute; width: 100px;" Text="Limpiar Campos" OnClick="Button1_Click" />
        <asp:Button ID="Button_Salir" runat="server" style="z-index: 1; left: 260px; top: 530px; position: absolute; width: 100px;" Text="Salir" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox_DiasL" runat="server" style="z-index: 1; left: 400px; top: 389px; position: absolute; margin-top: 0px; width: 264px;" Enabled="False"></asp:TextBox>    
        <asp:CheckBox ID="CheckBox_Lunes" runat="server" style="z-index: 1; left: 400px; top: 420px; position: absolute" Text="Lunes" OnCheckedChanged="CheckBox_Lunes_CheckedChanged" />
        <asp:CheckBox ID="CheckBox_Martes" runat="server" style="z-index: 1; left: 490px; top: 420px; position: absolute; right: 782px;" Text="Martes" OnCheckedChanged="CheckBox_Martes_CheckedChanged" />
        <asp:CheckBox ID="CheckBox_Miercoles" runat="server" style="z-index: 1; left: 580px; top: 420px; position: absolute" Text="Miercoles" OnCheckedChanged="CheckBox_Miercoles_CheckedChanged" />
        <asp:CheckBox ID="CheckBox_Jueves" runat="server" style="z-index: 1; left: 670px; top: 420px; position: absolute" Text="Jueves" OnCheckedChanged="CheckBox_Jueves_CheckedChanged" />
        <asp:CheckBox ID="CheckBox_Viernes" runat="server" style="z-index: 1; left: 400px; top: 460px; position: absolute; right: 866px;" Text="Viernes" OnCheckedChanged="CheckBox_Viernes_CheckedChanged" />
        <asp:CheckBox ID="CheckBox_Sabado" runat="server" style="z-index: 1; left: 490px; top: 460px; position: absolute" Text="Sabado" OnCheckedChanged="CheckBox_Sabado_CheckedChanged" />
        <asp:CheckBox ID="CheckBox_Domingo" runat="server" style="z-index: 1; left: 580px; top: 460px; position: absolute" Text="Domingo" OnCheckedChanged="CheckBox_Domingo_CheckedChanged" />
        <asp:GridView ID="GridView_Psico" runat="server" style="z-index: 1; left: 400px; top: 100px; position: absolute; height: 257px; width: 907px; margin-right: 103px;" OnSelectedIndexChanged="GridView_Psico_SelectedIndexChanged" OnSelectedIndexChanging="GridView_Psico_SelectedIndexChanging" CssClass="data_grids" Font-Size="Small" HorizontalAlign="Center" OnRowCreated ="GridView_Psico_RowCreated" EnableModelValidation="False" >
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>
        <asp:RadioButton ID="radioButt_Male" runat="server" style="z-index: 1; left: 150px; top: 339px; position: absolute" Text="Masculino" />
        <asp:RadioButton ID="radioButt_Female" runat="server" style="z-index: 1; left: 250px; top: 339px; position: absolute" Text="Femenino" />
    </div>
    </form>
</body>
</html>
