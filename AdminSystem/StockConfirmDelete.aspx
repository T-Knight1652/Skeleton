<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?</div>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" Text="Yes" Width="47px" />
            <asp:Button ID="btnNo" runat="server" Height="26px" OnClick="Button2_Click" style="margin-left: 15px; margin-top: 3px" Text="No" Width="58px" />
        </p>
    </form>
</body>
</html>
