<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votar.aspx.cs" Inherits="www.Votar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 500px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="6"><H1>Realiza tu Votación ! :D</H1></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="3" class="auto-style4">Estás votando la:
                        <asp:Label ID="Encuesta" runat="server"></asp:Label>
                    </td>
                    <td colspan="3" class="auto-style3">
                        <asp:Button ID="Volver" runat="server" OnClick="Volver_Click" Text="Volver" Width="70px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="200px" ImageUrl="./emotis/1.png" OnClick="ImageButton1_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton2" runat="server" Height="200px" ImageUrl="./emotis/2.png" OnClick="ImageButton2_Click" />
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:ImageButton ID="ImageButton3" runat="server" Height="200px" ImageUrl="./emotis/3.png" OnClick="ImageButton3_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton4" runat="server" Height="200px" ImageUrl="./emotis/4.png" OnClick="ImageButton4_Click" />
                    </td>
                    <td class="auto-style2">
                        <asp:ImageButton ID="ImageButton5" runat="server" Height="200px" ImageUrl="./emotis/5.png" OnClick="ImageButton5_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>Votación actual:
                        <asp:Label ID="Valor" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="error" runat="server" BackColor="#FF3300" ForeColor="White"></asp:Label>
                    </td>
                    <td colspan="2" class="auto-style2">
                        <asp:Button ID="Vot" runat="server" OnClick="Vot_Click" Text="Votar" />
                    </td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
