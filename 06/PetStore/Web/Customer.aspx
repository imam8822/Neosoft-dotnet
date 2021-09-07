<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Web.Customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="BulletList" HeaderText="Errors:" ForeColor="Red" />
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label><span class="mandatory">*</span>
            <asp:TextBox for="Label1" class="form-control" ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="Name cannot be empty" ForeColor="Red" Display="None" SetFocusOnError="True"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label><span class="mandatory">*</span>
            <asp:TextBox for="Label2" class="form-control" ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" ErrorMessage="Email cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid email" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Zipcode" ForeColor="Red"></asp:Label><span class="mandatory">*</span>
            <asp:TextBox for="Label3" class="form-control" ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Zipcode!" Display="Dynamic" ControlToValidate="TextBox3" ForeColor="Red" ValidationExpression="^[1-9]{1}[0-9]{5}$"></asp:RegularExpressionValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="UserName"></asp:Label><span class="mandatory">*</span>
            <asp:TextBox for="Label4" class="form-control" ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="username cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="Password"></asp:Label><span class="mandatory">*</span>
            <asp:TextBox for="Label5" class="form-control" ID="TextBox5" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password and confirm password donot match" ForeColor="Red" ControlToValidate="TextBox5" ControlToCompare="TextBox6"></asp:CompareValidator>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="Confirm Password"></asp:Label><span class="mandatory">*</span>
            <asp:TextBox for="Label5" class="form-control" ID="TextBox6" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Save" OnClick="Button1_Click" />
    </form>
</asp:Content>
