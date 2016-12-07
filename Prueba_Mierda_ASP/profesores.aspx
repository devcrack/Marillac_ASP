<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profesores.aspx.cs" Inherits="Prueba_Mierda_ASP.profesores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 215px; top: 94px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 213px; top: 137px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 212px; top: 174px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 215px; top: 290px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 212px; top: 214px; position: absolute; right: 1145px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 214px; top: 247px; position: absolute"></asp:TextBox>
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 217px; top: 334px; position: absolute">
            <asp:ListItem>M</asp:ListItem>
            <asp:ListItem>F</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 211px; top: 380px; position: absolute"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 584px; top: 108px; position: absolute; height: 133px; width: 551px">
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server" style="z-index: 1; left: 57px; top: 545px; position: absolute; height: 133px; width: 544px">
        </asp:GridView>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 125px; top: 99px; position: absolute" Text="Nombre"></asp:Label>
        </p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 126px; top: 137px; position: absolute" Text="Paterno"></asp:Label>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 127px; top: 177px; position: absolute" Text="Materno"></asp:Label>
        </p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 130px; top: 218px; position: absolute" Text="Direccion"></asp:Label>
        <p>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 131px; top: 250px; position: absolute" Text="Colonia"></asp:Label>
        </p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 132px; top: 289px; position: absolute" Text="Teléfono"></asp:Label>
        <p>
            <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 130px; top: 332px; position: absolute" Text="Sexo"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 95px; top: 380px; position: absolute" Text="Fecha nacimiento "></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 802px; top: 67px; position: absolute" Text="Profesores"></asp:Label>
        </p>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 263px; top: 513px; position: absolute" Text="Actividades del profesor"></asp:Label>
        <asp:CheckBox ID="lunes" runat="server" style="z-index: 1; left: 426px; top: 436px; position: absolute" />
        <p>
            <asp:CheckBox ID="martes" runat="server" style="z-index: 1; left: 165px; top: 422px; position: absolute; bottom: 171px;" Visible="False" />
            <asp:CheckBox ID="miercoles" runat="server" style="z-index: 1; left: 287px; top: 418px; position: absolute" Visible="False" />
            <asp:CheckBox ID="jueves" runat="server" style="z-index: 1; top: 416px; position: absolute" />
            <asp:CheckBox ID="viernes" runat="server" style="z-index: 1; left: 46px; top: 458px; position: absolute" />
            <asp:CheckBox ID="sábado" runat="server" style="z-index: 1; left: 167px; top: 456px; position: absolute; right: 1244px" />
            <asp:CheckBox ID="domingo" runat="server" style="z-index: 1; left: 305px; top: 459px; position: absolute" Visible="False" />
        </p>
    </form>
</body>
</html>
