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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Connection_Click(object sender, EventArgs e)
        {
            if (IsValid) {

                SqlConnection cnx = new SqlConnection("data source=.;initial catalog=ECommerce_DB;integrated security=yes");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "select count(*) from Client where login=@p1 and pwd=@p2 and enabled=1";
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = login.Text;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = pwd.Text;
            cnx.Open();
            int nb = (int)cmd.ExecuteScalar();
            cmd.CommandText = "select count(*) from Client where login=@p1 and pwd=@p2 ";
           
            int nb2 = (int)cmd.ExecuteScalar();
                
            if (nb == 1)
            {

                if (CheckBox1.Checked)
                {
                    HttpCookie cookie;

                    cookie = new HttpCookie("VinciEAnnence");
                    cookie.Values.Add("login", login.Text);
                    Response.Cookies.Add(cookie);

                }
                else
                {
                    Session["login"] = login.Text;
                }
                Response.Redirect("Accueil.aspx");

            }
            else
            {CustomValidator val = new CustomValidator();

                val.IsValid = false;
                String errmsg = "Combinaison Nom utilisateur/mot de passe incorrecte";
                if (nb2 == 1)
                {
                    errmsg = "Veuillez valider votre adresse courriel!";
                }
                
                val.ErrorMessage = errmsg;

                this.Page.Validators.Add(val);
            }
            }

        }

    }
}