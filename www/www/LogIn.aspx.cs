using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class LogIn : System.Web.UI.Page
    {
        BaseDatos db;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["sesion"] != null)
            {
                Server.Transfer(".\\Menu.aspx");
                
            }

            db = (BaseDatos)Session["db"];
        }



        protected void iniciar_Click(object sender, EventArgs e)
        {
            if (db.EstaUsuario(user.Text){

            }
        }
    }
}