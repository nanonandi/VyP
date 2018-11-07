using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class Menu : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["sesion"] == null)
            {
                Server.Transfer(".\\Seleccionar.aspx");
            }
        }

        protected void Volver_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Seleccionar.aspx");
        }

        protected void end_Click(object sender, EventArgs e)
        {
            Session["sesion"] = null;
            Server.Transfer(".\\Seleccionar.aspx");
        }

        protected void Anadir_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\AnadirEncuesta.aspx");
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\ModificarEncuesta.aspx");
        }

        protected void ActDes_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\ActDesactEnc.aspx");
        }

        protected void Result_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Resultados.aspx");
        }
    }
}