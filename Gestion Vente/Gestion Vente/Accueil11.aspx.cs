using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_Vente
{
    public partial class Accueil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Label1.Text = "" + ((int)Application["nb"]);
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.PageSize = int.Parse(DropDownList1.SelectedValue);
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Response.Redirect("webform2.aspx?idannonce=" + GridView1.SelectedValue);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            //  Label1.Text = "" + ((int)Application["nb"]);
        }
    }
}