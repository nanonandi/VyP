<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActDesactEnc.aspx.cs" Inherits="www.ActDesactEnc" %>

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
            width: 340px;
        }
        .auto-style3 {
            height: 23px;
            width: 340px;
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
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Volver" runat="server" OnClick="Volver_Click" Text="Volver" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Seleccione la encuesta:
                        <br />
                        <asp:DropDownList ID="Enc" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Enc_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>Estado Actual: <asp:Label ID="Estado" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
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
