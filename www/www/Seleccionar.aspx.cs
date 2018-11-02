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

        BaseDatos db;
        Encuesta encuestaActiva;
        

        protected void Page_Load(object sender, EventArgs e)
        {

            

            db = (BaseDatos)Session["db"];
            if (db == null)
            {
                db = new BaseDatos();
                Session["db"] = db;
            }

            encuestaActiva = (Encuesta)Session["encuestaActiva"];


        if (!IsPostBack) {
                itemsEncuestas.Add(new ListItem("Vacio", "0"));
                foreach (Encuesta en in db.EncuestasActivas())
                {
                    itemsEncuestas.Add(new ListItem(en.Nombre, ((int)en.Id + 1).ToString()));
                }

                enc.DataSource = itemsEncuestas;
                enc.DataBind();
            }
        }

        

        protected void AccEncuesta_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\Votar.aspx");
        }

        ListItem a;
        protected void Verdesc_Click(object sender, EventArgs e)
        {
            a = enc.SelectedItem;
            
            if(a.Text != "Vacio")
            {
                encuestaActiva = db.GetEncuesta(a.Text);
                desctext.Text = encuestaActiva.Descripcion;
            }
            else
            {
                desctext.Text = "(Descripcion)";
            }
        }
    }
}