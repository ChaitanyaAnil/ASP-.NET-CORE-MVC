<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationCRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 >STUDENT COURSE FACULTY </h1>
        <h2>CRUD OPERATIONS USING ASP.NET WEB FORMS</h2>
    <nav class="navbar">
     <div class="jumbotron">
         <h3>CREATE</h3>
        <a class="navbar-brand" href="AddStudent.aspx"> Add student &raquo;</a>
        <a class="navbar-brand" href="AddCourse.aspx">Add course &raquo; </a>
        <a class="navbar-brand" href="AddFaculty.aspx">Add faculty&raquo;</a>
         </div>
        <div class="jumbotron">
            <h3>READ</h3>
           <a class="navbar-brand" href="DisplayAll.aspx">All  student details &raquo;</a>
             <a class="navbar-brand" href="DisCourse.aspx">All  course details &raquo;</a>
             <a class="navbar-brand" href="DisFaculty.aspx">All  faculty details &raquo;</a>
            </div>
            <div class="jumbotron">
                       
        <a class="navbar-brand" href="SearchStudent.aspx">Search student &raquo; </a>
          <a class="navbar-brand" href="FindCourse.aspx">Search course &raquo; </a>
          <a class="navbar-brand" href="FindFaculty.aspx">Search faulty &raquo; </a>
                </div>
        <div class="jumbotron">
                   <h3>UPDATE</h3>
        <a class="navbar-brand" href="UpdateStudent.aspx">Update student&raquo;</a>
             <a class="navbar-brand" href="UpdateCourse.aspx">Update course&raquo;</a>
             <a class="navbar-brand" href="UpdateFaculty.aspx">Update facuty&raquo;</a>
            </div>
            <div class="jumbotron">
                       <h3>DELETE</h3>
           <a class="navbar-brand" href="DeleteStudent.aspx"> Delete student &raquo;</a>
        <a class="navbar-brand" href="DelCourse.aspx">Delete course &raquo; </a>
        <a class="navbar-brand" href="DelFaculty.aspx">Delete faculty&raquo;</a>
                </div>
    </nav>

   
        </div>
        

</asp:Content>
