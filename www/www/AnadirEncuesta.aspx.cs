using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class AnadirEncuesta : System.Web.UI.Page
    {

        BaseDatos db;
        Encuesta en;
        bool bol;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sesion"] == null)
            {
                Server.Transfer(".\\Seleccionar.aspx");
            }

            db = (BaseDatos)Session["db"];
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            if (bool.TryParse(Radio.SelectedValue, out bool sali))
            {

                if(Nombre.Text == "")
                {
                    Errorlab.Text = "Ponle un nombre a la encuesta";
                }
                else
                {
                    bol = sali;

                    en = new Encuesta(Nombre.Text, Descripcion.InnerText, bol);
                    db.GuardarEncuesta(en);

                    Server.Transfer(".\\Menu.aspx");

                }
            }
            else
            {
                Errorlab.Text = "Selecciona activa o desactiva";
            }

        }

        

        protected void Volver_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Menu.aspx");
        }


    }
}