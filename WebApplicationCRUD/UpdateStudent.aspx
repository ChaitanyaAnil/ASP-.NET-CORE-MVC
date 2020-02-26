<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateStudent.aspx.cs" Inherits="WebApplicationCRUD.UpdateStudent" %>
<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

    <asp:Label ID="Label1" runat="server" Text="Enter Id"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" ForeColor="#FF3300" ValidationGroup="vg">Enter valid student Id</asp:RequiredFieldValidator><br />


    <asp:Label ID="Label2" runat="server" Text="Emter Name to Update"></asp:Label>

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter your Updated data" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>
            <br />

    <asp:Button ID="Button1" runat="server" Text="UpdateStudent" OnClick="Button1_Click" ValidationGroup="vg" />

</div>



</asp:Content>