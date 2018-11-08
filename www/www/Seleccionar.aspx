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
        .auto-style4 {
            width: 300px;
        }
        .auto-style5 {
            width: 559px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="3" rowspan="2"><h1 class="auto-style5" id="Princpal">Seleccione la encuesta que quiera votar.</h1></td>
                    <td>&nbsp;</td>
                </tr>    
                <tr>
                    <td>
                        <asp:Button ID="Iniciar" runat="server" CssClass="auto-style6" Height="37px" OnClick="Iniciar_Click" Text="Iniciar sesión" Width="170px" />
                    </td>
                </tr>    
                <tr>
                    <td colspan="4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">Encuestas:<br />
                        <br />
                        
                        <asp:DropDownList ID="Enc" AutoPostBack="true" runat="server" OnSelectedIndexChanged="Enc_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                    </td>
                    <td class="auto-style4">
                        <br />
                        <asp:Label ID="desctext" runat="server" Text="(Descripción)"></asp:Label>
                    </td>
                    <td colspan="2">
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2" rowspan="2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Errorlab" runat="server" BackColor="#FF3300" ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="AccEncuesta" runat="server" OnClick="AccEncuesta_Click" Text="Aceptar" Height="37px" Width="170px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
