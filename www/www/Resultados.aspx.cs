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
        List<ListItem> itemsEncuestas = new List<ListItem>();
        List<ListItem> itemsResultados = new List<ListItem>();
        BaseDatos db;
        Encuesta encuestaActiva;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = (BaseDatos)Session["db"];
            if (!IsPostBack)
            {

                itemsEncuestas.Add(new ListItem("Vacio", "0"));
                foreach (Encuesta en in db.EncuestasActivas())
                {
                    itemsEncuestas.Add(new ListItem(en.Nombre, en.Descripcion));
                }

                Enc.DataSource = itemsEncuestas;
                Enc.DataBind();

                foreach (int re in db)
                {
                    itemsResultados.Add(new ListItem(en.Nombre, en.Descripcion));
                }

                Enc.DataSource = itemsEncuestas;
                Enc.DataBind();
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
                result.Text = "(Descripcion)";
            }
        }
    }
}