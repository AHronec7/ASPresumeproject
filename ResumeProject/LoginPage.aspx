<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ResumeProject.LoginPage" %>
<asp:Content ID="Content1"  ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">

    

    <p>
        &nbsp;


    </p>


    <div>
    <asp:Label ID="UsernameLabel" runat="server" Text="Username"></asp:Label>


   <br />


    
    <asp:TextBox ID="TextBox1" class="login" runat="server" Width="143px"></asp:TextBox>

    </div>


    <br />

  
    


      <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>

    <br />

    


     <asp:TextBox ID="TextBox2" class="login" runat="server" Width="146px"></asp:TextBox>




    <br />


    <br />




    <asp:Button ID="Button1" Class="Btncolor" runat="server" Text="Submit Password" OnClick="Button1_Click" />



</asp:Content>
