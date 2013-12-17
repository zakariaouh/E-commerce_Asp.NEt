using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_Vente
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           d.InnerHtml = "<table border='1'><tr><td>image</td><td>adresse IP</td></tr>";
            for (int i = 0; i < TestEnvoieDocument.galerie.Count; i++)
            {
                d.InnerHtml += "<tr><td><img src='" + TestEnvoieDocument.galerie[i] + "' width='200px' height='200px'/></td><td>" + TestEnvoieDocument.clients[i] + "</td><tr>";
            }
            d.InnerHtml += "</table>";
        }

    }
}