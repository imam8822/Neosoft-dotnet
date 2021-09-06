<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 593px">
            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="232px"></asp:TextBox>
            
            <br><br>
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="234px"></asp:TextBox><br><br>

            <asp:Label ID="Label3" runat="server" Text="zipcode"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Width="220px"></asp:TextBox><br><br>

            <asp:Label ID="Label4" runat="server" Text="username"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Width="212px"></asp:TextBox><br><br>

            <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Width="213px"></asp:TextBox><br><br>

            <asp:Button ID="Button1" runat="server" Height="49px" Text="Submit" Width="176px" OnClick="Button1_Click"/>

        </div>
    </form>
</body>
</html>
