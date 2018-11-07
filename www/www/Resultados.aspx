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
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 301px;
        }
        .auto-style4 {
            height: 45px;
            width: 301px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Seleccione encuesta:<br />
                    </td>
                    <td class="auto-style4">La media de resultados es:<br />
                        <asp:Label ID="result" runat="server">(valor)</asp:Label>
                    </td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="Volver" runat="server" OnClick="Volver_Click" Text="Volver" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="Enc" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Enc_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">Resultados: </td>
                    <td>
                        <asp:ListBox ID="ResultadosList" runat="server" AutoPostBack="True" CssClass="auto-style2" OnSelectedIndexChanged="ResultadosList_SelectedIndexChanged" Width="60px"></asp:ListBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style3">Comentarios: </td>
                    <td>
                        <asp:ListBox ID="ComentariosList" runat="server" AutoPostBack="True" CssClass="auto-style2" OnSelectedIndexChanged="ResultadosList_SelectedIndexChanged" Width="260px"></asp:ListBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
