using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class Resultados : System.Web.UI.Page
    {

        BaseDatos db;
        Encuesta encuestaActiva;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = (BaseDatos)Session["db"];
            if (!IsPostBack)
            {

                Enc.DataSource = (List<ListItem>)Session["itemsEncuestas"];
                Enc.DataBind();

                /*
                foreach (Encuesta en in db.EncuestasActivas())
                {
                    itemsResultados.Add(new ListItem(en.Nombre, en.Descripcion));
                }

                Enc.DataSource = itemsEncuestas;
                Enc.DataBind();
                */
            }
        }

        ListItem a;
        protected void Enc_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Enc.SelectedItem;

            if (a.Text != "Vacio")
            {
                encuestaActiva = db.GetEncuesta(a.Text);
                result.Text = encuestaActiva.Puntuacion.ToString();
            }
            else
            {
                Session["encuestaActiva"] = null;
                result.Text = "Seleccione Encuesta";
            }
        }
    }
}