
<%@ Page Title="" Language="C#" MasterPageFile="~/MyPageMaster.Master" AutoEventWireup="true" CodeBehind="Inscription.aspx.cs" Inherits="Gestion_Vente.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<title>Inscription</title>
    <style type="text/css">
     
        .style2
        {
            width: 960px;
            height: 35px;
            
        }
        
    
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <div class="accountInfo">
<h1>Inscription</h1>
<fieldset> <legend>Information Compte</legend>
        <table>
            <tr>
                <td class="style2">
                    Nom</td>
                <td class="style2">
                    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtNom" ErrorMessage="requis (*)">(1)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    login</td>
                <td class="style2">
                    <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                </td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtLogin" ErrorMessage="requis (*)">(2)</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    password</td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtPwd" ErrorMessage="requis (*)">(3)</asp:RequiredFieldValidator>
                </td>
            </tr>
                        <tr>
                <td class="style2">
                    confirmation password</td>
                <td>
                    <asp:TextBox ID="txtConfirm" runat="server"></asp:TextBox>
                            </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtPwd" ControlToValidate="txtConfirm" 
                        ErrorMessage="password non identique">(4)</asp:CompareValidator>
                            </td>
            </tr>
                        <tr>
                <td class="style2">
                    email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                            </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="format incorrect" 
                        ValidationExpression="\w+([.-]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">(5)</asp:RegularExpressionValidator>
                            </td>
            </tr>
                        <tr>
                <td class="style2">
                    Contrat</td>
                <td>
                   
                 <a href="contrat.aspx">lire contrat</a>
                    <br />
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="j'ai lu et j'accepte" />
                   
                            </td>
                <td>
                    &nbsp;</td>
            </tr>
                        <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Validate" runat="server" Text="Valider" 
                        onclick="Validate_Click" />
                    <asp:Button ID="Annuler" runat="server" Text="Annuler"  class="css3button"
                        onclick="Annuler_Click" />
                            </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>        

</fieldset>
<br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</div>
</asp:Content>
