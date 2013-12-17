using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_Vente
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            HttpCookie cookie;
            cookie = Request.Cookies["VinciEAnnence"];

            String user = "";
            user = (string)Session["login"];
            if (cookie != null)
            {
               
                loginlabel.Text = cookie["login"];
                connecterdiv.Visible = true;
                nonconnecterdiv.Visible = false;

            }
            else if (!"".Equals(user) & user != null)
            {

                loginlabel.Text = user;
                connecterdiv.Visible = true;
                nonconnecterdiv.Visible = false;
            }
            else
            {
                connecterdiv.Visible = false;
                nonconnecterdiv.Visible = true;
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string textbo = rechercherTXT.Text.Replace(" ", "+");
            string ch = "http://www.google.com//search?as_q=" + textbo;
            if (CheckBox1.Checked)
            {
                ch = ch + "&as_sitesearch=www.avito.ma";

            }
            //Button1.Attributes.Add("onclick", "window.open('" + ch + "')");
            Response.Redirect(ch);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie;

            cookie = new HttpCookie("VinciEAnnence");
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }
            Session["login"] = "";
            Response.Redirect("Accueil.aspx");
        }
        protected string LiListe() { 
        
        /*
          <ul>  
                                    <%
                                        for (int i = 0; i < 10; i++)
                                      { %>                                        
                                       <li class='last'><a href='#'><span>Contact<%=i %></span></a></li>
                                       <%} %>
                                    </ul>  
        */
            return null;
        }
    }
}