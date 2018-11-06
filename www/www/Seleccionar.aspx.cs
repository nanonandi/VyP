using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

namespace www
{
    public partial class Seleccionar : System.Web.UI.Page
    {
        List<ListItem> itemsEncuestas = new List<ListItem>();
        List<ListItem> itemsEncuestasSel = new List<ListItem>();

        BaseDatos db;
        Encuesta encuestaActiva;

        protected void Page_Load(object sender, EventArgs e)
        {

            if(Session["sesion"] != null)
            {
                Iniciar.Text = "menu";
            }

            db = (BaseDatos)Session["db"];
            if (db == null)
            {
                db = new BaseDatos();
                Session["db"] = db;
            }


            //Session["sesion"];
            //Session["encuestaActiva"];


            if (!IsPostBack)

            {


                if (Session["firsttimeuser"] == null)
                {
                    itemsEncuestasSel.Add(new ListItem("Vacio", "0"));
                    itemsEncuestas.Add(new ListItem("Vacio", "0"));
                    foreach (Encuesta en in db.EncuestasActivas())
                    {
                        itemsEncuestas.Add(new ListItem(en.Nombre, en.Descripcion));
                        itemsEncuestasSel.Add(new ListItem(en.Nombre, en.Descripcion));
                    }

                    Session["itemsEncuestas"] = itemsEncuestas;
                    Session["itemsEncuestasSel"] = itemsEncuestasSel;
                    Session["firsttimeuser"] = true;
                }


                Enc.DataSource = (List<ListItem>)Session["itemsEncuestasSel"];
                Enc.DataBind();
            }
        }


        protected void AccEncuesta_Click(object sender, EventArgs e)
        {
            if(Session["encuestaActiva"] != null)
            {
                Server.Transfer(".\\Votar.aspx");
            }
            else
            {
                error.Text = "Seleccione una encuesta";
            }
        }

        protected void Iniciar_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\LogIn.aspx");
        }

        ListItem a;
        protected void Enc_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Enc.SelectedItem;

            if (a.Text != "Vacio")
            {
                Session["encuestaActiva"] = db.GetEncuesta(a.Text);
                encuestaActiva = (Encuesta)Session["encuestaActiva"];
                desctext.Text = encuestaActiva.Descripcion;
            }
            else
            {
                Session["encuestaActiva"] = null;
                desctext.Text = "(Descripcion)";
            }
        }
    }
}