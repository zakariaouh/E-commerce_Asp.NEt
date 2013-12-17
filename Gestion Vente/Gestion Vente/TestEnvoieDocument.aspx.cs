using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_Vente
{
    public partial class TestEnvoieDocument : System.Web.UI.Page
    {
        public static List<String> galerie = new List<string>();
        public static List<String> clients = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("Images") + "/" + FileUpload1.FileName);
            galerie.Add("Images/" + FileUpload1.FileName);
            clients.Add(Request.UserHostAddress);
            visualiser();
        }

        void visualiser()
        {
            d.InnerHtml = "";
            foreach (string image in galerie)
            {
                d.InnerHtml += "<img src='" + image + "' width='200px' height='200px'/>";
            }
        }
    }
}