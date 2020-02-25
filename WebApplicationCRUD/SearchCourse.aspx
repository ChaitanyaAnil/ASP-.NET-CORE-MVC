<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchCourse.aspx.cs" Inherits="WebApplicationCRUD.SearchCourse" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron">


    <asp:Label ID="Label1" runat="server" Text="Enter Course ID"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />


    <asp:GridView ID="GridView1" runat="server"></asp:GridView>


</div>



</asp:Content>