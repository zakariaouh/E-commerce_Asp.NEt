<%@ Page Title="" Language="C#" MasterPageFile="~/MyPageMaster.Master" AutoEventWireup="true" CodeBehind="Accueil11.aspx.cs" Inherits="Gestion_Vente.Accueil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Accueil</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
       <br />
        <br />
        <br />
        Changer le nombre de résultats par page&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" 
            AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="5"></asp:ListItem>
            <asp:ListItem Value="10"></asp:ListItem>
            <asp:ListItem Value="15"></asp:ListItem>
        </asp:DropDownList>
        <hr />
        <br />
        <asp:GridView ID="GridView1" runat="server" width="62%" 
            AutoGenerateColumns="False" DataKeyNames="num" 
            DataSourceID="SqlDataSource1" AllowPaging="True" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" PageSize="5" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="num" HeaderText="num" 
                    SortExpression="num" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="Titre" HeaderText="Titre" SortExpression="Titre" />
                <asp:BoundField DataField="prix" HeaderText="prix" SortExpression="prix" />
                <asp:BoundField DataField="datArticle" HeaderText="datArticle" 
                    SortExpression="datArticle" />
                <asp:BoundField DataField="nom" HeaderText="nom" SortExpression="nom" />
                <asp:BoundField DataField="nom1" HeaderText="nom1" SortExpression="nom1" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ECommerce_DBConnectionString %>" 
            SelectCommand="SELECT * FROM [Statistique]">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ECommerce_DBConnectionString %>" 
            
            SelectCommand="SELECT [Article].[num], [Article].[Titre], [Article].[prix], [Article].[datArticle], [Article].[nom],[Categorie].nom FROM [Categorie]  INNER JOIN Article ON Categorie.IDCat=Article.IDCat
INNER JOIN Photo ON Article.num = Photo.numArticle">
        </asp:SqlDataSource>
   
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <p style="text-align:center">
                    <asp:Timer ID="Timer1" runat="server" Interval="6000" ontick="Timer1_Tick">
                    </asp:Timer>
                    nombre de visiteurs actuellement connectés :<asp:Label ID="Label1" 
        runat="server" ForeColor="Red" ></asp:Label>
                </p>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
    
    </div>
</asp:Content>
