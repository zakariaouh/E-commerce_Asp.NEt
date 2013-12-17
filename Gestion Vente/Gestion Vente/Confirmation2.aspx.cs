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
    public partial class Confirmation2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("data source=.;initial catalog=ECommerce_DB;integrated security=yes");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "select count(*) from ValidationMail where email=@p1 and code=@p2";
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value =Request.QueryString["email"] ;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = Request.QueryString["code"];
            cnx.Open();
            int nb = (int)cmd.ExecuteScalar();
            if (nb == 1)
            {
                Label1.Text = "Merci d'avoir confirmé votre enregistrement ";
                cmd.CommandText = "update Client set enabled=1 where email=@p1";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = Request.QueryString["email"];
                cmd.ExecuteNonQuery();
            }
            else{
                Label1.Text = "informations incorrectes";
          Label1.ForeColor=System.Drawing.Color.Red;
            }
        
        }
    }
}