<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnadirEncuesta.aspx.cs" Inherits="www.AnadirEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <h1>Añadir encuesta</h1>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Volver" runat="server" OnClick="Button1_Click" Text="Volver" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="nombre" placeholder="Nombre" runat="server" Font-Overline="False"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <textarea id="Descripcion" placeholder="Descripcion"cols="20" name="S1" rows="2"></textarea></td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    <p>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Activa</asp:ListItem>
            <asp:ListItem>Inactiva</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Aceptar" runat="server" Text="Aceptar" />
        </p>
    </form>
    </body>
</html>
