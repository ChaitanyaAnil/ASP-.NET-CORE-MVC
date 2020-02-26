<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DelFaculty.aspx.cs" Inherits="WebApplicationCRUD.DelFaculty" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Enter faculty id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" ForeColor="#FF3300" ValidationGroup="vg">Enter valid id</asp:RequiredFieldValidator><br />


        <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" ValidationGroup="vg" />



    </div>







</asp:Content>