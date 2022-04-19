<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 372px; top: 63px; position: absolute" Text="Find" />
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 26px; top: 71px; position: absolute" Text="Order ID" width="124px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 159px; top: 69px; position: absolute; height: 17px"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="txtCustomerID" runat="server" style="z-index: 1; left: 22px; top: 113px; position: absolute" Text="Customer ID" width="124px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 20px; top: 165px; position: absolute" Text="Order Date" width="124px"></asp:Label>
            <asp:TextBox ID="txtCustomer" runat="server" style="z-index: 1; left: 159px; top: 115px; position: absolute; height: 21px"></asp:TextBox>
        </p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 25px; top: 206px; position: absolute" Text="Price" width="124px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 159px; top: 210px; position: absolute; height: 13px"></asp:TextBox>
        <p>
            <asp:Label ID="lblComments" runat="server" style="z-index: 1; left: 26px; top: 248px; position: absolute" Text="Comments" width="124px"></asp:Label>
        </p>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 159px; top: 172px; position: absolute; height: 14px"></asp:TextBox>
        <asp:TextBox ID="txtComments" runat="server" style="z-index: 1; left: 159px; top: 256px; position: absolute; height: 15px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkDispatch" runat="server" style="z-index: 1; left: 19px; top: 284px; position: absolute" Text="Dispatch" width="124px" OnCheckedChanged="chkDispatch_CheckedChanged" />
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 352px; position: absolute" Text="OK" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 77px; top: 354px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 320px; position: absolute" width="124px"></asp:Label>
    </form>
</body>
</html>
