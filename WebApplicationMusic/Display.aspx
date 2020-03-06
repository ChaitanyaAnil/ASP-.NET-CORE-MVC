<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="WebApplicationMusic.Display" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">


        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>


    </div>



</asp:Content>