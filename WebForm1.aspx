<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 181px;
        }
        .auto-style2 {
            width: 131px;
        }
        .auto-style3 {
            height: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <asp:Image ID="Image1" runat="server" Height="111px" Width="162px" />
        </div>
        <table class="auto-style1">
            <tr>
                <td>Partner Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="191px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="38px" Text="Enter Data" Width="96px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
