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
            


            if (!IsPostBack)
            {

                Session["encuestaActiva"] = null;
                Session["sesion"] = null;

                itemsEncuestas.Add(new ListItem("Vacio", "0"));
                foreach (Encuesta en in db.EncuestasActivas())
                {
                    itemsEncuestas.Add(new ListItem(en.Nombre, en.Descripcion));
                }

                enc.DataSource = itemsEncuestas;
                enc.DataBind();
            }
        }

        

        ListItem a;
        protected void Verdesc_Click(object sender, EventArgs e)
        {
            a = enc.SelectedItem;
            
            if(a.Text != "Vacio")
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer(".\\LogIn.aspx");
        }
    }
}