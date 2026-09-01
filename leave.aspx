<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leave.aspx.cs" 
Inherits="Practical_5.leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Leave Details</h2>

            Username: 
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
            <br /><br />

            Student Name: 
            <asp:Label ID="lblStudentName" runat="server"></asp:Label>
            <br /><br />

            Leave Date: 
            <asp:Label ID="lblLeaveDate" runat="server"></asp:Label>
            <br /><br />

            Leave Type: 
            <asp:Label ID="lblLeaveType" runat="server"></asp:Label>
            <br /><br />

            Reason: 
            <asp:Label ID="lblReason" runat="server"></asp:Label>
            <br /><br />

            <asp:Button ID="btnLogout" runat="server" 
                Text="Logout" 
                OnClick="btnLogout_Click" />

        </div>
    </form>
</body>
</html>
