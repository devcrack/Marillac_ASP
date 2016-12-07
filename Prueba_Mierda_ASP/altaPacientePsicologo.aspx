<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="altaPacientePsicologo.aspx.cs" Inherits="Prueba_Mierda_ASP.altaPacientePsicologo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style29 {
            z-index: 1;
            left: 11px;
            top: 98px;
            position: absolute;
            right: 839px;
            height: 123px;
        }
        .auto-style30 {
            z-index: 1;
            left: 781px;
            top: 98px;
            position: absolute;
            right: 69px;
            height: 123px;
        }
        .auto-style10 {
            z-index: 1;
            left: 12px;
            top: 64px;
            position: absolute;
            right: 1092px;
            margin-top: 9px;
        }
        .auto-style31 {
            z-index: 1;
            left: 782px;
            top: 65px;
            position: absolute;
            right: 322px;
            margin-top: 9px;
        }
        .auto-style20 {
            z-index: 1;
            left: 925px;
            top: 67px;
            position: absolute;
            width: 302px;
        }
        .auto-style32 {
            z-index: 1;
            left: 137px;
            top: 66px;
            position: absolute;
            width: 302px;
            margin-top: 1px;
        }
        .auto-style33 {
            z-index: 1;
            left: 464px;
            top: 70px;
            position: absolute;
            width: 302px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
            <asp:GridView ID="beneficiariosInscritos" runat="server" CssClass="auto-style29" AutoGenerateSelectButton="True" OnSelectedIndexChanged="beneficiariosInscritos_SelectedIndexChanged">
            </asp:GridView>
            <asp:GridView ID="beneficiariosNoInscritos" runat="server" CssClass="auto-style30" AutoGenerateSelectButton="True" OnSelectedIndexChanged="beneficiariosNoInscritos_SelectedIndexChanged">
            </asp:GridView>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Pacientes No inscritos" CssClass="auto-style31"></asp:Label>
            <asp:CheckBox ID="beneficiarios" runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="beneficiarios_CheckedChanged" Text="Beneficiarios" />
            <asp:CheckBox ID="hijos" runat="server" AutoPostBack="True" OnCheckedChanged="hijos_CheckedChanged" Text="Hijos" />
        </p>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label13" runat="server" Text="Pacientes Inscritos" CssClass="auto-style10"></asp:Label>
            </p>
        <p>
            <asp:Button ID="baja" runat="server" CssClass="auto-style32" OnClick="baja_Click" Text="Baja paciente" />
            <asp:Button ID="salir" runat="server" CssClass="auto-style33" OnClick="salir_Click" Text="Salir" />
            </p>
        <p>
            <asp:Button ID="inscribir0" runat="server" CssClass="auto-style20" OnClick="alta_Click" Text="Alta paciente" />
            </p>
    </form>
</body>
</html>
