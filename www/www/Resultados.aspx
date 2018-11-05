<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="www.Resultados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 45px;
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
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Seleccione encuesta:<br />
                    </td>
                    <td class="auto-style1">La media de resultados es:<br />
                        <asp:Label ID="result" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="Enc" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Enc_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>Resultados: </td>
                    <td>
                        <asp:ListBox ID="ResultadosList" runat="server" AutoPostBack="True"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
