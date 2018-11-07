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
            
            if (Session["sesion"] != null)
            {
                Server.Transfer(".\\Menu.aspx");
            }

            db = (BaseDatos)Session["db"];
        }



        protected void iniciar_Click(object sender, EventArgs e)
        {
            if (db.EstaUsuario(user.Text)){
                Usuario u = db.GetUsuario(user.Text);
                if (u.ComprobarContrasena(pass.Text))
                {
                    Session["sesion"] = u;
                    Server.Transfer(".\\Menu.aspx");
                }
                else
                {
                    error.Text = "El usuario no existe o las contraseñas no coinciden.";
                }
            }
            else
            {
                error.Text = "El usuario no existe o las contraseñas no coinciden.";
            }
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Seleccionar.aspx");
        }
    }
}