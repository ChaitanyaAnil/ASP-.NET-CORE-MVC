<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MusicForm.aspx.cs" Inherits="WebApplicationMusic.MusicForm" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server" >
    <div class="jumbotron">
   
    <asp:Label ID="Label2" runat="server" Text="AlbumName"></asp:Label><br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Name mandatory" ControlToValidate="TextBox2" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator><br />
    <asp:Label ID="Label3" runat="server" Text="ReleaseDate"></asp:Label><br />
    
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br />


    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" ValidationGroup="vg" />

</div>




</asp:Content>