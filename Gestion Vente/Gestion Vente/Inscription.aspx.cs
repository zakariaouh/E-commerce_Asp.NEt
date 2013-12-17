using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.Net;
namespace Gestion_Vente
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate_Click(object sender, EventArgs e)
        {
            
            if (this.IsValid && CheckBox1.Checked)
            {
              //  CaptchaControl1.ValidateCaptcha(txtCaptcha.Text);
               // if (CaptchaControl1.UserValidated)
               // {
              /*  try
                {*/
                    SqlConnection cnx = new SqlConnection("data source=.;initial catalog=ECommerce_DB;integrated security=yes");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandText = "insert into Client values(@p1,@p2,@p3,@p4,getdate(),0,0)";
                    cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = txtLogin.Text;
                    cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = txtPwd.Text;
                    cmd.Parameters.Add("@p3", SqlDbType.VarChar).Value = txtNom.Text;
                    cmd.Parameters.Add("@p4", SqlDbType.VarChar).Value = txtEmail.Text;

                    cnx.Open();
                    cmd.ExecuteNonQuery();
               /* }
                catch (Exception ex) { 
                
                }*/


              envoiEmail(txtEmail.Text);

                  Response.Redirect("~/Confirmation.aspx");


                //}


            }
            else
            {
                CustomValidator val = new CustomValidator();

                val.IsValid = false;
                val.ErrorMessage = "veuillez accepter le contrat!";

                this.Page.Validators.Add(val);
            }
        }
        void envoiEmail(string des)
        {
            string dic = "ABCDEFGHIGKLMNOPQRSTUVWXYZ0123456789";
            string code = "";
            Random rd = new Random();
            for (int i = 0; i < 8; i++)
                code += dic[rd.Next(0, 35)];
            String Body = "Bonjour Mr " + txtNom.Text + "\nveuillez confirmer votre inscription en utilisant le lien suivant \n";
            Body += "http://localhost:3482//Confirmation2.aspx?email=" + des + "&code=" + code;

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("trainerofaspnet@gmail.com", "az1234321"),
                EnableSsl = true
            };
            try
            {
                client.Send("trainerofaspnet@gmail.com", des, "Confirmation inscription E-Commerce", Body);
            }catch(Exception ex){
                Response.Write("Echec Envoie de mail à " + des+"<br>"+ex.Message);
            }

           
         

            //
            SqlConnection cnx = new SqlConnection("data source=.;initial catalog=ECommerce_DB;integrated security=yes");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into ValidationMail values(@p1,@p2)";
            cmd.Parameters.Add("@p1", SqlDbType.VarChar).Value = des;
            cmd.Parameters.Add("@p2", SqlDbType.VarChar).Value = code;
            cnx.Open();
            cmd.ExecuteNonQuery();
            //

         


        }

        protected void Annuler_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Authentification.aspx");
        }
    }
}