using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace www
{
    public partial class ActDesactEnc : System.Web.UI.Page
    {

        BaseDatos db;
        Encuesta encuestaActiva;
        ListItem a;

        List<ListItem> itemsEncuestasSel = new List<ListItem>();
        protected void Page_Load(object sender, EventArgs e)
        {
            db = (BaseDatos)Session["db"];
            if (!IsPostBack)
            {
                Enc.DataSource = (List<ListItem>)Session["itemsEncuestas"];
                Enc.DataBind();
            }
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            a = Enc.SelectedItem;
            db.GetEncuesta(a.Text).ActivarDesactivarEncuesta();

            if (!IsPostBack)

            {
                itemsEncuestasSel = new List<ListItem>();
                itemsEncuestasSel.Add(new ListItem("Vacio", "0"));
                foreach (Encuesta en in db.EncuestasActivas())
                {
                    itemsEncuestasSel.Add(new ListItem(en.Nombre, en.Descripcion));
                }
                Session["itemsEncuestasSel"] = null;
                //Session["itemsEncuestasSel"] = itemsEncuestasSel;
                Session["firsttimeuser"] = true;
            }

            Server.Transfer(".\\Menu.aspx");
        }

        
        protected void Enc_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Enc.SelectedItem;

            if (a.Text != "Vacio")
            {
                encuestaActiva = db.GetEncuesta(a.Text);

                if (encuestaActiva.Activo())
                {
                    Estado.Text = "Activa";
                    Aceptar.Text = "Desactivar";
                }
                else
                {
                    Estado.Text = "Desactiva";
                    Aceptar.Text = "Activar";
                }
            }
            else
            {
                Session["encuestaActiva"] = null;
                Estado.Text = "Seleccione Encuesta";
            }
        }
    }
}