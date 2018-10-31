<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="www.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 145px;
        }
        .auto-style2 {
            width: 222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">LogIn</td>
                    <td class="auto-style2">
                        <input id="Text1" type="text" /></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">PassWord</td>
                    <td class="auto-style2">
                        <input id="Password1" type="password" /></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Iniciar" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
