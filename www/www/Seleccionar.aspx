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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>Seleccione la encuesta que quiera votar.</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Encuestas:<br />
                        <br />
                        <asp:DropDownList ID="enc" runat="server">
                        </asp:DropDownList>
                        <br />
                    </td>
                    <td>
                        <asp:Button ID="Verdesc" runat="server" OnClick="Verdesc_Click" Text="Ver Descripcion" />
                        <br />
                        <br />
                        <asp:TextBox ID="desc" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="AccEncuesta" runat="server" OnClick="AccEncuesta_Click" Text="Aceptar" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
