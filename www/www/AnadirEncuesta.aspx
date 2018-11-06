<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnadirEncuesta.aspx.cs" Inherits="www.AnadirEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2">
                <tr>
                    <h1>Añadir encuesta</h1>
                    <td>&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="nombre" placeholder="Nombre" runat="server" Font-Overline="False"></asp:TextBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="Volver" runat="server" OnClick="Button1_Click" Text="Volver" />
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <textarea id="Descripcion" placeholder="Descripcion"cols="20" name="S1" rows="2"></textarea><asp:Button ID="Aceptar" runat="server" Text="Aceptar" />
                    </td>
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
        </p>
    </form>
    </body>
</html>
