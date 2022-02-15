<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebFormWithADO.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
    <div  class="registration" >
        <div class="form-group">
        <asp:Label ID="lblFirstName"  runat="server"> first name</asp:Label>
        <asp:textbox ID="txtFirstName" class="form-control" runat="server"></asp:textbox>
        </div>
        
        <div class="form-group">
        <asp:Label ID="lblLastName"  runat="server"> last name</asp:Label>
        <asp:textbox ID="txtLastName" class="form-control" runat="server"></asp:textbox>
        </div>
    
        <div class="form-group">
        <asp:Label ID="lblDOB"  runat="server"> date of birth</asp:Label>
        <asp:textbox ID="txtDOB" class="form-control" runat="server" OnTextChanged="txtdob_TextChanged" TextMode="Date"></asp:textbox>
        </div>

        <div class="form-group">
        <asp:Label ID="lblEmail"  runat="server"> email</asp:Label>
        <asp:textbox ID="txtEmail" class="form-control" runat="server" TextMode="Email"></asp:textbox>
        </div>

        <div class="form-group">
        <asp:Label ID="lblpassword"  runat="server">password</asp:Label>
        <asp:textbox ID="txtpassword" class="form-control" runat="server" TextMode="Password"></asp:textbox>
        </div>

         <div class="form-group">
        <asp:Label ID="lblcourse"  runat="server"> course </asp:Label>
        <asp:DropDownList ID="ddlCourse" class="form-control" runat="server"></asp:DropDownList>
        </div>

        <asp:Button ID="btnSubmit" runat="server"  class="btn btn-primary" OnClick="clickBtnSubmit" Text="submit" />

        <asp:Label runat="server" ID="lbl1" Visible="false"></asp:Label>
        
        
    </div>
</asp:Content>
