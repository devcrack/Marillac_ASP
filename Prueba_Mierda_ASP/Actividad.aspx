﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Actividad.aspx.cs" Inherits="Prueba_Mierda_ASP.Actividad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 115%;
        }
        .auto-style3 {
            width: 470px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">


        <table class="auto-style2">
  <tr>
    <th align="left" class="auto-style3">
    <div style="height: 859px; width: 477px">
    
        Actividades<br />
        <br />
        Nombre Actividad&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp; ID Actividad&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style4" Enabled="False" Width="45px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Lunes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox4" runat="server" Text="Miércoles" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox6" runat="server" Text="Viernes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        Dias que se imparte&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Martes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox5" runat="server" Text="Jueves" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox7" runat="server" Text="Sábado" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Domingo" />
        <br />
        <br />
        <br />
        Hora Inicio -- Hora Final&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="42px"></asp:TextBox>
&nbsp; -&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="42px"></asp:TextBox>
        <br />
        <br />
        Cupo:
        <asp:TextBox ID="TextBox4" runat="server" Width="51px"></asp:TextBox>
        <br />
        <br />
        <br />
        Profesor:
        <asp:TextBox ID="TextBox6" runat="server" Width="46px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Agregar" Width="93px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Eliminar" Width="93px" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Modificar" Width="93px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Limpiar" Width="93px" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Salir" Width="93px" />
        <br />
        <br />
        <br />
        <br />
        Profesores<br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        </div>

        </th>


    <th align="left">


        <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnSelectedIndexChanging="GridView2_SelectedIndexChanging">
        </asp:GridView>
        <br />
        <br />
        Beneficiarios
        <br />
        ID:
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="GridView3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" OnSelectedIndexChanging="GridView3_SelectedIndexChanging">
        </asp:GridView>
        <br />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Alta" Width="64px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Baja" Width="64px" />
        <br />
        <br />
        <br />
        Hijos<br />
        ID:
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="GridView4" runat="server" OnSelectedIndexChanged="GridView4_SelectedIndexChanged" OnSelectedIndexChanging="GridView4_SelectedIndexChanging">
        </asp:GridView>
        <br />
        <asp:Button ID="Button8" runat="server" Text="Alta" Width="64px" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Baja" Width="64px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
      </th> 
    </tr>

  <tr>
    <th align="left" class="auto-style3">
        &nbsp;</th>


    <th align="left">


        &nbsp;</th> 
    </tr>

</table>

    </form>
</body>
</html>
