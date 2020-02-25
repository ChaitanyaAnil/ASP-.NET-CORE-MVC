<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="SearchStudent.aspx.cs" Inherits="WebApplicationCRUD.SearchStudent" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">

<div class="jumbotron">


    <asp:Label ID="Label1" runat="server" Text="Enter Student ID"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />


    <asp:GridView ID="GridView1" runat="server"></asp:GridView>


</div>





</asp:Content>