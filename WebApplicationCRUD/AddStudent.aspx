<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="WebApplicationCRUD.AddStudent" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
            <asp:Label ID="Label1" runat="server" Text="NAME"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" ForeColor="#FF3300" ValidationGroup="vg">Enter valid Name</asp:RequiredFieldValidator><br />

      
        <asp:Label ID="Label2" runat="server" Text="EMAIL"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>
            <br />





              <asp:Label ID="Label3" runat="server" Text="ADDRESS"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="ENTER student address" ControlToValidate="TextBox3" ForeColor="#FF3300" ValidationGroup="vg"></asp:RequiredFieldValidator>



              <br />

             
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AddStudent" ValidationGroup="vg" />
        </div>
    </asp:Content>