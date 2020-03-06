<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationFunctionHall._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
      
        <div class="col-md-4">
            <h2>FUNCTION HALL</h2>
            <p>
                You can easily find a fuctionhall by search wihth functionhall id and get details
            </p>
         
               <p>
                <a class="btn btn-default" href="InsertFhall.aspx">ADD HALL &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="DisplayHall.aspx">Show All &raquo;</a>
            </p>
             <p>
                <a class="btn btn-default" href="Search.aspx">Search HALL &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
