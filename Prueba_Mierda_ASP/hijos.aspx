<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hijos.aspx.cs" Inherits="Prueba_Mierda_ASP.hijos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 548px;
            top: 522px;
            position: absolute;
            height: 133px;
            width: 404px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="hijostabla" runat="server" OnPreRender="hijostabla_PreRender" OnSelectedIndexChanged="tabla2_SelectedIndexChanged" OnSelectedIndexChanging="tabla2_SelectedIndexChanging" style="z-index: 1; left: 570px; top: 82px; position: absolute; height: 133px; width: 417px" ViewStateMode="Enabled">
        </asp:GridView>
        <asp:TextBox ID="paterno" runat="server" style="z-index: 1; left: 292px; top: 51px; position: absolute; width: 185px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="boton_agregar" runat="server" OnClick="boton_agregar_Click" style="z-index: 1; left: 120px; top: 359px; position: absolute; width: 74px" Text="Agregar" />
        </p>
        <asp:TextBox ID="materno" runat="server" style="z-index: 1; left: 291px; top: 100px; position: absolute; width: 184px" TabIndex="1"></asp:TextBox>
        <asp:TextBox ID="nombre" runat="server" style="z-index: 1; left: 293px; top: 147px; position: absolute; width: 187px" TabIndex="2"></asp:TextBox>
        <asp:TextBox ID="fecha" runat="server" style="z-index: 1; left: 293px; top: 240px; position: absolute; width: 189px" TabIndex="4"></asp:TextBox>
        <asp:TextBox ID="beneficiario" runat="server" Enabled="False" style="z-index: 1; left: 296px; top: 289px; position: absolute; width: 187px" TabIndex="5"></asp:TextBox>
        <asp:DropDownList ID="sexo" runat="server" style="z-index: 1; left: 298px; top: 197px; position: absolute" TabIndex="3">
            <asp:ListItem>M</asp:ListItem>
            <asp:ListItem>F</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="boton_modificar" runat="server" OnClick="boton_modificar_Click" style="z-index: 1; left: 205px; top: 360px; position: absolute; height: 26px" Text="Modificar" />
        <asp:Button ID="boton_eliminar" runat="server" OnClick="boton_eliminar_Click" style="z-index: 1; left: 291px; top: 360px; position: absolute; width: 78px" Text="Eliminar" />
        <asp:Button ID="boton_limpiar" runat="server" OnClick="boton_limpiar_Click" style="z-index: 1; left: 122px; top: 402px; position: absolute; width: 73px" Text="Limpiar" />
        <asp:Button ID="boton_salir" runat="server" style="z-index: 1; top: 400px; position: absolute; left: 207px; width: 75px" Text="Salir" OnClick="boton_salir_Click" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click1" style="z-index: 1; left: 499px; top: 285px; position: absolute" Text="..." />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 169px; top: 54px; position: absolute" Text="Apellido Paterno"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 99px; top: 241px; position: absolute" Text="Fecha Nacimiento(mm-dd-aa)"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 758px; top: 51px; position: absolute" Text="Hijos"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 168px; top: 101px; position: absolute" Text="Apellido Materno"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 205px; top: 293px; position: absolute" Text="Beneficiario"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 253px; top: 199px; position: absolute" Text="Sexo"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 228px; top: 147px; position: absolute" Text="Nombre"></asp:Label>
        <asp:GridView ID="actividadestabla" runat="server" CssClass="auto-style1">
        </asp:GridView>
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 98px; top: 485px; position: absolute; height: 204px; width: 397px" Visible="False">
            <asp:Button ID="aceptar_beneficiario" runat="server" Text="Aceptar" OnClick="aceptar_beneficiario_Click" style="z-index: 1; left: 7px; top: 103px; position: absolute; right: 321px;" />
            <asp:Label ID="Label9" runat="server" Text="Seleccione el beneficiario"></asp:Label>
            <asp:GridView ID="beneficiariostabla" runat="server" OnSelectedIndexChanged="beneficiariostabla_SelectedIndexChanged" OnSelectedIndexChanging="beneficiariostabla_SelectedIndexChanging" style="z-index: 1; left: 90px; top: 42px; position: absolute; height: 133px; width: 299px">
            </asp:GridView>
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" style="z-index: 1; left: 7px; top: 147px; position: absolute" Text="Cancelar" />
        </asp:Panel>
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
    </form>
</body>
</html>
