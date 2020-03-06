<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebApplicationFunctionHall.Search" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">

<div class="jumbotron">
    <asp:Label ID="Label1" runat="server" Text="ENTER hALL ID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="id is neccsary"></asp:RequiredFieldValidator>
    <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>








</div>


</asp:Content>
