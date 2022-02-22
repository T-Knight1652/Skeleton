<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblProductID" runat="server" Text="Product ID" width="111px"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <div>
        </div>
        <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="111px"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" width="111px"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantityAvailable" runat="server" Text="Quantity Available"></asp:Label>
        <asp:TextBox ID="txtQuantityAvailable" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblLastDelivery" runat="server" Text="Last Delivery" width="111px"></asp:Label>
            <asp:TextBox ID="txtLastDelivery" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkInStock" runat="server" Text="In Stock" width="111px" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
