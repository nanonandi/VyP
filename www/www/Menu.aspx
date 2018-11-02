<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="www.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="Volver" runat="server" OnClick="Volver_Click" Text="Volver" />
                        <asp:Button ID="end" runat="server" OnClick="end_Click" Text="Cerrar sesion" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Anadir" runat="server" Height="37px" OnClick="Anadir_Click" Text="Añadir encuesta" Width="180px" />
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="ActDes" runat="server" Height="37px" OnClick="ActDes_Click" Text="Activar/Desactivar Encuesta" Width="180px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Modificar" runat="server" Height="37px" OnClick="Modificar_Click" Text="Modificar encuesta" Width="180px" />
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="Result" runat="server" Height="37px" OnClick="Result_Click" Text="Mostrar resultados" Width="180px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
