<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnadirEncuesta.aspx.cs" Inherits="www.AnadirEncuesta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 223px;
        }
        .auto-style3 {
            height: 23px;
            width: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Activar o desactivar Encuesta</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Volver" runat="server" OnClick="Volver_Click" Text="Volver" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="Nombre" placeholder="Nombre" runat="server" Font-Overline="False"></asp:TextBox>
                        <br />
                        <textarea id="Descripcion" placeholder="Descripcion" runat="server" cols="20" name="S1" rows="2"></textarea></td>
                    <td>
                        <asp:RadioButtonList ID="Radio" runat="server" AutoPostBack="True" >
                            <asp:ListItem Value="true">Activa</asp:ListItem>
                            <asp:ListItem Value="false">Inactiva</asp:ListItem>
                        </asp:RadioButtonList>
&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Errorlab" runat="server" BackColor="#FF3300" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="Aceptar" runat="server" OnClick="Aceptar_Click" Text="Aceptar cambios" />
                    </td>
                    <td class="auto-style1"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
