<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateFaculty.aspx.cs" Inherits="WebApplicationCRUD.UpdateFaculty" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron">

    <asp:Label ID="Label1" runat="server" Text="Enter Id"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Emter Name to Update"></asp:Label>

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

    <asp:Button ID="Button1" runat="server" Text="UpdateFaculty" OnClick="Button1_Click" />


</div>
    </asp:Content>
    

