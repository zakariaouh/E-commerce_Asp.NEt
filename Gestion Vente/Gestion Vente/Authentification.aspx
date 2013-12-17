<%@ Page Title="" Language="C#" MasterPageFile="~/MyPageMaster.Master" AutoEventWireup="true" CodeBehind="Authentification.aspx.cs" Inherits="Gestion_Vente.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Authentification</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="accountInfo">
<h1>Connection</h1>
Veuillez entrer votre nom d'utilisateur et votre mot de passe 
       <a href="Inscription.aspx" ID="HeadLoginStatus" runat="server"> Inscription </a>si vous n'avez pas un compte.
<fieldset> <legend>Information Compte</legend>
    <p> <asp:Label ID="Label1" runat="server" Text="Label">Nom utilisateur:</asp:Label><br />
  <asp:TextBox ID="login" runat="server" Width="236px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="login" ErrorMessage="Champ obligatoire" ForeColor="Red">*</asp:RequiredFieldValidator>
    </p>
    <p>  <asp:Label ID="Label2" runat="server" Text="Label">Mot de passe:</asp:Label><br />
     <asp:TextBox ID="pwd" runat="server" Width="236px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="pwd" ErrorMessage="Champ obligatoire" ForeColor="Red">*</asp:RequiredFieldValidator>
  </p>
  <p>   <asp:CheckBox ID="CheckBox1" runat="server" />Garder ma session active</p>
   
    <p><asp:Button ID="Connection" runat="server" Text="Connection" Class="connection" 
            onclick="Connection_Click"/></p>

 </fieldset>

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" 
            Width="573px" />

 </div>
 <br />
 <br />
<br />
<br />
<br />
<br />
</asp:Content>
