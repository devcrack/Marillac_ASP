<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForM_Beneficiarios.aspx.cs" Inherits="Prueba_Mierda_ASP.WebForM_Beneficiarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="estilos_generales.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 49px;
            top: 43px;
            position: absolute;
            height: 52px;
            width: 195px;
        }
        .auto-style2 {
            z-index: 1;
            left: 57px;
            top: 123px;
            position: absolute;
            right: 1147px;
        }
        .auto-style3 {
            z-index: 1;
            left: 220px;
            top: 123px;
            position: absolute;
            width: 176px;
        }
        .auto-style4 {
            height: 563px;
        }
        .auto-style5 {
            z-index: 1;
            left: 56px;
            top: 152px;
            position: absolute;
            right: 1098px;
            width: 131px;
        }
        .auto-style6 {
            z-index: 1;
            left: 57px;
            top: 182px;
            position: absolute;
            right: 1097px;
            width: 131px;
        }
        .auto-style7 {
            z-index: 1;
            left: 56px;
            top: 209px;
            position: absolute;
            right: 1098px;
            width: 131px;
        }
        .auto-style8 {
            z-index: 1;
            left: 56px;
            top: 236px;
            position: absolute;
            right: 1098px;
            width: 131px;
        }
        .auto-style9 {
            z-index: 1;
            left: 56px;
            top: 262px;
            position: absolute;
            right: 1098px;
            width: 131px;
            bottom: 260px;
        }
        .auto-style10 {
            z-index: 1;
            left: 56px;
            top: 288px;
            position: absolute;
            right: 1098px;
            width: 131px;
            bottom: 234px;
        }
        .auto-style11 {
            z-index: 1;
            left: 56px;
            top: 316px;
            position: absolute;
            right: 1063px;
            width: 166px;
            bottom: 187px;
            height: 37px;
        }
        .auto-style12 {
            z-index: 1;
            left: 219px;
            top: 153px;
            position: absolute;
            width: 179px;
        }
        .auto-style13 {
            z-index: 1;
            left: 219px;
            top: 183px;
            position: absolute;
            width: 180px;
        }
        .auto-style14 {
            z-index: 1;
            left: 219px;
            top: 209px;
            position: absolute;
            width: 182px;
        }
        .auto-style15 {
            z-index: 1;
            left: 219px;
            top: 236px;
            position: absolute;
            width: 184px;
        }
        .auto-style16 {
            z-index: 1;
            left: 219px;
            top: 263px;
            position: absolute;
            width: 186px;
        }
        .auto-style17 {
            z-index: 1;
            left: 222px;
            top: 292px;
            position: absolute;
        }
        .auto-style18 {
            z-index: 1;
            left: 323px;
            top: 292px;
            position: absolute;
            right: 842px;
        }
        .auto-style19 {
            z-index: 1;
            left: 223px;
            top: 324px;
            position: absolute;
            width: 174px;
        }
        .auto-style20 {
            z-index: 1;
            left: 59px;
            top: 372px;
            position: absolute;
            }
        .auto-style21 {
            z-index: 1;
            left: 171px;
            top: 373px;
            position: absolute;
            margin-top: 0px;
        }
        .auto-style22 {
            z-index: 1;
            left: 279px;
            top: 374px;
            position: absolute;
            right: 906px;
            margin-top: 0px;
        }
        .auto-style23 {
            z-index: 1;
            left: 59px;
            top: 405px;
            position: absolute;
        }
        .auto-style24 {
            z-index: 1;
            left: 171px;
            top: 406px;
            position: absolute;
            right: 1039px;
            margin-top: 0px;
            bottom: 177px;
        }
        .auto-style25 {
            z-index: 1;
            left: 279px;
            top: 406px;
            position: absolute;
            right: 906px;
            margin-top: 0px;
        }
        .auto-style27 {
            z-index: 1;
            left: 60px;
            top: 438px;
            position: absolute;
            margin-top: 0px;
            height: 25px;
            right: 1125px;
        }
        .auto-style28 {
            z-index: 1;
            left: 173px;
            top: 437px;
            position: absolute;
            right: 906px;
            width: 206px;
            margin-top: 0px;
            height: 25px;
            bottom: 78px;
        }
        .auto-style29 {
            z-index: 1;
            left: 450px;
            top: 120px;
            position: absolute;
            right: 400px;
            height: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">        
        <div class="auto-style4">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="text-align: center" Text="Beneficiarios" CssClass="auto-style1"></asp:Label>
            <asp:TextBox ID="paterno" runat="server" style="margin-top: 0px" CssClass="auto-style12" TabIndex="2"></asp:TextBox>
            <asp:TextBox ID="nombre" runat="server" style="margin-top: 0px" CssClass="auto-style3" TabIndex="1"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Nombre:" CssClass="auto-style2"></asp:Label>
            <asp:Label ID="Label4" runat="server" BorderStyle="None" CssClass="auto-style5" Height="16px" Text="Apellido paterno: "></asp:Label>
            <asp:Label ID="Label5" runat="server" BorderStyle="None" CssClass="auto-style7" Height="16px" Text="Dirección: "></asp:Label>
            <asp:Label ID="Label6" runat="server" BorderStyle="None" CssClass="auto-style6" Height="16px" Text="Apellido materno: "></asp:Label>
            <asp:Label ID="Label7" runat="server" BorderStyle="None" CssClass="auto-style8" Height="16px" Text="Colonia: "></asp:Label>
            <asp:Label ID="Label8" runat="server" BorderStyle="None" CssClass="auto-style9" Height="16px" Text="Teléfono: "></asp:Label>
            <asp:Label ID="Label9" runat="server" BorderStyle="None" CssClass="auto-style11" Text="Fecha de nacimiento: (mm-dd-yyyy)"></asp:Label>
            <asp:Label ID="Label10" runat="server" BorderStyle="None" CssClass="auto-style10" Height="16px" Text="Sexo: "></asp:Label>
            <asp:TextBox ID="materno" runat="server" style="margin-top: 0px" CssClass="auto-style13" TabIndex="3"></asp:TextBox>
            <asp:TextBox ID="fechaNacimiento" runat="server" style="margin-top: 0px" CssClass="auto-style19" TabIndex="9" AutoPostBack="True" OnTextChanged="fechaNacimiento_TextChanged"></asp:TextBox>
            <asp:TextBox ID="direccion" runat="server" style="margin-top: 0px" CssClass="auto-style14" TabIndex="4"></asp:TextBox>
            <asp:TextBox ID="colonia" runat="server" style="margin-top: 0px" CssClass="auto-style15" TabIndex="5"></asp:TextBox>
            <asp:CheckBox ID="masculino" runat="server" Checked="True" CssClass="auto-style17" OnCheckedChanged="masculino_CheckedChanged" TabIndex="7" Text="Masculino" AutoPostBack="True" />
            <asp:CheckBox ID="femenino" runat="server" CssClass="auto-style18" OnCheckedChanged="femenino_CheckedChanged" TabIndex="8" Text="Femenino" AutoPostBack="True" />
            <asp:TextBox ID="telefono" runat="server" style="margin-top: 0px" CssClass="auto-style16" TabIndex="6"></asp:TextBox>
            <asp:Button ID="salir" runat="server" CssClass="auto-style28" OnClick="salir_Click" Text="Salir" />
            <asp:Button ID="actividades" runat="server" CssClass="auto-style27" Text="Actividades" Width="100px" />
            <asp:Button ID="alta" runat="server" CssClass="auto-style20" OnClick="alta_Click" Text="Alta" Width="100px" />
            <asp:Button ID="baja" runat="server" CssClass="auto-style21" Text="Baja" Width="100px" OnClick="baja_Click" />
            <asp:Button ID="modificar" runat="server" CssClass="auto-style22" Text="Modificar" Width="100px" OnClick="modificar_Click" />
            <asp:Button ID="hijos" runat="server" CssClass="auto-style23" Text="Hijos" Width="100px" />
            <asp:Button ID="psicologo" runat="server" CssClass="auto-style24" Text="Psicólogo" Width="100px" Height="22px" OnClick="psicologo_Click" />
            <asp:Button ID="limpiar" runat="server" CssClass="auto-style25" OnClick="limpiar_Click" Text="Limpiar campos" Width="100px" Height="22px" />
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style29" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
    </div>
    </form>
</body>
</html>
