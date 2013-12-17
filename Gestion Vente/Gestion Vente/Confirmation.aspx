<%@ Page Title="" Language="C#" MasterPageFile="~/MyPageMaster.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="Gestion_Vente.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Confirmation email</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="height:700px">
<h1>Confirmation email</h1>
    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold=true ForeColor=Green>un email de confirmation vient de vous être envoyé</asp:Label>
</div>
</asp:Content>
