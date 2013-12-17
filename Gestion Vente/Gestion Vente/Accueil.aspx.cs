using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_Vente
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            SqlConnection cnx = new SqlConnection("data source=.;initial catalog=ECommerce_DB;integrated security=yes");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;



            String sql = "SELECT distinct TOP 12 Article.num,Article.Titre,Article.Descrption,Article.prix,Article.datArticle,Photo.nom as photo FROM ECommerce_DB.dbo.Article,ECommerce_DB.dbo.Photo where Photo.numArticle=Article.num";
            string categorie = Request.QueryString["categorie"];
            if (categorie != null & !"".Equals(categorie)) { sql += " and Article.IDCat=(SELECT IDCat  FROM ECommerce_DB.dbo.Categorie where Categorie.nom like '%" + categorie + "%')"; }
            
            cmd.CommandText = sql;
            cnx.Open();
            var reader = cmd.ExecuteReader();
            BodyAcc.InnerHtml = " <table>";
            int count = 1;
            while (reader.Read())
            {
                String Articlenum = reader["num"] + "";
                String ArtTitre = reader["Titre"] + "";
                String ArtPrix = reader["prix"] + "";
                String Artdate = reader["datArticle"] + "";
                String photo = reader["photo"] + "";




               
               
                if (count %2!=0)
                {
                    BodyAcc.InnerHtml += "<tr><td> <div class='Produitcssdiv'><center> "
                                        + "<a href='#'><img src='Images/"+photo+"' width='160' height='120'></a><br/>"
                                        + ArtTitre + "<br/> Prix:" + ArtPrix + "dh </center></div> </td>";
                   
                }
                else {
                    BodyAcc.InnerHtml += "<td> <div class='Produitcssdiv'><center> "
                                        + "<a href='#'><img src='Images/"+photo+"' width='160' height='120'></a><br/>"
                                        + ArtTitre + "<br/> Prix:" + ArtPrix + "dh </center></div> </td></tr>";
                }

                count++;
            }
           
           
                 BodyAcc.InnerHtml +="</table>";
        }
    }
}