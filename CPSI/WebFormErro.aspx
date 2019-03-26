<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormErro.aspx.cs" Inherits="CPSI.WebFormErro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelBoxErro"  runat="server"></asp:Label>
            <asp:Button ID="ButtonRetorno" OnClick="ButtonRetorno_Click" runat="server" Text="Retornar" />
        </div>
    </form>
</body>
</html>
