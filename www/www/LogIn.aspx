<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="www.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 145px;
            height: 60px;
        }
        .auto-style4 {
            width: 400px;
            height: 60px;
        }
        .auto-style5 {
            height: 60px;
        }
        .auto-style9 {
            width: 145px;
            height: 37px;
        }
        .auto-style10 {
            width: 400px;
            height: 37px;
        }
        .auto-style11 {
            height: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table style="width: 100%;">
                <tr>
                    <td colspan="3"><h1>Iniciar Sesión</h1></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">LogIn</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="user" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style9">PassWord</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                    </td>
                    <td class="auto-style11">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Label ID="error" runat="server" BackColor="Red" ForeColor="White"></asp:Label>
                    </td>
                    <td class="auto-style5">
                    </td>
                    <td class="auto-style5">
                        <asp:Button ID="iniciar" runat="server" Height="37px" OnClick="iniciar_Click" Text="Iniciar" Width="170px" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
