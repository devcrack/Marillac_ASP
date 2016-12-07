<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actividadBeneficiario.aspx.cs" Inherits="Prueba_Mierda_ASP.actividadBeneficiario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style2 {
            z-index: 1;
            left: 25px;
            top: 52px;
            position: absolute;
            right: 1135px;
        }
        .auto-style3 {
            z-index: 1;
            left: 185px;
            top: 53px;
            position: absolute;
            width: 176px;
        }
        .auto-style4 {
            z-index: 1;
            left: 25px;
            top: 82px;
            position: absolute;
            right: 1135px;
        }
        .auto-style5 {
            z-index: 1;
            left: 188px;
            top: 81px;
            position: absolute;
            width: 176px;
        }
        .auto-style6 {
            z-index: 1;
            left: 264px;
            top: 114px;
            position: absolute;
            right: 1004px;
        }
        .auto-style7 {
            z-index: 1;
            left: 184px;
            top: 117px;
            position: absolute;
            width: 55px;
        }
        .auto-style8 {
            z-index: 1;
            left: 291px;
            top: 115px;
            position: absolute;
            width: 77px;
            right: 909px;
        }
        .auto-style9 {
            z-index: 1;
            left: 24px;
            top: 117px;
            position: absolute;
            right: 1136px;
        }
        .auto-style10 {
            z-index: 1;
            left: 24px;
            top: 157px;
            position: absolute;
            right: 1136px;
        }
        .auto-style11 {
            z-index: 1;
            left: 185px;
            top: 155px;
            position: absolute;
            width: 185px;
            right: 915px;
        }
        .auto-style20 {
            z-index: 1;
            left: 26px;
            top: 196px;
            position: absolute;
            width: 345px;
        }
        .auto-style29 {
            z-index: 1;
            left: 420px;
            top: 53px;
            position: absolute;
            right: 430px;
            height: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="Label3" runat="server" Text="Días actividad: " CssClass="auto-style4"></asp:Label>
            <p>
            <asp:TextBox ID="nombre" runat="server" style="margin-top: 0px" CssClass="auto-style3" TabIndex="1" ReadOnly="True"></asp:TextBox>
            </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Nombre actividad: " CssClass="auto-style2"></asp:Label>
            </p>
        <p>
            <asp:TextBox ID="inicia" runat="server" style="margin-top: 0px" CssClass="auto-style7" TabIndex="1" ReadOnly="True"></asp:TextBox>
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style29" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="-" CssClass="auto-style6"></asp:Label>
            <asp:TextBox ID="dias" runat="server" style="margin-top: 0px" CssClass="auto-style5" TabIndex="1" ReadOnly="True"></asp:TextBox>
            </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Hora inicia/termina: " CssClass="auto-style9"></asp:Label>
            <asp:TextBox ID="costo" runat="server" style="margin-top: 0px" CssClass="auto-style11" TabIndex="1" ReadOnly="True"></asp:TextBox>
            <asp:Button ID="salir" runat="server" CssClass="auto-style20" OnClick="alta_Click" Text="Salir" />
            </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Costo: " CssClass="auto-style10"></asp:Label>
            </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="termina" runat="server" style="margin-top: 0px" CssClass="auto-style8" TabIndex="1" ReadOnly="True"></asp:TextBox>
            </p>
    </form>
</body>
</html>
