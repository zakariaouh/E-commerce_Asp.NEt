using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Gestion_Vente
{
    public partial class PoserArticle : System.Web.UI.Page
    {
        List<string> images = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie;
            cookie = Request.Cookies["VinciEAnnence"];

            String user = "";
            user = (string)Session["login"];
            if (cookie != null)
            {

                Session["login"] = cookie["login"];
                
            }
            else if (!"".Equals(user) & user != null)
            {

               
            }
            else
            {
               
                Response.Redirect("Authentification.aspx");
            }
         
        }

        protected void Envoyer_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnx = new SqlConnection("data source=.;initial catalog=ECommerce_DB;integrated security=yes");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Article values(@p1,@p2,@p3,getdate(),@p5,@p6,@p7,@p8,@p9,@p10);select max(num) from Article";
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = titreAnn.Text;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = desc.Text;
            cmd.Parameters.Add("@p3", SqlDbType.VarChar).Value = prix.Text;
            cmd.Parameters.Add("@p5", SqlDbType.VarChar).Value = nom.Text;
            cmd.Parameters.Add("@p6", SqlDbType.VarChar).Value = email.Text;
            cmd.Parameters.Add("@p7", SqlDbType.VarChar).Value = telephone.Text;
            cmd.Parameters.Add("@p8", SqlDbType.VarChar).Value = categorie.SelectedIndex;                   
            cmd.Parameters.Add("@p9", SqlDbType.VarChar).Value = Session["login"];
            cmd.Parameters.Add("@p10", SqlDbType.VarChar).Value = ville.SelectedIndex;  
           
            cnx.Open();
            int num = (int)cmd.ExecuteScalar();
            if (Session["img"] != null &!"".Equals(Session["img"]))
            {
                images = (List<string>)Session["img"];
                
                cmd.CommandText = "insert into photo values(@p1,@p2)";
                foreach (string s in images)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = num;
                    cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = s;
                    cmd.ExecuteNonQuery();
                }
                cnx.Close();
            }
            Session["img"] = "";
            Response.Redirect("Accueil.aspx");
        }
        protected void Visualiser_Click(object sender, EventArgs e)
        {
            if (Session["img"] != null & !"".Equals(Session["img"]))
                images = (List<string>)Session["img"];

            FileUpload1.SaveAs(Server.MapPath("Images") + "/" + FileUpload1.FileName);
            images.Add(FileUpload1.FileName);
            Session["img"] = images;
            //
            preview.InnerHtml = "";
            int i = -1;
            foreach (string s in images)
            {
                if (++i % 3 == 0)
                    preview.InnerHtml += "<br/>";
                preview.InnerHtml += "<img src='Images/" + s + "' style='width:150px;height:150px'/>";
            }




            
        }
    }
}