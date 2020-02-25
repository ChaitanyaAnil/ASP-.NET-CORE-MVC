<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FindFaculty.aspx.cs" Inherits="WebApplicationCRUD.FindFaculty" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">



    <div class="jumbotron">


    <asp:Label ID="Label1" runat="server" Text="Enter faculty ID"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />


    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>


</div>





</asp:Content>