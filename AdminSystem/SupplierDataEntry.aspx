<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductID" runat="server" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server" style="margin-left: 11px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblBrandName" runat="server" Text="Brand Name" width="68px"></asp:Label>
            <asp:TextBox ID="txtBrandName" runat="server" style="margin-left: 13px"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="68px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 13px"></asp:TextBox>
        <p>
            <asp:Label ID="lblTotal" runat="server" Text="Total" width="68px"></asp:Label>
            <asp:TextBox ID="txtTotal" runat="server" style="margin-left: 14px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblNextDelivery" runat="server" Text="Next Delivery" width="68px"></asp:Label>
            <asp:TextBox ID="txtNextDelivery" runat="server" style="margin-left: 17px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
