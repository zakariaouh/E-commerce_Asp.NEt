<%@ Page Title="" Language="C#" MasterPageFile="~/MyPageMaster.Master" AutoEventWireup="true" CodeBehind="PoserArticle.aspx.cs" Inherits="Gestion_Vente.PoserArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Nouveau Article</title>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Poster un article</h1>
<fieldset> <legend>informations article</legend>
  <table >
        <tr>
		<td > <label> nom</label> </td>
		<td><asp:TextBox ID="nom" runat="server"></asp:TextBox> </td>
		<td>&nbsp;</td>
        </tr>		
        <tr>
		<td ><label>Email</label></td>
		<td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
		<td>&nbsp;</td>
        </tr>
        <tr>
		<td ><label for="item-phone">Téléphone</label></td>
		<td><asp:TextBox ID="telephone" runat="server"></asp:TextBox></td>
		<td>&nbsp;</td>
        </tr>
        <tr>
        <td ><label for="item-location">Ville</label> </td>
        <td><asp:DropDownList ID="ville" runat="server" DataSourceID="SqlDataSource1" 
                DataTextField="nom" DataValueField="idv"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ECommerce_DBConnectionString %>" 
                SelectCommand="SELECT * FROM [Ville]"></asp:SqlDataSource></td>
        <td></td>
        </tr>
          <tr>
		  <td ><label for="item-category">Catégorie</label> </td>
        <td><asp:DropDownList ID="categorie" runat="server" 
                DataSourceID="SqlDataSource2" DataTextField="nom" DataValueField="nom" 
                AutoPostBack="True"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ECommerce_DBConnectionString %>" 
                SelectCommand="SELECT [nom] FROM [Categorie]"></asp:SqlDataSource></td>
        <td></td>
		</tr>
          <tr>
        <td >
        <label for="item-title">
        Titre de l&#39;annonce</label> </td>
        <td><asp:TextBox ID="titreAnn" runat="server"></asp:TextBox></td>
        <td></td>
        </tr>
          <tr>
        <td >
        <label for="item-description">
        Déscription de l&#39;annonce</label></td>
        <td><asp:TextBox ID="desc" runat="server" Height="117px" TextMode="MultiLine" 
                Width="200px"></asp:TextBox></td>
        <td></td>
        </tr>
          <tr>
        <td >Prix</td>
        <td><asp:TextBox ID="prix" runat="server"></asp:TextBox></td>
        <td></td>
        </tr>
          <tr>
        <td >Photos</td>
        <td>
           
              <asp:FileUpload ID="FileUpload1" runat="server" />    
              <asp:Button ID="Visualiser" runat="server" CausesValidation="False"         
                  Text="Visualiser" onclick="Visualiser_Click"  />        <br />        <span id="preview" runat="server"></span>
           <br /></td>
        <td>&nbsp;</td>
        </tr>
        <tr>
        <td></td>
        <td><asp:Button ID="Envoyer" runat="server" Text="Envoyer" 
                Width="111px" onclick="Envoyer_Click" /></td>
        <td></td>
        </tr>
    </table></fieldset>
</asp:Content>
