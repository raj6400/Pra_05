<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" 
Inherits="Practical_5._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h2>Apply for Leave</h2>

            Username: <asp:Label ID="lblUsername" runat="server"></asp:Label>
            <br /><br />

            Student Name:
            <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
            <br /><br />

            Leave Date:
            <asp:Calendar ID="calLeaveDate" runat="server"></asp:Calendar>
            <br /><br />

            Leave Type:
            <asp:DropDownList ID="ddlLeaveType" runat="server">
                <asp:ListItem Text="Select" Value="" />
                <asp:ListItem Text="Sick" Value="Sick" />
                <asp:ListItem Text="Casual" Value="Casual" />
            </asp:DropDownList>
            <br /><br />

            Reason:
            <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br /><br />

            <asp:Label ID="lblMessage" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
