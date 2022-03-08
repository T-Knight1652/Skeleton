<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the customer data entry page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="LblCustomerID" runat="server" Text="Customer ID" width="106px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password" width="106px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblFullname" runat="server" Text="Fullname" width="106px"></asp:Label>
        <asp:TextBox ID="txtFullname" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email" width="106px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblCreationDate" runat="server" Text="Creation date" width="106px"></asp:Label>
        <asp:TextBox ID="txtCreationDate" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkOverEighteen" runat="server" Text="Over Eighteen" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
