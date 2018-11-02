<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Seleccionar.aspx.cs" Inherits="www.Seleccionar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 518px;
        }
        .auto-style2 {
            width: 164px;
        }
        .auto-style3 {
            width: 632px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="5"><h1>Seleccione la encuesta que quiera votar.</h1></td>
                </tr>
                <tr>
                    <td class="auto-style2">Encuestas:<br />
                        <br />
                        <asp:DropDownList ID="enc" runat="server">
                        </asp:DropDownList>
                        <br />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Verdesc" runat="server" OnClick="Verdesc_Click" Text="Ver Descripcion" />
                        <br />
                        <br />
                        <asp:Label ID="desctext" runat="server" Text="(Descripción)"></asp:Label>
                    </td>
                    <td colspan="3">
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2" rowspan="2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="AccEncuesta" runat="server" OnClick="AccEncuesta_Click" Text="Aceptar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
