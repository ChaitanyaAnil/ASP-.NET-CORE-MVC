﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DelFaculty.aspx.cs" Inherits="WebApplicationCRUD.DelFaculty" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Enter faculty id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />



    </div>







</asp:Content>