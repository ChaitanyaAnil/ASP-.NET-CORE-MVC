<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="InsertFhall.aspx.cs" Inherits="WebApplicationFunctionHall.InsertFhall" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

    <asp:Label ID="Label1" runat="server" Text="HallName"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="enter hall name" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>

    <asp:Label ID="Label2" runat="server" Text="Location"></asp:Label>

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter location" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>


    <asp:Label ID="Label3" runat="server" Text="Hall Manager"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />

        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox3" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>


    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</div>
</asp:Content>