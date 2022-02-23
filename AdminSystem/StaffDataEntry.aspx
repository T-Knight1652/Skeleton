<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmployeeId" runat="server" Text="Employee ID" width="121px"></asp:Label>
            <asp:TextBox ID="txtEmployeeId" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="121px"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDepartment" runat="server" Text="Department" width="121px"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMonthlySalary" runat="server" Text="Monthly Salary"></asp:Label>
        <asp:TextBox ID="txtMonthlySalary" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStartJob" runat="server" Text="Start Job Date" width="121px"></asp:Label>
        <asp:TextBox ID="txtStartJob" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkManager" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Manager" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
