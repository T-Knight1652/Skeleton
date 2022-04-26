<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 137px; top: 342px; position: absolute; height: 34px; width: 76px" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 77px; top: 340px; position: absolute" Text="Edit" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 383px; position: absolute; height: 44px; width: 94px"></asp:Label>
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 15px; top: 40px; position: absolute; height: 290px; width: 490px"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 339px; position: absolute; height: 35px" Text="Add" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
