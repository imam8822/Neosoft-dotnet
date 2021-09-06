<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Web.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
       <h1>Customer Registration</h1>
        </div>
    <form>
          <div class="form-group row">
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter the name of the cat"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label ID="lbl_2" for="tb_Dob" runat="server" Text="Email " class="col-sm-2 col-form-label"></asp:Label>
              <div class="col-sm-10">
                  <asp:TextBox ID="tb_email" runat="server" class="form-control" placeholder="abc@gmail.com"></asp:TextBox>
              </div>              
          </div>
        <div class="form-group row">
            <asp:Label ID="lbl_3" runat="server" Text="Zipcode " class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_zipcode" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label ID="lbl_4" runat="server" Text="Username " class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_username" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label ID="Label1" runat="server" Text="Password " class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_pass" runat="server" ></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_addCustomer" runat="server" Text="Add" class="btn btn-primary" OnClick="btn_add_Click1" />
            </div>
        </div>
   
    </form>
</asp:Content>
